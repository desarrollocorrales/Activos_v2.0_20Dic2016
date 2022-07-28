using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activos.Negocio;
using Activos.Modelos;
using System.IO;

namespace Activos
{
    public partial class frmLogin : Form
    {
        ICatalogosNegocio _catalogosNegocio;
        IPermisosNegocio _permisosNegocio;

        public frmLogin()
        {
            InitializeComponent();

            this.ActiveControl = this.tbUsuario;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                this._catalogosNegocio = new CatalogosNegocio();
                this._permisosNegocio = new PermisosNegocio();

                // validaciones
                if (string.IsNullOrEmpty(this.tbUsuario.Text))
                {
                    this.ActiveControl = this.tbUsuario;
                    throw new Exception("Llene el campo Usuario");
                }

                if (string.IsNullOrEmpty(this.tbPass.Text))
                {
                    this.ActiveControl = this.tbPass;
                    throw new Exception("Llene el campo Contraseña");
                }

                Response resp = this._catalogosNegocio.validaAcceso(this.tbUsuario.Text, this.tbPass.Text);

                if (resp.status == Estatus.OK)
                {
                    // almacenar credeniales
                    Modelos.Login.idUsuario = resp.usuario.idUsuario;
                    Modelos.Login.nombre = resp.usuario.nombre;
                    Modelos.Login.usuario = resp.usuario.usuario;
                    Modelos.Login.idSucursal = resp.usuario.idSucursal;

                    Modelos.Login.permisos = this._permisosNegocio.getPermisosUsuario(Modelos.Login.idUsuario);

                    if (Modelos.Login.permisos.Contains(49))
                        Modelos.Login.admin = true;
                    else Modelos.Login.admin = false;

                    // bitacora
                    this._catalogosNegocio.generaBitacora(
                        "Nuevo Acceso a usuario '" + Modelos.Login.nombre.Replace("&", " ") + "'", "ACCESO");

                    this.Hide();
                    new FormPrincipal().ShowDialog();
                    this.Close();
                }
                else throw new Exception(resp.error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnAcceder_Click(null, null);
            }
        }

        private void tbUsuario_Enter(object sender, EventArgs e)
        {
            this.tbUsuario.SelectAll();
        }

        private void tbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.ActiveControl = this.tbPass;
                this.tbPass.SelectAll();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                // valida si ya tiene alguna clave guardada para el archivo
                string cveActual = Properties.Settings.Default.accesoConfig;

                if (string.IsNullOrEmpty(cveActual))
                {
                    string acceso = Modelos.Utilerias.Transform("p4ssw0rd");

                    Properties.Settings.Default.accesoConfig = acceso;
                    Properties.Settings.Default.Save();
                }

                string fileName = "config.dat";
                string pathConfigFile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\SisActivos\";

                // si no existe el directorio, lo crea
                bool exists = System.IO.Directory.Exists(pathConfigFile);

                if (!exists) System.IO.Directory.CreateDirectory(pathConfigFile);

                // busca en el directorio si exite el archivo con el nombre dado
                var file = Directory.GetFiles(pathConfigFile, fileName, SearchOption.AllDirectories)
                        .FirstOrDefault();

                if (file == null)
                {
                    // no existe
                    // abrir el formulario para llenar la configuracion de conexion y licencia
                    frmConfiguracion form = new frmConfiguracion();
                    form.ShowDialog();
                }
                else
                {
                    // si existe
                    // obtener la licencia del archivo y compararla con la que se calcularia
                    // obtener la cadena de conexion del archivo
                    FEncrypt.Respuesta result = FEncrypt.EncryptDncrypt.DecryptFile(file, "milagros");

                    if (result.status == FEncrypt.Estatus.ERROR)
                        throw new Exception(result.error);

                    if (result.status == FEncrypt.Estatus.OK)
                    {
                        string[] list = result.resultado.Split(new string[] { "||" }, StringSplitOptions.None);

                        string empresa = list[0].Substring(2);      // empresa
                        string servidor = list[1].Substring(2);     // servidor
                        string usuario = list[2].Substring(2);      // usuario
                        string contra = list[3].Substring(2);       // contraseña
                        string baseDatos = list[4].Substring(2);    // base de datos
                        string licencia = list[5].Substring(2);     // licencia

                        // verifica licencia (UTILERIAS)
                        string cifrar = servidor.Trim().ToUpper() + "-" + empresa.Trim().ToUpper();

                        string cifrado = Modelos.Utilerias.Transform(cifrar);

                        if (!licencia.Equals(cifrado))
                            throw new Exception("Licencia Inválida\nNo puede usar el sistema");

                        // si licencia pasa asigna cadena de conexion
                        Modelos.ConectionString.conn = string.Format(
                            "server={0};User Id={1};password={2};database={3}",
                            servidor, usuario, contra, baseDatos);

                        Modelos.Login.empresa = empresa;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmAcceso formA = new frmAcceso();

            var respuesta = formA.ShowDialog();

            if (respuesta == System.Windows.Forms.DialogResult.OK)
            {
                frmConfiguracion form = new frmConfiguracion();
                form.ShowDialog();
            }
        }

    }
}
