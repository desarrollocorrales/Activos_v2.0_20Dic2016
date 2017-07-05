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
            this.rbPN.Location = new Point(this.gbPTN.Location.X + 13, this.gbPTN.Location.Y - 1);
            this.rbPU.Location = new Point(this.gbPN_2.Location.X + 13, this.gbPN_2.Location.Y - 1);
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
                /* Version 2.1 21-06-2016 */

                // carga el combo de usuarios
                this.cmbUsuarios.DisplayMember = "nombreCompleto";
                this.cmbUsuarios.ValueMember = "idPersona";
                this.cmbUsuarios.DataSource = this._catalogosNegocio.getPersonas("%", "A");
                this.cmbUsuarios.SelectedIndex = -1;

                /* Version 2.1 21-06-2016 */

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
                this.rbPN.Checked = true;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rbPTN_CheckedChanged(object sender, EventArgs e)
        {
            this.gbPCA.Enabled = false;
            this.gbPN_2.Enabled = false;
            this.gbPNE.Enabled = false;
            this.gbPTN.Enabled = true;

            this.reiniciaControles();
        }

        private void rbPNE_CheckedChanged(object sender, EventArgs e)
        {
            this.gbPCA.Enabled = false;
            this.gbPN_2.Enabled = false;
            this.gbPNE.Enabled = true;
            this.gbPTN.Enabled = false;

            this.reiniciaControles();
        }

        private void rbPCA_CheckedChanged(object sender, EventArgs e)
        {
            this.gbPCA.Enabled = true;
            this.gbPN_2.Enabled = false;
            this.gbPNE.Enabled = false;
            this.gbPTN.Enabled = false;

            this.reiniciaControles();
        }

        private void rbPN_CheckedChanged(object sender, EventArgs e)
        {
            this.gbPCA.Enabled = false;
            this.gbPN_2.Enabled = true;
            this.gbPNE.Enabled = false;
            this.gbPTN.Enabled = false;

            this.reiniciaControles();
        }

        private void reiniciaControles()
        {
            this.tbNombre.Text = string.Empty;
            this.cmbTipo.SelectedIndex = -1;
            this.cmbSucursal.SelectedIndex = -1;
            this.cmbUsuarios.SelectedIndex = -1;
            this.cmbArea.DataSource = null;

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

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnBuscarPTN_Click(null, null);
            }
        }

        private void tbUsuarioPU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnBuscarPU_Click(null, null);
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

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.CadetBlue;
                e.Appearance.ForeColor = Color.White;
            }
        }

        private void btnBuscarPU_2_Click(object sender, EventArgs e)
        {
            try
            {
                List<Modelos.ActivosDesc> usuarios = new List<Modelos.ActivosDesc>();

                // valida radio
                string busqueda = "nombrecompleto";

                if (this.cmbUsuarios.SelectedIndex == -1)
                {
                    // busqueda de usuarios
                    usuarios = this._activosNegocio.busquedaUsuariosResponsiva("%", busqueda);
                }
                else
                {
                    Modelos.Personas persona = (Modelos.Personas)this.cmbUsuarios.SelectedItem;

                    // busqueda de usuarios
                    usuarios = this._activosNegocio.busquedaUsuariosResponsiva(persona.nombreCompleto, busqueda);
                }

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

        private void cmbUsuarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnBuscarPU_2_Click(null, null);
            }
        }

    }
}
