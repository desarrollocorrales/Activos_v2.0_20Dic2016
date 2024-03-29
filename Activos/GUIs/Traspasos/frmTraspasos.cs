﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.GUIs.Responsivas;
using Activos.Negocio;

namespace Activos.GUIs.Traspasos
{
    public partial class frmTraspasos : Form
    {
        IResponsivasNegocio _responsivasNegocio;
        ICatalogosNegocio _catalogosNegocio;

        // almacena ids de la primer seleccion
        private int? _idResponsiva = null;
        private int? _idUsuario = null;
        private List<Modelos.Activos> _activos = new List<Modelos.Activos>();

        // almacena ids del traspaso
        private int? _idResponsivaT = null;
        private int? _idUsuarioT = null;
        private List<Modelos.Activos> _activosT = new List<Modelos.Activos>();

        // definen cual accion tomar
        // nueva responsiva o agregar activos a una ya existente
        private bool _nuevaResp = false;
        private bool _respSelec = false;

        // valida movimientos
        private bool _movimiento = false;

        // contador de la lista original de traspasos
        private int _countListTraspaso = 0;

        public frmTraspasos()
        {
            InitializeComponent();

            this._catalogosNegocio = new CatalogosNegocio();
            this._responsivasNegocio = new ResponsivasNegocio();
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

                    this.tbFolio.Text = Convert.ToString( form._responsiva.idResponsiva);

                    this._idResponsiva = form._responsiva.idResponsiva;
                    this._idUsuario = form._responsiva.idPersona;

                    // llena el grid con los puestos disponibles
                    this.gcActivos.DataSource = form._activos;
                    this._activos = form._activos;

                    if (this.gridView1.RowCount != 0)
                        this.gridView1.UnselectRow(0);
                }

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
                frmBuscaUsuarioResp form = new frmBuscaUsuarioResp();

                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    
                    this.tbResponsableT.Text = form._usuario.nombre;
                    this.tbPuestoT.Text = form._usuario.puesto;
                    this.tbSucursalT.Text = form._usuario.sucursal;

                    this._nuevaResp = form._nuevaResp;
                    this._respSelec = form._respSelec;
                    this._idUsuarioT = form._usuario.idPersona;

                    this.gcActivosT.DataSource = null;
                    this._activosT = new List<Modelos.Activos>();

                    if (this._respSelec)
                    {
                        this._idResponsivaT = form._responsiva.idResponsiva;

                        // llena el grid con los puestos disponibles
                        this.gcActivosT.DataSource = form._activos;

                        if (this.gridView2.RowCount != 0)
                            this.gridView2.UnselectRow(0);

                        this._activosT = form._activos;

                        this._countListTraspaso = this._activosT.Count;
                    }
                    else
                    {
                        this._idResponsivaT = null;
                        this._activosT = new List<Modelos.Activos>();
                    }
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAgrega_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                // si ya se selecciono una responsiva
                if (this._idResponsiva == null)
                    throw new Exception("Seleccione una responsiva");

                // si ya se selecciono un usuario para traspaso
                if (this._idUsuarioT == null)
                    throw new Exception("Seleccione una persona para traspaso");

                // que no sean el mismo usuario ni la misma responsiva
                if (this._idResponsiva == this._idResponsivaT && this._idUsuario == this._idUsuarioT)
                    throw new Exception("No se permite el movimiento ya que es la misma persona y la misma responsiva");

                if (this.gridView1.GetSelectedRows().Count() == 0)
                    throw new Exception("Seleccione un activo a traspasar");

                // obtener el activo seleccionado
                Modelos.Activos activoSel = new Modelos.Activos();

                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    var dr1 = this.gridView1.GetRow(i);

                    activoSel = (Modelos.Activos)dr1;
                }

                if (activoSel.status.Equals("REPARACION"))
                    throw new Exception(
                        "No se permite traspasar un activo que se encuentra en REPARACION\n" +
                        "Reingrese el activo para poder traspasarlo");

