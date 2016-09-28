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
        Dictionary<char, Gma.QrCodeNet.Encoding.ErrorCorrectionLevel> _dic_error_correction = new Dictionary<char, ErrorCorrectionLevel>();
        Dictionary<char, QuietZoneModules> _dic_quite_zone = new Dictionary<char, QuietZoneModules>();

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

            _dic_error_correction.Add('L', ErrorCorrectionLevel.L); // 7%
            _dic_error_correction.Add('M', ErrorCorrectionLevel.M); // 15%
            _dic_error_correction.Add('Q', ErrorCorrectionLevel.Q); // 25%
            _dic_error_correction.Add('H', ErrorCorrectionLevel.H); // 30%

            _dic_quite_zone.Add('0', QuietZoneModules.Zero);
            _dic_quite_zone.Add('2', QuietZoneModules.Two);
            _dic_quite_zone.Add('4', QuietZoneModules.Four);

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            float dimension_inches = (float)numericUpDownSize.Value;
            if (comboBoxSizeUnit.Text == "mm")
                dimension_inches = milimeter_to_inches(dimension_inches);

            // Calculate number of pixels.  Note we use dpi in x direction
            // but we should probably use whichever is lowest
            float dpi_x = e.Graphics.DpiX;
            float dpi_y = e.Graphics.DpiY;
            int pixels = (int)(dimension_inches * dpi_x);

            if (pixels <= 0)
            {
                dimension_inches = e.ClipRectangle.Width / dpi_x;
                pixels = (int)(dimension_inches * dpi_x);
            }

            // Check whether we have enough space
            //if (pixels < qrCode.Matrix.Width)
            //throw new Exception("Too small");

            Bitmap bitmap = renderToBitmap(pixels);
            bitmap.SetResolution(dpi_x, dpi_y);

            
            //pictureBox1.Image = bitmap;
            e.Graphics.DrawImage(bitmap, (pictureBox1.Width - pixels) / 2, (pictureBox1.Height - pixels) / 2);
        }

        Bitmap renderToBitmap(int size_in_pixels)
        {
            QuietZoneModules quite_zone = _dic_quite_zone[comboBoxQuiteZone.Text[0]];
            ISizeCalculation iSizeCal = new FixedCodeSize(size_in_pixels, quite_zone);

            DrawingBrushRenderer dRenderer = new DrawingBrushRenderer(iSizeCal, System.Windows.Media.Brushes.Black, System.Windows.Media.Brushes.White);

            MemoryStream mem_stream = new MemoryStream();
            dRenderer.WriteToStream(_qrCode.Matrix, ImageFormatEnum.BMP, mem_stream);
            return new Bitmap(mem_stream);
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
            return milimeters / 25.4f;
        }
        float inches_to_milimeter(float inches)
        {
            return inches * 25.4f;
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
            encode();
        }

        void encode()
        {
            string data = this.textBoxData.Text;
            ErrorCorrectionLevel correction_level = _dic_error_correction[comboBoxCorrectionLevel.Text[0]];

            QrEncoder qrEncoder = new QrEncoder(correction_level);
            _qrCode = qrEncoder.Encode(data);

            pictureRefresh();
        }

        void pictureRefresh()
        {
            pictureBox1.Refresh();
        }

        private void comboBoxSizeUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            float val = (float)numericUpDownSize.Value;
            switch (comboBoxSizeUnit.Text)
            {
                case "mm":
                    numericUpDownSize.Maximum = 100;
                    numericUpDownSize.Increment = 1;
                    numericUpDownSize.Value = (decimal)inches_to_milimeter(val);
                    numericUpDownSize.Update();

                    break;
                case "in":
                    numericUpDownSize.Maximum = 4;
                    numericUpDownSize.Increment = 0.25M;
                    numericUpDownSize.Value = (decimal)milimeter_to_inches(val);
                    numericUpDownSize.Update();

                    break;
                default:
                    break;
            }
        }

        private void numericUpDownSize_ValueChanged(object sender, EventArgs e)
        {
            pictureRefresh();
        }

        private void comboBoxQuiteZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureRefresh();
        }

        private void comboBoxCorrectionLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            encode();
        }

        private void numericUpDownZoomFactor_ValueChanged(object sender, EventArgs e)
        {
/*
            float zoom_factor = (float)numericUpDownZoomFactor.Value;
            if (zoom_factor < 1)
                numericUpDownZoomFactor.Increment = 0.1M;
            else
                numericUpDownZoomFactor.Increment = 1.0M;

            float ratio = pictureBox1.Image.HorizontalResolution / (float)numericUpDownDPI.Value;
            Bitmap bitmap = _bitmaps_for_print[0];
            Bitmap pbitmap = new Bitmap(bitmap, (int)(bitmap.Width * ratio * zoom_factor), (int)(bitmap.Height * ratio * zoom_factor));
            this.pictureBox1.Image = pbitmap;*/

        }
    }
}
