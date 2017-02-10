namespace Activos.GUIs.AltaActivos
{
    partial class frmBuscActivos
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
            this.gbPN = new System.Windows.Forms.GroupBox();
            this.rbUsuarioPU = new System.Windows.Forms.RadioButton();
            this.rbNombrePU = new System.Windows.Forms.RadioButton();
            this.tbUsuarioPU = new System.Windows.Forms.TextBox();
            this.btnBuscarPU = new System.Windows.Forms.Button();
            this.rbPCA = new System.Windows.Forms.RadioButton();
            this.rbPNE = new System.Windows.Forms.RadioButton();
            this.rbPN = new System.Windows.Forms.RadioButton();
            this.rbPU = new System.Windows.Forms.RadioButton();
            this.gcResulBusquedas = new DevExpress.XtraGrid.GridControl();
            this.activosDescBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colarea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombreCorto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumEtiqueta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colclaveActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbResultNombre = new System.Windows.Forms.TextBox();
            this.tbResultDesc = new System.Windows.Forms.TextBox();
            this.tbResultNumEtiqueta = new System.Windows.Forms.TextBox();
            this.tbResultCveActivo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbPNE.SuspendLayout();
            this.gbPCA.SuspendLayout();
            this.gbPTN.SuspendLayout();
            this.gbPN.SuspendLayout();
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
            this.gbPNE.Location = new System.Drawing.Point(319, 286);
            this.gbPNE.Name = "gbPNE";
            this.gbPNE.Size = new System.Drawing.Size(234, 112);
            this.gbPNE.TabIndex = 3;
            this.gbPNE.TabStop = false;
            // 
            // tbNumEtiqueta
            // 
            this.tbNumEtiqueta.Location = new System.Drawing.Point(18, 29);
            this.tbNumEtiqueta.Name = "tbNumEtiqueta";
            this.tbNumEtiqueta.Size = new System.Drawing.Size(199, 30);
            this.tbNumEtiqueta.TabIndex = 5;
            this.tbNumEtiqueta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumEtiqueta_KeyPress);
            // 
            // btnBuscarPNE
            // 
            this.btnBuscarPNE.Location = new System.Drawing.Point(34, 65);
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
            this.gbPCA.Location = new System.Drawing.Point(319, 168);
            this.gbPCA.Name = "gbPCA";
            this.gbPCA.Size = new System.Drawing.Size(234, 112);
            this.gbPCA.TabIndex = 2;
            this.gbPCA.TabStop = false;
            // 
            // tbCveActivo
            // 
            this.tbCveActivo.Location = new System.Drawing.Point(18, 29);
            this.tbCveActivo.Name = "tbCveActivo";
            this.tbCveActivo.Size = new System.Drawing.Size(199, 30);
            this.tbCveActivo.TabIndex = 6;
            this.tbCveActivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCveActivo_KeyPress);
            // 
            // btnBuscarPCA
            // 
            this.btnBuscarPCA.Location = new System.Drawing.Point(34, 65);
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
            this.gbPTN.Location = new System.Drawing.Point(12, 12);
            this.gbPTN.Name = "gbPTN";
            this.gbPTN.Size = new System.Drawing.Size(301, 386);
            this.gbPTN.TabIndex = 1;
            this.gbPTN.TabStop = false;
            // 
            // cmbArea
            // 
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.DropDownWidth = 400;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(11, 126);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(279, 31);
            this.cmbArea.TabIndex = 8;
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.DropDownWidth = 400;
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(11, 52);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(279, 31);
            this.cmbSucursal.TabIndex = 7;
            this.cmbSucursal.SelectionChangeCommitted += new System.EventHandler(this.cmbSucursal_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Área";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sucursal";
            // 
            // btnBuscarPTN
            // 
            this.btnBuscarPTN.Location = new System.Drawing.Point(69, 329);
            this.btnBuscarPTN.Name = "btnBuscarPTN";
            this.btnBuscarPTN.Size = new System.Drawing.Size(163, 34);
            this.btnBuscarPTN.TabIndex = 3;
            this.btnBuscarPTN.Text = "Buscar";
            this.btnBuscarPTN.UseVisualStyleBackColor = true;
            this.btnBuscarPTN.Click += new System.EventHandler(this.btnBuscarPTN_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(11, 275);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(279, 30);
            this.tbNombre.TabIndex = 2;
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 249);
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
            this.cmbTipo.Location = new System.Drawing.Point(11, 200);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(279, 31);
            this.cmbTipo.TabIndex = 0;
            // 
            // gbPN
            // 
            this.gbPN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbPN.Controls.Add(this.rbUsuarioPU);
            this.gbPN.Controls.Add(this.rbNombrePU);
            this.gbPN.Controls.Add(this.tbUsuarioPU);
            this.gbPN.Controls.Add(this.btnBuscarPU);
            this.gbPN.Location = new System.Drawing.Point(319, 12);
            this.gbPN.Name = "gbPN";
            this.gbPN.Size = new System.Drawing.Size(234, 150);
            this.gbPN.TabIndex = 7;
            this.gbPN.TabStop = false;
            // 
            // rbUsuarioPU
            // 
            this.rbUsuarioPU.AutoSize = true;
            this.rbUsuarioPU.Location = new System.Drawing.Point(123, 66);
            this.rbUsuarioPU.Name = "rbUsuarioPU";
            this.rbUsuarioPU.Size = new System.Drawing.Size(90, 27);
            this.rbUsuarioPU.TabIndex = 8;
            this.rbUsuarioPU.Text = "Usuario";
            this.rbUsuarioPU.UseVisualStyleBackColor = true;
            // 
            // rbNombrePU
            // 
            this.rbNombrePU.AutoSize = true;
            this.rbNombrePU.Checked = true;
            this.rbNombrePU.Location = new System.Drawing.Point(22, 66);
            this.rbNombrePU.Name = "rbNombrePU";
            this.rbNombrePU.Size = new System.Drawing.Size(95, 27);
            this.rbNombrePU.TabIndex = 7;
            this.rbNombrePU.TabStop = true;
            this.rbNombrePU.Text = "Nombre";
            this.rbNombrePU.UseVisualStyleBackColor = true;
            // 
            // tbUsuarioPU
            // 
            this.tbUsuarioPU.Location = new System.Drawing.Point(18, 31);
            this.tbUsuarioPU.Name = "tbUsuarioPU";
            this.tbUsuarioPU.Size = new System.Drawing.Size(199, 30);
            this.tbUsuarioPU.TabIndex = 6;
            this.tbUsuarioPU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUsuarioPU_KeyPress);
            // 
            // btnBuscarPU
            // 
            this.btnBuscarPU.Location = new System.Drawing.Point(34, 102);
            this.btnBuscarPU.Name = "btnBuscarPU";
            this.btnBuscarPU.Size = new System.Drawing.Size(163, 34);
            this.btnBuscarPU.TabIndex = 5;
            this.btnBuscarPU.Text = "Buscar";
            this.btnBuscarPU.UseVisualStyleBackColor = true;
            this.btnBuscarPU.Click += new System.EventHandler(this.btnBuscarPU_Click);
            // 
            // rbPCA
            // 
            this.rbPCA.AutoSize = true;
            this.rbPCA.Location = new System.Drawing.Point(559, 64);
            this.rbPCA.Name = "rbPCA";
            this.rbPCA.Size = new System.Drawing.Size(160, 27);
            this.rbPCA.TabIndex = 10;
            this.rbPCA.Text = "Por Clave Activo";
            this.rbPCA.UseVisualStyleBackColor = true;
            this.rbPCA.CheckedChanged += new System.EventHandler(this.rbPCA_CheckedChanged);
            // 
            // rbPNE
            // 
            this.rbPNE.AutoSize = true;
            this.rbPNE.Location = new System.Drawing.Point(559, 43);
            this.rbPNE.Name = "rbPNE";
            this.rbPNE.Size = new System.Drawing.Size(182, 27);
            this.rbPNE.TabIndex = 9;
            this.rbPNE.Text = "Por Núm. Etiqueta";
            this.rbPNE.UseVisualStyleBackColor = true;
            this.rbPNE.CheckedChanged += new System.EventHandler(this.rbPNE_CheckedChanged);
            // 
            // rbPN
            // 
            this.rbPN.AutoSize = true;
            this.rbPN.Location = new System.Drawing.Point(559, 22);
            this.rbPN.Name = "rbPN";
            this.rbPN.Size = new System.Drawing.Size(128, 27);
            this.rbPN.TabIndex = 8;
            this.rbPN.Text = "Por Nombre";
            this.rbPN.UseVisualStyleBackColor = true;
            this.rbPN.CheckedChanged += new System.EventHandler(this.rbPTN_CheckedChanged);
            // 
            // rbPU
            // 
            this.rbPU.AutoSize = true;
            this.rbPU.Location = new System.Drawing.Point(559, 86);
            this.rbPU.Name = "rbPU";
            this.rbPU.Size = new System.Drawing.Size(123, 27);
            this.rbPU.TabIndex = 11;
            this.rbPU.Text = "Por Usuario";
            this.rbPU.UseVisualStyleBackColor = true;
            this.rbPU.CheckedChanged += new System.EventHandler(this.rbPN_CheckedChanged);
            // 
            // gcResulBusquedas
            // 
            this.gcResulBusquedas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gcResulBusquedas.DataSource = this.activosDescBindingSource;
            this.gcResulBusquedas.Location = new System.Drawing.Point(12, 404);
            this.gcResulBusquedas.MainView = this.gridView1;
            this.gcResulBusquedas.Name = "gcResulBusquedas";
            this.gcResulBusquedas.Size = new System.Drawing.Size(541, 145);
            this.gcResulBusquedas.TabIndex = 12;
            this.gcResulBusquedas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcResulBusquedas.DoubleClick += new System.EventHandler(this.gcResulBusquedas_DoubleClick);
            // 
            // activosDescBindingSource
            // 
            this.activosDescBindingSource.DataSource = typeof(Activos.Modelos.ActivosDesc);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidActivo,
            this.colarea,
            this.coltipo,
            this.colnombreCorto,
            this.coldescripcion,
            this.colsucursal,
            this.colusuario,
            this.colcosto,
            this.colnumEtiqueta,
            this.colclaveActivo});
            this.gridView1.GridControl = this.gcResulBusquedas;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // colidActivo
            // 
            this.colidActivo.FieldName = "idActivo";
            this.colidActivo.Name = "colidActivo";
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
            // colsucursal
            // 
            this.colsucursal.FieldName = "sucursal";
            this.colsucursal.Name = "colsucursal";
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
            this.colusuario.VisibleIndex = 3;
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
            // 
            // colclaveActivo
            // 
            this.colclaveActivo.FieldName = "claveActivo";
            this.colclaveActivo.Name = "colclaveActivo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre:";
            // 
            // label100
            // 
            this.label100.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(13, 594);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(63, 23);
            this.label100.TabIndex = 14;
            this.label100.Text = "Desc.:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 634);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cve. Activo:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 634);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Núm. Etiqueta:";
            // 
            // tbResultNombre
            // 
            this.tbResultNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbResultNombre.Location = new System.Drawing.Point(95, 555);
            this.tbResultNombre.Name = "tbResultNombre";
            this.tbResultNombre.ReadOnly = true;
            this.tbResultNombre.Size = new System.Drawing.Size(444, 30);
            this.tbResultNombre.TabIndex = 17;
            // 
            // tbResultDesc
            // 
            this.tbResultDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbResultDesc.Location = new System.Drawing.Point(95, 591);
            this.tbResultDesc.Name = "tbResultDesc";
            this.tbResultDesc.ReadOnly = true;
            this.tbResultDesc.Size = new System.Drawing.Size(444, 30);
            this.tbResultDesc.TabIndex = 18;
            // 
            // tbResultNumEtiqueta
            // 
            this.tbResultNumEtiqueta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbResultNumEtiqueta.Location = new System.Drawing.Point(157, 631);
            this.tbResultNumEtiqueta.Name = "tbResultNumEtiqueta";
            this.tbResultNumEtiqueta.ReadOnly = true;
            this.tbResultNumEtiqueta.Size = new System.Drawing.Size(146, 30);
            this.tbResultNumEtiqueta.TabIndex = 19;
            this.tbResultNumEtiqueta.Text = "0000000000000";
            this.tbResultNumEtiqueta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbResultCveActivo
            // 
            this.tbResultCveActivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbResultCveActivo.Location = new System.Drawing.Point(430, 631);
            this.tbResultCveActivo.Name = "tbResultCveActivo";
            this.tbResultCveActivo.ReadOnly = true;
            this.tbResultCveActivo.Size = new System.Drawing.Size(110, 30);
            this.tbResultCveActivo.TabIndex = 20;
            this.tbResultCveActivo.Text = "000000";
            this.tbResultCveActivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Location = new System.Drawing.Point(385, 682);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(169, 44);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAceptar.Location = new System.Drawing.Point(210, 682);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(169, 44);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmBuscActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(568, 750);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tbResultCveActivo);
            this.Controls.Add(this.tbResultNumEtiqueta);
            this.Controls.Add(this.tbResultDesc);
            this.Controls.Add(this.tbResultNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gcResulBusquedas);
            this.Controls.Add(this.rbPU);
            this.Controls.Add(this.rbPCA);
            this.Controls.Add(this.rbPNE);
            this.Controls.Add(this.rbPN);
            this.Controls.Add(this.gbPN);
            this.Controls.Add(this.gbPNE);
            this.Controls.Add(this.gbPCA);
            this.Controls.Add(this.gbPTN);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmBuscActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Activos";
            this.Load += new System.EventHandler(this.frmBuscActivos_Load);
            this.gbPNE.ResumeLayout(false);
            this.gbPNE.PerformLayout();
            this.gbPCA.ResumeLayout(false);
            this.gbPCA.PerformLayout();
            this.gbPTN.ResumeLayout(false);
            this.gbPTN.PerformLayout();
            this.gbPN.ResumeLayout(false);
            this.gbPN.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbPTN;
        private System.Windows.Forms.Button btnBuscarPTN;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.GroupBox gbPN;
        private System.Windows.Forms.RadioButton rbUsuarioPU;
        private System.Windows.Forms.RadioButton rbNombrePU;
        private System.Windows.Forms.TextBox tbUsuarioPU;
        private System.Windows.Forms.Button btnBuscarPU;
        private System.Windows.Forms.RadioButton rbPCA;
        private System.Windows.Forms.RadioButton rbPNE;
        private System.Windows.Forms.RadioButton rbPN;
        private System.Windows.Forms.RadioButton rbPU;
        private DevExpress.XtraGrid.GridControl gcResulBusquedas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbResultNombre;
        private System.Windows.Forms.TextBox tbResultDesc;
        private System.Windows.Forms.TextBox tbResultNumEtiqueta;
        private System.Windows.Forms.TextBox tbResultCveActivo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.BindingSource activosDescBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidActivo;
        private DevExpress.XtraGrid.Columns.GridColumn colarea;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo;
        private DevExpress.XtraGrid.Columns.GridColumn colnombreCorto;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colsucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraGrid.Columns.GridColumn colcosto;
        private DevExpress.XtraGrid.Columns.GridColumn colnumEtiqueta;
        private DevExpress.XtraGrid.Columns.GridColumn colclaveActivo;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}