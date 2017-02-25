using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;

namespace Activos.GUIs.Puestos
{
    public partial class frmModifPuestos : Form
    {
        private ICatalogosNegocio _catalogosNegocio;

        private int _idPuesto;
        private int _idSucursal;
        private string _nombre;

        public frmModifPuestos(int idPuesto, string nombre, int idSucursal)
        {
            InitializeComponent();

            this._catalogosNegocio = new CatalogosNegocio();

            this._idSucursal = idSucursal;
            this._idPuesto = idPuesto;
            this._nombre = nombre;
        }

        private void frmModifPuestos_Load(object sender, EventArgs e)
        {

            // llena el catalogo de sucursales disponibles
            this.cmbSucursal.DataSource = this._catalogosNegocio.getSucursales("A");
            this.cmbSucursal.DisplayMember = "nombre";
            this.cmbSucursal.ValueMember = "idSucursal";


            // selecciona la sucursal enviado
            this.cmbSucursal.SelectedValue = this._idSucursal;


            // imprime el nombre
            this.tbNombre.Text = this._nombre;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (string.IsNullOrEmpty(this.tbNombre.Text))
                    throw new Exception("Llene el nombre del Puesto");

                string puestoNom = this.tbNombre.Text;

                if (this.cmbSucursal.SelectedIndex == -1)
                    throw new Exception("Seleccione una sucursal");

                int idSuc = Convert.ToInt16(this.cmbSucursal.SelectedValue);
                string sucursal = ((Modelos.Sucursales)this.cmbSucursal.SelectedItem).nombre;

                // guardado de informacion
                bool resultado = this._catalogosNegocio.modificaPuesto(puestoNom, idSuc, this._idPuesto, sucursal);

                if (resultado)
                {
                    MessageBox.Show("Puesto modificado correctamente", "Modificar Puesto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tbNombre.Text = string.Empty;
                    this.cmbSucursal.SelectedIndex = 0;
                }

                // cerrar formularios
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Modificar Puestos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

