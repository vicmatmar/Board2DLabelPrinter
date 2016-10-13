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
using System.Xml;

using BoardSerialData;

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
            QuietZoneModules quite_zone = _dic_quite_zone[comboBox_quiteZone.Text[0]];
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
            float top_margin = (float)numericUpDown_topMargin.Value;
            if (comboBox_units.Text == "mm")
            {
                space_between = milimeter_to_inches(space_between);
                left_margin = milimeter_to_inches(left_margin);
                top_margin = milimeter_to_inches(top_margin);
            }
            int space_between_pixels = (int)(space_between * dpi_x);
            int left_margin_pixels = (int)(left_margin * dpi_x);
            int top_margin_pixels = (int)(top_margin * dpi_y);

            int offset_x = left_margin_pixels;
            int offset_y = top_margin_pixels;
            for (int i = 0; i < number_of_labels_per_page; i++)
            {
                Bitmap bitmap = renderToBitmap(_qrCodes[i].Matrix, pixels);
                e.Graphics.DrawImage(bitmap, offset_x, offset_y);
                offset_x += bitmap.Width + space_between_pixels;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get the products
            using (BoardSerial_DataContext dc = new BoardSerial_DataContext())
            {
                product_desc[] products =
                    dc.Products.Select(s =>
                        new product_desc { Id = s.Id, Name = s.Name, ModelString = s.ModelString }).OrderBy(s => s.ModelString).ToArray();
                comboBox_products.DataSource = products;
            }


            // Get the printers
            bool found_last_printer_used = false;
            foreach (string printer_name in PrinterSettings.InstalledPrinters)
            {
                comboBox_printers.Items.Add(printer_name);

                if (printer_name == Properties.Settings.Default.Last_Printer_Used_Name)
                    found_last_printer_used = true;
            }
            if (found_last_printer_used)
            {
                comboBox_printers.Text = Properties.Settings.Default.Last_Printer_Used_Name;
            }
            else
            {
                PrintDocument print_doc = new PrintDocument();
                comboBox_printers.Text = print_doc.PrinterSettings.PrinterName;
            }

            // Don't let the window shrink smaller
            this.MinimumSize = this.Size;

            numericUpDown_labelsPerPage.Value = Properties.Settings.Default.Labels_In_Row;
            numericUpDown_totalCount.Minimum = numericUpDown_labelsPerPage.Value;
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
            product_desc product = (product_desc)comboBox_products.SelectedItem;

            // Where we start the serials needs to be implemented
            SerialNumber.Week_Year wy = SerialNumber.GetWeekYearNumber();
            string serial = SerialNumber.BuildSerial(product.Id, 0, wy.Week, wy.Year);
            textBoxData.Text = serial;

            encodeRow();
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
                    numericUpDown_size.Maximum = 50;
                    numericUpDown_leftMargin.Maximum = 50;
                    numericUpDown_spaceBetween.Maximum = 50;
                    numericUpDown_topMargin.Maximum = 50;

                    numericUpDown_size.Value = (decimal)inches_to_milimeter((float)numericUpDown_size.Value);
                    numericUpDown_leftMargin.Value = (decimal)inches_to_milimeter((float)numericUpDown_leftMargin.Value);
                    numericUpDown_spaceBetween.Value = (decimal)inches_to_milimeter((float)numericUpDown_spaceBetween.Value);
                    numericUpDown_topMargin.Value = (decimal)inches_to_milimeter((float)numericUpDown_topMargin.Value);

                    numericUpDown_size.Minimum = 1;
                    numericUpDown_leftMargin.Minimum = 0;
                    numericUpDown_spaceBetween.Minimum = 0;
                    numericUpDown_topMargin.Minimum = 0;

                    numericUpDown_size.Increment = 0.5m;
                    numericUpDown_leftMargin.Increment = 0.1m;
                    numericUpDown_spaceBetween.Increment = 0.1m;
                    numericUpDown_topMargin.Increment = 0.1m;


                    break;
                case "in":
                    numericUpDown_size.Value = (decimal)milimeter_to_inches((float)numericUpDown_size.Value);
                    numericUpDown_leftMargin.Value = (decimal)milimeter_to_inches((float)numericUpDown_leftMargin.Value);
                    numericUpDown_spaceBetween.Value = (decimal)milimeter_to_inches((float)numericUpDown_spaceBetween.Value);
                    numericUpDown_topMargin.Value = (decimal)milimeter_to_inches((float)numericUpDown_topMargin.Value);

                    numericUpDown_size.Maximum = 2;
                    numericUpDown_leftMargin.Maximum = 2;
                    numericUpDown_spaceBetween.Maximum = 2;
                    numericUpDown_topMargin.Maximum = 2;

                    numericUpDown_size.Minimum = 0.05m;
                    numericUpDown_leftMargin.Minimum = 0;
                    numericUpDown_spaceBetween.Minimum = 0;
                    numericUpDown_topMargin.Minimum = 0;

                    numericUpDown_size.Increment = 0.01m;
                    numericUpDown_leftMargin.Increment = 0.01m;
                    numericUpDown_spaceBetween.Increment = 0.01m;
                    numericUpDown_topMargin.Increment = 0.01m;

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

        /// <summary>
        /// Encodes a row or page (all labels in a row)
        /// </summary>
        void encodeRow(int start_serial = 0)
        {
            pictureBox1.CreateGraphics().Clear(Color.Black);
            pictureBox2.CreateGraphics().Clear(Color.Black);

            Cursor oldcursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;

            product_desc product = (product_desc)comboBox_products.SelectedItem;
            ErrorCorrectionLevel correction_level = _dic_error_correction[comboBox_correctionLevel.Text[0]];
            QrEncoder qrEncoder = new QrEncoder(correction_level);

            int n = (int)numericUpDown_labelsPerPage.Value;
            _qrCodes = new QrCode[n];
            // Where we start the serials needs to be implemented
            int serial = start_serial;
            SerialNumber.Week_Year wy = SerialNumber.GetWeekYearNumber();
            for (int i = 0; i < n; i++)
            {
                string complete_serial_str = SerialNumber.BuildSerial(product.Id, serial++, wy.Week, wy.Year);
                _qrCodes[i] = qrEncoder.Encode(complete_serial_str);
            }

            pictureRefreshAll();

            this.Cursor = oldcursor;

        }

        private void comboBoxCorrectionLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            encodeRow();
        }

        private void numericUpDownZoomFactor_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
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
            float top_margin = (float)numericUpDown_topMargin.Value;
            float space_between = (float)numericUpDown_spaceBetween.Value;

            if (comboBox_units.Text == "mm")
            {
                left_margin = milimeter_to_inches(left_margin);
                top_margin = milimeter_to_inches(top_margin);
                space_between = milimeter_to_inches(space_between);
            }

            int offset_x = (int)(left_margin * dpi_x);
            int offset_y = (int)(top_margin * dpi_y);
            int space_between_pixels = (int)(space_between * dpi_x);

            for (int i = 0; i < number_of_labels; i++)
            {
                Bitmap bitmap = renderToBitmap(_qrCodes[i].Matrix, pixels);
                bitmap.SetResolution(dpi_x, dpi_y);

                e.Graphics.DrawImage(bitmap, offset_x, offset_y);
                offset_x += pixels + space_between_pixels;
            }
        }

        private void numericUpDown_labelsPerPage_ValueChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.Labels_In_Row = (int)numericUpDown_labelsPerPage.Value;
            Properties.Settings.Default.Save();

            int row_count = (int)numericUpDown_labelsPerPage.Value;
            int total_count = (int)numericUpDown_totalCount.Value;

            numericUpDown_totalCount.Minimum = row_count;
            numericUpDown_totalCount.Increment = row_count;

            while (total_count % row_count != 0)
                total_count++;
            numericUpDown_totalCount.Value = total_count;

            encodeRow();
        }

        private void numericUpDown_SpaceBetween_ValueChanged(object sender, EventArgs e)
        {
            pictureBox2.Refresh();
        }

        private void numericUpDown_leftMargin_ValueChanged(object sender, EventArgs e)
        {
            pictureBox2.Refresh();
        }

        private void numericUpDown_topMargin_ValueChanged(object sender, EventArgs e)
        {
            pictureBox2.Refresh();
        }

        private void comboBoxPrinters_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Last_Printer_Used_Name = comboBox_printers.Text;
            Properties.Settings.Default.Save();

            comboBox_papers.Items.Clear();
            PrintDocument print_doc = new PrintDocument();
            print_doc.PrinterSettings.PrinterName = comboBox_printers.Text;

            bool found_last_paper_used = false;
            foreach (PaperSize ps in print_doc.PrinterSettings.PaperSizes)
            {
                comboBox_papers.Items.Add(ps);
                if (papersize(ps) == Properties.Settings.Default.Last_Paper_Used)
                    found_last_paper_used = true;
            }
            if (found_last_paper_used)
            {
                comboBox_papers.Text = Properties.Settings.Default.Last_Paper_Used;
            }
            else
            {
                PaperSize ps = print_doc.DefaultPageSettings.PaperSize;
                comboBox_papers.Text = papersize(ps);
            }
        }

        string papersize(PaperSize ps)
        {
            return string.Format("{0} ({1:0.000} x {2:0.000})", ps.PaperName, (float)ps.Width / 100, (float)ps.Height / 100);
        }

        private void comboBox_papers_Format(object sender, ListControlConvertEventArgs e)
        {
            PaperSize ps = (PaperSize)e.ListItem;
            e.Value = papersize(ps);
        }

        private void comboBox_papers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Last_Paper_Used = comboBox_papers.Text;
            Properties.Settings.Default.Save();
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            Cursor cursor_old = Cursor;
            Cursor = Cursors.WaitCursor;
            try
            {
                int number_of_pages = (int)(numericUpDown_totalCount.Value / numericUpDown_labelsPerPage.Value);
                int start_serial = 0;

                PrintDocument print_doc = new PrintDocument();
                print_doc.PrintController = new StandardPrintController();
                print_doc.PrinterSettings.PrinterName = comboBox_printers.Text;
                print_doc.DefaultPageSettings.PaperSize = (PaperSize)comboBox_papers.SelectedItem;
                print_doc.PrintPage += printDocumentAll_PrintPage;

                for (int p = 0; p < number_of_pages; p++)
                {
                    encodeRow(start_serial);

                    print_doc.Print();

                    start_serial += (int)numericUpDown_labelsPerPage.Value;
                }
            }
            finally
            {
                Cursor = cursor_old;
            }
        }

        private void numericUpDown_totalCount_ValueChanged(object sender, EventArgs e)
        {
            int labels_per_row = (int)numericUpDown_labelsPerPage.Value;
            int total_count = (int)numericUpDown_totalCount.Value;

            while (total_count % labels_per_row != 0)
                total_count++;
            numericUpDown_totalCount.Value = total_count;

            int row_count = (int)(numericUpDown_totalCount.Value / numericUpDown_labelsPerPage.Value);
            label_print_total.Text = string.Format("Print Total\r\n({0} rows)", row_count);
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.DefaultExt = "lsdoc";
            dlg.Filter = "lsdoc | Label Setting Document";
            dlg.FileName = "*.lsdoc";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ///////////////////////////////////
                XmlDocument doc = new XmlDocument();

                ///////////////////////////////////
                XmlNode node_top = doc.CreateElement("Settings");

                ///////////////////////////////////
                XmlNode node_printer = doc.CreateElement("Printer");

                XmlAttribute a = doc.CreateAttribute("Name");
                a.Value = comboBox_printers.Text;
                node_printer.Attributes.Append(a);

                a = doc.CreateAttribute("Paper");
                a.Value = comboBox_papers.Text;
                node_printer.Attributes.Append(a);

                node_top.AppendChild(node_printer);

                ///////////////////////////////////
                XmlNode node_label = doc.CreateElement("Label");

                a = doc.CreateAttribute("Product");
                a.Value = comboBox_products.Text;
                node_label.Attributes.Append(a);

                a = doc.CreateAttribute("Units");
                a.Value = comboBox_units.Text;
                node_label.Attributes.Append(a);

                a = doc.CreateAttribute("Size");
                a.Value = numericUpDown_size.Value.ToString();
                node_label.Attributes.Append(a);

                a = doc.CreateAttribute("Correction");
                a.Value = comboBox_correctionLevel.Text;
                node_label.Attributes.Append(a);

                node_top.AppendChild(node_label);

                ///////////////////////////////////
                XmlNode node_row = doc.CreateElement("RowSettings");

                a = doc.CreateAttribute("LabelsPerRow");
                a.Value = numericUpDown_labelsPerPage.Value.ToString();
                node_row.Attributes.Append(a);

                a = doc.CreateAttribute("LabelSpacing");
                a.Value = numericUpDown_spaceBetween.Value.ToString();
                node_row.Attributes.Append(a);

                a = doc.CreateAttribute("TopMargin");
                a.Value = numericUpDown_topMargin.Value.ToString();
                node_row.Attributes.Append(a);

                a = doc.CreateAttribute("LeftMargin");
                a.Value = numericUpDown_leftMargin.Value.ToString();
                node_row.Attributes.Append(a);

                node_top.AppendChild(node_row);

                ///////////////////////////////////
                doc.AppendChild(node_top);

                doc.Save(dlg.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "lsdoc | Label Setting Document";
            dlg.FileName = "*.lsdoc";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ///////////////////////////////////
                XmlDocument doc = new XmlDocument();
                doc.Load(dlg.FileName);

                ///////////////////////////////////
                XmlNode node_top = doc["Settings"];

                ///////////////////////////////////
                XmlNode node_printer = node_top["Printer"];
                if (node_printer != null)
                {
                    XmlAttribute a = node_printer.Attributes["Name"];
                    try { comboBox_printers.Text = a.Value; } catch { };

                    a = node_printer.Attributes["Paper"];
                    try { comboBox_papers.Text = a.Value; } catch { };
                }


                ///////////////////////////////////
                XmlNode node_label = node_top["Label"];
                if (node_label != null)
                {
                    XmlAttribute a = node_label.Attributes["Units"];
                    try { comboBox_units.Text = a.Value; } catch { };

                    a = node_label.Attributes["Size"];
                    try { numericUpDown_size.Value = Convert.ToDecimal(a.Value); } catch { };

                    XmlNode node_row = node_top["RowSettings"];
                    a = node_row.Attributes["LabelsPerRow"];
                    try { numericUpDown_labelsPerPage.Value = Convert.ToDecimal(a.Value); } catch { };

                    a = node_row.Attributes["LabelSpacing"];
                    try { numericUpDown_spaceBetween.Value = Convert.ToDecimal(a.Value); } catch { };

                    a = node_row.Attributes["TopMargin"];
                    try { numericUpDown_topMargin.Value = Convert.ToDecimal(a.Value); } catch { };

                    a = node_row.Attributes["LeftMargin"];
                    try { numericUpDown_leftMargin.Value = Convert.ToDecimal(a.Value); } catch { };
                }
            }
        }
    }
}
