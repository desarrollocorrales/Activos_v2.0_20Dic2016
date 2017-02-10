using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;

namespace Activos.GUIs.Puestos
{
    public partial class frmPuestos : Form
    {
        ICatalogosNegocio _catalogosNegocio;

        public frmPuestos()
        {
            InitializeComponent();
            this._catalogosNegocio = new CatalogosNegocio();
        }

        private void frmPuestos_Load(object sender, EventArgs e)
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
                this.cmbSucursal.DataSource = this._catalogosNegocio.getSucursales("A");
                this.cmbSucursal.DisplayMember = "nombre";
                this.cmbSucursal.ValueMember = "idSucursal";
                this.cmbSucursal.SelectedIndex = -1;

                // llena el grid con los puestos disponibles
                this.gcPuestos.DataSource = this._catalogosNegocio.getPuestos("A");

                if (this.gridView1.RowCount != 0)
                    this.gridView1.UnselectRow(0);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Puestos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (string.IsNullOrEmpty(this.tbNombrePuesto.Text))
                    throw new Exception("Llene el nombre del puesto");

                string puestoNom = this.tbNombrePuesto.Text;

                if (this.cmbSucursal.SelectedIndex == -1)
                    throw new Exception("Seleccione una sucursal");

                int idSuc = Convert.ToInt16(this.cmbSucursal.SelectedValue);

                // guardado de informacion
                bool resultado = this._catalogosNegocio.agregaPuesto(puestoNom, idSuc);

                if (resultado)
                {
                    MessageBox.Show("Puesto agregado correctamente", "Agregar Puestos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tbNombrePuesto.Text = string.Empty;
                    this.cmbSucursal.SelectedIndex = -1;
                }

                // actualizar grid
                this.gcPuestos.DataSource = this._catalogosNegocio.getPuestos("A");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Agregar Puestos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActivaP_Click(object sender, EventArgs e)
        {
            try
            {
                frmActPuestos form = new frmActPuestos();

                var result = form.ShowDialog();

                if (result == DialogResult.OK || result == DialogResult.Cancel)
                {
                    // llena el grid con los puestos disponibles
                    this.gcPuestos.DataSource = this._catalogosNegocio.getPuestos("A");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Puestos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnElimSelecc_Click(object sender, EventArgs e)
        {
            try
            {
                List<Modelos.Puestos> puestos = (List<Modelos.Puestos>)this.gridView1.DataSource;

                // obtiene los ids de los puestos seleccionadas
                List<int> seleccionados = puestos.Where(w => w.seleccionado == true).Select(s => s.idPuesto).ToList();

                if (seleccionados.Count == 0)
                    throw new Exception("No se ha seleccionado ningun puesto");

                DialogResult dialogResult = MessageBox.Show(
                                "¿Desea dar de baja los puestos seleccionadas?",
                                "Áreas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.No) return;

                // dar de baja los seleccionados
                bool resultado = this._catalogosNegocio.bajaPuestos(seleccionados);

                if (resultado)
                    MessageBox.Show("Puesto(s) dado(s) de baja correctamente", "Puestos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // llena el grid con los puestos disponibles
                this.gcPuestos.DataSource = this._catalogosNegocio.getPuestos("A");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Puestos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gcPuestos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                // PERMISOS
                if (!Modelos.Login.permisos.Contains(54))
                    return;

                if (this.gridView1.GetSelectedRows().Count() == 0)
                    throw new Exception("No a seleccionado un puesto");

                Modelos.Puestos ent = new Modelos.Puestos();

                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    var dr1 = this.gridView1.GetRow(i);

                    ent = (Modelos.Puestos)dr1;
                }

                frmModifPuestos form = new frmModifPuestos(ent.idPuesto, ent.nombre, ent.idSucursal);
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // llena el grid con los puestos disponibles
                    this.gcPuestos.DataSource = this._catalogosNegocio.getPuestos("A");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
