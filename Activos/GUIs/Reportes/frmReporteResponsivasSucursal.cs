using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Activos.GUIs.Reportes
{
    public partial class frmReporteResponsivasSucursal : Form
    {
        public List<Modelos.ResponsivasSucursal> _responsivas = new List<Modelos.ResponsivasSucursal>();

        public frmReporteResponsivasSucursal()
        {
            InitializeComponent();
        }

        private void frmReporteResponsivasSucursal_Load(object sender, EventArgs e)
        {
            //Limpiemos el DataSource del informe
            reportViewer1.LocalReport.DataSources.Clear();
            //
            //Establezcamos la lista como Datasource del informe
            //
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsRespSuc", _responsivas));

            this.reportViewer1.RefreshReport();
        }

        private void frmReporteResponsivasSucursal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
