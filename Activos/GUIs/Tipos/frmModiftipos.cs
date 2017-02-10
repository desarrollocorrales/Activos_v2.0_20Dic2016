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
    public partial class frmModiftipos : Form
    {
        private ICatalogosNegocio _catalogosNegocio;

        private int _idTipo;
        private string _nombre;
        private bool _marca;
        private bool _modelo;
        private bool _serie;
        private bool _color;
        private bool _costo;
        private bool _factura;

        public frmModiftipos(int idTipo, string nombre, bool marca, bool modelo, bool serie, bool color, bool costo, bool factura)
        {
            InitializeComponent();

            this._catalogosNegocio = new CatalogosNegocio();

            this._idTipo = idTipo;
            this._nombre = nombre;
            this._marca = marca;
            this._modelo = modelo;
            this._serie = serie;
            this._color = color;
            this._costo = costo;
            this._factura = factura;
        }

        private void frmModiftipos_Load(object sender, EventArgs e)
        {
            // imprime nombre
            this.tbNombre.Text = this._nombre;

            // imprime valores de checkbox
            this.cbMarca.Checked = this._marca;
            this.cbModelo.Checked = this._modelo;
            this.cbSerie.Checked = this._serie;
            this.cbColor.Checked = this._color;
            this.cbCosto.Checked = this._costo;
            this.cbFactura.Checked = this._factura;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                // validaciones
                if (string.IsNullOrEmpty(this.tbNombre.Text))
                    throw new Exception("Defina un nombre para el tipo");

                int marca = this.cbMarca.Checked ? 1 : 0;
                int modelo = this.cbModelo.Checked ? 1 : 0;
                int serie = this.cbSerie.Checked ? 1 : 0;
                int color = this.cbColor.Checked ? 1 : 0;
                int costo = this.cbCosto.Checked ? 1 : 0;
                int factura = this.cbFactura.Checked ? 1 : 0;

                // guardado de informacion
                bool resultado =
                    this._catalogosNegocio.modificaTipo(
                        this._idTipo,
                        this.tbNombre.Text,
                        marca, modelo, serie, color, costo, factura);


                if (resultado)
                {
                    MessageBox.Show("Tipo modificado correctamente", "Modificar Tipos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // cerrar formularios
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Modificar Tipos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
