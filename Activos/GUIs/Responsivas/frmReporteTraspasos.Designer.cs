namespace Activos.GUIs.Responsivas
{
    partial class frmReporteTraspasos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteTraspasos));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PersonaResponsivasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LogoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ActivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaResponsivasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsActivos";
            reportDataSource1.Value = this.ActivosBindingSource;
            reportDataSource2.Name = "dsResponsables";
            reportDataSource2.Value = this.PersonaResponsivasBindingSource;
            reportDataSource3.Name = "dsLogo";
            reportDataSource3.Value = this.LogoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Activos.Reportes.infActivosTraspaso.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(737, 689);
            this.reportViewer1.TabIndex = 0;
            // 
            // ActivosBindingSource
            // 
            this.ActivosBindingSource.DataSource = typeof(Modelos.Activos);
            // 
            // PersonaResponsivasBindingSource
            // 
            this.PersonaResponsivasBindingSource.DataSource = typeof(Modelos.PersonaResponsivas);
            // 
            // LogoBindingSource
            // 
            this.LogoBindingSource.DataSource = typeof(Modelos.Logo);
            // 
            // frmReporteTraspasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 689);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteTraspasos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista Previa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReporteTraspasos_FormClosed);
            this.Load += new System.EventHandler(this.frmReporteTraspasos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaResponsivasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ActivosBindingSource;
        private System.Windows.Forms.BindingSource PersonaResponsivasBindingSource;
        private System.Windows.Forms.BindingSource LogoBindingSource;
    }
}