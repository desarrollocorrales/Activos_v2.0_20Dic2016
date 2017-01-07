namespace Activos.GUIs.Responsivas
{
    partial class frmBuscaActivos
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
            this.gbPTN = new System.Windows.Forms.GroupBox();
            this.btnBuscarPTN = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.rbPTN = new System.Windows.Forms.RadioButton();
            this.gbPNE = new System.Windows.Forms.GroupBox();
            this.tbNumEtiqueta = new System.Windows.Forms.TextBox();
            this.btnBuscarPNE = new System.Windows.Forms.Button();
            this.rbPNE = new System.Windows.Forms.RadioButton();
            this.gbPCA = new System.Windows.Forms.GroupBox();
            this.tbCveActivo = new System.Windows.Forms.TextBox();
            this.btnBuscarPCA = new System.Windows.Forms.Button();
            this.rbPCA = new System.Windows.Forms.RadioButton();
            this.gcResulBusquedas = new DevExpress.XtraGrid.GridControl();
            this.activosBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.btnAgrega = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnQuitarTodos = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gcSeleccionados = new DevExpress.XtraGrid.GridControl();
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
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbPTN.SuspendLayout();
            this.gbPNE.SuspendLayout();
            this.gbPCA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcResulBusquedas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPTN
            // 
            this.gbPTN.Controls.Add(this.btnBuscarPTN);
            this.gbPTN.Controls.Add(this.tbNombre);
            this.gbPTN.Controls.Add(this.label1);
            this.gbPTN.Controls.Add(this.cmbTipo);
            this.gbPTN.Location = new System.Drawing.Point(12, 12);
            this.gbPTN.Name = "gbPTN";
            this.gbPTN.Size = new System.Drawing.Size(364, 185);
            this.gbPTN.TabIndex = 0;
            this.gbPTN.TabStop = false;
            // 
            // btnBuscarPTN
            // 
            this.btnBuscarPTN.Location = new System.Drawing.Point(101, 134);
            this.btnBuscarPTN.Name = "btnBuscarPTN";
            this.btnBuscarPTN.Size = new System.Drawing.Size(163, 34);
            this.btnBuscarPTN.TabIndex = 3;
            this.btnBuscarPTN.Text = "Buscar";
            this.btnBuscarPTN.UseVisualStyleBackColor = true;
            this.btnBuscarPTN.Click += new System.EventHandler(this.btnBuscarPTN_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(20, 89);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(331, 30);
            this.tbNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(20, 29);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(331, 31);
            this.cmbTipo.TabIndex = 0;
            // 
            // rbPTN
            // 
            this.rbPTN.AutoSize = true;
            this.rbPTN.Location = new System.Drawing.Point(14, 353);
            this.rbPTN.Name = "rbPTN";
            this.rbPTN.Size = new System.Drawing.Size(183, 27);
            this.rbPTN.TabIndex = 1;
            this.rbPTN.Text = "Por Tipo - Nombre";
            this.rbPTN.UseVisualStyleBackColor = true;
            this.rbPTN.CheckedChanged += new System.EventHandler(this.rbPTN_CheckedChanged);
            // 
            // gbPNE
            // 
            this.gbPNE.Controls.Add(this.tbNumEtiqueta);
            this.gbPNE.Controls.Add(this.btnBuscarPNE);
            this.gbPNE.Location = new System.Drawing.Point(382, 12);
            this.gbPNE.Name = "gbPNE";
            this.gbPNE.Size = new System.Drawing.Size(269, 185);
            this.gbPNE.TabIndex = 0;
            this.gbPNE.TabStop = false;
            // 
            // tbNumEtiqueta
            // 
            this.tbNumEtiqueta.Location = new System.Drawing.Point(20, 51);
            this.tbNumEtiqueta.Name = "tbNumEtiqueta";
            this.tbNumEtiqueta.Size = new System.Drawing.Size(231, 30);
            this.tbNumEtiqueta.TabIndex = 5;
            // 
            // btnBuscarPNE
            // 
            this.btnBuscarPNE.Location = new System.Drawing.Point(58, 99);
            this.btnBuscarPNE.Name = "btnBuscarPNE";
            this.btnBuscarPNE.Size = new System.Drawing.Size(163, 34);
            this.btnBuscarPNE.TabIndex = 4;
            this.btnBuscarPNE.Text = "Buscar";
            this.btnBuscarPNE.UseVisualStyleBackColor = true;
            this.btnBuscarPNE.Click += new System.EventHandler(this.btnBuscarPNE_Click);
            // 
            // rbPNE
            // 
            this.rbPNE.AutoSize = true;
            this.rbPNE.Location = new System.Drawing.Point(14, 374);
            this.rbPNE.Name = "rbPNE";
            this.rbPNE.Size = new System.Drawing.Size(182, 27);
            this.rbPNE.TabIndex = 2;
            this.rbPNE.Text = "Por Núm. Etiqueta";
            this.rbPNE.UseVisualStyleBackColor = true;
            this.rbPNE.CheckedChanged += new System.EventHandler(this.rbPNE_CheckedChanged);
            // 
            // gbPCA
            // 
            this.gbPCA.Controls.Add(this.tbCveActivo);
            this.gbPCA.Controls.Add(this.btnBuscarPCA);
            this.gbPCA.Location = new System.Drawing.Point(657, 12);
            this.gbPCA.Name = "gbPCA";
            this.gbPCA.Size = new System.Drawing.Size(266, 185);
            this.gbPCA.TabIndex = 0;
            this.gbPCA.TabStop = false;
            // 
            // tbCveActivo
            // 
            this.tbCveActivo.Location = new System.Drawing.Point(16, 51);
            this.tbCveActivo.Name = "tbCveActivo";
            this.tbCveActivo.Size = new System.Drawing.Size(231, 30);
            this.tbCveActivo.TabIndex = 6;
            // 
            // btnBuscarPCA
            // 
            this.btnBuscarPCA.Location = new System.Drawing.Point(48, 99);
            this.btnBuscarPCA.Name = "btnBuscarPCA";
            this.btnBuscarPCA.Size = new System.Drawing.Size(163, 34);
            this.btnBuscarPCA.TabIndex = 5;
            this.btnBuscarPCA.Text = "Buscar";
            this.btnBuscarPCA.UseVisualStyleBackColor = true;
            this.btnBuscarPCA.Click += new System.EventHandler(this.btnBuscarPCA_Click);
            // 
            // rbPCA
            // 
            this.rbPCA.AutoSize = true;
            this.rbPCA.Location = new System.Drawing.Point(14, 395);
            this.rbPCA.Name = "rbPCA";
            this.rbPCA.Size = new System.Drawing.Size(160, 27);
            this.rbPCA.TabIndex = 3;
            this.rbPCA.Text = "Por Clave Activo";
            this.rbPCA.UseVisualStyleBackColor = true;
            this.rbPCA.CheckedChanged += new System.EventHandler(this.rbPCA_CheckedChanged);
            // 
            // gcResulBusquedas
            // 
            this.gcResulBusquedas.DataSource = this.activosBindingSource;
            this.gcResulBusquedas.Location = new System.Drawing.Point(12, 203);
            this.gcResulBusquedas.MainView = this.gridView1;
            this.gcResulBusquedas.Name = "gcResulBusquedas";
            this.gcResulBusquedas.Size = new System.Drawing.Size(911, 153);
            this.gcResulBusquedas.TabIndex = 1;
            this.gcResulBusquedas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // activosBindingSource
            // 
            this.activosBindingSource.DataSource = typeof(Activos.Modelos.Activos);
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
            // 
            // colseleccionado
            // 
            this.colseleccionado.Caption = " ";
            this.colseleccionado.FieldName = "seleccionado";
            this.colseleccionado.Name = "colseleccionado";
            this.colseleccionado.Visible = true;
            this.colseleccionado.VisibleIndex = 0;
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
            this.colarea.VisibleIndex = 1;
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
            this.coltipo.VisibleIndex = 2;
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
            this.colnombreCorto.VisibleIndex = 3;
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
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 4;
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
            this.colnumEtiqueta.VisibleIndex = 5;
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
            this.colclaveActivo.VisibleIndex = 6;
            this.colclaveActivo.Width = 70;
            // 
            // colstatus
            // 
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            // 
            // btnAgrega
            // 
            this.btnAgrega.Location = new System.Drawing.Point(163, 374);
            this.btnAgrega.Name = "btnAgrega";
            this.btnAgrega.Size = new System.Drawing.Size(179, 41);
            this.btnAgrega.TabIndex = 2;
            this.btnAgrega.Text = "Agregar";
            this.btnAgrega.UseVisualStyleBackColor = true;
            this.btnAgrega.Click += new System.EventHandler(this.btnAgrega_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(378, 374);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(179, 41);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnQuitarTodos
            // 
            this.btnQuitarTodos.Location = new System.Drawing.Point(593, 374);
            this.btnQuitarTodos.Name = "btnQuitarTodos";
            this.btnQuitarTodos.Size = new System.Drawing.Size(179, 41);
            this.btnQuitarTodos.TabIndex = 4;
            this.btnQuitarTodos.Text = "Quitar Todos";
            this.btnQuitarTodos.UseVisualStyleBackColor = true;
            this.btnQuitarTodos.Click += new System.EventHandler(this.btnQuitarTodos_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(531, 602);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(179, 41);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(725, 602);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(179, 41);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gcSeleccionados
            // 
            this.gcSeleccionados.DataSource = this.activosBindingSource;
            this.gcSeleccionados.Location = new System.Drawing.Point(12, 428);
            this.gcSeleccionados.MainView = this.gridView2;
            this.gcSeleccionados.Name = "gcSeleccionados";
            this.gcSeleccionados.Size = new System.Drawing.Size(911, 156);
            this.gcSeleccionados.TabIndex = 8;
            this.gcSeleccionados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
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
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16});
            this.gridView2.GridControl = this.gcSeleccionados;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = " ";
            this.gridColumn1.FieldName = "seleccionado";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 38;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "idActivo";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "idArea";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Área";
            this.gridColumn4.FieldName = "area";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowMove = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 170;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "idTipo";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tipo";
            this.gridColumn6.FieldName = "tipo";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowMove = false;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 170;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Nombre Activo";
            this.gridColumn7.FieldName = "nombreCorto";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.AllowMove = false;
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            this.gridColumn7.Width = 150;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Descripción";
            this.gridColumn8.FieldName = "descripcion";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.OptionsColumn.AllowMove = false;
            this.gridColumn8.OptionsColumn.ReadOnly = true;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            this.gridColumn8.Width = 200;
            // 
            // gridColumn9
            // 
            this.gridColumn9.FieldName = "fechaAlta";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // gridColumn10
            // 
            this.gridColumn10.FieldName = "idUsuarioAlta";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // gridColumn11
            // 
            this.gridColumn11.FieldName = "fechaModificacion";
            this.gridColumn11.Name = "gridColumn11";
            // 
            // gridColumn12
            // 
            this.gridColumn12.FieldName = "idUsuarioModifica";
            this.gridColumn12.Name = "gridColumn12";
            // 
            // gridColumn13
            // 
            this.gridColumn13.FieldName = "costo";
            this.gridColumn13.Name = "gridColumn13";
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Núm. Etiqueta";
            this.gridColumn14.FieldName = "numEtiqueta";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.OptionsColumn.AllowMove = false;
            this.gridColumn14.OptionsColumn.ReadOnly = true;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 5;
            this.gridColumn14.Width = 90;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Cve. Activo";
            this.gridColumn15.FieldName = "claveActivo";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsColumn.AllowEdit = false;
            this.gridColumn15.OptionsColumn.AllowMove = false;
            this.gridColumn15.OptionsColumn.ReadOnly = true;
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 6;
            this.gridColumn15.Width = 70;
            // 
            // gridColumn16
            // 
            this.gridColumn16.FieldName = "status";
            this.gridColumn16.Name = "gridColumn16";
            // 
            // frmBuscaActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 658);
            this.Controls.Add(this.gcSeleccionados);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.rbPCA);
            this.Controls.Add(this.rbPNE);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.rbPTN);
            this.Controls.Add(this.btnQuitarTodos);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgrega);
            this.Controls.Add(this.gcResulBusquedas);
            this.Controls.Add(this.gbPNE);
            this.Controls.Add(this.gbPCA);
            this.Controls.Add(this.gbPTN);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmBuscaActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Activos";
            this.Load += new System.EventHandler(this.frmBuscaActivos_Load);
            this.gbPTN.ResumeLayout(false);
            this.gbPTN.PerformLayout();
            this.gbPNE.ResumeLayout(false);
            this.gbPNE.PerformLayout();
            this.gbPCA.ResumeLayout(false);
            this.gbPCA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcResulBusquedas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSeleccionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPTN;
        private System.Windows.Forms.Button btnBuscarPTN;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPTN;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.GroupBox gbPNE;
        private System.Windows.Forms.TextBox tbNumEtiqueta;
        private System.Windows.Forms.RadioButton rbPNE;
        private System.Windows.Forms.Button btnBuscarPNE;
        private System.Windows.Forms.GroupBox gbPCA;
        private System.Windows.Forms.TextBox tbCveActivo;
        private System.Windows.Forms.RadioButton rbPCA;
        private System.Windows.Forms.Button btnBuscarPCA;
        private DevExpress.XtraGrid.GridControl gcResulBusquedas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnAgrega;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnQuitarTodos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
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
        private DevExpress.XtraGrid.GridControl gcSeleccionados;
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
    }
}