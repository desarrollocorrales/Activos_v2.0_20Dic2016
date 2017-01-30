using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace Activos.GUIs.Ejemplos_QR
{
    public partial class EjemploQR : Form
    {
        public EjemploQR()
        {
            InitializeComponent();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {

            FEncrypt.Respuesta result = FEncrypt.EncryptDncrypt.EncryptFile("holahola", "hola\nMundo\nbuenos\ndias", @"C:\Users\Guillermo\Pictures\config.txt");


            MessageBox.Show(result.status.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FEncrypt.Respuesta result = FEncrypt.EncryptDncrypt.DecryptFile(@"C:\Users\Guillermo\Pictures\config.txt", "holahola");

            MessageBox.Show(result.resultado);
        }
    }
}
