using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;

namespace Activos.GUIs.Responsivas
{
    public partial class frmTraspasarResponsiva : Form
    {
        IResponsivasNegocio _responsivasNegocio;
        ICatalogosNegocio _catalogosNegocio;

        private int? _idResponsiva = null;
        private int? _idPersonaAnt = null;

        private int? _idPersonaNueva = null;

        private List<Modelos.Activos> _activos = new List<Modelos.Activos>();

        public frmTraspasarResponsiva()
        {
            InitializeComponent();
            this._catalogosNegocio = new CatalogosNegocio();
            this._responsivasNegocio = new ResponsivasNegocio();
        }

        private void btnBuscaResponsiva_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscarResponsiva form = new frmBuscarResponsiva(string.Empty);

                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.tbResponsable.Text = form._responsiva.responsable;
                    this.tbPuesto.Text = form._responsiva.puesto;
                    this.tbSucursal.Text = form._responsiva.sucursal;

                    this.tbFolio.Text = Convert.ToString(form._responsiva.idResponsiva);

                    this._idResponsiva = form._responsiva.idResponsiva;
                    this._activos = form._activos;
                    this._idPersonaAnt = form._responsiva.idPersona;

                    // llena el grid con los puestos disponibles
                    this.gcActivos.DataSource = form._activos;
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones 
                if (this._idResponsiva == null)
                    throw new Exception("Seleccione una responsiva");

                if (this._idPersonaNueva == null)
                    throw new Exception("Seleccione un persona");

                // la misma persona
                if(this._idPersonaAnt == this._idPersonaNueva)
                    throw new Exception ("Es la misma persona.\nVerifique");

                if (this.tbMotivo.Text.Trim().Length < 10)
                {
                    this.label4.ForeColor = System.Drawing.Color.Red;
                    this.label4.Text = "Motivo*";
                    throw new Exception("La longitud miníma permitida para el motivo es de 10 carácteres");
                }
                else
                {
                    this.label4.ForeColor = System.Drawing.Color.Black;
                    this.label4.Text = "Motivo";
                }

                DialogResult dialogResult = MessageBox.Show(
                    "¿Desea realizar el traspaso de la responsiva?" + 
                    (this.gridView1.DataRowCount > 0 ? "\nLos activos pertenecerán a la persona seleccionada" : string.Empty),
                                "Responsivas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    // validaciones 
                    if(string.IsNullOrEmpty(this.tbMotivo.Text))
                        throw new Exception("Defina un motivo del traspaso");

                    string motivo = this.tbMotivo.Text;

                    bool resultado = this._responsivasNegocio.
                        traspasoResponsiva(this._idResponsiva, this._idPersonaAnt, this._idPersonaNueva, this._activos, motivo);

                    if (resultado)
                    {
                        MessageBox.Show("Responsiva traspasada correctamente", "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        string activos = string.Join(",", this._activos.Select(s=>s.idActivo).ToList());

                        // bitacora
                        this._catalogosNegocio.generaBitacora(
                            "Todos los activos de la responsiva se traspasaron a: " + this._idPersonaNueva
                            + " como una nueva responsiva con los activos: " + activos
                            + " por el motivo '" + motivo + "'", "RESPONSIVAS");



                        this.gcActivos.DataSource = null;

                        this.tbMotivo.Text = string.Empty;
                        this.tbPuesto.Text = string.Empty;
                        this.tbResponsable.Text = string.Empty;
                        this.tbSucursal.Text = string.Empty;

                        this.tbPuestoT.Text = string.Empty;
                        this.tbResponsableT.Text = string.Empty;
                        this.tbSucursalT.Text = string.Empty;

                        this._idResponsiva = null;
                        this._idPersonaAnt = null;
                        this._idPersonaNueva = null;
                    }
                    else throw new Exception("Problemas durante el traspaso de la responsiva");
                }
                else if (dialogResult == DialogResult.No) return;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscaUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscaPersona form = new frmBuscaPersona();

                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {

                    this.tbResponsableT.Text = form._usuario.nombre;
                    this.tbPuestoT.Text = form._usuario.puesto;
                    this.tbSucursalT.Text = form._usuario.sucursal;

                    this._idPersonaNueva = form._usuario.idPersona;
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBusFolio_Click(object sender, EventArgs e)
        {
            try
            {
                // validacion
                if (string.IsNullOrEmpty(this.tbFolio.Text))
                    throw new Exception("Defina un folio");

                int folio = Convert.ToInt16(this.tbFolio.Text);

                // obtiene responsables
                Modelos.RespPorFolio respFolio = this._responsivasNegocio.obtieneRespXFolio(folio);

                if (respFolio == null)
                {
                    this.gcActivos.DataSource = null;
                    this.ActiveControl = this.tbFolio;
                    this.tbFolio.SelectAll();

                    this.tbResponsable.Text = string.Empty;
                    this.tbPuesto.Text = string.Empty;
                    this.tbSucursal.Text = string.Empty;

                    throw new Exception("Sin resultados");
                }

                this.gcActivos.DataSource = null;
                this.ActiveControl = this.tbFolio;
                this.tbFolio.SelectAll();

                this.tbResponsable.Text = respFolio.responsiva.responsable;
                this.tbPuesto.Text = respFolio.responsiva.puesto;
                this.tbSucursal.Text = respFolio.responsiva.sucursal;

                this._idResponsiva = respFolio.responsiva.idResponsiva;
                this._activos = respFolio.activos;
                this._idPersonaAnt = respFolio.responsiva.idPersona;

                this.gcActivos.DataSource = respFolio.activos;
                this._activos = respFolio.activos;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnBusFolio_Click(null, null);
            }
        }
    }
}
