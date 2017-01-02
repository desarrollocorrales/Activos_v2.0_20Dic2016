using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;

namespace Activos.GUIs.Responsivas
{
    public partial class frmResponsivas : Form
    {
        ICatalogosNegocio _catalogosNegocio;
        IResponsivasNegocio _responsivasNegocio;

        private int? _idUsuario = null;

        public frmResponsivas()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this._catalogosNegocio = new CatalogosNegocio();
            this._responsivasNegocio = new ResponsivasNegocio();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // valida radio
                string busqueda = this.rbUsuario.Checked ? "usuario" : "nombre";

                // busqueda de usuarios
                List<Modelos.UsuariosResponsivas> usuarios = this._catalogosNegocio.busquedaUsuarios(this.tbUsuario.Text, busqueda);

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
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gcUsuarios_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.gridView1.GetSelectedRows().Count() == 0)
                    return;

                Modelos.UsuariosResponsivas ent = new Modelos.UsuariosResponsivas();

                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    var dr1 = this.gridView1.GetRow(i);

                    ent = (Modelos.UsuariosResponsivas)dr1;
                }

                // imprime datos
                this.lbUsuarios.Text = ent.nomUsuario;
                this.lbSucursal.Text = ent.sucursal;
                this.lbPuesto.Text = ent.puesto;

                this._idUsuario = ent.idUsuario;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscaActivos_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscaActivos form = new frmBuscaActivos();

                var result = form.ShowDialog();

                if (result == DialogResult.OK || result == DialogResult.Cancel)
                {
                    // llena el grid con las areas disponibles
                    //this.gcActivos.DataSource = this._.getAreas("A");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
