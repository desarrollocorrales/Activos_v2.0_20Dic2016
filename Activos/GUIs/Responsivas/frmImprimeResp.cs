using System;
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
using System.Configuration;

namespace Activos.GUIs.Responsivas
{
    public partial class frmImprimeResp : Form
    {
        ICatalogosNegocio _catalogosNegocio;

        private Modelos.Responsivas _responsiva = null;
        private List<Modelos.Activos> _activos = new List<Modelos.Activos>();

        IResponsivasNegocio _responsivasNegocio;

        public frmImprimeResp()
        {
            InitializeComponent();
            this._responsivasNegocio = new ResponsivasNegocio();
            this._catalogosNegocio = new CatalogosNegocio();
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

                    this.tbFolio.Text = form._responsiva.idResponsiva.ToString();

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
                    string descripcion = ac.descripcion.Replace("&", ";");
                    string[] array = descripcion.Split(';');

                    descripcion = (!string.IsNullOrEmpty(array[0]) ? " Marca: " + array[0] + ";" : string.Empty) +
                                  (!string.IsNullOrEmpty(array[1]) ? " Modelo: " + array[1] + ";" : string.Empty) +
                                  (!string.IsNullOrEmpty(array[2]) ? " Núm. Serie: " + array[2] + ";" : string.Empty) +
                                  (!string.IsNullOrEmpty(array[3]) ? " Color: " + array[3] + ";" : string.Empty) +
                                  (!string.IsNullOrEmpty(array[4]) ? " Costo: " + array[4] + ";" : string.Empty) +
                                  (!string.IsNullOrEmpty(array[5]) ? " Factura: " + array[5] + ";" : string.Empty) +
                                  (!string.IsNullOrEmpty(array[6]) ? " \nFecha: " + array[6] + ";" : string.Empty)+
                                    (!string.IsNullOrEmpty(array[6]) ? " \nDetalles: " + array[7] + ";" : string.Empty);

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

                // obtiene responsables
                List<Modelos.PersonaResponsivas> responsables = this._responsivasNegocio.obtieneResponsables(this._responsiva.idResponsiva);

                // obtiene logo
                Modelos.Logo logo = this._responsivasNegocio.obtieneLogo("reportes");

                form._logo = logo;
                form._responsables = responsables;
                form._activos = activos;
                form._responsivas = this._responsiva;

                form._empresa = Modelos.Login.empresa;

                form.Show();


                // bitacora
                this._catalogosNegocio.generaBitacora(
                    "Se genero la vista previa de la responsiva " + this._responsiva.idResponsiva, "RESPONSIVAS");

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
                
                // string url = ConfigurationManager.AppSettings["url"];

                string url = this._catalogosNegocio.getUrl("url");
                string aaaaaa = string.Empty;
                foreach (Modelos.Activos ac in this._activos)
                {
                    string comando = this._responsivasNegocio.getBuscaComandoEt("activo");

                    if (string.IsNullOrEmpty(comando))
                        throw new Exception("No se encontró un comando para la etiqueta");

                    string[] tipoArray = ac.tipo.Split(' ');

                    List<string> listOfStrings = new List<string>();

                    string agregado = string.Empty;
                    string linea = string.Empty;

                    foreach (string ta in tipoArray)
                    {

                        agregado += ta + " ";

                        if (agregado.Trim().Length >= 13)
                        {
                            listOfStrings.Add(linea);
                            linea = string.Empty;
                            agregado = ta + " ";
                        }

                        linea += ta + " ";
                    }

                    if (!string.IsNullOrEmpty(linea))
                        listOfStrings.Add(linea);

                    linea = string.Empty;

                    if (listOfStrings.Count > 1)
                    {
                        linea = "\nA244,149,2,4,1,1,N,\"" + listOfStrings[1] + "\"";
                    }

                    if (listOfStrings.Count > 2)
                    {
                        linea += "\nA244,114,2,4,1,1,N,\"" + listOfStrings[2] + "\"";
                    }

                    comando = comando.Insert(comando.IndexOf("|tipo|") + 7, linea);

                    string comEtiqueta = comando;


                    comEtiqueta = comEtiqueta.Replace("|A|", ac.numEtiqueta[1].ToString());
                    comEtiqueta = comEtiqueta.Replace("|B|", ac.numEtiqueta[2].ToString());
                    comEtiqueta = comEtiqueta.Replace("|C|", ac.numEtiqueta[3].ToString());
                    comEtiqueta = comEtiqueta.Replace("|D|", ac.numEtiqueta[4].ToString());
                    comEtiqueta = comEtiqueta.Replace("|E|", ac.numEtiqueta[5].ToString());
                    comEtiqueta = comEtiqueta.Replace("|F|", ac.numEtiqueta[6].ToString());
                    comEtiqueta = comEtiqueta.Replace("|G|", ac.numEtiqueta[7].ToString());
                    comEtiqueta = comEtiqueta.Replace("|H|", ac.numEtiqueta[8].ToString());
                    comEtiqueta = comEtiqueta.Replace("|I|", ac.numEtiqueta[9].ToString());
                    comEtiqueta = comEtiqueta.Replace("|J|", ac.numEtiqueta[10].ToString());
                    comEtiqueta = comEtiqueta.Replace("|K|", ac.numEtiqueta[11].ToString());
                    comEtiqueta = comEtiqueta.Replace("|L|", ac.numEtiqueta[12].ToString());
                    comEtiqueta = comEtiqueta.Replace("|M|", ac.numEtiqueta[0].ToString());


                    comEtiqueta = comEtiqueta.Replace("|tipo|", listOfStrings[0]);

                    comEtiqueta = comEtiqueta.Replace("|cveAct|", ac.claveActivo);

                    comEtiqueta = comEtiqueta.Replace("0000000000000", ac.numEtiqueta);
                    // comEtiqueta = comEtiqueta.Replace("|url|", ac.url);
                    comEtiqueta = comEtiqueta.Replace("|url|", string.Format(url + "{0}", ac.idActivo));

                    sbComandos.AppendLine(comEtiqueta);

                    aaaaaa += comEtiqueta;
                }

                if (!string.IsNullOrEmpty(Properties.Settings.Default.Impresora))
                {
                    string impresora = Properties.Settings.Default.Impresora;

                    RawPrinter.SendToPrinter("Etiqueta Produccion", sbComandos.ToString(), impresora);

                    string activos = string.Join(",", this._activos.Select(s => s.idActivo).ToList());

                    // bitacora
                    this._catalogosNegocio.generaBitacora(
                        "Se imprimieron los activos de la responsiva " + this._responsiva.idResponsiva + 
                        "los cuales fueron " + activos, "RESPONSIVAS");

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

        private void btnBusFolio_Click(object sender, EventArgs e)
        {
            try
            {
                // validacion
                if (string.IsNullOrEmpty(this.tbFolio.Text))
                    throw new Exception("Defina un folio");

                int folio = Convert.ToInt16(this.tbFolio.Text);

                // obtiene responsables
                Modelos.RespPorFolio respFolio = this._responsivasNegocio.obtieneRespXFolio(folio);

                if (respFolio == null)
                {
                    this.gcActivos.DataSource = null;
                    this.ActiveControl = this.tbFolio;
                    this.tbFolio.SelectAll();

                    this.tbResponsable.Text = string.Empty;
                    this.tbPuesto.Text = string.Empty;
                    this.tbSucursal.Text = string.Empty;

                    throw new Exception("Sin resultados");
                }

                this.gcActivos.DataSource = null;
                this.ActiveControl = this.tbFolio;
                this.tbFolio.SelectAll();

                this.tbResponsable.Text = respFolio.responsiva.responsable;
                this.tbPuesto.Text = respFolio.responsiva.puesto;
                this.tbSucursal.Text = respFolio.responsiva.sucursal;

                this._responsiva = respFolio.responsiva;

                // llena el grid con los puestos disponibles
                this.gcActivos.DataSource = respFolio.activos;
                this._activos = respFolio.activos;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Responsivas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void tbFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnBusFolio_Click(null, null);
            }
        }

    }
}
