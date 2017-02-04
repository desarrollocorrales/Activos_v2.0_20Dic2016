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
    public partial class frmActivosPersona : Form
    {
        ICatalogosNegocio _catalogosNegocio;
        IResponsivasNegocio _responsivasNegocio;
        IActivosNegocio _activosNegocio;

        public Modelos.PersonaResponsivas _responsiva;
        public List<Modelos.Activos> _activos;

        public frmActivosPersona()
        {
            InitializeComponent();
            this._catalogosNegocio = new CatalogosNegocio();
            this._responsivasNegocio = new ResponsivasNegocio();
            this._activosNegocio = new ActivosNegocio();
        }

        private void frmActivosPersona_Load(object sender, EventArgs e)
        {
            try
            {
                // llena el catalogo de sucursales disponibles
                this.cmbSucursal.DataSource = this._catalogosNegocio.getSucursales("A");
                this.cmbSucursal.DisplayMember = "nombre";
                this.cmbSucursal.ValueMember = "idSucursal";
                this.cmbSucursal.SelectedIndex = -1;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbSucursal.SelectedIndex == -1)
                    throw new Exception("Seleccione una sucursal");

                string responsable = this.tbResp.Text;
                int idSuc = (int)this.cmbSucursal.SelectedValue;

                List<Modelos.PersonaResponsivas> responsivas = this._responsivasNegocio.buscaResponsiva(responsable, idSuc);

                this._activos = null;

                this.tbRespDe.Text = string.Empty;

                this.gcActivos.DataSource = this._activos;

                this._responsiva = null;

                if (responsivas.Count == 0)
                {
                    this.gcResponsables.DataSource = null;

                    throw new Exception("Sin resultados");
                }

                this.gcResponsables.DataSource = responsivas;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gcResponsables_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.gridView1.GetSelectedRows().Count() == 0)
                    throw new Exception("No a seleccionado una persona");

                this._responsiva = new Modelos.PersonaResponsivas();

                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    var dr1 = this.gridView1.GetRow(i);

                    this._responsiva = (Modelos.PersonaResponsivas)dr1;
                }

                int idPersona = this._responsiva.idPersona;

                this._activos = this._activosNegocio.getBuscaActivosPersona(idPersona, this.cbBajas.Checked, this.cbReparacion.Checked);

                this.tbRespDe.Text = this._responsiva.nombre;

                this.gcActivos.DataSource = this._activos;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._responsiva == null)
                    throw new Exception("Seleccione una persona");

                Modelos.Responsivas responsiva = new Modelos.Responsivas();

                DateTime thisDay = DateTime.Today;

                responsiva.fechaImpresion = thisDay.ToString("d");

                frmReporteActivosPersona form = new frmReporteActivosPersona();

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

                responsiva.puesto = this._responsiva.puesto;
                responsiva.responsable = this._responsiva.nombre;
                responsiva.sucursal = this._responsiva.sucursal;

                form._activos = activos;
                form._responsivas = responsiva;

                form._empresa = Modelos.Login.empresa;

                form.ShowDialog();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
