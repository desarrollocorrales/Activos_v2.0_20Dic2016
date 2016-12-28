using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;

namespace Activos.GUIs.Usuarios
{
    public partial class frmActUs : Form
    {
        ICatalogosNegocio _catalogosNegocio;

        public frmActUs()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this._catalogosNegocio = new CatalogosNegocio();
        }

        private void frmActUs_Load(object sender, EventArgs e)
        {
            // llena el grid con las sucursales disponibles
            this.gcUsuariosBaja.DataSource = this._catalogosNegocio.getResponsables("B");

            if (this.gridView1.RowCount != 0)
                this.gridView1.UnselectRow(0);
        }

        private void btnActiva_Click(object sender, EventArgs e)
        {
            try
            {
                List<Modelos.Usuarios> sucursales = (List<Modelos.Usuarios>)this.gridView1.DataSource;

                // obtiene los ids de los usuarios seleccionadas
                List<int> seleccionados = sucursales.Where(w => w.seleccionado == true).Select(s => s.idUsuario).ToList();

                if (seleccionados.Count == 0)
                    throw new Exception("No se ha seleccionado ningun usuario");

                // dar de baja los seleccionados
                bool resultado = this._catalogosNegocio.activaUsuarios(seleccionados);

                if (resultado)
                    MessageBox.Show("Usuarios(s) activado(s) correctamente", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // llena el grid con las sucursales disponibles
                this.gcUsuariosBaja.DataSource = this._catalogosNegocio.getResponsables("B");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activar Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
