using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;
using Activos.Modelos;

namespace Activos.GUIs.Usuarios
{
    public partial class frmAltaUsuarios : Form
    {
        ICatalogosNegocio _catalogosNegocio;

        public frmAltaUsuarios()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this._catalogosNegocio = new CatalogosNegocio();
        }

        private void frmAltaUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                // llena el catalogo de puestos disponibles
                this.cmbPuesto.DataSource = this._catalogosNegocio.getPuestos("A");
                this.cmbPuesto.DisplayMember = "nom_suc";
                this.cmbPuesto.ValueMember = "idPuesto";
                this.cmbPuesto.SelectedIndex = -1;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones 
                if (string.IsNullOrEmpty(this.tbNombre.Text))
                    throw new Exception("Llene el campo 'Nombre'");

                if (this.cmbPuesto.SelectedIndex == -1)
                    throw new Exception("Seleccione un Puesto");

                if (string.IsNullOrEmpty(this.tbCorreo.Text))
                    throw new Exception("Llene el campo 'Correo'");

                if (string.IsNullOrEmpty(this.tbUsuario.Text))
                    throw new Exception("Llene el campo 'Usuario'");

                if (string.IsNullOrEmpty(this.tbClave.Text))
                    throw new Exception("Llene el campo 'Clave'");

                string nombre = this.tbNombre.Text;
                int idPuesto = (int)this.cmbPuesto.SelectedValue;
                string correo = this.tbCorreo.Text;
                string usuario = this.tbUsuario.Text;
                string clave = this.tbClave.Text;

                string fecIng = this.dtpFechaIngreso.Value.ToString("yyyy-MM-dd");

                // guarda el usuario
                Response resp = this._catalogosNegocio.creaUsuario(nombre, idPuesto, fecIng, correo, usuario, clave);

                if (resp.status == Estatus.OK)
                {
                    MessageBox.Show("El usuario ha sido creado correctamente", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.cmbPuesto.SelectedIndex = -1;

                    this.tbNombre.Text = string.Empty;
                    this.tbCorreo.Text = string.Empty;
                    this.tbUsuario.Text = string.Empty;
                    this.tbClave.Text = string.Empty;
                }
                else
                    throw new Exception(resp.error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
