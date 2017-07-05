using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;

namespace Activos.GUIs.Permisos
{
    public partial class frmBuscaUsuario : Form
    {
        ICatalogosNegocio _catalogosNegocio;
        public Modelos.PersonaResponsivas _usuario;

        public frmBuscaUsuario()
        {
            InitializeComponent();
            this._catalogosNegocio = new CatalogosNegocio();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // busqueda de usuarios
                List<Modelos.PersonaResponsivas> usuarios = this._catalogosNegocio.busquedaUsuarios(this.tbUsuario.Text);

                if (usuarios.Count == 0)
                {
                    this.gcUsuarios.DataSource = null;
                    this.ActiveControl = this.tbUsuario;
                    this.tbUsuario.SelectAll();
                    throw new Exception("Sin resultados");
                }

                this.gcUsuarios.DataSource = usuarios;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gcUsuarios_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.gridView1.GetSelectedRows().Count() == 0)
                    throw new Exception("No a seleccionado un usuario");

                this._usuario = new Modelos.PersonaResponsivas();

                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    var dr1 = this.gridView1.GetRow(i);

                    this._usuario = (Modelos.PersonaResponsivas)dr1;
                }

                this.tbUsuarioSeleccionado.Text = this._usuario.nombre;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._usuario == null) throw new Exception("Seleccione un usuario");

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void tbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnBuscar_Click(null, null);
            }
        }

        private void frmBuscaUsuario_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.tbUsuario;
        }
    }
}
