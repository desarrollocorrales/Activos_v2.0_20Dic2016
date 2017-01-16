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
    public partial class frmBuscarResponsiva : Form
    {
        ICatalogosNegocio _catalogosNegocio;
        IResponsivasNegocio _responsivasNegocio;
        IActivosNegocio _activosNegocio;

        public Modelos.Responsivas _responsiva;
        public List<Modelos.Activos> _activos;

        public frmBuscarResponsiva()
        {
            InitializeComponent();
            this._catalogosNegocio = new CatalogosNegocio();
            this._responsivasNegocio = new ResponsivasNegocio();
            this._activosNegocio = new ActivosNegocio();
        }

        private void frmBuscarResponsiva_Load(object sender, EventArgs e)
        {
            try
            {
                // llena el catalogo de sucursales disponibles
                this.cmbSucursal.DataSource = this._catalogosNegocio.getSucursales("A");
                this.cmbSucursal.DisplayMember = "nombre";
                this.cmbSucursal.ValueMember = "idSucursal";
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
                if (this.cmbSucursal.SelectedIndex == -1)
                    throw new Exception("Seleccione una sucursal");

                string responsable = this.tbResp.Text;
                int idSuc = (int)this.cmbSucursal.SelectedValue;

                List<Modelos.Responsivas> responsivas = this._responsivasNegocio.buscaResponsiva(responsable, idSuc);

                this._activos = null;

                this.tbRespDe.Text = string.Empty;

                this.gcActivos.DataSource = this._activos;

                this._responsiva = null;

                if (responsivas.Count == 0)
                {
                    this.gcResponsables.DataSource = null;

                    throw new Exception("Sin resultados");
                }

                this.gcResponsables.DataSource = responsivas;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gcResponsables_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.gridView1.GetSelectedRows().Count() == 0)
                    throw new Exception("No a seleccionado una responsiva");

                this._responsiva = new Modelos.Responsivas();

                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    var dr1 = this.gridView1.GetRow(i);

                    this._responsiva = (Modelos.Responsivas)dr1;
                }

                this._activos = this._activosNegocio.getBuscaActivos(this._responsiva.idResponsiva);

                this.tbRespDe.Text = this._responsiva.responsable;

                this.gcActivos.DataSource = this._activos;               

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (this._responsiva == null) throw new Exception("Seleccione una responsiva");

                this.DialogResult = System.Windows.Forms.DialogResult.OK;

                this.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
