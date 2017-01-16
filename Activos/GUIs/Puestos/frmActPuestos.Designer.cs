namespace Activos.GUIs.Puestos
{
    partial class frmActPuestos
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
            this.gcPuestosBaja = new DevExpress.XtraGrid.GridControl();
            this.puestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidPuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnActiva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bntCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcPuestosBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcPuestosBaja
            // 
            this.gcPuestosBaja.DataSource = this.puestosBindingSource;
            this.gcPuestosBaja.Location = new System.Drawing.Point(10, 74);
            this.gcPuestosBaja.MainView = this.gridView1;
            this.gcPuestosBaja.Name = "gcPuestosBaja";
            this.gcPuestosBaja.Size = new System.Drawing.Size(563, 267);
            this.gcPuestosBaja.TabIndex = 10;
            this.gcPuestosBaja.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // puestosBindingSource
            // 
            this.puestosBindingSource.DataSource = typeof(Activos.Modelos.Puestos);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidPuesto,
            this.colidSucursal,
            this.colsucursal,
            this.colnombre,
            this.colstatus,
            this.colseleccionado});
            this.gridView1.GridControl = this.gcPuestosBaja;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colidPuesto
            // 
            this.colidPuesto.FieldName = "idPuesto";
            this.colidPuesto.Name = "colidPuesto";
            // 
            // colidSucursal
            // 
            this.colidSucursal.FieldName = "idSucursal";
            this.colidSucursal.Name = "colidSucursal";
            // 
            // colsucursal
            // 
            this.colsucursal.Caption = "Sucursal";
            this.colsucursal.FieldName = "sucursal";
            this.colsucursal.Name = "colsucursal";
            this.colsucursal.Visible = true;
            this.colsucursal.VisibleIndex = 2;
            this.colsucursal.Width = 200;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 300;
            // 
            // colstatus
            // 
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
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
            // btnActiva
            // 
            this.btnActiva.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnActiva.Location = new System.Drawing.Point(199, 349);
            this.btnActiva.Margin = new System.Windows.Forms.Padding(5);
            this.btnActiva.Name = "btnActiva";
            this.btnActiva.Size = new System.Drawing.Size(174, 51);
            this.btnActiva.TabIndex = 9;
            this.btnActiva.Text = "&Activar";
            this.btnActiva.UseVisualStyleBackColor = true;
            this.btnActiva.Click += new System.EventHandler(this.btnActiva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Activar Puestos";
            // 
            // bntCerrar
            // 
            this.bntCerrar.Font = new System.Drawing.Font("Tahoma", 14F);
            this.bntCerrar.Location = new System.Drawing.Point(383, 349);
            this.bntCerrar.Margin = new System.Windows.Forms.Padding(5);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(174, 51);
            this.bntCerrar.TabIndex = 7;
            this.bntCerrar.Text = "&Cerrar";
            this.bntCerrar.UseVisualStyleBackColor = true;
            this.bntCerrar.Click += new System.EventHandler(this.bntCerrar_Click);
            // 
            // frmActPuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 419);
            this.Controls.Add(this.gcPuestosBaja);
            this.Controls.Add(this.btnActiva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmActPuestos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmActPuestos";
            this.Load += new System.EventHandler(this.frmActPuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcPuestosBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcPuestosBaja;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnActiva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntCerrar;
        private System.Windows.Forms.BindingSource puestosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidPuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colidSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colsucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionado;
    }
}