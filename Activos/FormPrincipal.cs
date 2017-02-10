using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.GUIs.Usuarios;
using Activos.GUIs.Sucursales;
using Activos.GUIs.Puestos;
using Activos.GUIs.Areas;
using Activos.Modelos;
using Activos.GUIs.Tipos;
using Activos.GUIs.AltaActivos;
using Activos.GUIs.Responsivas;
using Activos.GUIs.Personas;
using Activos.GUIs.Traspasos;
using Activos.GUIs.Grupos;
using Activos.GUIs.Permisos;
using Activos.GUIs.Reportes;
using Activos.GUIs;

namespace Activos
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                // privilegios
                List<ToolStripMenuItem> allItems = new List<ToolStripMenuItem>();
                foreach (ToolStripMenuItem toolItem in this.menuStrip1.Items)
                {
                    allItems.Add(toolItem);
                    //add sub items
                    allItems.AddRange(GetItems(toolItem));
                }

                foreach (ToolStripMenuItem item in allItems)
                {
                    int tag = Convert.ToInt16(item.Tag);

                    if (!Modelos.Login.permisos.Contains(tag))
                        item.Enabled = false;
                }

                // busca si se tiene seleccionada una impresora de etiquetas
                if (string.IsNullOrEmpty(Properties.Settings.Default.Impresora))
                {
                    DialogResult dialogResult = MessageBox.Show(
                               "No se tiene ninguna impresora para Etiquetas seleccionada\n" +
                               "¿Desea seleccionar una ahora?",
                               "Activos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        frmSelecImpresora form = new frmSelecImpresora();

                        form.ShowDialog();
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private IEnumerable<ToolStripMenuItem> GetItems(ToolStripMenuItem item)
        {
            foreach (ToolStripMenuItem dropDownItem in item.DropDownItems)
            {
                if (dropDownItem.HasDropDownItems)
                {
                    foreach (ToolStripMenuItem subItem in GetItems(dropDownItem))
                        yield return subItem;
                }
                yield return dropDownItem;
            }
        }

        // salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea salir de la aplicación?", "Sistema de Activos", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Valida si el formulario no se encuentre abierto
        private bool validaFormsDuplicados(Type type)
        {
            bool result = true;

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == type)
                {
                    form.Close();

                    result = false;
                    break;
                }
            }

            return result;
        }


        //****************************************************************************************************
        //************** S U C U R S A L E S *****************************************************************
        //****************************************************************************************************
        // abre formulario de Sucursales
        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSucursales child = new frmSucursales();

                this.validaFormsDuplicados(child.GetType());

                child.MdiParent = this;

                child.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //****************************************************************************************************
        //************** P U E S T O S ***********************************************************************
        //****************************************************************************************************
        private void puestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPuestos child = new frmPuestos();

                this.validaFormsDuplicados(child.GetType());

                child.MdiParent = this;

                child.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        //****************************************************************************************************
        //************** U S U A R I O S *********************************************************************
        //****************************************************************************************************
        // alta usuarios
        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAltaUsuarios child = new frmAltaUsuarios();

                this.validaFormsDuplicados(child.GetType());

                child.MdiParent = this;

                child.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // modificaciones usuarios
        private void modificacionesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                frmModifUsuarios child = new frmModifUsuarios();

                this.validaFormsDuplicados(child.GetType());

                child.MdiParent = this;

                child.Show();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // activar usuarios
        private void activarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmActUs child = new frmActUs();

                this.validaFormsDuplicados(child.GetType());

                child.MdiParent = this;

                child.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // baja de usuarios
        private void bajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBajaUsuarios child = new frmBajaUsuarios();

                this.validaFormsDuplicados(child.GetType());

                child.MdiParent = this;

                child.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // cambia clave
        private void cambiaClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmModifContra form = new frmModifContra(Modelos.Login.usuario, Modelos.Login.idUsuario);

                form.ShowDialog();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //****************************************************************************************************
        //************** A R E A S ***************************************************************************
        //****************************************************************************************************
        private void áreasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAreas child = new frmAreas();

                this.validaFormsDuplicados(child.GetType());

                child.MdiParent = this;

                child.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //****************************************************************************************************
        //************** T I P O S ***************************************************************************
        //****************************************************************************************************
        private void tipoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                frmTipos child = new frmTipos();

                this.validaFormsDuplicados(child.GetType());

                child.MdiParent = this;

                child.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        //****************************************************************************************************
        //************** A C T I V O S ***********************************************************************
        //****************************************************************************************************
        private void altasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                frmAltaActivo child = new frmAltaActivo(Login.idUsuario);

                this.validaFormsDuplicados(child.GetType());

                child.MdiParent = this;

                child.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void modificacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmModifActivo child = new frmModifActivo();

                this.validaFormsDuplicados(child.GetType());

                child.MdiParent = this;

                child.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void bajasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmBajaActivo child = new frmBajaActivo();

                this.validaFormsDuplicados(child.GetType());

                child.MdiParent = this;

                child.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void reparacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmActReparacion child = new frmActReparacion();

                this.validaFormsDuplicados(child.GetType());

                child.MdiParent = this;

                child.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //****************************************************************************************************
        //************** R E S P O N S I V A S ***************************************************************
        //****************************************************************************************************
        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmResponsivas child = new frmResponsivas();

                this.validaFormsDuplicados(child.GetType());

                child.MdiParent = this;

                child.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmModifResp child = new frmModifResp();

                this.validaFormsDuplicados(child.GetType());

                child.MdiParent = this;

                child.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void bajasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                frmTraspasarResponsiva child = new frmTraspasarResponsiva();

                this.validaFormsDuplicados(child.GetType());

                child.MdiParent = this;

                child.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void imprimirResponsivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmImprimeResp child = new frmImprimeResp();

                this.validaFormsDuplicados(child.GetType());

                child.MdiParent = this;

                child.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //****************************************************************************************************
        //************** P E R S O N A S *********************************************************************
        //****************************************************************************************************
        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPersonas child = new frmPersonas();

                this.validaFormsDuplicados(child.GetType());

                child.MdiParent = this;

                child.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //****************************************************************************************************
        //************** T R A S P A S O S *******************************************************************
        //****************************************************************************************************
        private void traspasosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmTraspasos child = new frmTraspasos();

                this.validaFormsDuplicados(child.GetType());

                child.MdiParent = this;

                child.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        //****************************************************************************************************
        //************** G R U P O S *************************************************************************
        //****************************************************************************************************

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmAltaGrupos child = new frmAltaGrupos();

                this.validaFormsDuplicados(child.GetType());

                child.MdiParent = this;

                child.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void modificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmModifGrupos child = new frmModifGrupos();

                this.validaFormsDuplicados(child.GetType());

                child.MdiParent = this;

                child.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBajaGrupos child = new frmBajaGrupos();

                this.validaFormsDuplicados(child.GetType());

                child.MdiParent = this;

                child.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        //****************************************************************************************************
        //************** I M P R E S O R A S *****************************************************************
        //****************************************************************************************************

        private void seleccionaImpresoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSelecImpresora child = new frmSelecImpresora();

                child.ShowDialog();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        //****************************************************************************************************
        //************** P E R M I S O S *********************************************************************
        //****************************************************************************************************

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPermisos child = new frmPermisos();

                this.validaFormsDuplicados(child.GetType());

                child.MdiParent = this;

                child.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //****************************************************************************************************
        //************** R E P O R T E S   R E S P O N S I V A S *********************************************
        //****************************************************************************************************
        private void responsivasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmActivosPersona child = new frmActivosPersona();

                this.validaFormsDuplicados(child.GetType());

                child.MdiParent = this;

                child.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void activosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmMovimientosActivos child = new frmMovimientosActivos();

                this.validaFormsDuplicados(child.GetType());

                child.MdiParent = this;

                child.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void actSinRespToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                frmActivosSinResp child = new frmActivosSinResp();

                this.validaFormsDuplicados(child.GetType());

                child.MdiParent = this;

                child.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        
    }
}
