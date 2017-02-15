namespace Activos.GUIs.Traspasos
{
    partial class frmBuscaUsuarioResp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscaUsuarioResp));
            this.gcUsuarios = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnomUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gcResponsivas = new DevExpress.XtraGrid.GridControl();
            this.responsivasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidResponsiva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUsuario1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUsuarioCrea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaBaja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsucursal1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpuesto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colresponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcActivos = new DevExpress.XtraGrid.GridControl();
            this.activosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.btnNuevaResp = new System.Windows.Forms.Button();
            this.btnRespSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbUsuarioSeleccionado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResponsivas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsivasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // gcUsuarios
            // 
            this.gcUsuarios.Location = new System.Drawing.Point(14, 118);
            this.gcUsuarios.MainView = this.gridView1;
            this.gcUsuarios.Name = "gcUsuarios";
            this.gcUsuarios.Size = new System.Drawing.Size(530, 154);
            this.gcUsuarios.TabIndex = 7;
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
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Usuarios";
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
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(378, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(124, 40);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gcResponsivas
            // 
            this.gcResponsivas.DataSource = this.responsivasBindingSource;
            this.gcResponsivas.Location = new System.Drawing.Point(14, 318);
            this.gcResponsivas.MainView = this.gridView2;
            this.gcResponsivas.Name = "gcResponsivas";
            this.gcResponsivas.Size = new System.Drawing.Size(530, 150);
            this.gcResponsivas.TabIndex = 8;
            this.gcResponsivas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gcResponsivas.DoubleClick += new System.EventHandler(this.gcResponsivas_DoubleClick);
            // 
            // responsivasBindingSource
            // 
            this.responsivasBindingSource.DataSource = typeof(Activos.Modelos.Responsivas);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidResponsiva,
            this.colidUsuario1,
            this.colidUsuarioCrea,
            this.colfecha,
            this.colfechaBaja,
            this.colobservaciones,
            this.colstatus,
            this.colsucursal1,
            this.colpuesto1,
            this.colresponsable});
            this.gridView2.GridControl = this.gcResponsivas;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowViewCaption = true;
            this.gridView2.ViewCaption = "Responsivas";
            this.gridView2.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView2_RowCellStyle);
            // 
            // colidResponsiva
            // 
            this.colidResponsiva.FieldName = "idResponsiva";
            this.colidResponsiva.Name = "colidResponsiva";
            // 
            // colidUsuario1
            // 
            this.colidUsuario1.FieldName = "idUsuario";
            this.colidUsuario1.Name = "colidUsuario1";
            // 
            // colidUsuarioCrea
            // 
            this.colidUsuarioCrea.FieldName = "idUsuarioCrea";
            this.colidUsuarioCrea.Name = "colidUsuarioCrea";
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha de Creación";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.OptionsColumn.AllowMove = false;
            this.colfecha.OptionsColumn.ReadOnly = true;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 0;
            this.colfecha.Width = 110;
            // 
            // colfechaBaja
            // 
            this.colfechaBaja.FieldName = "fechaBaja";
            this.colfechaBaja.Name = "colfechaBaja";
            // 
            // colobservaciones
            // 
            this.colobservaciones.Caption = "Observaciones";
            this.colobservaciones.FieldName = "observaciones";
            this.colobservaciones.Name = "colobservaciones";
            this.colobservaciones.OptionsColumn.AllowEdit = false;
            this.colobservaciones.OptionsColumn.AllowMove = false;
            this.colobservaciones.OptionsColumn.ReadOnly = true;
            this.colobservaciones.Visible = true;
            this.colobservaciones.VisibleIndex = 1;
            this.colobservaciones.Width = 402;
            // 
            // colstatus
            // 
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            // 
            // colsucursal1
            // 
            this.colsucursal1.FieldName = "sucursal";
            this.colsucursal1.Name = "colsucursal1";
            // 
            // colpuesto1
            // 
            this.colpuesto1.FieldName = "puesto";
            this.colpuesto1.Name = "colpuesto1";
            // 
            // colresponsable
            // 
            this.colresponsable.FieldName = "responsable";
            this.colresponsable.Name = "colresponsable";
            // 
            // gcActivos
            // 
            this.gcActivos.DataSource = this.activosBindingSource;
            this.gcActivos.Location = new System.Drawing.Point(14, 474);
            this.gcActivos.MainView = this.gridView3;
            this.gcActivos.Name = "gcActivos";
            this.gcActivos.Size = new System.Drawing.Size(530, 144);
            this.gcActivos.TabIndex = 9;
            this.gcActivos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // activosBindingSource
            // 
            this.activosBindingSource.DataSource = typeof(Activos.Modelos.Activos);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.gridView3.GridControl = this.gcActivos;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.OptionsView.ShowViewCaption = true;
            this.gridView3.ViewCaption = "Activos";
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
            // 
            // colnombreCorto
            // 
            this.colnombreCorto.Caption = "Activo";
            this.colnombreCorto.FieldName = "nombreCorto";
            this.colnombreCorto.Name = "colnombreCorto";
            this.colnombreCorto.OptionsColumn.AllowEdit = false;
            this.colnombreCorto.OptionsColumn.AllowMove = false;
            this.colnombreCorto.OptionsColumn.ReadOnly = true;
            this.colnombreCorto.Visible = true;
            this.colnombreCorto.VisibleIndex = 2;
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
            this.colnumEtiqueta.FieldName = "numEtiqueta";
            this.colnumEtiqueta.Name = "colnumEtiqueta";
            this.colnumEtiqueta.OptionsColumn.AllowEdit = false;
            this.colnumEtiqueta.OptionsColumn.AllowMove = false;
            this.colnumEtiqueta.OptionsColumn.ReadOnly = true;
            // 
            // colclaveActivo
            // 
            this.colclaveActivo.FieldName = "claveActivo";
            this.colclaveActivo.Name = "colclaveActivo";
            this.colclaveActivo.OptionsColumn.AllowEdit = false;
            this.colclaveActivo.OptionsColumn.AllowMove = false;
            this.colclaveActivo.OptionsColumn.ReadOnly = true;
            // 
            // colstatus1
            // 
            this.colstatus1.FieldName = "status";
            this.colstatus1.Name = "colstatus1";
            // 
            // btnNuevaResp
            // 
            this.btnNuevaResp.Location = new System.Drawing.Point(104, 628);
            this.btnNuevaResp.Name = "btnNuevaResp";
            this.btnNuevaResp.Size = new System.Drawing.Size(177, 39);
            this.btnNuevaResp.TabIndex = 10;
            this.btnNuevaResp.Text = "Nueva Responsiva";
            this.btnNuevaResp.UseVisualStyleBackColor = true;
            this.btnNuevaResp.Click += new System.EventHandler(this.btnNuevaResp_Click);
            // 
            // btnRespSelect
            // 
            this.btnRespSelect.Location = new System.Drawing.Point(297, 628);
            this.btnRespSelect.Name = "btnRespSelect";
            this.btnRespSelect.Size = new System.Drawing.Size(230, 39);
            this.btnRespSelect.TabIndex = 11;
            this.btnRespSelect.Text = "Seleccionar Responsiva";
            this.btnRespSelect.UseVisualStyleBackColor = true;
            this.btnRespSelect.Click += new System.EventHandler(this.btnRespSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Persona";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(21, 50);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(330, 30);
            this.tbUsuario.TabIndex = 5;
            // 
            // tbUsuarioSeleccionado
            // 
            this.tbUsuarioSeleccionado.Location = new System.Drawing.Point(95, 278);
            this.tbUsuarioSeleccionado.Name = "tbUsuarioSeleccionado";
            this.tbUsuarioSeleccionado.ReadOnly = true;
            this.tbUsuarioSeleccionado.Size = new System.Drawing.Size(432, 30);
            this.tbUsuarioSeleccionado.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Persona";
            // 
            // frmBuscaUsuarioResp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(558, 685);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbUsuarioSeleccionado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRespSelect);
            this.Controls.Add(this.btnNuevaResp);
            this.Controls.Add(this.gcActivos);
            this.Controls.Add(this.gcResponsivas);
            this.Controls.Add(this.gcUsuarios);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmBuscaUsuarioResp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Personas";
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResponsivas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsivasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcUsuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colnomUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colpuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colsucursal;
        private System.Windows.Forms.Button btnBuscar;
        private DevExpress.XtraGrid.GridControl gcResponsivas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gcActivos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.Button btnNuevaResp;
        private System.Windows.Forms.Button btnRespSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbUsuarioSeleccionado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource responsivasBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidResponsiva;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuario1;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuarioCrea;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaBaja;
        private DevExpress.XtraGrid.Columns.GridColumn colobservaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colsucursal1;
        private DevExpress.XtraGrid.Columns.GridColumn colpuesto1;
        private DevExpress.XtraGrid.Columns.GridColumn colresponsable;
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
        private DevExpress.XtraGrid.Columns.GridColumn colstatus1;
    }
}