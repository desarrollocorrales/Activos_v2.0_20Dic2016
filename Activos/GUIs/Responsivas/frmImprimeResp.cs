﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Activos.GUIs.Responsivas.Reporte;
using Activos.Negocio;
using Sofbr.Utils.Impresoras;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Activos.GUIs.Responsivas
{
    public partial class frmImprimeResp : Form
    {

        private Modelos.Responsivas _responsiva = null;
        private List<Modelos.Activos> _activos = new List<Modelos.Activos>();

        IResponsivasNegocio _responsivasNegocio;


        public frmImprimeResp()
        {
            InitializeComponent();
            this._responsivasNegocio = new ResponsivasNegocio();
        }

        private void btnBuscaResponsiva_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscarResponsiva form = new frmBuscarResponsiva("B");

                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.tbResponsable.Text = form._responsiva.responsable;
                    this.tbPuesto.Text = form._responsiva.puesto;
                    this.tbSucursal.Text = form._responsiva.sucursal;

                    this._responsiva = form._responsiva;

                    // llena el grid con los puestos disponibles
                    this.gcActivos.DataSource = form._activos;
                    this._activos = form._activos;
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._responsiva == null)
                    throw new Exception("Seleccione una responsiva");


                string fecIng = this.dtpFechaImpr.Value.ToString("dd-MM-yyyy");
                this._responsiva.fechaImpresion = fecIng;

                frmResponsivaReporte form = new frmResponsivaReporte();

                List<Modelos.Activos> activos = new List<Modelos.Activos>();

                // cambia activos
                foreach (Modelos.Activos ac in this._activos)
                {
                    string descripcion = ac.descripcion.Replace("---", ";");
                    string[] array = descripcion.Split(';');

                    descripcion = (!string.IsNullOrEmpty(array[0]) ? " Marca: " + array[0] + ";" : string.Empty) +
                                  (!string.IsNullOrEmpty(array[1]) ? " Modelo: " + array[1] + ";" : string.Empty) +
                                  (!string.IsNullOrEmpty(array[2]) ? " Núm. Serie: " + array[2] + ";" : string.Empty) +
                                  (!string.IsNullOrEmpty(array[3]) ? " Color: " + array[3] + ";" : string.Empty) +
                                  (!string.IsNullOrEmpty(array[4]) ? " \nDetalles: " + array[4] + ";" : string.Empty);

                    activos.Add(new Modelos.Activos
                    {
                        accion = ac.accion,
                        area = ac.area,
                        costo = ac.costo,
                        claveActivo = ac.claveActivo,
                        descripcion = descripcion.Trim(),
                        fechaAlta = ac.fechaAlta,
                        fechaModificacion = ac.fechaModificacion,
                        idActivo = ac.idActivo,
                        idArea = ac.idArea,
                        idTipo = ac.idTipo,
                        idUsuarioAlta = ac.idUsuarioAlta,
                        idUsuarioModifica = ac.idUsuarioModifica,
                        nombreCorto = ac.nombreCorto,
                        numEtiqueta = ac.numEtiqueta,
                        seleccionado = ac.seleccionado,
                        status = ac.status,
                        tipo = ac.tipo

                    });
                }

                form._activos = activos;
                form._responsivas = this._responsiva;

                form.ShowDialog();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnImprEtiquetas_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sbComandos = new StringBuilder();

                if (this._responsiva == null)
                    throw new Exception("Seleccione una responsiva");
                
                string comando = this._responsivasNegocio.getBuscaComandoEt("activo");

                if (string.IsNullOrEmpty(comando))
                    throw new Exception("No se encotró un comando para la etiqueta");

                foreach(Modelos.Activos ac in this._activos)
                {
                    string comEtiqueta = comando;

                    // comEtiqueta = comEtiqueta.Replace("|sucursal|", this._responsiva.sucursal);
                    comEtiqueta = comEtiqueta.Replace("|sucursal|", @"ABASTESEDORA DE CARNES LOS CORRALES S.A. DE C.V.");
                    comEtiqueta = comEtiqueta.Replace("|area|", ac.area);
                    comEtiqueta = comEtiqueta.Replace("|cveActivo|", ac.claveActivo);
                    comEtiqueta = comEtiqueta.Replace("|nombrecorto|", ac.nombreCorto);
                    comEtiqueta = comEtiqueta.Replace("0000000000000", ac.numEtiqueta);
                    comEtiqueta = comEtiqueta.Replace("|url|", ac.url);

                    sbComandos.AppendLine(comEtiqueta);
                }

                if (!string.IsNullOrEmpty(Properties.Settings.Default.Impresora))
                {
                    string impresora = Properties.Settings.Default.Impresora;

                    RawPrinter.SendToPrinter("Etiqueta Produccion", sbComandos.ToString(), impresora);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show(
                               "No se tiene ninguna impresora para Etiquetas seleccionada\n" +
                               "¿Desea seleccionar una ahora?",
                               "Responsivas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        frmSelecImpresora form = new frmSelecImpresora();

                        form.ShowDialog();
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}