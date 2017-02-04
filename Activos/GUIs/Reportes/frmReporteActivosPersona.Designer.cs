namespace Activos.GUIs.Reportes
{
    partial class frmReporteActivosPersona
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ResponsivasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PersonaResponsivasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ResponsivasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaResponsivasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsResponsiva";
            reportDataSource1.Value = this.ResponsivasBindingSource;
            reportDataSource2.Name = "dsActivos";
            reportDataSource2.Value = this.ActivosBindingSource;
            reportDataSource3.Name = "dsResponsables";
            reportDataSource3.Value = this.PersonaResponsivasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Activos.Reportes.infActivosPersona.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(702, 679);
            this.reportViewer1.TabIndex = 0;
            // 
            // ResponsivasBindingSource
            // 
            this.ResponsivasBindingSource.DataSource = typeof(Activos.Modelos.Responsivas);
            // 
            // ActivosBindingSource
            // 
            this.ActivosBindingSource.DataSource = typeof(Activos.Modelos.Activos);
            // 
            // PersonaResponsivasBindingSource
            // 
            this.PersonaResponsivasBindingSource.DataSource = typeof(Activos.Modelos.PersonaResponsivas);
            // 
            // frmReporteActivosPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 679);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteActivosPersona";
            this.Text = "Vista Previa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReporteActivosPersona_FormClosing);
            this.Load += new System.EventHandler(this.frmReporteActivosPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResponsivasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaResponsivasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ResponsivasBindingSource;
        private System.Windows.Forms.BindingSource ActivosBindingSource;
        private System.Windows.Forms.BindingSource PersonaResponsivasBindingSource;
    }
}