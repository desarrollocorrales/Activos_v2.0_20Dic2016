﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;
using Activos.Modelos;

namespace Activos.GUIs.Usuarios
{
    public partial class frmModifUsuarios : Form
    {
        ICatalogosNegocio _catalogosNegocio;

        public frmModifUsuarios()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this._catalogosNegocio = new CatalogosNegocio();
        }

        private void frmModifUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                // llena el combo de usuarios
                this.cmbSelecUsuario.DataSource = this._catalogosNegocio.getPersonas("A");
                this.cmbSelecUsuario.DisplayMember = "nombre";
                this.cmbSelecUsuario.ValueMember = "idUsuario";
                this.cmbSelecUsuario.SelectedIndex = -1;


                // llena el catalogo de puestos disponibles
                this.cmbPuesto.DataSource = this._catalogosNegocio.getPuestos("A");
                this.cmbPuesto.DisplayMember = "nom_suc";
                this.cmbPuesto.ValueMember = "idPuesto";
                this.cmbPuesto.SelectedIndex = -1;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmbSelecUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbSelecUsuario.SelectedIndex == -1)
                {
                    this.cmbPuesto.SelectedIndex = -1;

                    this.tbNombre.Text = string.Empty;
                    this.tbCorreo.Text = string.Empty;

                    this.dtpFechaIngreso.Value = DateTime.Now;

                    return;
                }

                this.tbNombre.Text = ((Modelos.Usuarios)this.cmbSelecUsuario.SelectedItem).nombre;
                this.tbCorreo.Text = ((Modelos.Usuarios)this.cmbSelecUsuario.SelectedItem).correo;
                this.dtpFechaIngreso.Text = ((Modelos.Usuarios)this.cmbSelecUsuario.SelectedItem).fechaIngreso;
                this.cmbPuesto.SelectedValue = ((Modelos.Usuarios)this.cmbSelecUsuario.SelectedItem).idPuesto;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones 
                if (this.cmbSelecUsuario.SelectedIndex == -1)
                    throw new Exception("Seleccione un usuario para modificar");

                if (string.IsNullOrEmpty(this.tbCorreo.Text))
                    throw new Exception("Llene el campo 'Correo'");

                string correo = this.tbCorreo.Text;

                int idUsuario = (int)this.cmbSelecUsuario.SelectedValue;

                // guarda el usuario
                bool resp = this._catalogosNegocio.modificacionUsuario(correo, idUsuario);

                if (resp)
                {
                    MessageBox.Show("El usuario ha sido Actualizado correctamente", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
    }
}