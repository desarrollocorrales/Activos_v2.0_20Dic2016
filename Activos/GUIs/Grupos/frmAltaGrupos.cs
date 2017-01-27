using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;
using Activos.GUIs.Responsivas;
using Activos.Modelos;

namespace Activos.GUIs.Grupos
{
    public partial class frmAltaGrupos : Form
    {
        ICatalogosNegocio _catalogosNegocio;

        public frmAltaGrupos()
        {
            InitializeComponent();

            this._catalogosNegocio = new CatalogosNegocio();
        }

        private void frmAltaGrupos_Load(object sender, EventArgs e)
        {
            try
            {
                // llenar combo de sucursales
                this.cmbSucursal.DisplayMember = "nombre";
                this.cmbSucursal.ValueMember = "idSucursal";
                this.cmbSucursal.DataSource = this._catalogosNegocio.getSucursales("A");
                this.cmbSucursal.SelectedIndex = -1;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Grupos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmbSucursal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                int idSucursal = (int)this.cmbSucursal.SelectedValue;
                
                // llenar combo de Tipos
                this.cmbArea.DataSource = this._catalogosNegocio.getAreas(idSucursal);
                this.cmbArea.DisplayMember = "nombre";
                this.cmbArea.ValueMember = "idArea";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Grupos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAgregaActivo_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (this.cmbArea.SelectedIndex == -1)
                    throw new Exception("Seleccione un área");

                int idArea = (int)this.cmbArea.SelectedValue;
                int idSucursal = (int)this.cmbSucursal.SelectedValue;

                frmBuscaActivos form = new frmBuscaActivos(idArea, idSucursal);

                var result = form.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    List<Modelos.Activos> activos = new List<Modelos.Activos>();

                    if(this.gridView1.DataRowCount != 0)
                        activos = (List<Modelos.Activos>)this.gridView1.DataSource;

                    foreach (Modelos.Activos ac in form._listaAgregados)

                        if (activos.Where(w => w.idActivo == ac.idActivo).ToList().Count == 0)
                        {
                            activos.Add(new Modelos.Activos
                            {
                                area = ac.area,
                                claveActivo = ac.claveActivo,
                                costo = ac.costo,
                                descripcion = ac.descripcion,
                                fechaAlta = ac.fechaAlta,
                                fechaModificacion = ac.fechaModificacion,
                                idActivo = ac.idActivo,
                                idArea = ac.idArea,
                                idTipo = ac.idTipo,
                                idUsuarioAlta = ac.idUsuarioAlta,
                                idUsuarioModifica = ac.idUsuarioModifica,
                                nombreCorto = ac.nombreCorto,
                                numEtiqueta = ac.numEtiqueta,
                                seleccionado = false,
                                status = ac.status,
                                tipo = ac.tipo
                            });
                        }

                    // llena el grid los activos seleccionados
                    this.gcActivos.DataSource = null;
                    this.gcActivos.DataSource = activos;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Grupos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnQuitarSelec_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.gridView1.DataRowCount == 0) return;

                List<Modelos.Activos> activos = (List<Modelos.Activos>)this.gridView1.DataSource;

                // obtiene los activos seleccionados
                List<Modelos.Activos> seleccionados = activos.Where(w => w.seleccionado == false).Select(s => s).ToList();

                this.gcActivos.DataSource = null;

                this.gcActivos.DataSource = seleccionados;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Grupos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCrearGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (string.IsNullOrEmpty(this.tbNombre.Text))
                    throw new Exception("Defina un nombre para el grupo");

                if (this.cmbArea.SelectedIndex == -1)
                    throw new Exception("Seleccione un área");

                if (this.gridView1.DataRowCount == 0)
                    throw new Exception("Agre al menos un activo");

                string nombreG = this.tbNombre.Text;

                int idArea = (int)this.cmbArea.SelectedValue;

                List<Modelos.Activos> activos = (List<Modelos.Activos>)this.gridView1.DataSource;

                bool resultado = this._catalogosNegocio.agregaGrupo(Login.idUsuario, idArea, nombreG, activos);

                if (resultado)
                {
                    MessageBox.Show("Grupo agregado correctamente", "Grupos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.tbNombre.Text = string.Empty;
                    this.cmbArea.DataSource = null;
                    this.cmbSucursal.SelectedIndex = -1;
                    this.gcActivos.DataSource = null;
                }
                else
                    throw new Exception("Problemas al agregar el grupo");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Grupos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
