//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Drawing.Imaging;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Proyecto
//{
//    public partial class BarraQr : Form
//    {
//        public BarraQr()
//        {
//            InitializeComponent();
//        }

//        private void btnBarra_Click(object sender, EventArgs e)
//        {
//            Zen.Barcode.Code128BarcodeDraw codigodebarra = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
//            imgBarra.Image = codigodebarra.Draw(id_txt.Text, 40);
//        }

//        private void btnQr_Click(object sender, EventArgs e)
//        {
//            Zen.Barcode.CodeQrBarcodeDraw codigoqr = Zen.Barcode.BarcodeDrawFactory.CodeQr;
//            imgQr.Image = codigoqr.Draw(txtQr.Text, 40);
//        }

//        private void btnGuardarQr_Click(object sender, EventArgs e)
//        {
//            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
//            saveFileDialog1.FileName = "";
//            saveFileDialog1.Filter = "JPEG|*.jpeg";

//            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
//            {
//                string varing = saveFileDialog1.FileName;
//                Bitmap varbmp = new Bitmap(imgBarra.Image);
//                varbmp.Save(varing, ImageFormat.Jpeg);
//            }
//        }

//        private void BarraQr_Load(object sender, EventArgs e)
//        {

//        }
//    }
//}
