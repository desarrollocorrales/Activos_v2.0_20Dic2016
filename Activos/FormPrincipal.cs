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
using Activos.GUIs.Ejemplos_QR;
using Activos.GUIs.AltaActivos;
using Activos.GUIs.Responsivas;
using Activos.GUIs.Personas;
using Activos.GUIs.Traspasos;

namespace Activos
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
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
        //************** E J E M P L O   Q R *****************************************************************
        //****************************************************************************************************
        private void ejemploQRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                EjemploQR child = new EjemploQR();

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

    }
}
