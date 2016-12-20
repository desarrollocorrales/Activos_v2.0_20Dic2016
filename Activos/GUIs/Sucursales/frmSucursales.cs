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
    public partial class frmSucursales : Form
    {
        ICatalogosNegocio _catalogosNegocio;

        public frmSucursales()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this._catalogosNegocio = new CatalogosNegocio();
        }

        private void frmSucursales_Load(object sender, EventArgs e)
        {
            try
            {
                // llena el catalogo de responsables (usuarios) disponibles
                this.cmbResponsable.DataSource = this._catalogosNegocio.getResponsables();
                this.cmbResponsable.DisplayMember = "nombre";
                this.cmbResponsable.ValueMember = "idUsuario";

                // llena el grid con las sucursales disponibles
                this.gcSucursales.DataSource = this._catalogosNegocio.getSucursales();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
