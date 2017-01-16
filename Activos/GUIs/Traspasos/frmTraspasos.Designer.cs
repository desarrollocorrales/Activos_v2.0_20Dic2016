namespace Activos.GUIs.Traspasos
{
    partial class frmTraspasos
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
            this.tbPuesto = new System.Windows.Forms.TextBox();
            this.tbSucursal = new System.Windows.Forms.TextBox();
            this.tbResponsable = new System.Windows.Forms.TextBox();
            this.gcActivos = new DevExpress.XtraGrid.GridControl();
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
            this.colAccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscaResponsiva = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPuestoT = new System.Windows.Forms.TextBox();
            this.tbSucursalT = new System.Windows.Forms.TextBox();
            this.tbResponsableT = new System.Windows.Forms.TextBox();
            this.gcActivosT = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colseleccionado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidActivo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidArea1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colarea1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidTipo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombreCorto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaAlta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUsuarioAlta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaModificacion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUsuarioModifica1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcosto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumEtiqueta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colclaveActivo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscaUsuario = new System.Windows.Forms.Button();
            this.btnGuardaCambios = new System.Windows.Forms.Button();
            this.btnAgrega = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcActivosT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPuesto
            // 
            this.tbPuesto.Location = new System.Drawing.Point(133, 95);
            this.tbPuesto.Name = "tbPuesto";
            this.tbPuesto.ReadOnly = true;
            this.tbPuesto.Size = new System.Drawing.Size(363, 30);
            this.tbPuesto.TabIndex = 21;
            // 
            // tbSucursal
            // 
            this.tbSucursal.Location = new System.Drawing.Point(133, 54);
            this.tbSucursal.Name = "tbSucursal";
            this.tbSucursal.ReadOnly = true;
            this.tbSucursal.Size = new System.Drawing.Size(363, 30);
            this.tbSucursal.TabIndex = 20;
            // 
            // tbResponsable
            // 
            this.tbResponsable.Location = new System.Drawing.Point(133, 13);
            this.tbResponsable.Name = "tbResponsable";
            this.tbResponsable.ReadOnly = true;
            this.tbResponsable.Size = new System.Drawing.Size(363, 30);
            this.tbResponsable.TabIndex = 19;
            // 
            // gcActivos
            // 
            this.gcActivos.DataSource = this.activosBindingSource;
            this.gcActivos.Location = new System.Drawing.Point(12, 142);
            this.gcActivos.MainView = this.gridView1;
            this.gcActivos.Name = "gcActivos";
            this.gcActivos.Size = new System.Drawing.Size(705, 202);
            this.gcActivos.TabIndex = 18;
            this.gcActivos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.colAccion,
            this.colstatus});
            this.gridView1.GridControl = this.gcActivos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Activos";
            // 
            // colseleccionado
            // 
            this.colseleccionado.Caption = " ";
            this.colseleccionado.FieldName = "seleccionado";
            this.colseleccionado.Name = "colseleccionado";
            this.colseleccionado.Width = 30;
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
            this.colarea.Width = 85;
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
            this.coltipo.Width = 85;
            // 
            // colnombreCorto
            // 
            this.colnombreCorto.FieldName = "nombreCorto";
            this.colnombreCorto.Name = "colnombreCorto";
            this.colnombreCorto.OptionsColumn.AllowEdit = false;
            this.colnombreCorto.OptionsColumn.AllowMove = false;
            this.colnombreCorto.OptionsColumn.ReadOnly = true;
            this.colnombreCorto.Visible = true;
            this.colnombreCorto.VisibleIndex = 2;
            this.colnombreCorto.Width = 85;
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
            this.colnumEtiqueta.Width = 85;
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
            this.colclaveActivo.Width = 85;
            // 
            // colAccion
            // 
            this.colAccion.Caption = "Acción";
            this.colAccion.FieldName = "accion";
            this.colAccion.Name = "colAccion";
            this.colAccion.OptionsColumn.AllowEdit = false;
            this.colAccion.OptionsColumn.AllowMove = false;
            this.colAccion.OptionsColumn.ReadOnly = true;
            this.colAccion.Visible = true;
            this.colAccion.VisibleIndex = 6;
            this.colAccion.Width = 85;
            // 
            // colstatus
            // 
            this.colstatus.Caption = "Estatus";
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            this.colstatus.OptionsColumn.AllowEdit = false;
            this.colstatus.OptionsColumn.AllowMove = false;
            this.colstatus.OptionsColumn.ReadOnly = true;
            this.colstatus.Visible = true;
            this.colstatus.VisibleIndex = 5;
            this.colstatus.Width = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Puesto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Sucursal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Responsable";
            // 
            // btnBuscaResponsiva
            // 
            this.btnBuscaResponsiva.Location = new System.Drawing.Point(523, 48);
            this.btnBuscaResponsiva.Name = "btnBuscaResponsiva";
            this.btnBuscaResponsiva.Size = new System.Drawing.Size(198, 43);
            this.btnBuscaResponsiva.TabIndex = 14;
            this.btnBuscaResponsiva.Text = "Buscar Responsiva";
            this.btnBuscaResponsiva.UseVisualStyleBackColor = true;
            this.btnBuscaResponsiva.Click += new System.EventHandler(this.btnBuscaResponsiva_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPuestoT);
            this.groupBox1.Controls.Add(this.tbSucursalT);
            this.groupBox1.Controls.Add(this.tbResponsableT);
            this.groupBox1.Controls.Add(this.gcActivosT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnBuscaUsuario);
            this.groupBox1.Location = new System.Drawing.Point(12, 412);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 391);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Responsiva Traspaso";
            // 
            // tbPuestoT
            // 
            this.tbPuestoT.Location = new System.Drawing.Point(135, 122);
            this.tbPuestoT.Name = "tbPuestoT";
            this.tbPuestoT.ReadOnly = true;
            this.tbPuestoT.Size = new System.Drawing.Size(349, 30);
            this.tbPuestoT.TabIndex = 29;
            // 
            // tbSucursalT
            // 
            this.tbSucursalT.Location = new System.Drawing.Point(135, 81);
            this.tbSucursalT.Name = "tbSucursalT";
            this.tbSucursalT.ReadOnly = true;
            this.tbSucursalT.Size = new System.Drawing.Size(349, 30);
            this.tbSucursalT.TabIndex = 28;
            // 
            // tbResponsableT
            // 
            this.tbResponsableT.Location = new System.Drawing.Point(135, 40);
            this.tbResponsableT.Name = "tbResponsableT";
            this.tbResponsableT.ReadOnly = true;
            this.tbResponsableT.Size = new System.Drawing.Size(349, 30);
            this.tbResponsableT.TabIndex = 27;
            // 
            // gcActivosT
            // 
            this.gcActivosT.DataSource = this.activosBindingSource;
            this.gcActivosT.Location = new System.Drawing.Point(14, 169);
            this.gcActivosT.MainView = this.gridView2;
            this.gcActivosT.Name = "gcActivosT";
            this.gcActivosT.Size = new System.Drawing.Size(674, 202);
            this.gcActivosT.TabIndex = 26;
            this.gcActivosT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colseleccionado1,
            this.colidActivo1,
            this.colidArea1,
            this.colarea1,
            this.colidTipo1,
            this.coltipo1,
            this.colnombreCorto1,
            this.coldescripcion1,
            this.colfechaAlta1,
            this.colidUsuarioAlta1,
            this.colfechaModificacion1,
            this.colidUsuarioModifica1,
            this.colcosto1,
            this.colnumEtiqueta1,
            this.colclaveActivo1,
            this.colstatus1});
            this.gridView2.GridControl = this.gcActivosT;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowViewCaption = true;
            this.gridView2.ViewCaption = "Activos";
            // 
            // colseleccionado1
            // 
            this.colseleccionado1.FieldName = "seleccionado";
            this.colseleccionado1.Name = "colseleccionado1";
            this.colseleccionado1.OptionsColumn.AllowEdit = false;
            this.colseleccionado1.OptionsColumn.AllowMove = false;
            this.colseleccionado1.OptionsColumn.ReadOnly = true;
            // 
            // colidActivo1
            // 
            this.colidActivo1.FieldName = "idActivo";
            this.colidActivo1.Name = "colidActivo1";
            this.colidActivo1.OptionsColumn.AllowEdit = false;
            this.colidActivo1.OptionsColumn.AllowMove = false;
            this.colidActivo1.OptionsColumn.ReadOnly = true;
            // 
            // colidArea1
            // 
            this.colidArea1.FieldName = "idArea";
            this.colidArea1.Name = "colidArea1";
            this.colidArea1.OptionsColumn.AllowEdit = false;
            this.colidArea1.OptionsColumn.AllowMove = false;
            this.colidArea1.OptionsColumn.ReadOnly = true;
            // 
            // colarea1
            // 
            this.colarea1.Caption = "Área";
            this.colarea1.FieldName = "area";
            this.colarea1.Name = "colarea1";
            this.colarea1.Visible = true;
            this.colarea1.VisibleIndex = 0;
            // 
            // colidTipo1
            // 
            this.colidTipo1.FieldName = "idTipo";
            this.colidTipo1.Name = "colidTipo1";
            this.colidTipo1.OptionsColumn.AllowEdit = false;
            this.colidTipo1.OptionsColumn.AllowMove = false;
            this.colidTipo1.OptionsColumn.ReadOnly = true;
            // 
            // coltipo1
            // 
            this.coltipo1.Caption = "Tipo";
            this.coltipo1.FieldName = "tipo";
            this.coltipo1.Name = "coltipo1";
            this.coltipo1.Visible = true;
            this.coltipo1.VisibleIndex = 1;
            // 
            // colnombreCorto1
            // 
            this.colnombreCorto1.Caption = "Activo";
            this.colnombreCorto1.FieldName = "nombreCorto";
            this.colnombreCorto1.Name = "colnombreCorto1";
            this.colnombreCorto1.Visible = true;
            this.colnombreCorto1.VisibleIndex = 2;
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.OptionsColumn.AllowEdit = false;
            this.coldescripcion1.OptionsColumn.AllowMove = false;
            this.coldescripcion1.OptionsColumn.ReadOnly = true;
            // 
            // colfechaAlta1
            // 
            this.colfechaAlta1.FieldName = "fechaAlta";
            this.colfechaAlta1.Name = "colfechaAlta1";
            this.colfechaAlta1.OptionsColumn.AllowEdit = false;
            this.colfechaAlta1.OptionsColumn.AllowMove = false;
            this.colfechaAlta1.OptionsColumn.ReadOnly = true;
            // 
            // colidUsuarioAlta1
            // 
            this.colidUsuarioAlta1.FieldName = "idUsuarioAlta";
            this.colidUsuarioAlta1.Name = "colidUsuarioAlta1";
            this.colidUsuarioAlta1.OptionsColumn.AllowEdit = false;
            this.colidUsuarioAlta1.OptionsColumn.AllowMove = false;
            this.colidUsuarioAlta1.OptionsColumn.ReadOnly = true;
            // 
            // colfechaModificacion1
            // 
            this.colfechaModificacion1.FieldName = "fechaModificacion";
            this.colfechaModificacion1.Name = "colfechaModificacion1";
            this.colfechaModificacion1.OptionsColumn.AllowEdit = false;
            this.colfechaModificacion1.OptionsColumn.AllowMove = false;
            this.colfechaModificacion1.OptionsColumn.ReadOnly = true;
            // 
            // colidUsuarioModifica1
            // 
            this.colidUsuarioModifica1.FieldName = "idUsuarioModifica";
            this.colidUsuarioModifica1.Name = "colidUsuarioModifica1";
            this.colidUsuarioModifica1.OptionsColumn.AllowEdit = false;
            this.colidUsuarioModifica1.OptionsColumn.AllowMove = false;
            this.colidUsuarioModifica1.OptionsColumn.ReadOnly = true;
            // 
            // colcosto1
            // 
            this.colcosto1.FieldName = "costo";
            this.colcosto1.Name = "colcosto1";
            this.colcosto1.OptionsColumn.AllowEdit = false;
            this.colcosto1.OptionsColumn.AllowMove = false;
            this.colcosto1.OptionsColumn.ReadOnly = true;
            // 
            // colnumEtiqueta1
            // 
            this.colnumEtiqueta1.Caption = "Núm. Etiqueta";
            this.colnumEtiqueta1.FieldName = "numEtiqueta";
            this.colnumEtiqueta1.Name = "colnumEtiqueta1";
            this.colnumEtiqueta1.Visible = true;
            this.colnumEtiqueta1.VisibleIndex = 3;
            // 
            // colclaveActivo1
            // 
            this.colclaveActivo1.Caption = "Cve. Activo";
            this.colclaveActivo1.FieldName = "claveActivo";
            this.colclaveActivo1.Name = "colclaveActivo1";
            this.colclaveActivo1.Visible = true;
            this.colclaveActivo1.VisibleIndex = 4;
            // 
            // colstatus1
            // 
            this.colstatus1.FieldName = "status";
            this.colstatus1.Name = "colstatus1";
            this.colstatus1.OptionsColumn.AllowEdit = false;
            this.colstatus1.OptionsColumn.AllowMove = false;
            this.colstatus1.OptionsColumn.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Puesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Sucursal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Responsable";
            // 
            // btnBuscaUsuario
            // 
            this.btnBuscaUsuario.Location = new System.Drawing.Point(525, 75);
            this.btnBuscaUsuario.Name = "btnBuscaUsuario";
            this.btnBuscaUsuario.Size = new System.Drawing.Size(163, 43);
            this.btnBuscaUsuario.TabIndex = 22;
            this.btnBuscaUsuario.Text = "Buscar Usuario";
            this.btnBuscaUsuario.UseVisualStyleBackColor = true;
            this.btnBuscaUsuario.Click += new System.EventHandler(this.btnBuscaUsuario_Click);
            // 
            // btnGuardaCambios
            // 
            this.btnGuardaCambios.Location = new System.Drawing.Point(251, 820);
            this.btnGuardaCambios.Name = "btnGuardaCambios";
            this.btnGuardaCambios.Size = new System.Drawing.Size(210, 52);
            this.btnGuardaCambios.TabIndex = 23;
            this.btnGuardaCambios.Text = "Guardar Cambios";
            this.btnGuardaCambios.UseVisualStyleBackColor = true;
            this.btnGuardaCambios.Click += new System.EventHandler(this.btnGuardaCambios_Click);
            // 
            // btnAgrega
            // 
            this.btnAgrega.Location = new System.Drawing.Point(226, 362);
            this.btnAgrega.Name = "btnAgrega";
            this.btnAgrega.Size = new System.Drawing.Size(102, 34);
            this.btnAgrega.TabIndex = 24;
            this.btnAgrega.Text = "Agregar";
            this.btnAgrega.UseVisualStyleBackColor = true;
            this.btnAgrega.Click += new System.EventHandler(this.btnAgrega_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(415, 362);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(102, 34);
            this.btnQuitar.TabIndex = 25;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(479, 820);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(210, 52);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmTraspasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 891);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgrega);
            this.Controls.Add(this.btnGuardaCambios);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbPuesto);
            this.Controls.Add(this.tbSucursal);
            this.Controls.Add(this.tbResponsable);
            this.Controls.Add(this.gcActivos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscaResponsiva);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmTraspasos";
            this.Text = "Traspasos";
            ((System.ComponentModel.ISupportInitialize)(this.gcActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcActivosT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPuesto;
        private System.Windows.Forms.TextBox tbSucursal;
        private System.Windows.Forms.TextBox tbResponsable;
        private DevExpress.XtraGrid.GridControl gcActivos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscaResponsiva;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPuestoT;
        private System.Windows.Forms.TextBox tbSucursalT;
        private System.Windows.Forms.TextBox tbResponsableT;
        private DevExpress.XtraGrid.GridControl gcActivosT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscaUsuario;
        private System.Windows.Forms.Button btnGuardaCambios;
        private System.Windows.Forms.Button btnAgrega;
        private System.Windows.Forms.Button btnQuitar;
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
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionado1;
        private DevExpress.XtraGrid.Columns.GridColumn colidActivo1;
        private DevExpress.XtraGrid.Columns.GridColumn colidArea1;
        private DevExpress.XtraGrid.Columns.GridColumn colarea1;
        private DevExpress.XtraGrid.Columns.GridColumn colidTipo1;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo1;
        private DevExpress.XtraGrid.Columns.GridColumn colnombreCorto1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaAlta1;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuarioAlta1;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaModificacion1;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuarioModifica1;
        private DevExpress.XtraGrid.Columns.GridColumn colcosto1;
        private DevExpress.XtraGrid.Columns.GridColumn colnumEtiqueta1;
        private DevExpress.XtraGrid.Columns.GridColumn colclaveActivo1;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus1;
        private DevExpress.XtraGrid.Columns.GridColumn colAccion;
        private System.Windows.Forms.Button btnCancelar;
    }
}