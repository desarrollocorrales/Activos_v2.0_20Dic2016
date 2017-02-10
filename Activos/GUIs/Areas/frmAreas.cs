using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;

namespace Activos.GUIs.Areas
{
    public partial class frmAreas : Form
    {
        ICatalogosNegocio _catalogosNegocio;

        public frmAreas()
        {
            InitializeComponent();
            this._catalogosNegocio = new CatalogosNegocio();
        }

        private void frmAreas_Load(object sender, EventArgs e)
        {
            try
            {
                // permisos
                foreach (Control x in this.Controls)
                {
                    if (x is Button)
                    {
                        int tag = Convert.ToInt16(((Button)x).Tag);

                        if (!Modelos.Login.permisos.Contains(tag))
                            ((Button)x).Enabled = false;
                    }
                }

                // llena el catalogo de sucursales disponibles
                this.cmbSucursales.DataSource = this._catalogosNegocio.getSucursales("A");
                this.cmbSucursales.DisplayMember = "nombre";
                this.cmbSucursales.ValueMember = "idSucursal";
                this.cmbSucursales.SelectedIndex = -1;

                // llena el grid con las areas disponibles
                this.gcAreas.DataSource = this._catalogosNegocio.getAreas("A");

                if (this.gridView1.RowCount != 0)
                    this.gridView1.UnselectRow(0);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Áreas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (string.IsNullOrEmpty(this.tbNombreAreas.Text))
                    throw new Exception("Llene el nombre del área");

                string areaNom = this.tbNombreAreas.Text;

                if (this.cmbSucursales.SelectedIndex == -1)
                    throw new Exception("Seleccione una sucursal");

                int idSuc = Convert.ToInt16(this.cmbSucursales.SelectedValue);

                // guardado de informacion
                bool resultado = this._catalogosNegocio.agregaArea(areaNom, idSuc);

                if (resultado)
                {
                    MessageBox.Show("Área agregada correctamente", "Agregar áreas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tbNombreAreas.Text = string.Empty;
                    this.cmbSucursales.SelectedIndex = -1;
                }

                // actualizar grid
                this.gcAreas.DataSource = this._catalogosNegocio.getAreas("A");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Agregar Áreas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActivaA_Click(object sender, EventArgs e)
        {

            try
            {
                frmActAreas form = new frmActAreas();
                
                var result = form.ShowDialog();

                if (result == DialogResult.OK || result == DialogResult.Cancel)
                {
                    // llena el grid con las areas disponibles
                    this.gcAreas.DataSource = this._catalogosNegocio.getAreas("A");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Áreas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnElimSelecc_Click(object sender, EventArgs e)
        {
            try
            {
                List<Modelos.Areas> areas = (List<Modelos.Areas>)this.gridView1.DataSource;

                // obtiene los ids de los puestos seleccionadas
                List<int> seleccionados = areas.Where(w => w.seleccionado == true).Select(s => s.idArea).ToList();

                if (seleccionados.Count == 0)
                    throw new Exception("No se ha seleccionado ningun área");

                DialogResult dialogResult = MessageBox.Show(
                                "¿Desea dar de baja las áreas seleccionadas?",
                                "Áreas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.No) return;

                // dar de baja los seleccionados
                bool resultado = this._catalogosNegocio.bajaAreas(seleccionados);

                if (resultado)
                    MessageBox.Show("Áreas(s) dada(s) de baja correctamente", "Áreas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // llena el grid con las areas disponibles
                this.gcAreas.DataSource = this._catalogosNegocio.getAreas("A");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Áreas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gcAreas_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                // PERMISOS
                if (!Modelos.Login.permisos.Contains(55))
                    return;

                if (this.gridView1.GetSelectedRows().Count() == 0)
                    throw new Exception("No a seleccionado un área");

                Modelos.Areas ent = new Modelos.Areas();

                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    var dr1 = this.gridView1.GetRow(i);

                    ent = (Modelos.Areas)dr1;
                }

                frmModifArea form = new frmModifArea(ent.idArea, ent.nombre, ent.idSucursal);
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // llena el grid con las areas disponibles
                    this.gcAreas.DataSource = this._catalogosNegocio.getAreas("A");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
