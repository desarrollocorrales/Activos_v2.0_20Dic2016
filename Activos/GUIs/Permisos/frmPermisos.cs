using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;

namespace Activos.GUIs.Permisos
{
    public partial class frmPermisos : Form
    {
        IPermisosNegocio _permisosNegocio;

        // variable que contiene los ids seleccionados
        List<int> _valueList = new List<int>();

        private int? _idPersona = null;

        public frmPermisos()
        {
            InitializeComponent();

            this.tvPermisos.CheckBoxes = true;
            this._permisosNegocio = new PermisosNegocio();
        }

        private void frmPermisos_Load(object sender, EventArgs e)
        {
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this._valueList = new List<int>();
            this.getCheckedNodes(this.tvPermisos.Nodes);

            // guarda permisos
            bool resultado = this._permisosNegocio.actualizaPermisos(this._idPersona, this._valueList);

            if (resultado)
            {
                MessageBox.Show("Permisos actualizados correctamente", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                throw new Exception("Problemas al actualizar los permisos");
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
                MessageBox.Show(Ex.Message, "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void tvPermisos_AfterCheck(object sender, TreeViewEventArgs e)
        {
            
            if (updatingTreeView) return;
            updatingTreeView = true;
            CheckChildren_ParentSelected(e.Node, e.Node.Checked);
            SelectParents(e.Node, e.Node.Checked);
            updatingTreeView = false;
        }

    }
}
