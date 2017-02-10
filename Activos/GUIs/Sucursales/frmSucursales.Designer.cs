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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombreSuc = new System.Windows.Forms.TextBox();
            this.cmbResponsable = new System.Windows.Forms.ComboBox();
            this.rICheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colseleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidResponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colresponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSucursales = new DevExpress.XtraGrid.GridControl();
            this.sucursalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnElimSelecc = new System.Windows.Forms.Button();
            this.btnActivaS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rICheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSucursales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregar.Location = new System.Drawing.Point(656, 75);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 41);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Tag = "27";
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nueva";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.tbNombreSuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNombreSuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombreSuc.Location = new System.Drawing.Point(164, 53);
            this.tbNombreSuc.Margin = new System.Windows.Forms.Padding(5);
            this.tbNombreSuc.MaxLength = 250;
            this.tbNombreSuc.Name = "tbNombreSuc";
            this.tbNombreSuc.Size = new System.Drawing.Size(482, 30);
            this.tbNombreSuc.TabIndex = 5;
            // 
            // cmbResponsable
            // 
            this.cmbResponsable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResponsable.FormattingEnabled = true;
            this.cmbResponsable.Location = new System.Drawing.Point(164, 102);
            this.cmbResponsable.Margin = new System.Windows.Forms.Padding(5);
            this.cmbResponsable.Name = "cmbResponsable";
            this.cmbResponsable.Size = new System.Drawing.Size(482, 31);
            this.cmbResponsable.TabIndex = 6;
            // 
            // rICheckEdit
            // 
            this.rICheckEdit.Name = "rICheckEdit";
            this.rICheckEdit.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
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
            this.gridView1.GridControl = this.gcSucursales;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
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
            this.colnombre.OptionsColumn.AllowEdit = false;
            this.colnombre.OptionsColumn.AllowMove = false;
            this.colnombre.OptionsColumn.ReadOnly = true;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 350;
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
            this.colresponsable.OptionsColumn.AllowEdit = false;
            this.colresponsable.OptionsColumn.ReadOnly = true;
            this.colresponsable.Visible = true;
            this.colresponsable.VisibleIndex = 2;
            this.colresponsable.Width = 350;
            // 
            // colstatus
            // 
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            // 
            // gcSucursales
            // 
            this.gcSucursales.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gcSucursales.DataSource = this.sucursalesBindingSource;
            this.gcSucursales.Location = new System.Drawing.Point(12, 156);
            this.gcSucursales.MainView = this.gridView1;
            this.gcSucursales.Name = "gcSucursales";
            this.gcSucursales.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rICheckEdit});
            this.gcSucursales.Size = new System.Drawing.Size(788, 365);
            this.gcSucursales.TabIndex = 7;
            this.gcSucursales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcSucursales.DoubleClick += new System.EventHandler(this.gcSucursales_DoubleClick);
            // 
            // sucursalesBindingSource
            // 
            this.sucursalesBindingSource.DataSource = typeof(Activos.Modelos.Sucursales);
            // 
            // btnElimSelecc
            // 
            this.btnElimSelecc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnElimSelecc.Location = new System.Drawing.Point(531, 536);
            this.btnElimSelecc.Name = "btnElimSelecc";
            this.btnElimSelecc.Size = new System.Drawing.Size(250, 39);
            this.btnElimSelecc.TabIndex = 8;
            this.btnElimSelecc.Tag = "29";
            this.btnElimSelecc.Text = "Baja seleccionado (s)";
            this.btnElimSelecc.UseVisualStyleBackColor = true;
            this.btnElimSelecc.Click += new System.EventHandler(this.btnElimSelecc_Click);
            // 
            // btnActivaS
            // 
            this.btnActivaS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActivaS.Location = new System.Drawing.Point(258, 536);
            this.btnActivaS.Name = "btnActivaS";
            this.btnActivaS.Size = new System.Drawing.Size(250, 39);
            this.btnActivaS.TabIndex = 9;
            this.btnActivaS.Tag = "28";
            this.btnActivaS.Text = "A&ctivar Sucursales";
            this.btnActivaS.UseVisualStyleBackColor = true;
            this.btnActivaS.Click += new System.EventHandler(this.btnActivaS_Click);
            // 
            // frmSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(812, 592);
            this.Controls.Add(this.btnActivaS);
            this.Controls.Add(this.btnElimSelecc);
            this.Controls.Add(this.gcSucursales);
            this.Controls.Add(this.cmbResponsable);
            this.Controls.Add(this.tbNombreSuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSucursales";
            this.Text = "Sucursales";
            this.Load += new System.EventHandler(this.frmSucursales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rICheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSucursales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombreSuc;
        private System.Windows.Forms.ComboBox cmbResponsable;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit rICheckEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gcSucursales;
        private System.Windows.Forms.Button btnElimSelecc;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionado;
        private DevExpress.XtraGrid.Columns.GridColumn colidSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colidResponsable;
        private DevExpress.XtraGrid.Columns.GridColumn colresponsable;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private System.Windows.Forms.BindingSource sucursalesBindingSource;
        private System.Windows.Forms.Button btnActivaS;
    }
}