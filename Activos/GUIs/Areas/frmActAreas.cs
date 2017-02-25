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
    public partial class frmActAreas : Form
    {
        ICatalogosNegocio _catalogosNegocio;

        public frmActAreas()
        {
            InitializeComponent();
            this._catalogosNegocio = new CatalogosNegocio();
        }

        private void frmActAreas_Load(object sender, EventArgs e)
        {

            // llena el grid con las sucursales disponibles
            this.gcAreasBaja.DataSource = this._catalogosNegocio.getAreas("B");

            if (this.gridView1.RowCount != 0)
                this.gridView1.UnselectRow(0);
        }

        private void bntCerrar_Click(object sender, EventArgs e)
        {
            // cerrar formularios
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnActiva_Click(object sender, EventArgs e)
        {
            try
            {
                List<Modelos.Areas> areas = (List<Modelos.Areas>)this.gridView1.DataSource;

                // obtiene los ids de las sucursales seleccionadas
                List<int> seleccionados = areas.Where(w => w.seleccionado == true).Select(s => s.idArea).ToList();
                List<string> strings = areas.Where(w => w.seleccionado == true).Select(s => s.nombre).ToList();

                if (seleccionados.Count == 0)
                    throw new Exception("No se ha seleccionado ningun área");

                // dar de baja los seleccionados
                bool resultado = this._catalogosNegocio.activaAreas(seleccionados, strings);

                if (resultado)
                    MessageBox.Show("Áreas(s) activada(s) correctamente", "Áreas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // llena el grid con las sucursales disponibles
                this.gcAreasBaja.DataSource = this._catalogosNegocio.getAreas("B");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activar Áreas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
