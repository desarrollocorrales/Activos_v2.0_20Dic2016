using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;

namespace Activos.GUIs.Responsivas
{
    public partial class frmBajaResponsiva : Form
    {
        IResponsivasNegocio _responsivasNegocio;
        private int? _idResponsiva = null;

        public frmBajaResponsiva()
        {
            InitializeComponent();
            this._responsivasNegocio = new ResponsivasNegocio();
        }

        private void btnBuscaResponsiva_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscarResponsiva form = new frmBuscarResponsiva(string.Empty);

                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.tbResponsable.Text = form._responsiva.responsable;
                    this.tbPuesto.Text = form._responsiva.puesto;
                    this.tbSucursal.Text = form._responsiva.sucursal;

                    this._idResponsiva = form._responsiva.idResponsiva;

                    // llena el grid con los puestos disponibles
                    this.gcActivos.DataSource = form._activos;
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones 
                if (this._idResponsiva == null)
                    throw new Exception("Seleccione una responsiva");

                DialogResult dialogResult = MessageBox.Show(
                    "¿Desea dar de baja la responsiva?" + (this.gridView1.DataRowCount > 0 ? "\nLos activos se quedarán sin responsiva":string.Empty),
                                "Responsivas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    // validaciones 
                    if(string.IsNullOrEmpty(this.tbMotivo.Text))
                        throw new Exception("Defina un motivo");

                    string motivo = this.tbMotivo.Text;

                    bool resultado = this._responsivasNegocio.bajaResponsiva(this._idResponsiva, motivo);

                    if (resultado)
                    {
                        MessageBox.Show("Responsiva dada de baja correctamente", "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        this.gcActivos.DataSource = null;

                        this.tbMotivo.Text = string.Empty;
                        this.tbPuesto.Text = string.Empty;
                        this.tbResponsable.Text = string.Empty;
                        this.tbSucursal.Text = string.Empty;

                        this._idResponsiva = null;
                    }
                    else throw new Exception("Problemas al dar de baja la responsiva");
                }
                else if (dialogResult == DialogResult.No) return;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
