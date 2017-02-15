namespace Activos.GUIs.Areas
{
    partial class frmAreas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAreas));
            this.btnActivaA = new System.Windows.Forms.Button();
            this.btnElimSelecc = new System.Windows.Forms.Button();
            this.gcAreas = new DevExpress.XtraGrid.GridControl();
            this.areasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colseleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rICheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cmbSucursales = new System.Windows.Forms.ComboBox();
            this.tbNombreAreas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcAreas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rICheckEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActivaA
            // 
            this.btnActivaA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActivaA.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnActivaA.Location = new System.Drawing.Point(131, 536);
            this.btnActivaA.Name = "btnActivaA";
            this.btnActivaA.Size = new System.Drawing.Size(250, 39);
            this.btnActivaA.TabIndex = 18;
            this.btnActivaA.Tag = "34";
            this.btnActivaA.Text = "A&ctivar Áreas";
            this.btnActivaA.UseVisualStyleBackColor = true;
            this.btnActivaA.Click += new System.EventHandler(this.btnActivaA_Click);
            // 
            // btnElimSelecc
            // 
            this.btnElimSelecc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnElimSelecc.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnElimSelecc.Location = new System.Drawing.Point(404, 536);
            this.btnElimSelecc.Name = "btnElimSelecc";
            this.btnElimSelecc.Size = new System.Drawing.Size(250, 39);
            this.btnElimSelecc.TabIndex = 17;
            this.btnElimSelecc.Tag = "35";
            this.btnElimSelecc.Text = "Baja seleccionado (s)";
            this.btnElimSelecc.UseVisualStyleBackColor = true;
            this.btnElimSelecc.Click += new System.EventHandler(this.btnElimSelecc_Click);
            // 
            // gcAreas
            // 
            this.gcAreas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gcAreas.DataSource = this.areasBindingSource;
            this.gcAreas.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.gcAreas.Location = new System.Drawing.Point(12, 149);
            this.gcAreas.MainView = this.gridView1;
            this.gcAreas.Name = "gcAreas";
            this.gcAreas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rICheckEdit});
            this.gcAreas.Size = new System.Drawing.Size(657, 365);
            this.gcAreas.TabIndex = 16;
            this.gcAreas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcAreas.DoubleClick += new System.EventHandler(this.gcAreas_DoubleClick);
            // 
            // areasBindingSource
            // 
            this.areasBindingSource.DataSource = typeof(Activos.Modelos.Areas);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colseleccionado,
            this.colidArea,
            this.colidSucursal,
            this.colsucursal,
            this.colnombre,
            this.colstatus});
            this.gridView1.GridControl = this.gcAreas;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
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
            // colidArea
            // 
            this.colidArea.FieldName = "idArea";
            this.colidArea.Name = "colidArea";
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
            this.colsucursal.OptionsColumn.AllowEdit = false;
            this.colsucursal.OptionsColumn.AllowMove = false;
            this.colsucursal.OptionsColumn.ReadOnly = true;
            this.colsucursal.Visible = true;
            this.colsucursal.VisibleIndex = 2;
            this.colsucursal.Width = 300;
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
            this.colnombre.Width = 300;
            // 
            // colstatus
            // 
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            // 
            // rICheckEdit
            // 
            this.rICheckEdit.Name = "rICheckEdit";
            this.rICheckEdit.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // cmbSucursales
            // 
            this.cmbSucursales.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursales.DropDownWidth = 400;
            this.cmbSucursales.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.cmbSucursales.FormattingEnabled = true;
            this.cmbSucursales.Location = new System.Drawing.Point(131, 95);
            this.cmbSucursales.Margin = new System.Windows.Forms.Padding(5);
            this.cmbSucursales.Name = "cmbSucursales";
            this.cmbSucursales.Size = new System.Drawing.Size(378, 31);
            this.cmbSucursales.TabIndex = 15;
            // 
            // tbNombreAreas
            // 
            this.tbNombreAreas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNombreAreas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombreAreas.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.tbNombreAreas.Location = new System.Drawing.Point(131, 46);
            this.tbNombreAreas.Margin = new System.Windows.Forms.Padding(5);
            this.tbNombreAreas.MaxLength = 250;
            this.tbNombreAreas.Name = "tbNombreAreas";
            this.tbNombreAreas.Size = new System.Drawing.Size(378, 30);
            this.tbNombreAreas.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label3.Location = new System.Drawing.Point(44, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sucursal";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label2.Location = new System.Drawing.Point(44, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nueva";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregar.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnAgregar.Location = new System.Drawing.Point(529, 66);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 41);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Tag = "33";
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(680, 587);
            this.Controls.Add(this.btnActivaA);
            this.Controls.Add(this.btnElimSelecc);
            this.Controls.Add(this.gcAreas);
            this.Controls.Add(this.cmbSucursales);
            this.Controls.Add(this.tbNombreAreas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAreas";
            this.Text = "Áreas";
            this.Load += new System.EventHandler(this.frmAreas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcAreas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rICheckEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActivaA;
        private System.Windows.Forms.Button btnElimSelecc;
        private DevExpress.XtraGrid.GridControl gcAreas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit rICheckEdit;
        private System.Windows.Forms.ComboBox cmbSucursales;
        private System.Windows.Forms.TextBox tbNombreAreas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.BindingSource areasBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionado;
        private DevExpress.XtraGrid.Columns.GridColumn colidArea;
        private DevExpress.XtraGrid.Columns.GridColumn colidSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colsucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
    }
}