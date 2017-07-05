namespace Activos.GUIs.Reportes
{
    partial class frmTraspasosRealizados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraspasosRealizados));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gcTraspasos = new DevExpress.XtraGrid.GridControl();
            this.traspasosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colseleccionado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconsecTraspaso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidPersonaAnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpersonaAnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidPersonaNuevo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpersonaNuevo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmotivo = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.btnVistaPrevia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcTraspasos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traspasosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione Fecha a consultar";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(266, 12);
            this.dtpFecha.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(133, 30);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFecha_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(405, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(122, 34);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gcTraspasos
            // 
            this.gcTraspasos.DataSource = this.traspasosBindingSource;
            this.gcTraspasos.Location = new System.Drawing.Point(12, 52);
            this.gcTraspasos.MainView = this.gridView1;
            this.gcTraspasos.Name = "gcTraspasos";
            this.gcTraspasos.Size = new System.Drawing.Size(706, 202);
            this.gcTraspasos.TabIndex = 3;
            this.gcTraspasos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcTraspasos.DoubleClick += new System.EventHandler(this.gcTraspasos_DoubleClick);
            // 
            // traspasosBindingSource
            // 
            this.traspasosBindingSource.DataSource = typeof(Modelos.Traspasos);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colseleccionado1,
            this.colconsecTraspaso,
            this.colidPersonaAnt,
            this.colpersonaAnt,
            this.colidPersonaNuevo,
            this.colpersonaNuevo,
            this.colfecha,
            this.colmotivo});
            this.gridView1.GridControl = this.gcTraspasos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Traspasos";
            // 
            // colseleccionado1
            // 
            this.colseleccionado1.Caption = " ";
            this.colseleccionado1.FieldName = "seleccionado";
            this.colseleccionado1.Name = "colseleccionado1";
            this.colseleccionado1.OptionsColumn.AllowMove = false;
            this.colseleccionado1.OptionsColumn.ShowCaption = false;
            this.colseleccionado1.Visible = true;
            this.colseleccionado1.VisibleIndex = 0;
            this.colseleccionado1.Width = 30;
            // 
            // colconsecTraspaso
            // 
            this.colconsecTraspaso.FieldName = "consecTraspaso";
            this.colconsecTraspaso.Name = "colconsecTraspaso";
            this.colconsecTraspaso.Width = 94;
            // 
            // colidPersonaAnt
            // 
            this.colidPersonaAnt.FieldName = "idPersonaAnt";
            this.colidPersonaAnt.Name = "colidPersonaAnt";
            this.colidPersonaAnt.Width = 94;
            // 
            // colpersonaAnt
            // 
            this.colpersonaAnt.Caption = "Anterior";
            this.colpersonaAnt.FieldName = "personaAnt";
            this.colpersonaAnt.Name = "colpersonaAnt";
            this.colpersonaAnt.OptionsColumn.AllowEdit = false;
            this.colpersonaAnt.OptionsColumn.AllowMove = false;
            this.colpersonaAnt.OptionsColumn.ReadOnly = true;
            this.colpersonaAnt.Visible = true;
            this.colpersonaAnt.VisibleIndex = 1;
            this.colpersonaAnt.Width = 94;
            // 
            // colidPersonaNuevo
            // 
            this.colidPersonaNuevo.FieldName = "idPersonaNuevo";
            this.colidPersonaNuevo.Name = "colidPersonaNuevo";
            this.colidPersonaNuevo.Width = 94;
            // 
            // colpersonaNuevo
            // 
            this.colpersonaNuevo.Caption = "Nueva";
            this.colpersonaNuevo.FieldName = "personaNuevo";
            this.colpersonaNuevo.Name = "colpersonaNuevo";
            this.colpersonaNuevo.OptionsColumn.AllowEdit = false;
            this.colpersonaNuevo.OptionsColumn.AllowMove = false;
            this.colpersonaNuevo.OptionsColumn.ReadOnly = true;
            this.colpersonaNuevo.Visible = true;
            this.colpersonaNuevo.VisibleIndex = 2;
            this.colpersonaNuevo.Width = 94;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.OptionsColumn.AllowMove = false;
            this.colfecha.OptionsColumn.ReadOnly = true;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 3;
            this.colfecha.Width = 94;
            // 
            // colmotivo
            // 
            this.colmotivo.Caption = "Motivo";
            this.colmotivo.FieldName = "motivo";
            this.colmotivo.Name = "colmotivo";
            this.colmotivo.OptionsColumn.AllowEdit = false;
            this.colmotivo.OptionsColumn.AllowMove = false;
            this.colmotivo.OptionsColumn.ReadOnly = true;
            this.colmotivo.Visible = true;
            this.colmotivo.VisibleIndex = 4;
            this.colmotivo.Width = 94;
            // 
            // gcActivos
            // 
            this.gcActivos.DataSource = this.activosBindingSource;
            this.gcActivos.Location = new System.Drawing.Point(12, 260);
            this.gcActivos.MainView = this.gridView2;
            this.gcActivos.Name = "gcActivos";
            this.gcActivos.Size = new System.Drawing.Size(706, 147);
            this.gcActivos.TabIndex = 19;
            this.gcActivos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // activosBindingSource
            // 
            this.activosBindingSource.DataSource = typeof(Modelos.Activos);
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
            this.colstatus});
            this.gridView2.GridControl = this.gcActivos;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
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
            this.colarea.Caption = "Área";
            this.colarea.FieldName = "area";
            this.colarea.Name = "colarea";
            this.colarea.OptionsColumn.AllowEdit = false;
            this.colarea.OptionsColumn.AllowMove = false;
            this.colarea.OptionsColumn.ReadOnly = true;
            this.colarea.Visible = true;
            this.colarea.VisibleIndex = 0;
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
            this.coltipo.VisibleIndex = 1;
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
            this.colnombreCorto.VisibleIndex = 2;
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
            this.colnumEtiqueta.VisibleIndex = 3;
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
            this.colclaveActivo.VisibleIndex = 4;
            this.colclaveActivo.Width = 112;
            // 
            // colstatus
            // 
            this.colstatus.Caption = "Estatus";
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.Location = new System.Drawing.Point(549, 413);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(169, 41);
            this.btnVistaPrevia.TabIndex = 20;
            this.btnVistaPrevia.Text = "Vista Previa";
            this.btnVistaPrevia.UseVisualStyleBackColor = true;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // frmTraspasosRealizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 467);
            this.Controls.Add(this.btnVistaPrevia);
            this.Controls.Add(this.gcActivos);
            this.Controls.Add(this.gcTraspasos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmTraspasosRealizados";
            this.Text = "Traspasos Realizados";
            ((System.ComponentModel.ISupportInitialize)(this.gcTraspasos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traspasosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnBuscar;
        private DevExpress.XtraGrid.GridControl gcTraspasos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private System.Windows.Forms.Button btnVistaPrevia;
        private System.Windows.Forms.BindingSource traspasosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionado1;
        private DevExpress.XtraGrid.Columns.GridColumn colconsecTraspaso;
        private DevExpress.XtraGrid.Columns.GridColumn colidPersonaAnt;
        private DevExpress.XtraGrid.Columns.GridColumn colpersonaAnt;
        private DevExpress.XtraGrid.Columns.GridColumn colidPersonaNuevo;
        private DevExpress.XtraGrid.Columns.GridColumn colpersonaNuevo;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colmotivo;
        private System.Windows.Forms.BindingSource activosBindingSource;
    }
}