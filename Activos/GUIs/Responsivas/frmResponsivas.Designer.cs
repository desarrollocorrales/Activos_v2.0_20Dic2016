namespace Activos.GUIs.Responsivas
{
    partial class frmResponsivas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSucursal = new System.Windows.Forms.Label();
            this.lbPuesto = new System.Windows.Forms.Label();
            this.lbUsuarios = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gcUsuarios = new DevExpress.XtraGrid.GridControl();
            this.usuariosResponsivasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnomUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbUsuario = new System.Windows.Forms.RadioButton();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreaResp = new System.Windows.Forms.Button();
            this.gcActivos = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnBuscaActivos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosResponsivasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbSucursal);
            this.groupBox1.Controls.Add(this.lbPuesto);
            this.groupBox1.Controls.Add(this.lbUsuarios);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.gcUsuarios);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.tbUsuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuarios";
            // 
            // lbSucursal
            // 
            this.lbSucursal.AutoSize = true;
            this.lbSucursal.Location = new System.Drawing.Point(104, 410);
            this.lbSucursal.Name = "lbSucursal";
            this.lbSucursal.Size = new System.Drawing.Size(17, 23);
            this.lbSucursal.TabIndex = 9;
            this.lbSucursal.Text = "-";
            // 
            // lbPuesto
            // 
            this.lbPuesto.AutoSize = true;
            this.lbPuesto.Location = new System.Drawing.Point(104, 371);
            this.lbPuesto.Name = "lbPuesto";
            this.lbPuesto.Size = new System.Drawing.Size(17, 23);
            this.lbPuesto.TabIndex = 8;
            this.lbPuesto.Text = "-";
            // 
            // lbUsuarios
            // 
            this.lbUsuarios.AutoSize = true;
            this.lbUsuarios.Location = new System.Drawing.Point(104, 328);
            this.lbUsuarios.Name = "lbUsuarios";
            this.lbUsuarios.Size = new System.Drawing.Size(17, 23);
            this.lbUsuarios.TabIndex = 7;
            this.lbUsuarios.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sucursal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Puesto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario: ";
            // 
            // gcUsuarios
            // 
            this.gcUsuarios.DataSource = this.usuariosResponsivasBindingSource;
            this.gcUsuarios.Location = new System.Drawing.Point(17, 138);
            this.gcUsuarios.MainView = this.gridView1;
            this.gcUsuarios.Name = "gcUsuarios";
            this.gcUsuarios.Size = new System.Drawing.Size(530, 174);
            this.gcUsuarios.TabIndex = 3;
            this.gcUsuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcUsuarios.DoubleClick += new System.EventHandler(this.gcUsuarios_DoubleClick);
            // 
            // usuariosResponsivasBindingSource
            // 
            this.usuariosResponsivasBindingSource.DataSource = typeof(Activos.Modelos.UsuariosResponsivas);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidUsuario,
            this.colnomUsuario,
            this.colpuesto,
            this.colsucursal,
            this.colusuario});
            this.gridView1.GridControl = this.gcUsuarios;
            this.gridView1.Name = "gridView1";
            // 
            // colidUsuario
            // 
            this.colidUsuario.FieldName = "idUsuario";
            this.colidUsuario.Name = "colidUsuario";
            // 
            // colnomUsuario
            // 
            this.colnomUsuario.Caption = "Nombre";
            this.colnomUsuario.FieldName = "nomUsuario";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.rbNombre);
            this.panel1.Controls.Add(this.rbUsuario);
            this.panel1.Location = new System.Drawing.Point(343, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 94);
            this.panel1.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(43, 42);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(124, 40);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(102, 7);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(95, 27);
            this.rbNombre.TabIndex = 1;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // rbUsuario
            // 
            this.rbUsuario.AutoSize = true;
            this.rbUsuario.Checked = true;
            this.rbUsuario.Location = new System.Drawing.Point(6, 7);
            this.rbUsuario.Name = "rbUsuario";
            this.rbUsuario.Size = new System.Drawing.Size(90, 27);
            this.rbUsuario.TabIndex = 0;
            this.rbUsuario.TabStop = true;
            this.rbUsuario.Text = "Usuario";
            this.rbUsuario.UseVisualStyleBackColor = true;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(24, 70);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(292, 30);
            this.tbUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataSource = typeof(Activos.Modelos.Usuarios);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCreaResp);
            this.groupBox2.Controls.Add(this.gcActivos);
            this.groupBox2.Controls.Add(this.btnBuscaActivos);
            this.groupBox2.Location = new System.Drawing.Point(582, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 450);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Responsivas";
            // 
            // btnCreaResp
            // 
            this.btnCreaResp.Location = new System.Drawing.Point(189, 379);
            this.btnCreaResp.Name = "btnCreaResp";
            this.btnCreaResp.Size = new System.Drawing.Size(186, 41);
            this.btnCreaResp.TabIndex = 2;
            this.btnCreaResp.Text = "Crear Responsiva";
            this.btnCreaResp.UseVisualStyleBackColor = true;
            // 
            // gcActivos
            // 
            this.gcActivos.Location = new System.Drawing.Point(6, 85);
            this.gcActivos.MainView = this.gridView2;
            this.gcActivos.Name = "gcActivos";
            this.gcActivos.Size = new System.Drawing.Size(552, 266);
            this.gcActivos.TabIndex = 1;
            this.gcActivos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gcActivos;
            this.gridView2.Name = "gridView2";
            // 
            // btnBuscaActivos
            // 
            this.btnBuscaActivos.Location = new System.Drawing.Point(189, 29);
            this.btnBuscaActivos.Name = "btnBuscaActivos";
            this.btnBuscaActivos.Size = new System.Drawing.Size(186, 41);
            this.btnBuscaActivos.TabIndex = 0;
            this.btnBuscaActivos.Text = "Buscar Activos";
            this.btnBuscaActivos.UseVisualStyleBackColor = true;
            // 
            // frmResponsivas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 473);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmResponsivas";
            this.Text = "Responsivas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosResponsivasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gcUsuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbUsuario;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource usuariosResponsivasBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colnomUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colpuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colsucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreaResp;
        private DevExpress.XtraGrid.GridControl gcActivos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Button btnBuscaActivos;
        private System.Windows.Forms.Label lbSucursal;
        private System.Windows.Forms.Label lbPuesto;
        private System.Windows.Forms.Label lbUsuarios;
    }
}