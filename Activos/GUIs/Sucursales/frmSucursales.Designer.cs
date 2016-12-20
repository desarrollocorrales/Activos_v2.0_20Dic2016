namespace Activos.GUIs.Sucursales
{
    partial class frmSucursales
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
            this.sucursalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombreSuc = new System.Windows.Forms.TextBox();
            this.cmbResponsable = new System.Windows.Forms.ComboBox();
            this.sucursalesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gcSucursales = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidResponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colresponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSucursales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sucursalesBindingSource
            // 
            this.sucursalesBindingSource.DataSource = typeof(Activos.Modelos.Sucursales);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(656, 75);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 41);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nuevo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Responsable";
            // 
            // tbNombreSuc
            // 
            this.tbNombreSuc.Location = new System.Drawing.Point(164, 53);
            this.tbNombreSuc.Margin = new System.Windows.Forms.Padding(5);
            this.tbNombreSuc.Name = "tbNombreSuc";
            this.tbNombreSuc.Size = new System.Drawing.Size(482, 30);
            this.tbNombreSuc.TabIndex = 5;
            // 
            // cmbResponsable
            // 
            this.cmbResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResponsable.FormattingEnabled = true;
            this.cmbResponsable.Location = new System.Drawing.Point(164, 102);
            this.cmbResponsable.Margin = new System.Windows.Forms.Padding(5);
            this.cmbResponsable.Name = "cmbResponsable";
            this.cmbResponsable.Size = new System.Drawing.Size(482, 31);
            this.cmbResponsable.TabIndex = 6;
            // 
            // sucursalesBindingSource1
            // 
            this.sucursalesBindingSource1.DataSource = typeof(Activos.Modelos.Sucursales);
            // 
            // gcSucursales
            // 
            this.gcSucursales.DataSource = this.sucursalesBindingSource1;
            this.gcSucursales.Location = new System.Drawing.Point(12, 156);
            this.gcSucursales.MainView = this.gridView1;
            this.gcSucursales.Name = "gcSucursales";
            this.gcSucursales.Size = new System.Drawing.Size(788, 365);
            this.gcSucursales.TabIndex = 7;
            this.gcSucursales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidSucursal,
            this.colnombre,
            this.colidResponsable,
            this.colresponsable,
            this.colstatus});
            this.gridView1.GridControl = this.gcSucursales;
            this.gridView1.Name = "gridView1";
            // 
            // colidSucursal
            // 
            this.colidSucursal.FieldName = "idSucursal";
            this.colidSucursal.Name = "colidSucursal";
            this.colidSucursal.Visible = true;
            this.colidSucursal.VisibleIndex = 0;
            // 
            // colnombre
            // 
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            // 
            // colidResponsable
            // 
            this.colidResponsable.FieldName = "idResponsable";
            this.colidResponsable.Name = "colidResponsable";
            this.colidResponsable.Visible = true;
            this.colidResponsable.VisibleIndex = 2;
            // 
            // colresponsable
            // 
            this.colresponsable.FieldName = "responsable";
            this.colresponsable.Name = "colresponsable";
            this.colresponsable.Visible = true;
            this.colresponsable.VisibleIndex = 3;
            // 
            // colstatus
            // 
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            this.colstatus.Visible = true;
            this.colstatus.VisibleIndex = 4;
            // 
            // frmSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 533);
            this.Controls.Add(this.gcSucursales);
            this.Controls.Add(this.cmbResponsable);
            this.Controls.Add(this.tbNombreSuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSucursales";
            this.Text = "Sucursales";
            this.Load += new System.EventHandler(this.frmSucursales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSucursales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombreSuc;
        private System.Windows.Forms.ComboBox cmbResponsable;
        private System.Windows.Forms.BindingSource sucursalesBindingSource;
        private System.Windows.Forms.BindingSource sucursalesBindingSource1;
        private DevExpress.XtraGrid.GridControl gcSucursales;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colidSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colidResponsable;
        private DevExpress.XtraGrid.Columns.GridColumn colresponsable;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
    }
}