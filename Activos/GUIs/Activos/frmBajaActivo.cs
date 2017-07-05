using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;
using Activos.GUIs.Activos;

namespace Activos.GUIs.AltaActivos
{
    public partial class frmBajaActivo : Form
    {
        IActivosNegocio _activosNegocio;
        ICatalogosNegocio _catalogosNegocio;
        private int? _idActivo = null;
        IResponsivasNegocio _responsivasNegocio;

        private string _sucursal;
        private string _usuario;

        public frmBajaActivo()
        {
            InitializeComponent();

            this._catalogosNegocio = new CatalogosNegocio();
            this._activosNegocio = new ActivosNegocio();
            this._responsivasNegocio = new ResponsivasNegocio();
        }

        private void frmBajaActivo_Load(object sender, EventArgs e)
        {
            try
            {
                this.lbCveActivo.Text = string.Empty;
                this.lbNumetiqueta.Text = string.Empty;
                this.tbUsuario.Text = string.Empty;

                this.dtpFecha.MaxDate = DateTime.Today.AddDays(10);

                // permisos bajas responsivas
                // bajas = 67
                // reparacion = 68
                List<Modelos.MotivosBaja> motivos = this._catalogosNegocio.getMotivosBaja();

                if (Modelos.Login.permisos.Contains(67))
                {
                    if (!Modelos.Login.permisos.Contains(68))
                        motivos = motivos.Where(w => w.clave.Equals("B")).ToList();
                }
                else
                {
                    if (Modelos.Login.permisos.Contains(68))
                        motivos = motivos.Where(w => w.clave.Equals("R")).ToList();

                    else
                        motivos = motivos.Where(w => w.clave.Equals("A")).ToList();
                }

                // carga combo motivos
                this.cbMotivo.ValueMember = "idMotivoBaja";
                this.cbMotivo.DisplayMember = "motivo";
                this.cbMotivo.DataSource = motivos;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBusqAct_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscActivos form = new frmBuscActivos("BAJAS");

                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // muestra los datos del activo
                    Modelos.ActivosDesc activo = form._activoSelecc;
                    string[] array = activo.descripcion.Split('&');

                    this.tbNombre.Text = activo.nombreCorto;
                    this.tbTipo.Text = activo.tipo;
                    this.tbSucursal.Text = activo.sucursal;
                    this.tbArea.Text = activo.area;
                    this.tbMarca.Text = array[0];
                    this.tbModelo.Text = array[1];
                    this.tbNumSerie.Text = array[2];
                    this.tbColor.Text = array[3];
                    this.tbCosto.Text = array[4];
                    this.tbFactura.Text = array[5];
                    this.dtpFechaConsulta.Text = array[6];
                    this.tbDescripcion.Text = array[7];
                    this.tbUsuario.Text = activo.usuario;

                    this.lbNumetiqueta.Text = activo.numEtiqueta;
                    this.lbCveActivo.Text = activo.claveActivo;
                    
                    this._idActivo = activo.idActivo;

                    this._usuario = activo.usuario;
                    this._sucursal = activo.sucursal;

                    // reinicia campos
                    this.cbMotivo.SelectedIndex = -1;
                    this.tbDetalles.Text = string.Empty;
                }

                if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Operación Cancelada", "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRealizaMto_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (this._idActivo == null)
                    throw new Exception("Seleccione un activo");

                if (this.cbMotivo.SelectedIndex == -1)
                    throw new Exception("Seleccione un motivo");

                if (string.IsNullOrEmpty(this.tbDetalles.Text))
                    throw new Exception("Proporcione un detalle");

                if (this.tbDetalles.Text.Trim().Length < 10)
                {
                    this.label10.ForeColor = System.Drawing.Color.Red;
                    this.label10.Text = "Detalles*";
                    throw new Exception("La longitud miníma permitida para los Detalles es de 10 carácteres");
                }
                else
                {
                    this.label10.ForeColor = System.Drawing.Color.Black;
                    this.label10.Text = "Detalles";
                }

                if (string.IsNullOrEmpty(this.dtpFecha.Text))
                    throw new Exception("Seleccione una fecha");

                string motivo = ((Modelos.MotivosBaja)this.cbMotivo.SelectedItem).clave;
                int idMotivo = ((Modelos.MotivosBaja)this.cbMotivo.SelectedItem).idMotivoBaja;
                string fecha = this.dtpFecha.Value.ToString("yyyy-MM-dd");
                string detalle = this.tbDetalles.Text;

                bool resultado;

                List<Modelos.Activos> activoT = this._activosNegocio.getActivo((long)this._idActivo);

                resultado = this._activosNegocio.bajaActivo(this._idActivo, idMotivo, motivo, detalle, fecha, Modelos.Login.idUsuario);

                if (resultado)
                {
                    MessageBox.Show("Movimiento realizado correctamente", "Activos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string mot = ((Modelos.MotivosBaja)this.cbMotivo.SelectedItem).motivo;

                    if (motivo.Equals("R"))
                    {
                        // manda a abrir el formulario de Reparacion
                        frmReporteRepara form = new frmReporteRepara();

                        form._activos = activoT;
                        form._empresa = Modelos.Login.empresa;
                        form._logo = this._responsivasNegocio.obtieneLogo("reportes");

                        List<Modelos.PersonaResponsivas> res = new List<Modelos.PersonaResponsivas>();
                        res.Add(new Modelos.PersonaResponsivas {nombre = this._usuario, sucursal = this._sucursal });
                        form._responsables = res;

                        form._fecha = fecha;
                        form._movimiento = detalle;
                        form._activacion = string.Empty;

                        form.Show();

                        // bitacora
                        this._catalogosNegocio.generaBitacora(
                            "Se genero la vista previa del informe de Reparacion, ACTIVO: " + this._idActivo, "ACTIVOS");
                    }

                    if (motivo.Equals("B"))
                    {
                        // manda a abrir el formulario de Reparacion
                        frmReporteBaja form = new frmReporteBaja();

                        form._activos = activoT;
                        form._empresa = Modelos.Login.empresa;
                        form._logo = this._responsivasNegocio.obtieneLogo("reportes");

                        List<Modelos.PersonaResponsivas> res = new List<Modelos.PersonaResponsivas>();
                        res.Add(new Modelos.PersonaResponsivas { nombre = this._usuario, sucursal = this._sucursal });
                        form._responsables = res;

                        form._fecha = fecha;
                        form._movimiento = detalle;

                        form.Show();

                        // bitacora
                        this._catalogosNegocio.generaBitacora(
                            "Se genero la vista previa del informe de Baja, ACTIVO: " + this._idActivo, "ACTIVOS");
                    }

                    // bitacora
                    this._catalogosNegocio.generaBitacora(
                        "Activo " + this._idActivo + " enviado a: " + mot + "/detalle: " + detalle, "ACTIVOS");


                    this.tbNombre.Text = string.Empty;
                    this.tbTipo.Text = string.Empty;
                    this.tbSucursal.Text = string.Empty;
                    this.tbArea.Text = string.Empty;
                    this.tbMarca.Text = string.Empty;
                    this.tbModelo.Text = string.Empty;
                    this.tbNumSerie.Text = string.Empty;
                    this.tbColor.Text = string.Empty;
                    this.tbFactura.Text = string.Empty;
                    this.tbCosto.Text = string.Empty;

                    this.tbDescripcion.Text = string.Empty;
                    this.tbUsuario.Text = string.Empty;

                    this.lbNumetiqueta.Text = string.Empty;
                    this.lbCveActivo.Text = string.Empty;

                    this._idActivo = null;

                    // reinicia campos
                    this.cbMotivo.SelectedIndex = -1;
                    this.tbDetalles.Text = string.Empty;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Activos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
