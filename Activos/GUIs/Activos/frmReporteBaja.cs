using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Activos.GUIs.Activos
{
    public partial class frmReporteBaja : Form
    {
        public frmReporteBaja()
        {
            InitializeComponent();
        }

        public Modelos.Logo _logo = new Modelos.Logo();
        public List<Modelos.Activos> _activos = new List<Modelos.Activos>();
        public List<Modelos.PersonaResponsivas> _responsables = new List<Modelos.PersonaResponsivas>();

        public string _empresa = string.Empty;
        public string _movimiento = string.Empty;
        public string _fecha = string.Empty;

        private void frmReporteBaja_Load(object sender, EventArgs e)
        {
            List<Modelos.Logo> logos = new List<Modelos.Logo>();
            logos.Add(this._logo);

            //Limpiemos el DataSource del informe
            reportViewer1.LocalReport.DataSources.Clear();
            //
            //Establezcamos los parámetros que enviaremos al reporte
            //recuerde que son dos para el titulo del reporte y para el nombre de la empresa
            //
            ReportParameter[] parameters = new ReportParameter[3];
            parameters[0] = new ReportParameter("pEmpresa", this._empresa);
            parameters[1] = new ReportParameter("pMovimiento", this._movimiento);
            parameters[2] = new ReportParameter("pFecha", this._fecha);
            //
            //Establezcamos la lista como Datasource del informe
            //
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsActivos", this._activos));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsResponsables", this._responsables));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsLogo", logos));
            //
            //Enviemos la lista de parametros
            //
            reportViewer1.LocalReport.SetParameters(parameters);

            this.reportViewer1.RefreshReport();
        }

        private void frmReporteBaja_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
