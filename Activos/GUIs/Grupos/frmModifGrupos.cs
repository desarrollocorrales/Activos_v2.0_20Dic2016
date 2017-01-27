using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.GUIs.Responsivas;
using Activos.Negocio;

namespace Activos.GUIs.Grupos
{
    public partial class frmModifGrupos : Form
    {
        private Modelos.Grupos _grupo;
        private List<Modelos.Activos> _activos;

        private int? _idArea;
        private int? _idSucursal;
        private ICatalogosNegocio _catalogosNegocio;

        public frmModifGrupos()
        {
            InitializeComponent();
            this._catalogosNegocio = new CatalogosNegocio();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscaGrupos form = new frmBuscaGrupos();

                var result = form.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    this._activos = form._activos;
                    this._grupo = form._grupo;

                    this.tbArea.Text = this._grupo.area;
                    this.tbNombre.Text = this._grupo.nombre;

                    this._idArea = this._grupo.idArea;
                    this._idSucursal = this._grupo.idSucursal;

                    // llena el grid los activos seleccionados
                    this.gcActivos.DataSource = null;
                    this.gcActivos.DataSource = this._activos;

                    this.tbNombre.ReadOnly = false;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Grupos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAgregaActivos_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (this._grupo == null)
                    throw new Exception("Seleccione un grupo");

                int idArea = this._grupo.idArea;
                int idSucursal = this._grupo.idSucursal;

                frmBuscaActivos form = new frmBuscaActivos(idArea, idSucursal);

                var result = form.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (Modelos.Activos ac in form._listaAgregados)

                        if (this._activos.Where(w => w.idActivo == ac.idActivo).ToList().Count == 0)
                        {
                            this._activos.Add(new Modelos.Activos
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
                    this.gcActivos.DataSource = this._activos;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Grupos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnQuitarActivos_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.gridView1.DataRowCount == 0) return;

                List<Modelos.Activos> activos = (List<Modelos.Activos>)this.gridView1.DataSource;

                // obtiene los activos seleccionados
                List<Modelos.Activos> seleccionados = activos.Where(w => w.seleccionado == false).Select(s => s).ToList();

                this._activos = null;
                this._activos = seleccionados;

                this.gcActivos.DataSource = null;

                this.gcActivos.DataSource = seleccionados;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Grupos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGuardaCambios_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (this.gridView1.DataRowCount == 0)
                    throw new Exception("Agregue al menos un activo");

                bool resultado = this._catalogosNegocio.modificaGrupo(this._grupo.idGrupo, this.tbNombre.Text, this._activos);

                if (resultado)
                {
                    MessageBox.Show("Grupo modificado correctamente", "Grupos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.tbNombre.Text = string.Empty;
                    this.tbArea.Text = string.Empty;

                    this.tbNombre.ReadOnly = true;

                    _grupo = null;
                    _activos = null;

                    _idArea = null;

                    this.gcActivos.DataSource = null;
                }
                else
                    throw new Exception("Problemas en la modificación del activo");

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Grupos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
