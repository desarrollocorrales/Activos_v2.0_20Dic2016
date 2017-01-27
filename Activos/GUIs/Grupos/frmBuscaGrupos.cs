using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;

namespace Activos.GUIs.Grupos
{
    public partial class frmBuscaGrupos : Form
    {
        ICatalogosNegocio _catalogosNegocio;
        IActivosNegocio _activosNegocio;

        public Modelos.Grupos _grupo;
        public List<Modelos.Activos> _activos;

        public frmBuscaGrupos()
        {
            InitializeComponent();

            this._catalogosNegocio = new CatalogosNegocio();
            this._activosNegocio = new ActivosNegocio();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string grupoNombre = this.tbNomGrupo.Text;

                List<Modelos.Grupos> grupos = this._catalogosNegocio.getGrupos(grupoNombre);

                if (grupos.Count == 0)
                    throw new Exception("Sin resultados");

                this.gcGrupos.DataSource = grupos;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Grupos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gcGrupos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.gridView1.GetSelectedRows().Count() == 0)
                    throw new Exception("No a seleccionado un grupo");

                this._grupo = new Modelos.Grupos();

                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    var dr1 = this.gridView1.GetRow(i);

                    this._grupo = (Modelos.Grupos)dr1;
                }

                this._activos = this._activosNegocio.getBuscaActivosGrupo(this._grupo.idGrupo);

                if (this._activos.Count == 0)
                    throw new Exception("Sin resultados");

                this.gcActivos.DataSource = null;
                this.gcActivos.DataSource = this._activos;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Grupos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._grupo == null)
                    throw new Exception("Seleccione un grupo");

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Grupos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbNomGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnBuscar_Click(null, null);
            }
        }
    }
}
