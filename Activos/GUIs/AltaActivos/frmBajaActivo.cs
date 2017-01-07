using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;

namespace Activos.GUIs.AltaActivos
{
    public partial class frmBajaActivo : Form
    {
        IActivosNegocio _activosNegocio;
        private int? _idActivo = null;

        public frmBajaActivo()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this._activosNegocio = new ActivosNegocio();
        }

        private void frmBajaActivo_Load(object sender, EventArgs e)
        {
            this.lbCveActivo.Text = string.Empty;
            this.lbNumetiqueta.Text = string.Empty;
            this.tbUsuario.Text = string.Empty;

            this.dtpFecha.MaxDate = DateTime.Today.AddDays(10);
        }

        private void btnBusqAct_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscActivos form = new frmBuscActivos();

                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // muestra los datos del activo
                    Modelos.ActivosDesc activo = form._activoSelecc;

                    string[] array = activo.descripcion.Split('&');

                    this.tbNombre.Text = activo.nombreCorto;
                    this.tbTipo.Text = activo.tipo;
                    this.tbSucursal.Text = activo.sucursal;
                    this.tbArea.Text = activo.area;
                    this.tbMarca.Text = array[0];
                    this.tbModelo.Text = array[1];
                    this.tbNumSerie.Text = array[2];
                    this.tbColor.Text = array[3];
                    this.tbDescripcion.Text = array[4];
                    this.tbUsuario.Text = activo.usuario;

                    this.lbNumetiqueta.Text = activo.numEtiqueta;
                    this.lbCveActivo.Text = activo.claveActivo;

                    this._idActivo = activo.idActivo;

                    // reinicia campos
                    this.cbMotivo.SelectedIndex = -1;
                    this.tbCausa.Text = string.Empty;
                }

                if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Operación Cancelada", "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRealizaMto_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (this._idActivo == null)
                    throw new Exception("Seleccione un activo");

                if (this.cbMotivo.SelectedIndex == -1)
                    throw new Exception("Seleccione un motivo");

                if (string.IsNullOrEmpty(this.tbCausa.Text))
                    throw new Exception("Defina una causa");

                if (string.IsNullOrEmpty(this.dtpFecha.Text))
                    throw new Exception("Seleccione una fecha");

                string motivo = (string)this.cbMotivo.SelectedItem;
                string fecha = this.dtpFecha.Value.ToString("yyyy-MM-dd");
                string causa = this.tbCausa.Text;

                bool resultado;

                resultado = this._activosNegocio.bajaActivo(this._idActivo, (motivo.Equals("REPARACION") ? "R" : "B"), causa, fecha, Modelos.Login.idUsuario);

                if(resultado)
                    MessageBox.Show("Movimiento realizado correctamente", "Activos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
