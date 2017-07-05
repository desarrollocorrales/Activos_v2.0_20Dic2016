using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;
using Activos.GUIs.Responsivas;

namespace Activos.GUIs.Reportes
{
    public partial class frmTraspasosRealizados : Form
    {
        IResponsivasNegocio _responsivasNegocio;
        IActivosNegocio _activosNegocio;
        ICatalogosNegocio _catalogosNegocio;

        Modelos.Traspasos _traspasoSel;

        public frmTraspasosRealizados()
        {
            InitializeComponent();

            this._responsivasNegocio = new ResponsivasNegocio();
            this._activosNegocio = new ActivosNegocio();
            this._catalogosNegocio = new CatalogosNegocio();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.dtpFecha.Text))
                    throw new Exception("Seleccione una Fecha");

                string fecha = this.dtpFecha.Value.ToString("yyyy-MM-dd");

                List<Modelos.Traspasos> traspasos = this._responsivasNegocio.getTraspasos(fecha);

                if (traspasos.Count == 0)
                {
                    this.gcTraspasos.DataSource = null;
                    this.gcActivos.DataSource = null;
                    this._traspasoSel = null;
                    throw new Exception("Sin Resultados");
                }

                this.gcTraspasos.DataSource = traspasos;
                this.gridView1.BestFitColumns();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Traspasos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dtpFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnBuscar_Click(null, null);
            }
        }

        private void gcTraspasos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.gridView1.GetSelectedRows().Count() == 0)
                    return;

                this._traspasoSel = new Modelos.Traspasos();

                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    var dr1 = this.gridView1.GetRow(i);

                    this._traspasoSel = (Modelos.Traspasos)dr1;
                }

                List<Modelos.Activos> activos = this._activosNegocio.getActivosTras(this._traspasoSel.fecha, this._traspasoSel.consecTraspaso);

                if (activos.Count == 0)
                    throw new Exception("Sin Resultados");

                this.gcActivos.DataSource = activos;
                this.gridView2.BestFitColumns();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Traspasos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.gridView1.RowCount == 0) return;

                List<Modelos.Activos> activosImpre = new List<Modelos.Activos>();

                List<Modelos.Traspasos> traspasos =
                    ((List<Modelos.Traspasos>)this.gridView1.DataSource)
                    .Where(w => w.seleccionado == true)
                    .Select(s => s)
                    .ToList();

                string motivo = string.Empty;
                string personaAnt = string.Empty;
                string personaNva = string.Empty;
                string fecha = string.Empty;

                if (traspasos.Count > 0)
                {
                    // si se selecciono por casilla de verificacion los traspasos
                    foreach (Modelos.Traspasos tr in traspasos)
                    {
                        if (!string.IsNullOrEmpty(personaNva))
                        {
                            if (!personaNva.Equals(tr.personaNuevo) || !personaAnt.Equals(tr.personaAnt) || !motivo.Equals(tr.motivo))
                                throw new Exception("Las personas ni el motivo corresponden entre los traspasos seleccionados");
                        }

                        personaAnt = tr.personaAnt;
                        personaNva = tr.personaNuevo;
                        motivo = tr.motivo;
                        fecha = tr.fecha;

                        activosImpre.AddRange(this._activosNegocio.getActivosTras(tr.fecha, tr.consecTraspaso));
                    }
                }
                else
                {
                    if (this._traspasoSel == null)
                        throw new Exception("Seleccione un Traspaso");

                    // si solo se dio doble clin en un traspaso
                    activosImpre = this._activosNegocio.getActivosTras(this._traspasoSel.fecha, this._traspasoSel.consecTraspaso);

                    personaAnt = this._traspasoSel.personaAnt;
                    personaNva = this._traspasoSel.personaNuevo;
                    motivo = this._traspasoSel.motivo;
                    fecha = this._traspasoSel.fecha;
                }

                // abrir formulario
                frmReporteTraspasos form = new frmReporteTraspasos();

                form._empresa = Modelos.Login.empresa;
                form._logo = this._responsivasNegocio.obtieneLogo("reportes");
                form._activos = activosImpre;
                form._detalle = motivo;
                form._personaAnterior = personaAnt;
                form._personaNueva = personaNva;
                form._fecha = fecha;

                form.ShowDialog();

                string idActivos = string.Join(",", activosImpre.Select(s => s.idActivo).ToList());

                // bitacora
                this._catalogosNegocio.generaBitacora(
                    "Se genero la vista previa del informe de Traspaso, ACTIVOS: " + idActivos, "CONSULTAS");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Traspasos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
