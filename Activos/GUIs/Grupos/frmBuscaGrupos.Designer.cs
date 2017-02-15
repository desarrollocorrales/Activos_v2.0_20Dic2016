namespace Activos.GUIs.Grupos
{
    partial class frmBuscaGrupos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscaGrupos));
            this.label1 = new System.Windows.Forms.Label();
            this.tbNomGrupo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gcGrupos = new DevExpress.XtraGrid.GridControl();
            this.gruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colseleccionado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidArea1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colarea1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUsuarioCrea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuarioCrea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcActivos = new DevExpress.XtraGrid.GridControl();
            this.activosBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grupo";
            // 
            // tbNomGrupo
            // 
            this.tbNomGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNomGrupo.Location = new System.Drawing.Point(80, 20);
            this.tbNomGrupo.Name = "tbNomGrupo";
            this.tbNomGrupo.Size = new System.Drawing.Size(288, 30);
            this.tbNomGrupo.TabIndex = 1;
            this.tbNomGrupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNomGrupo_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(385, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(131, 38);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gcGrupos
            // 
            this.gcGrupos.DataSource = this.gruposBindingSource;
            this.gcGrupos.Location = new System.Drawing.Point(16, 59);
            this.gcGrupos.MainView = this.gridView1;
            this.gcGrupos.Name = "gcGrupos";
            this.gcGrupos.Size = new System.Drawing.Size(500, 200);
            this.gcGrupos.TabIndex = 3;
            this.gcGrupos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcGrupos.DoubleClick += new System.EventHandler(this.gcGrupos_DoubleClick);
            // 
            // gruposBindingSource
            // 
            this.gruposBindingSource.DataSource = typeof(Activos.Modelos.Grupos);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colseleccionado1,
            this.colidGrupo,
            this.colidArea1,
            this.colarea1,
            this.colnombre,
            this.colfecha,
            this.colidUsuarioCrea,
            this.colusuarioCrea,
            this.colstatus1});
            this.gridView1.GridControl = this.gcGrupos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Grupos";
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // colseleccionado1
            // 
            this.colseleccionado1.Caption = " ";
            this.colseleccionado1.FieldName = "seleccionado";
            this.colseleccionado1.Name = "colseleccionado1";
            this.colseleccionado1.Width = 30;
            // 
            // colidGrupo
            // 
            this.colidGrupo.FieldName = "idGrupo";
            this.colidGrupo.Name = "colidGrupo";
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
            this.colarea1.OptionsColumn.AllowEdit = false;
            this.colarea1.OptionsColumn.AllowMove = false;
            this.colarea1.OptionsColumn.ReadOnly = true;
            this.colarea1.Visible = true;
            this.colarea1.VisibleIndex = 0;
            this.colarea1.Width = 224;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Grupo";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowEdit = false;
            this.colnombre.OptionsColumn.AllowMove = false;
            this.colnombre.OptionsColumn.ReadOnly = true;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 228;
            // 
            // colfecha
            // 
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            // 
            // colidUsuarioCrea
            // 
            this.colidUsuarioCrea.FieldName = "idUsuarioCrea";
            this.colidUsuarioCrea.Name = "colidUsuarioCrea";
            // 
            // colusuarioCrea
            // 
            this.colusuarioCrea.FieldName = "usuarioCrea";
            this.colusuarioCrea.Name = "colusuarioCrea";
            // 
            // colstatus1
            // 
            this.colstatus1.FieldName = "status";
            this.colstatus1.Name = "colstatus1";
            // 
            // gcActivos
            // 
            this.gcActivos.DataSource = this.activosBindingSource;
            this.gcActivos.Location = new System.Drawing.Point(16, 265);
            this.gcActivos.MainView = this.gridView2;
            this.gcActivos.Name = "gcActivos";
            this.gcActivos.Size = new System.Drawing.Size(500, 200);
            this.gcActivos.TabIndex = 4;
            this.gcActivos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // activosBindingSource
            // 
            this.activosBindingSource.DataSource = typeof(Activos.Modelos.Activos);
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
            this.colstatus,
            this.colaccion});
            this.gridView2.GridControl = this.gcActivos;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowViewCaption = true;
            this.gridView2.ViewCaption = "Activos";
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
            this.colarea.FieldName = "area";
            this.colarea.Name = "colarea";
            this.colarea.Width = 89;
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
            this.coltipo.Visible = true;
            this.coltipo.VisibleIndex = 0;
            this.coltipo.Width = 150;
            // 
            // colnombreCorto
            // 
            this.colnombreCorto.Caption = "Nombre Corto";
            this.colnombreCorto.FieldName = "nombreCorto";
            this.colnombreCorto.Name = "colnombreCorto";
            this.colnombreCorto.Visible = true;
            this.colnombreCorto.VisibleIndex = 1;
            this.colnombreCorto.Width = 150;
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
            this.colnumEtiqueta.VisibleIndex = 2;
            this.colnumEtiqueta.Width = 90;
            // 
            // colclaveActivo
            // 
            this.colclaveActivo.Caption = "Cve. Activo";
            this.colclaveActivo.FieldName = "claveActivo";
            this.colclaveActivo.Name = "colclaveActivo";
            this.colclaveActivo.Visible = true;
            this.colclaveActivo.VisibleIndex = 3;
            this.colclaveActivo.Width = 70;
            // 
            // colstatus
            // 
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            // 
            // colaccion
            // 
            this.colaccion.FieldName = "accion";
            this.colaccion.Name = "colaccion";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(297, 481);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(202, 38);
            this.btnSeleccionar.TabIndex = 5;
            this.btnSeleccionar.Text = "Seleccionar Grupo";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frmBuscaGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(535, 532);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.gcActivos);
            this.Controls.Add(this.gcGrupos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbNomGrupo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmBuscaGrupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Grupos";
            ((System.ComponentModel.ISupportInitialize)(this.gcGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNomGrupo;
        private System.Windows.Forms.Button btnBuscar;
        private DevExpress.XtraGrid.GridControl gcGrupos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gcActivos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Button btnSeleccionar;
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
        private DevExpress.XtraGrid.Columns.GridColumn colaccion;
        private System.Windows.Forms.BindingSource gruposBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionado1;
        private DevExpress.XtraGrid.Columns.GridColumn colidGrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colidArea1;
        private DevExpress.XtraGrid.Columns.GridColumn colarea1;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuarioCrea;
        private DevExpress.XtraGrid.Columns.GridColumn colusuarioCrea;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus1;
    }
}