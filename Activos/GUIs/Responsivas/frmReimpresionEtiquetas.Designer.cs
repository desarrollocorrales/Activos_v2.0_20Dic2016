namespace Activos.GUIs.Responsivas
{
    partial class frmReimpresionEtiquetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReimpresionEtiquetas));
            this.gbPNE = new System.Windows.Forms.GroupBox();
            this.tbNumEtiqueta = new System.Windows.Forms.TextBox();
            this.btnBuscarPNE = new System.Windows.Forms.Button();
            this.gbPCA = new System.Windows.Forms.GroupBox();
            this.tbCveActivo = new System.Windows.Forms.TextBox();
            this.btnBuscarPCA = new System.Windows.Forms.Button();
            this.rbPCA = new System.Windows.Forms.RadioButton();
            this.rbPNE = new System.Windows.Forms.RadioButton();
            this.tbResultCveActivo = new System.Windows.Forms.TextBox();
            this.tbResultNumEtiqueta = new System.Windows.Forms.TextBox();
            this.tbResultDesc = new System.Windows.Forms.TextBox();
            this.tbResultNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImprEtiquetas = new System.Windows.Forms.Button();
            this.gbPNE.SuspendLayout();
            this.gbPCA.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPNE
            // 
            this.gbPNE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbPNE.Controls.Add(this.tbNumEtiqueta);
            this.gbPNE.Controls.Add(this.btnBuscarPNE);
            this.gbPNE.Location = new System.Drawing.Point(284, 16);
            this.gbPNE.Name = "gbPNE";
            this.gbPNE.Size = new System.Drawing.Size(234, 112);
            this.gbPNE.TabIndex = 5;
            this.gbPNE.TabStop = false;
            // 
            // tbNumEtiqueta
            // 
            this.tbNumEtiqueta.Location = new System.Drawing.Point(18, 29);
            this.tbNumEtiqueta.Name = "tbNumEtiqueta";
            this.tbNumEtiqueta.Size = new System.Drawing.Size(199, 30);
            this.tbNumEtiqueta.TabIndex = 5;
            this.tbNumEtiqueta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumEtiqueta_KeyPress);
            // 
            // btnBuscarPNE
            // 
            this.btnBuscarPNE.Location = new System.Drawing.Point(34, 65);
            this.btnBuscarPNE.Name = "btnBuscarPNE";
            this.btnBuscarPNE.Size = new System.Drawing.Size(163, 34);
            this.btnBuscarPNE.TabIndex = 4;
            this.btnBuscarPNE.Text = "Buscar";
            this.btnBuscarPNE.UseVisualStyleBackColor = true;
            this.btnBuscarPNE.Click += new System.EventHandler(this.btnBuscarPNE_Click);
            // 
            // gbPCA
            // 
            this.gbPCA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbPCA.Controls.Add(this.tbCveActivo);
            this.gbPCA.Controls.Add(this.btnBuscarPCA);
            this.gbPCA.Location = new System.Drawing.Point(44, 16);
            this.gbPCA.Name = "gbPCA";
            this.gbPCA.Size = new System.Drawing.Size(234, 112);
            this.gbPCA.TabIndex = 4;
            this.gbPCA.TabStop = false;
            // 
            // tbCveActivo
            // 
            this.tbCveActivo.Location = new System.Drawing.Point(18, 29);
            this.tbCveActivo.Name = "tbCveActivo";
            this.tbCveActivo.Size = new System.Drawing.Size(199, 30);
            this.tbCveActivo.TabIndex = 6;
            this.tbCveActivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCveActivo_KeyPress);
            // 
            // btnBuscarPCA
            // 
            this.btnBuscarPCA.Location = new System.Drawing.Point(34, 65);
            this.btnBuscarPCA.Name = "btnBuscarPCA";
            this.btnBuscarPCA.Size = new System.Drawing.Size(163, 34);
            this.btnBuscarPCA.TabIndex = 5;
            this.btnBuscarPCA.Text = "Buscar";
            this.btnBuscarPCA.UseVisualStyleBackColor = true;
            this.btnBuscarPCA.Click += new System.EventHandler(this.btnBuscarPCA_Click);
            // 
            // rbPCA
            // 
            this.rbPCA.AutoSize = true;
            this.rbPCA.Location = new System.Drawing.Point(522, 44);
            this.rbPCA.Name = "rbPCA";
            this.rbPCA.Size = new System.Drawing.Size(160, 27);
            this.rbPCA.TabIndex = 12;
            this.rbPCA.Text = "Por Clave Activo";
            this.rbPCA.UseVisualStyleBackColor = true;
            this.rbPCA.CheckedChanged += new System.EventHandler(this.rbPCA_CheckedChanged);
            // 
            // rbPNE
            // 
            this.rbPNE.AutoSize = true;
            this.rbPNE.Location = new System.Drawing.Point(522, 23);
            this.rbPNE.Name = "rbPNE";
            this.rbPNE.Size = new System.Drawing.Size(182, 27);
            this.rbPNE.TabIndex = 11;
            this.rbPNE.Text = "Por Núm. Etiqueta";
            this.rbPNE.UseVisualStyleBackColor = true;
            this.rbPNE.CheckedChanged += new System.EventHandler(this.rbPNE_CheckedChanged);
            // 
            // tbResultCveActivo
            // 
            this.tbResultCveActivo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbResultCveActivo.Location = new System.Drawing.Point(434, 225);
            this.tbResultCveActivo.Name = "tbResultCveActivo";
            this.tbResultCveActivo.ReadOnly = true;
            this.tbResultCveActivo.Size = new System.Drawing.Size(110, 30);
            this.tbResultCveActivo.TabIndex = 28;
            this.tbResultCveActivo.Text = "000000";
            this.tbResultCveActivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbResultNumEtiqueta
            // 
            this.tbResultNumEtiqueta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbResultNumEtiqueta.Location = new System.Drawing.Point(161, 225);
            this.tbResultNumEtiqueta.Name = "tbResultNumEtiqueta";
            this.tbResultNumEtiqueta.ReadOnly = true;
            this.tbResultNumEtiqueta.Size = new System.Drawing.Size(146, 30);
            this.tbResultNumEtiqueta.TabIndex = 27;
            this.tbResultNumEtiqueta.Text = "0000000000000";
            this.tbResultNumEtiqueta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbResultDesc
            // 
            this.tbResultDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbResultDesc.Location = new System.Drawing.Point(99, 185);
            this.tbResultDesc.Name = "tbResultDesc";
            this.tbResultDesc.ReadOnly = true;
            this.tbResultDesc.Size = new System.Drawing.Size(444, 30);
            this.tbResultDesc.TabIndex = 26;
            // 
            // tbResultNombre
            // 
            this.tbResultNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbResultNombre.Location = new System.Drawing.Point(99, 149);
            this.tbResultNombre.Name = "tbResultNombre";
            this.tbResultNombre.ReadOnly = true;
            this.tbResultNombre.Size = new System.Drawing.Size(444, 30);
            this.tbResultNombre.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Núm. Etiqueta:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cve. Activo:";
            // 
            // label100
            // 
            this.label100.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(17, 188);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(63, 23);
            this.label100.TabIndex = 22;
            this.label100.Text = "Desc.:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre:";
            // 
            // btnImprEtiquetas
            // 
            this.btnImprEtiquetas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnImprEtiquetas.Location = new System.Drawing.Point(300, 282);
            this.btnImprEtiquetas.Name = "btnImprEtiquetas";
            this.btnImprEtiquetas.Size = new System.Drawing.Size(203, 43);
            this.btnImprEtiquetas.TabIndex = 29;
            this.btnImprEtiquetas.Text = "Imprimir Etiquetas";
            this.btnImprEtiquetas.UseVisualStyleBackColor = true;
            this.btnImprEtiquetas.Click += new System.EventHandler(this.btnImprEtiquetas_Click);
            // 
            // frmReimpresionEtiquetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 344);
            this.Controls.Add(this.btnImprEtiquetas);
            this.Controls.Add(this.tbResultCveActivo);
            this.Controls.Add(this.tbResultNumEtiqueta);
            this.Controls.Add(this.tbResultDesc);
            this.Controls.Add(this.tbResultNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbPCA);
            this.Controls.Add(this.rbPNE);
            this.Controls.Add(this.gbPNE);
            this.Controls.Add(this.gbPCA);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmReimpresionEtiquetas";
            this.Text = "Reimpresion Etiquetas";
            this.Load += new System.EventHandler(this.frmReimpresionEtiquetas_Load);
            this.gbPNE.ResumeLayout(false);
            this.gbPNE.PerformLayout();
            this.gbPCA.ResumeLayout(false);
            this.gbPCA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPNE;
        private System.Windows.Forms.TextBox tbNumEtiqueta;
        private System.Windows.Forms.Button btnBuscarPNE;
        private System.Windows.Forms.GroupBox gbPCA;
        private System.Windows.Forms.TextBox tbCveActivo;
        private System.Windows.Forms.Button btnBuscarPCA;
        private System.Windows.Forms.RadioButton rbPCA;
        private System.Windows.Forms.RadioButton rbPNE;
        private System.Windows.Forms.TextBox tbResultCveActivo;
        private System.Windows.Forms.TextBox tbResultNumEtiqueta;
        private System.Windows.Forms.TextBox tbResultDesc;
        private System.Windows.Forms.TextBox tbResultNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImprEtiquetas;
    }
}