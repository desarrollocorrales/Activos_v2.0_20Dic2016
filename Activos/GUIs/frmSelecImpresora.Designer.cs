namespace Activos.GUIs
{
    partial class frmSelecImpresora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelecImpresora));
            this.gcImpresoras = new DevExpress.XtraGrid.GridControl();
            this.impresoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidImpresora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimpresora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualiza = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbImprSelecc = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcImpresoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.impresoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcImpresoras
            // 
            this.gcImpresoras.DataSource = this.impresoraBindingSource;
            this.gcImpresoras.Location = new System.Drawing.Point(12, 130);
            this.gcImpresoras.MainView = this.gridView1;
            this.gcImpresoras.Name = "gcImpresoras";
            this.gcImpresoras.Size = new System.Drawing.Size(509, 273);
            this.gcImpresoras.TabIndex = 0;
            this.gcImpresoras.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // impresoraBindingSource
            // 
            this.impresoraBindingSource.DataSource = typeof(Activos.Modelos.Impresora);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidImpresora,
            this.colimpresora});
            this.gridView1.GridControl = this.gcImpresoras;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Impresoras Detectadas";
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // colidImpresora
            // 
            this.colidImpresora.FieldName = "idImpresora";
            this.colidImpresora.Name = "colidImpresora";
            // 
            // colimpresora
            // 
            this.colimpresora.Caption = "Impresora";
            this.colimpresora.FieldName = "impresora";
            this.colimpresora.Name = "colimpresora";
            this.colimpresora.Visible = true;
            this.colimpresora.VisibleIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(176, 418);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(159, 44);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Seleccionar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualiza
            // 
            this.btnActualiza.Image = ((System.Drawing.Image)(resources.GetObject("btnActualiza.Image")));
            this.btnActualiza.Location = new System.Drawing.Point(301, 10);
            this.btnActualiza.Name = "btnActualiza";
            this.btnActualiza.Size = new System.Drawing.Size(41, 41);
            this.btnActualiza.TabIndex = 2;
            this.btnActualiza.UseVisualStyleBackColor = true;
            this.btnActualiza.Click += new System.EventHandler(this.btnActualiza_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Impresoras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Impresora selecionada actualmente";
            // 
            // tbImprSelecc
            // 
            this.tbImprSelecc.Location = new System.Drawing.Point(12, 88);
            this.tbImprSelecc.Name = "tbImprSelecc";
            this.tbImprSelecc.ReadOnly = true;
            this.tbImprSelecc.Size = new System.Drawing.Size(509, 30);
            this.tbImprSelecc.TabIndex = 5;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(341, 418);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(159, 44);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmSelecImpresora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 479);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.tbImprSelecc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActualiza);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gcImpresoras);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmSelecImpresora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Impresora de Etiquetas";
            this.Load += new System.EventHandler(this.frmSelecImpresora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcImpresoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.impresoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcImpresoras;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualiza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbImprSelecc;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.BindingSource impresoraBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidImpresora;
        private DevExpress.XtraGrid.Columns.GridColumn colimpresora;
    }
}