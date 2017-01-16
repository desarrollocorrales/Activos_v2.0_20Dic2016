using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;

namespace Activos.GUIs.Sucursales
{
    public partial class frmModifSuc : Form
    {
        private ICatalogosNegocio _catalogosNegocio;

        private int? _idResponsable;
        private int _idSucursal;
        private string _nombre;

        public frmModifSuc(int? idResponsable, string nombre, int idSucursal)
        {
            InitializeComponent();

            this._catalogosNegocio = new CatalogosNegocio();

            this._idSucursal = idSucursal;
            this._idResponsable = idResponsable;
            this._nombre = nombre;
        }

        private void frmModifSuc_Load(object sender, EventArgs e)
        {
            // llena el catalogo de responsables (usuarios) disponibles
            this.cmbResponsable.DataSource = this._catalogosNegocio.getPersonas("", "A");
            this.cmbResponsable.DisplayMember = "nombreCompleto";
            this.cmbResponsable.ValueMember = "idPersona";
            

            // selecciona el usuario enviado
            if (this._idResponsable == null) this.cmbResponsable.SelectedIndex = -1;
            else this.cmbResponsable.SelectedValue = this._idResponsable;
            

            // imprime el nombre
            this.tbNombre.Text = this._nombre;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (string.IsNullOrEmpty(this.tbNombre.Text))
                    throw new Exception("Llene el nombre de la sucursal");

                string sucNom = this.tbNombre.Text;

                int? idResp = null;

                if (this.cmbResponsable.SelectedIndex != -1)
                {
                    int sv = Convert.ToInt16(this.cmbResponsable.SelectedValue);

                    if (sv != -1)
                        idResp = sv;
                }

                // guardado de informacion
                bool resultado = this._catalogosNegocio.modificaSucursal(sucNom, idResp, this._idSucursal);

                if (resultado)
                {
                    MessageBox.Show("Sucursal modificada correctamente", "Modificar Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tbNombre.Text = string.Empty;
                    this.cmbResponsable.SelectedIndex = 0;
                }

                // cerrar formularios
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Modificar Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


    }
}
