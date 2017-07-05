namespace Activos.GUIs.Reportes
{
    partial class frmMovimientosActivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimientosActivos));
            this.tbResultCveActivo = new System.Windows.Forms.TextBox();
            this.tbResultNumEtiqueta = new System.Windows.Forms.TextBox();
            this.tbResultNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rbPCA = new System.Windows.Forms.RadioButton();
            this.rbPNE = new System.Windows.Forms.RadioButton();
            this.rbPN = new System.Windows.Forms.RadioButton();
            this.gbPNE = new System.Windows.Forms.GroupBox();
            this.tbNumEtiqueta = new System.Windows.Forms.TextBox();
            this.btnBuscarPNE = new System.Windows.Forms.Button();
            this.gbPCA = new System.Windows.Forms.GroupBox();
            this.tbCveActivo = new System.Windows.Forms.TextBox();
            this.btnBuscarPCA = new System.Windows.Forms.Button();
            this.gbPTN = new System.Windows.Forms.GroupBox();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarPTN = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.gcCambios = new DevExpress.XtraGrid.GridControl();
            this.cambiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidcambio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidPersonaAnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpersonaAnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidAreaAnterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colareaanterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidPersonaNuevo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpersonaNuevo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidAreaNueva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colareaNueva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmotivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnVistaPrevia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.gbPNE.SuspendLayout();
            this.gbPCA.SuspendLayout();
            this.gbPTN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCambios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cambiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbResultCveActivo
            // 
            this.tbResultCveActivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbResultCveActivo.Location = new System.Drawing.Point(468, 494);
            this.tbResultCveActivo.Name = "tbResultCveActivo";
            this.tbResultCveActivo.ReadOnly = true;
            this.tbResultCveActivo.Size = new System.Drawing.Size(110, 30);
            this.tbResultCveActivo.TabIndex = 37;
            this.tbResultCveActivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbResultNumEtiqueta
            // 
            this.tbResultNumEtiqueta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbResultNumEtiqueta.Location = new System.Drawing.Point(195, 494);
            this.tbResultNumEtiqueta.Name = "tbResultNumEtiqueta";
            this.tbResultNumEtiqueta.ReadOnly = true;
            this.tbResultNumEtiqueta.Size = new System.Drawing.Size(146, 30);
            this.tbResultNumEtiqueta.TabIndex = 36;
            this.tbResultNumEtiqueta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbResultNombre
            // 
            this.tbResultNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbResultNombre.Location = new System.Drawing.Point(133, 454);
            this.tbResultNombre.Name = "tbResultNombre";
            this.tbResultNombre.ReadOnly = true;
            this.tbResultNombre.Size = new System.Drawing.Size(444, 30);
            this.tbResultNombre.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 497);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "Núm. Etiqueta:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Cve. Activo:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Activo:";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridControl1.Location = new System.Drawing.Point(6, 328);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(614, 116);
            this.gridControl1.TabIndex = 29;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView2_RowCellClick);
            this.gridView2.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView2_RowCellStyle);
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "idActivo";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Área";
            this.gridColumn2.FieldName = "area";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowMove = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tipo";
            this.gridColumn3.FieldName = "tipo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowMove = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Activo";
            this.gridColumn4.FieldName = "nombreCorto";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowMove = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "descripcion";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "sucursal";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Usuario";
            this.gridColumn7.FieldName = "usuario";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.AllowMove = false;
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "costo";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn9
            // 
            this.gridColumn9.FieldName = "numEtiqueta";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // gridColumn10
            // 
            this.gridColumn10.FieldName = "claveActivo";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // rbPCA
            // 
            this.rbPCA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbPCA.AutoSize = true;
            this.rbPCA.Location = new System.Drawing.Point(626, 65);
            this.rbPCA.Name = "rbPCA";
            this.rbPCA.Size = new System.Drawing.Size(160, 27);
            this.rbPCA.TabIndex = 27;
            this.rbPCA.Text = "Por Clave Activo";
            this.rbPCA.UseVisualStyleBackColor = true;
            this.rbPCA.CheckedChanged += new System.EventHandler(this.rbPCA_CheckedChanged);
            // 
            // rbPNE
            // 
            this.rbPNE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbPNE.AutoSize = true;
            this.rbPNE.Location = new System.Drawing.Point(626, 44);
            this.rbPNE.Name = "rbPNE";
            this.rbPNE.Size = new System.Drawing.Size(182, 27);
            this.rbPNE.TabIndex = 26;
            this.rbPNE.Text = "Por Núm. Etiqueta";
            this.rbPNE.UseVisualStyleBackColor = true;
            this.rbPNE.CheckedChanged += new System.EventHandler(this.rbPNE_CheckedChanged);
            // 
            // rbPN
            // 
            this.rbPN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbPN.AutoSize = true;
            this.rbPN.Location = new System.Drawing.Point(626, 23);
            this.rbPN.Name = "rbPN";
            this.rbPN.Size = new System.Drawing.Size(128, 27);
            this.rbPN.TabIndex = 25;
            this.rbPN.Text = "Por Nombre";
            this.rbPN.UseVisualStyleBackColor = true;
            this.rbPN.CheckedChanged += new System.EventHandler(this.rbPN_CheckedChanged);
            // 
            // gbPNE
            // 
            this.gbPNE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbPNE.Controls.Add(this.tbNumEtiqueta);
            this.gbPNE.Controls.Add(this.btnBuscarPNE);
            this.gbPNE.Location = new System.Drawing.Point(316, 210);
            this.gbPNE.Name = "gbPNE";
            this.gbPNE.Size = new System.Drawing.Size(304, 112);
            this.gbPNE.TabIndex = 23;
            this.gbPNE.TabStop = false;
            // 
            // tbNumEtiqueta
            // 
            this.tbNumEtiqueta.Location = new System.Drawing.Point(28, 29);
            this.tbNumEtiqueta.Name = "tbNumEtiqueta";
            this.tbNumEtiqueta.Size = new System.Drawing.Size(249, 30);
            this.tbNumEtiqueta.TabIndex = 5;
            this.tbNumEtiqueta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumEtiqueta_KeyPress);
            // 
            // btnBuscarPNE
            // 
            this.btnBuscarPNE.Location = new System.Drawing.Point(71, 65);
            this.btnBuscarPNE.Name = "btnBuscarPNE";
            this.btnBuscarPNE.Size = new System.Drawing.Size(163, 34);
            this.btnBuscarPNE.TabIndex = 4;
            this.btnBuscarPNE.Text = "Buscar";
            this.btnBuscarPNE.UseVisualStyleBackColor = true;
            this.btnBuscarPNE.Click += new System.EventHandler(this.btnBuscarPNE_Click);
            // 
            // gbPCA
            // 
            this.gbPCA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbPCA.Controls.Add(this.tbCveActivo);
            this.gbPCA.Controls.Add(this.btnBuscarPCA);
            this.gbPCA.Location = new System.Drawing.Point(6, 210);
            this.gbPCA.Name = "gbPCA";
            this.gbPCA.Size = new System.Drawing.Size(304, 112);
            this.gbPCA.TabIndex = 22;
            this.gbPCA.TabStop = false;
            // 
            // tbCveActivo
            // 
            this.tbCveActivo.Location = new System.Drawing.Point(28, 29);
            this.tbCveActivo.Name = "tbCveActivo";
            this.tbCveActivo.Size = new System.Drawing.Size(249, 30);
            this.tbCveActivo.TabIndex = 6;
            this.tbCveActivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCveActivo_KeyPress);
            // 
            // btnBuscarPCA
            // 
            this.btnBuscarPCA.Location = new System.Drawing.Point(71, 65);
            this.btnBuscarPCA.Name = "btnBuscarPCA";
            this.btnBuscarPCA.Size = new System.Drawing.Size(163, 34);
            this.btnBuscarPCA.TabIndex = 5;
            this.btnBuscarPCA.Text = "Buscar";
            this.btnBuscarPCA.UseVisualStyleBackColor = true;
            this.btnBuscarPCA.Click += new System.EventHandler(this.btnBuscarPCA_Click);
            // 
            // gbPTN
            // 
            this.gbPTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbPTN.Controls.Add(this.cmbArea);
            this.gbPTN.Controls.Add(this.cmbSucursal);
            this.gbPTN.Controls.Add(this.label7);
            this.gbPTN.Controls.Add(this.label6);
            this.gbPTN.Controls.Add(this.label3);
            this.gbPTN.Controls.Add(this.btnBuscarPTN);
            this.gbPTN.Controls.Add(this.tbNombre);
            this.gbPTN.Controls.Add(this.label1);
            this.gbPTN.Controls.Add(this.cmbTipo);
            this.gbPTN.Location = new System.Drawing.Point(6, 12);
            this.gbPTN.Name = "gbPTN";
            this.gbPTN.Size = new System.Drawing.Size(614, 192);
            this.gbPTN.TabIndex = 21;
            this.gbPTN.TabStop = false;
            // 
            // cmbArea
            // 
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.DropDownWidth = 400;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(20, 112);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(279, 31);
            this.cmbArea.TabIndex = 8;
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.DropDownWidth = 400;
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(20, 53);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(279, 31);
            this.cmbSucursal.TabIndex = 7;
            this.cmbSucursal.SelectionChangeCommitted += new System.EventHandler(this.cmbSucursal_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Área";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sucursal";
            // 
            // btnBuscarPTN
            // 
            this.btnBuscarPTN.Location = new System.Drawing.Point(226, 149);
            this.btnBuscarPTN.Name = "btnBuscarPTN";
            this.btnBuscarPTN.Size = new System.Drawing.Size(163, 34);
            this.btnBuscarPTN.TabIndex = 3;
            this.btnBuscarPTN.Text = "Buscar";
            this.btnBuscarPTN.UseVisualStyleBackColor = true;
            this.btnBuscarPTN.Click += new System.EventHandler(this.btnBuscarPTN_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(318, 112);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(279, 30);
            this.tbNombre.TabIndex = 2;
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.DropDownWidth = 400;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(316, 52);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(279, 31);
            this.cmbTipo.TabIndex = 0;
            // 
            // gcCambios
            // 
            this.gcCambios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gcCambios.DataSource = this.cambiosBindingSource;
            this.gcCambios.Location = new System.Drawing.Point(6, 535);
            this.gcCambios.MainView = this.gridView1;
            this.gcCambios.Name = "gcCambios";
            this.gcCambios.Size = new System.Drawing.Size(614, 171);
            this.gcCambios.TabIndex = 38;
            this.gcCambios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // cambiosBindingSource
            // 
            this.cambiosBindingSource.DataSource = typeof(
                Modelos.Cambios);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidcambio,
            this.colidPersonaAnt,
            this.colpersonaAnt,
            this.colidAreaAnterior,
            this.colareaanterior,
            this.colidPersonaNuevo,
            this.colpersonaNuevo,
            this.colidAreaNueva,
            this.colareaNueva,
            this.colfecha,
            this.colmotivo,
            this.colidActivo});
            this.gridView1.GridControl = this.gcCambios;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Cambios";
            // 
            // colidcambio
            // 
            this.colidcambio.FieldName = "idcambio";
            this.colidcambio.Name = "colidcambio";
            // 
            // colidPersonaAnt
            // 
            this.colidPersonaAnt.FieldName = "idPersonaAnt";
            this.colidPersonaAnt.Name = "colidPersonaAnt";
            // 
            // colpersonaAnt
            // 
            this.colpersonaAnt.Caption = "Persona Ant.";
            this.colpersonaAnt.FieldName = "personaAnt";
            this.colpersonaAnt.Name = "colpersonaAnt";
            this.colpersonaAnt.Visible = true;
            this.colpersonaAnt.VisibleIndex = 0;
            // 
            // colidAreaAnterior
            // 
            this.colidAreaAnterior.FieldName = "idAreaAnterior";
            this.colidAreaAnterior.Name = "colidAreaAnterior";
            // 
            // colareaanterior
            // 
            this.colareaanterior.Caption = "Área Ant.";
            this.colareaanterior.FieldName = "areaanterior";
            this.colareaanterior.Name = "colareaanterior";
            this.colareaanterior.Visible = true;
            this.colareaanterior.VisibleIndex = 1;
            // 
            // colidPersonaNuevo
            // 
            this.colidPersonaNuevo.FieldName = "idPersonaNuevo";
            this.colidPersonaNuevo.Name = "colidPersonaNuevo";
            // 
            // colpersonaNuevo
            // 
            this.colpersonaNuevo.Caption = "Persona sig.";
            this.colpersonaNuevo.FieldName = "personaNuevo";
            this.colpersonaNuevo.Name = "colpersonaNuevo";
            this.colpersonaNuevo.Visible = true;
            this.colpersonaNuevo.VisibleIndex = 2;
            // 
            // colidAreaNueva
            // 
            this.colidAreaNueva.FieldName = "idAreaNueva";
            this.colidAreaNueva.Name = "colidAreaNueva";
            // 
            // colareaNueva
            // 
            this.colareaNueva.Caption = "Área Sig.";
            this.colareaNueva.FieldName = "areaNueva";
            this.colareaNueva.Name = "colareaNueva";
            this.colareaNueva.Visible = true;
            this.colareaNueva.VisibleIndex = 3;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 4;
            // 
            // colmotivo
            // 
            this.colmotivo.Caption = "Motivo";
            this.colmotivo.FieldName = "motivo";
            this.colmotivo.Name = "colmotivo";
            this.colmotivo.Visible = true;
            this.colmotivo.VisibleIndex = 5;
            // 
            // colidActivo
            // 
            this.colidActivo.FieldName = "idActivo";
            this.colidActivo.Name = "colidActivo";
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVistaPrevia.Location = new System.Drawing.Point(440, 723);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(163, 34);
            this.btnVistaPrevia.TabIndex = 39;
            this.btnVistaPrevia.Text = "Vista Previa";
            this.btnVistaPrevia.UseVisualStyleBackColor = true;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // frmMovimientosActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 774);
            this.Controls.Add(this.btnVistaPrevia);
            this.Controls.Add(this.rbPNE);
            this.Controls.Add(this.gcCambios);
            this.Controls.Add(this.tbResultCveActivo);
            this.Controls.Add(this.tbResultNumEtiqueta);
            this.Controls.Add(this.gbPNE);
            this.Controls.Add(this.tbResultNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.rbPCA);
            this.Controls.Add(this.rbPN);
            this.Controls.Add(this.gbPCA);
            this.Controls.Add(this.gbPTN);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMovimientosActivos";
            this.Text = "Movimientos Activos";
            this.Load += new System.EventHandler(this.frmMovimientosActivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.gbPNE.ResumeLayout(false);
            this.gbPNE.PerformLayout();
            this.gbPCA.ResumeLayout(false);
            this.gbPCA.PerformLayout();
            this.gbPTN.ResumeLayout(false);
            this.gbPTN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCambios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cambiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbResultCveActivo;
        private System.Windows.Forms.TextBox tbResultNumEtiqueta;
        private System.Windows.Forms.TextBox tbResultNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private System.Windows.Forms.RadioButton rbPCA;
        private System.Windows.Forms.RadioButton rbPNE;
        private System.Windows.Forms.RadioButton rbPN;
        private System.Windows.Forms.GroupBox gbPNE;
        private System.Windows.Forms.TextBox tbNumEtiqueta;
        private System.Windows.Forms.Button btnBuscarPNE;
        private System.Windows.Forms.GroupBox gbPCA;
        private System.Windows.Forms.TextBox tbCveActivo;
        private System.Windows.Forms.Button btnBuscarPCA;
        private System.Windows.Forms.GroupBox gbPTN;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarPTN;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipo;
        private DevExpress.XtraGrid.GridControl gcCambios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource cambiosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidcambio;
        private DevExpress.XtraGrid.Columns.GridColumn colidPersonaAnt;
        private DevExpress.XtraGrid.Columns.GridColumn colpersonaAnt;
        private DevExpress.XtraGrid.Columns.GridColumn colidAreaAnterior;
        private DevExpress.XtraGrid.Columns.GridColumn colareaanterior;
        private DevExpress.XtraGrid.Columns.GridColumn colidPersonaNuevo;
        private DevExpress.XtraGrid.Columns.GridColumn colpersonaNuevo;
        private DevExpress.XtraGrid.Columns.GridColumn colidAreaNueva;
        private DevExpress.XtraGrid.Columns.GridColumn colareaNueva;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colmotivo;
        private DevExpress.XtraGrid.Columns.GridColumn colidActivo;
        private System.Windows.Forms.Button btnVistaPrevia;

    }
}