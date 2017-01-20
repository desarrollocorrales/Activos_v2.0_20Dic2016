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
    public partial class frmBuscActivos : Form
    {
        ICatalogosNegocio _catalogosNegocio;
        IActivosNegocio _activosNegocio;

        public Modelos.ActivosDesc _activoSelecc;
        public int _idTipo;
        public string _tipoConsulta = string.Empty;

        public frmBuscActivos(string tipoConsulta)
        {
            InitializeComponent();
            
            // acomoda radios
            this.rbPTN.Location = new Point(this.gbPTN.Location.X + 13, this.gbPTN.Location.Y - 1);
            this.rbPN.Location = new Point(this.gbPN.Location.X + 13, this.gbPN.Location.Y - 1);
            this.rbPNE.Location = new Point(this.gbPNE.Location.X + 13, this.gbPNE.Location.Y - 1);
            this.rbPCA.Location = new Point(this.gbPCA.Location.X + 13, this.gbPCA.Location.Y - 1);

            // inicializa variables
            this._catalogosNegocio = new CatalogosNegocio();
            this._activosNegocio = new ActivosNegocio();

            this.tbResultCveActivo.Text = string.Empty;
            this.tbResultNumEtiqueta.Text = string.Empty;

            // tipo de consulta
            this._tipoConsulta = tipoConsulta;
        }

        private void frmBuscActivos_Load(object sender, EventArgs e)
        {
            try
            {
                // carga el combo de tipos
                this.cmbTipo.DisplayMember = "nombre";
                this.cmbTipo.ValueMember = "idTipo";
                this.cmbTipo.DataSource = this._catalogosNegocio.getTipos("A");
                this.cmbTipo.SelectedIndex = -1;

                // define radios activos
                this.rbPTN.Checked = true;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rbPTN_CheckedChanged(object sender, EventArgs e)
        {
            this.gbPCA.Enabled = false;
            this.gbPN.Enabled = false;
            this.gbPNE.Enabled = false;
            this.gbPTN.Enabled = true;

            this.reiniciaControles();
        }

        private void rbPNE_CheckedChanged(object sender, EventArgs e)
        {
            this.gbPCA.Enabled = false;
            this.gbPN.Enabled = false;
            this.gbPNE.Enabled = true;
            this.gbPTN.Enabled = false;

            this.reiniciaControles();
        }

        private void rbPCA_CheckedChanged(object sender, EventArgs e)
        {
            this.gbPCA.Enabled = true;
            this.gbPN.Enabled = false;
            this.gbPNE.Enabled = false;
            this.gbPTN.Enabled = false;

            this.reiniciaControles();
        }

        private void rbPN_CheckedChanged(object sender, EventArgs e)
        {
            this.gbPCA.Enabled = false;
            this.gbPN.Enabled = true;
            this.gbPNE.Enabled = false;
            this.gbPTN.Enabled = false;

            this.reiniciaControles();
        }

        private void reiniciaControles()
        {
            this.tbNombre.Text = string.Empty;
            this.cmbTipo.SelectedIndex = -1;

            this.tbUsuarioPU.Text = string.Empty;
            this.rbNombrePU.Checked = true;
            this.rbUsuarioPU.Checked = false;

            this.tbNumEtiqueta.Text = string.Empty;

            this.tbCveActivo.Text = string.Empty;

            this.gcResulBusquedas.DataSource = null;

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
                if (this._activoSelecc == null)
                    throw new Exception("Seleccione un activo");

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscarPTN_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (this.cmbTipo.SelectedIndex == -1)
                    throw new Exception("Seleccione un tipo");

                int idTipo = (int)this.cmbTipo.SelectedValue;
                string nombre = this.tbNombre.Text;

                List<Modelos.ActivosDesc> resultado = this._activosNegocio.getBuscaActivosResp(idTipo, nombre, "A");

                if (resultado.Count == 0)
                {
                    this.gcResulBusquedas.DataSource = null;
                    this.ActiveControl = this.tbNombre;
                    this.tbNombre.SelectAll();
                    throw new Exception("Sin resultados");
                }

                /*
                List<Modelos.ActivosDesc> lista = resultado.Where(w => !string.IsNullOrEmpty(w.usuario)).ToList();

                this.gcResulBusquedas.DataSource = this._tipoConsulta.Equals("BAJAS") ? lista : resultado;

                if (this.gridView1.DataRowCount == 0)
                    throw new Exception("Sin resultados");
                */

                this.gcResulBusquedas.DataSource = resultado;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    this.gcResulBusquedas.DataSource = null;
                    this.ActiveControl = this.tbNumEtiqueta;
                    this.tbNumEtiqueta.SelectAll();
                    throw new Exception("Sin resultados");
                }

                /*
                List<Modelos.ActivosDesc> lista = resultado.Where(w => !string.IsNullOrEmpty(w.usuario)).ToList();

                this.gcResulBusquedas.DataSource = this._tipoConsulta.Equals("BAJAS") ? lista : resultado;

                if (this.gridView1.DataRowCount == 0)
                    throw new Exception("Sin resultados");
                */

                this.gcResulBusquedas.DataSource = resultado;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscarPCA_Click(object sender, EventArgs e)
        {
            try
            {
                string cveActivo = this.tbCveActivo.Text;

                List<Modelos.ActivosDesc> resultado = this._activosNegocio.getBuscaActivosResp(cveActivo, "CA");

                if (resultado.Count == 0)
                {
                    this.gcResulBusquedas.DataSource = null;
                    this.ActiveControl = this.tbCveActivo;
                    this.tbCveActivo.SelectAll();
                    throw new Exception("Sin resultados");
                }

                /*
                List<Modelos.ActivosDesc> lista = resultado.Where(w => !string.IsNullOrEmpty(w.usuario)).ToList();

                this.gcResulBusquedas.DataSource = this._tipoConsulta.Equals("BAJAS") ? lista : resultado;

                if (this.gridView1.DataRowCount == 0)
                    throw new Exception("Sin resultados");
                */

                this.gcResulBusquedas.DataSource = resultado;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscarPU_Click(object sender, EventArgs e)
        {
            try
            {
                // valida radio
                string busqueda = this.rbUsuarioPU.Checked ? "usuario" : "nombrecompleto";

                // busqueda de usuarios
                List<Modelos.ActivosDesc> usuarios = this._activosNegocio.busquedaUsuariosResponsiva(this.tbUsuarioPU.Text, busqueda);

                if (usuarios.Count == 0)
                {
                    this.gcResulBusquedas.DataSource = null;
                    this.ActiveControl = this.tbUsuarioPU;
                    this.tbUsuarioPU.SelectAll();
                    throw new Exception("Sin resultados");
                }

                this.gcResulBusquedas.DataSource = usuarios;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gcResulBusquedas_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.gridView1.GetSelectedRows().Count() == 0)
                    return;

                this._activoSelecc = new Modelos.ActivosDesc();

                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    var dr1 = this.gridView1.GetRow(i);

                    this._activoSelecc = (Modelos.ActivosDesc)dr1;
                }

                // imprime datos
                this.tbResultNombre.Text = this._activoSelecc.nombreCorto;
                this.tbResultDesc.Text = this._activoSelecc.descripcion.Replace("&", " ").Trim();
                this.tbResultNumEtiqueta.Text = this._activoSelecc.numEtiqueta;
                this.tbResultCveActivo.Text = this._activoSelecc.claveActivo;

                this._idTipo = this._activoSelecc.idTipo;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
