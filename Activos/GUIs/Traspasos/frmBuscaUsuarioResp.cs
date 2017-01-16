using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;

namespace Activos.GUIs.Traspasos
{
    public partial class frmBuscaUsuarioResp : Form
    {
        ICatalogosNegocio _catalogosNegocio;
        IResponsivasNegocio _responsivasNegocio;
        IActivosNegocio _activosNegocio;

        public bool _nuevaResp = false;
        public bool _respSelec = false;

        public Modelos.Responsivas _responsiva;
        public Modelos.UsuariosResponsivas _usuario;
        public List<Modelos.Activos> _activos;

        public frmBuscaUsuarioResp()
        {
            InitializeComponent();
            this._catalogosNegocio = new CatalogosNegocio();
            this._responsivasNegocio = new ResponsivasNegocio();
            this._activosNegocio = new ActivosNegocio();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // valida radio
                string busqueda = this.rbUsuario.Checked ? "usuario" : "nombrecompleto";

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
                MessageBox.Show(Ex.Message, "Taspasos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gcUsuarios_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this._activos = null;
                this._responsiva = null;

                if (this.gridView1.GetSelectedRows().Count() == 0)
                    throw new Exception("No a seleccionado un usuario");

                this._usuario = new Modelos.UsuariosResponsivas();

                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    var dr1 = this.gridView1.GetRow(i);

                    this._usuario = (Modelos.UsuariosResponsivas)dr1;
                }

                // busca responsivas segun un usuario
                List<Modelos.Responsivas> responsivas = this._responsivasNegocio.buscaResponsiva(this._usuario.idUsuario);

                if (responsivas.Count == 0)
                {
                    this.gcResponsivas.DataSource = null;
                    this.gcActivos.DataSource = null;
                    throw new Exception("El usuario no tiene responsivas");
                }
                this.tbUsuarioSeleccionado.Text = this._usuario.nomUsuario;

                this.gcResponsivas.DataSource = responsivas;
                this.gcActivos.DataSource = null;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Taspasos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gcResponsivas_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.gridView2.GetSelectedRows().Count() == 0)
                    throw new Exception("No a seleccionado una responsiva");

                this._responsiva = new Modelos.Responsivas();

                foreach (int i in this.gridView2.GetSelectedRows())
                {
                    var dr1 = this.gridView2.GetRow(i);

                    this._responsiva = (Modelos.Responsivas)dr1;
                }

                // busca responsivas segun un usuario
                this._activos = this._activosNegocio.getBuscaActivos(this._responsiva.idResponsiva);

                this.gcActivos.DataSource = this._activos;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Taspasos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnNuevaResp_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._usuario == null)
                    throw new Exception("Seleccione un usuario");

                this.DialogResult = System.Windows.Forms.DialogResult.OK;

                this._responsiva = new Modelos.Responsivas();
                this._nuevaResp = true;

                this.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Taspasos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRespSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._responsiva == null)
                    throw new Exception("Seleccione una responsiva");

                this.DialogResult = System.Windows.Forms.DialogResult.OK;

                this._respSelec = true;

                this.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Taspasos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
