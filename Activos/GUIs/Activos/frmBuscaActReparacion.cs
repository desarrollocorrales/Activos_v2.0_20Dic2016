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
    public partial class frmBuscaActReparacion : Form
    {
        ICatalogosNegocio _catalogosNegocio;
        IReparacionesNegocio _reparacionesNegocio;

        public Modelos.Reparaciones _activoSelecc;

        public frmBuscaActReparacion()
        {
            InitializeComponent();


            this._catalogosNegocio = new CatalogosNegocio();
            this._reparacionesNegocio = new ReparacionesNegocio();
        }

        private void frmReparaActivos_Load(object sender, EventArgs e)
        {
            try
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
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
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

                List<Modelos.Reparaciones> resultado = this._reparacionesNegocio.getBuscaActivosReparacion(idSucursal, idArea, idTipo, nombre);

                if (resultado.Count == 0)
                {
                    this.gcReparaciones.DataSource = null;
                    this.ActiveControl = this.tbNombre;
                    this.tbNombre.SelectAll();
                    throw new Exception("Sin resultados");
                }

                this.gcReparaciones.DataSource = resultado;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gcReparaciones_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.gridView1.GetSelectedRows().Count() == 0)
                    return;

                this._activoSelecc = new Modelos.Reparaciones();

                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    var dr1 = this.gridView1.GetRow(i);

                    this._activoSelecc = (Modelos.Reparaciones)dr1;
                }

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
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
                this.btnBuscar_Click(null, null);
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
    }
}
