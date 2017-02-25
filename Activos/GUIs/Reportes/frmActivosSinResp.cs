using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;

namespace Activos.GUIs.Reportes
{
    public partial class frmActivosSinResp : Form
    {
        ICatalogosNegocio _catalogosNegocio;
        IActivosNegocio _activosNegocio;

        public frmActivosSinResp()
        {
            InitializeComponent();

            // inicializa variables
            this._catalogosNegocio = new CatalogosNegocio();
            this._activosNegocio = new ActivosNegocio();
        }

        private void frmActivosSinResp_Load(object sender, EventArgs e)
        {
            // llenar combo de sucursales
            this.cmbSucursal.DisplayMember = "nombre";
            this.cmbSucursal.ValueMember = "idSucursal";
            this.cmbSucursal.DataSource = this._catalogosNegocio.getSucursales("A");
            this.cmbSucursal.SelectedIndex = -1;

        }

        private void cmbSucursal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                int idSucursal = (int)this.cmbSucursal.SelectedValue;

                // llenar combo de Tipos
                this.cmbArea.DataSource = this._catalogosNegocio.getAreas(idSucursal);
                this.cmbArea.DisplayMember = "nombre";
                this.cmbArea.ValueMember = "idArea";
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
                // validaciones 
                if (this.cmbSucursal.SelectedIndex == -1)
                throw new Exception("Seleccione una sucursal");

                if (this.cmbArea.SelectedIndex == -1)
                    throw new Exception("Seleccione un área");

                int idSucursal = (int)this.cmbSucursal.SelectedValue;
                int idArea = (int)this.cmbArea.SelectedValue;

                List<Modelos.Activos> resultado = this._activosNegocio.getBuscaActivos(idSucursal, idArea);

                string sucursal = ((Modelos.Sucursales)this.cmbSucursal.SelectedItem).nombre;

                foreach (Modelos.Activos a in resultado)
                    a.status = sucursal;

                if (resultado.Count == 0)
                {
                    this.gcActivos.DataSource = null;
                    throw new Exception("Sin resultados");
                }

                this.gcActivos.DataSource = resultado;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            try
            {
                string sucursal = ((Modelos.Sucursales)this.cmbSucursal.SelectedItem).nombre;
                string areas = ((Modelos.Areas)this.cmbArea.SelectedItem).nombre;

                // bitacora
                this._catalogosNegocio.generaBitacora(
                    "Genera Reporte 'Activos sin Responsivas' con parametros:" +
                    " sucursal: " + sucursal +
                    " area: " + areas, "CONSULTAS");

                this.gridView2.BestFitColumns();
                this.gcActivos.ShowPrintPreview();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
