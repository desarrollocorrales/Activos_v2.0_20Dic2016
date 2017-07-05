using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;

namespace Activos.GUIs.Reportes
{
    public partial class frmResponsivasSucursalXResp : Form
    {
        ICatalogosNegocio _catalogosNegocio;
        IResponsivasNegocio _responsivasNegocio;
        IActivosNegocio _activosNegocio;

        private string _sucursal;
        private Modelos.Responsivas _responsiva = new Modelos.Responsivas();

        List<Modelos.Activos> _activos = new List<Modelos.Activos>();

        public frmResponsivasSucursalXResp()
        {
            InitializeComponent();
            this._catalogosNegocio = new CatalogosNegocio();
            this._responsivasNegocio = new ResponsivasNegocio();
            this._activosNegocio = new ActivosNegocio();
        }

        private void frmResponsivasSucursalXResp_Load(object sender, EventArgs e)
        {
            try
            {
                // llena el catalogo de sucursales disponibles
                this.cmbSucursales.DataSource = this._catalogosNegocio.getSucursales("A");
                this.cmbSucursales.DisplayMember = "nombre";
                this.cmbSucursales.ValueMember = "idSucursal";
                this.cmbSucursales.SelectedIndex = -1;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Reponsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (this.cmbSucursales.SelectedIndex == -1)
                    throw new Exception("Seleccione una sucursal");

                int idSuc = (int)this.cmbSucursales.SelectedValue;

                this._sucursal = ((Modelos.Sucursales)this.cmbSucursales.SelectedItem).nombre;

                // List<Modelos.Responsivas> responsivas = this._responsivasNegocio.buscaResponsiva("", idSuc, "B");
                List<Modelos.Responsivas> responsivas = this._responsivasNegocio.buscaRespXSuc(idSuc);

                if (responsivas.Count == 0)
                {
                    responsivas = new List<Modelos.Responsivas>();
                    this.gcResponsables.DataSource = null;
                    this.gcActivos.DataSource = null;
                    this.tbRespDe.Text = string.Empty;
                    throw new Exception("Sin resultados");
                }

                this.gcResponsables.DataSource = null;
                this.gcResponsables.DataSource = responsivas;
                this.gridView1.BestFitColumns();

                this.gcActivos.DataSource = null;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Reponsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gcResponsables_DoubleClick(object sender, EventArgs e)
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

                this._activos = this._activosNegocio.getBuscaActivosRepBaja(this._responsiva.idResponsiva);

                if (this.cbBajas.Checked)
                {
                    if (!this.cbReparaciones.Checked)
                        this._activos = this._activos.Where(w => w.status.Equals("BAJA") || w.status.Equals("ACTIVO")).ToList();
                }
                else
                {
                    if (this.cbReparaciones.Checked)
                        this._activos = this._activos.Where(w => w.status.Equals("REPARACION") || w.status.Equals("ACTIVO")).ToList();
                    else
                        this._activos = this._activos.Where(w => w.status.Equals("ACTIVO")).ToList();
                }

                this.tbRespDe.Text = this._responsiva.responsable;
                this.tbFolio.Text = this._responsiva.idResponsiva.ToString();
                
                this.gcActivos.DataSource = this._activos;
                this.gridView2.BestFitColumns();

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
                // validaciones 
                if (this._responsiva == null)
                    throw new Exception("Realice una búsqueda");

                frmReporteRespSucXResp form = new frmReporteRespSucXResp();
                List<Modelos.Activos> activos = new List<Modelos.Activos>();

                // cambia activos
                foreach (Modelos.Activos ac in this._activos)
                {
                    string descripcion = ac.descripcion.Replace("---", ";");
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

                List<Modelos.PersonaResponsivas> responsable = new List<Modelos.PersonaResponsivas>();
                responsable.Add(new Modelos.PersonaResponsivas
                    {
                        sucursal = this._sucursal,
                        nombre = this._responsiva.responsable
                    });

                form._logo = logo;
                form._responsables = responsable;
                form._activos = activos;
                form._folio = this._responsiva.idResponsiva;

                // bitacora
                this._catalogosNegocio.generaBitacora(
                    "Genera Reporte 'Responsivas por sucursal' con parametros:" +
                    " sucursal: " + this._sucursal + ", responsiva folio " + this._responsiva.idResponsiva, "CONSULTAS");

                form.Show();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Reponsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
