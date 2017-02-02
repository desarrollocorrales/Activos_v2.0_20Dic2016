using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;

namespace Activos.GUIs.AltaActivos
{
    public partial class frmAltaActivo : Form
    {
        ICatalogosNegocio _catalogosNegocio;
        IActivosNegocio _activosNegocio;

        private Modelos.Tipos _tipos;

        // CAMBIAR CUANDO SE DEFINA EL LOGIN
        private int _idUsuario = 1;

        public frmAltaActivo(int idUsuario)
        {
            InitializeComponent();

            this._catalogosNegocio = new CatalogosNegocio();
            this._activosNegocio = new ActivosNegocio();

            this._idUsuario = idUsuario;

        }

        private void frmAltaActivo_Load(object sender, EventArgs e)
        {
            try
            {
                // llenar combo de Tipos
                this.cmbTipo.DataSource = this._catalogosNegocio.getTipos("A");
                this.cmbTipo.DisplayMember = "nombre";
                this.cmbTipo.ValueMember = "idTipo";
                this.cmbTipo.SelectedIndex = -1;


                // llenar combo de sucursales
                this.cmbSucursal.DisplayMember = "nombre";
                this.cmbSucursal.ValueMember = "idSucursal";
                this.cmbSucursal.DataSource = this._catalogosNegocio.getSucursales("A");
                this.cmbSucursal.SelectedIndex = -1;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmbSucursal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                this.cargaAreas((int)this.cmbSucursal.SelectedValue);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        private void cmbTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                this._tipos = this._catalogosNegocio.getTipo((int)this.cmbTipo.SelectedValue);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones combos
                if (this.cmbTipo.SelectedIndex == -1)
                    throw new Exception("Seleccione un tipo");

                if (this.cmbArea.SelectedIndex == -1)
                    throw new Exception("Seleccione un área");

                // valida nombre
                if (string.IsNullOrEmpty(this.tbNombre.Text))
                    throw new Exception("Llene el campo nombre");

                // validaciones segun el tipo
                bool resultado = validaciones();

                if (!resultado)
                    throw new Exception("Campos incompletos.\nPor favor verifique.");
                
                // guardar informacion
                string nombre = this.tbNombre.Text;
                
                int idTipo = (int)this.cmbTipo.SelectedValue;
                
                string descripcion =
                    this.tbMarca.Text + "&" +
                    this.tbModelo.Text + "&" +
                    this.tbNumSerie.Text + "&" +
                    this.tbColor.Text + "&" +
                    this.tbCosto.Text + "&" +
                    this.tbFactura.Text + "&" +
                    this.tbDescripcion.Text;

                string fecIng = this.dtpFecha.Value.ToString("yyyy-MM-dd");

                int idArea = (int)this.cmbArea.SelectedValue;

                bool result = this._activosNegocio.guardaActivo(nombre, descripcion, idArea, idTipo, this._idUsuario, fecIng);

                if (result)
                {
                    MessageBox.Show("Activo guardado correctamente", "Activos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.tbMarca.Text = string.Empty;
                    this.tbModelo.Text = string.Empty;
                    this.tbNumSerie.Text = string.Empty;
                    this.tbColor.Text = string.Empty;
                    this.tbDescripcion.Text = string.Empty;

                    this.tbCosto.Text = string.Empty;
                    this.tbFactura.Text = string.Empty;

                    this.cmbArea.DataSource = null;
                    this.cmbSucursal.SelectedIndex = -1;
                    this.cmbTipo.SelectedIndex = -1;

                    this.tbNombre.Text = string.Empty;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // true  : todo bien
        // false : algun prblema con las validaciones
        private bool validaciones()
        {
            bool result = true;

            // colorea todo de negro
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(Label))
                    c.ForeColor = System.Drawing.Color.Black;
            }

            // reestablece los nombres
            this.lMarca.Text = "Marca";
            this.lModelo.Text = "Modelo";
            this.lNumSerie.Text = "Núm. de Serie";
            this.lColor.Text = "Color";
            this.lbCosto.Text = "Costo";
            this.lbFactura.Text = "Factura";

            // MARCA
            if (this._tipos.marca.Equals("SI") && string.IsNullOrEmpty(this.tbMarca.Text))
            {
                this.lMarca.Text = "Marca*";
                this.lMarca.ForeColor = System.Drawing.Color.Red;
                result = false;
            }

            // MODELO
            if (this._tipos.modelo.Equals("SI") && string.IsNullOrEmpty(this.tbModelo.Text))
            {
                this.lModelo.Text = "Modelo*";
                this.lModelo.ForeColor = System.Drawing.Color.Red;
                result = false;
            }

            // NUM DE SERIE
            if (this._tipos.serie.Equals("SI") && string.IsNullOrEmpty(this.tbNumSerie.Text))
            {
                this.lNumSerie.Text = "Núm. de Serie*";
                this.lNumSerie.ForeColor = System.Drawing.Color.Red;
                result = false;
            }

            // COLOR
            if (this._tipos.color.Equals("SI") && string.IsNullOrEmpty(this.tbColor.Text))
            {
                this.lColor.Text = "Color*";
                this.lColor.ForeColor = System.Drawing.Color.Red;
                result = false;
            }

            // COSTO
            if (this._tipos.costo.Equals("SI") && string.IsNullOrEmpty(this.tbCosto.Text))
            {
                this.lbCosto.Text = "Costo*";
                this.lbCosto.ForeColor = System.Drawing.Color.Red;
                result = false;
            }

            // FACTURA
            if (this._tipos.factura.Equals("SI") && string.IsNullOrEmpty(this.tbFactura.Text))
            {
                this.lbFactura.Text = "Factura*";
                this.lbFactura.ForeColor = System.Drawing.Color.Red;
                result = false;
            }

            return result;
        }

        public void cargaAreas(int idSucursal)
        {
            // llenar combo de Tipos
            this.cmbArea.DataSource = this._catalogosNegocio.getAreas(idSucursal);
            this.cmbArea.DisplayMember = "nombre";
            this.cmbArea.ValueMember = "idArea";
        }

    }
}
