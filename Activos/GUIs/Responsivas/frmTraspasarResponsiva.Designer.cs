﻿namespace Activos.GUIs.Responsivas
{
    partial class frmTraspasarResponsiva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraspasarResponsiva));
            this.tbPuesto = new System.Windows.Forms.TextBox();
            this.tbSucursal = new System.Windows.Forms.TextBox();
            this.tbResponsable = new System.Windows.Forms.TextBox();
            this.gcActivos = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colseleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colarea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombreCorto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaAlta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUsuarioAlta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUsuarioModifica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumEtiqueta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colclaveActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscaResponsiva = new System.Windows.Forms.Button();
            this.btnAplicaTraspaso = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMotivo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPuestoT = new System.Windows.Forms.TextBox();
            this.tbSucursalT = new System.Windows.Forms.TextBox();
            this.tbResponsableT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscaUsuario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBusFolio = new System.Windows.Forms.Button();
            this.tbFolio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCambiaResp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPuesto
            // 
            this.tbPuesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPuesto.Location = new System.Drawing.Point(133, 95);
            this.tbPuesto.Name = "tbPuesto";
            this.tbPuesto.ReadOnly = true;
            this.tbPuesto.Size = new System.Drawing.Size(363, 30);
            this.tbPuesto.TabIndex = 21;
            // 
            // tbSucursal
            // 
            this.tbSucursal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSucursal.Location = new System.Drawing.Point(133, 54);
            this.tbSucursal.Name = "tbSucursal";
            this.tbSucursal.ReadOnly = true;
            this.tbSucursal.Size = new System.Drawing.Size(363, 30);
            this.tbSucursal.TabIndex = 20;
            // 
            // tbResponsable
            // 
            this.tbResponsable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbResponsable.Location = new System.Drawing.Point(133, 13);
            this.tbResponsable.Name = "tbResponsable";
            this.tbResponsable.ReadOnly = true;
            this.tbResponsable.Size = new System.Drawing.Size(363, 30);
            this.tbResponsable.TabIndex = 19;
            // 
            // gcActivos
            // 
            this.gcActivos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gcActivos.Location = new System.Drawing.Point(11, 258);
            this.gcActivos.MainView = this.gridView1;
            this.gcActivos.Name = "gcActivos";
            this.gcActivos.Size = new System.Drawing.Size(705, 147);
            this.gcActivos.TabIndex = 18;
            this.gcActivos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colseleccionado,
            this.colidActivo,
            this.colidArea,
            this.colarea,
            this.colidTipo,
            this.coltipo,
            this.colnombreCorto,
            this.coldescripcion,
            this.colfechaAlta,
            this.colidUsuarioAlta,
            this.colfechaModificacion,
            this.colidUsuarioModifica,
            this.colcosto,
            this.colnumEtiqueta,
            this.colclaveActivo,
            this.colstatus});
            this.gridView1.GridControl = this.gcActivos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Activos";
            // 
            // colseleccionado
            // 
            this.colseleccionado.Caption = " ";
            this.colseleccionado.FieldName = "seleccionado";
            this.colseleccionado.Name = "colseleccionado";
            this.colseleccionado.Width = 30;
            // 
            // colidActivo
            // 
            this.colidActivo.FieldName = "idActivo";
            this.colidActivo.Name = "colidActivo";
            // 
            // colidArea
            // 
            this.colidArea.FieldName = "idArea";
            this.colidArea.Name = "colidArea";
            // 
            // colarea
            // 
            this.colarea.Caption = "Área";
            this.colarea.FieldName = "area";
            this.colarea.Name = "colarea";
            this.colarea.OptionsColumn.AllowEdit = false;
            this.colarea.OptionsColumn.AllowMove = false;
            this.colarea.OptionsColumn.ReadOnly = true;
            this.colarea.Visible = true;
            this.colarea.VisibleIndex = 0;
            this.colarea.Width = 109;
            // 
            // colidTipo
            // 
            this.colidTipo.FieldName = "idTipo";
            this.colidTipo.Name = "colidTipo";
            // 
            // coltipo
            // 
            this.coltipo.Caption = "Tipo";
            this.coltipo.FieldName = "tipo";
            this.coltipo.Name = "coltipo";
            this.coltipo.OptionsColumn.AllowEdit = false;
            this.coltipo.OptionsColumn.AllowMove = false;
            this.coltipo.OptionsColumn.ReadOnly = true;
            this.coltipo.Visible = true;
            this.coltipo.VisibleIndex = 1;
            this.coltipo.Width = 109;
            // 
            // colnombreCorto
            // 
            this.colnombreCorto.Caption = "Activo";
            this.colnombreCorto.FieldName = "nombreCorto";
            this.colnombreCorto.Name = "colnombreCorto";
            this.colnombreCorto.OptionsColumn.AllowEdit = false;
            this.colnombreCorto.OptionsColumn.AllowMove = false;
            this.colnombreCorto.OptionsColumn.ReadOnly = true;
            this.colnombreCorto.Visible = true;
            this.colnombreCorto.VisibleIndex = 2;
            this.colnombreCorto.Width = 109;
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Width = 109;
            // 
            // colfechaAlta
            // 
            this.colfechaAlta.FieldName = "fechaAlta";
            this.colfechaAlta.Name = "colfechaAlta";
            // 
            // colidUsuarioAlta
            // 
            this.colidUsuarioAlta.FieldName = "idUsuarioAlta";
            this.colidUsuarioAlta.Name = "colidUsuarioAlta";
            // 
            // colfechaModificacion
            // 
            this.colfechaModificacion.FieldName = "fechaModificacion";
            this.colfechaModificacion.Name = "colfechaModificacion";
            // 
            // colidUsuarioModifica
            // 
            this.colidUsuarioModifica.FieldName = "idUsuarioModifica";
            this.colidUsuarioModifica.Name = "colidUsuarioModifica";
            // 
            // colcosto
            // 
            this.colcosto.FieldName = "costo";
            this.colcosto.Name = "colcosto";
            // 
            // colnumEtiqueta
            // 
            this.colnumEtiqueta.Caption = "Núm. Etiqueta";
            this.colnumEtiqueta.FieldName = "numEtiqueta";
            this.colnumEtiqueta.Name = "colnumEtiqueta";
            this.colnumEtiqueta.OptionsColumn.AllowEdit = false;
            this.colnumEtiqueta.OptionsColumn.AllowMove = false;
            this.colnumEtiqueta.OptionsColumn.ReadOnly = true;
            this.colnumEtiqueta.Visible = true;
            this.colnumEtiqueta.VisibleIndex = 3;
            this.colnumEtiqueta.Width = 109;
            // 
            // colclaveActivo
            // 
            this.colclaveActivo.Caption = "Cve. Activo";
            this.colclaveActivo.FieldName = "claveActivo";
            this.colclaveActivo.Name = "colclaveActivo";
            this.colclaveActivo.OptionsColumn.AllowEdit = false;
            this.colclaveActivo.OptionsColumn.AllowMove = false;
            this.colclaveActivo.OptionsColumn.ReadOnly = true;
            this.colclaveActivo.Visible = true;
            this.colclaveActivo.VisibleIndex = 4;
            this.colclaveActivo.Width = 112;
            // 
            // colstatus
            // 
            this.colstatus.Caption = "Estatus";
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            this.colstatus.Visible = true;
            this.colstatus.VisibleIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Puesto";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Sucursal";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Responsable";
            // 
            // btnBuscaResponsiva
            // 
            this.btnBuscaResponsiva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscaResponsiva.Location = new System.Drawing.Point(519, 49);
            this.btnBuscaResponsiva.Name = "btnBuscaResponsiva";
            this.btnBuscaResponsiva.Size = new System.Drawing.Size(198, 43);
            this.btnBuscaResponsiva.TabIndex = 14;
            this.btnBuscaResponsiva.Text = "Buscar Responsiva";
            this.btnBuscaResponsiva.UseVisualStyleBackColor = true;
            this.btnBuscaResponsiva.Click += new System.EventHandler(this.btnBuscaResponsiva_Click);
            // 
            // btnAplicaTraspaso
            // 
            this.btnAplicaTraspaso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAplicaTraspaso.Location = new System.Drawing.Point(502, 731);
            this.btnAplicaTraspaso.Name = "btnAplicaTraspaso";
            this.btnAplicaTraspaso.Size = new System.Drawing.Size(187, 43);
            this.btnAplicaTraspaso.TabIndex = 22;
            this.btnAplicaTraspaso.Text = "Aplicar Traspaso";
            this.btnAplicaTraspaso.UseVisualStyleBackColor = true;
            this.btnAplicaTraspaso.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 591);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Motivo";
            // 
            // tbMotivo
            // 
            this.tbMotivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbMotivo.Location = new System.Drawing.Point(12, 617);
            this.tbMotivo.MaxLength = 500;
            this.tbMotivo.Multiline = true;
            this.tbMotivo.Name = "tbMotivo";
            this.tbMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMotivo.Size = new System.Drawing.Size(705, 92);
            this.tbMotivo.TabIndex = 177;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.tbPuestoT);
            this.groupBox1.Controls.Add(this.tbSucursalT);
            this.groupBox1.Controls.Add(this.tbResponsableT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnBuscaUsuario);
            this.groupBox1.Location = new System.Drawing.Point(12, 411);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 164);
            this.groupBox1.TabIndex = 178;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Persona Traspaso";
            // 
            // tbPuestoT
            // 
            this.tbPuestoT.Location = new System.Drawing.Point(95, 112);
            this.tbPuestoT.Name = "tbPuestoT";
            this.tbPuestoT.ReadOnly = true;
            this.tbPuestoT.Size = new System.Drawing.Size(405, 30);
            this.tbPuestoT.TabIndex = 29;
            // 
            // tbSucursalT
            // 
            this.tbSucursalT.Location = new System.Drawing.Point(95, 76);
            this.tbSucursalT.Name = "tbSucursalT";
            this.tbSucursalT.ReadOnly = true;
            this.tbSucursalT.Size = new System.Drawing.Size(405, 30);
            this.tbSucursalT.TabIndex = 28;
            // 
            // tbResponsableT
            // 
            this.tbResponsableT.Location = new System.Drawing.Point(95, 40);
            this.tbResponsableT.Name = "tbResponsableT";
            this.tbResponsableT.ReadOnly = true;
            this.tbResponsableT.Size = new System.Drawing.Size(405, 30);
            this.tbResponsableT.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Puesto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Sucursal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 23;
            this.label7.Text = "Persona";
            // 
            // btnBuscaUsuario
            // 
            this.btnBuscaUsuario.Location = new System.Drawing.Point(525, 69);
            this.btnBuscaUsuario.Name = "btnBuscaUsuario";
            this.btnBuscaUsuario.Size = new System.Drawing.Size(163, 43);
            this.btnBuscaUsuario.TabIndex = 22;
            this.btnBuscaUsuario.Text = "Buscar Persona";
            this.btnBuscaUsuario.UseVisualStyleBackColor = true;
            this.btnBuscaUsuario.Click += new System.EventHandler(this.btnBuscaUsuario_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnBusFolio);
            this.panel1.Controls.Add(this.tbFolio);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(25, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 100);
            this.panel1.TabIndex = 179;
            // 
            // btnBusFolio
            // 
            this.btnBusFolio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBusFolio.Location = new System.Drawing.Point(460, 30);
            this.btnBusFolio.Name = "btnBusFolio";
            this.btnBusFolio.Size = new System.Drawing.Size(198, 43);
            this.btnBusFolio.TabIndex = 28;
            this.btnBusFolio.Text = "Buscar por Folio";
            this.btnBusFolio.UseVisualStyleBackColor = true;
            this.btnBusFolio.Click += new System.EventHandler(this.btnBusFolio_Click);
            // 
            // tbFolio
            // 
            this.tbFolio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbFolio.Location = new System.Drawing.Point(74, 37);
            this.tbFolio.Name = "tbFolio";
            this.tbFolio.Size = new System.Drawing.Size(363, 30);
            this.tbFolio.TabIndex = 27;
            this.tbFolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFolio_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = "Folio";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Location = new System.Drawing.Point(309, 731);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(187, 43);
            this.btnCancelar.TabIndex = 180;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCambiaResp
            // 
            this.btnCambiaResp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCambiaResp.Location = new System.Drawing.Point(519, 95);
            this.btnCambiaResp.Name = "btnCambiaResp";
            this.btnCambiaResp.Size = new System.Drawing.Size(198, 43);
            this.btnCambiaResp.TabIndex = 181;
            this.btnCambiaResp.Text = "Cambiar Responsiva";
            this.btnCambiaResp.UseVisualStyleBackColor = true;
            this.btnCambiaResp.Visible = false;
            this.btnCambiaResp.Click += new System.EventHandler(this.btnCambiaResp_Click);
            // 
            // frmTraspasarResponsiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(728, 790);
            this.Controls.Add(this.btnCambiaResp);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbMotivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAplicaTraspaso);
            this.Controls.Add(this.tbPuesto);
            this.Controls.Add(this.tbSucursal);
            this.Controls.Add(this.tbResponsable);
            this.Controls.Add(this.gcActivos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscaResponsiva);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmTraspasarResponsiva";
            this.Text = "Traspasar Responsiva";
            ((System.ComponentModel.ISupportInitialize)(this.gcActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPuesto;
        private System.Windows.Forms.TextBox tbSucursal;
        private System.Windows.Forms.TextBox tbResponsable;
        private DevExpress.XtraGrid.GridControl gcActivos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionado;
        private DevExpress.XtraGrid.Columns.GridColumn colidActivo;
        private DevExpress.XtraGrid.Columns.GridColumn colidArea;
        private DevExpress.XtraGrid.Columns.GridColumn colarea;
        private DevExpress.XtraGrid.Columns.GridColumn colidTipo;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo;
        private DevExpress.XtraGrid.Columns.GridColumn colnombreCorto;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaAlta;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuarioAlta;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuarioModifica;
        private DevExpress.XtraGrid.Columns.GridColumn colcosto;
        private DevExpress.XtraGrid.Columns.GridColumn colnumEtiqueta;
        private DevExpress.XtraGrid.Columns.GridColumn colclaveActivo;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscaResponsiva;
        private System.Windows.Forms.Button btnAplicaTraspaso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMotivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPuestoT;
        private System.Windows.Forms.TextBox tbResponsableT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscaUsuario;
        private System.Windows.Forms.TextBox tbSucursalT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBusFolio;
        private System.Windows.Forms.TextBox tbFolio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCambiaResp;
    }
}