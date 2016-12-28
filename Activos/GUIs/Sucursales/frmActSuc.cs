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
    public partial class frmActSuc : Form
    {
        ICatalogosNegocio _catalogosNegocio;

        public frmActSuc()
        {
            InitializeComponent();

            this._catalogosNegocio = new CatalogosNegocio();
        }

        private void frmActSuc_Load(object sender, EventArgs e)
        {
            // llena el grid con las sucursales disponibles
            this.gcSucursalesBaja.DataSource = this._catalogosNegocio.getSucursales("B");

            if (this.gridView1.RowCount != 0)
                this.gridView1.UnselectRow(0);
        }

        private void btnActiva_Click(object sender, EventArgs e)
        {
            try
            {
                List<Modelos.Sucursales> sucursales = (List<Modelos.Sucursales>)this.gridView1.DataSource;

                // obtiene los ids de las sucursales seleccionadas
                List<int> seleccionados = sucursales.Where(w => w.seleccionado == true).Select(s => s.idSucursal).ToList();

                if (seleccionados.Count == 0)
                    throw new Exception("No se ha seleccionado ninguna sucursal");

                // dar de baja los seleccionados
                bool resultado = this._catalogosNegocio.activaSucursalas(seleccionados);

                if (resultado)
                    MessageBox.Show("Sucursal(es) activada(s) correctamente", "Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // llena el grid con las sucursales disponibles
                this.gcSucursalesBaja.DataSource = this._catalogosNegocio.getSucursales("B");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activar Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
