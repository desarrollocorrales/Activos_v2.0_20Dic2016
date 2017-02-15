using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;

namespace Activos.GUIs.Sucursales
{
    public partial class frmSucursales : Form
    {
        ICatalogosNegocio _catalogosNegocio;

        public frmSucursales()
        {
            InitializeComponent();
            this._catalogosNegocio = new CatalogosNegocio();
        }

        private void frmSucursales_Load(object sender, EventArgs e)
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

                // llena el catalogo de responsables (usuarios) disponibles
                this.cmbResponsable.DataSource = this._catalogosNegocio.getPersonas("", "A");
                this.cmbResponsable.DisplayMember = "nombreCompleto";
                this.cmbResponsable.ValueMember = "idPersona";
                this.cmbResponsable.SelectedIndex = -1;

                // llena el grid con las sucursales disponibles
                this.gcSucursales.DataSource = this._catalogosNegocio.getSucursales("A");

                if (this.gridView1.RowCount != 0)
                    this.gridView1.UnselectRow(0);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (string.IsNullOrEmpty(this.tbNombreSuc.Text))
                    throw new Exception("Llene el nombre de la sucursal");

                string sucNom = this.tbNombreSuc.Text;

                int? idResp = null;

                if (this.cmbResponsable.SelectedIndex != -1)
                {
                    int sv = Convert.ToInt16(this.cmbResponsable.SelectedValue);

                    if (sv != -1)
                        idResp = sv;
                }

                // guardado de informacion
                bool resultado = this._catalogosNegocio.agregaSucursal(sucNom, idResp);

                if (resultado)
                {
                    MessageBox.Show("Sucursal agregada correctamente", "Agregar Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tbNombreSuc.Text = string.Empty;
                    this.cmbResponsable.SelectedIndex = -1;
                }

                // actualizar grid
                this.gcSucursales.DataSource = this._catalogosNegocio.getSucursales("A");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Agregar Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnElimSelecc_Click(object sender, EventArgs e)
        {
            try
            {
                List<Modelos.Sucursales> sucursales = (List<Modelos.Sucursales>)this.gridView1.DataSource;

                // obtiene los ids de las sucursales seleccionadas
                List<int> seleccionados = sucursales.Where(w => w.seleccionado == true).Select(s => s.idSucursal).ToList();

                if (seleccionados.Count == 0)
                    throw new Exception("No se ha seleccionado ninguna sucursal");

                DialogResult dialogResult = MessageBox.Show(
                                "¿Desea dar de baja las sucursales seleccionadas?",
                                "Áreas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.No) return;

                // dar de baja los seleccionados
                bool resultado = this._catalogosNegocio.bajaSucursalas(seleccionados);

                if(resultado)
                    MessageBox.Show("Sucursal(es) dada(s) de baja correctamente", "Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // llena el grid con las sucursales disponibles
                this.gcSucursales.DataSource = this._catalogosNegocio.getSucursales("A");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gcSucursales_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                // PERMISOS
                if (!Modelos.Login.permisos.Contains(53))
                    return;

                if (this.gridView1.GetSelectedRows().Count() == 0)
                    throw new Exception("No a seleccionado una sucursal");

                Modelos.Sucursales ent = new Modelos.Sucursales();

                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    var dr1 = this.gridView1.GetRow(i);

                    ent = (Modelos.Sucursales)dr1;
                }

                frmModifSuc form = new frmModifSuc(ent.idResponsable, ent.nombre, ent.idSucursal);
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // llena el grid con las sucursales disponibles
                    this.gcSucursales.DataSource = this._catalogosNegocio.getSucursales("A");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActivaS_Click(object sender, EventArgs e)
        {
            try
            {
                frmActSuc form = new frmActSuc();

                var result = form.ShowDialog();

                if (result == DialogResult.OK || result == DialogResult.Cancel)
                {
                    // llena el grid con las sucursales disponibles
                    this.gcSucursales.DataSource = this._catalogosNegocio.getSucursales("A");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
        }
    }
}
