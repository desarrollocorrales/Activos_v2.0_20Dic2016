﻿namespace Activos.GUIs.Tipos
{
    partial class frmModiftipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModiftipos));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFactura = new System.Windows.Forms.CheckBox();
            this.cbCosto = new System.Windows.Forms.CheckBox();
            this.cbSerie = new System.Windows.Forms.CheckBox();
            this.cbColor = new System.Windows.Forms.CheckBox();
            this.cbModelo = new System.Windows.Forms.CheckBox();
            this.cbMarca = new System.Windows.Forms.CheckBox();
            this.cbFechaCompra = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnGuardar.Location = new System.Drawing.Point(180, 252);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(189, 44);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label2.Location = new System.Drawing.Point(35, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombre.Font = new System.Drawing.Font("Tahoma", 16F);
            this.tbNombre.Location = new System.Drawing.Point(147, 28);
            this.tbNombre.MaxLength = 250;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(340, 33);
            this.tbNombre.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbFechaCompra);
            this.groupBox1.Controls.Add(this.cbFactura);
            this.groupBox1.Controls.Add(this.cbCosto);
            this.groupBox1.Controls.Add(this.cbSerie);
            this.groupBox1.Controls.Add(this.cbColor);
            this.groupBox1.Controls.Add(this.cbModelo);
            this.groupBox1.Controls.Add(this.cbMarca);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox1.Location = new System.Drawing.Point(24, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 154);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obligatorios";
            // 
            // cbFactura
            // 
            this.cbFactura.AutoSize = true;
            this.cbFactura.Font = new System.Drawing.Font("Tahoma", 16F);
            this.cbFactura.Location = new System.Drawing.Point(121, 102);
            this.cbFactura.Name = "cbFactura";
            this.cbFactura.Size = new System.Drawing.Size(103, 31);
            this.cbFactura.TabIndex = 11;
            this.cbFactura.Text = "Factura";
            this.cbFactura.UseVisualStyleBackColor = true;
            // 
            // cbCosto
            // 
            this.cbCosto.AutoSize = true;
            this.cbCosto.Font = new System.Drawing.Font("Tahoma", 16F);
            this.cbCosto.Location = new System.Drawing.Point(15, 102);
            this.cbCosto.Name = "cbCosto";
            this.cbCosto.Size = new System.Drawing.Size(85, 31);
            this.cbCosto.TabIndex = 10;
            this.cbCosto.Text = "Costo";
            this.cbCosto.UseVisualStyleBackColor = true;
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
            // cbFechaCompra
            // 
            this.cbFechaCompra.AutoSize = true;
            this.cbFechaCompra.Font = new System.Drawing.Font("Tahoma", 16F);
            this.cbFechaCompra.Location = new System.Drawing.Point(245, 102);
            this.cbFechaCompra.Name = "cbFechaCompra";
            this.cbFechaCompra.Size = new System.Drawing.Size(201, 31);
            this.cbFechaCompra.TabIndex = 12;
            this.cbFechaCompra.Text = "Fecha de Compra";
            this.cbFechaCompra.UseVisualStyleBackColor = true;
            // 
            // frmModiftipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(549, 316);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombre);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmModiftipos";
            this.Text = "Modificar Tipos";
            this.Load += new System.EventHandler(this.frmModiftipos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbSerie;
        private System.Windows.Forms.CheckBox cbColor;
        private System.Windows.Forms.CheckBox cbModelo;
        private System.Windows.Forms.CheckBox cbMarca;
        private System.Windows.Forms.CheckBox cbFactura;
        private System.Windows.Forms.CheckBox cbCosto;
        private System.Windows.Forms.CheckBox cbFechaCompra;
    }
}