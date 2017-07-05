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
    public partial class frmResponsivasSucursal : Form
    {
        ICatalogosNegocio _catalogosNegocio;
        IResponsivasNegocio _responsivasNegocio;

        private string _sucursal = string.Empty;

        private List<Modelos.ResponsivasSucursal> _resultado = new List<Modelos.ResponsivasSucursal>();

        public frmResponsivasSucursal()
        {
            InitializeComponent();
            this._catalogosNegocio = new CatalogosNegocio();
            this._responsivasNegocio = new ResponsivasNegocio();
        }

        private void frmResponsivasSucursal_Load(object sender, EventArgs e)
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

                bool bajas = this.cbBajas.Checked;
                bool repara = this.cbReparaciones.Checked;

                int idSuc = (int)this.cmbSucursales.SelectedValue;

                this._sucursal = ((Modelos.Sucursales)this.cmbSucursales.SelectedItem).nombre;

                this._resultado = this._responsivasNegocio.getRespSuc(idSuc, bajas, repara);

                if (this._resultado.Count == 0)
                {
                    this._resultado = new List<Modelos.ResponsivasSucursal>();
                    this.gcResponsivas.DataSource = null;
                    throw new Exception("Sin resultados");
                }

                this.gcResponsivas.DataSource = null;
                this.gcResponsivas.DataSource = this._resultado;
                this.gridView1.BestFitColumns();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Reponsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones 
                if (this._resultado.Count == 0)
                    throw new Exception("Realice una búsqueda");

                frmReporteResponsivasSucursal form = new frmReporteResponsivasSucursal();

                List<Modelos.ResponsivasSucursal> responsiva = new List<Modelos.ResponsivasSucursal>();

                // cambia activos
                foreach (Modelos.ResponsivasSucursal ac in this._resultado)
                {
                    string descripcion = ac.descripcion.Replace("---", ";");
                    string[] array = descripcion.Split(';');

                    descripcion = (!string.IsNullOrEmpty(array[0]) ? "Marca: " + array[0] + "; " : string.Empty) +
                                  (!string.IsNullOrEmpty(array[1]) ? "Modelo: " + array[1] + ";\n" : string.Empty) +
                                  (!string.IsNullOrEmpty(array[2]) ? "Núm. Serie: " + array[2] + ";\n" : string.Empty) +
                                  (!string.IsNullOrEmpty(array[3]) ? "Color: " + array[3] + "; " : string.Empty) +
                                  (!string.IsNullOrEmpty(array[4]) ? "Costo: " + array[4] + "; " : string.Empty) +
                                  (!string.IsNullOrEmpty(array[5]) ? "Factura: " + array[5] + ";\n" : string.Empty) +
                                  (!string.IsNullOrEmpty(array[6]) ? "Detalles: " + array[6] + ";\n" : string.Empty);

                    responsiva.Add(new Modelos.ResponsivasSucursal
                    {
                        activo = ac.activo,
                        descripcion = descripcion,
                        estatus = ac.estatus,
                        idActivo = ac.idActivo,
                        idPersona = ac.idPersona,
                        idResponsiva = ac.idResponsiva,
                        persona = ac.persona
                    });
                }

                form._responsivas = responsiva;


                // bitacora
                this._catalogosNegocio.generaBitacora(
                    "Genera Reporte 'Responsivas por sucursal' con parametros:" +
                    " sucursal: " + this._sucursal +

                    (this.cbBajas.Checked ? " BAJAS " : string.Empty) +
                    (this.cbReparaciones.Checked ? " REPARACIONES " : string.Empty), "CONSULTAS");

                form.Show();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Reponsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
