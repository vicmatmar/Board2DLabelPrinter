using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Windows;

using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;

namespace Board2DLabelPrinter
{
    public partial class Form1 : Form
    {
        QrCode _qrCode;

        // private class used to hold product selection combobox
        class product_desc
        {
            public int Id = 0;
            public string ModelString = null;
            public string Name = null;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            float dim_mm = 10;
            float dimension_inches = milimeter_to_inches(dim_mm);

            // Calculate number of pixels.  Note we use dpi in x direction
            // but we should probably use whichever is lowest
            float dpi_x = e.Graphics.DpiX;
            float dpi_y = e.Graphics.DpiY;
            int pixels = (int)(dimension_inches * dpi_x);

            // Check whether we have enough space
            //if (pixels < qrCode.Matrix.Width)
            //throw new Exception("Too small");

            QuietZoneModules quite_zone = QuietZoneModules.Zero;
            ISizeCalculation iSizeCal = new FixedCodeSize(pixels, quite_zone);

            DrawingBrushRenderer dRenderer = new DrawingBrushRenderer(iSizeCal, System.Windows.Media.Brushes.Black, System.Windows.Media.Brushes.White);
            //DrawingBrushRenderer dRenderer = new DrawingBrushRenderer(iSizeCal, System.Windows.Media.Brushes.Black, System.Windows.Media.Brushes.LightGray);

            MemoryStream mem_stream = new MemoryStream();
            dRenderer.WriteToStream(_qrCode.Matrix, ImageFormatEnum.BMP, mem_stream);
            Bitmap bitmap = new Bitmap(mem_stream);
            bitmap.SetResolution(dpi_x, dpi_y);

            pictureBox1.Image = bitmap;
            //e.Graphics.DrawImage(bitmap, 0, 0);

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ManufacturingStore_DataContext dc = Utils.DC;

            product_desc[] products =
                dc.Products.Select(s =>
                    new product_desc { Id = s.Id, Name = s.Name, ModelString = s.ModelString }).OrderBy(s => s.ModelString).ToArray();
            comboBoxProducts.DataSource = products;

        }

        float milimeter_to_inches(float milimeters)
        {
            return milimeters * 1/25.4f;
        }

        private void comboBoxProducts_Format(object sender, ListControlConvertEventArgs e)
        {
            //PowerCalibration.Product product = (PowerCalibration.Product)e.ListItem;
            product_desc product = (product_desc)e.ListItem;
            e.Value = string.Format("{0,-10} ({1})", product.ModelString, product.Name);

        }

        private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            product_desc product = (product_desc)comboBoxProducts.SelectedItem;

            string serial = SerialNumber.BuildSerial(product.Id, 1);
            textBoxData.Text = serial;

        }

        private void textBoxData_TextChanged(object sender, EventArgs e)
        {
            string data = this.textBoxData.Text;

            ErrorCorrectionLevel correction_level = ErrorCorrectionLevel.L;

            QrEncoder qrEncoder = new QrEncoder(correction_level);
            _qrCode = qrEncoder.Encode(data);

            pictureBox1.Refresh();
        }
    }
}
