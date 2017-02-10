namespace Activos.GUIs.Reportes
{
    partial class frmActivosPersona
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbResp = new System.Windows.Forms.TextBox();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRespDe = new System.Windows.Forms.TextBox();
            this.gcActivos = new DevExpress.XtraGrid.GridControl();
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
            this.cbBajas = new System.Windows.Forms.CheckBox();
            this.cbReparacion = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gcResponsables = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnomUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gcActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcResponsables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Responsable";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sucursal";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(506, 56);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(136, 43);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbResp
            // 
            this.tbResp.Location = new System.Drawing.Point(256, 63);
            this.tbResp.Name = "tbResp";
            this.tbResp.Size = new System.Drawing.Size(244, 30);
            this.tbResp.TabIndex = 12;
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.DropDownWidth = 400;
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(6, 63);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(244, 31);
            this.cmbSucursal.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Responsable:";
            // 
            // tbRespDe
            // 
            this.tbRespDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbRespDe.Location = new System.Drawing.Point(158, 364);
            this.tbRespDe.Name = "tbRespDe";
            this.tbRespDe.ReadOnly = true;
            this.tbRespDe.Size = new System.Drawing.Size(497, 30);
            this.tbRespDe.TabIndex = 18;
            // 
            // gcActivos
            // 
            this.gcActivos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gcActivos.Location = new System.Drawing.Point(12, 409);
            this.gcActivos.MainView = this.gridView2;
            this.gcActivos.Name = "gcActivos";
            this.gcActivos.Size = new System.Drawing.Size(661, 182);
            this.gcActivos.TabIndex = 17;
            this.gcActivos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
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
            this.colnumEtiqueta.VisibleIndex = 1;
            // 
            // colclaveActivo
            // 
            this.colclaveActivo.Caption = "Cve. Activo";
            this.colclaveActivo.FieldName = "claveActivo";
            this.colclaveActivo.Name = "colclaveActivo";
            this.colclaveActivo.Visible = true;
            this.colclaveActivo.VisibleIndex = 2;
            // 
            // colstatus1
            // 
            this.colstatus1.Caption = "Estatus";
            this.colstatus1.FieldName = "status";
            this.colstatus1.Name = "colstatus1";
            this.colstatus1.Visible = true;
            this.colstatus1.VisibleIndex = 3;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVistaPrevia.Location = new System.Drawing.Point(496, 597);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(158, 43);
            this.btnVistaPrevia.TabIndex = 20;
            this.btnVistaPrevia.Text = "Vista Previa";
            this.btnVistaPrevia.UseVisualStyleBackColor = true;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // cbBajas
            // 
            this.cbBajas.AutoSize = true;
            this.cbBajas.Location = new System.Drawing.Point(100, 29);
            this.cbBajas.Name = "cbBajas";
            this.cbBajas.Size = new System.Drawing.Size(73, 27);
            this.cbBajas.TabIndex = 21;
            this.cbBajas.Text = "Bajas";
            this.cbBajas.UseVisualStyleBackColor = true;
            // 
            // cbReparacion
            // 
            this.cbReparacion.AutoSize = true;
            this.cbReparacion.Location = new System.Drawing.Point(253, 29);
            this.cbReparacion.Name = "cbReparacion";
            this.cbReparacion.Size = new System.Drawing.Size(141, 27);
            this.cbReparacion.TabIndex = 22;
            this.cbReparacion.Text = "Reparaciones";
            this.cbReparacion.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.cbBajas);
            this.groupBox1.Controls.Add(this.cbReparacion);
            this.groupBox1.Location = new System.Drawing.Point(92, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 79);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Incluir Activos:";
            // 
            // gcResponsables
            // 
            this.gcResponsables.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gcResponsables.Location = new System.Drawing.Point(12, 219);
            this.gcResponsables.MainView = this.gridView1;
            this.gcResponsables.Name = "gcResponsables";
            this.gcResponsables.Size = new System.Drawing.Size(661, 136);
            this.gcResponsables.TabIndex = 24;
            this.gcResponsables.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcResponsables.DoubleClick += new System.EventHandler(this.gcResponsables_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidUsuario,
            this.colnomUsuario,
            this.colpuesto,
            this.colsucursal});
            this.gridView1.GridControl = this.gcResponsables;
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
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbSucursal);
            this.groupBox2.Controls.Add(this.tbResp);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 116);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Búsqueda";
            // 
            // frmActivosPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 648);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gcResponsables);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVistaPrevia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRespDe);
            this.Controls.Add(this.gcActivos);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmActivosPersona";
            this.Text = "Reporte de Activos por Persona";
            this.Load += new System.EventHandler(this.frmActivosPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcResponsables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbResp;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRespDe;
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
        private System.Windows.Forms.CheckBox cbBajas;
        private System.Windows.Forms.CheckBox cbReparacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gcResponsables;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colnomUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colpuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colsucursal;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}