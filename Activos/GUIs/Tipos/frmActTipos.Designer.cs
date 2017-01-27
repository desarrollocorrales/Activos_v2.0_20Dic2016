namespace Activos.GUIs.Tipos
{
    partial class frmActTipos
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
            this.btnActiva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bntCerrar = new System.Windows.Forms.Button();
            this.gcTipos = new DevExpress.XtraGrid.GridControl();
            this.tiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colseleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmodelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcolor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colserie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActiva
            // 
            this.btnActiva.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnActiva.Location = new System.Drawing.Point(203, 304);
            this.btnActiva.Margin = new System.Windows.Forms.Padding(5);
            this.btnActiva.Name = "btnActiva";
            this.btnActiva.Size = new System.Drawing.Size(174, 51);
            this.btnActiva.TabIndex = 13;
            this.btnActiva.Text = "&Activar";
            this.btnActiva.UseVisualStyleBackColor = true;
            this.btnActiva.Click += new System.EventHandler(this.btnActiva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Activar Tipos";
            // 
            // bntCerrar
            // 
            this.bntCerrar.Font = new System.Drawing.Font("Tahoma", 14F);
            this.bntCerrar.Location = new System.Drawing.Point(387, 304);
            this.bntCerrar.Margin = new System.Windows.Forms.Padding(5);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(174, 51);
            this.bntCerrar.TabIndex = 11;
            this.bntCerrar.Text = "&Cerrar";
            this.bntCerrar.UseVisualStyleBackColor = true;
            this.bntCerrar.Click += new System.EventHandler(this.bntCerrar_Click);
            // 
            // gcTipos
            // 
            this.gcTipos.DataSource = this.tiposBindingSource;
            this.gcTipos.Font = new System.Drawing.Font("Tahoma", 14F);
            this.gcTipos.Location = new System.Drawing.Point(11, 48);
            this.gcTipos.MainView = this.gridView1;
            this.gcTipos.Name = "gcTipos";
            this.gcTipos.Size = new System.Drawing.Size(573, 238);
            this.gcTipos.TabIndex = 14;
            this.gcTipos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tiposBindingSource
            // 
            this.tiposBindingSource.DataSource = typeof(Activos.Modelos.Tipos);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colseleccionado,
            this.colidTipo,
            this.colnombre,
            this.colmarca,
            this.colmodelo,
            this.colcolor,
            this.colserie,
            this.colstatus});
            this.gridView1.GridControl = this.gcTipos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            // colidTipo
            // 
            this.colidTipo.FieldName = "idTipo";
            this.colidTipo.Name = "colidTipo";
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
            // colmarca
            // 
            this.colmarca.AppearanceCell.Options.UseTextOptions = true;
            this.colmarca.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmarca.Caption = "Marca";
            this.colmarca.FieldName = "marca";
            this.colmarca.Name = "colmarca";
            this.colmarca.OptionsColumn.AllowEdit = false;
            this.colmarca.OptionsColumn.AllowMove = false;
            this.colmarca.OptionsColumn.ReadOnly = true;
            this.colmarca.Visible = true;
            this.colmarca.VisibleIndex = 2;
            this.colmarca.Width = 40;
            // 
            // colmodelo
            // 
            this.colmodelo.AppearanceCell.Options.UseTextOptions = true;
            this.colmodelo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmodelo.Caption = "Modelo";
            this.colmodelo.FieldName = "modelo";
            this.colmodelo.Name = "colmodelo";
            this.colmodelo.OptionsColumn.AllowEdit = false;
            this.colmodelo.OptionsColumn.AllowMove = false;
            this.colmodelo.OptionsColumn.ReadOnly = true;
            this.colmodelo.Visible = true;
            this.colmodelo.VisibleIndex = 3;
            this.colmodelo.Width = 45;
            // 
            // colcolor
            // 
            this.colcolor.AppearanceCell.Options.UseTextOptions = true;
            this.colcolor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcolor.Caption = "Color";
            this.colcolor.FieldName = "color";
            this.colcolor.Name = "colcolor";
            this.colcolor.OptionsColumn.AllowEdit = false;
            this.colcolor.OptionsColumn.AllowMove = false;
            this.colcolor.OptionsColumn.ReadOnly = true;
            this.colcolor.Visible = true;
            this.colcolor.VisibleIndex = 4;
            this.colcolor.Width = 40;
            // 
            // colserie
            // 
            this.colserie.AppearanceCell.Options.UseTextOptions = true;
            this.colserie.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colserie.Caption = "Serie";
            this.colserie.FieldName = "serie";
            this.colserie.Name = "colserie";
            this.colserie.OptionsColumn.AllowEdit = false;
            this.colserie.OptionsColumn.AllowMove = false;
            this.colserie.OptionsColumn.ReadOnly = true;
            this.colserie.Visible = true;
            this.colserie.VisibleIndex = 5;
            this.colserie.Width = 40;
            // 
            // colstatus
            // 
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            // 
            // frmActTipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(602, 370);
            this.Controls.Add(this.gcTipos);
            this.Controls.Add(this.btnActiva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntCerrar);
            this.Name = "frmActTipos";
            this.Text = "Activar Tipos";
            this.Load += new System.EventHandler(this.frmActTipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcTipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActiva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntCerrar;
        private DevExpress.XtraGrid.GridControl gcTipos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionado;
        private DevExpress.XtraGrid.Columns.GridColumn colidTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colmarca;
        private DevExpress.XtraGrid.Columns.GridColumn colmodelo;
        private DevExpress.XtraGrid.Columns.GridColumn colcolor;
        private DevExpress.XtraGrid.Columns.GridColumn colserie;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private System.Windows.Forms.BindingSource tiposBindingSource;
    }
}