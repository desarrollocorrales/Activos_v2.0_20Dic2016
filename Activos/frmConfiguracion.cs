using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Activos.Negocio;

namespace Activos
{
    public partial class frmConfiguracion : Form
    {
        ICatalogosNegocio _catalogosNegocio;

        private bool _pruebaCon = false;

        private string _path = string.Empty;
        private bool _correcto = false;
        private bool _empresa = false;

        public frmConfiguracion()
        {
            InitializeComponent();
            this._pruebaCon = false;
        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            try
            {
                string fileName = "config.dat";
                string pathConfigFile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\SisActivos\";

                // si no existe el directorio, lo crea
                bool exists = System.IO.Directory.Exists(pathConfigFile);

                if (!exists) System.IO.Directory.CreateDirectory(pathConfigFile);

                // busca en el directorio si exite el archivo con el nombre dado
                var file = Directory.GetFiles(pathConfigFile, fileName, SearchOption.AllDirectories)
                        .FirstOrDefault();

                this._path = pathConfigFile + fileName;

                if (file != null)
                {
                    // si existe
                    // cargar los datos en los campos
                    this.tbEmpresa.Enabled = false;
                    this.tbLicencia.Enabled = false;

                    FEncrypt.Respuesta result = FEncrypt.EncryptDncrypt.DecryptFile(this._path, "milagros");

                    if (result.status == FEncrypt.Estatus.ERROR)
                        throw new Exception(result.error);

                    if (result.status == FEncrypt.Estatus.OK)
                    {
                        string[] list = result.resultado.Split(new string[] { "||" }, StringSplitOptions.None);

                        this.tbEmpresa.Text = list[0].Substring(2);     // empresa
                        this.tbServidor.Text = list[1].Substring(2);    // servidor
                        this.tbUsuario.Text = list[2].Substring(2);     // usuario
                        this.tbContrasenia.Text = list[3].Substring(2); // contraseña
                        this.tbBaseDeDatos.Text = list[4].Substring(2); // base de datos
                        this.tbLicencia.Text = list[5].Substring(2);    // licencia
                    }

                    this._empresa = true;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                foreach (Control x in this.Controls)
                {
                    if (x is TextBox)
                    {
                        if (string.IsNullOrEmpty(((TextBox)x).Text))
                            throw new Exception("Campos incompletos, Por favor verifique");
                    }
                }

                if (!this._pruebaCon)
                    throw new Exception("Realice una prueba de conexión para verificar el acceso a la base de datos");
                
                // define texto del archivo
                string cadena = string.Empty;

                cadena += "E_" + this.tbEmpresa.Text + "||";
                cadena += "S_" + this.tbServidor.Text + "||";
                cadena += "U_" + this.tbUsuario.Text + "||";
                cadena += "C_" + this.tbContrasenia.Text + "||";
                cadena += "B_" + this.tbBaseDeDatos.Text + "||";

                cadena += "L_" + this.tbLicencia.Text;

                // verifica licencia
                string cifrar = this.tbServidor.Text.Trim().ToUpper() + "-" + this.tbEmpresa.Text.Trim().ToUpper();

                string cifrado = Modelos.Utilerias.Transform(cifrar);

                if (!this.tbLicencia.Text.Equals(cifrado))
                    throw new Exception("Verifique la Licencia");

                if (!this._empresa)
                {
                    // avisa sobre la empresa
                    DialogResult dialogResult = MessageBox.Show(
                                   "La empresa se mostrará en reportes y etiquetas, una vez definido el nombre no puede volverlo a cambiar\n" +
                                   "Los datos de conexión si se podrán cambiar\n" +
                                   "¿Desea continuar?",
                                   "Configuración", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.No) return;
                }

                // prosigue con la creación del archivo
                FEncrypt.Respuesta result = FEncrypt.EncryptDncrypt.EncryptFile("milagros", cadena, this._path);

                if (result.status == FEncrypt.Estatus.ERROR)
                    throw new Exception(result.error);

                if (result.status == FEncrypt.Estatus.OK)
                {
                    Modelos.ConectionString.conn = string.Format(
                        "server={0};User Id={1};password={2};database={3}",
                        this.tbServidor.Text,
                        this.tbUsuario.Text,
                        this.tbContrasenia.Text,
                        this.tbBaseDeDatos.Text);

                    Modelos.Login.empresa = this.tbEmpresa.Text;

                    MessageBox.Show("Se cargó correctamente la información", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this._correcto = true;
                    this.Close();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnTestConn_Click(object sender, EventArgs e)
        {
            try
            {
                // expresion regular para ips
                // si se ingresa una ip, no es valida la cadena de entrada
                if (Modelos.Utilerias.esIp(this.tbServidor.Text))
                    throw new Exception("Utilice el nombre del servidor en lugar de su IP");

                Modelos.ConectionString.conn = string.Format(
                            "server={0};User Id={1};password={2};database={3}",
                            this.tbServidor.Text,
                            this.tbUsuario.Text,
                            this.tbContrasenia.Text,
                            this.tbBaseDeDatos.Text);

                this._catalogosNegocio = new CatalogosNegocio();

                List<Modelos.Sucursales> sucursales = this._catalogosNegocio.getSucursales("A");

                MessageBox.Show("Conexión Exitosa!!!", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this._pruebaCon = true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Falló la conexión a la base de datos", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmConfiguracion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this._correcto)
            {
                MessageBox.Show("Operación Cancelada", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbEmpresa_TextChanged(object sender, EventArgs e)
        {
            this.tbLicencia.Text = string.Empty;
        }
    }
}
