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
    public partial class frmActPuestos : Form
    {
        ICatalogosNegocio _catalogosNegocio;

        public frmActPuestos()
        {
            InitializeComponent();
            this._catalogosNegocio = new CatalogosNegocio();
        }

        private void frmActPuestos_Load(object sender, EventArgs e)
        {
            // llena el grid con las sucursales disponibles
            this.gcPuestosBaja.DataSource = this._catalogosNegocio.getPuestos("B");

            if (this.gridView1.RowCount != 0)
                this.gridView1.UnselectRow(0);
        }

        private void btnActiva_Click(object sender, EventArgs e)
        {

            try
            {
                List<Modelos.Puestos> puestos = (List<Modelos.Puestos>)this.gridView1.DataSource;

                // obtiene los ids de las sucursales seleccionadas
                List<int> seleccionados = puestos.Where(w => w.seleccionado == true).Select(s => s.idPuesto).ToList();

                if (seleccionados.Count == 0)
                    throw new Exception("No se ha seleccionado ningun puesto");

                // dar de baja los seleccionados
                bool resultado = this._catalogosNegocio.activaPuestos(seleccionados);

                if (resultado)
                    MessageBox.Show("Puesto(s) activado(s) correctamente", "Puestos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // llena el grid con las puestos disponibles
                this.gcPuestosBaja.DataSource = this._catalogosNegocio.getPuestos("B");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activar Puestos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bntCerrar_Click(object sender, EventArgs e)
        {
            // cerrar formularios
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
