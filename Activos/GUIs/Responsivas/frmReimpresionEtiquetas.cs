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
            this.rbPTN.Location = new Point(this.gbPTN.Location.X + 13, this.gbPTN.Location.Y - 1);

            this._activosNegocio = new ActivosNegocio();
            this._catalogosNegocio = new CatalogosNegocio();
            this._responsivasNegocio = new ResponsivasNegocio();
        }

        private void frmReimpresionEtiquetas_Load(object sender, EventArgs e)
        {
            // carga el combo de tipos
            List<Modelos.Tipos> tipos = new List<Modelos.Tipos>();
            tipos.Add(new Modelos.Tipos { idTipo = -1, nombre = "" });
            tipos.AddRange(this._catalogosNegocio.getTipos("A"));

            this.cmbTipo.DisplayMember = "nombre";
            this.cmbTipo.ValueMember = "idTipo";
            this.cmbTipo.DataSource = tipos;

            // llenar combo de sucursales
            this.cmbSucursal.DisplayMember = "nombre";
            this.cmbSucursal.ValueMember = "idSucursal";
            this.cmbSucursal.DataSource = this._catalogosNegocio.getSucursales("A");
            this.cmbSucursal.SelectedIndex = -1;

            // define radios activos
            this.rbPTN.Checked = true;
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

                this.gcResulBusquedas.DataSource = resultado;
                this.gridView1.BestFitColumns();

                /*
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
                */
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

                this.gcResulBusquedas.DataSource = resultado;
                this.gridView1.BestFitColumns();

                /*
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
                */
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
            this.gbPTN.Enabled = false;

            this.reiniciaControles();
        }

        private void reiniciaControles()
        {
            this.tbNombre.Text = string.Empty;
            this.cmbTipo.SelectedIndex = -1;
            this.cmbSucursal.SelectedIndex = -1;
            this.cmbArea.DataSource = null;

            this.tbNumEtiqueta.Text = string.Empty;

            this.tbCveActivo.Text = string.Empty;

            this.tbResultNombre.Text = string.Empty;
            this.tbResultDesc.Text = string.Empty;
            this.tbResultNumEtiqueta.Text = string.Empty;
            this.tbResultCveActivo.Text = string.Empty;

            this._encontrado = null;
            this.gcResulBusquedas.DataSource = null;
        }

        private void rbPCA_CheckedChanged(object sender, EventArgs e)
        {
            this.gbPCA.Enabled = true;
            this.gbPNE.Enabled = false;
            this.gbPTN.Enabled = false;

            this.reiniciaControles();
        }

        private void btnImprEtiquetas_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._encontrado == null)
                    throw new Exception("Realice una búsqueda y/o seleccione un activo");

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


                    // bitacora
                    this._catalogosNegocio.generaBitacora(
                        "Se reimprimio la etiqueta '" + this._encontrado.numEtiqueta + "' con el nombre '" + this._encontrado.nombreCorto + "'", "RESPONSIVAS");

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

        private void tbCveActivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnBuscarPCA_Click(null, null);
            }
        }

        private void tbNumEtiqueta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnBuscarPNE_Click(null, null);
            }
        }

        private void cmbSucursal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                int idSucursal = (int)this.cmbSucursal.SelectedValue;

                // llenar combo de Tipos
                List<Modelos.Areas> areas = new List<Modelos.Areas>();
                areas.Add(new Modelos.Areas { idArea = -1, nombre = "" });
                areas.AddRange(this._catalogosNegocio.getAreas(idSucursal));

                this.cmbArea.DataSource = areas;
                this.cmbArea.DisplayMember = "nombre";
                this.cmbArea.ValueMember = "idArea";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscarPTN_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (this.cmbSucursal.SelectedIndex == -1)
                    throw new Exception("Seleccione una sucursal");

                int idSucursal = (int)this.cmbSucursal.SelectedValue;

                int idArea = this.cmbArea.SelectedIndex == -1 ? -1 : (int)this.cmbArea.SelectedValue;

                int idTipo = this.cmbTipo.SelectedIndex == -1 ? -1 : (int)this.cmbTipo.SelectedValue;

                string nombre = this.tbNombre.Text;

                List<Modelos.ActivosDesc> resultado = this._activosNegocio.getBuscaActivosResp(idSucursal, idArea, idTipo, nombre, "A");

                if (resultado.Count == 0)
                {
                    this.gcResulBusquedas.DataSource = null;
                    this.ActiveControl = this.tbNombre;
                    this.tbNombre.SelectAll();
                    throw new Exception("Sin resultados");
                }

                this.gcResulBusquedas.DataSource = resultado;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gcResulBusquedas_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.gridView1.GetSelectedRows().Count() == 0)
                    return;

                Modelos.ActivosDesc activoSelecc = new Modelos.ActivosDesc();

                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    var dr1 = this.gridView1.GetRow(i);

                    activoSelecc = (Modelos.ActivosDesc)dr1;
                }

                // imprime datos
                this.tbResultNombre.Text = activoSelecc.nombreCorto;
                this.tbResultDesc.Text = activoSelecc.descripcion.Replace("&", " ").Trim();
                this.tbResultNumEtiqueta.Text = activoSelecc.numEtiqueta;
                this.tbResultCveActivo.Text = activoSelecc.claveActivo;

                this._encontrado = activoSelecc;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rbPTN_CheckedChanged(object sender, EventArgs e)
        {
            this.gbPCA.Enabled = false;
            this.gbPNE.Enabled = false;
            this.gbPTN.Enabled = true;

            this.reiniciaControles();
        }
    }
}
