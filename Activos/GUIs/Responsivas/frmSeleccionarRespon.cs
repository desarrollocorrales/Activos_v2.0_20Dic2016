using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;

namespace Activos.GUIs.Responsivas
{
    public partial class frmSeleccionarRespon : Form
    {
        // true  = todo bien
        // false = cerrar desde X o cancelar
        bool _desde = false;

        private List<Modelos.Responsivas> _responsivas;
        private bool _cancela;
        public Modelos.Responsivas _responsiva;

        public List<Modelos.Activos> _activos;

        private IActivosNegocio _activosNegocio;

        public frmSeleccionarRespon()
        {
            InitializeComponent();

            this._activosNegocio = new ActivosNegocio();
        }

        // cancela:
        //  true: valida si se cancela la operacion
        // false: SIN validacion
        public frmSeleccionarRespon(List<Modelos.Responsivas> responsivas, bool cancela)
        {
            InitializeComponent();

            this._activosNegocio = new ActivosNegocio();
            this._responsivas = responsivas;
            this._cancela = cancela;
        }

        private void frmSeleccionarRespon_Load(object sender, EventArgs e)
        {
            try
            {
                this.gcResponsables.DataSource = this._responsivas;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gcResponsables_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.gridView1.GetSelectedRows().Count() == 0)
                    throw new Exception("No a seleccionado una responsiva");

                this._responsiva = new Modelos.Responsivas();

                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    var dr1 = this.gridView1.GetRow(i);

                    this._responsiva = (Modelos.Responsivas)dr1;
                }

                this._activos = this._activosNegocio.getBuscaActivos(this._responsiva.idResponsiva);

                this.tbRespDe.Text = this._responsiva.responsable;
                this.tbFolio.Text = this._responsiva.idResponsiva.ToString();

                this.gcActivos.DataSource = this._activos;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (this._responsiva == null) throw new Exception("Seleccione una responsiva");

                this.DialogResult = System.Windows.Forms.DialogResult.OK;

                this._desde = true;

                this.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmSeleccionarRespon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this._desde)
            {
                if (this._cancela)
                {
                    var window = MessageBox.Show(
                        "¿Desea cancelar la operación?",
                        "Responisvas",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    e.Cancel = (window == DialogResult.No);

                    if (window == DialogResult.No)
                        e.Cancel = true;
                }
             
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }
    }
}
