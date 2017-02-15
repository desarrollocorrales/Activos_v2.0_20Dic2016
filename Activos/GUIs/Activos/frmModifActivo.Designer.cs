namespace Activos.GUIs.AltaActivos
{
    partial class frmModifActivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifActivo));
            this.btnBusqAct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbNumetiqueta = new System.Windows.Forms.Label();
            this.lbCveActivo = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.tbSucursal = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.tbNumSerie = new System.Windows.Forms.TextBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lColor = new System.Windows.Forms.Label();
            this.lNumSerie = new System.Windows.Forms.Label();
            this.lModelo = new System.Windows.Forms.Label();
            this.lMarca = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbFactura = new System.Windows.Forms.TextBox();
            this.tbCosto = new System.Windows.Forms.TextBox();
            this.lbFactura = new System.Windows.Forms.Label();
            this.lbCosto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnBusqAct
            // 
            this.btnBusqAct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBusqAct.Location = new System.Drawing.Point(561, 81);
            this.btnBusqAct.Name = "btnBusqAct";
            this.btnBusqAct.Size = new System.Drawing.Size(242, 38);
            this.btnBusqAct.TabIndex = 1;
            this.btnBusqAct.Text = "Búsqueda de Activo";
            this.btnBusqAct.UseVisualStyleBackColor = true;
            this.btnBusqAct.Click += new System.EventHandler(this.btnBusqAct_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sucursal";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Núm. Etiqueta";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(480, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "Clave Activo";
            // 
            // lbNumetiqueta
            // 
            this.lbNumetiqueta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNumetiqueta.AutoSize = true;
            this.lbNumetiqueta.Location = new System.Drawing.Point(299, 188);
            this.lbNumetiqueta.Name = "lbNumetiqueta";
            this.lbNumetiqueta.Size = new System.Drawing.Size(140, 23);
            this.lbNumetiqueta.TabIndex = 10;
            this.lbNumetiqueta.Text = "0000000000000";
            // 
            // lbCveActivo
            // 
            this.lbCveActivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCveActivo.AutoSize = true;
            this.lbCveActivo.Location = new System.Drawing.Point(595, 188);
            this.lbCveActivo.Name = "lbCveActivo";
            this.lbCveActivo.Size = new System.Drawing.Size(70, 23);
            this.lbCveActivo.TabIndex = 11;
            this.lbCveActivo.Text = "000000";
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombre.Location = new System.Drawing.Point(115, 29);
            this.tbNombre.MaxLength = 40;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ReadOnly = true;
            this.tbNombre.Size = new System.Drawing.Size(420, 30);
            this.tbNombre.TabIndex = 12;
            // 
            // tbTipo
            // 
            this.tbTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTipo.Location = new System.Drawing.Point(115, 65);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.ReadOnly = true;
            this.tbTipo.Size = new System.Drawing.Size(420, 30);
            this.tbTipo.TabIndex = 13;
            // 
            // tbSucursal
            // 
            this.tbSucursal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSucursal.Location = new System.Drawing.Point(115, 101);
            this.tbSucursal.Name = "tbSucursal";
            this.tbSucursal.ReadOnly = true;
            this.tbSucursal.Size = new System.Drawing.Size(420, 30);
            this.tbSucursal.TabIndex = 14;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDescripcion.Location = new System.Drawing.Point(286, 401);
            this.tbDescripcion.MaxLength = 500;
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.ReadOnly = true;
            this.tbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescripcion.Size = new System.Drawing.Size(516, 102);
            this.tbDescripcion.TabIndex = 122;
            // 
            // tbColor
            // 
            this.tbColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbColor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbColor.Location = new System.Drawing.Point(25, 329);
            this.tbColor.MaxLength = 70;
            this.tbColor.Name = "tbColor";
            this.tbColor.ReadOnly = true;
            this.tbColor.Size = new System.Drawing.Size(256, 30);
            this.tbColor.TabIndex = 119;
            // 
            // tbNumSerie
            // 
            this.tbNumSerie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNumSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNumSerie.Location = new System.Drawing.Point(547, 258);
            this.tbNumSerie.MaxLength = 70;
            this.tbNumSerie.Name = "tbNumSerie";
            this.tbNumSerie.ReadOnly = true;
            this.tbNumSerie.Size = new System.Drawing.Size(255, 30);
            this.tbNumSerie.TabIndex = 118;
            // 
            // tbModelo
            // 
            this.tbModelo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbModelo.Location = new System.Drawing.Point(286, 258);
            this.tbModelo.MaxLength = 70;
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.ReadOnly = true;
            this.tbModelo.Size = new System.Drawing.Size(255, 30);
            this.tbModelo.TabIndex = 117;
            // 
            // tbMarca
            // 
            this.tbMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbMarca.Location = new System.Drawing.Point(25, 258);
            this.tbMarca.MaxLength = 70;
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.ReadOnly = true;
            this.tbMarca.Size = new System.Drawing.Size(255, 30);
            this.tbMarca.TabIndex = 116;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 23);
            this.label7.TabIndex = 113;
            this.label7.Text = "Descripción";
            // 
            // lColor
            // 
            this.lColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lColor.AutoSize = true;
            this.lColor.Location = new System.Drawing.Point(40, 303);
            this.lColor.Name = "lColor";
            this.lColor.Size = new System.Drawing.Size(52, 23);
            this.lColor.TabIndex = 112;
            this.lColor.Text = "Color";
            // 
            // lNumSerie
            // 
            this.lNumSerie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lNumSerie.AutoSize = true;
            this.lNumSerie.Location = new System.Drawing.Point(562, 232);
            this.lNumSerie.Name = "lNumSerie";
            this.lNumSerie.Size = new System.Drawing.Size(131, 23);
            this.lNumSerie.TabIndex = 111;
            this.lNumSerie.Text = "Núm. de Serie";
            // 
            // lModelo
            // 
            this.lModelo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lModelo.AutoSize = true;
            this.lModelo.Location = new System.Drawing.Point(301, 232);
            this.lModelo.Name = "lModelo";
            this.lModelo.Size = new System.Drawing.Size(70, 23);
            this.lModelo.TabIndex = 110;
            this.lModelo.Text = "Modelo";
            // 
            // lMarca
            // 
            this.lMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lMarca.AutoSize = true;
            this.lMarca.Location = new System.Drawing.Point(40, 232);
            this.lMarca.Name = "lMarca";
            this.lMarca.Size = new System.Drawing.Size(61, 23);
            this.lMarca.TabIndex = 109;
            this.lMarca.Text = "Marca";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 123;
            this.label1.Text = "Usuario";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModificar.Location = new System.Drawing.Point(296, 523);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(233, 51);
            this.btnModificar.TabIndex = 125;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // tbArea
            // 
            this.tbArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbArea.Location = new System.Drawing.Point(115, 137);
            this.tbArea.Name = "tbArea";
            this.tbArea.ReadOnly = true;
            this.tbArea.Size = new System.Drawing.Size(420, 30);
            this.tbArea.TabIndex = 127;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 23);
            this.label8.TabIndex = 126;
            this.label8.Text = "Área";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbUsuario.Location = new System.Drawing.Point(23, 401);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.ReadOnly = true;
            this.tbUsuario.Size = new System.Drawing.Size(257, 30);
            this.tbUsuario.TabIndex = 128;
            // 
            // tbFactura
            // 
            this.tbFactura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbFactura.Location = new System.Drawing.Point(548, 329);
            this.tbFactura.MaxLength = 70;
            this.tbFactura.Name = "tbFactura";
            this.tbFactura.ReadOnly = true;
            this.tbFactura.Size = new System.Drawing.Size(255, 30);
            this.tbFactura.TabIndex = 132;
            // 
            // tbCosto
            // 
            this.tbCosto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCosto.Location = new System.Drawing.Point(287, 329);
            this.tbCosto.MaxLength = 70;
            this.tbCosto.Name = "tbCosto";
            this.tbCosto.ReadOnly = true;
            this.tbCosto.Size = new System.Drawing.Size(255, 30);
            this.tbCosto.TabIndex = 131;
            this.tbCosto.Leave += new System.EventHandler(this.tbCosto_Leave);
            // 
            // lbFactura
            // 
            this.lbFactura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbFactura.AutoSize = true;
            this.lbFactura.Location = new System.Drawing.Point(563, 303);
            this.lbFactura.Name = "lbFactura";
            this.lbFactura.Size = new System.Drawing.Size(73, 23);
            this.lbFactura.TabIndex = 130;
            this.lbFactura.Text = "Factura";
            // 
            // lbCosto
            // 
            this.lbCosto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCosto.AutoSize = true;
            this.lbCosto.Location = new System.Drawing.Point(302, 303);
            this.lbCosto.Name = "lbCosto";
            this.lbCosto.Size = new System.Drawing.Size(55, 23);
            this.lbCosto.TabIndex = 129;
            this.lbCosto.Text = "Costo";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 23);
            this.label6.TabIndex = 135;
            this.label6.Text = "Fecha de Compra";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFecha.CustomFormat = "dd-MM-yyyy";
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(23, 473);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(257, 30);
            this.dtpFecha.TabIndex = 137;
            // 
            // frmModifActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(825, 592);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbFactura);
            this.Controls.Add(this.tbCosto);
            this.Controls.Add(this.lbFactura);
            this.Controls.Add(this.lbCosto);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.tbArea);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.tbNumSerie);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lColor);
            this.Controls.Add(this.lNumSerie);
            this.Controls.Add(this.lModelo);
            this.Controls.Add(this.lMarca);
            this.Controls.Add(this.tbSucursal);
            this.Controls.Add(this.tbTipo);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbCveActivo);
            this.Controls.Add(this.lbNumetiqueta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBusqAct);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmModifActivo";
            this.Text = "Modificar Activo";
            this.Load += new System.EventHandler(this.frmModifActivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBusqAct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbNumetiqueta;
        private System.Windows.Forms.Label lbCveActivo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.TextBox tbSucursal;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.TextBox tbNumSerie;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lColor;
        private System.Windows.Forms.Label lNumSerie;
        private System.Windows.Forms.Label lModelo;
        private System.Windows.Forms.Label lMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbFactura;
        private System.Windows.Forms.TextBox tbCosto;
        private System.Windows.Forms.Label lbFactura;
        private System.Windows.Forms.Label lbCosto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}