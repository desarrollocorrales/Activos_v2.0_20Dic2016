namespace Activos.GUIs.Usuarios
{
    partial class frmModifUsuarios
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
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSelecUsuario = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPuesto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFechaIngreso.Enabled = false;
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.dtpFechaIngreso.Location = new System.Drawing.Point(155, 180);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(366, 30);
            this.dtpFechaIngreso.TabIndex = 22;
            // 
            // tbCorreo
            // 
            this.tbCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCorreo.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.tbCorreo.Location = new System.Drawing.Point(155, 237);
            this.tbCorreo.MaxLength = 255;
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(432, 30);
            this.tbCorreo.TabIndex = 23;
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombre.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.tbNombre.Location = new System.Drawing.Point(155, 88);
            this.tbNombre.MaxLength = 255;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ReadOnly = true;
            this.tbNombre.Size = new System.Drawing.Size(432, 30);
            this.tbNombre.TabIndex = 20;
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCrear.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnCrear.Location = new System.Drawing.Point(433, 284);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(212, 40);
            this.btnCrear.TabIndex = 26;
            this.btnCrear.Text = "Actualizar";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label4.Location = new System.Drawing.Point(65, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Correo";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label3.Location = new System.Drawing.Point(36, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 49);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fecha de Ingreso";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label2.Location = new System.Drawing.Point(65, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Puesto";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label1.Location = new System.Drawing.Point(53, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre";
            // 
            // cmbSelecUsuario
            // 
            this.cmbSelecUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbSelecUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSelecUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSelecUsuario.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.cmbSelecUsuario.FormattingEnabled = true;
            this.cmbSelecUsuario.Location = new System.Drawing.Point(199, 26);
            this.cmbSelecUsuario.Name = "cmbSelecUsuario";
            this.cmbSelecUsuario.Size = new System.Drawing.Size(431, 31);
            this.cmbSelecUsuario.TabIndex = 27;
            this.cmbSelecUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbSelecUsuario_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label7.Location = new System.Drawing.Point(27, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Seleccione Usuario";
            // 
            // tbPuesto
            // 
            this.tbPuesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPuesto.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.tbPuesto.Location = new System.Drawing.Point(155, 130);
            this.tbPuesto.MaxLength = 255;
            this.tbPuesto.Name = "tbPuesto";
            this.tbPuesto.ReadOnly = true;
            this.tbPuesto.Size = new System.Drawing.Size(432, 30);
            this.tbPuesto.TabIndex = 29;
            // 
            // frmModifUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(657, 336);
            this.Controls.Add(this.tbPuesto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbSelecUsuario);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmModifUsuarios";
            this.Text = "Modificaciones Usuarios";
            this.Load += new System.EventHandler(this.frmModifUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSelecUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPuesto;
    }
}