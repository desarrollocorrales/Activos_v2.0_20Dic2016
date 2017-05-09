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
    public partial class frmResponsivas : Form
    {
        ICatalogosNegocio _catalogosNegocio;
        IResponsivasNegocio _responsivasNegocio;

        private int? _idPersona = null;

        private bool _creaRespActivo;
        private List<Modelos.Activos> _activosResp = new List<Modelos.Activos>();

        public frmResponsivas()
        {
            InitializeComponent();
            this._catalogosNegocio = new CatalogosNegocio();
            this._responsivasNegocio = new ResponsivasNegocio();
        }

        public frmResponsivas(List<Modelos.Activos> activos)
        {
            InitializeComponent();
            this._catalogosNegocio = new CatalogosNegocio();
            this._responsivasNegocio = new ResponsivasNegocio();

            this._creaRespActivo = true;
            this._activosResp = activos;
        }

        private void frmResponsivas_Load(object sender, EventArgs e)
        {
            try
            {
                if (this._creaRespActivo)
                {
                    this.btnBuscaActivos.Enabled = false;

                    this.gcActivos.DataSource = this._activosResp;
                }
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
                // busqueda de usuarios
                List<Modelos.PersonaResponsivas> usuarios = this._catalogosNegocio.busquedaResponsables(this.tbUsuario.Text);

                if (usuarios.Count == 0)
                {
                    this.gcUsuarios.DataSource = null;
                    this.ActiveControl = this.tbUsuario;
                    this.tbUsuario.SelectAll();
                    throw new Exception("Sin resultados");
                }

                this.gcUsuarios.DataSource = usuarios;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gcUsuarios_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.gridView1.GetSelectedRows().Count() == 0)
                    return;

                Modelos.PersonaResponsivas ent = new Modelos.PersonaResponsivas();

                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    var dr1 = this.gridView1.GetRow(i);

                    ent = (Modelos.PersonaResponsivas)dr1;
                }

                // imprime datos
                this.tbUsuarioSelec.Text = ent.nombre;
                this.tbPuestoSelec.Text = ent.sucursal;
                this.tbSucursalSelec.Text = ent.puesto;

                this._idPersona = ent.idPersona;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscaActivos_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscaActivos form = new frmBuscaActivos(null, null);

                if(!Modelos.Login.admin)
                    form = new frmBuscaActivos(null, Modelos.Login.idSucursal);

                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // llena el grid los activos seleccionados
                    this.gcActivos.DataSource = form._listaAgregados;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCreaResp_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (this._idPersona == null)
                    throw new Exception("Seleccione una persona");

                if(this.gridView2.DataRowCount == 0)
                    throw new Exception("Añada al menos un activo para asignarlo a la persona");

                if (this.tbObservaciones.Text.Trim().Length < 10)
                {
                    this.lbObservaciones.ForeColor = System.Drawing.Color.Red;
                    this.lbObservaciones.Text = "Observaciones*";
                    throw new Exception("La longitud miníma permitida para las observaciones es de 10 carácteres");
                }
                else
                {
                    this.lbObservaciones.ForeColor = System.Drawing.Color.Black;
                    this.lbObservaciones.Text = "Observaciones";
                }

                List<Modelos.PersonaResponsivas> responsables = new List<Modelos.PersonaResponsivas>();

                if (this.cbAgregaResp.Checked)
                {
                    // obtiene la lista de personas responsables a la responsiva
                    frmAgregaResponsables form = new frmAgregaResponsables(this._idPersona);

                    var respuesta = form.ShowDialog();

                    if (respuesta == System.Windows.Forms.DialogResult.OK)
                    {
                        responsables = form._listaAgregados;
                    }
                    else return;
                }
                
                // obtiene los activos agregados
                List<Modelos.Activos> activos = (List<Modelos.Activos>)this.gridView2.DataSource;

                // registrar responsiva
                bool resultado = this._responsivasNegocio.crearResponsivas(activos, Modelos.Login.idUsuario, this._idPersona, this.tbObservaciones.Text, responsables);

                if (resultado)
                {
                    MessageBox.Show("La responsiva fue creada correctamente", "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string resp = string.Join(",", responsables.Select(s => s.nombre).ToList());

                    // bitacora
                    this._catalogosNegocio.generaBitacora(
                        "Nueva responsiva agregada para la persona: " + this._idPersona +
                        (responsables.Count > 0 ? " con los responsables: " + resp : string.Empty), "RESPONSIVAS");

                    if (this._creaRespActivo)
                        this.Close();

                    _idPersona = null;
                    this.gcUsuarios.DataSource = null;

                    this.tbUsuarioSelec.Text = string.Empty;
                    this.tbSucursalSelec.Text = string.Empty;
                    this.tbPuestoSelec.Text = string.Empty;

                    this.gcActivos.DataSource = null;
                    this.tbObservaciones.Text = string.Empty;
                    this.tbUsuario.Text = string.Empty;

                    this.cbAgregaResp.Checked = false;

                }
                else
                {
                    throw new Exception("Problemas en la creación de la responsiva");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
