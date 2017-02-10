using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Activos.GUIs
{
    public partial class frmSelecImpresora : Form
    {
        public frmSelecImpresora()
        {
            InitializeComponent();
        }

        private void frmSelecImpresora_Load(object sender, EventArgs e)
        {

            // crear el tooltip y asociarlo con el contenido del formulario
            ToolTip toolTip1 = new ToolTip();

            // Establece los retrasos para el tooltip
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;

            // Forzar al texto del tooltip que se muestre si el formulario esta activo o no
            toolTip1.ShowAlways = true;

            // Define el tooltip para el boton ACTUALIZAR
            toolTip1.SetToolTip(this.btnActualiza, "Actualizar lista de impresoras");

            try
            {
                // impresora seleccionada actualmente
                if (!string.IsNullOrEmpty(Properties.Settings.Default.Impresora))
                    this.tbImprSelecc.Text = Properties.Settings.Default.Impresora;

                // buscar impresoras
                List<Modelos.Impresora> impresoras = new List<Modelos.Impresora>();

                foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                    impresoras.Add(new Modelos.Impresora {idImpresora = 1, impresora = printer });

                if (impresoras.Count == 0) throw new Exception("No se detectaron impresoras");

                this.gcImpresoras.DataSource = impresoras;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Impresoras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {
            try
            {

                List<Modelos.Impresora> impresoras = new List<Modelos.Impresora>();

                foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                    impresoras.Add(new Modelos.Impresora { idImpresora = 1, impresora = printer });

                if (impresoras.Count == 0) throw new Exception("No se detectaron impresoras");

                this.gcImpresoras.DataSource = null;
                this.gcImpresoras.DataSource = impresoras;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Impresoras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.gridView1.GetSelectedRows().Count() == 0)
                    throw new Exception("Seleccione una impresora");

                Modelos.Impresora impresora = new Modelos.Impresora();

                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    var dr1 = this.gridView1.GetRow(i);

                    impresora = (Modelos.Impresora)dr1;
                }

                Properties.Settings.Default.Impresora = impresora.impresora;
                Properties.Settings.Default.Save();

                this.tbImprSelecc.Text = Properties.Settings.Default.Impresora;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Impresoras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.CadetBlue;
                e.Appearance.ForeColor = Color.White;
            }
        }

    }
}
