namespace Activos.GUIs.Sucursales
{
    partial class frmModifSuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifSuc));
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbResponsable = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAgregaPersona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombre.Location = new System.Drawing.Point(160, 26);
            this.tbNombre.MaxLength = 250;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(416, 33);
            this.tbNombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Responsable";
            // 
            // cmbResponsable
            // 
            this.cmbResponsable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbResponsable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbResponsable.FormattingEnabled = true;
            this.cmbResponsable.Location = new System.Drawing.Point(160, 70);
            this.cmbResponsable.Name = "cmbResponsable";
            this.cmbResponsable.Size = new System.Drawing.Size(376, 33);
            this.cmbResponsable.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnGuardar.Location = new System.Drawing.Point(205, 121);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(189, 43);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAgregaPersona
            // 
            this.btnAgregaPersona.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregaPersona.BackgroundImage")));
            this.btnAgregaPersona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregaPersona.Location = new System.Drawing.Point(545, 70);
            this.btnAgregaPersona.Name = "btnAgregaPersona";
            this.btnAgregaPersona.Size = new System.Drawing.Size(31, 31);
            this.btnAgregaPersona.TabIndex = 186;
            this.btnAgregaPersona.Tag = "23";
            this.btnAgregaPersona.UseVisualStyleBackColor = true;
            this.btnAgregaPersona.Click += new System.EventHandler(this.btnAgregaPersona_Click);
            // 
            // frmModifSuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(597, 180);
            this.Controls.Add(this.btnAgregaPersona);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbResponsable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombre);
            this.Font = new System.Drawing.Font("Tahoma", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmModifSuc";
            this.Text = "Modificar Sucursal";
            this.Load += new System.EventHandler(this.frmModifSuc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbResponsable;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregaPersona;
    }
}