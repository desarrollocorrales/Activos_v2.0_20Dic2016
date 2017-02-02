using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Activos.GUIs.Responsivas.Reporte
{
    public partial class frmResponsivaReporte : Form
    {
        public frmResponsivaReporte()
        {
            InitializeComponent();
        }

        public Modelos.Responsivas _responsivas = new Modelos.Responsivas();
        public List<Modelos.Activos> _activos = new List<Modelos.Activos>();
        public List<Modelos.PersonaResponsivas> _responsables = new List<Modelos.PersonaResponsivas>();

        public string _empresa = string.Empty;

        private void frmResponsivaReporte_Load(object sender, EventArgs e)
        {

            List<Modelos.Responsivas> dsResponsiva = new List<Modelos.Responsivas>();
            dsResponsiva.Add(this._responsivas);

            //Limpiemos el DataSource del informe
            reportViewer1.LocalReport.DataSources.Clear();
            //
            //Establezcamos los parámetros que enviaremos al reporte
            //recuerde que son dos para el titulo del reporte y para el nombre de la empresa
            //
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("pEmpresa", this._empresa);
            //
            //Establezcamos la lista como Datasource del informe
            //
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsResponsiva", dsResponsiva));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsActivos", this._activos));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsResponsables", this._responsables));
            //
            //Enviemos la lista de parametros
            //
            reportViewer1.LocalReport.SetParameters(parameters);

            this.reportViewer1.RefreshReport();

        }

        private void frmResponsivaReporte_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }

        private void reportViewer1_PrintingBegin(object sender, ReportPrintEventArgs e)
        {
            MessageBox.Show("se imprimio");
        }

    }
}
