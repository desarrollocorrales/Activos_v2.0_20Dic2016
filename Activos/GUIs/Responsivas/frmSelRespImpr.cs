using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.GUIs.Responsivas.Reporte;

namespace Activos.GUIs.Responsivas
{
    public partial class frmSelRespImpr : Form
    {
        Negocio.IResponsivasNegocio _responsivasNegocio;
        Negocio.IActivosNegocio _activosNegocio;
        Modelos.Responsivas _responsiva = new Modelos.Responsivas();
        List<Modelos.Responsivas> _responsivas = new List<Modelos.Responsivas>();
        List<Modelos.Activos> _activos = new List<Modelos.Activos>();
        Negocio.ICatalogosNegocio _catalogosNegocio;

        public frmSelRespImpr()
        {
            InitializeComponent();

            this._activosNegocio = new Negocio.ActivosNegocio();
            this._responsivasNegocio = new Negocio.ResponsivasNegocio();
            this._catalogosNegocio = new Negocio.CatalogosNegocio();
        }

        private void frmSelRespImpr_Load(object sender, EventArgs e)
        {
            try
            {
                this._responsivas = this._responsivasNegocio.getResponsivas("B");

                this.gcResponsivas.DataSource = this._responsivas;
                this.gridView1.BestFitColumns();

                this.ActiveControl = this.tbFiltro;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gcResponsivas_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.gridView1.GetSelectedRows().Count() == 0)
                    throw new Exception("No a seleccionado una responsiva");

                this._responsiva = new Modelos.Responsivas();

                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    var dr1 = this.gridView1.GetRow(i);

                    this._responsiva = (Modelos.Responsivas)dr1;
                }

                this._activos = this._activosNegocio.getBuscaActivos(this._responsiva.idResponsiva);

                this.tbRespDeSel.Text = this._responsiva.responsable;
                this.tbFolioSel.Text = this._responsiva.idResponsiva.ToString();
                
                this.gcActivos.DataSource = this._activos;
                this.gridView2.BestFitColumns();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Modelos.Responsivas> lstResponsivasAux = new List<Modelos.Responsivas>();

                int folio = 0; int.TryParse(this.tbFiltro.Text, out folio);

                lstResponsivasAux = 
                    this._responsivas
                        .FindAll(f => f.responsable.Contains(this.tbFiltro.Text.ToUpper()) ||
                                      Convert.ToString(f.idResponsiva).Contains(this.tbFiltro.Text) ||
                                      f.sucursal.Contains(this.tbFiltro.Text.ToUpper()) ||
                                      f.puesto.Contains(this.tbFiltro.Text.ToUpper()));

                this.gcResponsivas.DataSource = lstResponsivasAux;
                this.gridView1.BestFitColumns();
                Application.DoEvents();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._responsiva == null)
                    throw new Exception("Seleccione una responsiva");


                string fecIng = this.dtpFechaImpr.Value.ToString("dd-MM-yyyy");
                this._responsiva.fechaImpresion = fecIng;

                frmResponsivaReporte form = new frmResponsivaReporte();

                List<Modelos.Activos> activos = new List<Modelos.Activos>();

                // cambia activos
                foreach (Modelos.Activos ac in this._activos)
                {
                    string descripcion = ac.descripcion.Replace("&", ";");
                    string[] array = descripcion.Split(';');

                    descripcion = (!string.IsNullOrEmpty(array[0]) ? " Marca: " + array[0] + ";" : string.Empty) +
                                  (!string.IsNullOrEmpty(array[1]) ? " Modelo: " + array[1] + ";" : string.Empty) +
                                  (!string.IsNullOrEmpty(array[2]) ? " Núm. Serie: " + array[2] + ";" : string.Empty) +
                                  (!string.IsNullOrEmpty(array[3]) ? " Color: " + array[3] + ";" : string.Empty) +
                                  (!string.IsNullOrEmpty(array[4]) ? " Costo: " + array[4] + ";" : string.Empty) +
                                  (!string.IsNullOrEmpty(array[5]) ? " Factura: " + array[5] + ";" : string.Empty) +
                                  (!string.IsNullOrEmpty(array[6]) ? " \nDetalles: " + array[6] + ";" : string.Empty);

                    activos.Add(new Modelos.Activos
                    {
                        accion = ac.accion,
                        area = ac.area,
                        costo = ac.costo,
                        claveActivo = ac.claveActivo,
                        descripcion = descripcion.Trim(),
                        fechaAlta = ac.fechaAlta,
                        fechaModificacion = ac.fechaModificacion,
                        idActivo = ac.idActivo,
                        idArea = ac.idArea,
                        idTipo = ac.idTipo,
                        idUsuarioAlta = ac.idUsuarioAlta,
                        idUsuarioModifica = ac.idUsuarioModifica,
                        nombreCorto = ac.nombreCorto,
                        numEtiqueta = ac.numEtiqueta,
                        seleccionado = ac.seleccionado,
                        status = ac.status,
                        tipo = ac.tipo

                    });
                }

                // obtiene responsables
                List<Modelos.PersonaResponsivas> responsables = this._responsivasNegocio.obtieneResponsables(this._responsiva.idResponsiva);

                // obtiene logo
                Modelos.Logo logo = this._responsivasNegocio.obtieneLogo("reportes");

                form._logo = logo;
                form._responsables = responsables;
                form._activos = activos;
                form._responsivas = this._responsiva;

                form._empresa = Modelos.Login.empresa;

                form.Show();


                // bitacora
                this._catalogosNegocio.generaBitacora(
                    "Se generó la vista previa de la responsiva " + this._responsiva.idResponsiva + " - SELECCIONAR RESPONSIVA A IMPRIMIR", "RESPONSIVAS");

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
