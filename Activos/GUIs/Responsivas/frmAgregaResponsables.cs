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
    public partial class frmAgregaResponsables : Form
    {
        ICatalogosNegocio _catalogosNegocio;
        IResponsivasNegocio _responsivasNegocio;

        private int _idPersona;

        public List<Modelos.PersonaResponsivas> _listaAgregados = new List<Modelos.PersonaResponsivas>();

        public frmAgregaResponsables(int? idPersona)
        {
            InitializeComponent();
            this._catalogosNegocio = new CatalogosNegocio();
            this._responsivasNegocio = new ResponsivasNegocio();

            this._idPersona = (int)idPersona;
        }

        private void frmAgregaResponsables_Load(object sender, EventArgs e)
        {
            try
            {
                // llena el catalogo de sucursales disponibles
                this.cmbSucursal.DataSource = this._catalogosNegocio.getSucursales("A");
                this.cmbSucursal.DisplayMember = "nombre";
                this.cmbSucursal.ValueMember = "idSucursal";
                this.cmbSucursal.SelectedIndex = -1;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Agregar Responsables", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if(this.cmbSucursal.SelectedIndex == -1)
                    throw new Exception("Seleccione una sucursal");

                int idsucursal = (int)this.cmbSucursal.SelectedValue;
                string nombre = this.tbResp.Text;

                // busqueda de usuarios
                List<Modelos.PersonaResponsivas> usuarios = this._catalogosNegocio.busquedaResponsables(this.tbResp.Text, idsucursal);



                if (usuarios.Count == 0)
                {
                    this.gcUsuarios.DataSource = null;
                    this.ActiveControl = this.tbResp;
                    this.tbResp.SelectAll();
                    throw new Exception("Sin resultados");
                }

                this.gcUsuarios.DataSource = usuarios.Where(w => w.idPersona != this._idPersona).ToList();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Agregar Responsables", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAgrega_Click(object sender, EventArgs e)
        {

            try
            {
                string activosGpos = string.Empty;

                List<Modelos.PersonaResponsivas> personas = ((List<Modelos.PersonaResponsivas>)this.gridView1.DataSource).Where(w => w.seleccionado == true).Select(s => s).ToList();

                if (personas.Count == 0)
                    throw new Exception("No se ha seleccionado ninguna persona");

                foreach (Modelos.PersonaResponsivas per in personas)
                {
                    if (this._listaAgregados.Where(w => w.idPersona == per.idPersona).ToList().Count == 0)
                    {
                        this._listaAgregados.Add(new Modelos.PersonaResponsivas
                        {
                            idPersona = per.idPersona,
                            nombre= per.nombre,
                            puesto = per.puesto,
                            sucursal = per.sucursal,
                        });
                    }
                }

                this.gcSeleccionados.DataSource = null;

                this.gcSeleccionados.DataSource = this._listaAgregados;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Agregar Responsables", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Modelos.PersonaResponsivas> personas = 
                    ((List<Modelos.PersonaResponsivas>)this.gridView2.DataSource).Where(w => w.seleccionado == false).Select(s => s).ToList();

                if (personas.Count == 0)
                    throw new Exception("No se ha seleccionado ninguna persona");

                this._listaAgregados = new List<Modelos.PersonaResponsivas>();

                foreach (Modelos.PersonaResponsivas per in personas)
                {
                    if (this._listaAgregados.Where(w => w.idPersona == per.idPersona).ToList().Count == 0)
                    {
                        this._listaAgregados.Add(new Modelos.PersonaResponsivas
                        {
                            idPersona = per.idPersona,
                            nombre= per.nombre,
                            puesto = per.puesto,
                            sucursal = per.sucursal,
                            seleccionado = false
                        });
                    }
                }

                this.gcSeleccionados.DataSource = null;

                this.gcSeleccionados.DataSource = this._listaAgregados;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Agregar Responsables", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnQuitarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                this._listaAgregados = new List<Modelos.PersonaResponsivas>();

                this.gcSeleccionados.DataSource = null;

                this.gcSeleccionados.DataSource = this._listaAgregados;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Agregar Responsables", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

    }
}
