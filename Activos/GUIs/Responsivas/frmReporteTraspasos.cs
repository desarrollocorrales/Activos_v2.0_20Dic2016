using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Activos.GUIs.Responsivas
{
    public partial class frmReporteTraspasos : Form
    {
        public string _empresa;
        public string _fecha;
        public string _personaAnterior;
        public string _personaNueva;
        public string _detalle;

        public Modelos.Logo _logo;
        public List<Modelos.Activos> _activos;

        public frmReporteTraspasos()
        {
            InitializeComponent();
        }

        private void frmReporteTraspasos_Load(object sender, EventArgs e)
        {

            List<Modelos.Logo> logos = new List<Modelos.Logo>();
            logos.Add(this._logo);

            //Limpiemos el DataSource del informe
            reportViewer1.LocalReport.DataSources.Clear();
            //
            //Establezcamos los parámetros que enviaremos al reporte
            //recuerde que son dos para el titulo del reporte y para el nombre de la empresa
            //
            ReportParameter[] parameters = new ReportParameter[5];
            parameters[0] = new ReportParameter("pEmpresa", this._empresa);
            parameters[1] = new ReportParameter("pDetalle", this._detalle);
            parameters[2] = new ReportParameter("pFecha", this._fecha);
            parameters[3] = new ReportParameter("pPersonaAnt", this._personaAnterior);
            parameters[4] = new ReportParameter("pPersonaNueva", this._personaNueva);
            //
            //Establezcamos la lista como Datasource del informe
            //
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsActivos", this._activos));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsLogo", logos));
            //
            //Enviemos la lista de parametros
            //
            reportViewer1.LocalReport.SetParameters(parameters);

            this.reportViewer1.RefreshReport();
        }

        private void frmReporteTraspasos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }

    }
}
