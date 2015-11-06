using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.OneD;

namespace PrintBarCode2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void bPrint_Click(object sender, EventArgs e) {
            PrintDialog p = new PrintDialog();
            p.UseEXDialog = true;
            PrintDocument doc = new PrintDocument();
            doc.DocumentName = NormName;
            p.Document = doc;
            if (p.ShowDialog(this) != System.Windows.Forms.DialogResult.OK)
                return;

            doc.PrintPage += doc_PrintPage;

            doc.Print();
        }

        bool[] al;

        void doc_PrintPage(object sender, PrintPageEventArgs e) {
            var cv = e.Graphics;

            PrintIt(cv);

            e.HasMorePages = false;
        }

        void PrintIt(Graphics cv) {
            var w = cbb.SelectedItem as OneDimensionalCodeWriter;
            if (w == null) return;
            al = w.encode(tb.Text);

            cv.PageUnit = GraphicsUnit.Document;
            var rc = cv.VisibleClipBounds;

            float w1 = 5, M = 100;
            for (int x = 0; x < al.Length; x++) {
                var rc1 = new RectangleF(
                    M + w1 * x,
                    M,
                    w1,
                    25 * w1
                    );
                cv.FillRectangle(al[x] ? Brushes.Black : Brushes.White, rc1);
                var rc2 = rc1;
                rc2.X = rc.Right - M - w1 * al.Length + w1 * x;
                cv.FillRectangle(al[x] ? Brushes.Black : Brushes.White, rc2);
            }
        }

        Bitmap Gen() {
            var pic = new Bitmap(2480, 3504);
            pic.SetResolution(300, 300);
            using (var cv = Graphics.FromImage(pic)) {
                cv.Clear(Color.White);

                PrintIt(cv);
                return pic;
            }
        }

        private void bTIF_Click(object sender, EventArgs e) {
            using (var pic = Gen()) {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = NormName + ".tif";
                sfd.Filter = "*.tif;*.tiff|*.tif;*.tiff";
                if (sfd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;
                ImageCodecInfo ici = ImageCodecInfo.GetImageEncoders().First(q => q.MimeType.Equals("image/tiff"));
                EncoderParameters myEncoderParameters = new EncoderParameters(1);
                myEncoderParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Compression, (Int64)EncoderValue.CompressionCCITT4);
                pic.Save(sfd.FileName, ici, myEncoderParameters);
            }
        }

        private void bPDF_Click(object sender, EventArgs e) {
            using (var pic = Gen()) {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = NormName + ".pdf";
                sfd.Filter = "*.pdf|*.pdf";
                if (sfd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;
                String fp1 = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString("N") + ".tif");
                ImageCodecInfo ici = ImageCodecInfo.GetImageEncoders().First(q => q.MimeType.Equals("image/tiff"));
                EncoderParameters myEncoderParameters = new EncoderParameters(1);
                myEncoderParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Compression, (Int64)EncoderValue.CompressionCCITT4);
                pic.Save(fp1, ici, myEncoderParameters);
                Process p = Process.Start(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tiff2pdf.exe"), " -o \"" + sfd.FileName + "\" \"" + fp1 + "\" ");
                p.WaitForExit();
                File.Delete(fp1);
            }
        }

        public string NormName { get { return tb.Text.Replace("*", ""); } }

        private void Form1_Load(object sender, EventArgs e) {
            cbb.Items.Add(new ZXing.OneD.Code39Writer());
            cbb.Items.Add(new ZXing.OneD.Code128Writer());
            cbb.Items.Add(new ZXing.OneD.CodaBarWriter());
            cbb.Items.Add(new ZXing.OneD.EAN13Writer());
            cbb.Items.Add(new ZXing.OneD.EAN8Writer());
            //cbb.Items.Add(new ZXing.OneD.ITFWriter());
            //cbb.Items.Add(new ZXing.OneD.MSIWriter());
            //cbb.Items.Add(new ZXing.OneD.PlesseyWriter());
            //cbb.Items.Add(new ZXing.OneD.UPCAWriter());
            //cbb.Items.Add(new ZXing.Aztec.AztecWriter());
            //cbb.Items.Add(new ZXing.Datamatrix.DataMatrixWriter());
            //cbb.Items.Add(new ZXing.PDF417.PDF417Writer());
            //cbb.Items.Add(new ZXing.QrCode.QRCodeWriter());

            cbb.SelectedIndex = 0;
        }
    }
}
