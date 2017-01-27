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

namespace Activos
{
    public partial class frmLogin : Form
    {
        ICatalogosNegocio _catalogosNegocio;

        public frmLogin()
        {
            InitializeComponent();

            this._catalogosNegocio = new CatalogosNegocio();

            this.ActiveControl = this.tbUsuario;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (string.IsNullOrEmpty(this.tbUsuario.Text))
                    throw new Exception("Llene el campo Usuario");

                if (string.IsNullOrEmpty(this.tbPass.Text))
                    throw new Exception("Llene el campo Contraseña");

                Response resp = this._catalogosNegocio.validaAcceso(this.tbUsuario.Text, this.tbPass.Text);

                if (resp.status == Estatus.OK)
                {
                    // almacenar credeniales
                    Modelos.Login.idUsuario = resp.usuario.idUsuario;
                    Modelos.Login.nombre = resp.usuario.nombre;
                    Modelos.Login.usuario = resp.usuario.usuario;

                    this.Hide();
                    new FormPrincipal().ShowDialog();
                    this.Close();
                }
                else throw new Exception(resp.error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnAcceder_Click(null, null);
            }
        }

        private void tbUsuario_Enter(object sender, EventArgs e)
        {
            this.tbUsuario.SelectAll();
        }

        private void tbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.ActiveControl = this.tbPass;
                this.tbPass.SelectAll();
            }
        }

    }
}
