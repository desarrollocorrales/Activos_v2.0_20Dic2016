namespace Activos.GUIs.Tipos
{
    partial class frmTipos
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
            this.btnActivar = new System.Windows.Forms.Button();
            this.btnElimSel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSerie = new System.Windows.Forms.CheckBox();
            this.cbColor = new System.Windows.Forms.CheckBox();
            this.cbModelo = new System.Windows.Forms.CheckBox();
            this.cbMarca = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNombreTipo = new System.Windows.Forms.TextBox();
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActivar
            // 
            this.btnActivar.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnActivar.Location = new System.Drawing.Point(100, 490);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(186, 41);
            this.btnActivar.TabIndex = 0;
            this.btnActivar.Text = "Activar Tipos";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // btnElimSel
            // 
            this.btnElimSel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnElimSel.Location = new System.Drawing.Point(295, 490);
            this.btnElimSel.Name = "btnElimSel";
            this.btnElimSel.Size = new System.Drawing.Size(239, 41);
            this.btnElimSel.TabIndex = 1;
            this.btnElimSel.Text = "Eliminar seleccionado(s)";
            this.btnElimSel.UseVisualStyleBackColor = true;
            this.btnElimSel.Click += new System.EventHandler(this.btnElimSel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSerie);
            this.groupBox1.Controls.Add(this.cbColor);
            this.groupBox1.Controls.Add(this.cbModelo);
            this.groupBox1.Controls.Add(this.cbMarca);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox1.Location = new System.Drawing.Point(27, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 103);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obligatorios";
            // 
            // cbSerie
            // 
            this.cbSerie.AutoSize = true;
            this.cbSerie.Font = new System.Drawing.Font("Tahoma", 16F);
            this.cbSerie.Location = new System.Drawing.Point(346, 44);
            this.cbSerie.Name = "cbSerie";
            this.cbSerie.Size = new System.Drawing.Size(139, 31);
            this.cbSerie.TabIndex = 7;
            this.cbSerie.Text = "Núm. Serie";
            this.cbSerie.UseVisualStyleBackColor = true;
            // 
            // cbColor
            // 
            this.cbColor.AutoSize = true;
            this.cbColor.Font = new System.Drawing.Font("Tahoma", 16F);
            this.cbColor.Location = new System.Drawing.Point(245, 44);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(81, 31);
            this.cbColor.TabIndex = 6;
            this.cbColor.Text = "Color";
            this.cbColor.UseVisualStyleBackColor = true;
            // 
            // cbModelo
            // 
            this.cbModelo.AutoSize = true;
            this.cbModelo.Font = new System.Drawing.Font("Tahoma", 16F);
            this.cbModelo.Location = new System.Drawing.Point(121, 44);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(101, 31);
            this.cbModelo.TabIndex = 5;
            this.cbModelo.Text = "Modelo";
            this.cbModelo.UseVisualStyleBackColor = true;
            // 
            // cbMarca
            // 
            this.cbMarca.AutoSize = true;
            this.cbMarca.Font = new System.Drawing.Font("Tahoma", 16F);
            this.cbMarca.Location = new System.Drawing.Point(15, 44);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(90, 31);
            this.cbMarca.TabIndex = 4;
            this.cbMarca.Text = "Marca";
            this.cbMarca.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label5.Location = new System.Drawing.Point(12, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre";
            // 
            // tbNombreTipo
            // 
            this.tbNombreTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombreTipo.Font = new System.Drawing.Font("Tahoma", 14F);
            this.tbNombreTipo.Location = new System.Drawing.Point(102, 21);
            this.tbNombreTipo.MaxLength = 250;
            this.tbNombreTipo.Name = "tbNombreTipo";
            this.tbNombreTipo.Size = new System.Drawing.Size(449, 30);
            this.tbNombreTipo.TabIndex = 4;
            // 
            // gcTipos
            // 
            this.gcTipos.DataSource = this.tiposBindingSource;
            this.gcTipos.Font = new System.Drawing.Font("Tahoma", 14F);
            this.gcTipos.Location = new System.Drawing.Point(16, 233);
            this.gcTipos.MainView = this.gridView1;
            this.gcTipos.Name = "gcTipos";
            this.gcTipos.Size = new System.Drawing.Size(535, 242);
            this.gcTipos.TabIndex = 5;
            this.gcTipos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcTipos.DoubleClick += new System.EventHandler(this.gcTipos_DoubleClick);
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
            this.colseleccionado.Width = 33;
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
            this.colnombre.Width = 310;
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
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(190, 176);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(186, 41);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmTipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 550);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gcTipos);
            this.Controls.Add(this.tbNombreTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnElimSel);
            this.Controls.Add(this.btnActivar);
            this.Name = "frmTipos";
            this.Text = "Tipos";
            this.Load += new System.EventHandler(this.frmTipos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Button btnElimSel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbSerie;
        private System.Windows.Forms.CheckBox cbColor;
        private System.Windows.Forms.CheckBox cbModelo;
        private System.Windows.Forms.CheckBox cbMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNombreTipo;
        private DevExpress.XtraGrid.GridControl gcTipos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.BindingSource tiposBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionado;
        private DevExpress.XtraGrid.Columns.GridColumn colidTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colmarca;
        private DevExpress.XtraGrid.Columns.GridColumn colmodelo;
        private DevExpress.XtraGrid.Columns.GridColumn colcolor;
        private DevExpress.XtraGrid.Columns.GridColumn colserie;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
    }
}