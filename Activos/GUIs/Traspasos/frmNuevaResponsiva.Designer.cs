namespace Activos.GUIs.Traspasos
{
    partial class frmNuevaResponsiva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevaResponsiva));
            this.tbPuestoT = new System.Windows.Forms.TextBox();
            this.tbSucursalT = new System.Windows.Forms.TextBox();
            this.tbResponsableT = new System.Windows.Forms.TextBox();
            this.gcActivosT = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colseleccionado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidActivo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidArea1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colarea1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidTipo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombreCorto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaAlta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUsuarioAlta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaModificacion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUsuarioModifica1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcosto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumEtiqueta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colclaveActivo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbObservacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcActivosT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPuestoT
            // 
            this.tbPuestoT.Location = new System.Drawing.Point(145, 102);
            this.tbPuestoT.Name = "tbPuestoT";
            this.tbPuestoT.ReadOnly = true;
            this.tbPuestoT.Size = new System.Drawing.Size(349, 30);
            this.tbPuestoT.TabIndex = 36;
            // 
            // tbSucursalT
            // 
            this.tbSucursalT.Location = new System.Drawing.Point(145, 61);
            this.tbSucursalT.Name = "tbSucursalT";
            this.tbSucursalT.ReadOnly = true;
            this.tbSucursalT.Size = new System.Drawing.Size(349, 30);
            this.tbSucursalT.TabIndex = 35;
            // 
            // tbResponsableT
            // 
            this.tbResponsableT.Location = new System.Drawing.Point(145, 20);
            this.tbResponsableT.Name = "tbResponsableT";
            this.tbResponsableT.ReadOnly = true;
            this.tbResponsableT.Size = new System.Drawing.Size(349, 30);
            this.tbResponsableT.TabIndex = 34;
            // 
            // gcActivosT
            // 
            this.gcActivosT.Location = new System.Drawing.Point(12, 150);
            this.gcActivosT.MainView = this.gridView2;
            this.gcActivosT.Name = "gcActivosT";
            this.gcActivosT.Size = new System.Drawing.Size(501, 202);
            this.gcActivosT.TabIndex = 33;
            this.gcActivosT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colseleccionado1,
            this.colidActivo1,
            this.colidArea1,
            this.colarea1,
            this.colidTipo1,
            this.coltipo1,
            this.colnombreCorto1,
            this.coldescripcion1,
            this.colfechaAlta1,
            this.colidUsuarioAlta1,
            this.colfechaModificacion1,
            this.colidUsuarioModifica1,
            this.colcosto1,
            this.colnumEtiqueta1,
            this.colclaveActivo1,
            this.colstatus1});
            this.gridView2.GridControl = this.gcActivosT;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowViewCaption = true;
            this.gridView2.ViewCaption = "Activos";
            // 
            // colseleccionado1
            // 
            this.colseleccionado1.FieldName = "seleccionado";
            this.colseleccionado1.Name = "colseleccionado1";
            this.colseleccionado1.OptionsColumn.AllowEdit = false;
            this.colseleccionado1.OptionsColumn.AllowMove = false;
            this.colseleccionado1.OptionsColumn.ReadOnly = true;
            // 
            // colidActivo1
            // 
            this.colidActivo1.FieldName = "idActivo";
            this.colidActivo1.Name = "colidActivo1";
            this.colidActivo1.OptionsColumn.AllowEdit = false;
            this.colidActivo1.OptionsColumn.AllowMove = false;
            this.colidActivo1.OptionsColumn.ReadOnly = true;
            // 
            // colidArea1
            // 
            this.colidArea1.FieldName = "idArea";
            this.colidArea1.Name = "colidArea1";
            this.colidArea1.OptionsColumn.AllowEdit = false;
            this.colidArea1.OptionsColumn.AllowMove = false;
            this.colidArea1.OptionsColumn.ReadOnly = true;
            // 
            // colarea1
            // 
            this.colarea1.Caption = "Área";
            this.colarea1.FieldName = "area";
            this.colarea1.Name = "colarea1";
            this.colarea1.OptionsColumn.AllowEdit = false;
            this.colarea1.OptionsColumn.AllowMove = false;
            this.colarea1.OptionsColumn.ReadOnly = true;
            this.colarea1.Visible = true;
            this.colarea1.VisibleIndex = 0;
            // 
            // colidTipo1
            // 
            this.colidTipo1.FieldName = "idTipo";
            this.colidTipo1.Name = "colidTipo1";
            this.colidTipo1.OptionsColumn.AllowEdit = false;
            this.colidTipo1.OptionsColumn.AllowMove = false;
            this.colidTipo1.OptionsColumn.ReadOnly = true;
            // 
            // coltipo1
            // 
            this.coltipo1.Caption = "Tipo";
            this.coltipo1.FieldName = "tipo";
            this.coltipo1.Name = "coltipo1";
            this.coltipo1.OptionsColumn.AllowEdit = false;
            this.coltipo1.OptionsColumn.AllowMove = false;
            this.coltipo1.OptionsColumn.ReadOnly = true;
            this.coltipo1.Visible = true;
            this.coltipo1.VisibleIndex = 1;
            // 
            // colnombreCorto1
            // 
            this.colnombreCorto1.Caption = "Activo";
            this.colnombreCorto1.FieldName = "nombreCorto";
            this.colnombreCorto1.Name = "colnombreCorto1";
            this.colnombreCorto1.OptionsColumn.AllowEdit = false;
            this.colnombreCorto1.OptionsColumn.AllowMove = false;
            this.colnombreCorto1.OptionsColumn.ReadOnly = true;
            this.colnombreCorto1.Visible = true;
            this.colnombreCorto1.VisibleIndex = 2;
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.OptionsColumn.AllowEdit = false;
            this.coldescripcion1.OptionsColumn.AllowMove = false;
            this.coldescripcion1.OptionsColumn.ReadOnly = true;
            // 
            // colfechaAlta1
            // 
            this.colfechaAlta1.FieldName = "fechaAlta";
            this.colfechaAlta1.Name = "colfechaAlta1";
            this.colfechaAlta1.OptionsColumn.AllowEdit = false;
            this.colfechaAlta1.OptionsColumn.AllowMove = false;
            this.colfechaAlta1.OptionsColumn.ReadOnly = true;
            // 
            // colidUsuarioAlta1
            // 
            this.colidUsuarioAlta1.FieldName = "idUsuarioAlta";
            this.colidUsuarioAlta1.Name = "colidUsuarioAlta1";
            this.colidUsuarioAlta1.OptionsColumn.AllowEdit = false;
            this.colidUsuarioAlta1.OptionsColumn.AllowMove = false;
            this.colidUsuarioAlta1.OptionsColumn.ReadOnly = true;
            // 
            // colfechaModificacion1
            // 
            this.colfechaModificacion1.FieldName = "fechaModificacion";
            this.colfechaModificacion1.Name = "colfechaModificacion1";
            this.colfechaModificacion1.OptionsColumn.AllowEdit = false;
            this.colfechaModificacion1.OptionsColumn.AllowMove = false;
            this.colfechaModificacion1.OptionsColumn.ReadOnly = true;
            // 
            // colidUsuarioModifica1
            // 
            this.colidUsuarioModifica1.FieldName = "idUsuarioModifica";
            this.colidUsuarioModifica1.Name = "colidUsuarioModifica1";
            this.colidUsuarioModifica1.OptionsColumn.AllowEdit = false;
            this.colidUsuarioModifica1.OptionsColumn.AllowMove = false;
            this.colidUsuarioModifica1.OptionsColumn.ReadOnly = true;
            // 
            // colcosto1
            // 
            this.colcosto1.FieldName = "costo";
            this.colcosto1.Name = "colcosto1";
            this.colcosto1.OptionsColumn.AllowEdit = false;
            this.colcosto1.OptionsColumn.AllowMove = false;
            this.colcosto1.OptionsColumn.ReadOnly = true;
            // 
            // colnumEtiqueta1
            // 
            this.colnumEtiqueta1.Caption = "Núm. Etiqueta";
            this.colnumEtiqueta1.FieldName = "numEtiqueta";
            this.colnumEtiqueta1.Name = "colnumEtiqueta1";
            this.colnumEtiqueta1.OptionsColumn.AllowEdit = false;
            this.colnumEtiqueta1.OptionsColumn.AllowMove = false;
            this.colnumEtiqueta1.OptionsColumn.ReadOnly = true;
            // 
            // colclaveActivo1
            // 
            this.colclaveActivo1.Caption = "Cve. Activo";
            this.colclaveActivo1.FieldName = "claveActivo";
            this.colclaveActivo1.Name = "colclaveActivo1";
            this.colclaveActivo1.OptionsColumn.AllowEdit = false;
            this.colclaveActivo1.OptionsColumn.AllowMove = false;
            this.colclaveActivo1.OptionsColumn.ReadOnly = true;
            // 
            // colstatus1
            // 
            this.colstatus1.FieldName = "status";
            this.colstatus1.Name = "colstatus1";
            this.colstatus1.OptionsColumn.AllowEdit = false;
            this.colstatus1.OptionsColumn.AllowMove = false;
            this.colstatus1.OptionsColumn.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Puesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Sucursal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = "Responsable";
            // 
            // tbObservacion
            // 
            this.tbObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbObservacion.Location = new System.Drawing.Point(12, 396);
            this.tbObservacion.MaxLength = 500;
            this.tbObservacion.Multiline = true;
            this.tbObservacion.Name = "tbObservacion";
            this.tbObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbObservacion.Size = new System.Drawing.Size(501, 92);
            this.tbObservacion.TabIndex = 176;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 23);
            this.label7.TabIndex = 175;
            this.label7.Text = "Observaciones";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(214, 503);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(133, 36);
            this.btnAceptar.TabIndex = 177;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(353, 503);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 36);
            this.btnCancelar.TabIndex = 178;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmNuevaResponsiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(529, 557);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbObservacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPuestoT);
            this.Controls.Add(this.tbSucursalT);
            this.Controls.Add(this.tbResponsableT);
            this.Controls.Add(this.gcActivosT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmNuevaResponsiva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Responsiva para el Traspaso";
            this.Load += new System.EventHandler(this.frmNuevaResponsiva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcActivosT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPuestoT;
        private System.Windows.Forms.TextBox tbSucursalT;
        private System.Windows.Forms.TextBox tbResponsableT;
        private DevExpress.XtraGrid.GridControl gcActivosT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionado1;
        private DevExpress.XtraGrid.Columns.GridColumn colidActivo1;
        private DevExpress.XtraGrid.Columns.GridColumn colidArea1;
        private DevExpress.XtraGrid.Columns.GridColumn colarea1;
        private DevExpress.XtraGrid.Columns.GridColumn colidTipo1;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo1;
        private DevExpress.XtraGrid.Columns.GridColumn colnombreCorto1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaAlta1;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuarioAlta1;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaModificacion1;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuarioModifica1;
        private DevExpress.XtraGrid.Columns.GridColumn colcosto1;
        private DevExpress.XtraGrid.Columns.GridColumn colnumEtiqueta1;
        private DevExpress.XtraGrid.Columns.GridColumn colclaveActivo1;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbObservacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;

    }
}