                // se bloque la seleccion de responsivas y usuario 
                if (!this._movimiento)
                {
                    DialogResult dialogResult = MessageBox.Show(
                                "Una vez que comience a realizar movimientos de traspasos no podrá seleccionar otra responsiva u otra persona\n" +
                                "¿Desea continuar con el movimiento?",
                                "Responsivas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        this._movimiento = true;

                        this.btnBuscaUsuario.Enabled = false;
                        this.btnBuscaResponsiva.Enabled = false;

                        this.panel1.Enabled = false;
                    }
                    else if (dialogResult == DialogResult.No) return;

                }

                // valida si el activo ya fue agregado
                if (!string.IsNullOrEmpty(activoSel.accion))
                    throw new Exception("El activo se encuentra en el traspaso");

                frmConfirmTraspaso form = new frmConfirmTraspaso(activoSel, this.tbResponsable.Text);

                var result = form.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    Modelos.Activos acttemp = form._activoModif;

                    // agregar el activo seleccionado al traspaso
                    this._activosT.Add(new Modelos.Activos
                    {
                        accion = "TRASPASO",
                        idActivo = acttemp.idActivo,
                        area = acttemp.area,
                        costo = acttemp.costo,
                        claveActivo = acttemp.claveActivo,
                        descripcion = acttemp.descripcion,
                        fechaAlta = acttemp.fechaAlta,
                        fechaModificacion = acttemp.fechaModificacion,
                        idArea = acttemp.idArea,
                        idTipo = acttemp.idTipo,
                        idUsuarioAlta = acttemp.idUsuarioAlta,
                        idUsuarioModifica = acttemp.idUsuarioModifica,
                        nombreCorto = acttemp.nombreCorto,
                        numEtiqueta = acttemp.numEtiqueta,
                        seleccionado = acttemp.seleccionado,
                        status = acttemp.status,
                        tipo = acttemp.tipo
                    });

                    this.gcActivosT.DataSource = null;
                    this.gcActivosT.DataSource = this._activosT;

                    // cambia el estatus del activo agregado
                    List<Modelos.Activos> temp = new List<Modelos.Activos>();
                    foreach(Modelos.Activos act in this._activos)
                    {
                        temp.Add(new Modelos.Activos
                        {
                            accion = (act.idActivo == activoSel.idActivo ? "TRASPASO" : act.accion),
                            idActivo = act.idActivo,
                            area = act.area,
                            costo = act.costo,
                            claveActivo = act.claveActivo,
                            descripcion = act.descripcion,
                            fechaAlta = act.fechaAlta,
                            fechaModificacion = act.fechaModificacion,
                            idArea = act.idArea,
                            idTipo = act.idTipo,
                            idUsuarioAlta = act.idUsuarioAlta,
                            idUsuarioModifica = act.idUsuarioModifica,
                            nombreCorto = act.nombreCorto,
                            numEtiqueta = act.numEtiqueta,
                            seleccionado = act.seleccionado,
                            status = act.status,
                            tipo = act.tipo
                        });
                    }

