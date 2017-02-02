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
    public partial class frmModifResp : Form
    {
        IResponsivasNegocio _responsivasNegocio;
        private int? _idResponsiva = null;

        private List<Modelos.Activos> _movimientos = new List<Modelos.Activos>();

        public frmModifResp()
        {
            InitializeComponent();
            this._responsivasNegocio = new ResponsivasNegocio();
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

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.gridView1.DataRowCount == 0) return;

                List<Modelos.Activos> sucursales = (List<Modelos.Activos>)this.gridView1.DataSource;

                // obtiene los activos seleccionados
                List<Modelos.Activos> seleccionados = sucursales.Where(w => w.seleccionado == true).Select(s => s).ToList();

                if (seleccionados.Count == 0)
                    throw new Exception("No se ha seleccionado ningun activo");

                foreach (Modelos.Activos sel in seleccionados)
                    if (this._movimientos.Where(w => w.idActivo == sel.idActivo).ToList().Count == 0)
                        this._movimientos.Add(new Modelos.Activos
                        {
                            area = sel.area,
                            claveActivo = sel.claveActivo,
                            idActivo = sel.idActivo,
                            tipo = sel.tipo,
                            nombreCorto = sel.nombreCorto,
                            numEtiqueta = sel.numEtiqueta,
                            status = "ELIMINAR"

                        });

                this.gcPrevMov.DataSource = null;

                this.gcPrevMov.DataSource = this._movimientos;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAgrega_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscaActivos form = new frmBuscaActivos(null, null);

                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    foreach (Modelos.Activos sel in form._listaAgregados)
                        if (this._movimientos.Where(w => w.idActivo == sel.idActivo).ToList().Count == 0)
                            this._movimientos.Add(new Modelos.Activos
                            {
                                area = sel.area,
                                claveActivo = sel.claveActivo,
                                idActivo = sel.idActivo,
                                tipo = sel.tipo,
                                nombreCorto = sel.nombreCorto,
                                numEtiqueta = sel.numEtiqueta,
                                status = "AGREGAR"

                            });

                    this.gcPrevMov.DataSource = null;

                    this.gcPrevMov.DataSource = this._movimientos;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.gridView2.DataRowCount == 0) return;

                List<Modelos.Activos> sucursales = (List<Modelos.Activos>)this.gridView2.DataSource;

                // obtiene los activos seleccionados
                List<Modelos.Activos> seleccionados = sucursales.Where(w => w.seleccionado == true).Select(s => s).ToList();

                if (seleccionados.Count == 0)
                    throw new Exception("No se ha seleccionado ningun activo");

                this._movimientos.RemoveAll(item => seleccionados.Contains(item));

                this.gcPrevMov.DataSource = null;

                this.gcPrevMov.DataSource = this._movimientos;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (this.gridView2.DataRowCount == 0) 
                    throw new Exception ("No hay cambios a realizar para la responsiva");

                if (this._idResponsiva == null)
                    throw new Exception("Seleccione una responsiva");

                List<int> idsResp = new List<int>();

                frmModificaResponsables form = new frmModificaResponsables();

                var result = form.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK)
                {

                }

                bool resultado = this._responsivasNegocio.modifResponsiva(this._idResponsiva, this._movimientos);

                if (resultado)
                {
                    MessageBox.Show("Responsiva modificada correctamente", "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this._idResponsiva = null;

                    this._movimientos = new List<Modelos.Activos>();

                    this.tbPuesto.Text = string.Empty;
                    this.tbResponsable.Text = string.Empty;
                    this.tbSucursal.Text = string.Empty;

                    this.gcActivos.DataSource = null;
                    this.gcPrevMov.DataSource = null;
                }
                else
                    throw new Exception("Problemas en la modificación de la responsiva");

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
