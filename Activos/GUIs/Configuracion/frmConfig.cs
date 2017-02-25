using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;
using Activos.GUIs.Permisos;

namespace Activos.GUIs.Imagenes
{
    public partial class frmConfig : Form
    {

        IPermisosNegocio _permisosNegocio;

        // variable que contiene los ids seleccionados
        List<int> _valueList = new List<int>();

        private int? _idPersona = null;
        private bool _nuevaUrl = false;

        ICatalogosNegocio _catalogosNegocio;
        private Modelos.Logo _logo;

        private string _url = string.Empty;

        public frmConfig()
        {
            InitializeComponent();

            this._catalogosNegocio = new CatalogosNegocio();

            this.tvPermisos.CheckBoxes = true;
            this._permisosNegocio = new PermisosNegocio();
        }

        private void frmLogos_Load(object sender, EventArgs e)
        {
            try
            {
                // permisos
                // SELECCIONAR LOGO
                int tag1 = Convert.ToInt16(this.tabPage1.Tag);
                if (!Modelos.Login.permisos.Contains(tag1))
                    foreach (Control ctrl in this.tabPage1.Controls)
                        ctrl.Enabled = false;

                // SUBIR LOGO
                int tag2 = Convert.ToInt16(this.tabPage2.Tag);
                if (!Modelos.Login.permisos.Contains(tag2))
                    foreach (Control ctrl in this.tabPage2.Controls)
                        ctrl.Enabled = false;

                // PERMISOS
                int tag3 = Convert.ToInt16(this.tabPage3.Tag);
                if (!Modelos.Login.permisos.Contains(tag3))
                    foreach (Control ctrl in this.tabPage3.Controls)
                        ctrl.Enabled = false;

                // URL FOTOS
                int tag4 = Convert.ToInt16(this.tabPage4.Tag);
                if (!Modelos.Login.permisos.Contains(tag4))
                    foreach (Control ctrl in this.tabPage4.Controls)
                        ctrl.Enabled = false;




                List<Modelos.UsoLogos> usosSelec = this._catalogosNegocio.getUsosLogos();
                List<Modelos.UsoLogos> usos2Subir = this._catalogosNegocio.getUsosLogos();

                // llenar combo de usos
                this.cmbUso.DisplayMember = "clave";
                this.cmbUso.ValueMember = "idUso";
                this.cmbUso.DataSource = usosSelec;
                this.cmbUso.SelectedIndex = -1;

                this.cmbSubirUso.DisplayMember = "clave";
                this.cmbSubirUso.ValueMember = "idUso";
                this.cmbSubirUso.DataSource = usos2Subir;
                this.cmbSubirUso.SelectedIndex = -1;

                this._url = this._catalogosNegocio.getUrl("url");

                if (string.IsNullOrEmpty(this._url))
                {
                    this.btnCambia.Text = "Guardar";
                    this._nuevaUrl = true;
                }

                this.tbUrl.Text = this._url;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        #region - Seleccionar Logo -

        private void cmbUso_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (this.cmbUso.SelectedIndex == -1)
                    throw new Exception("Seleccione un uso");

                int idUso = (int)this.cmbUso.SelectedValue;

                List<Modelos.Logo> logos = this._catalogosNegocio.getLogos(idUso, "A");

                this.pbSelLogo.Image = null;

                // llenar combo de usos
                this.cmbNombreLogo.DisplayMember = "nombre";
                this.cmbNombreLogo.ValueMember = "idLogo";
                this.cmbNombreLogo.DataSource = logos;

                int seleccionado = logos.Where(w => string.IsNullOrEmpty(w.clave) == false).Select(s => s.idLogo).FirstOrDefault();

                this.cmbNombreLogo.SelectedValue = seleccionado;

                this._logo = (Modelos.Logo)this.cmbNombreLogo.SelectedItem;

                if (this._logo != null)
                {
                    this.btnSeleccionar.Text = "Cambiar Selección";
                    this.pbSelLogo.Image = Modelos.Utilerias.ByteToImage(_logo.logo);
                }
                else
                {
                    this.btnSeleccionar.Text = "Seleccionar";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmbNombreLogo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                this._logo = (Modelos.Logo)this.cmbNombreLogo.SelectedItem;

                this.pbSelLogo.Image = Modelos.Utilerias.ByteToImage(_logo.logo);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._logo == null)
                    throw new Exception("Elija un logo");

                Modelos.UsoLogos uso = (Modelos.UsoLogos)this.cmbUso.SelectedItem;

                bool resultado = this._catalogosNegocio.seleccionarLogo(this._logo.idLogo, uso);

                if (resultado)
                {

                    // bitacora
                    this._catalogosNegocio.generaBitacora(
                        "Logo Seleccionado " + this._logo.idLogo + " para el uso '" + uso.nombre + "'", "ARCHIVO - CONFIGURACION");

                    MessageBox.Show("Logo cambiado para '" + uso.nombre + "' correctamente", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("Problemas al seleccionar el logo");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion
        
        #region - Subir Logo -

        private void btnSubirImagen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog buscaImagen = new OpenFileDialog();
                buscaImagen.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.gif;";
                buscaImagen.Title = "Seleccionar Logo";
                buscaImagen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures);

                if (buscaImagen.ShowDialog() == DialogResult.OK)
                {
                    System.Drawing.Image img = System.Drawing.Image.FromFile(buscaImagen.FileName);

                    int width = img.Width;
                    int heigth = img.Height;

                    if (width > 1500 && heigth > 900)
                        throw new Exception("Las dimensiones de la imagen sobrepasan el tamaño aceptado por el programa");

                    this.tbSubirArchivo.Text = buscaImagen.FileName;
                    string path = buscaImagen.FileName;
                    this.pbSubirImagen.ImageLocation = path;

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSubirSubir_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (string.IsNullOrEmpty(this.tbSubirNombre.Text))
                    throw new Exception("Defina un nombre para el logo");

                if (string.IsNullOrEmpty(this.tbSubirDescripcion.Text))
                    throw new Exception("Defina una descripción para el logo");
                else
                {
                    if (this.tbSubirDescripcion.Text.Trim().Length < 10)
                    {
                        this.label4.ForeColor = System.Drawing.Color.Red;
                        this.label4.Text = "Descripción*";
                        throw new Exception("La longitud miníma permitida para la Descripción es de 10 carácteres");
                    }
                    else
                    {
                        this.label4.ForeColor = System.Drawing.Color.Black;
                        this.label4.Text = "Descripción";
                    }
                }

                if (!string.IsNullOrEmpty(this.tbSubirObserv.Text))
                {
                    if (this.tbSubirObserv.Text.Trim().Length < 10)
                    {
                        this.label5.ForeColor = System.Drawing.Color.Red;
                        this.label5.Text = "Observaciones*";
                        throw new Exception("La longitud miníma permitida para las Observaciones es de 10 carácteres");
                    }

                    this.label5.ForeColor = System.Drawing.Color.Black;
                    this.label5.Text = "Observaciones";
                }

                if (this.cmbSubirUso.SelectedIndex == -1)
                    throw new Exception("Seleccione un uso");

                if (this.pbSubirImagen.Image == null)
                    throw new Exception("Suba un logo");

                Modelos.UsoLogos uso = (Modelos.UsoLogos)this.cmbSubirUso.SelectedItem;

                string nombre = this.tbSubirNombre.Text;
                string descripcion = this.tbSubirDescripcion.Text;
                string observaciones = this.tbSubirObserv.Text;

                bool seleccionar = this.cbSubirSelLogo.Checked;

                byte[] logo = Modelos.Utilerias.ImageToByte(this.pbSubirImagen.Image);

                bool resultado = this._catalogosNegocio.subirLogo(uso, nombre, descripcion, observaciones, seleccionar, logo);

                if (resultado)
                {
                    // bitacora
                    this._catalogosNegocio.generaBitacora(
                        "Logo Subido " + (seleccionar ? "y seleccionado" : string.Empty) + " para el uso '" + uso.nombre + "'", "ARCHIVO - CONFIGURACION");

                    MessageBox.Show(
                        "Logo subido " + (seleccionar ? "y seleccionado" : string.Empty) + " correctamente",
                        "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.tbSubirNombre.Text = string.Empty;
                    this.tbSubirDescripcion.Text = string.Empty;
                    this.tbSubirObserv.Text = string.Empty;

                    this.cmbSubirUso.SelectedIndex = -1;
                    this.tbSubirArchivo.Text = string.Empty;
                    this.pbSubirImagen.Image = null;

                    this.cbSubirSelLogo.Checked = false;
                }
                else
                {
                    throw new Exception("Problemas al subir el logo");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion
        
        #region - Permisos -

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this._valueList = new List<int>();
                this.getCheckedNodes(this.tvPermisos.Nodes);

                // guarda permisos
                bool resultado = this._permisosNegocio.actualizaPermisos(this._idPersona, this._valueList);

                if (resultado)
                {
                    // bitacora
                    this._catalogosNegocio.generaBitacora(
                        "Permisos alterados para '" + this.tbNombre.Text + "'", "ARCHIVO - CONFIGURACION");

                    MessageBox.Show("Permisos actualizados correctamente", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    throw new Exception("Problemas al actualizar los permisos");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private List<int> getCheckedNodes(TreeNodeCollection _parentNodeList)
        {
            foreach (TreeNode item in _parentNodeList)
            {
                if (item.Checked)
                {
                    _valueList.Add(Convert.ToInt32(item.Tag));
                }

                if (item.Nodes.Count > 0)
                {
                    //.NET does not forget where it stayed.
                    getCheckedNodes(item.Nodes);
                }
            }

            return _valueList;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscaUsuario form = new frmBuscaUsuario();

                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.tvPermisos.Nodes.Clear();

                    this.tbNombre.Text = form._usuario.nombre;

                    this._idPersona = form._usuario.idPersona;

                    // obtener todos los permisos del usuario
                    List<int> permisosUsuario = this._permisosNegocio.getPermisosUsuario(form._usuario.idPersona);

                    // carga los permisos
                    List<Modelos.Permisos> permPrinc = this._permisosNegocio.getPermisos(1);

                    // nodo princ
                    TreeNode nodo;

                    foreach (Modelos.Permisos per in permPrinc)
                    {

                        List<Modelos.Permisos> permPrim = this._permisosNegocio.getPermisos(per.idPermiso);

                        // nodo primario
                        TreeNode nodoP;
                        List<TreeNode> nodosP = new List<TreeNode>();

                        foreach (Modelos.Permisos prim in permPrim)
                        {
                            List<Modelos.Permisos> permSec = this._permisosNegocio.getPermisos(prim.idPermiso);

                            // nodo sec
                            TreeNode nodoS;
                            List<TreeNode> nodosS = new List<TreeNode>();

                            foreach (Modelos.Permisos secun in permSec)
                            {
                                nodoS = new TreeNode("  " + secun.descripcion);
                                nodoS.Tag = secun.idPermiso;

                                if (permisosUsuario.Contains(secun.idPermiso))
                                    nodoS.Checked = true;

                                nodosS.Add(nodoS);
                            }

                            nodoP = nodosS.Count == 0 ? new TreeNode("  " + prim.descripcion) : new TreeNode(prim.descripcion, nodosS.ToArray());
                            nodoP.Tag = prim.idPermiso;

                            if (permisosUsuario.Contains(prim.idPermiso))
                                nodoP.Checked = true;

                            nodosP.Add(nodoP);
                        }

                        nodo = nodosP.Count == 0 ? new TreeNode("  " + per.descripcion) : new TreeNode(per.descripcion, nodosP.ToArray());
                        nodo.Tag = per.idPermiso;

                        if (permisosUsuario.Contains(per.idPermiso))
                            nodo.Checked = true;

                        this.tvPermisos.Nodes.Add(nodo);
                    }

                    this.tvPermisos.ExpandAll();
                    this.tvPermisos.Nodes[0].EnsureVisible();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool updatingTreeView;

        private void CheckChildren_ParentSelected(TreeNode node, Boolean isChecked)
        {
            foreach (TreeNode item in node.Nodes)
            {
                item.Checked = isChecked;

                if (item.Nodes.Count > 0)
                {
                    this.CheckChildren_ParentSelected(item, isChecked);
                }
            }
        }

        private void SelectParents(TreeNode node, Boolean isChecked)
        {
            bool _isCheckes = isChecked;

            if (node.Parent != null)
            {
                if (!node.Checked)
                    foreach (TreeNode tn in node.Parent.Nodes)
                    {
                        if (!node.Text.Equals(tn.Text))
                        {
                            if (tn.Checked)
                                _isCheckes = true;
                        }
                    }

                node.Parent.Checked = _isCheckes;
                SelectParents(node.Parent, _isCheckes);
            }
        }

        private void tvPermisos_AfterCheck_1(object sender, TreeViewEventArgs e)
        {

            if (updatingTreeView) return;
            updatingTreeView = true;
            CheckChildren_ParentSelected(e.Node, e.Node.Checked);
            SelectParents(e.Node, e.Node.Checked);
            updatingTreeView = false;
        }

        #endregion

        #region - Configuración -

        private void btnCambia_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (string.IsNullOrEmpty(this.tbUrl.Text))
                    throw new Exception("Defina una ruta");

                string url = this.tbUrl.Text;

                // guarda permisos
                bool resultado = this._permisosNegocio.guardaUrl(url, this._nuevaUrl);

                if (resultado)
                {
                    if (this._nuevaUrl)
                    {
                        // bitacora
                        this._catalogosNegocio.generaBitacora(
                            "URL definida: " + url, "ARCHIVO - CONFIGURACION");
                    }
                    else
                    {
                        // bitacora
                        this._catalogosNegocio.generaBitacora(
                            "URL cambiada de: '" + this._url + "' a '" + url + "'", "ARCHIVO - CONFIGURACION");
                    }

                    MessageBox.Show("Url guardada correctamente", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this._nuevaUrl = false;
                    this._url = url;
                }
                else
                    throw new Exception("Problemas al guardar la url");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

    }
}
