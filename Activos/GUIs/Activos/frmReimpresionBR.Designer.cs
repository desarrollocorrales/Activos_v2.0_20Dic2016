namespace Activos.GUIs.Activos
{
    partial class frmReimpresionBR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReimpresionBR));
            this.cbMotivo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gcReparaciones = new DevExpress.XtraGrid.GridControl();
            this.reparacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidReparacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUsuarioResp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcausa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservActivacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbActivo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFechaIni = new System.Windows.Forms.TextBox();
            this.lbFechaIni = new System.Windows.Forms.Label();
            this.tbFechaFin = new System.Windows.Forms.TextBox();
            this.lbFechaFin = new System.Windows.Forms.Label();
            this.tbCausaObserv = new System.Windows.Forms.TextBox();
            this.lbCausObs = new System.Windows.Forms.Label();
            this.tbObservAct = new System.Windows.Forms.TextBox();
            this.lbObservAct = new System.Windows.Forms.Label();
            this.btnVistaPrevia = new System.Windows.Forms.Button();
            this.gcBajas = new DevExpress.XtraGrid.GridControl();
            this.bajasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidBaja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidActivo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUsuaroiBaja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidMotivoBaja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbFecha = new System.Windows.Forms.TextBox();
            this.lbFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gcReparaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reparacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBajas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bajasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMotivo
            // 
            this.cbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMotivo.FormattingEnabled = true;
            this.cbMotivo.Items.AddRange(new object[] {
            "BAJA",
            "REPARACION"});
            this.cbMotivo.Location = new System.Drawing.Point(238, 12);
            this.cbMotivo.Name = "cbMotivo";
            this.cbMotivo.Size = new System.Drawing.Size(141, 31);
            this.cbMotivo.TabIndex = 157;
            this.cbMotivo.SelectionChangeCommitted += new System.EventHandler(this.cbMotivo_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 156;
            this.label6.Text = "Motivo";
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.DropDownWidth = 400;
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(108, 65);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(307, 31);
            this.cmbSucursal.TabIndex = 167;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 166;
            this.label4.Text = "Sucursal";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(420, 63);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(115, 32);
            this.btnBuscar.TabIndex = 163;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gcReparaciones
            // 
            this.gcReparaciones.DataSource = this.reparacionesBindingSource;
            this.gcReparaciones.Location = new System.Drawing.Point(12, 102);
            this.gcReparaciones.MainView = this.gridView1;
            this.gcReparaciones.Name = "gcReparaciones";
            this.gcReparaciones.Size = new System.Drawing.Size(524, 180);
            this.gcReparaciones.TabIndex = 162;
            this.gcReparaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcReparaciones.DoubleClick += new System.EventHandler(this.gcReparaciones_DoubleClick);
            // 
            // reparacionesBindingSource
            // 
            this.reparacionesBindingSource.DataSource = typeof(Modelos.Reparaciones);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidReparacion,
            this.colidActivo,
            this.colactivo,
            this.colidUsuarioResp,
            this.colusuario,
            this.colfechaInicio,
            this.colfechaFin,
            this.colcausa,
            this.colobservActivacion,
            this.colstatus});
            this.gridView1.GridControl = this.gcReparaciones;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colidReparacion
            // 
            this.colidReparacion.FieldName = "idReparacion";
            this.colidReparacion.Name = "colidReparacion";
            // 
            // colidActivo
            // 
            this.colidActivo.FieldName = "idActivo";
            this.colidActivo.Name = "colidActivo";
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
            // 
            // colidUsuarioResp
            // 
            this.colidUsuarioResp.FieldName = "idUsuarioResp";
            this.colidUsuarioResp.Name = "colidUsuarioResp";
            // 
            // colusuario
            // 
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            // 
            // colfechaInicio
            // 
            this.colfechaInicio.Caption = "Fecha Inicial";
            this.colfechaInicio.FieldName = "fechaInicio";
            this.colfechaInicio.Name = "colfechaInicio";
            this.colfechaInicio.OptionsColumn.AllowEdit = false;
            this.colfechaInicio.OptionsColumn.AllowMove = false;
            this.colfechaInicio.OptionsColumn.ReadOnly = true;
            this.colfechaInicio.Visible = true;
            this.colfechaInicio.VisibleIndex = 1;
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
            this.colcausa.VisibleIndex = 2;
            // 
            // colobservActivacion
            // 
            this.colobservActivacion.FieldName = "observActivacion";
            this.colobservActivacion.Name = "colobservActivacion";
            // 
            // colstatus
            // 
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            // 
            // tbActivo
            // 
            this.tbActivo.BackColor = System.Drawing.Color.White;
            this.tbActivo.Location = new System.Drawing.Point(77, 288);
            this.tbActivo.Name = "tbActivo";
            this.tbActivo.ReadOnly = true;
            this.tbActivo.Size = new System.Drawing.Size(459, 30);
            this.tbActivo.TabIndex = 169;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 168;
            this.label5.Text = "Activo";
            // 
            // tbFechaIni
            // 
            this.tbFechaIni.BackColor = System.Drawing.Color.White;
            this.tbFechaIni.Location = new System.Drawing.Point(129, 324);
            this.tbFechaIni.Name = "tbFechaIni";
            this.tbFechaIni.ReadOnly = true;
            this.tbFechaIni.Size = new System.Drawing.Size(114, 30);
            this.tbFechaIni.TabIndex = 171;
            // 
            // lbFechaIni
            // 
            this.lbFechaIni.AutoSize = true;
            this.lbFechaIni.Location = new System.Drawing.Point(8, 327);
            this.lbFechaIni.Name = "lbFechaIni";
            this.lbFechaIni.Size = new System.Drawing.Size(115, 23);
            this.lbFechaIni.TabIndex = 170;
            this.lbFechaIni.Text = "Fecha Inicial";
            // 
            // tbFechaFin
            // 
            this.tbFechaFin.BackColor = System.Drawing.Color.White;
            this.tbFechaFin.Location = new System.Drawing.Point(422, 324);
            this.tbFechaFin.Name = "tbFechaFin";
            this.tbFechaFin.ReadOnly = true;
            this.tbFechaFin.Size = new System.Drawing.Size(114, 30);
            this.tbFechaFin.TabIndex = 173;
            // 
            // lbFechaFin
            // 
            this.lbFechaFin.AutoSize = true;
            this.lbFechaFin.Location = new System.Drawing.Point(311, 327);
            this.lbFechaFin.Name = "lbFechaFin";
            this.lbFechaFin.Size = new System.Drawing.Size(105, 23);
            this.lbFechaFin.TabIndex = 172;
            this.lbFechaFin.Text = "Fecha Final";
            // 
            // tbCausaObserv
            // 
            this.tbCausaObserv.BackColor = System.Drawing.Color.White;
            this.tbCausaObserv.Location = new System.Drawing.Point(12, 391);
            this.tbCausaObserv.Multiline = true;
            this.tbCausaObserv.Name = "tbCausaObserv";
            this.tbCausaObserv.ReadOnly = true;
            this.tbCausaObserv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCausaObserv.Size = new System.Drawing.Size(252, 189);
            this.tbCausaObserv.TabIndex = 175;
            // 
            // lbCausObs
            // 
            this.lbCausObs.AutoSize = true;
            this.lbCausObs.Location = new System.Drawing.Point(8, 365);
            this.lbCausObs.Name = "lbCausObs";
            this.lbCausObs.Size = new System.Drawing.Size(60, 23);
            this.lbCausObs.TabIndex = 174;
            this.lbCausObs.Text = "Causa";
            // 
            // tbObservAct
            // 
            this.tbObservAct.BackColor = System.Drawing.Color.White;
            this.tbObservAct.Location = new System.Drawing.Point(284, 391);
            this.tbObservAct.Multiline = true;
            this.tbObservAct.Name = "tbObservAct";
            this.tbObservAct.ReadOnly = true;
            this.tbObservAct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbObservAct.Size = new System.Drawing.Size(252, 189);
            this.tbObservAct.TabIndex = 177;
            // 
            // lbObservAct
            // 
            this.lbObservAct.AutoSize = true;
            this.lbObservAct.Location = new System.Drawing.Point(280, 365);
            this.lbObservAct.Name = "lbObservAct";
            this.lbObservAct.Size = new System.Drawing.Size(219, 23);
            this.lbObservAct.TabIndex = 176;
            this.lbObservAct.Text = "Observaciones Activación";
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.Location = new System.Drawing.Point(207, 593);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(133, 32);
            this.btnVistaPrevia.TabIndex = 178;
            this.btnVistaPrevia.Text = "Vista Previa";
            this.btnVistaPrevia.UseVisualStyleBackColor = true;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // gcBajas
            // 
            this.gcBajas.DataSource = this.bajasBindingSource;
            this.gcBajas.Location = new System.Drawing.Point(12, 102);
            this.gcBajas.MainView = this.gridView2;
            this.gcBajas.Name = "gcBajas";
            this.gcBajas.Size = new System.Drawing.Size(524, 180);
            this.gcBajas.TabIndex = 179;
            this.gcBajas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gcBajas.DoubleClick += new System.EventHandler(this.gcBajas_DoubleClick);
            // 
            // bajasBindingSource
            // 
            this.bajasBindingSource.DataSource = typeof(Modelos.Bajas);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidBaja,
            this.colidActivo1,
            this.colactivo1,
            this.colfecha,
            this.colidUsuaroiBaja,
            this.colusuario1,
            this.colobservaciones,
            this.colidMotivoBaja});
            this.gridView2.GridControl = this.gcBajas;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView2_RowCellStyle);
            // 
            // colidBaja
            // 
            this.colidBaja.FieldName = "idBaja";
            this.colidBaja.Name = "colidBaja";
            // 
            // colidActivo1
            // 
            this.colidActivo1.FieldName = "idActivo";
            this.colidActivo1.Name = "colidActivo1";
            // 
            // colactivo1
            // 
            this.colactivo1.Caption = "Activo";
            this.colactivo1.FieldName = "activo";
            this.colactivo1.Name = "colactivo1";
            this.colactivo1.OptionsColumn.AllowEdit = false;
            this.colactivo1.OptionsColumn.AllowMove = false;
            this.colactivo1.OptionsColumn.ReadOnly = true;
            this.colactivo1.Visible = true;
            this.colactivo1.VisibleIndex = 0;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha Baja";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.OptionsColumn.AllowMove = false;
            this.colfecha.OptionsColumn.ReadOnly = true;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 1;
            // 
            // colidUsuaroiBaja
            // 
            this.colidUsuaroiBaja.FieldName = "idUsuaroiBaja";
            this.colidUsuaroiBaja.Name = "colidUsuaroiBaja";
            // 
            // colusuario1
            // 
            this.colusuario1.FieldName = "usuario";
            this.colusuario1.Name = "colusuario1";
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
            this.colobservaciones.VisibleIndex = 2;
            // 
            // colidMotivoBaja
            // 
            this.colidMotivoBaja.FieldName = "idMotivoBaja";
            this.colidMotivoBaja.Name = "colidMotivoBaja";
            // 
            // tbFecha
            // 
            this.tbFecha.BackColor = System.Drawing.Color.White;
            this.tbFecha.Location = new System.Drawing.Point(77, 595);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.ReadOnly = true;
            this.tbFecha.Size = new System.Drawing.Size(114, 30);
            this.tbFecha.TabIndex = 181;
            this.tbFecha.Visible = false;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(8, 598);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(60, 23);
            this.lbFecha.TabIndex = 180;
            this.lbFecha.Text = "Fecha";
            this.lbFecha.Visible = false;
            // 
            // frmReimpresionBR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 637);
            this.Controls.Add(this.tbFecha);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.gcBajas);
            this.Controls.Add(this.btnVistaPrevia);
            this.Controls.Add(this.tbObservAct);
            this.Controls.Add(this.lbObservAct);
            this.Controls.Add(this.tbCausaObserv);
            this.Controls.Add(this.lbCausObs);
            this.Controls.Add(this.tbFechaFin);
            this.Controls.Add(this.lbFechaFin);
            this.Controls.Add(this.tbFechaIni);
            this.Controls.Add(this.lbFechaIni);
            this.Controls.Add(this.tbActivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gcReparaciones);
            this.Controls.Add(this.cbMotivo);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmReimpresionBR";
            this.Text = "Reimpresión de Bajas y Reparaciones de Activos";
            this.Load += new System.EventHandler(this.frmReimpresionBR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcReparaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reparacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBajas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bajasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMotivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private DevExpress.XtraGrid.GridControl gcReparaciones;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource reparacionesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidReparacion;
        private DevExpress.XtraGrid.Columns.GridColumn colidActivo;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuarioResp;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaInicio;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaFin;
        private DevExpress.XtraGrid.Columns.GridColumn colcausa;
        private DevExpress.XtraGrid.Columns.GridColumn colobservActivacion;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private System.Windows.Forms.TextBox tbActivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFechaIni;
        private System.Windows.Forms.Label lbFechaIni;
        private System.Windows.Forms.TextBox tbFechaFin;
        private System.Windows.Forms.Label lbFechaFin;
        private System.Windows.Forms.TextBox tbCausaObserv;
        private System.Windows.Forms.Label lbCausObs;
        private System.Windows.Forms.TextBox tbObservAct;
        private System.Windows.Forms.Label lbObservAct;
        private System.Windows.Forms.Button btnVistaPrevia;
        private DevExpress.XtraGrid.GridControl gcBajas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource bajasBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidBaja;
        private DevExpress.XtraGrid.Columns.GridColumn colidActivo1;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo1;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuaroiBaja;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario1;
        private DevExpress.XtraGrid.Columns.GridColumn colobservaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colidMotivoBaja;
        private System.Windows.Forms.TextBox tbFecha;
        private System.Windows.Forms.Label lbFecha;
    }
}