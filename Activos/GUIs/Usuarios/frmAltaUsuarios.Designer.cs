namespace Activos.GUIs.Usuarios
{
    partial class frmAltaUsuarios
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.cmbPersona = new System.Windows.Forms.ComboBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.tbConfirmClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label2.Location = new System.Drawing.Point(35, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Persona";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label3.Location = new System.Drawing.Point(17, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 49);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Ingreso";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label4.Location = new System.Drawing.Point(46, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label5.Location = new System.Drawing.Point(39, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label6.Location = new System.Drawing.Point(57, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Clave";
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnCrear.Location = new System.Drawing.Point(445, 189);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(110, 65);
            this.btnCrear.TabIndex = 14;
            this.btnCrear.Text = "Crear Usuario";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // tbCorreo
            // 
            this.tbCorreo.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.tbCorreo.Location = new System.Drawing.Point(136, 125);
            this.tbCorreo.MaxLength = 255;
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(432, 30);
            this.tbCorreo.TabIndex = 10;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.tbUsuario.Location = new System.Drawing.Point(136, 166);
            this.tbUsuario.MaxLength = 20;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(292, 30);
            this.tbUsuario.TabIndex = 11;
            // 
            // tbClave
            // 
            this.tbClave.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.tbClave.Location = new System.Drawing.Point(136, 207);
            this.tbClave.MaxLength = 20;
            this.tbClave.Name = "tbClave";
            this.tbClave.PasswordChar = '*';
            this.tbClave.Size = new System.Drawing.Size(292, 30);
            this.tbClave.TabIndex = 12;
            this.tbClave.UseSystemPasswordChar = true;
            // 
            // cmbPersona
            // 
            this.cmbPersona.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPersona.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPersona.DropDownWidth = 600;
            this.cmbPersona.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.cmbPersona.FormattingEnabled = true;
            this.cmbPersona.Location = new System.Drawing.Point(136, 18);
            this.cmbPersona.Name = "cmbPersona";
            this.cmbPersona.Size = new System.Drawing.Size(432, 31);
            this.cmbPersona.TabIndex = 8;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.dtpFechaIngreso.Location = new System.Drawing.Point(136, 68);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(366, 30);
            this.dtpFechaIngreso.TabIndex = 9;
            // 
            // tbConfirmClave
            // 
            this.tbConfirmClave.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.tbConfirmClave.Location = new System.Drawing.Point(136, 251);
            this.tbConfirmClave.MaxLength = 20;
            this.tbConfirmClave.Name = "tbConfirmClave";
            this.tbConfirmClave.PasswordChar = '*';
            this.tbConfirmClave.Size = new System.Drawing.Size(292, 30);
            this.tbConfirmClave.TabIndex = 13;
            this.tbConfirmClave.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label1.Location = new System.Drawing.Point(19, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 51);
            this.label1.TabIndex = 14;
            this.label1.Text = "Confirmar Clave";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmAltaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 303);
            this.Controls.Add(this.tbConfirmClave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.cmbPersona);
            this.Controls.Add(this.tbClave);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmAltaUsuarios";
            this.Tag = "altausuarios";
            this.Text = "Alta de Usuarios";
            this.Load += new System.EventHandler(this.frmAltaUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.ComboBox cmbPersona;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.TextBox tbConfirmClave;
        private System.Windows.Forms.Label label1;
    }
}