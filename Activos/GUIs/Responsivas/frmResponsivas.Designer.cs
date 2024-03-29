﻿namespace Activos.GUIs.Responsivas
{
    partial class frmResponsivas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResponsivas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbSucursalSelec = new System.Windows.Forms.TextBox();
            this.tbPuestoSelec = new System.Windows.Forms.TextBox();
            this.tbUsuarioSelec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gcUsuarios = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnomUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbAgregaResp = new System.Windows.Forms.CheckBox();
            this.lbObservaciones = new System.Windows.Forms.Label();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.btnCreaResp = new System.Windows.Forms.Button();
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
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnBuscaActivos = new System.Windows.Forms.Button();
            this.btnAgregaArea = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btnAgregaArea);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.tbSucursalSelec);
            this.groupBox1.Controls.Add(this.tbPuestoSelec);
            this.groupBox1.Controls.Add(this.tbUsuarioSelec);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.gcUsuarios);
            this.groupBox1.Controls.Add(this.tbUsuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personas";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(379, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(124, 40);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbSucursalSelec
            // 
            this.tbSucursalSelec.Location = new System.Drawing.Point(107, 406);
            this.tbSucursalSelec.Name = "tbSucursalSelec";
            this.tbSucursalSelec.ReadOnly = true;
            this.tbSucursalSelec.Size = new System.Drawing.Size(440, 30);
            this.tbSucursalSelec.TabIndex = 9;
            // 
            // tbPuestoSelec
            // 
            this.tbPuestoSelec.Location = new System.Drawing.Point(107, 359);
            this.tbPuestoSelec.Name = "tbPuestoSelec";
            this.tbPuestoSelec.ReadOnly = true;
            this.tbPuestoSelec.Size = new System.Drawing.Size(440, 30);
            this.tbPuestoSelec.TabIndex = 8;
            // 
            // tbUsuarioSelec
            // 
            this.tbUsuarioSelec.Location = new System.Drawing.Point(107, 307);
            this.tbUsuarioSelec.Name = "tbUsuarioSelec";
            this.tbUsuarioSelec.ReadOnly = true;
            this.tbUsuarioSelec.Size = new System.Drawing.Size(440, 30);
            this.tbUsuarioSelec.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sucursal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Puesto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Persona:";
            // 
            // gcUsuarios
            // 
            this.gcUsuarios.Location = new System.Drawing.Point(17, 138);
            this.gcUsuarios.MainView = this.gridView1;
            this.gcUsuarios.Name = "gcUsuarios";
            this.gcUsuarios.Size = new System.Drawing.Size(530, 144);
            this.gcUsuarios.TabIndex = 3;
            this.gcUsuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcUsuarios.DoubleClick += new System.EventHandler(this.gcUsuarios_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidUsuario,
            this.colnomUsuario,
            this.colpuesto,
            this.colsucursal});
            this.gridView1.GridControl = this.gcUsuarios;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // colidUsuario
            // 
            this.colidUsuario.FieldName = "idPersona";
            this.colidUsuario.Name = "colidUsuario";
            // 
            // colnomUsuario
            // 
            this.colnomUsuario.Caption = "Nombre";
            this.colnomUsuario.FieldName = "nombre";
            this.colnomUsuario.Name = "colnomUsuario";
            this.colnomUsuario.OptionsColumn.AllowEdit = false;
            this.colnomUsuario.OptionsColumn.AllowMove = false;
            this.colnomUsuario.OptionsColumn.ReadOnly = true;
            this.colnomUsuario.Visible = true;
            this.colnomUsuario.VisibleIndex = 0;
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
            this.colpuesto.VisibleIndex = 1;
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
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(24, 70);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(349, 30);
            this.tbUsuario.TabIndex = 1;
            this.tbUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUsuario_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personas";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.cbAgregaResp);
            this.groupBox2.Controls.Add(this.lbObservaciones);
            this.groupBox2.Controls.Add(this.tbObservaciones);
            this.groupBox2.Controls.Add(this.btnCreaResp);
            this.groupBox2.Controls.Add(this.gcActivos);
            this.groupBox2.Controls.Add(this.btnBuscaActivos);
            this.groupBox2.Location = new System.Drawing.Point(582, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 450);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Responsivas";
            // 
            // cbAgregaResp
            // 
            this.cbAgregaResp.AutoSize = true;
            this.cbAgregaResp.Location = new System.Drawing.Point(21, 408);
            this.cbAgregaResp.Name = "cbAgregaResp";
            this.cbAgregaResp.Size = new System.Drawing.Size(313, 27);
            this.cbAgregaResp.TabIndex = 12;
            this.cbAgregaResp.Text = "Agregar Responsables Adicionales";
            this.cbAgregaResp.UseVisualStyleBackColor = true;
            // 
            // lbObservaciones
            // 
            this.lbObservaciones.AutoSize = true;
            this.lbObservaciones.Location = new System.Drawing.Point(8, 291);
            this.lbObservaciones.Name = "lbObservaciones";
            this.lbObservaciones.Size = new System.Drawing.Size(130, 23);
            this.lbObservaciones.TabIndex = 11;
            this.lbObservaciones.Text = "Observaciones";
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbObservaciones.Location = new System.Drawing.Point(12, 317);
            this.tbObservaciones.MaxLength = 250;
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(546, 75);
            this.tbObservaciones.TabIndex = 10;
            // 
            // btnCreaResp
            // 
            this.btnCreaResp.Location = new System.Drawing.Point(358, 400);
            this.btnCreaResp.Name = "btnCreaResp";
            this.btnCreaResp.Size = new System.Drawing.Size(186, 41);
            this.btnCreaResp.TabIndex = 2;
            this.btnCreaResp.Text = "Crear Responsiva";
            this.btnCreaResp.UseVisualStyleBackColor = true;
            this.btnCreaResp.Click += new System.EventHandler(this.btnCreaResp_Click);
            // 
            // gcActivos
            // 
            this.gcActivos.DataSource = this.activosBindingSource;
            this.gcActivos.Location = new System.Drawing.Point(6, 85);
            this.gcActivos.MainView = this.gridView2;
            this.gcActivos.Name = "gcActivos";
            this.gcActivos.Size = new System.Drawing.Size(552, 197);
            this.gcActivos.TabIndex = 1;
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
            this.colstatus});
            this.gridView2.GridControl = this.gcActivos;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
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
            this.colarea.Caption = "Área";
            this.colarea.FieldName = "area";
            this.colarea.Name = "colarea";
            this.colarea.OptionsColumn.AllowEdit = false;
            this.colarea.OptionsColumn.AllowMove = false;
            this.colarea.OptionsColumn.ReadOnly = true;
            this.colarea.Visible = true;
            this.colarea.VisibleIndex = 0;
            this.colarea.Width = 114;
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
            this.coltipo.OptionsColumn.AllowEdit = false;
            this.coltipo.OptionsColumn.AllowMove = false;
            this.coltipo.OptionsColumn.ReadOnly = true;
            this.coltipo.Visible = true;
            this.coltipo.VisibleIndex = 1;
            this.coltipo.Width = 114;
            // 
            // colnombreCorto
            // 
            this.colnombreCorto.Caption = "Nombre";
            this.colnombreCorto.FieldName = "nombreCorto";
            this.colnombreCorto.Name = "colnombreCorto";
            this.colnombreCorto.OptionsColumn.AllowEdit = false;
            this.colnombreCorto.OptionsColumn.AllowMove = false;
            this.colnombreCorto.OptionsColumn.ReadOnly = true;
            this.colnombreCorto.Visible = true;
            this.colnombreCorto.VisibleIndex = 2;
            this.colnombreCorto.Width = 114;
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
            this.colnumEtiqueta.OptionsColumn.AllowEdit = false;
            this.colnumEtiqueta.OptionsColumn.AllowMove = false;
            this.colnumEtiqueta.OptionsColumn.ReadOnly = true;
            this.colnumEtiqueta.Visible = true;
            this.colnumEtiqueta.VisibleIndex = 3;
            this.colnumEtiqueta.Width = 90;
            // 
            // colclaveActivo
            // 
            this.colclaveActivo.Caption = "Cve. Etiqueta";
            this.colclaveActivo.FieldName = "claveActivo";
            this.colclaveActivo.Name = "colclaveActivo";
            this.colclaveActivo.OptionsColumn.AllowEdit = false;
            this.colclaveActivo.OptionsColumn.AllowMove = false;
            this.colclaveActivo.OptionsColumn.ReadOnly = true;
            this.colclaveActivo.Visible = true;
            this.colclaveActivo.VisibleIndex = 4;
            this.colclaveActivo.Width = 102;
            // 
            // colstatus
            // 
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            // 
            // btnBuscaActivos
            // 
            this.btnBuscaActivos.Location = new System.Drawing.Point(189, 29);
            this.btnBuscaActivos.Name = "btnBuscaActivos";
            this.btnBuscaActivos.Size = new System.Drawing.Size(186, 41);
            this.btnBuscaActivos.TabIndex = 0;
            this.btnBuscaActivos.Text = "Buscar Activos";
            this.btnBuscaActivos.UseVisualStyleBackColor = true;
            this.btnBuscaActivos.Click += new System.EventHandler(this.btnBuscaActivos_Click);
            // 
            // btnAgregaArea
            // 
            this.btnAgregaArea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregaArea.BackgroundImage")));
            this.btnAgregaArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregaArea.Location = new System.Drawing.Point(516, 69);
            this.btnAgregaArea.Name = "btnAgregaArea";
            this.btnAgregaArea.Size = new System.Drawing.Size(31, 31);
            this.btnAgregaArea.TabIndex = 185;
            this.btnAgregaArea.Tag = "23";
            this.btnAgregaArea.UseVisualStyleBackColor = true;
            this.btnAgregaArea.Click += new System.EventHandler(this.btnAgregaArea_Click);
            // 
            // frmResponsivas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1157, 473);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmResponsivas";
            this.Text = "Responsivas";
            this.Load += new System.EventHandler(this.frmResponsivas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gcUsuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colnomUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colpuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colsucursal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreaResp;
        private DevExpress.XtraGrid.GridControl gcActivos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Button btnBuscaActivos;
        private System.Windows.Forms.BindingSource activosBindingSource;
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
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private System.Windows.Forms.Label lbObservaciones;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.TextBox tbSucursalSelec;
        private System.Windows.Forms.TextBox tbPuestoSelec;
        private System.Windows.Forms.TextBox tbUsuarioSelec;
        private System.Windows.Forms.CheckBox cbAgregaResp;
        private System.Windows.Forms.Button btnAgregaArea;
    }
}