﻿namespace Activos.GUIs.Reportes
{
    partial class frmResponsivasSucursalXResp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResponsivasSucursalXResp));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSucursales = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gcResponsables = new DevExpress.XtraGrid.GridControl();
            this.responsivasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidResponsiva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUsuarioCrea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaBaja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colresponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcActivos = new DevExpress.XtraGrid.GridControl();
            this.activosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colseleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colarea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombreCorto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaAlta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUsuarioAlta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUsuarioModifica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumEtiqueta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colclaveActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnVistaPrevia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRespDe = new System.Windows.Forms.TextBox();
            this.cbBajas = new System.Windows.Forms.CheckBox();
            this.cbReparaciones = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFolio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gcResponsables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsivasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sucursal";
            // 
            // cmbSucursales
            // 
            this.cmbSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursales.DropDownWidth = 400;
            this.cmbSucursales.FormattingEnabled = true;
            this.cmbSucursales.Location = new System.Drawing.Point(97, 19);
            this.cmbSucursales.Name = "cmbSucursales";
            this.cmbSucursales.Size = new System.Drawing.Size(367, 31);
            this.cmbSucursales.TabIndex = 15;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(478, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(136, 43);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gcResponsables
            // 
            this.gcResponsables.DataSource = this.responsivasBindingSource;
            this.gcResponsables.Location = new System.Drawing.Point(12, 61);
            this.gcResponsables.MainView = this.gridView1;
            this.gcResponsables.Name = "gcResponsables";
            this.gcResponsables.Size = new System.Drawing.Size(602, 200);
            this.gcResponsables.TabIndex = 17;
            this.gcResponsables.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcResponsables.DoubleClick += new System.EventHandler(this.gcResponsables_DoubleClick);
            // 
            // responsivasBindingSource
            // 
            this.responsivasBindingSource.DataSource = typeof(Modelos.Responsivas);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidResponsiva,
            this.colidUsuario,
            this.colidUsuarioCrea,
            this.colfechaBaja,
            this.colobservaciones,
            this.colstatus,
            this.colresponsable,
            this.colsucursal,
            this.colpuesto,
            this.colfecha});
            this.gridView1.GridControl = this.gcResponsables;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Responsables";
            // 
            // colidResponsiva
            // 
            this.colidResponsiva.AppearanceCell.Options.UseTextOptions = true;
            this.colidResponsiva.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colidResponsiva.Caption = "Folio";
            this.colidResponsiva.FieldName = "idResponsiva";
            this.colidResponsiva.Name = "colidResponsiva";
            this.colidResponsiva.Visible = true;
            this.colidResponsiva.VisibleIndex = 0;
            this.colidResponsiva.Width = 30;
            // 
            // colidUsuario
            // 
            this.colidUsuario.FieldName = "idPersona";
            this.colidUsuario.Name = "colidUsuario";
            // 
            // colidUsuarioCrea
            // 
            this.colidUsuarioCrea.FieldName = "idUsuarioCrea";
            this.colidUsuarioCrea.Name = "colidUsuarioCrea";
            // 
            // colfechaBaja
            // 
            this.colfechaBaja.FieldName = "fechaBaja";
            this.colfechaBaja.Name = "colfechaBaja";
            // 
            // colobservaciones
            // 
            this.colobservaciones.FieldName = "observaciones";
            this.colobservaciones.Name = "colobservaciones";
            // 
            // colstatus
            // 
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            // 
            // colresponsable
            // 
            this.colresponsable.Caption = "Responsable";
            this.colresponsable.FieldName = "responsable";
            this.colresponsable.Name = "colresponsable";
            this.colresponsable.OptionsColumn.AllowEdit = false;
            this.colresponsable.OptionsColumn.AllowMove = false;
            this.colresponsable.OptionsColumn.ReadOnly = true;
            this.colresponsable.Visible = true;
            this.colresponsable.VisibleIndex = 1;
            this.colresponsable.Width = 111;
            // 
            // colsucursal
            // 
            this.colsucursal.Caption = "Sucursal";
            this.colsucursal.FieldName = "sucursal";
            this.colsucursal.Name = "colsucursal";
            this.colsucursal.OptionsColumn.AllowEdit = false;
            this.colsucursal.OptionsColumn.AllowMove = false;
            this.colsucursal.OptionsColumn.ReadOnly = true;
            this.colsucursal.Visible = true;
            this.colsucursal.VisibleIndex = 2;
            this.colsucursal.Width = 111;
            // 
            // colpuesto
            // 
            this.colpuesto.Caption = "Puesto";
            this.colpuesto.FieldName = "puesto";
            this.colpuesto.Name = "colpuesto";
            this.colpuesto.OptionsColumn.AllowEdit = false;
            this.colpuesto.OptionsColumn.AllowMove = false;
            this.colpuesto.OptionsColumn.ReadOnly = true;
            this.colpuesto.Visible = true;
            this.colpuesto.VisibleIndex = 3;
            this.colpuesto.Width = 111;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.OptionsColumn.AllowMove = false;
            this.colfecha.OptionsColumn.ReadOnly = true;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 4;
            this.colfecha.Width = 113;
            // 
            // gcActivos
            // 
            this.gcActivos.DataSource = this.activosBindingSource;
            this.gcActivos.Location = new System.Drawing.Point(12, 336);
            this.gcActivos.MainView = this.gridView2;
            this.gcActivos.Name = "gcActivos";
            this.gcActivos.Size = new System.Drawing.Size(602, 200);
            this.gcActivos.TabIndex = 18;
            this.gcActivos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // activosBindingSource
            // 
            this.activosBindingSource.DataSource = typeof(Modelos.Activos);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colseleccionado,
            this.colidActivo,
            this.colidArea,
            this.colarea,
            this.colidTipo,
            this.coltipo,
            this.colnombreCorto,
            this.coldescripcion,
            this.colfechaAlta,
            this.colidUsuarioAlta,
            this.colfechaModificacion,
            this.colidUsuarioModifica,
            this.colcosto,
            this.colnumEtiqueta,
            this.colclaveActivo,
            this.colstatus1});
            this.gridView2.GridControl = this.gcActivos;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowViewCaption = true;
            this.gridView2.ViewCaption = "Activos";
            // 
            // colseleccionado
            // 
            this.colseleccionado.FieldName = "seleccionado";
            this.colseleccionado.Name = "colseleccionado";
            // 
            // colidActivo
            // 
            this.colidActivo.FieldName = "idActivo";
            this.colidActivo.Name = "colidActivo";
            // 
            // colidArea
            // 
            this.colidArea.FieldName = "idArea";
            this.colidArea.Name = "colidArea";
            // 
            // colarea
            // 
            this.colarea.FieldName = "area";
            this.colarea.Name = "colarea";
            // 
            // colidTipo
            // 
            this.colidTipo.FieldName = "idTipo";
            this.colidTipo.Name = "colidTipo";
            // 
            // coltipo
            // 
            this.coltipo.Caption = "Tipo";
            this.coltipo.FieldName = "tipo";
            this.coltipo.Name = "coltipo";
            this.coltipo.Visible = true;
            this.coltipo.VisibleIndex = 1;
            // 
            // colnombreCorto
            // 
            this.colnombreCorto.Caption = "Activo";
            this.colnombreCorto.FieldName = "nombreCorto";
            this.colnombreCorto.Name = "colnombreCorto";
            this.colnombreCorto.Visible = true;
            this.colnombreCorto.VisibleIndex = 0;
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            // 
            // colfechaAlta
            // 
            this.colfechaAlta.FieldName = "fechaAlta";
            this.colfechaAlta.Name = "colfechaAlta";
            // 
            // colidUsuarioAlta
            // 
            this.colidUsuarioAlta.FieldName = "idUsuarioAlta";
            this.colidUsuarioAlta.Name = "colidUsuarioAlta";
            // 
            // colfechaModificacion
            // 
            this.colfechaModificacion.FieldName = "fechaModificacion";
            this.colfechaModificacion.Name = "colfechaModificacion";
            // 
            // colidUsuarioModifica
            // 
            this.colidUsuarioModifica.FieldName = "idUsuarioModifica";
            this.colidUsuarioModifica.Name = "colidUsuarioModifica";
            // 
            // colcosto
            // 
            this.colcosto.FieldName = "costo";
            this.colcosto.Name = "colcosto";
            // 
            // colnumEtiqueta
            // 
            this.colnumEtiqueta.Caption = "Núm. Etiqueta";
            this.colnumEtiqueta.FieldName = "numEtiqueta";
            this.colnumEtiqueta.Name = "colnumEtiqueta";
            this.colnumEtiqueta.Visible = true;
            this.colnumEtiqueta.VisibleIndex = 2;
            // 
            // colclaveActivo
            // 
            this.colclaveActivo.Caption = "Cve. Activo";
            this.colclaveActivo.FieldName = "claveActivo";
            this.colclaveActivo.Name = "colclaveActivo";
            this.colclaveActivo.Visible = true;
            this.colclaveActivo.VisibleIndex = 3;
            // 
            // colstatus1
            // 
            this.colstatus1.Caption = "Estatus";
            this.colstatus1.FieldName = "status";
            this.colstatus1.Name = "colstatus1";
            this.colstatus1.Visible = true;
            this.colstatus1.VisibleIndex = 4;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.Location = new System.Drawing.Point(478, 542);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(136, 43);
            this.btnVistaPrevia.TabIndex = 19;
            this.btnVistaPrevia.Text = "Vista Previa";
            this.btnVistaPrevia.UseVisualStyleBackColor = true;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Responsable:";
            // 
            // tbRespDe
            // 
            this.tbRespDe.Location = new System.Drawing.Point(140, 300);
            this.tbRespDe.Name = "tbRespDe";
            this.tbRespDe.ReadOnly = true;
            this.tbRespDe.Size = new System.Drawing.Size(339, 30);
            this.tbRespDe.TabIndex = 20;
            // 
            // cbBajas
            // 
            this.cbBajas.AutoSize = true;
            this.cbBajas.Location = new System.Drawing.Point(184, 267);
            this.cbBajas.Name = "cbBajas";
            this.cbBajas.Size = new System.Drawing.Size(73, 27);
            this.cbBajas.TabIndex = 23;
            this.cbBajas.Text = "Bajas";
            this.cbBajas.UseVisualStyleBackColor = true;
            // 
            // cbReparaciones
            // 
            this.cbReparaciones.AutoSize = true;
            this.cbReparaciones.Location = new System.Drawing.Point(297, 267);
            this.cbReparaciones.Name = "cbReparaciones";
            this.cbReparaciones.Size = new System.Drawing.Size(141, 27);
            this.cbReparaciones.TabIndex = 24;
            this.cbReparaciones.Text = "Reparaciones";
            this.cbReparaciones.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Folio:";
            // 
            // tbFolio
            // 
            this.tbFolio.Location = new System.Drawing.Point(551, 300);
            this.tbFolio.Name = "tbFolio";
            this.tbFolio.ReadOnly = true;
            this.tbFolio.Size = new System.Drawing.Size(63, 30);
            this.tbFolio.TabIndex = 25;
            this.tbFolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmResponsivasSucursalXResp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 594);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFolio);
            this.Controls.Add(this.cbBajas);
            this.Controls.Add(this.cbReparaciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRespDe);
            this.Controls.Add(this.btnVistaPrevia);
            this.Controls.Add(this.gcActivos);
            this.Controls.Add(this.gcResponsables);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSucursales);
            this.Controls.Add(this.btnBuscar);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmResponsivasSucursalXResp";
            this.Text = "Responsivas por Sucursal";
            this.Load += new System.EventHandler(this.frmResponsivasSucursalXResp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcResponsables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsivasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSucursales;
        private System.Windows.Forms.Button btnBuscar;
        private DevExpress.XtraGrid.GridControl gcResponsables;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colidResponsiva;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuarioCrea;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaBaja;
        private DevExpress.XtraGrid.Columns.GridColumn colobservaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colresponsable;
        private DevExpress.XtraGrid.Columns.GridColumn colsucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colpuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.GridControl gcActivos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionado;
        private DevExpress.XtraGrid.Columns.GridColumn colidActivo;
        private DevExpress.XtraGrid.Columns.GridColumn colidArea;
        private DevExpress.XtraGrid.Columns.GridColumn colarea;
        private DevExpress.XtraGrid.Columns.GridColumn colidTipo;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo;
        private DevExpress.XtraGrid.Columns.GridColumn colnombreCorto;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaAlta;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuarioAlta;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuarioModifica;
        private DevExpress.XtraGrid.Columns.GridColumn colcosto;
        private DevExpress.XtraGrid.Columns.GridColumn colnumEtiqueta;
        private DevExpress.XtraGrid.Columns.GridColumn colclaveActivo;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus1;
        private System.Windows.Forms.Button btnVistaPrevia;
        private System.Windows.Forms.BindingSource responsivasBindingSource;
        private System.Windows.Forms.BindingSource activosBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRespDe;
        private System.Windows.Forms.CheckBox cbBajas;
        private System.Windows.Forms.CheckBox cbReparaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFolio;
    }
}