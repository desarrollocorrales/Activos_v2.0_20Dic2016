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
    public partial class frmBajaGrupos : Form
    {
        private Modelos.Grupos _grupo;
        private List<Modelos.Activos> _activos;

        private int? _idArea;
        private ICatalogosNegocio _catalogosNegocio;

        public frmBajaGrupos()
        {
            InitializeComponent();
            this._catalogosNegocio = new CatalogosNegocio();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscaGrupos form = new frmBuscaGrupos();

                var result = form.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    this._activos = form._activos;
                    this._grupo = form._grupo;

                    this.tbArea.Text = this._grupo.area;
                    this.tbNombre.Text = this._grupo.nombre;

                    // llena el grid los activos seleccionados
                    this.gcActivos.DataSource = null;
                    this.gcActivos.DataSource = this._activos;

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Grupos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnElimGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (this._grupo == null)
                    throw new Exception("Seleccione un grupo");

                DialogResult dialogResult = MessageBox.Show(
                                "¿Desea eliminar el grupo seleccionado?",
                                "Áreas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.No) return;

                bool resultado = this._catalogosNegocio.bajaGrupo(this._grupo.idGrupo);

                if (resultado)
                {
                    MessageBox.Show("Grupo eliminado correctamente", "Grupos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.tbNombre.Text = string.Empty;
                    this.tbArea.Text = string.Empty;

                    _grupo = null;
                    _activos = null;

                    _idArea = null;

                    this.gcActivos.DataSource = null;
                }
                else
                    throw new Exception("Problemas en la eliminación del activo");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Grupos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