                    this._activos = null; this._activos = temp;
                    this.gcActivos.DataSource = null;
                    this.gcActivos.DataSource = this._activos;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGuardaCambios_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._idResponsiva == null || this._idUsuarioT == null)
                    throw new Exception("Realice algún movimiento para guardar cambios");

                bool resultado = false;

                if (this._respSelec)
                {
                    // validaciones
                    if (this._countListTraspaso == this._activosT.Count)
                        throw new Exception("No se han realizado modificaciones");

                    if (string.IsNullOrEmpty(this.tbMotivo.Text))
                        throw new Exception("Defina un motivo del traspaso");

                    if (this.tbMotivo.Text.Trim().Length < 10)
                    {
                        this.label7.ForeColor = System.Drawing.Color.Red;
                        this.label7.Text = "Motivo*";
                        throw new Exception("La longitud miníma permitida para el Motivo es de 10 carácteres");
                    }
                    else
                    {
                        this.label7.ForeColor = System.Drawing.Color.Black;
                        this.label7.Text = "Motivo";
                    }

                    string motivo = this.tbMotivo.Text;

                    // agrega a la responsiva existente los nuevos activos
                    // y cambia el estatus a los anteriores
                    // y las areas de los activos
                    resultado = this._responsivasNegocio.traspasoRespExist( this._activos, this._idUsuarioT, this._idUsuario, motivo,
                        this._activosT.Where(w => !string.IsNullOrEmpty(w.accion)).ToList(),
                        this._idResponsivaT, this._idResponsiva);

                    if (resultado)
                    {
                        string idActivos = string.Join(",", this._activosT.Where(w => !string.IsNullOrEmpty(w.accion)).Select(s => s.idActivo).ToList());

                        // bitacora
                        this._catalogosNegocio.generaBitacora(
                            "Traspaso realizado de la responsiva " + this._idResponsiva + "a la responsiva " + this._idResponsivaT +
                            " los activos " + idActivos + " por el motivo '" + motivo + "'", "ACTIVOS");
                    }
                    
                }
                else if (this._nuevaResp)
                {
                    if (this._activosT.Count == 0)
                        throw new Exception("Agregue al menos un activo a la lista");

                    string responsable = this.tbResponsableT.Text;
                    string sucursal = this.tbSucursalT.Text;
                    string puesto = this.tbPuestoT.Text;

                    if (string.IsNullOrEmpty(this.tbMotivo.Text))
                        throw new Exception("Defina un motivo del traspaso");

                    string motivo = this.tbMotivo.Text;

                    // abre formulario para la creacion de la nueva responsiva
                    frmNuevaResponsiva form = new frmNuevaResponsiva(this._activosT, responsable, sucursal, puesto);

                    var result = form.ShowDialog();

                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        string observaciones = form.observaciones;

                        // crea nueva responsiva
                        // y cambia el estatus a los anteriores
                        resultado = this._responsivasNegocio.traspasoCreaResp(this._activos, this._idUsuario, motivo,
                            this._activosT.Where(w => !string.IsNullOrEmpty(w.accion)).ToList(),
                            this._idResponsiva, observaciones, this._idUsuarioT, Modelos.Login.idUsuario);

                        if (resultado)
                        {
                            string idActivos = string.Join(",", this._activosT.Where(w => !string.IsNullOrEmpty(w.accion)).Select(s => s.idActivo).ToList());

                            // bitacora
                            this._catalogosNegocio.generaBitacora(
                                "Traspaso realizado de la responsiva " + this._idResponsiva + "a una nueva responsiva los activos " + idActivos + " por el motivo '" + motivo + "'", "ACTIVOS");
                        }
                    }
                    else return;
                }

                if (resultado)
                { 
                    MessageBox.Show("Cambios guardados correctamente", "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Information); 

                    // abrir formulario
                    frmReporteTraspasos form = new frmReporteTraspasos();

                    List<Modelos.Activos> activos = this._activosT.Where(w => !string.IsNullOrEmpty(w.accion)).ToList();

                    form._empresa = Modelos.Login.empresa;
                    form._logo = this._responsivasNegocio.obtieneLogo("reportes");
                    form._activos = activos;
                    form._detalle = this.tbMotivo.Text;
                    form._personaAnterior = this.tbResponsable.Text;
                    form._personaNueva = this.tbResponsableT.Text;
                    form._fecha = this._catalogosNegocio.getFechaServidor();

                    form.ShowDialog();

                    string idActivos = string.Join(",", this._activosT.Where(w => !string.IsNullOrEmpty(w.accion)).Select(s => s.idActivo).ToList());

                    // bitacora
                    this._catalogosNegocio.generaBitacora(
                        "Se genero la vista previa del informe de Traspaso, ACTIVOS: " + idActivos, "ACTIVOS");

                    this.limpia(); 
                }
                else
                    throw new Exception("Problemas al guardar cambios");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones 
                if (this.gridView2.GetSelectedRows().Count() == 0)
                    throw new Exception("Seleccione un activo para quitar de la lista de traspasos");

                // obtener el activo seleccionado
                Modelos.Activos activoSel = new Modelos.Activos();

                foreach (int i in this.gridView2.GetSelectedRows())
                {
                    var dr1 = this.gridView2.GetRow(i);

                    activoSel = (Modelos.Activos)dr1;
                }

                var result = this._activos.Where(w => w.idActivo == activoSel.idActivo).ToList();

                if (result.Count == 0)
                    throw new Exception("El activo que intenta quitar pertenece originalmete a la responsiva del traspaso");


                // quita el activo seleccionado
                this._activosT.Remove(activoSel);

                this.gcActivosT.DataSource = null;
                this.gcActivosT.DataSource = this._activosT;

                // cambia el estatus del activo agregado
                List<Modelos.Activos> temp = new List<Modelos.Activos>();
                foreach (Modelos.Activos act in this._activos)
                {
                    temp.Add(new Modelos.Activos
                    {
                        accion = (act.idActivo == activoSel.idActivo ? string.Empty : act.accion),
                        idActivo = act.idActivo,
                        area = act.area,
                        costo = act.costo,
                        claveActivo = act.claveActivo,
                        descripcion = act.descripcion,
                        fechaAlta = act.fechaAlta,
                        fechaModificacion = act.fechaModificacion,
                        idArea = act.idArea,
                        idTipo = act.idTipo,
                        idUsuarioAlta = act.idUsuarioAlta,
                        idUsuarioModifica = act.idUsuarioModifica,
                        nombreCorto = act.nombreCorto,
                        numEtiqueta = act.numEtiqueta,
                        seleccionado = act.seleccionado,
                        status = act.status,
                        tipo = act.tipo
                    });
                }

                this._activos = null; this._activos = temp;
                this.gcActivos.DataSource = null;
                this.gcActivos.DataSource = this._activos;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show(
                    "¿Desea cancelar el movimiento y volver a seleccionar las responsivas?",
                    "Responsivas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    this.limpia();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void limpia()
        {
            // limpia formulario
            // almacena ids de la primer seleccion
            this._idResponsiva = null;
            this._idUsuario = null;
            this._activos = new List<Modelos.Activos>();

            // almacena ids del traspaso
            this._idResponsivaT = null;
            this._idUsuarioT = null;
            this._activosT = new List<Modelos.Activos>();

            // definen cual accion tomar
            // nueva responsiva o agregar activos a una ya existente
            this._nuevaResp = false;
            this._respSelec = false;

            this._movimiento = false;

            this.tbMotivo.Text = string.Empty;

            this.tbResponsable.Text = string.Empty;
            this.tbResponsableT.Text = string.Empty;
            this.tbSucursal.Text = string.Empty;
            this.tbSucursalT.Text = string.Empty;
            this.tbPuesto.Text = string.Empty;
            this.tbPuestoT.Text = string.Empty;
            this.tbFolio.Text = string.Empty;

            this.gcActivos.DataSource = null;
            this.gcActivosT.DataSource = null;

            this.btnBuscaResponsiva.Enabled = true;
            this.btnBuscaUsuario.Enabled = true;

            this.panel1.Enabled = true;

            this._countListTraspaso = 0;
        }

        private void tbFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnBusFolio_Click(null, null);
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
                this._idUsuario = respFolio.responsiva.idPersona;

                // llena el grid con los puestos disponibles
                this.gcActivos.DataSource = respFolio.activos;
                this._activos = respFolio.activos;

                if (this.gridView1.RowCount != 0)
                    this.gridView1.UnselectRow(0);

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.CadetBlue;
                e.Appearance.ForeColor = Color.White;
            }
        }

        private void gridView2_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.CadetBlue;
                e.Appearance.ForeColor = Color.White;
            }
        }
    }
}
