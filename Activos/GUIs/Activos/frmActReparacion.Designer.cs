namespace Activos.GUIs.AltaActivos
{
    partial class frmActReparacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActReparacion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbActivo = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbFechaIni = new System.Windows.Forms.TextBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.tbCausa = new System.Windows.Forms.TextBox();
            this.btnBuscaActivo = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            this.tbObservAct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Activo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Inicio";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Final";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Causa";
            // 
            // tbActivo
            // 
            this.tbActivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbActivo.Location = new System.Drawing.Point(96, 26);
            this.tbActivo.Name = "tbActivo";
            this.tbActivo.ReadOnly = true;
            this.tbActivo.Size = new System.Drawing.Size(312, 30);
            this.tbActivo.TabIndex = 5;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbUsuario.Location = new System.Drawing.Point(96, 70);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.ReadOnly = true;
            this.tbUsuario.Size = new System.Drawing.Size(312, 30);
            this.tbUsuario.TabIndex = 6;
            // 
            // tbFechaIni
            // 
            this.tbFechaIni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbFechaIni.Location = new System.Drawing.Point(170, 124);
            this.tbFechaIni.Name = "tbFechaIni";
            this.tbFechaIni.ReadOnly = true;
            this.tbFechaIni.Size = new System.Drawing.Size(109, 30);
            this.tbFechaIni.TabIndex = 7;
            this.tbFechaIni.Text = "00-00-0000";
            this.tbFechaIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFechaFin.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(405, 121);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(137, 30);
            this.dtpFechaFin.TabIndex = 8;
            // 
            // tbCausa
            // 
            this.tbCausa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCausa.Location = new System.Drawing.Point(23, 192);
            this.tbCausa.Multiline = true;
            this.tbCausa.Name = "tbCausa";
            this.tbCausa.ReadOnly = true;
            this.tbCausa.Size = new System.Drawing.Size(554, 82);
            this.tbCausa.TabIndex = 9;
            // 
            // btnBuscaActivo
            // 
            this.btnBuscaActivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscaActivo.Location = new System.Drawing.Point(425, 43);
            this.btnBuscaActivo.Name = "btnBuscaActivo";
            this.btnBuscaActivo.Size = new System.Drawing.Size(152, 39);
            this.btnBuscaActivo.TabIndex = 10;
            this.btnBuscaActivo.Text = "Buscar Activo";
            this.btnBuscaActivo.UseVisualStyleBackColor = true;
            this.btnBuscaActivo.Click += new System.EventHandler(this.btnBuscaActivo_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActivar.Location = new System.Drawing.Point(385, 405);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(193, 39);
            this.btnActivar.TabIndex = 11;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // tbObservAct
            // 
            this.tbObservAct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbObservAct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbObservAct.Location = new System.Drawing.Point(22, 310);
            this.tbObservAct.MaxLength = 250;
            this.tbObservAct.Multiline = true;
            this.tbObservAct.Name = "tbObservAct";
            this.tbObservAct.Size = new System.Drawing.Size(554, 82);
            this.tbObservAct.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Observaciones de la Activación";
            // 
            // frmActReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(590, 460);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbObservAct);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.btnBuscaActivo);
            this.Controls.Add(this.tbCausa);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.tbFechaIni);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.tbActivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmActReparacion";
            this.Text = "Activos Reparación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbActivo;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbFechaIni;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.TextBox tbCausa;
        private System.Windows.Forms.Button btnBuscaActivo;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.TextBox tbObservAct;
        private System.Windows.Forms.Label label6;
    }
}