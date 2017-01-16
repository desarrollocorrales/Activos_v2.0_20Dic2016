using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;

namespace Activos.GUIs.Personas
{
    public partial class frmPersonas : Form
    {
        ICatalogosNegocio _catalogosNegocio;
        private int? _idPersona = null;
        private string _paramBusq = string.Empty;

        public frmPersonas()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this._catalogosNegocio = new CatalogosNegocio();
        }

        private void frmModifPer_Load(object sender, EventArgs e)
        {
            try
            {
                List<Modelos.Puestos> puestos = this._catalogosNegocio.getPuestos("A");

                // llena el catalogo de sucursales disponibles
                this.cmbPuestoAlta.DisplayMember = "nom_suc";
                this.cmbPuestoAlta.ValueMember = "idPuesto";
                this.cmbPuestoAlta.DataSource = puestos;
                this.cmbPuestoAlta.SelectedIndex = -1;


                // llena el catalogo de sucursales disponibles
                this.cmbPuestoModif.DisplayMember = "nom_suc";
                this.cmbPuestoModif.ValueMember = "idPuesto";
                this.cmbPuestoModif.DataSource = puestos;
                this.cmbPuestoModif.SelectedIndex = -1;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Personas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            int index = this.tabControl1.SelectedIndex;

            switch (index)
            {
                case 0:
                    this.ActiveControl = this.tbNombreAlta;
                    break;
                case 1:
                    this.ActiveControl = this.tbNombreBusqModif;

                    break;
                case 2:
                    this.ActiveControl = this.tbNombreBaja;

                    break;
                case 3:
                    this.ActiveControl = this.tbNombreActiva;

                    break;
            }

        }

        #region - A L T A -

        private void btnCrearAlta_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (string.IsNullOrEmpty(this.tbNombreAlta.Text))
                    throw new Exception("Defina un nombre para la Persona");

                if (string.IsNullOrEmpty(this.tbApPaternoAlta.Text))
                    throw new Exception("Defina un apellido paterno para la Persona");

                if (this.cmbPuestoAlta.SelectedIndex == -1)
                    throw new Exception("seleccione un puesto");

                string nombre = this.tbNombreAlta.Text + "&" + this.tbApPaternoAlta.Text + "&" + this.tbApMaternoAlta.Text;

                int idPuesto = (int)this.cmbPuestoAlta.SelectedValue;

                bool resultado = this._catalogosNegocio.altaPersona(nombre, idPuesto);

                if (resultado)
                {
                    MessageBox.Show("Persona creada con exito!", "Personas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.tbNombreAlta.Text = string.Empty;
                    this.tbApPaternoAlta.Text = string.Empty;
                    this.tbApMaternoAlta.Text = string.Empty;

                    this.cmbPuestoAlta.SelectedIndex = -1;
                }
                else
                    throw new Exception("Problemas al crear la persona");

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Personas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion 


        #region - M O D I F I C A R - 

        private void btnBuscarModif_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (string.IsNullOrEmpty(this.tbNombreBusqModif.Text))
                    throw new Exception("Defina nombre para iniciar la búsqueda");

                string paramBusq = this.tbNombreBusqModif.Text;

                List<Modelos.Personas> personas = this._catalogosNegocio.getPersonas(paramBusq, "A");

                if (personas.Count == 0)
                {
                    this.gcModif.DataSource = null;
                    throw new Exception("Sin Resultados");
                }

                this.gcModif.DataSource = personas;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Personas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gcModif_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.gridView1.GetSelectedRows().Count() == 0)
                    return;

                Modelos.Personas ent = new Modelos.Personas();

                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    var dr1 = this.gridView1.GetRow(i);

                    ent = (Modelos.Personas)dr1;
                }

                this.tbNombreModif.Text = ent.nombre;
                this.tbApPaternoModif.Text = ent.apPaterno;
                this.tbApMaternoModif.Text = ent.apMaterno;

                this.cmbPuestoModif.SelectedValue = ent.idPuesto;

                this._idPersona = ent.idPersona;

                this.tbNombreModif.ReadOnly = false;
                this.tbApPaternoModif.ReadOnly = false;
                this.tbApMaternoModif.ReadOnly = false;

