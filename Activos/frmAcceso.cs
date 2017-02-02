using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Activos
{
    public partial class frmAcceso : Form
    {
        public frmAcceso()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // validacion
                if (string.IsNullOrEmpty(this.tbAccess.Text))
                    throw new Exception("Ingrese la clave de acceso");

                string claveAcceso = Modelos.Utilerias.Transform(this.tbAccess.Text);

                string acceso = Properties.Settings.Default.accesoConfig;

                if (Modelos.Utilerias.Transform(acceso).Equals(Modelos.Utilerias.Transform(claveAcceso)))
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                else
                    throw new Exception("Clave incorrecta");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Impresoras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbAccess_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnAceptar_Click(null, null);
            }
        }
    }
}
