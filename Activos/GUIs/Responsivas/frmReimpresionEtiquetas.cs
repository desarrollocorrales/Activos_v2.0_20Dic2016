using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;
using Sofbr.Utils.Impresoras;

namespace Activos.GUIs.Responsivas
{
    public partial class frmReimpresionEtiquetas : Form
    {
        IActivosNegocio _activosNegocio;
        ICatalogosNegocio _catalogosNegocio;
        IResponsivasNegocio _responsivasNegocio;
        Modelos.ActivosDesc _encontrado;

        public frmReimpresionEtiquetas()
        {
            InitializeComponent();

            // acomoda radios
            this.rbPNE.Location = new Point(this.gbPNE.Location.X + 13, this.gbPNE.Location.Y - 1);
            this.rbPCA.Location = new Point(this.gbPCA.Location.X + 13, this.gbPCA.Location.Y - 1);

            this._activosNegocio = new ActivosNegocio();
            this._catalogosNegocio = new CatalogosNegocio();
            this._responsivasNegocio = new ResponsivasNegocio();

        }

        private void frmReimpresionEtiquetas_Load(object sender, EventArgs e)
        {

            // define radios activos
            this.rbPCA.Checked = true;
        }

        private void btnBuscarPCA_Click(object sender, EventArgs e)
        {
            try
            {
                string cveActivo = this.tbCveActivo.Text;

                List<Modelos.ActivosDesc> resultado = this._activosNegocio.getBuscaActivosResp(cveActivo, "CA");

                if (resultado.Count == 0)
                {
                    this.tbResultNombre.Text = string.Empty;
                    this.tbResultDesc.Text = string.Empty;
                    this.tbResultNumEtiqueta.Text = string.Empty;
                    this.tbResultCveActivo.Text = string.Empty;

                    this.ActiveControl = this.tbCveActivo;
                    this.tbCveActivo.SelectAll();
                    throw new Exception("Sin resultados");
                }

                // si encontro algo
                Modelos.ActivosDesc encontrado = resultado.Where(w => w.claveActivo.Equals(cveActivo)).Select(s => s).FirstOrDefault();

                if (encontrado == null || string.IsNullOrEmpty(encontrado.usuario))
                {
                    this.tbResultNombre.Text = string.Empty;
                    this.tbResultDesc.Text = string.Empty;
                    this.tbResultNumEtiqueta.Text = string.Empty;
                    this.tbResultCveActivo.Text = string.Empty;

                    this.ActiveControl = this.tbCveActivo;
                    this.tbCveActivo.SelectAll();
                    throw new Exception("Sin resultados");
                }

                this.tbResultNombre.Text = encontrado.nombreCorto;
                this.tbResultDesc.Text = encontrado.descripcion;
                this.tbResultNumEtiqueta.Text = encontrado.numEtiqueta;
                this.tbResultCveActivo.Text = encontrado.claveActivo;

                this._encontrado = encontrado;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Reimpresión de Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscarPNE_Click(object sender, EventArgs e)
        {

            try
            {
                string numEtiqueta = this.tbNumEtiqueta.Text;

                List<Modelos.ActivosDesc> resultado = this._activosNegocio.getBuscaActivosResp(numEtiqueta, "NE");

                if (resultado.Count == 0)
                {
                    this.tbResultNombre.Text = string.Empty;
                    this.tbResultDesc.Text = string.Empty;
                    this.tbResultNumEtiqueta.Text = string.Empty;
                    this.tbResultCveActivo.Text = string.Empty;

                    this.ActiveControl = this.tbNumEtiqueta;
                    this.tbNumEtiqueta.SelectAll();
                    throw new Exception("Sin resultados");
                }

                // si encontro algo
                Modelos.ActivosDesc encontrado = resultado.Where(w => w.numEtiqueta.Equals(numEtiqueta)).Select(s => s).FirstOrDefault();

                if (encontrado == null || string.IsNullOrEmpty(encontrado.usuario))
                {
                    this.tbResultNombre.Text = string.Empty;
                    this.tbResultDesc.Text = string.Empty;
                    this.tbResultNumEtiqueta.Text = string.Empty;
                    this.tbResultCveActivo.Text = string.Empty;

                    this.ActiveControl = this.tbNumEtiqueta;
                    this.tbNumEtiqueta.SelectAll();
                    throw new Exception("Sin resultados");
                }

                this.tbResultNombre.Text = encontrado.nombreCorto;
                this.tbResultDesc.Text = encontrado.descripcion;
                this.tbResultNumEtiqueta.Text = encontrado.numEtiqueta;
                this.tbResultCveActivo.Text = encontrado.claveActivo;

                this._encontrado = encontrado;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Reimpresión de Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rbPNE_CheckedChanged(object sender, EventArgs e)
        {

            this.gbPCA.Enabled = false;
            this.gbPNE.Enabled = true;

            this.reiniciaControles();
        }

        private void reiniciaControles()
        {
            this.tbNumEtiqueta.Text = string.Empty;

            this.tbCveActivo.Text = string.Empty;

            this.tbResultNombre.Text = string.Empty;
            this.tbResultDesc.Text = string.Empty;
            this.tbResultNumEtiqueta.Text = string.Empty;
            this.tbResultCveActivo.Text = string.Empty;
        }

        private void rbPCA_CheckedChanged(object sender, EventArgs e)
        {

            this.gbPCA.Enabled = true;
            this.gbPNE.Enabled = false;

            this.reiniciaControles();
        }

        private void btnImprEtiquetas_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sbComandos = new StringBuilder();
                string comando = this._responsivasNegocio.getBuscaComandoEt("activo");

                if (string.IsNullOrEmpty(comando))
                    throw new Exception("No se encontró un comando para la etiqueta");

                // string url = ConfigurationManager.AppSettings["url"];

                string url = this._catalogosNegocio.getUrl("url");


                string sucursal = this._catalogosNegocio.getSucursal(this._encontrado.idPersona);


                string comEtiqueta = comando;

                comEtiqueta = comEtiqueta.Replace("|sucursal|", sucursal);
                comEtiqueta = comEtiqueta.Replace("|area|", this._encontrado.area);
                comEtiqueta = comEtiqueta.Replace("|cveActivo|", this._encontrado.claveActivo);
                comEtiqueta = comEtiqueta.Replace("|nombrecorto|", this._encontrado.nombreCorto);
                comEtiqueta = comEtiqueta.Replace("0000000000000", this._encontrado.numEtiqueta);
                // comEtiqueta = comEtiqueta.Replace("|url|", ac.url);
                comEtiqueta = comEtiqueta.Replace("|url|", string.Format(url + "{0}", this._encontrado.idActivo));
                comEtiqueta = comEtiqueta.Replace("|empresa|", Modelos.Login.empresa);

                sbComandos.AppendLine(comEtiqueta);



                if (!string.IsNullOrEmpty(Properties.Settings.Default.Impresora))
                {
                    string impresora = Properties.Settings.Default.Impresora;

                    RawPrinter.SendToPrinter("Etiqueta Activos", sbComandos.ToString(), impresora);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show(
                               "No se tiene ninguna impresora para Etiquetas seleccionada\n" +
                               "¿Desea seleccionar una ahora?",
                               "Responsivas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        frmSelecImpresora form = new frmSelecImpresora();

                        form.ShowDialog();
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Reimpresión de Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
