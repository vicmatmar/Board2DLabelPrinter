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
using System.Drawing.Printing;

using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;

namespace Board2DLabelPrinter
{
    public partial class Form1 : Form
    {
        QrCode[] _qrCodes;
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
            float dimension_inches = (float)numericUpDown_size.Value;
            if (comboBox_units.Text == "mm")
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

            Bitmap bitmap = renderToBitmap(_qrCodes[0].Matrix, pixels);
            //bitmap.SetResolution(dpi_x, dpi_y);

            // Apply zoom factor
            float zoom_factor = (float)numericUpDownZoomFactor.Value;
            bitmap = new Bitmap(bitmap, (int)(bitmap.Width * zoom_factor), (int)(bitmap.Height * zoom_factor));

            //pictureBox1.Image = bitmap;
            e.Graphics.DrawImage(bitmap, (pictureBox1.Width - bitmap.Width) / 2, (pictureBox1.Height - bitmap.Height) / 2);
        }

        Bitmap renderToBitmap(BitMatrix bitmatrix, int size_in_pixels)
        {
            QuietZoneModules quite_zone = _dic_quite_zone[comboBoxQuiteZone.Text[0]];
            ISizeCalculation iSizeCal = new FixedCodeSize(size_in_pixels, quite_zone);

            DrawingBrushRenderer dRenderer = new DrawingBrushRenderer(iSizeCal, System.Windows.Media.Brushes.Black, System.Windows.Media.Brushes.White);

            MemoryStream mem_stream = new MemoryStream();
            dRenderer.WriteToStream(bitmatrix, ImageFormatEnum.BMP, mem_stream);
            return new Bitmap(mem_stream);
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            float dimension_inches = (float)numericUpDown_size.Value;
            if (comboBox_units.Text == "mm")
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


            int number_of_labels_per_page = (int)numericUpDown_labelsPerPage.Value;

            float space_between = (float)numericUpDown_spaceBetween.Value;
            float left_margin = (float)numericUpDown_leftMargin.Value;
            if (comboBox_units.Text == "mm")
            {
                space_between = milimeter_to_inches(space_between);
                left_margin = milimeter_to_inches(left_margin);
            }
            int space_between_pixels = (int)(space_between * dpi_x);
            int left_margin_pixels = (int)(left_margin * dpi_x);

            int offset_x = left_margin_pixels;
            for (int i = 0; i < number_of_labels_per_page; i++)
            {
                Bitmap bitmap = renderToBitmap(_qrCodes[i].Matrix, pixels);
                e.Graphics.DrawImage(bitmap, offset_x, 0);
                offset_x += bitmap.Width + space_between_pixels;
            }

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

            // Where we start the serials needs to be implemented
            string serial = SerialNumber.BuildSerial(product.Id, 0);
            textBoxData.Text = serial;

            encodeAll();
        }

        void pictureRefreshAll()
        {
            pictureBox1.Refresh();
            pictureBox2.Refresh();
        }

