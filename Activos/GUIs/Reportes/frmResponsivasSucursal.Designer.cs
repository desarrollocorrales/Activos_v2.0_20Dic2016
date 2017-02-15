namespace Activos.GUIs.Reportes
{
    partial class frmResponsivasSucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResponsivasSucursal));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbBajas = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbReparaciones = new System.Windows.Forms.CheckBox();
            this.cmbSucursales = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gcResponsivas = new DevExpress.XtraGrid.GridControl();
            this.responsivasSucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidResponsiva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnVistaPrevia = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcResponsivas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsivasSucursalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.cbBajas);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbReparaciones);
            this.groupBox2.Controls.Add(this.cmbSucursales);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 176);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Búsqueda";
            // 
            // cbBajas
            // 
            this.cbBajas.AutoSize = true;
            this.cbBajas.Location = new System.Drawing.Point(118, 82);
            this.cbBajas.Name = "cbBajas";
            this.cbBajas.Size = new System.Drawing.Size(73, 27);
            this.cbBajas.TabIndex = 21;
            this.cbBajas.Text = "Bajas";
            this.cbBajas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sucursal";
            // 
            // cbReparaciones
            // 
            this.cbReparaciones.AutoSize = true;
            this.cbReparaciones.Location = new System.Drawing.Point(231, 82);
            this.cbReparaciones.Name = "cbReparaciones";
            this.cbReparaciones.Size = new System.Drawing.Size(141, 27);
            this.cbReparaciones.TabIndex = 22;
            this.cbReparaciones.Text = "Reparaciones";
            this.cbReparaciones.UseVisualStyleBackColor = true;
            // 
            // cmbSucursales
            // 
            this.cmbSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursales.DropDownWidth = 400;
            this.cmbSucursales.FormattingEnabled = true;
            this.cmbSucursales.Location = new System.Drawing.Point(107, 34);
            this.cmbSucursales.Name = "cmbSucursales";
            this.cmbSucursales.Size = new System.Drawing.Size(367, 31);
            this.cmbSucursales.TabIndex = 11;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(177, 115);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(136, 43);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gcResponsivas
            // 
            this.gcResponsivas.DataSource = this.responsivasSucursalBindingSource;
            this.gcResponsivas.Location = new System.Drawing.Point(12, 194);
            this.gcResponsivas.MainView = this.gridView1;
            this.gcResponsivas.Name = "gcResponsivas";
            this.gcResponsivas.Size = new System.Drawing.Size(491, 218);
            this.gcResponsivas.TabIndex = 27;
            this.gcResponsivas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // responsivasSucursalBindingSource
            // 
            this.responsivasSucursalBindingSource.DataSource = typeof(Activos.Modelos.ResponsivasSucursal);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidPersona,
            this.colidResponsiva,
            this.colidActivo,
            this.colpersona,
            this.colactivo,
            this.coldescripcion,
            this.colestatus});
            this.gridView1.GridControl = this.gcResponsivas;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Responsivas";
            // 
            // colidPersona
            // 
            this.colidPersona.FieldName = "idPersona";
            this.colidPersona.Name = "colidPersona";
            // 
            // colidResponsiva
            // 
            this.colidResponsiva.AppearanceCell.Options.UseTextOptions = true;
            this.colidResponsiva.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colidResponsiva.Caption = "Folio";
            this.colidResponsiva.FieldName = "idResponsiva";
            this.colidResponsiva.Name = "colidResponsiva";
            this.colidResponsiva.OptionsColumn.AllowEdit = false;
            this.colidResponsiva.OptionsColumn.AllowMove = false;
            this.colidResponsiva.OptionsColumn.ReadOnly = true;
            this.colidResponsiva.Visible = true;
            this.colidResponsiva.VisibleIndex = 1;
            this.colidResponsiva.Width = 40;
            // 
            // colidActivo
            // 
            this.colidActivo.FieldName = "idActivo";
            this.colidActivo.Name = "colidActivo";
            // 
            // colpersona
            // 
            this.colpersona.Caption = "Persona";
            this.colpersona.FieldName = "persona";
            this.colpersona.Name = "colpersona";
            this.colpersona.OptionsColumn.AllowEdit = false;
            this.colpersona.OptionsColumn.AllowMove = false;
            this.colpersona.OptionsColumn.ReadOnly = true;
            this.colpersona.Visible = true;
            this.colpersona.VisibleIndex = 0;
            this.colpersona.Width = 94;
            // 
            // colactivo
            // 
            this.colactivo.Caption = "Activo";
            this.colactivo.FieldName = "activo";
            this.colactivo.Name = "colactivo";
            this.colactivo.OptionsColumn.AllowEdit = false;
            this.colactivo.OptionsColumn.AllowMove = false;
            this.colactivo.OptionsColumn.ReadOnly = true;
            this.colactivo.Visible = true;
            this.colactivo.VisibleIndex = 2;
            this.colactivo.Width = 111;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripción";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.OptionsColumn.AllowMove = false;
            this.coldescripcion.OptionsColumn.ReadOnly = true;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 3;
            this.coldescripcion.Width = 111;
            // 
            // colestatus
            // 
            this.colestatus.Caption = "Estatus";
            this.colestatus.FieldName = "estatus";
            this.colestatus.Name = "colestatus";
            this.colestatus.OptionsColumn.AllowEdit = false;
            this.colestatus.OptionsColumn.AllowMove = false;
            this.colestatus.OptionsColumn.ReadOnly = true;
            this.colestatus.Visible = true;
            this.colestatus.VisibleIndex = 4;
            this.colestatus.Width = 117;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.Location = new System.Drawing.Point(302, 428);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(173, 43);
            this.btnVistaPrevia.TabIndex = 28;
            this.btnVistaPrevia.Text = "Vista Previa";
            this.btnVistaPrevia.UseVisualStyleBackColor = true;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // frmResponsivasSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 485);
            this.Controls.Add(this.btnVistaPrevia);
            this.Controls.Add(this.gcResponsivas);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmResponsivasSucursal";
            this.Text = "Responsivas por Sucursal";
            this.Load += new System.EventHandler(this.frmResponsivasSucursal_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcResponsivas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsivasSucursalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSucursales;
        private System.Windows.Forms.Button btnBuscar;
        private DevExpress.XtraGrid.GridControl gcResponsivas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.CheckBox cbBajas;
        private System.Windows.Forms.CheckBox cbReparaciones;
        private System.Windows.Forms.Button btnVistaPrevia;
        private System.Windows.Forms.BindingSource responsivasSucursalBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colidResponsiva;
        private DevExpress.XtraGrid.Columns.GridColumn colidActivo;
        private DevExpress.XtraGrid.Columns.GridColumn colpersona;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colestatus;
    }
}