namespace Activos.GUIs.Usuarios
{
    partial class frmActUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActUs));
            this.gcUsuariosBaja = new DevExpress.XtraGrid.GridControl();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colseleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidPuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaIngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colclave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnActiva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuariosBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcUsuariosBaja
            // 
            this.gcUsuariosBaja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gcUsuariosBaja.DataSource = this.usuariosBindingSource;
            this.gcUsuariosBaja.Font = new System.Drawing.Font("Tahoma", 16F);
            this.gcUsuariosBaja.Location = new System.Drawing.Point(12, 61);
            this.gcUsuariosBaja.MainView = this.gridView1;
            this.gcUsuariosBaja.Name = "gcUsuariosBaja";
            this.gcUsuariosBaja.Size = new System.Drawing.Size(730, 267);
            this.gcUsuariosBaja.TabIndex = 9;
            this.gcUsuariosBaja.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataSource = typeof(Activos.Modelos.Usuarios);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colseleccionado,
            this.colidUsuario,
            this.colnombre,
            this.colidPuesto,
            this.colpuesto,
            this.colfechaIngreso,
            this.colcorreo,
            this.colusuario,
            this.colclave,
            this.colstatus});
            this.gridView1.GridControl = this.gcUsuariosBaja;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colseleccionado
            // 
            this.colseleccionado.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colseleccionado.AppearanceCell.Options.UseBackColor = true;
            this.colseleccionado.Caption = " ";
            this.colseleccionado.FieldName = "seleccionado";
            this.colseleccionado.Name = "colseleccionado";
            this.colseleccionado.Visible = true;
            this.colseleccionado.VisibleIndex = 0;
            this.colseleccionado.Width = 30;
            // 
            // colidUsuario
            // 
            this.colidUsuario.FieldName = "idUsuario";
            this.colidUsuario.Name = "colidUsuario";
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowEdit = false;
            this.colnombre.OptionsColumn.AllowMove = false;
            this.colnombre.OptionsColumn.ReadOnly = true;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 140;
            // 
            // colidPuesto
            // 
            this.colidPuesto.FieldName = "idPuesto";
            this.colidPuesto.Name = "colidPuesto";
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
            this.colpuesto.VisibleIndex = 2;
            this.colpuesto.Width = 160;
            // 
            // colfechaIngreso
            // 
            this.colfechaIngreso.Caption = "Fecha de Ingreso";
            this.colfechaIngreso.FieldName = "fechaIngreso";
            this.colfechaIngreso.Name = "colfechaIngreso";
            this.colfechaIngreso.OptionsColumn.AllowEdit = false;
            this.colfechaIngreso.OptionsColumn.AllowMove = false;
            this.colfechaIngreso.OptionsColumn.ReadOnly = true;
            this.colfechaIngreso.Visible = true;
            this.colfechaIngreso.VisibleIndex = 3;
            this.colfechaIngreso.Width = 120;
            // 
            // colcorreo
            // 
            this.colcorreo.Caption = "Correo";
            this.colcorreo.FieldName = "correo";
            this.colcorreo.Name = "colcorreo";
            this.colcorreo.OptionsColumn.AllowEdit = false;
            this.colcorreo.OptionsColumn.AllowMove = false;
            this.colcorreo.OptionsColumn.ReadOnly = true;
            this.colcorreo.Visible = true;
            this.colcorreo.VisibleIndex = 4;
            this.colcorreo.Width = 170;
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
            this.colusuario.VisibleIndex = 5;
            this.colusuario.Width = 85;
            // 
            // colclave
            // 
            this.colclave.FieldName = "clave";
            this.colclave.Name = "colclave";
            // 
            // colstatus
            // 
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            // 
            // btnActiva
            // 
            this.btnActiva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActiva.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnActiva.Location = new System.Drawing.Point(488, 336);
            this.btnActiva.Margin = new System.Windows.Forms.Padding(5);
            this.btnActiva.Name = "btnActiva";
            this.btnActiva.Size = new System.Drawing.Size(237, 51);
            this.btnActiva.TabIndex = 8;
            this.btnActiva.Text = "&Activar";
            this.btnActiva.UseVisualStyleBackColor = true;
            this.btnActiva.Click += new System.EventHandler(this.btnActiva_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Activar Usuarios";
            // 
            // frmActUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(754, 409);
            this.Controls.Add(this.gcUsuariosBaja);
            this.Controls.Add(this.btnActiva);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmActUs";
            this.Text = "Activar Usuarios";
            this.Load += new System.EventHandler(this.frmActUs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuariosBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcUsuariosBaja;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnActiva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionado;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colidPuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colpuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaIngreso;
        private DevExpress.XtraGrid.Columns.GridColumn colcorreo;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraGrid.Columns.GridColumn colclave;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
    }
}