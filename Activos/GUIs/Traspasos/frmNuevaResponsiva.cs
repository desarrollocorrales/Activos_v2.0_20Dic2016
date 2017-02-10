using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Activos.GUIs.Traspasos
{
    public partial class frmNuevaResponsiva : Form
    {
        private List<Modelos.Activos> _activos;
        private string _responsable;
        private string _sucursal;
        private string _puesto;

        public string observaciones;

        public frmNuevaResponsiva()
        {
            InitializeComponent();
        }

        public frmNuevaResponsiva(List<Modelos.Activos> activos, string responsable, string sucursal, string puesto)
        {
            InitializeComponent();

            // TODO: Complete member initialization
            this._activos = activos;
            this._responsable = responsable;
            this._sucursal = sucursal;
            this._puesto = puesto;
        }

        private void frmNuevaResponsiva_Load(object sender, EventArgs e)
        {
            this.tbResponsableT.Text = this._responsable;
            this.tbSucursalT.Text = this._sucursal;
            this.tbPuestoT.Text = this._puesto;

            this.gcActivosT.DataSource = this._activos;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.tbObservacion.Text.Trim().Length < 10)
                {
                    this.tbObservacion.ForeColor = System.Drawing.Color.Red;
                    this.tbObservacion.Text = "Observaciones*";
                    throw new Exception("La longitud miníma permitida para las observaciones es de 10 carácteres");
                }
                else
                {
                    this.tbObservacion.ForeColor = System.Drawing.Color.Black;
                    this.tbObservacion.Text = "Observaciones";
                }

                this.observaciones = this.tbObservacion.Text;

                this.DialogResult = System.Windows.Forms.DialogResult.OK;

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Traspasos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;

            this.Close();
        }
    }
}
