using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;

namespace Activos.GUIs.AltaActivos
{
    public partial class frmBuscaActReparacion : Form
    {
        ICatalogosNegocio _catalogosNegocio;
        IReparacionesNegocio _reparacionesNegocio;

        public Modelos.Reparaciones _activoSelecc;

        public frmBuscaActReparacion()
        {
            InitializeComponent();


            this._catalogosNegocio = new CatalogosNegocio();
            this._reparacionesNegocio = new ReparacionesNegocio();
        }

        private void frmReparaActivos_Load(object sender, EventArgs e)
        {
            try
            {
                // carga el combo de tipos
                this.cmbTipo.DisplayMember = "nombre";
                this.cmbTipo.ValueMember = "idTipo";
                this.cmbTipo.DataSource = this._catalogosNegocio.getTipos("A");
                this.cmbTipo.SelectedIndex = -1;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (this.cmbTipo.SelectedIndex == -1)
                    throw new Exception("Seleccione un tipo");

                int idTipo = (int)this.cmbTipo.SelectedValue;
                string nombre = this.tbNombre.Text;

                List<Modelos.Reparaciones> resultado = this._reparacionesNegocio.getBuscaActivosReparacion(idTipo, nombre);

                if (resultado.Count == 0)
                {
                    this.gcReparaciones.DataSource = null;
                    this.ActiveControl = this.tbNombre;
                    this.tbNombre.SelectAll();
                    throw new Exception("Sin resultados");
                }

                this.gcReparaciones.DataSource = resultado;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gcReparaciones_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.gridView1.GetSelectedRows().Count() == 0)
                    return;

                this._activoSelecc = new Modelos.Reparaciones();

                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    var dr1 = this.gridView1.GetRow(i);

                    this._activoSelecc = (Modelos.Reparaciones)dr1;
                }

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
