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
using Activos.Modelos;

namespace Activos
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAltaUsuarios child = new frmAltaUsuarios();

                if (!this.validaFormsDuplicados(child.GetType()))
                    throw new Exception("Ya tiene abierto el formulario que intenta abrir");

                child.MdiParent = this;

                child.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void modificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmModifUsuarios child = new frmModifUsuarios();

                if (!this.validaFormsDuplicados(child.GetType()))
                    throw new Exception("Ya tiene abierto el formulario que intenta abrir");

                child.MdiParent = this;

                child.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
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

                if (!this.validaFormsDuplicados(child.GetType()))
                    throw new Exception("Ya tiene abierto el formulario que intenta abrir");

                child.MdiParent = this;

                child.Show();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
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
                    form.Activate();
                    result = false;
                    break;
                }
            }

            return result;
        }


    }
}