        private void comboBoxSizeUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_units.Text)
            {
                case "mm":
                    numericUpDown_size.Value = (decimal)inches_to_milimeter((float)numericUpDown_size.Value);
                    numericUpDown_leftMargin.Value = (decimal)inches_to_milimeter((float)numericUpDown_leftMargin.Value);
                    numericUpDown_spaceBetween.Value = (decimal)inches_to_milimeter((float)numericUpDown_spaceBetween.Value);

                    numericUpDown_size.Maximum = 50;
                    numericUpDown_size.Minimum = 1;
                    numericUpDown_size.Increment = 0.5m;

                    numericUpDown_leftMargin.Maximum = 50;
                    numericUpDown_leftMargin.Minimum = 0;
                    numericUpDown_leftMargin.Increment = 0.1m;

                    numericUpDown_spaceBetween.Maximum = 50;
                    numericUpDown_size.Minimum = 0;
                    numericUpDown_spaceBetween.Increment = 0.1m;


                    break;
                case "in":
                    numericUpDown_size.Value = (decimal)milimeter_to_inches((float)numericUpDown_size.Value);
                    numericUpDown_leftMargin.Value = (decimal)milimeter_to_inches((float)numericUpDown_leftMargin.Value);
                    numericUpDown_spaceBetween.Value = (decimal)milimeter_to_inches((float)numericUpDown_spaceBetween.Value);

                    numericUpDown_size.Maximum = 2;
                    numericUpDown_size.Minimum = 0.05m;
                    numericUpDown_size.Increment = 0.01m;

                    numericUpDown_leftMargin.Maximum = 2;
                    numericUpDown_leftMargin.Minimum = 0;
                    numericUpDown_leftMargin.Increment = 0.01m;

                    numericUpDown_spaceBetween.Maximum = 2;
                    numericUpDown_size.Minimum = 0;
                    numericUpDown_spaceBetween.Increment = 0.01m;

                    break;
                default:
                    break;
            }
        }


        private void numericUpDownSize_ValueChanged(object sender, EventArgs e)
        {
            pictureRefreshAll();
        }

        private void comboBoxQuiteZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureRefreshAll();
        }

        void encodeAll()
        {
            pictureBox1.CreateGraphics().Clear(Color.Black);
            pictureBox2.CreateGraphics().Clear(Color.Black);

            Cursor oldcursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;

            product_desc product = (product_desc)comboBoxProducts.SelectedItem;
            ErrorCorrectionLevel correction_level = _dic_error_correction[comboBoxCorrectionLevel.Text[0]];
            QrEncoder qrEncoder = new QrEncoder(correction_level);

            int n = (int)numericUpDown_labelsPerPage.Value;
            _qrCodes = new QrCode[n];
            // Where we start the serials needs to be implemented
            for (int i = 0; i < n; i++)
            {
                string serial = SerialNumber.BuildSerial(product.Id, i);
                _qrCodes[i] = qrEncoder.Encode(serial);
            }

            pictureRefreshAll();

            this.Cursor = oldcursor;

        }

        private void comboBoxCorrectionLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            encodeAll();
        }

        private void numericUpDownZoomFactor_ValueChanged(object sender, EventArgs e)
        {
            float zoom_factor = (float)numericUpDownZoomFactor.Value;
            if (zoom_factor < 1)
                numericUpDownZoomFactor.Increment = 0.1M;
            else
                numericUpDownZoomFactor.Increment = 1.0M;

            pictureRefreshAll();
        }

        private void printSingleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = new PrintDocument();
            printDialog.Document.PrintPage += printDocumentSingle_PrintPage;
            DialogResult r = printDialog.ShowDialog();
            if (r == DialogResult.OK)
            {
                printDialog.Document.Print();
            }
        }

        private void printDocumentSingle_PrintPage(object sender, PrintPageEventArgs e)
        {
            float dimension_inches = (float)numericUpDown_size.Value;
            if (comboBox_units.Text == "mm")
                dimension_inches = milimeter_to_inches(dimension_inches);

            // Calculate number of pixels.  Note we use dpi in x direction
            // but we should probably use whichever is lowest
            float dpi_x = e.Graphics.DpiX;
            float dpi_y = e.Graphics.DpiY;
            int pixels = (int)(dimension_inches * dpi_x);

            if (pixels <= 0)
            {
                dimension_inches = e.PageSettings.PrintableArea.Width / dpi_x;
                pixels = (int)(dimension_inches * dpi_x);
            }

            // Check whether we have enough space
            //if (pixels < qrCode.Matrix.Width)
            //throw new Exception("Too small");

            e.Graphics.PageUnit = GraphicsUnit.Pixel;  // does not matter here
            Bitmap bitmap = renderToBitmap(_qrCodes[0].Matrix, pixels);
            bitmap.SetResolution(dpi_x, dpi_y);
            e.Graphics.DrawImage(bitmap, 0, 0);

        }

        private void printAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = new PrintDocument();
            printDialog.Document.PrintPage += printDocumentAll_PrintPage;
            DialogResult r = printDialog.ShowDialog();
            if (r == DialogResult.OK)
            {
                printDialog.Document.Print();
            }

        }

        private void printDocumentAll_PrintPage(object sender, PrintPageEventArgs e)
        {
            float dimension_inches = (float)numericUpDown_size.Value;
            if (comboBox_units.Text == "mm")
                dimension_inches = milimeter_to_inches(dimension_inches);

            // Calculate number of pixels.  Note we use dpi in x direction
            // but we should probably use whichever is lowest
            float dpi_x = e.Graphics.DpiX;
            float dpi_y = e.Graphics.DpiY;
            int pixels = (int)(dimension_inches * dpi_x);
            int number_of_labels = (int)numericUpDown_labelsPerPage.Value;

            // If too small lets just use the entired width
            if (pixels <= 0)
            {
                dimension_inches = e.PageSettings.PrintableArea.Width / 100 / number_of_labels;
                pixels = (int)(dimension_inches * dpi_x);
            }

            e.Graphics.PageUnit = GraphicsUnit.Pixel;

            float left_margin = (float)numericUpDown_leftMargin.Value;
            float space_between = (float)numericUpDown_spaceBetween.Value;

            if (comboBox_units.Text == "mm")
            {
                left_margin = milimeter_to_inches(left_margin);
                space_between = milimeter_to_inches(space_between);
            }

            int offset_x = (int)(left_margin * dpi_x);
            int space_between_pixels = (int)(space_between * dpi_x);

            for (int i = 0; i < number_of_labels; i++)
            {
                Bitmap bitmap = renderToBitmap(_qrCodes[0].Matrix, pixels);
                bitmap.SetResolution(dpi_x, dpi_y);

                e.Graphics.DrawImage(bitmap, offset_x, 0);
                offset_x += pixels + space_between_pixels;
            }
        }

        private void numericUpDown_labelsPerPage_ValueChanged(object sender, EventArgs e)
        {
            encodeAll();
        }

        private void numericUpDown_SpaceBetween_ValueChanged(object sender, EventArgs e)
        {
            pictureBox2.Refresh();
        }

        private void numericUpDown_leftMargin_ValueChanged(object sender, EventArgs e)
        {
            pictureBox2.Refresh();
        }
    }
}
