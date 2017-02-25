using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;

namespace Activos.GUIs.Tipos
{
    public partial class frmActTipos : Form
    {
        ICatalogosNegocio _catalogosNegocio;

        public frmActTipos()
        {
            InitializeComponent();
            this._catalogosNegocio = new CatalogosNegocio();
        }

        private void frmActTipos_Load(object sender, EventArgs e)
        {
            try
            {
                // llena el grid con los puestos disponibles
                this.gcTipos.DataSource = this._catalogosNegocio.getTipos("B");

                if (this.gridView1.RowCount != 0)
                    this.gridView1.UnselectRow(0);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Tipos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActiva_Click(object sender, EventArgs e)
        {
            try
            {
                List<Modelos.Tipos> tipos = (List<Modelos.Tipos>)this.gridView1.DataSource;

                // obtiene los ids de las sucursales seleccionadas
                List<int> seleccionados = tipos.Where(w => w.seleccionado == true).Select(s => s.idTipo).ToList();
                List<string> strings = tipos.Where(w => w.seleccionado == true).Select(s => s.nombre).ToList();

                if (seleccionados.Count == 0)
                    throw new Exception("No se ha seleccionado ningun tipo");

                // dar de baja los seleccionados
                bool resultado = this._catalogosNegocio.activaTipos(seleccionados, strings);

                if (resultado)
                    MessageBox.Show("Tipo(s) activado(s) correctamente", "Tipos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // llena el grid con los tipos disponibles
                this.gcTipos.DataSource = this._catalogosNegocio.getTipos("B");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activar Tipos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bntCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
