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
    public partial class frmModifActivo : Form
    {
        ICatalogosNegocio _catalogosNegocio;
        IActivosNegocio _activosNegocio;


        private Modelos.Tipos _tipos;
        private int? _idActivo = null;

        public frmModifActivo()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this._catalogosNegocio = new CatalogosNegocio();
            this._activosNegocio = new ActivosNegocio();
        }

        private void frmModifActivo_Load(object sender, EventArgs e)
        {
            this.lbCveActivo.Text = string.Empty;
            this.lbNumetiqueta.Text = string.Empty;
            this.tbUsuario.Text = string.Empty;
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
            this.tbDescripcion.ReadOnly = false;
        }

        private void btnBusqAct_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscActivos form = new frmBuscActivos();

                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.inicializaValores();

                    // trae permisos de tipos
                    this._tipos = this._catalogosNegocio.getTipo(form._idTipo);

                    // muestra los datos del activo
                    Modelos.ActivosDesc activo = form._activoSelecc;

                    string[] array = activo.descripcion.Split('&');

                    this.tbNombre.Text = activo.nombreCorto;
                    this.tbTipo.Text = activo.tipo;
                    this.tbSucursal.Text = activo.sucursal;
                    this.tbArea.Text = activo.area;
                    this.tbMarca.Text = array[0];
                    this.tbModelo.Text = array[1];
                    this.tbNumSerie.Text = array[2];
                    this.tbColor.Text = array[3];
                    this.tbDescripcion.Text = array[4];
                    this.tbUsuario.Text = activo.usuario;

                    this.lbNumetiqueta.Text = activo.numEtiqueta;
                    this.lbCveActivo.Text = activo.claveActivo;

                    this._idActivo = activo.idActivo;

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
                        this.tbDescripcion.ReadOnly = true;
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

                // validaciones segun el tipo
                bool resultado = validaciones();

                if (!resultado)
                    throw new Exception("Campos incompletos.\nPor favor verifique.");

                string nombre = this.tbNombre.Text;

                string descripcion =
                    this.tbMarca.Text + "&" +
                    this.tbModelo.Text + "&" +
                    this.tbNumSerie.Text + "&" +
                    this.tbColor.Text + "&" +
                    this.tbDescripcion.Text;

                bool res = this._activosNegocio.modifActivo(this._idActivo, nombre, descripcion);

                if (res) MessageBox.Show("Datos modificados correctamente", "Activos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
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

            return result;
        }
    }
}
