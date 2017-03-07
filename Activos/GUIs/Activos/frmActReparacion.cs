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
    public partial class frmActReparacion : Form
    {
        private int? _idReparacion = null;
        private int? _idActivo = null;

        IActivosNegocio _activosNegocio;
        ICatalogosNegocio _catalogosNegocio;

        public frmActReparacion()
        {
            InitializeComponent();

            this._catalogosNegocio = new CatalogosNegocio();
            this._activosNegocio = new ActivosNegocio();
        }

        private void btnBuscaActivo_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscaActReparacion form = new frmBuscaActReparacion();

                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // muestra los datos del activo
                    Modelos.Reparaciones reparado = form._activoSelecc;

                    this.tbActivo.Text = reparado.activo;
                    this.tbUsuario.Text = reparado.usuario;
                    this.tbFechaIni.Text = reparado.fechaInicio;
                    this.tbCausa.Text = reparado.causa;

                    this._idReparacion = reparado.idReparacion;
                    this._idActivo = reparado.idActivo;

                    this.dtpFechaFin.Value = DateTime.Today;
                    this.tbObservAct.Text = string.Empty;
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

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._idReparacion == null)
                    throw new Exception("Seleccione un activo en reparación");

                string fechaFin = this.dtpFechaFin.Value.ToString("yyyy-MM-dd");

                if (this.tbObservAct.Text.Trim().Length < 10)
                {
                    this.label6.ForeColor = System.Drawing.Color.Red;
                    this.label6.Text = "Observaciones de la Activación*";
                    throw new Exception("La longitud miníma permitida para las observaciones es de 10 carácteres");
                }
                else
                {
                    this.label6.ForeColor = System.Drawing.Color.Black;
                    this.label6.Text = "Observaciones de la Activación";
                }

                string observAct = this.tbObservAct.Text;

                bool resultado = this._activosNegocio.actActivoReparacion(this._idReparacion, observAct, fechaFin, this._idActivo);

                if (resultado)
                {
                    MessageBox.Show("Activación exitosa", "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    // bitacora
                    this._catalogosNegocio.generaBitacora(
                        "Activo " + this._idActivo + " reingresado por reparacion el dia: " + fechaFin, "ACTIVOS");

                    this.tbActivo.Text = string.Empty;
                    this.tbUsuario.Text = string.Empty;
                    this.tbFechaIni.Text = string.Empty;
                    this.tbCausa.Text = string.Empty;

                    this.dtpFechaFin.Value = DateTime.Today;
                    this.tbObservAct.Text = string.Empty;
                
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
