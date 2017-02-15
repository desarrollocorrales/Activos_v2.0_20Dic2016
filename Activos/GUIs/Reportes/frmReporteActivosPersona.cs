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
    public partial class frmReporteActivosPersona : Form
    {
        public Modelos.Logo _logo = new Modelos.Logo();
        public Modelos.Responsivas _responsivas = new Modelos.Responsivas();
        public List<Modelos.Activos> _activos = new List<Modelos.Activos>();
        public List<Modelos.PersonaResponsivas> _responsables = new List<Modelos.PersonaResponsivas>();

        public string _empresa = string.Empty;

        public frmReporteActivosPersona()
        {
            InitializeComponent();
        }

        private void frmReporteActivosPersona_Load(object sender, EventArgs e)
        {
            List<Modelos.Responsivas> dsResponsiva = new List<Modelos.Responsivas>();
            dsResponsiva.Add(this._responsivas);

            List<Modelos.Logo> logos = new List<Modelos.Logo>();
            logos.Add(this._logo);

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
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsLogo", logos));
            //
            //Enviemos la lista de parametros
            //
            reportViewer1.LocalReport.SetParameters(parameters);

            this.reportViewer1.RefreshReport();
        }

        private void frmReporteActivosPersona_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
