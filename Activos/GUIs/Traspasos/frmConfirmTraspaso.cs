using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;

namespace Activos.GUIs.Traspasos
{
    public partial class frmConfirmTraspaso : Form
    {
        private Modelos.Activos _activoSel;
        public Modelos.Activos _activoModif;
        private string _usuario;

        ICatalogosNegocio _catalogosNegocio;

        public frmConfirmTraspaso()
        {
            InitializeComponent();
        }

        public frmConfirmTraspaso(Modelos.Activos activoSel, string usuario)
        {
            InitializeComponent();

            this._activoSel = activoSel;
            this._usuario = usuario;

            this._catalogosNegocio = new CatalogosNegocio();
        }

        private void frmConfirmTraspaso_Load(object sender, EventArgs e)
        {
            try
            {
                // acomoda check
                this.cbArea.Location = new Point(this.gbArea.Location.X + 13, this.gbArea.Location.Y - 1);

                // llenar combo de sucursales
                this.cmbSucursal.DisplayMember = "nombre";
                this.cmbSucursal.ValueMember = "idSucursal";
                this.cmbSucursal.DataSource = this._catalogosNegocio.getSucursales("A");
                this.cmbSucursal.SelectedIndex = -1;

                this.tbNombre.Text = this._activoSel.nombreCorto;
                this.tbTipo.Text = this._activoSel.tipo;
                this.tbArea.Text = this._activoSel.area;
                this.lbNumetiqueta.Text = this._activoSel.numEtiqueta;
                this.lbCveActivo.Text = this._activoSel.claveActivo;

                string descripcion = this._activoSel.descripcion.Replace("---", "&");
                string[] array = descripcion.Split('&');

                this.tbMarca.Text = array[0];
                this.tbModelo.Text = array[1];
                this.tbNumSerie.Text = array[2];
                this.tbColor.Text = array[3];
                this.tbFactura.Text = array[4];
                this.tbCosto.Text = array[5];
                this.tbDescripcion.Text = array[6];

                this.tbUsuario.Text = _usuario;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Confirmar Traspaso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                this._activoModif = new Modelos.Activos();

                this._activoModif.accion = this._activoSel.accion;
                this._activoModif.area = this._activoSel.area;
                this._activoModif.claveActivo = this._activoSel.claveActivo;
                this._activoModif.costo = this._activoSel.costo;
                this._activoModif.descripcion = this._activoSel.descripcion;
                this._activoModif.fechaAlta = this._activoSel.fechaAlta;
                this._activoModif.fechaModificacion = this._activoSel.fechaModificacion;
                this._activoModif.idActivo = this._activoSel.idActivo;
                this._activoModif.idArea = this._activoSel.idArea;
                this._activoModif.idTipo = this._activoSel.idTipo;
                this._activoModif.idUsuarioAlta = this._activoSel.idUsuarioAlta;
                this._activoModif.idUsuarioModifica = this._activoSel.idUsuarioModifica;
                this._activoModif.nombreCorto = this._activoSel.nombreCorto;
                this._activoModif.numEtiqueta = this._activoSel.numEtiqueta;
                this._activoModif.seleccionado = this._activoSel.seleccionado;
                this._activoModif.status = this._activoSel.status;
                this._activoModif.tipo = this._activoSel.tipo;

                if (this.cbArea.Checked)
                {
                    // validaciones
                    if (this.cmbArea.SelectedIndex == -1)
                        throw new Exception("Seleccione un área");

                    this._activoModif.area = ((Modelos.Areas)this.cmbArea.SelectedItem).nombre;
                    this._activoModif.idArea = (int)this.cmbArea.SelectedValue;
                }

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Confirmar Traspaso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void cmbSucursal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                this.cargaAreas((int)this.cmbSucursal.SelectedValue);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Confirmar Traspaso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void cargaAreas(int idSucursal)
        {
            // llenar combo de Tipos
            this.cmbArea.DataSource = this._catalogosNegocio.getAreas(idSucursal);
            this.cmbArea.DisplayMember = "nombre";
            this.cmbArea.ValueMember = "idArea";
        }

        private void cbArea_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbArea.Checked)
                this.gbArea.Enabled = true;
            else
                this.gbArea.Enabled = false;
        }
    }
}
