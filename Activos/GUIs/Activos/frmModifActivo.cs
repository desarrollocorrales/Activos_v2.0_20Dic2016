﻿using System;
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
    public partial class frmModifActivo : Form
    {
        ICatalogosNegocio _catalogosNegocio;
        IActivosNegocio _activosNegocio;

        private Modelos.ActivosDesc _activoAntes;

        private Modelos.Tipos _tipos;
        private int? _idActivo = null;

        private int _idAreaAnt;
        private int _idTipoAnt;

        public frmModifActivo()
        {
            InitializeComponent();

            this._catalogosNegocio = new CatalogosNegocio();
            this._activosNegocio = new ActivosNegocio();
        }

        private void frmModifActivo_Load(object sender, EventArgs e)
        {
            this.lbCveActivo.Text = string.Empty;
            this.lbNumetiqueta.Text = string.Empty;
            this.tbUsuario.Text = string.Empty;

            // carga combos
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

        private void inicializaValores()
        {
            this.lbCveActivo.Text = string.Empty;
            this.lbNumetiqueta.Text = string.Empty;
            this.tbUsuario.Text = string.Empty;

            // limpia textbox
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                }
            }

            this.tbNombre.ReadOnly = false;
            this.tbMarca.ReadOnly = false;
            this.tbModelo.ReadOnly = false;
            this.tbNumSerie.ReadOnly = false;
            this.tbColor.ReadOnly = false;
            this.tbCosto.ReadOnly = false;
            this.tbFactura.ReadOnly = false;
            this.tbDescripcion.ReadOnly = false;
            this.dtpFecha.Enabled = true;

            this.cmbArea.Enabled = true;
            this.cmbSucursal.Enabled = true;
            this.cmbTipo.Enabled = true;
        }

        private void btnBusqAct_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscActivos form = new frmBuscActivos("MODIFICACION");

                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.inicializaValores();

                    // trae permisos de tipos
                    this._tipos = this._catalogosNegocio.getTipo(form._idTipo);

                    // muestra los datos del activo
                    this._activoAntes = form._activoSelecc;

                    string[] array = this._activoAntes.descripcion.Split('&');

                    this.tbNombre.Text = this._activoAntes.nombreCorto;

                    this.tbMarca.Text = array[0];
                    this.tbModelo.Text = array[1];
                    this.tbNumSerie.Text = array[2];
                    this.tbColor.Text = array[3];
                    this.tbCosto.Text = array[4];
                    this.tbFactura.Text = array[5];
                    this.dtpFecha.Text = array[6];
                    this.tbDescripcion.Text = array[7];
                    this.tbUsuario.Text = this._activoAntes.usuario;

                    this.lbNumetiqueta.Text = this._activoAntes.numEtiqueta;
                    this.lbCveActivo.Text = this._activoAntes.claveActivo;

                    this._idActivo = this._activoAntes.idActivo;

                    this.cmbTipo.SelectedValue = this._activoAntes.idTipo;
                    this.cmbSucursal.SelectedValue = this._activoAntes.idSucursal;
                    this.cargaAreas(this._activoAntes.idSucursal);
                    this.cmbArea.SelectedValue = this._activoAntes.idArea;

                    this._idTipoAnt = this._activoAntes.idTipo;
                    this._idAreaAnt = this._activoAntes.idArea;

                    if (!string.IsNullOrEmpty(this._activoAntes.usuario))
                    {
                        MessageBox.Show(
                            "No es permitido cambiar la Sucursal\n" + 
                            "El Activo pertenece a una responsiva\n" +
                            "Para realizar el cambio debe ser por medio de un traspaso", "Activos",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // this.cmbArea.Enabled = false;
                        this.cmbSucursal.Enabled = false;
                    }
                }

                if (result == DialogResult.Cancel)
                {
                    if (string.IsNullOrEmpty(this.tbNombre.Text))
                    {
                        this.tbNombre.ReadOnly = true;
                        this.tbMarca.ReadOnly = true;
                        this.tbModelo.ReadOnly = true;
                        this.tbNumSerie.ReadOnly = true;
                        this.tbColor.ReadOnly = true;
                        this.tbCosto.ReadOnly = true;
                        this.tbFactura.ReadOnly = true;
                        this.tbDescripcion.ReadOnly = true;
                        this.dtpFecha.Enabled = false;
                    }

                    MessageBox.Show("Operación Cancelada", "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (string.IsNullOrEmpty(this.tbNombre.Text))
                    throw new Exception("Llene el campo nombre");

                // validaciones combos
                if (this.cmbTipo.SelectedIndex == -1)
                    throw new Exception("Seleccione un tipo");

                if (this.cmbArea.SelectedIndex == -1)
                    throw new Exception("Seleccione un área");

                // validaciones segun el tipo
                bool resultado = validaciones();

                if (!resultado)
                    throw new Exception("Campos incompletos o valores inválidos.\nPor favor verifique.");

                string nombre = this.tbNombre.Text;

                string fechaCompra = this.dtpFecha.Value.ToString("yyyy-MM-dd");

                string descripcion =
                    this.tbMarca.Text + "&" +
                    this.tbModelo.Text + "&" +
                    this.tbNumSerie.Text + "&" +
                    this.tbColor.Text + "&" +
                    this.tbCosto.Text + "&" +
                    this.tbFactura.Text + "&" +
                    fechaCompra + "&" +
                    this.tbDescripcion.Text;

                int idTipo = (int)this.cmbTipo.SelectedValue;
                int idArea = (int)this.cmbArea.SelectedValue;

                string tipo = ((Modelos.Tipos)this.cmbTipo.SelectedItem).nombre;
                string areas = ((Modelos.Areas)this.cmbArea.SelectedItem).nombre;

                bool res = this._activosNegocio.modifActivo(this._idActivo, nombre, descripcion, string.Empty, idTipo, idArea);

                if (res) MessageBox.Show("Datos modificados correctamente", "Activos", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // bitacora
                /*
                this._catalogosNegocio.generaBitacora(
                    "Activo Modificado: " + this._idActivo + " nuevos datos: " + nombre + "/" + descripcion +
                    "/ tipo: " + tipo + "/ area: " + areas, "ACTIVOS");
                */

                this._catalogosNegocio.generaBitacora(
                "Activo Modificado: " + this._idActivo + " datos anteriores: " + this._activoAntes.nombreCorto + "/" + this._activoAntes.descripcion +
                "/ tipo: " + this._activoAntes.tipo + "/ area: " + this._activoAntes.area, "ACTIVOS");
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

            // COSTO valor numerico
            decimal costo = 0;
            if (!decimal.TryParse(this.tbCosto.Text, out costo))
            {
                this.lbCosto.Text = "Costo*";
                this.lbCosto.ForeColor = System.Drawing.Color.Red;
                result = false;
            }

            // COSTO varios puntos
            int count = this.tbCosto.Text.Count(c => c == '.');
            if (count > 1)
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

        private void tbCosto_Leave(object sender, EventArgs e)
        {
            this.tbCosto.Text = this.tbCosto.Text.Replace(",", "");
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

        public void cargaAreas(int idSucursal)
        {
            // llenar combo de Tipos
            this.cmbArea.DataSource = this._catalogosNegocio.getAreas(idSucursal);
            this.cmbArea.DisplayMember = "nombre";
            this.cmbArea.ValueMember = "idArea";
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
    }
}
