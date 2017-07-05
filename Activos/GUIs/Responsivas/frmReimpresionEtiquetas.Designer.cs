namespace Activos.GUIs.Responsivas
{
    partial class frmReimpresionEtiquetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReimpresionEtiquetas));
            this.gbPNE = new System.Windows.Forms.GroupBox();
            this.tbNumEtiqueta = new System.Windows.Forms.TextBox();
            this.btnBuscarPNE = new System.Windows.Forms.Button();
            this.gbPCA = new System.Windows.Forms.GroupBox();
            this.tbCveActivo = new System.Windows.Forms.TextBox();
            this.btnBuscarPCA = new System.Windows.Forms.Button();
            this.rbPCA = new System.Windows.Forms.RadioButton();
            this.rbPNE = new System.Windows.Forms.RadioButton();
            this.tbResultCveActivo = new System.Windows.Forms.TextBox();
            this.tbResultNumEtiqueta = new System.Windows.Forms.TextBox();
            this.tbResultDesc = new System.Windows.Forms.TextBox();
            this.tbResultNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImprEtiquetas = new System.Windows.Forms.Button();
            this.gbPTN = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.btnBuscarPTN = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.rbPTN = new System.Windows.Forms.RadioButton();
            this.gcResulBusquedas = new DevExpress.XtraGrid.GridControl();
            this.activosDescBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.gbPNE.SuspendLayout();
            this.gbPCA.SuspendLayout();
            this.gbPTN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcResulBusquedas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosDescBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPNE
            // 
            this.gbPNE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbPNE.Controls.Add(this.tbNumEtiqueta);
            this.gbPNE.Controls.Add(this.btnBuscarPNE);
            this.gbPNE.Location = new System.Drawing.Point(554, 173);
            this.gbPNE.Name = "gbPNE";
            this.gbPNE.Size = new System.Drawing.Size(234, 152);
            this.gbPNE.TabIndex = 5;
            this.gbPNE.TabStop = false;
            // 
            // tbNumEtiqueta
            // 
            this.tbNumEtiqueta.Location = new System.Drawing.Point(18, 41);
            this.tbNumEtiqueta.Name = "tbNumEtiqueta";
            this.tbNumEtiqueta.Size = new System.Drawing.Size(199, 30);
            this.tbNumEtiqueta.TabIndex = 5;
            this.tbNumEtiqueta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumEtiqueta_KeyPress);
            // 
            // btnBuscarPNE
            // 
            this.btnBuscarPNE.Location = new System.Drawing.Point(36, 77);
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
            this.gbPCA.Location = new System.Drawing.Point(554, 12);
            this.gbPCA.Name = "gbPCA";
            this.gbPCA.Size = new System.Drawing.Size(234, 152);
            this.gbPCA.TabIndex = 4;
            this.gbPCA.TabStop = false;
            // 
            // tbCveActivo
            // 
            this.tbCveActivo.Location = new System.Drawing.Point(18, 41);
            this.tbCveActivo.Name = "tbCveActivo";
            this.tbCveActivo.Size = new System.Drawing.Size(199, 30);
            this.tbCveActivo.TabIndex = 6;
            this.tbCveActivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCveActivo_KeyPress);
            // 
            // btnBuscarPCA
            // 
            this.btnBuscarPCA.Location = new System.Drawing.Point(36, 77);
            this.btnBuscarPCA.Name = "btnBuscarPCA";
            this.btnBuscarPCA.Size = new System.Drawing.Size(163, 34);
            this.btnBuscarPCA.TabIndex = 5;
            this.btnBuscarPCA.Text = "Buscar";
            this.btnBuscarPCA.UseVisualStyleBackColor = true;
            this.btnBuscarPCA.Click += new System.EventHandler(this.btnBuscarPCA_Click);
            // 
            // rbPCA
            // 
            this.rbPCA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbPCA.AutoSize = true;
            this.rbPCA.BackColor = System.Drawing.Color.Transparent;
            this.rbPCA.ForeColor = System.Drawing.Color.Black;
            this.rbPCA.Location = new System.Drawing.Point(794, 197);
            this.rbPCA.Name = "rbPCA";
            this.rbPCA.Size = new System.Drawing.Size(160, 27);
            this.rbPCA.TabIndex = 12;
            this.rbPCA.Text = "Por Clave Activo";
            this.rbPCA.UseVisualStyleBackColor = false;
            this.rbPCA.CheckedChanged += new System.EventHandler(this.rbPCA_CheckedChanged);
            // 
            // rbPNE
            // 
            this.rbPNE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbPNE.AutoSize = true;
            this.rbPNE.BackColor = System.Drawing.Color.Transparent;
            this.rbPNE.ForeColor = System.Drawing.Color.Black;
            this.rbPNE.Location = new System.Drawing.Point(794, 175);
            this.rbPNE.Name = "rbPNE";
            this.rbPNE.Size = new System.Drawing.Size(182, 27);
            this.rbPNE.TabIndex = 11;
            this.rbPNE.Text = "Por Núm. Etiqueta";
            this.rbPNE.UseVisualStyleBackColor = false;
            this.rbPNE.CheckedChanged += new System.EventHandler(this.rbPNE_CheckedChanged);
            // 
            // tbResultCveActivo
            // 
            this.tbResultCveActivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbResultCveActivo.Location = new System.Drawing.Point(554, 566);
            this.tbResultCveActivo.Name = "tbResultCveActivo";
            this.tbResultCveActivo.ReadOnly = true;
            this.tbResultCveActivo.Size = new System.Drawing.Size(110, 30);
            this.tbResultCveActivo.TabIndex = 28;
            this.tbResultCveActivo.Text = "000000";
            this.tbResultCveActivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbResultNumEtiqueta
            // 
            this.tbResultNumEtiqueta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbResultNumEtiqueta.Location = new System.Drawing.Point(281, 566);
            this.tbResultNumEtiqueta.Name = "tbResultNumEtiqueta";
            this.tbResultNumEtiqueta.ReadOnly = true;
            this.tbResultNumEtiqueta.Size = new System.Drawing.Size(146, 30);
            this.tbResultNumEtiqueta.TabIndex = 27;
            this.tbResultNumEtiqueta.Text = "0000000000000";
            this.tbResultNumEtiqueta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbResultDesc
            // 
            this.tbResultDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbResultDesc.Location = new System.Drawing.Point(174, 526);
            this.tbResultDesc.Name = "tbResultDesc";
            this.tbResultDesc.ReadOnly = true;
            this.tbResultDesc.Size = new System.Drawing.Size(535, 30);
            this.tbResultDesc.TabIndex = 26;
            // 
            // tbResultNombre
            // 
            this.tbResultNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbResultNombre.Location = new System.Drawing.Point(174, 490);
            this.tbResultNombre.Name = "tbResultNombre";
            this.tbResultNombre.ReadOnly = true;
            this.tbResultNombre.Size = new System.Drawing.Size(535, 30);
            this.tbResultNombre.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 569);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Núm. Etiqueta:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 569);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cve. Activo:";
            // 
            // label100
            // 
            this.label100.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(92, 529);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(63, 23);
            this.label100.TabIndex = 22;
            this.label100.Text = "Desc.:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre:";
            // 
            // btnImprEtiquetas
            // 
            this.btnImprEtiquetas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnImprEtiquetas.Location = new System.Drawing.Point(299, 620);
            this.btnImprEtiquetas.Name = "btnImprEtiquetas";
            this.btnImprEtiquetas.Size = new System.Drawing.Size(203, 43);
            this.btnImprEtiquetas.TabIndex = 29;
            this.btnImprEtiquetas.Text = "Imprimir Etiquetas";
            this.btnImprEtiquetas.UseVisualStyleBackColor = true;
            this.btnImprEtiquetas.Click += new System.EventHandler(this.btnImprEtiquetas_Click);
            // 
            // gbPTN
            // 
            this.gbPTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbPTN.Controls.Add(this.label1);
            this.gbPTN.Controls.Add(this.label3);
            this.gbPTN.Controls.Add(this.label6);
            this.gbPTN.Controls.Add(this.cmbArea);
            this.gbPTN.Controls.Add(this.cmbSucursal);
            this.gbPTN.Controls.Add(this.btnBuscarPTN);
            this.gbPTN.Controls.Add(this.tbNombre);
            this.gbPTN.Controls.Add(this.label7);
            this.gbPTN.Controls.Add(this.cmbTipo);
            this.gbPTN.Location = new System.Drawing.Point(12, 12);
            this.gbPTN.Name = "gbPTN";
            this.gbPTN.Size = new System.Drawing.Size(536, 313);
            this.gbPTN.TabIndex = 30;
            this.gbPTN.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sucursal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Área";
            // 
            // cmbArea
            // 
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.DropDownWidth = 400;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(20, 112);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(493, 31);
            this.cmbArea.TabIndex = 5;
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.DropDownWidth = 400;
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(20, 52);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(493, 31);
            this.cmbSucursal.TabIndex = 4;
            this.cmbSucursal.SelectionChangeCommitted += new System.EventHandler(this.cmbSucursal_SelectionChangeCommitted);
            // 
            // btnBuscarPTN
            // 
            this.btnBuscarPTN.Location = new System.Drawing.Point(171, 268);
            this.btnBuscarPTN.Name = "btnBuscarPTN";
            this.btnBuscarPTN.Size = new System.Drawing.Size(163, 34);
            this.btnBuscarPTN.TabIndex = 3;
            this.btnBuscarPTN.Text = "Buscar";
            this.btnBuscarPTN.UseVisualStyleBackColor = true;
            this.btnBuscarPTN.Click += new System.EventHandler(this.btnBuscarPTN_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(20, 232);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(493, 30);
            this.tbNombre.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tipo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.DropDownWidth = 400;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(20, 172);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(493, 31);
            this.cmbTipo.TabIndex = 0;
            // 
            // rbPTN
            // 
            this.rbPTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbPTN.AutoSize = true;
            this.rbPTN.BackColor = System.Drawing.Color.Transparent;
            this.rbPTN.ForeColor = System.Drawing.Color.Black;
            this.rbPTN.Location = new System.Drawing.Point(794, 154);
            this.rbPTN.Name = "rbPTN";
            this.rbPTN.Size = new System.Drawing.Size(128, 27);
            this.rbPTN.TabIndex = 31;
            this.rbPTN.Text = "Por Nombre";
            this.rbPTN.UseVisualStyleBackColor = false;
            this.rbPTN.CheckedChanged += new System.EventHandler(this.rbPTN_CheckedChanged);
            // 
            // gcResulBusquedas
            // 
            this.gcResulBusquedas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gcResulBusquedas.DataSource = this.activosDescBindingSource;
            this.gcResulBusquedas.Location = new System.Drawing.Point(12, 331);
            this.gcResulBusquedas.MainView = this.gridView1;
            this.gcResulBusquedas.Name = "gcResulBusquedas";
            this.gcResulBusquedas.Size = new System.Drawing.Size(776, 153);
            this.gcResulBusquedas.TabIndex = 32;
            this.gcResulBusquedas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcResulBusquedas.DoubleClick += new System.EventHandler(this.gcResulBusquedas_DoubleClick);
            // 
            // activosDescBindingSource
            // 
            this.activosDescBindingSource.DataSource = typeof(Modelos.ActivosDesc);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.gridView1.GridControl = this.gcResulBusquedas;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Activos";
            // 
            // colseleccionado
            // 
            this.colseleccionado.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colseleccionado.AppearanceCell.Options.UseBackColor = true;
            this.colseleccionado.Caption = " ";
            this.colseleccionado.FieldName = "seleccionado";
            this.colseleccionado.Name = "colseleccionado";
            this.colseleccionado.Width = 38;
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
            this.colarea.Width = 170;
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
            this.coltipo.Width = 170;
            // 
            // colnombreCorto
            // 
            this.colnombreCorto.Caption = "Nombre Activo";
            this.colnombreCorto.FieldName = "nombreCorto";
            this.colnombreCorto.Name = "colnombreCorto";
            this.colnombreCorto.OptionsColumn.AllowEdit = false;
            this.colnombreCorto.OptionsColumn.AllowMove = false;
            this.colnombreCorto.OptionsColumn.ReadOnly = true;
            this.colnombreCorto.Visible = true;
            this.colnombreCorto.VisibleIndex = 2;
            this.colnombreCorto.Width = 150;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripción";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.OptionsColumn.AllowMove = false;
            this.coldescripcion.OptionsColumn.ReadOnly = true;
            this.coldescripcion.Width = 200;
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
            this.colclaveActivo.Caption = "Cve. Activo";
            this.colclaveActivo.FieldName = "claveActivo";
            this.colclaveActivo.Name = "colclaveActivo";
            this.colclaveActivo.OptionsColumn.AllowEdit = false;
            this.colclaveActivo.OptionsColumn.AllowMove = false;
            this.colclaveActivo.OptionsColumn.ReadOnly = true;
            this.colclaveActivo.Visible = true;
            this.colclaveActivo.VisibleIndex = 4;
            this.colclaveActivo.Width = 70;
            // 
            // colstatus
            // 
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            // 
            // frmReimpresionEtiquetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 675);
            this.Controls.Add(this.gcResulBusquedas);
            this.Controls.Add(this.rbPCA);
            this.Controls.Add(this.rbPNE);
            this.Controls.Add(this.rbPTN);
            this.Controls.Add(this.gbPTN);
            this.Controls.Add(this.btnImprEtiquetas);
            this.Controls.Add(this.tbResultCveActivo);
            this.Controls.Add(this.tbResultNumEtiqueta);
            this.Controls.Add(this.tbResultDesc);
            this.Controls.Add(this.tbResultNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbPNE);
            this.Controls.Add(this.gbPCA);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmReimpresionEtiquetas";
            this.Text = "Reimpresion Etiquetas";
            this.Load += new System.EventHandler(this.frmReimpresionEtiquetas_Load);
            this.gbPNE.ResumeLayout(false);
            this.gbPNE.PerformLayout();
            this.gbPCA.ResumeLayout(false);
            this.gbPCA.PerformLayout();
            this.gbPTN.ResumeLayout(false);
            this.gbPTN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcResulBusquedas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosDescBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPNE;
        private System.Windows.Forms.TextBox tbNumEtiqueta;
        private System.Windows.Forms.Button btnBuscarPNE;
        private System.Windows.Forms.GroupBox gbPCA;
        private System.Windows.Forms.TextBox tbCveActivo;
        private System.Windows.Forms.Button btnBuscarPCA;
        private System.Windows.Forms.RadioButton rbPCA;
        private System.Windows.Forms.RadioButton rbPNE;
        private System.Windows.Forms.TextBox tbResultCveActivo;
        private System.Windows.Forms.TextBox tbResultNumEtiqueta;
        private System.Windows.Forms.TextBox tbResultDesc;
        private System.Windows.Forms.TextBox tbResultNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImprEtiquetas;
        private System.Windows.Forms.GroupBox gbPTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Button btnBuscarPTN;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.RadioButton rbPTN;
        private DevExpress.XtraGrid.GridControl gcResulBusquedas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
        private System.Windows.Forms.BindingSource activosDescBindingSource;
    }
}