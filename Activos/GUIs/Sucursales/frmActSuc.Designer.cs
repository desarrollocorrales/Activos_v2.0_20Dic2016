namespace Activos.GUIs.Sucursales
{
    partial class frmActSuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActSuc));
            this.bntCerrar = new System.Windows.Forms.Button();
            this.btnActiva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gcSucursalesBaja = new DevExpress.XtraGrid.GridControl();
            this.sucursalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colseleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidResponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colresponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcSucursalesBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bntCerrar
            // 
            this.bntCerrar.Font = new System.Drawing.Font("Tahoma", 14F);
            this.bntCerrar.Location = new System.Drawing.Point(385, 350);
            this.bntCerrar.Margin = new System.Windows.Forms.Padding(5);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(174, 51);
            this.bntCerrar.TabIndex = 0;
            this.bntCerrar.Text = "&Cerrar";
            this.bntCerrar.UseVisualStyleBackColor = true;
            this.bntCerrar.Click += new System.EventHandler(this.bntCerrar_Click);
            // 
            // btnActiva
            // 
            this.btnActiva.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnActiva.Location = new System.Drawing.Point(201, 350);
            this.btnActiva.Margin = new System.Windows.Forms.Padding(5);
            this.btnActiva.Name = "btnActiva";
            this.btnActiva.Size = new System.Drawing.Size(174, 51);
            this.btnActiva.TabIndex = 5;
            this.btnActiva.Text = "&Activar";
            this.btnActiva.UseVisualStyleBackColor = true;
            this.btnActiva.Click += new System.EventHandler(this.btnActiva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Activar Sucursales";
            // 
            // gcSucursalesBaja
            // 
            this.gcSucursalesBaja.DataSource = this.sucursalesBindingSource;
            this.gcSucursalesBaja.Location = new System.Drawing.Point(12, 75);
            this.gcSucursalesBaja.MainView = this.gridView1;
            this.gcSucursalesBaja.Name = "gcSucursalesBaja";
            this.gcSucursalesBaja.Size = new System.Drawing.Size(563, 267);
            this.gcSucursalesBaja.TabIndex = 6;
            this.gcSucursalesBaja.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sucursalesBindingSource
            // 
            this.sucursalesBindingSource.DataSource = typeof(Modelos.Sucursales);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colseleccionado,
            this.colidSucursal,
            this.colnombre,
            this.colidResponsable,
            this.colresponsable,
            this.colstatus});
            this.gridView1.GridControl = this.gcSucursalesBaja;
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
            // colidSucursal
            // 
            this.colidSucursal.FieldName = "idSucursal";
            this.colidSucursal.Name = "colidSucursal";
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 256;
            // 
            // colidResponsable
            // 
            this.colidResponsable.FieldName = "idResponsable";
            this.colidResponsable.Name = "colidResponsable";
            // 
            // colresponsable
            // 
            this.colresponsable.Caption = "Responsable";
            this.colresponsable.FieldName = "responsable";
            this.colresponsable.Name = "colresponsable";
            this.colresponsable.Visible = true;
            this.colresponsable.VisibleIndex = 2;
            this.colresponsable.Width = 229;
            // 
            // colstatus
            // 
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            // 
            // frmActSuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(587, 415);
            this.Controls.Add(this.gcSucursalesBaja);
            this.Controls.Add(this.btnActiva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntCerrar);
            this.Font = new System.Drawing.Font("Tahoma", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmActSuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activar Sucursales";
            this.Load += new System.EventHandler(this.frmActSuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcSucursalesBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntCerrar;
        private System.Windows.Forms.Button btnActiva;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcSucursalesBaja;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource sucursalesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionado;
        private DevExpress.XtraGrid.Columns.GridColumn colidSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colidResponsable;
        private DevExpress.XtraGrid.Columns.GridColumn colresponsable;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
    }
}