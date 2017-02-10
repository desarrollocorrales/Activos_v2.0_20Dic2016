namespace Activos.GUIs.AltaActivos
{
    partial class frmBuscaActReparacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.reparacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidReparacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidActivos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUsuarioResp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcausa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcReparaciones = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.reparacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReparaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.DropDownWidth = 400;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(110, 86);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(282, 31);
            this.cmbTipo.TabIndex = 3;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(110, 123);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(282, 30);
            this.tbNombre.TabIndex = 4;
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre_KeyPress);
            // 
            // reparacionesBindingSource
            // 
            this.reparacionesBindingSource.DataSource = typeof(Activos.Modelos.Reparaciones);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(407, 99);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(124, 42);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbArea
            // 
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.DropDownWidth = 400;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(110, 49);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(421, 31);
            this.cmbArea.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Área";
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.DropDownWidth = 400;
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(110, 12);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(421, 31);
            this.cmbSucursal.TabIndex = 10;
            this.cmbSucursal.SelectionChangeCommitted += new System.EventHandler(this.cmbSucursal_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sucursal";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidReparacion,
            this.colidActivos,
            this.colactivo,
            this.colidUsuarioResp,
            this.colusuario,
            this.colfechaInicio,
            this.colfechaFin,
            this.colcausa,
            this.colstatus});
            this.gridView1.GridControl = this.gcReparaciones;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // colidReparacion
            // 
            this.colidReparacion.FieldName = "idReparacion";
            this.colidReparacion.Name = "colidReparacion";
            // 
            // colidActivos
            // 
            this.colidActivos.FieldName = "idActivos";
            this.colidActivos.Name = "colidActivos";
            // 
            // colactivo
            // 
            this.colactivo.Caption = "Activo";
            this.colactivo.FieldName = "activo";
            this.colactivo.Name = "colactivo";
            this.colactivo.OptionsColumn.AllowEdit = false;
            this.colactivo.OptionsColumn.AllowMove = false;
            this.colactivo.OptionsColumn.ReadOnly = true;
            this.colactivo.Visible = true;
            this.colactivo.VisibleIndex = 0;
            this.colactivo.Width = 150;
            // 
            // colidUsuarioResp
            // 
            this.colidUsuarioResp.FieldName = "idUsuarioResp";
            this.colidUsuarioResp.Name = "colidUsuarioResp";
            // 
            // colusuario
            // 
            this.colusuario.Caption = "Usuario";
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            this.colusuario.OptionsColumn.AllowEdit = false;
            this.colusuario.OptionsColumn.AllowMove = false;
            this.colusuario.OptionsColumn.ReadOnly = true;
            this.colusuario.Visible = true;
            this.colusuario.VisibleIndex = 1;
            this.colusuario.Width = 100;
            // 
            // colfechaInicio
            // 
            this.colfechaInicio.Caption = "Fecha Inicio";
            this.colfechaInicio.FieldName = "fechaInicio";
            this.colfechaInicio.Name = "colfechaInicio";
            this.colfechaInicio.OptionsColumn.AllowEdit = false;
            this.colfechaInicio.OptionsColumn.AllowMove = false;
            this.colfechaInicio.OptionsColumn.ReadOnly = true;
            this.colfechaInicio.Visible = true;
            this.colfechaInicio.VisibleIndex = 2;
            this.colfechaInicio.Width = 100;
            // 
            // colfechaFin
            // 
            this.colfechaFin.FieldName = "fechaFin";
            this.colfechaFin.Name = "colfechaFin";
            // 
            // colcausa
            // 
            this.colcausa.Caption = "Causa";
            this.colcausa.FieldName = "causa";
            this.colcausa.Name = "colcausa";
            this.colcausa.OptionsColumn.AllowEdit = false;
            this.colcausa.OptionsColumn.AllowMove = false;
            this.colcausa.OptionsColumn.ReadOnly = true;
            this.colcausa.Visible = true;
            this.colcausa.VisibleIndex = 3;
            this.colcausa.Width = 250;
            // 
            // colstatus
            // 
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            // 
            // gcReparaciones
            // 
            this.gcReparaciones.DataSource = this.reparacionesBindingSource;
            this.gcReparaciones.Location = new System.Drawing.Point(21, 172);
            this.gcReparaciones.MainView = this.gridView1;
            this.gcReparaciones.Name = "gcReparaciones";
            this.gcReparaciones.Size = new System.Drawing.Size(518, 215);
            this.gcReparaciones.TabIndex = 5;
            this.gcReparaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcReparaciones.DoubleClick += new System.EventHandler(this.gcReparaciones_DoubleClick);
            // 
            // frmBuscaActReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(552, 398);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gcReparaciones);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmBuscaActReparacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activos en Reparación";
            this.Load += new System.EventHandler(this.frmReparaActivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reparacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReparaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.BindingSource reparacionesBindingSource;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colidReparacion;
        private DevExpress.XtraGrid.Columns.GridColumn colidActivos;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuarioResp;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaInicio;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaFin;
        private DevExpress.XtraGrid.Columns.GridColumn colcausa;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private DevExpress.XtraGrid.GridControl gcReparaciones;
    }
}