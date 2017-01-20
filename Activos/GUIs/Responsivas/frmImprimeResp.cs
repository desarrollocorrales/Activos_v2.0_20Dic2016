using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Activos.GUIs.Responsivas.Reporte;

namespace Activos.GUIs.Responsivas
{
    public partial class frmImprimeResp : Form
    {

        private Modelos.Responsivas _responsiva = null;
        private List<Modelos.Activos> _activos = new List<Modelos.Activos>();
        

        public frmImprimeResp()
        {
            InitializeComponent();
        }

        private void btnBuscaResponsiva_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscarResponsiva form = new frmBuscarResponsiva("B");

                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.tbResponsable.Text = form._responsiva.responsable;
                    this.tbPuesto.Text = form._responsiva.puesto;
                    this.tbSucursal.Text = form._responsiva.sucursal;

                    this._responsiva = form._responsiva;

                    // llena el grid con los puestos disponibles
                    this.gcActivos.DataSource = form._activos;
                    this._activos = form._activos;
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._responsiva == null)
                    throw new Exception("Seleccione una responsiva");


                string fecIng = this.dtpFechaImpr.Value.ToString("dd-MM-yyyy");
                this._responsiva.fechaImpresion = fecIng;

                frmResponsivaReporte form = new frmResponsivaReporte();

                form._activos = this._activos;
                form._responsivas = this._responsiva;

                form.ShowDialog();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