                this.cmbPuestoModif.Enabled = true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Personas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModifModif_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (this._idPersona == null)
                    throw new Exception("Seleccione una persona");

                if (string.IsNullOrEmpty(this.tbNombreModif.Text))
                    throw new Exception("Defina un nombre para la persona");

                if (string.IsNullOrEmpty(this.tbNombreModif.Text))
                    throw new Exception("Defina un apellido paterno para la persona");

                if (this.cmbPuestoModif.SelectedIndex == -1)
                    throw new Exception("Seleccione un puesto");

                string nombre = this.tbNombreModif.Text + "&" + this.tbApPaternoModif.Text + "&" + this.tbApMaternoModif.Text;

                int idPuesto = (int)this.cmbPuestoModif.SelectedValue;

                bool resultado = this._catalogosNegocio.modifPersona(nombre, idPuesto, this._idPersona);

                if (resultado)
                {
                    MessageBox.Show("Persona modificada con exito!", "Personas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.tbNombreModif.Text = string.Empty;
                    this.tbApPaternoModif.Text = string.Empty;
                    this.tbApMaternoModif.Text = string.Empty;

                    this.cmbPuestoModif.SelectedIndex = -1;


                    this.tbNombreModif.ReadOnly = true;
                    this.tbApPaternoModif.ReadOnly = true;
                    this.tbApMaternoModif.ReadOnly = true;

                    this.cmbPuestoModif.Enabled = false;
                }
                else
                    throw new Exception("Problemas al modificar la persona"); 
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Personas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

        #region - B A J A S -

        private void btnBuscarBaja_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (string.IsNullOrEmpty(this.tbNombreBaja.Text))
                    throw new Exception("Defina nombre para iniciar la búsqueda");

                this._paramBusq = this.tbNombreBaja.Text;

                List<Modelos.Personas> personas = this._catalogosNegocio.getPersonas(this._paramBusq, "A");

                if (personas.Count == 0)
                {
                    this.gcBaja.DataSource = null;
                    throw new Exception("Sin Resultados");
                }
                this.gcBaja.DataSource = personas;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Personas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBajaSeleccBaja_Click(object sender, EventArgs e)
        {
            try
            {
                List<Modelos.Personas> personas = (List<Modelos.Personas>)this.gridView2.DataSource;

                // obtiene los ids de las personas seleccionadas
                List<int> seleccionados = personas.Where(w => w.seleccionado == true).Select(s => s.idPersona).ToList();

                if (seleccionados.Count == 0)
                    throw new Exception("No se ha seleccionado ninguna persona");

                // dar de baja los seleccionados
                bool resultado = this._catalogosNegocio.bajaPersonas(seleccionados);

                if (resultado)
                    MessageBox.Show("Persona (s) eliminada (s) correctamente", "Personas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // llena el grid con los tipos disponibles
                this.gcBaja.DataSource = this._catalogosNegocio.getPersonas(this._paramBusq, "A");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Personas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion



        private void btnBuscarActiva_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (string.IsNullOrEmpty(this.tbNombreActiva.Text))
                    throw new Exception("Defina nombre para iniciar la búsqueda");

                this._paramBusq = this.tbNombreActiva.Text;

                List<Modelos.Personas> personas = this._catalogosNegocio.getPersonas(this._paramBusq, "B");

                if (personas.Count == 0)
                {
                    this.gcActiva.DataSource = null;
                    throw new Exception("Sin Resultados");
                }
                this.gcActiva.DataSource = personas;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Personas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActivaSeleccActiva_Click(object sender, EventArgs e)
        {
            try
            {
                List<Modelos.Personas> personas = (List<Modelos.Personas>)this.gridView3.DataSource;

                // obtiene los ids de las personas seleccionadas
                List<int> seleccionados = personas.Where(w => w.seleccionado == true).Select(s => s.idPersona).ToList();

                if (seleccionados.Count == 0)
                    throw new Exception("No se ha seleccionado ninguna persona");

                // activar los seleccionados
                bool resultado = this._catalogosNegocio.activaPersonas(seleccionados);

                if (resultado)
                    MessageBox.Show("Persona (s) activada (s) correctamente", "Personas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // llena el grid con los tipos disponibles
                this.gcActiva.DataSource = this._catalogosNegocio.getPersonas(this._paramBusq, "B");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Personas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


    }
}
