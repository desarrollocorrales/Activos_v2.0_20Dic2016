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
        ICatalogosNegocio _catalogosNegocio;
        private int? _idActivo = null;

        public frmBajaActivo()
        {
            InitializeComponent();

            this._catalogosNegocio = new CatalogosNegocio();
            this._activosNegocio = new ActivosNegocio();
        }

        private void frmBajaActivo_Load(object sender, EventArgs e)
        {
            this.lbCveActivo.Text = string.Empty;
            this.lbNumetiqueta.Text = string.Empty;
            this.tbUsuario.Text = string.Empty;

            this.dtpFecha.MaxDate = DateTime.Today.AddDays(10);

            // carga combo motivos
            this.cbMotivo.ValueMember = "idMotivoBaja";
            this.cbMotivo.DisplayMember = "motivo";
            this.cbMotivo.DataSource = this._catalogosNegocio.getMotivosBaja();
        }

        private void btnBusqAct_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscActivos form = new frmBuscActivos("BAJAS");

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
                    this.tbCosto.Text = array[4];
                    this.tbFactura.Text = array[5];
                    this.tbDescripcion.Text = array[6];
                    this.tbUsuario.Text = activo.usuario;

                    this.lbNumetiqueta.Text = activo.numEtiqueta;
                    this.lbCveActivo.Text = activo.claveActivo;

                    this.dtpFechaConsulta.Text = activo.fecha;

                    this._idActivo = activo.idActivo;

                    // reinicia campos
                    this.cbMotivo.SelectedIndex = -1;
                    this.tbDetalles.Text = string.Empty;
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

                if (string.IsNullOrEmpty(this.tbDetalles.Text))
                    throw new Exception("Proporcione un detalle");

                if (this.tbDetalles.Text.Trim().Length < 10)
                {
                    this.label10.ForeColor = System.Drawing.Color.Red;
                    this.label10.Text = "Detalles*";
                    throw new Exception("La longitud miníma permitida para los Detalles es de 10 carácteres");
                }
                else
                {
                    this.label10.ForeColor = System.Drawing.Color.Black;
                    this.label10.Text = "Detalles";
                }

                if (string.IsNullOrEmpty(this.dtpFecha.Text))
                    throw new Exception("Seleccione una fecha");

                string motivo = ((Modelos.MotivosBaja)this.cbMotivo.SelectedItem).clave;
                int idMotivo = ((Modelos.MotivosBaja)this.cbMotivo.SelectedItem).idMotivoBaja;
                string fecha = this.dtpFecha.Value.ToString("yyyy-MM-dd");
                string detalle = this.tbDetalles.Text;

                bool resultado;

                resultado = this._activosNegocio.bajaActivo(this._idActivo, idMotivo, motivo, detalle, fecha, Modelos.Login.idUsuario);

                if (resultado)
                {
                    MessageBox.Show("Movimiento realizado correctamente", "Activos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.tbNombre.Text = string.Empty;
                    this.tbTipo.Text = string.Empty;
                    this.tbSucursal.Text = string.Empty;
                    this.tbArea.Text = string.Empty;
                    this.tbMarca.Text = string.Empty;
                    this.tbModelo.Text = string.Empty;
                    this.tbNumSerie.Text = string.Empty;
                    this.tbColor.Text = string.Empty;
                    this.tbFactura.Text = string.Empty;
                    this.tbCosto.Text = string.Empty;

                    this.tbDescripcion.Text = string.Empty;
                    this.tbUsuario.Text = string.Empty;

                    this.lbNumetiqueta.Text = string.Empty;
                    this.lbCveActivo.Text = string.Empty;

                    this._idActivo = null;

                    // reinicia campos
                    this.cbMotivo.SelectedIndex = -1;
                    this.tbDetalles.Text = string.Empty;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
