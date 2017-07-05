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
using Activos.GUIs.Personas;

namespace Activos.GUIs.Usuarios
{
    public partial class frmAltaUsuarios : Form
    {
        ICatalogosNegocio _catalogosNegocio;

        public frmAltaUsuarios()
        {
            InitializeComponent();

            this._catalogosNegocio = new CatalogosNegocio();
        }

        private void frmAltaUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                int t = Convert.ToInt16(this.btnAgregaPersona.Tag);

                if (!Modelos.Login.permisos.Contains(t))
                    this.btnAgregaPersona.Enabled = false;

                // llena el catalogo de puestos disponibles
                this.cmbPersona.DisplayMember = "nombrecompleto";
                this.cmbPersona.ValueMember = "idPersona";
                this.cmbPersona.DataSource = this._catalogosNegocio.getPersonasSinUsuario("A");
                this.cmbPersona.SelectedIndex = -1;
                
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
                if (this.cmbPersona.SelectedIndex == -1)
                    throw new Exception("Seleccione una Persona");

                if (string.IsNullOrEmpty(this.tbUsuario.Text))
                    throw new Exception("Defina un Usuario");

                if (string.IsNullOrEmpty(this.tbClave.Text))
                    throw new Exception("Defina una clave para la cuenta");
                
                if (string.IsNullOrEmpty(this.tbCorreo.Text))
                    throw new Exception("Defina un Correo para el usuario");

                if (!this.tbConfirmClave.Text.Equals(this.tbClave.Text))
                    throw new Exception("La claves no coinciden");


                int idPersona = (int)this.cmbPersona.SelectedValue;
                string correo = this.tbCorreo.Text;
                string usuario = this.tbUsuario.Text;
                string clave = this.tbClave.Text;

                string fecIng = this.dtpFechaIngreso.Value.ToString("yyyy-MM-dd");

                // guarda el usuario
                Response resp = this._catalogosNegocio.creaUsuario(idPersona, fecIng, correo, usuario, clave);

                if (resp.status == Estatus.OK)
                {
                    MessageBox.Show("El usuario ha sido creado correctamente", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.cmbPersona.SelectedIndex = -1;

                    this.tbCorreo.Text = string.Empty;
                    this.tbUsuario.Text = string.Empty;
                    this.tbClave.Text = string.Empty;
                    this.tbConfirmClave.Text = string.Empty;

                    this.cmbPersona.DataSource = null;

                    this.cmbPersona.DisplayMember = "nombrecompleto";
                    this.cmbPersona.ValueMember = "idPersona";
                    this.cmbPersona.DataSource = this._catalogosNegocio.getPersonasSinUsuario("A");
                    this.cmbPersona.SelectedIndex = -1;
                }
                else
                    throw new Exception(resp.error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAgregaPersona_Click(object sender, EventArgs e)
        {
            try
            {
                frmPersonas form = new frmPersonas();

                form.ShowDialog();

                // llena el catalogo de puestos disponibles
                this.cmbPersona.DisplayMember = "nombrecompleto";
                this.cmbPersona.ValueMember = "idPersona";
                this.cmbPersona.DataSource = this._catalogosNegocio.getPersonasSinUsuario("A");
                this.cmbPersona.SelectedIndex = -1;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
