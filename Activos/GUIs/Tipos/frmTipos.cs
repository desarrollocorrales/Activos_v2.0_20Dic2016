﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;

namespace Activos.GUIs.Tipos
{
    public partial class frmTipos : Form
    {
        ICatalogosNegocio _catalogosNegocio;

        public frmTipos()
        {
            InitializeComponent();
            this._catalogosNegocio = new CatalogosNegocio();
        }

        private void frmTipos_Load(object sender, EventArgs e)
        {
            try
            {
                // permisos
                foreach (Control x in this.Controls)
                {
                    if (x is Button)
                    {
                        int tag = Convert.ToInt16(((Button)x).Tag);

                        if (!Modelos.Login.permisos.Contains(tag))
                            ((Button)x).Enabled = false;
                    }
                }

                // llena el grid con los puestos disponibles
                this.gcTipos.DataSource = this._catalogosNegocio.getTipos("A");

                if (this.gridView1.RowCount != 0)
                    this.gridView1.UnselectRow(0);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Tipos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.tbNombreTipo.Text))
                    throw new Exception("Defina un nombre para el tipo");

                int marca = this.cbMarca.Checked ? 1 : 0;
                int modelo = this.cbModelo.Checked ? 1 : 0;
                int serie = this.cbSerie.Checked ? 1 : 0;
                int color = this.cbColor.Checked ? 1 : 0;
                int costo = this.cbCosto.Checked ? 1 : 0;
                int factura = this.cbFactura.Checked ? 1 : 0;
                int fechaCompra = this.cbFechaCompra.Checked ? 1 : 0;

                // guardado de informacion
                bool resultado =
                    this._catalogosNegocio.agregaTipo(
                        this.tbNombreTipo.Text,
                        marca, modelo, serie, color, costo, factura, fechaCompra);


                if (resultado)
                {
                    MessageBox.Show("Tipo agregado correctamente", "Agregar Tipos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tbNombreTipo.Text = string.Empty;

                    this.cbMarca.Checked = false;
                    this.cbModelo.Checked = false;
                    this.cbSerie.Checked = false;
                    this.cbColor.Checked = false;
                    this.cbColor.Checked = false;
                    this.cbColor.Checked = false;
                    this.cbCosto.Checked = false;
                    this.cbFactura.Checked = false;
                    this.cbFechaCompra.Checked = false;
                }

                // actualizar grid
                this.gcTipos.DataSource = this._catalogosNegocio.getTipos("A");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Tipos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                frmActTipos form = new frmActTipos();

                var result = form.ShowDialog();

                if (result == DialogResult.OK || result == DialogResult.Cancel)
                {
                    // llena el grid con los puestos disponibles
                    this.gcTipos.DataSource = this._catalogosNegocio.getTipos("A");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Tipos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnElimSel_Click(object sender, EventArgs e)
        {
            try
            {
                List<Modelos.Tipos> puestos = (List<Modelos.Tipos>)this.gridView1.DataSource;

                // obtiene los ids de los puestos seleccionadas
                List<int> seleccionados = puestos.Where(w => w.seleccionado == true).Select(s => s.idTipo).ToList();
                List<string> strings = puestos.Where(w => w.seleccionado == true).Select(s => s.nombre).ToList();

                if (seleccionados.Count == 0)
                    throw new Exception("No se ha seleccionado ningun tipo");

                DialogResult dialogResult = MessageBox.Show(
                                "¿Desea dar de baja los tipos seleccionados?",
                                "Áreas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.No) return;

                // dar de baja los seleccionados
                bool resultado = this._catalogosNegocio.bajaTipos(seleccionados, strings);

                if (resultado)
                    MessageBox.Show("Tipo(s) dado(s) de baja correctamente", "Tipos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // llena el grid con los puestos disponibles
                this.gcTipos.DataSource = this._catalogosNegocio.getTipos("A");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Tipos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gcTipos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                // PERMISOS
                if (!Modelos.Login.permisos.Contains(56))
                    return;

                if (this.gridView1.GetSelectedRows().Count() == 0)
                    throw new Exception("No a seleccionado un puesto");

                Modelos.Tipos ent = new Modelos.Tipos();
                    
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    var dr1 = this.gridView1.GetRow(i);

                    ent = (Modelos.Tipos)dr1;
                }

                frmModiftipos form = new frmModiftipos(ent.idTipo, ent.nombre,
                    ent.marca.Equals("NO") ? false : true,
                    ent.modelo.Equals("NO") ? false : true,
                    ent.serie.Equals("NO") ? false : true,
                    ent.color.Equals("NO") ? false : true,
                    ent.costo.Equals("NO") ? false : true,
                    ent.factura.Equals("NO") ? false : true,
                    ent.fechaCompra.Equals("NO") ? false : true
                    );

                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // llena el grid con los puestos disponibles
                    this.gcTipos.DataSource = this._catalogosNegocio.getTipos("A");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Tipos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
