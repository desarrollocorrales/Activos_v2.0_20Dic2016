namespace Activos.GUIs.AltaActivos
{
    partial class frmAltaActivo
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lMarca = new System.Windows.Forms.Label();
            this.lModelo = new System.Windows.Forms.Label();
            this.lNumSerie = new System.Windows.Forms.Label();
            this.lColor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.tbNumSerie = new System.Windows.Forms.TextBox();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.Location = new System.Drawing.Point(198, 384);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(340, 56);
            this.btnGuardar.TabIndex = 109;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo";
            // 
            // lMarca
            // 
            this.lMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lMarca.AutoSize = true;
            this.lMarca.Location = new System.Drawing.Point(25, 97);
            this.lMarca.Name = "lMarca";
            this.lMarca.Size = new System.Drawing.Size(61, 23);
            this.lMarca.TabIndex = 3;
            this.lMarca.Text = "Marca";
            // 
            // lModelo
            // 
            this.lModelo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lModelo.AutoSize = true;
            this.lModelo.Location = new System.Drawing.Point(264, 97);
            this.lModelo.Name = "lModelo";
            this.lModelo.Size = new System.Drawing.Size(70, 23);
            this.lModelo.TabIndex = 4;
            this.lModelo.Text = "Modelo";
            // 
            // lNumSerie
            // 
            this.lNumSerie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lNumSerie.AutoSize = true;
            this.lNumSerie.Location = new System.Drawing.Point(496, 97);
            this.lNumSerie.Name = "lNumSerie";
            this.lNumSerie.Size = new System.Drawing.Size(131, 23);
            this.lNumSerie.TabIndex = 5;
            this.lNumSerie.Text = "Núm. de Serie";
            // 
            // lColor
            // 
            this.lColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lColor.AutoSize = true;
            this.lColor.Location = new System.Drawing.Point(25, 165);
            this.lColor.Name = "lColor";
            this.lColor.Size = new System.Drawing.Size(52, 23);
            this.lColor.TabIndex = 6;
            this.lColor.Text = "Color";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Descripción";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Sucursal";
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombre.Location = new System.Drawing.Point(19, 55);
            this.tbNombre.MaxLength = 40;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(345, 30);
            this.tbNombre.TabIndex = 100;
            // 
            // tbMarca
            // 
            this.tbMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbMarca.Location = new System.Drawing.Point(19, 123);
            this.tbMarca.MaxLength = 70;
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(228, 30);
            this.tbMarca.TabIndex = 102;
            // 
            // tbModelo
            // 
            this.tbModelo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbModelo.Location = new System.Drawing.Point(253, 123);
            this.tbModelo.MaxLength = 70;
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(228, 30);
            this.tbModelo.TabIndex = 103;
            // 
            // tbNumSerie
            // 
            this.tbNumSerie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNumSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNumSerie.Location = new System.Drawing.Point(487, 123);
            this.tbNumSerie.MaxLength = 70;
            this.tbNumSerie.Name = "tbNumSerie";
            this.tbNumSerie.Size = new System.Drawing.Size(228, 30);
            this.tbNumSerie.TabIndex = 104;
            // 
            // tbColor
            // 
            this.tbColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbColor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbColor.Location = new System.Drawing.Point(19, 191);
            this.tbColor.MaxLength = 70;
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(228, 30);
            this.tbColor.TabIndex = 105;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDescripcion.Location = new System.Drawing.Point(253, 191);
            this.tbDescripcion.MaxLength = 500;
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescripcion.Size = new System.Drawing.Size(462, 172);
            this.tbDescripcion.TabIndex = 108;
            // 
            // cmbTipo
            // 
            this.cmbTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.DropDownWidth = 400;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(370, 55);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(345, 31);
            this.cmbTipo.TabIndex = 101;
            this.cmbTipo.SelectionChangeCommitted += new System.EventHandler(this.cmbTipo_SelectionChangeCommitted);
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.DropDownWidth = 400;
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(19, 259);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(228, 31);
            this.cmbSucursal.TabIndex = 106;
            this.cmbSucursal.SelectionChangeCommitted += new System.EventHandler(this.cmbSucursal_SelectionChangeCommitted);
            // 
            // cmbArea
            // 
            this.cmbArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.DropDownWidth = 400;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(19, 332);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(228, 31);
            this.cmbArea.TabIndex = 107;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Área";
            // 
            // frmAltaActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(737, 459);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.tbNumSerie);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lColor);
            this.Controls.Add(this.lNumSerie);
            this.Controls.Add(this.lModelo);
            this.Controls.Add(this.lMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmAltaActivo";
            this.Text = "Alta Activos";
            this.Load += new System.EventHandler(this.frmAltaActivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lMarca;
        private System.Windows.Forms.Label lModelo;
        private System.Windows.Forms.Label lNumSerie;
        private System.Windows.Forms.Label lColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.TextBox tbNumSerie;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label label9;
    }
}