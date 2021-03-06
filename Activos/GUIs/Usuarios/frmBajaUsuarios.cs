﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;

namespace Activos.GUIs.Usuarios
{
    public partial class frmBajaUsuarios : Form
    {
        ICatalogosNegocio _catalogosNegocio;

        public frmBajaUsuarios()
        {
            InitializeComponent();

            this._catalogosNegocio = new CatalogosNegocio();
        }

        private void frmBajaUsuarios_Load(object sender, EventArgs e)
        {
            // llena el grid con las sucursales disponibles
            this.gcUsuariosBaja.DataSource = this._catalogosNegocio.getPersonas("A");

            if (this.gridView1.RowCount != 0)
                this.gridView1.UnselectRow(0);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                List<Modelos.Usuarios> sucursales = (List<Modelos.Usuarios>)this.gridView1.DataSource;

                // obtiene los ids de los usuarios seleccionadas
                List<int> seleccionados = sucursales.Where(w => w.seleccionado == true).Select(s => s.idUsuario).ToList();
                List<string> strings = sucursales.Where(w => w.seleccionado == true).Select(s => s.usuario).ToList();

                if (seleccionados.Count == 0)
                    throw new Exception("No se ha seleccionado ningun Usuario");

                DialogResult dialogResult = MessageBox.Show(
                                "¿Desea dar de baja los usuarios seleccionados?",
                                "Áreas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.No) return;

                // dar de baja los seleccionados
                bool resultado = this._catalogosNegocio.bajaUsuarios(seleccionados, strings);

                if (resultado)
                    MessageBox.Show("Usuario(s) dado(s) de baja correctamente", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // llena el grid con las sucursales disponibles
                this.gcUsuariosBaja.DataSource = this._catalogosNegocio.getPersonas("A");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
