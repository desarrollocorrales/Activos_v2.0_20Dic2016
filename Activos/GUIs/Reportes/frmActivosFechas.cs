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
    public partial class frmActivosFechas : Form
    {
        ICatalogosNegocio _catalogosNegocio;
        IActivosNegocio _activosNegocio;
        private List<Modelos.Activos> _resultado = new List<Modelos.Activos>();
        public frmActivosFechas()
        {
            InitializeComponent();

            // inicializa variables
            this._catalogosNegocio = new CatalogosNegocio();
            this._activosNegocio = new ActivosNegocio();
        }

        private void frmActivosFechas_Load(object sender, EventArgs e)
        {
            try
            {
                List<Modelos.Sucursales> sucursales = new List<Modelos.Sucursales>();
                sucursales.Add(new Modelos.Sucursales { idSucursal = -1, nombre = "TODAS LAS SUCURSALES" });
                sucursales.AddRange(this._catalogosNegocio.getSucursales("A"));

                // llenar combo de sucursales
                this.cmbSucursal.DisplayMember = "nombre";
                this.cmbSucursal.ValueMember = "idSucursal";
                this.cmbSucursal.DataSource = sucursales;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos por Fechas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbSucursal.SelectedIndex == -1)
                    throw new Exception("Seleccione una sucursal");

                if (string.IsNullOrEmpty(this.dtpFechaInicio.Text))
                    throw new Exception("Defina una fecha de inicio");

                if (string.IsNullOrEmpty(this.dtpFechaFin.Text))
                    throw new Exception("Defina una fecha final");

                string fechaIni = this.dtpFechaInicio.Value.ToString("yyyy-MM-dd");
                string fechaFin = this.dtpFechaFin.Value.AddHours(24).ToString("yyyy-MM-dd");
                
                int idSuc = this.cmbSucursal.SelectedIndex == -1 ? -1 : (int)this.cmbSucursal.SelectedValue;

                this._resultado = this._activosNegocio.getActivosFechas(fechaIni, fechaFin, idSuc, "A");

                if (this._resultado.Count == 0)
                {
                    this.gcActivos.DataSource = null;
                    this._resultado = new List<Modelos.Activos>();

                    throw new Exception("Sin resultados");
                }

                this.gcActivos.DataSource = this._resultado;
                this.gridView2.BestFitColumns();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos por Fechas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._resultado.Count == 0)
                    throw new Exception("Realice una consulta");

                this.gridView2.BestFitColumns();
                this.gcActivos.ShowPrintPreview();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos por Fechas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
