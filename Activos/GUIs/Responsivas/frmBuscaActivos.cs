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
    public partial class frmBuscaActivos : Form
    {
        ICatalogosNegocio _catalogosNegocio;
        IActivosNegocio _activosNegocio;

        public List<Modelos.Activos> _listaAgregados;
        private int? _idArea = null;
        private int? _idSucursal = null;

        public frmBuscaActivos(int? idArea, int? idSucursal)
        {
            InitializeComponent();

            // acomoda radios
            this.rbPTN.Location = new Point(this.gbPTN.Location.X + 13, this.gbPTN.Location.Y - 1);
            this.rbPNE.Location = new Point(this.gbPNE.Location.X + 13, this.gbPNE.Location.Y - 1);
            this.rbPCA.Location = new Point(this.gbPCA.Location.X + 13, this.gbPCA.Location.Y - 1);

            // inicializa variables
            this._catalogosNegocio = new CatalogosNegocio();
            this._activosNegocio = new ActivosNegocio();


            // TODO: Complete member initialization
            this._idArea = idArea;
            this._idSucursal = idSucursal;
        }


        private void frmBuscaActivos_Load(object sender, EventArgs e)
        {
            try
            {
                // carga el combo de tipos
                this.cmbTipo.DisplayMember = "nombre";
                this.cmbTipo.ValueMember = "idTipo";
                this.cmbTipo.DataSource = this._catalogosNegocio.getTipos("A");
                this.cmbTipo.SelectedIndex = -1;

                // llenar combo de sucursales
                this.cmbSucursal.DisplayMember = "nombre";
                this.cmbSucursal.ValueMember = "idSucursal";
                this.cmbSucursal.DataSource = this._catalogosNegocio.getSucursales("A");
                this.cmbSucursal.SelectedIndex = -1;

                if (this._idArea != null)
                {
                    this.cmbSucursal.SelectedValue = this._idSucursal;

                    this.cmbSucursal_SelectionChangeCommitted(null, null);

                    this.cmbArea.SelectedValue = this._idArea;

                    this.cmbSucursal.Enabled = false;
                    this.cmbArea.Enabled = false;
                }

                // define radios activos
                this.rbPTN.Checked = true;

                // inicializa la lista de agregados
                this._listaAgregados = new List<Modelos.Activos>();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rbPTN_CheckedChanged(object sender, EventArgs e)
        {
            this.gbPTN.Enabled = true;
            this.gbPNE.Enabled = false;
            this.gbPCA.Enabled = false;

            reiniciaControles();
        }

        private void rbPNE_CheckedChanged(object sender, EventArgs e)
        {
            this.gbPTN.Enabled = false;
            this.gbPNE.Enabled = true;
            this.gbPCA.Enabled = false;

            reiniciaControles();
        }

        private void rbPCA_CheckedChanged(object sender, EventArgs e)
        {
            this.gbPTN.Enabled = false;
            this.gbPNE.Enabled = false;
            this.gbPCA.Enabled = true;

            reiniciaControles();
        }

        private void reiniciaControles()
        {
            this.tbNombre.Text = string.Empty;
            this.cmbTipo.SelectedIndex = -1;

            if (this._idArea == null)
            {
                this.cmbSucursal.SelectedIndex = -1;
                this.cmbArea.DataSource = null;
            }

            this.tbNumEtiqueta.Text = string.Empty;

            this.tbCveActivo.Text = string.Empty;

            this.gcResulBusquedas.DataSource = null;
        }

        private void btnBuscarPTN_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (this.cmbSucursal.SelectedIndex == -1)
                    throw new Exception("Seleccione una sucursal");

                if (this.cmbArea.SelectedIndex == -1)
                    throw new Exception("Seleccione un área");

                if (this.cmbTipo.SelectedIndex == -1)
                    throw new Exception("Seleccione un tipo");

                int idArea = (int)this.cmbArea.SelectedValue;
                int idTipo = (int)this.cmbTipo.SelectedValue;
                string nombre = this.tbNombre.Text;

                List<Modelos.Activos> resultado = this._activosNegocio.getBuscaActivos(idArea, idTipo, nombre, "A");

                if (resultado.Count==0)
                {
                    this.gcResulBusquedas.DataSource = null;
                    this.ActiveControl = this.tbNombre;
                    this.tbNombre.SelectAll();
                    throw new Exception("Sin resultados");
                }
                
                if (this._idArea != null)
                {
                    List<Modelos.Activos> activos = new List<Modelos.Activos>();

                    if (this._idArea != null)
                        activos = resultado.Where(w => w.idArea == this._idArea).ToList();

                    if(activos.Count == 0)
                        throw new Exception("Sin resultados");

                    this.gcResulBusquedas.DataSource = activos;

                    return;
                }
                
                this.gcResulBusquedas.DataSource = resultado;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscarPNE_Click(object sender, EventArgs e)
        {
            try
            {
                string numEtiqueta = this.tbNumEtiqueta.Text;

                List<Modelos.Activos> resultado = this._activosNegocio.getBuscaActivos(numEtiqueta, "NE");

                if (resultado.Count == 0)
                {
                    this.gcResulBusquedas.DataSource = null;
                    this.ActiveControl = this.tbNumEtiqueta;
                    this.tbNumEtiqueta.SelectAll();
                    throw new Exception("Sin resultados");
                }

                if (this._idArea != null)
                {
                    List<Modelos.Activos> activos = new List<Modelos.Activos>();

                    if (this._idArea != null)
                        activos = resultado.Where(w => w.idArea == this._idArea).ToList();

                    if (activos.Count == 0)
                        throw new Exception("Sin resultados");

                    this.gcResulBusquedas.DataSource = activos;

                    return;
                }

                this.gcResulBusquedas.DataSource = resultado;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscarPCA_Click(object sender, EventArgs e)
        {
            try
            {
                string cveActivo = this.tbCveActivo.Text;

                List<Modelos.Activos> resultado = this._activosNegocio.getBuscaActivos(cveActivo, "CA");

                if (resultado.Count == 0)
                {
                    this.gcResulBusquedas.DataSource = null;
                    this.ActiveControl = this.tbCveActivo;
                    this.tbCveActivo.SelectAll();
                    throw new Exception("Sin resultados");
                }

                if (this._idArea != null)
                {
                    List<Modelos.Activos> activos = new List<Modelos.Activos>();

                    if (this._idArea != null)
                        activos = resultado.Where(w => w.idArea == this._idArea).ToList();

                    if (activos.Count == 0)
                        throw new Exception("Sin resultados");

                    this.gcResulBusquedas.DataSource = activos;

                    return;
                }

                this.gcResulBusquedas.DataSource = resultado;
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
                string activosGpos = string.Empty;

                List<Modelos.Activos> activos = ((List<Modelos.Activos>)this.gridView1.DataSource).Where(w => w.seleccionado == true).Select(s => s).ToList();

                if (activos.Count == 0)
                    throw new Exception("No se ha seleccionado ningun activo");

                foreach (Modelos.Activos ac in activos)
                {
                    // en caso de agregar activos para grupos
                    // validar si el activo que se intenta agregar 
                    // ya existe en un grupo
                    if (this._idArea != null)
                    {

                        string actGrupo = this._catalogosNegocio.buscaActivoEnGrupo(ac.idActivo);

                        if (!string.IsNullOrEmpty(actGrupo))
                        {
                            activosGpos += "El activo " + ac.nombreCorto + " pertenece al grupo '" +actGrupo + "'\n";

                            continue;
                        }
                    }


                    if (this._listaAgregados.Where(w => w.idActivo == ac.idActivo).ToList().Count == 0)
                    {
                        this._listaAgregados.Add(new Modelos.Activos
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
                }
                this.gcSeleccionados.DataSource = null;

                this.gcSeleccionados.DataSource = this._listaAgregados;

                if (!string.IsNullOrEmpty(activosGpos))
                    throw new Exception(activosGpos);
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
                List<Modelos.Activos> activos = ((List<Modelos.Activos>)this.gridView2.DataSource).Where(w => w.seleccionado == true).Select(s => s).ToList();

                if (activos.Count == 0)
                    throw new Exception("No se ha seleccionado ningun activo");

                foreach (Modelos.Activos ac in activos)
                {
                    this._listaAgregados.Remove(ac);
                }

                // obtiene los ids de los puestos seleccionadas
                // this._listaAgregados.AddRange(activos);

                this.gcSeleccionados.DataSource = null;

                this.gcSeleccionados.DataSource = this._listaAgregados;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnQuitarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                this._listaAgregados = new List<Modelos.Activos>();

                this.gcSeleccionados.DataSource = null;

                this.gcSeleccionados.DataSource = this._listaAgregados;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnBuscarPTN_Click(null, null);
            }
        }

        private void tbNumEtiqueta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnBuscarPNE_Click(null, null);
            }
        }

        private void tbCveActivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnBuscarPCA_Click(null, null);
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
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
