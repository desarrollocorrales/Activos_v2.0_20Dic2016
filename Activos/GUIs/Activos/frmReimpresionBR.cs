using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;

namespace Activos.GUIs.Activos
{
    public partial class frmReimpresionBR : Form
    {
        ICatalogosNegocio _catalogosNegocio;
        IReparacionesNegocio _reparacionesNegocio;
        IActivosNegocio _activosNegocio;
        IResponsivasNegocio _responsivasNegocio;
        public Modelos.Bajas _activoSelBajas;
        public Modelos.Reparaciones _activoSelRepara;

        private List<Modelos.Activos> _activos = new List<Modelos.Activos>();
        private Modelos.ActivosDesc _activo;

        public frmReimpresionBR()
        {
            InitializeComponent();
            this._catalogosNegocio = new CatalogosNegocio();
            this._reparacionesNegocio = new ReparacionesNegocio();
            this._activosNegocio = new ActivosNegocio();
            this._responsivasNegocio = new ResponsivasNegocio();

            this.lbFecha.Location = new Point(8, 327);
            this.tbFecha.Location = new Point(77, 324);
        }

        private void frmReimpresionBR_Load(object sender, EventArgs e)
        {
            try
            {
                // permisos bajas responsivas
                // bajas = 69
                // reparacion = 70
                List<Modelos.MotivosBaja> motivos = this._catalogosNegocio.getMotivosBaja();

                if (Modelos.Login.permisos.Contains(69))
                {
                    if (!Modelos.Login.permisos.Contains(70))
                        motivos = motivos.Where(w => w.clave.Equals("B")).ToList();
                }
                else
                {
                    if (Modelos.Login.permisos.Contains(70))
                        motivos = motivos.Where(w => w.clave.Equals("R")).ToList();

                    else
                        motivos = motivos.Where(w => w.clave.Equals("A")).ToList();
                }

                // carga combo motivos
                this.cbMotivo.ValueMember = "idMotivoBaja";
                this.cbMotivo.DisplayMember = "motivo";
                this.cbMotivo.DataSource = motivos;

                // llenar combo de sucursales
                this.cmbSucursal.DisplayMember = "nombre";
                this.cmbSucursal.ValueMember = "idSucursal";
                this.cmbSucursal.DataSource = this._catalogosNegocio.getSucursales("A");
                this.cmbSucursal.SelectedIndex = -1;

                this.cbMotivo_SelectionChangeCommitted(null, null);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Reimpresión Bajas/Reparaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cbMotivo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (this.cbMotivo.SelectedIndex == -1) return;

                string clave = ((Modelos.MotivosBaja)this.cbMotivo.SelectedItem).clave;

                if (clave.Equals("B"))
                {
                    this.gcBajas.Visible = true;

                    this.lbFecha.Visible = true;
                    this.tbFecha.Visible = true;

                    this.lbCausObs.Text = "Observaciones";
                    this.tbCausaObserv.Size = new Size(523, 189);

                    this.lbObservAct.Visible = false;
                    this.tbObservAct.Visible = false;

                    this.lbFechaIni.Visible = false;
                    this.tbFechaIni.Visible = false;
                    this.lbFechaFin.Visible = false;
                    this.tbFechaFin.Visible = false;
                    this.gcReparaciones.Visible = false;
                }

                if (clave.Equals("R"))
                {
                    this.gcBajas.Visible = false;
                    this.lbFecha.Visible = false;
                    this.tbFecha.Visible = false;

                    this.lbCausObs.Text = "Causa";
                    this.tbCausaObserv.Size = new Size(252, 189);

                    this.lbFechaIni.Visible = true;
                    this.tbFechaIni.Visible = true;
                    this.lbFechaFin.Visible = true;
                    this.tbFechaFin.Visible = true;
                    this.gcReparaciones.Visible = true;

                    this.lbObservAct.Visible = true;
                    this.tbObservAct.Visible = true;

                }

                this._reiniciaControles();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Reimpresión Bajas/Reparaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void _reiniciaControles()
        {
            this.tbActivo.Text = string.Empty;
            this.tbFechaFin.Text = string.Empty;
            this.tbFecha.Text = string.Empty;
            this.tbFechaIni.Text = string.Empty;

            this.tbCausaObserv.Text = string.Empty;
            this.tbObservAct.Text = string.Empty;

            this.gcBajas.DataSource = null;
            this.gcReparaciones.DataSource = null;

            this._activo = null;
            this._activos = new List<Modelos.Activos>();
            this._activoSelBajas = null;
            this._activoSelRepara = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cbMotivo.SelectedIndex == -1)
                    throw new Exception("Seleccione un motivo");

                if (this.cmbSucursal.SelectedIndex == -1)
                    throw new Exception("Seleccione una sucursal");

                string clave = ((Modelos.MotivosBaja)this.cbMotivo.SelectedItem).clave;

                List<Modelos.Bajas> bajas = new List<Modelos.Bajas>();
                List<Modelos.Reparaciones> repara = new List<Modelos.Reparaciones>();

                int idSuc = ((Modelos.Sucursales)this.cmbSucursal.SelectedItem).idSucursal;

                if (clave.Equals("B"))
                {
                    bajas = this._reparacionesNegocio.getBajasSuc(idSuc);

                    if (bajas.Count == 0)
                        throw new Exception("Sin Resultados");

                    this.gcBajas.DataSource = bajas;
                    this.gridView2.BestFitColumns();
                }

                if (clave.Equals("R"))
                {
                    repara = this._reparacionesNegocio.getReparaciones(idSuc);

                    if (repara.Count == 0)
                        throw new Exception("Sin Resultados");

                    this.gcReparaciones.DataSource = repara;
                    this.gridView1.BestFitColumns();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Reimpresión Bajas/Reparaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gcBajas_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.gridView2.GetSelectedRows().Count() == 0)
                    return;

                this._activoSelBajas = new Modelos.Bajas();

                foreach (int i in this.gridView2.GetSelectedRows())
                {
                    var dr1 = this.gridView2.GetRow(i);

                    this._activoSelBajas = (Modelos.Bajas)dr1;
                }

                // seleccionar los activos
                this._activos = this._activosNegocio.getActivoSinEstatus((long)this._activoSelBajas.idActivo);

                // buscar los responsables y la sucursal
                this._activo = this._activosNegocio.getActivoDesc(this._activoSelBajas.idActivo);

                this.tbActivo.Text = this._activoSelBajas.activo;
                this.tbFecha.Text = this._activoSelBajas.fecha;
                this.tbCausaObserv.Text = this._activoSelBajas.observaciones;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Reimpresión Bajas/Reparaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gridView2_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.CadetBlue;
                e.Appearance.ForeColor = Color.White;
            }
        }

