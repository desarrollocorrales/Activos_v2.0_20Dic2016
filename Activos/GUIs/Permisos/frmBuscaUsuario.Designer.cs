namespace Activos.GUIs.Permisos
{
    partial class frmBuscaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscaUsuario));
            this.gcUsuarios = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnomUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.tbUsuarioSeleccionado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcUsuarios
            // 
            this.gcUsuarios.Location = new System.Drawing.Point(9, 121);
            this.gcUsuarios.MainView = this.gridView1;
            this.gcUsuarios.Name = "gcUsuarios";
            this.gcUsuarios.Size = new System.Drawing.Size(530, 150);
            this.gcUsuarios.TabIndex = 11;
            this.gcUsuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcUsuarios.DoubleClick += new System.EventHandler(this.gcUsuarios_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidUsuario,
            this.colnomUsuario,
            this.colpuesto,
            this.colsucursal});
            this.gridView1.GridControl = this.gcUsuarios;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Usuarios";
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // colidUsuario
            // 
            this.colidUsuario.FieldName = "idPersona";
            this.colidUsuario.Name = "colidUsuario";
            // 
            // colnomUsuario
            // 
            this.colnomUsuario.Caption = "Nombre";
            this.colnomUsuario.FieldName = "nombre";
            this.colnomUsuario.Name = "colnomUsuario";
            this.colnomUsuario.OptionsColumn.AllowEdit = false;
            this.colnomUsuario.OptionsColumn.AllowMove = false;
            this.colnomUsuario.OptionsColumn.ReadOnly = true;
            this.colnomUsuario.Visible = true;
            this.colnomUsuario.VisibleIndex = 0;
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
            this.colpuesto.VisibleIndex = 1;
            // 
            // colsucursal
            // 
            this.colsucursal.Caption = "Sucursal";
            this.colsucursal.FieldName = "sucursal";
            this.colsucursal.Name = "colsucursal";
            this.colsucursal.OptionsColumn.AllowEdit = false;
            this.colsucursal.OptionsColumn.AllowMove = false;
            this.colsucursal.OptionsColumn.ReadOnly = true;
            this.colsucursal.Visible = true;
            this.colsucursal.VisibleIndex = 2;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(16, 53);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(357, 30);
            this.tbUsuario.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuario";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(378, 336);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(140, 40);
            this.btnSeleccionar.TabIndex = 12;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // tbUsuarioSeleccionado
            // 
            this.tbUsuarioSeleccionado.Location = new System.Drawing.Point(86, 287);
            this.tbUsuarioSeleccionado.Name = "tbUsuarioSeleccionado";
            this.tbUsuarioSeleccionado.ReadOnly = true;
            this.tbUsuarioSeleccionado.Size = new System.Drawing.Size(453, 30);
            this.tbUsuarioSeleccionado.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Usuario";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(394, 47);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(124, 40);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            // frmBuscaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 393);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbUsuarioSeleccionado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.gcUsuarios);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmBuscaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcUsuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colnomUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colpuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colsucursal;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox tbUsuarioSeleccionado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
    }
}