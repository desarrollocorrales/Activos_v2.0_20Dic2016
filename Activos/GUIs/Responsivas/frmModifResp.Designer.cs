namespace Activos.GUIs.Responsivas
{
    partial class frmModifResp
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
            this.btnBuscaResponsiva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgrega = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
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
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPrevMov = new DevExpress.XtraGrid.GridControl();
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
            this.tbResponsable = new System.Windows.Forms.TextBox();
            this.tbSucursal = new System.Windows.Forms.TextBox();
            this.tbPuesto = new System.Windows.Forms.TextBox();
            this.btnQuitarActivo = new System.Windows.Forms.Button();
            this.btnAplica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrevMov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscaResponsiva
            // 
            this.btnBuscaResponsiva.Location = new System.Drawing.Point(523, 47);
            this.btnBuscaResponsiva.Name = "btnBuscaResponsiva";
            this.btnBuscaResponsiva.Size = new System.Drawing.Size(198, 43);
            this.btnBuscaResponsiva.TabIndex = 0;
            this.btnBuscaResponsiva.Text = "Buscar Responsiva";
            this.btnBuscaResponsiva.UseVisualStyleBackColor = true;
            this.btnBuscaResponsiva.Click += new System.EventHandler(this.btnBuscaResponsiva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Responsable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sucursal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Puesto";
            // 
            // btnAgrega
            // 
            this.btnAgrega.Location = new System.Drawing.Point(441, 412);
            this.btnAgrega.Name = "btnAgrega";
            this.btnAgrega.Size = new System.Drawing.Size(230, 33);
            this.btnAgrega.TabIndex = 6;
            this.btnAgrega.Text = "Agregar Activo (s)";
            this.btnAgrega.UseVisualStyleBackColor = true;
            this.btnAgrega.Click += new System.EventHandler(this.btnAgrega_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(38, 412);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(274, 33);
            this.btnQuitar.TabIndex = 7;
            this.btnQuitar.Text = "Quitar Activo (s)";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(582, 635);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(139, 43);
            this.btnAplicar.TabIndex = 8;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            // 
            // gcActivos
            // 
            this.gcActivos.DataSource = this.activosBindingSource;
            this.gcActivos.Location = new System.Drawing.Point(12, 141);
            this.gcActivos.MainView = this.gridView1;
            this.gcActivos.Name = "gcActivos";
            this.gcActivos.Size = new System.Drawing.Size(705, 255);
            this.gcActivos.TabIndex = 9;
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
            this.colseleccionado.Visible = true;
            this.colseleccionado.VisibleIndex = 0;
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
            this.colarea.VisibleIndex = 1;
            this.colarea.Width = 109;
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
            this.coltipo.Width = 109;
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
            this.colnombreCorto.VisibleIndex = 3;
            this.colnombreCorto.Width = 109;
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Width = 109;
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
            this.colnumEtiqueta.VisibleIndex = 4;
            this.colnumEtiqueta.Width = 109;
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
            this.colclaveActivo.VisibleIndex = 5;
            this.colclaveActivo.Width = 112;
            // 
            // colstatus
            // 
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            // 
            // gcPrevMov
            // 
            this.gcPrevMov.DataSource = this.activosBindingSource;
            this.gcPrevMov.Location = new System.Drawing.Point(16, 466);
            this.gcPrevMov.MainView = this.gridView2;
            this.gcPrevMov.Name = "gcPrevMov";
            this.gcPrevMov.Size = new System.Drawing.Size(705, 212);
            this.gcPrevMov.TabIndex = 10;
            this.gcPrevMov.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridView2.GridControl = this.gcPrevMov;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowViewCaption = true;
            this.gridView2.ViewCaption = "Previsualización de Movimientos";
            // 
            // colseleccionado1
            // 
            this.colseleccionado1.Caption = " ";
            this.colseleccionado1.FieldName = "seleccionado";
            this.colseleccionado1.Name = "colseleccionado1";
            this.colseleccionado1.Visible = true;
            this.colseleccionado1.VisibleIndex = 0;
            this.colseleccionado1.Width = 30;
            // 
            // colidActivo1
            // 
            this.colidActivo1.FieldName = "idActivo";
            this.colidActivo1.Name = "colidActivo1";
            // 
            // colidArea1
            // 
            this.colidArea1.FieldName = "idArea";
            this.colidArea1.Name = "colidArea1";
            // 
            // colarea1
            // 
            this.colarea1.Caption = "Área";
            this.colarea1.FieldName = "area";
            this.colarea1.Name = "colarea1";
            this.colarea1.Visible = true;
            this.colarea1.VisibleIndex = 1;
            this.colarea1.Width = 109;
            // 
            // colidTipo1
            // 
            this.colidTipo1.FieldName = "idTipo";
            this.colidTipo1.Name = "colidTipo1";
            // 
            // coltipo1
            // 
            this.coltipo1.Caption = "Tipo";
            this.coltipo1.FieldName = "tipo";
            this.coltipo1.Name = "coltipo1";
            this.coltipo1.Visible = true;
            this.coltipo1.VisibleIndex = 2;
            this.coltipo1.Width = 109;
            // 
            // colnombreCorto1
            // 
            this.colnombreCorto1.Caption = "Activo";
            this.colnombreCorto1.FieldName = "nombreCorto";
            this.colnombreCorto1.Name = "colnombreCorto1";
            this.colnombreCorto1.Visible = true;
            this.colnombreCorto1.VisibleIndex = 3;
            this.colnombreCorto1.Width = 109;
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            // 
            // colfechaAlta1
            // 
            this.colfechaAlta1.FieldName = "fechaAlta";
            this.colfechaAlta1.Name = "colfechaAlta1";
            // 
            // colidUsuarioAlta1
            // 
            this.colidUsuarioAlta1.FieldName = "idUsuarioAlta";
            this.colidUsuarioAlta1.Name = "colidUsuarioAlta1";
            // 
            // colfechaModificacion1
            // 
            this.colfechaModificacion1.FieldName = "fechaModificacion";
            this.colfechaModificacion1.Name = "colfechaModificacion1";
            // 
            // colidUsuarioModifica1
            // 
            this.colidUsuarioModifica1.FieldName = "idUsuarioModifica";
            this.colidUsuarioModifica1.Name = "colidUsuarioModifica1";
            // 
            // colcosto1
            // 
            this.colcosto1.FieldName = "costo";
            this.colcosto1.Name = "colcosto1";
            // 
            // colnumEtiqueta1
            // 
            this.colnumEtiqueta1.Caption = "Núm. Etiqueta";
            this.colnumEtiqueta1.FieldName = "numEtiqueta";
            this.colnumEtiqueta1.Name = "colnumEtiqueta1";
            this.colnumEtiqueta1.Visible = true;
            this.colnumEtiqueta1.VisibleIndex = 4;
            this.colnumEtiqueta1.Width = 109;
            // 
            // colclaveActivo1
            // 
            this.colclaveActivo1.Caption = "Cve. Etiqueta";
            this.colclaveActivo1.FieldName = "claveActivo";
            this.colclaveActivo1.Name = "colclaveActivo1";
            this.colclaveActivo1.Visible = true;
            this.colclaveActivo1.VisibleIndex = 5;
            this.colclaveActivo1.Width = 109;
            // 
            // colstatus1
            // 
            this.colstatus1.Caption = "Acción";
            this.colstatus1.FieldName = "status";
            this.colstatus1.Name = "colstatus1";
            this.colstatus1.Visible = true;
            this.colstatus1.VisibleIndex = 6;
            this.colstatus1.Width = 112;
            // 
            // tbResponsable
            // 
            this.tbResponsable.Location = new System.Drawing.Point(133, 12);
            this.tbResponsable.Name = "tbResponsable";
            this.tbResponsable.ReadOnly = true;
            this.tbResponsable.Size = new System.Drawing.Size(363, 30);
            this.tbResponsable.TabIndex = 11;
            // 
            // tbSucursal
            // 
            this.tbSucursal.Location = new System.Drawing.Point(133, 53);
            this.tbSucursal.Name = "tbSucursal";
            this.tbSucursal.ReadOnly = true;
            this.tbSucursal.Size = new System.Drawing.Size(363, 30);
            this.tbSucursal.TabIndex = 12;
            // 
            // tbPuesto
            // 
            this.tbPuesto.Location = new System.Drawing.Point(133, 94);
            this.tbPuesto.Name = "tbPuesto";
            this.tbPuesto.ReadOnly = true;
            this.tbPuesto.Size = new System.Drawing.Size(363, 30);
            this.tbPuesto.TabIndex = 13;
            // 
            // btnQuitarActivo
            // 
            this.btnQuitarActivo.Location = new System.Drawing.Point(16, 699);
            this.btnQuitarActivo.Name = "btnQuitarActivo";
            this.btnQuitarActivo.Size = new System.Drawing.Size(274, 33);
            this.btnQuitarActivo.TabIndex = 14;
            this.btnQuitarActivo.Text = "Quitar Activo (s)";
            this.btnQuitarActivo.UseVisualStyleBackColor = true;
            this.btnQuitarActivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAplica
            // 
            this.btnAplica.Location = new System.Drawing.Point(523, 699);
            this.btnAplica.Name = "btnAplica";
            this.btnAplica.Size = new System.Drawing.Size(198, 43);
            this.btnAplica.TabIndex = 15;
            this.btnAplica.Text = "Aplicar";
            this.btnAplica.UseVisualStyleBackColor = true;
            this.btnAplica.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmModifResp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 760);
            this.Controls.Add(this.btnAplica);
            this.Controls.Add(this.btnQuitarActivo);
            this.Controls.Add(this.tbPuesto);
            this.Controls.Add(this.tbSucursal);
            this.Controls.Add(this.tbResponsable);
            this.Controls.Add(this.gcPrevMov);
            this.Controls.Add(this.gcActivos);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgrega);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscaResponsiva);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmModifResp";
            this.Text = "Modificar Responsivas";
            ((System.ComponentModel.ISupportInitialize)(this.gcActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrevMov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscaResponsiva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgrega;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAplicar;
        private DevExpress.XtraGrid.GridControl gcActivos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gcPrevMov;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.TextBox tbResponsable;
        private System.Windows.Forms.TextBox tbSucursal;
        private System.Windows.Forms.TextBox tbPuesto;
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
        private System.Windows.Forms.Button btnQuitarActivo;
        private System.Windows.Forms.Button btnAplica;
    }
}