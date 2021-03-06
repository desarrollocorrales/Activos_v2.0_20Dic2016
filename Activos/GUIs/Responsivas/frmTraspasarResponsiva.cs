﻿using System;
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
        private List<Modelos.Activos> _activosTraspaso = new List<Modelos.Activos>();
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
            this._activosTraspaso = new List<Modelos.Activos>();
        }

        private void btnBuscaResponsiva_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscarResponsiva form = new frmBuscarResponsiva("B");

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

        List<Modelos.Responsivas> _responsivas;

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

                    bool traspaso = this._activos.Where(w => w.status.Equals("REPARACION")).Count() == 0;

                    if(!traspaso)
                        throw new Exception(
                        "No se permite traspasar la responsiva ya que cuenta con activos en REPARACION\n" +
                        "Reingrese el (los) activo (s) para poder traspasarla");

                    bool resultado = this._responsivasNegocio.
                        traspasoResponsiva(this._idResponsiva, this._idPersonaAnt, this._idPersonaNueva, this._activos, motivo);

                    if (resultado)
                    {
                        // agrega a la lista los activos que han sido traspasado
                        this._activosTraspaso.AddRange(this._activos);

                        MessageBox.Show("Responsiva traspasada correctamente", "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        string activos = string.Join(",", this._activos.Select(s => s.idActivo).ToList());

                        // bitacora
                        this._catalogosNegocio.generaBitacora(
                            "Todos los activos de la responsiva " + this._idResponsiva + " se traspasaron a la persona: " + this._idPersonaNueva
                            + " como una nueva responsiva con los activos: " + activos
                            + " por el motivo '" + motivo + "'", "RESPONSIVAS");
                        
                        // busca si la persona tiene mas responsivas
                        this._responsivas = this._responsivasNegocio.getRespPersonas(this._idPersonaAnt);

                        if (this._responsivas.Count > 0)
                        {
                            dialogResult = MessageBox.Show(
                                    "¿Desea Traspasar otra responsiva de '" + this.tbResponsable.Text + "' a '" + this.tbResponsableT.Text + "'?\n",
                                    "Responsivas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (dialogResult == DialogResult.Yes)
                            {
                                // abrir otro formulario
                                frmSeleccionarRespon form = new frmSeleccionarRespon(this._responsivas, true);

                                var res = form.ShowDialog();

                                if (res == System.Windows.Forms.DialogResult.OK)
                                {
                                    // carga los activos y datos del responsable
                                    this.gcActivos.DataSource = form._activos;
                                    this.tbResponsable.Text = form._responsiva.responsable;
                                    this.tbSucursal.Text = form._responsiva.sucursal;
                                    this.tbPuesto.Text = form._responsiva.puesto;


                                    this.tbFolio.Text = Convert.ToString(form._responsiva.idResponsiva);

                                    this._idResponsiva = form._responsiva.idResponsiva;
                                    this._activos = form._activos;
                                    this._idPersonaAnt = form._responsiva.idPersona;


                                    this.btnCambiaResp.Location = new Point(519, 49);
                                    this.btnCambiaResp.Visible = true;
                                    this.btnBuscaResponsiva.Visible = false;
                                    this.btnCancelar.Visible = true;
                                }
                                else
                                {
                                    
                                    // MANDAR REPORTE
                                    this._imprimeReporte();

                                    this.reinicia();
                                }
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                // MANDAR REPORTE
                                this._imprimeReporte();

                                this.reinicia();
                            };
                        }
                        else
                        {
                            // MANDAR REPORTE
                            this._imprimeReporte();

                            this.reinicia();
                        }
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

        public void _imprimeReporte()
        {

            // abrir formulario
            frmReporteTraspasos form = new frmReporteTraspasos();

            form._empresa = Modelos.Login.empresa;
            form._logo = this._responsivasNegocio.obtieneLogo("reportes");
            form._activos = this._activosTraspaso;
            form._detalle = this.tbMotivo.Text;
            form._personaAnterior = this.tbResponsable.Text;
            form._personaNueva = this.tbResponsableT.Text;
            form._fecha = this._catalogosNegocio.getFechaServidor();

            form.ShowDialog();

            string idActivos = string.Join(",", this._activosTraspaso.Select(s => s.idActivo).ToList());

            // bitacora
            this._catalogosNegocio.generaBitacora(
                "Se genero la vista previa del informe de Traspaso, ACTIVOS: " + idActivos, "RESPONSIVAS");

        }

        public void reinicia()
        {
            this.gcActivos.DataSource = null;

            this.tbMotivo.Text = string.Empty;
            this.tbPuesto.Text = string.Empty;
            this.tbResponsable.Text = string.Empty;
            this.tbSucursal.Text = string.Empty;

            this.tbPuestoT.Text = string.Empty;
            this.tbResponsableT.Text = string.Empty;
            this.tbSucursalT.Text = string.Empty;

            this.tbFolio.Text = string.Empty;

            this._idResponsiva = null;
            this._idPersonaAnt = null;
            this._idPersonaNueva = null;

            this.btnCambiaResp.Visible = false;
            this.btnBuscaResponsiva.Visible = true;
            this.btnCancelar.Visible = false;

            this._responsivas = null;
            this._activosTraspaso = new List<Modelos.Activos>();
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

        private void btnCambiaResp_Click(object sender, EventArgs e)
        {
            // abrir otro formulario
            frmSeleccionarRespon form = new frmSeleccionarRespon(this._responsivas, false);

            var res = form.ShowDialog();

            if (res == System.Windows.Forms.DialogResult.OK)
            {
                // carga los activos y datos del responsable
                this.gcActivos.DataSource = form._activos;
                this.tbResponsable.Text = form._responsiva.responsable;
                this.tbSucursal.Text = form._responsiva.sucursal;
                this.tbPuesto.Text = form._responsiva.puesto;


                this.tbFolio.Text = Convert.ToString(form._responsiva.idResponsiva);

                this._idResponsiva = form._responsiva.idResponsiva;
                this._activos = form._activos;
                this._idPersonaAnt = form._responsiva.idPersona;


                this.btnCambiaResp.Location = new Point(519, 49);
                this.btnCambiaResp.Visible = true;
                this.btnBuscaResponsiva.Visible = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                var respuesta = MessageBox.Show("¿Desea cancelar la operacion?", "Responsivas", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (respuesta == System.Windows.Forms.DialogResult.Yes)
                {
                    // MANDAR REPORTE
                    this._imprimeReporte();
                    this.reinicia();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
