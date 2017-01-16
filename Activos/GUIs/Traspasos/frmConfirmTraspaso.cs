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
    public partial class frmConfirmTraspaso : Form
    {
        private Modelos.Activos _activoSel;
        private string _usuario;

        public frmConfirmTraspaso()
        {
            InitializeComponent();
        }

        public frmConfirmTraspaso(Modelos.Activos activoSel, string usuario)
        {
            InitializeComponent();

            this._activoSel = activoSel;
            this._usuario = usuario;
        }

        private void frmConfirmTraspaso_Load(object sender, EventArgs e)
        {
            try
            {
                this.tbNombre.Text = this._activoSel.nombreCorto;
                this.tbTipo.Text = this._activoSel.tipo;
                this.tbArea.Text = this._activoSel.area;
                this.lbNumetiqueta.Text = this._activoSel.numEtiqueta;
                this.lbCveActivo.Text = this._activoSel.claveActivo;

                string descripcion = this._activoSel.descripcion.Replace("---", "&");
                string[] array = descripcion.Split('&');

                this.tbMarca.Text = array[0];
                this.tbModelo.Text = array[1];
                this.tbNumSerie.Text = array[2];
                this.tbColor.Text = array[3];
                this.tbDescripcion.Text = array[4];

                this.tbUsuario.Text = _usuario;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Confirmar Traspaso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
