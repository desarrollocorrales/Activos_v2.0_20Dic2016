namespace Activos.GUIs.Puestos
{
    partial class frmPuestos
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
            this.btnActivaP = new System.Windows.Forms.Button();
            this.btnElimSelecc = new System.Windows.Forms.Button();
            this.gcPuestos = new DevExpress.XtraGrid.GridControl();
            this.puestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidPuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rICheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.tbNombrePuesto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcPuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rICheckEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActivaP
            // 
            this.btnActivaP.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnActivaP.Location = new System.Drawing.Point(198, 526);
            this.btnActivaP.Name = "btnActivaP";
            this.btnActivaP.Size = new System.Drawing.Size(184, 39);
            this.btnActivaP.TabIndex = 18;
            this.btnActivaP.Text = "A&ctivar Puestos";
            this.btnActivaP.UseVisualStyleBackColor = true;
            this.btnActivaP.Click += new System.EventHandler(this.btnActivaP_Click);
            // 
            // btnElimSelecc
            // 
            this.btnElimSelecc.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnElimSelecc.Location = new System.Drawing.Point(388, 526);
            this.btnElimSelecc.Name = "btnElimSelecc";
            this.btnElimSelecc.Size = new System.Drawing.Size(223, 39);
            this.btnElimSelecc.TabIndex = 17;
            this.btnElimSelecc.Text = "&Eliminar seleccionado(s)";
            this.btnElimSelecc.UseVisualStyleBackColor = true;
            this.btnElimSelecc.Click += new System.EventHandler(this.btnElimSelecc_Click);
            // 
            // gcPuestos
            // 
            this.gcPuestos.DataSource = this.puestosBindingSource;
            this.gcPuestos.Location = new System.Drawing.Point(12, 155);
            this.gcPuestos.MainView = this.gridView1;
            this.gcPuestos.Name = "gcPuestos";
            this.gcPuestos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rICheckEdit});
            this.gcPuestos.Size = new System.Drawing.Size(628, 365);
            this.gcPuestos.TabIndex = 16;
            this.gcPuestos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcPuestos.DoubleClick += new System.EventHandler(this.gcPuestos_DoubleClick);
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
            this.gridView1.GridControl = this.gcPuestos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
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
            this.colsucursal.OptionsColumn.AllowEdit = false;
            this.colsucursal.OptionsColumn.AllowMove = false;
            this.colsucursal.OptionsColumn.ReadOnly = true;
            this.colsucursal.Visible = true;
            this.colsucursal.VisibleIndex = 2;
            this.colsucursal.Width = 250;
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
            this.colnombre.Width = 250;
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
            // rICheckEdit
            // 
            this.rICheckEdit.Name = "rICheckEdit";
            this.rICheckEdit.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(131, 101);
            this.cmbSucursal.Margin = new System.Windows.Forms.Padding(5);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(333, 31);
            this.cmbSucursal.TabIndex = 15;
            // 
            // tbNombrePuesto
            // 
            this.tbNombrePuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombrePuesto.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.tbNombrePuesto.Location = new System.Drawing.Point(131, 52);
            this.tbNombrePuesto.Margin = new System.Windows.Forms.Padding(5);
            this.tbNombrePuesto.MaxLength = 250;
            this.tbNombrePuesto.Name = "tbNombrePuesto";
            this.tbNombrePuesto.Size = new System.Drawing.Size(333, 30);
            this.tbNombrePuesto.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label3.Location = new System.Drawing.Point(44, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sucursal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label2.Location = new System.Drawing.Point(44, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nueva";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnAgregar.Location = new System.Drawing.Point(486, 72);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 41);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmPuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 580);
            this.Controls.Add(this.btnActivaP);
            this.Controls.Add(this.btnElimSelecc);
            this.Controls.Add(this.gcPuestos);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.tbNombrePuesto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmPuestos";
            this.Text = "Puestos";
            this.Load += new System.EventHandler(this.frmPuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcPuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rICheckEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActivaP;
        private System.Windows.Forms.Button btnElimSelecc;
        private DevExpress.XtraGrid.GridControl gcPuestos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit rICheckEdit;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.TextBox tbNombrePuesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.BindingSource puestosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidPuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colidSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colsucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionado;
    }
}