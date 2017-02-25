using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;

namespace Activos.GUIs.Reportes
{
    public partial class frmMovimientosActivos : Form
    {
        ICatalogosNegocio _catalogosNegocio;
        IActivosNegocio _activosNegocio;

        public Modelos.ActivosDesc _activoSelecc;

        public frmMovimientosActivos()
        {
            InitializeComponent();

            // acomoda radios
            this.rbPN.Location = new Point(this.gbPTN.Location.X + 13, this.gbPTN.Location.Y - 1);
            this.rbPNE.Location = new Point(this.gbPNE.Location.X + 13, this.gbPNE.Location.Y - 1);
            this.rbPCA.Location = new Point(this.gbPCA.Location.X + 13, this.gbPCA.Location.Y - 1);

            // inicializa variables
            this._catalogosNegocio = new CatalogosNegocio();
            this._activosNegocio = new ActivosNegocio();
        }

        private void frmMovimientosActivos_Load(object sender, EventArgs e)
        {
            try
            {
                // carga el combo de tipos
                this.cmbTipo.DisplayMember = "nombre";
                this.cmbTipo.ValueMember = "idTipo";
                this.cmbTipo.DataSource = this._catalogosNegocio.getTipos("A");
                this.cmbTipo.SelectedIndex = -1;

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

        private void btnBuscarPCA_Click(object sender, EventArgs e)
        {
            try
            {
                string cveActivo = this.tbCveActivo.Text;

                List<Modelos.ActivosDesc> resultado = this._activosNegocio.getBuscaActivosResp(cveActivo, "CA");

                if (resultado.Count == 0)
                {
                    this.gridControl1.DataSource = null;
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

                this.gridControl1.DataSource = resultado;
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

                if (this.cmbArea.SelectedIndex == -1)
                    throw new Exception("Seleccione un área");

                if (this.cmbTipo.SelectedIndex == -1)
                    throw new Exception("Seleccione un tipo");

                int idSucursal = (int)this.cmbSucursal.SelectedValue;
                int idArea = (int)this.cmbArea.SelectedValue;
                int idTipo = (int)this.cmbTipo.SelectedValue;
                string nombre = this.tbNombre.Text;

                List<Modelos.ActivosDesc> resultado = this._activosNegocio.getBuscaActivosResp(idArea, idTipo, nombre, "A");

                if (resultado.Count == 0)
                {
                    this.gridControl1.DataSource = null;
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

                this.gridControl1.DataSource = resultado;
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
                    this.gridControl1.DataSource = null;
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

                this.gridControl1.DataSource = resultado;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.gridView2.GetSelectedRows().Count() == 0)
                    return;

                this._activoSelecc = new Modelos.ActivosDesc();

                foreach (int i in this.gridView2.GetSelectedRows())
                {
                    var dr1 = this.gridView2.GetRow(i);

                    this._activoSelecc = (Modelos.ActivosDesc)dr1;
                }

                // imprime datos
                this.tbResultNombre.Text = this._activoSelecc.nombreCorto;
                this.tbResultNumEtiqueta.Text = this._activoSelecc.numEtiqueta;
                this.tbResultCveActivo.Text = this._activoSelecc.claveActivo;

                List<Modelos.Cambios> cambios = this._activosNegocio.getCambios(this._activoSelecc.idActivo);

                if (cambios.Count == 0)
                {
                    this.tbResultNombre.Text = string.Empty;
                    this.tbResultNumEtiqueta.Text = string.Empty;
                    this.tbResultCveActivo.Text = string.Empty;

                    this.gcCambios.DataSource = null;

                    throw new Exception("Sin Resultados");
                }

                this.gcCambios.DataSource = cambios;

                this.gridView1.BestFitColumns();
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
                this.cmbArea.DataSource = this._catalogosNegocio.getAreas(idSucursal);
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

        private void rbPN_CheckedChanged(object sender, EventArgs e)
        {
            this.gbPCA.Enabled = false;
            this.gbPNE.Enabled = false;
            this.gbPTN.Enabled = true;

            this.reiniciaControles();
        }

        private void rbPNE_CheckedChanged(object sender, EventArgs e)
        {
            this.gbPCA.Enabled = false;
            this.gbPNE.Enabled = true;
            this.gbPTN.Enabled = false;

            this.reiniciaControles();
        }

        private void rbPCA_CheckedChanged(object sender, EventArgs e)
        {
            this.gbPCA.Enabled = true;
            this.gbPNE.Enabled = false;
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

            this.gridControl1.DataSource = null;
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            try
            {

                // bitacora
                this._catalogosNegocio.generaBitacora(
                    "Genera Reporte 'Movimientos de Activo' con parametros:" +
                    " idActivo: " + this._activoSelecc.idActivo, "CONSULTAS");


                this.gridView1.BestFitColumns();
                this.gcCambios.ShowPrintPreview();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            
        }

        private void gridView2_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.CadetBlue;
                e.Appearance.ForeColor = Color.White;
            }
        }
        

    }
}