        private void gcReparaciones_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.gridView1.GetSelectedRows().Count() == 0)
                    return;

                this._activoSelRepara = new Modelos.Reparaciones();

                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    var dr1 = this.gridView1.GetRow(i);

                    this._activoSelRepara = (Modelos.Reparaciones)dr1;
                }

                // seleccionar los activos
                this._activos = this._activosNegocio.getActivoSinEstatus((long)this._activoSelRepara.idActivo);

                // buscar los responsables y la sucursal
                this._activo = this._activosNegocio.getActivoDesc(this._activoSelRepara.idActivo);

                this.tbActivo.Text = this._activoSelRepara.activo;
                this.tbFechaIni.Text = this._activoSelRepara.fechaInicio;
                this.tbFechaFin.Text = this._activoSelRepara.fechaFin;
                this.tbCausaObserv.Text = this._activoSelRepara.causa;
                this.tbObservAct.Text = this._activoSelRepara.observActivacion;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Reimpresión Bajas/Reparaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cbMotivo.SelectedIndex == -1)
                    throw new Exception("Seleccione un motivo");

                string clave = ((Modelos.MotivosBaja)this.cbMotivo.SelectedItem).clave;

                if (clave.Equals("B"))
                {
                    if (this._activoSelBajas == null)
                        throw new Exception("Seleccione un activo");

                    // manda a abrir el formulario de Reparacion
                    frmReporteBaja form = new frmReporteBaja();

                    form._activos = this._activos;
                    form._empresa = Modelos.Login.empresa;
                    form._logo = this._responsivasNegocio.obtieneLogo("reportes");

                    List<Modelos.PersonaResponsivas> res = new List<Modelos.PersonaResponsivas>();
                    res.Add(new Modelos.PersonaResponsivas { nombre = this._activo.usuario, sucursal = this._activo.sucursal });
                    form._responsables = res;

                    form._fecha = this._activoSelBajas.fecha;
                    form._movimiento = this._activoSelBajas.observaciones;

                    form.Show();

                    // bitacora
                    this._catalogosNegocio.generaBitacora(
                        "Se genero la vista previa del informe de Baja, ACTIVO: " + this._activoSelBajas.idActivo, "REIMPRESION ACTIVOS");
                }

                if (clave.Equals("R"))
                {
                    // manda a abrir el formulario de Reparacion
                    frmReporteRepara form = new frmReporteRepara();

                    form._activos = this._activos;
                    form._empresa = Modelos.Login.empresa;
                    form._logo = this._responsivasNegocio.obtieneLogo("reportes");

                    List<Modelos.PersonaResponsivas> res = new List<Modelos.PersonaResponsivas>();
                    res.Add(new Modelos.PersonaResponsivas { nombre = this._activo.usuario, sucursal = this._activo.sucursal });
                    form._responsables = res;

                    form._fecha = this._activoSelRepara.fechaInicio;
                    form._movimiento = this._activoSelRepara.causa;
                    form._activacion = this._activoSelRepara.observActivacion;

                    form.Show();

                    // bitacora
                    this._catalogosNegocio.generaBitacora(
                        "Se genero la vista previa del informe de Reparacion, ACTIVO: " + this._activoSelRepara.idActivo, "REIMPRESION ACTIVOS");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Reimpresión Bajas/Reparaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
