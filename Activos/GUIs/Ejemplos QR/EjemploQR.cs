using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gma.QrCodeNet.Encoding;
using System.Drawing.Imaging;
using System.IO;
using Gma.QrCodeNet.Encoding.Windows.Render;

namespace Activos.GUIs.Ejemplos_QR
{
    public partial class EjemploQR : Form
    {
        public EjemploQR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = this.textBox1.Text;

            string tipo = this.textBox2.Text;

            QrEncoder qrEncoder = null;


            if (this.radioButton1.Checked)
                qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);


            if (this.radioButton2.Checked)
                qrEncoder = new QrEncoder(ErrorCorrectionLevel.L);


            if (this.radioButton3.Checked)
                qrEncoder = new QrEncoder(ErrorCorrectionLevel.Q);


            if (this.radioButton4.Checked)
                qrEncoder = new QrEncoder(ErrorCorrectionLevel.M);



            var qrCode = qrEncoder.Encode(url);

            var renderer = new GraphicsRenderer(new FixedModuleSize(5, QuietZoneModules.Two), Brushes.Black, Brushes.White);
            /*
            using (var stream = new FileStream("qrcode.png", FileMode.Create))
                renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, stream);
            */

            MemoryStream ms = new MemoryStream();

            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);

            var imageTemp = new Bitmap(ms);

            var image = new Bitmap(imageTemp);

            pictureBox1.Image = image;
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
