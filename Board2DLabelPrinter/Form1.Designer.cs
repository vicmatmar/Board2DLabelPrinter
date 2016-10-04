namespace Board2DLabelPrinter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.comboBox_products = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip_Picture1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printSingelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_quiteZone = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_correctionLevel = new System.Windows.Forms.ComboBox();
            this.numericUpDown_size = new System.Windows.Forms.NumericUpDown();
            this.comboBox_units = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownZoomFactor = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_print = new System.Windows.Forms.Button();
            this.label_print_total = new System.Windows.Forms.Label();
            this.numericUpDown_totalCount = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown_topMargin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_labelsPerPage = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_spaceBetween = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown_leftMargin = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip_Picture2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolPrintAllStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_printers = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox_papers = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip_Picture1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoomFactor)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_totalCount)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_topMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_labelsPerPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_spaceBetween)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_leftMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.contextMenuStrip_Picture2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxData
            // 
            this.textBoxData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxData.Location = new System.Drawing.Point(19, 19);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ReadOnly = true;
            this.textBoxData.Size = new System.Drawing.Size(232, 22);
            this.textBoxData.TabIndex = 0;
            this.textBoxData.Text = "12345678901234567890";
            this.textBoxData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxData.WordWrap = false;
            // 
            // comboBox_products
            // 
            this.comboBox_products.FormattingEnabled = true;
            this.comboBox_products.Location = new System.Drawing.Point(59, 16);
            this.comboBox_products.Name = "comboBox_products";
            this.comboBox_products.Size = new System.Drawing.Size(223, 21);
            this.comboBox_products.TabIndex = 0;
            this.comboBox_products.SelectedIndexChanged += new System.EventHandler(this.comboBoxProducts_SelectedIndexChanged);
            this.comboBox_products.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxProducts_Format);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Product:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip_Picture1;
            this.pictureBox1.Location = new System.Drawing.Point(82, 61);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(100, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // contextMenuStrip_Picture1
            // 
            this.contextMenuStrip_Picture1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printSingelToolStripMenuItem});
            this.contextMenuStrip_Picture1.Name = "contextMenuStrip_Picture1";
            this.contextMenuStrip_Picture1.Size = new System.Drawing.Size(100, 26);
            // 
            // printSingelToolStripMenuItem
            // 
            this.printSingelToolStripMenuItem.Name = "printSingelToolStripMenuItem";
            this.printSingelToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.printSingelToolStripMenuItem.Text = "&Print";
            this.printSingelToolStripMenuItem.Click += new System.EventHandler(this.printSingleToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox_products);
            this.groupBox1.Location = new System.Drawing.Point(18, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 195);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_quiteZone, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_correctionLevel, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_size, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_units, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(155, 115);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quite:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Correction:";
            // 
            // comboBox_quiteZone
            // 
            this.comboBox_quiteZone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox_quiteZone.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "2",
            "4"});
            this.comboBox_quiteZone.FormattingEnabled = true;
            this.comboBox_quiteZone.Items.AddRange(new object[] {
            "0",
            "2",
            "4"});
            this.comboBox_quiteZone.Location = new System.Drawing.Point(67, 87);
            this.comboBox_quiteZone.Name = "comboBox_quiteZone";
            this.comboBox_quiteZone.Size = new System.Drawing.Size(32, 21);
            this.comboBox_quiteZone.TabIndex = 3;
            this.comboBox_quiteZone.Text = "0";
            this.comboBox_quiteZone.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuiteZone_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Size:";
            // 
            // comboBox_correctionLevel
            // 
            this.comboBox_correctionLevel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox_correctionLevel.FormattingEnabled = true;
            this.comboBox_correctionLevel.Items.AddRange(new object[] {
            "L",
            "M",
            "Q",
            "H"});
            this.comboBox_correctionLevel.Location = new System.Drawing.Point(67, 56);
            this.comboBox_correctionLevel.Name = "comboBox_correctionLevel";
            this.comboBox_correctionLevel.Size = new System.Drawing.Size(32, 21);
            this.comboBox_correctionLevel.TabIndex = 2;
            this.comboBox_correctionLevel.Text = "L";
            this.comboBox_correctionLevel.SelectedIndexChanged += new System.EventHandler(this.comboBoxCorrectionLevel_SelectedIndexChanged);
            // 
            // numericUpDown_size
            // 
            this.numericUpDown_size.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_size.DecimalPlaces = 3;
            this.numericUpDown_size.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown_size.Location = new System.Drawing.Point(67, 30);
            this.numericUpDown_size.Name = "numericUpDown_size";
            this.numericUpDown_size.Size = new System.Drawing.Size(56, 20);
            this.numericUpDown_size.TabIndex = 1;
            this.numericUpDown_size.Value = new decimal(new int[] {
            100,
            0,
            0,
            65536});
            this.numericUpDown_size.ValueChanged += new System.EventHandler(this.numericUpDownSize_ValueChanged);
            // 
            // comboBox_units
            // 
            this.comboBox_units.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox_units.FormattingEnabled = true;
            this.comboBox_units.Items.AddRange(new object[] {
            "mm",
            "in"});
            this.comboBox_units.Location = new System.Drawing.Point(67, 3);
            this.comboBox_units.Name = "comboBox_units";
            this.comboBox_units.Size = new System.Drawing.Size(44, 21);
            this.comboBox_units.TabIndex = 0;
            this.comboBox_units.Text = "mm";
            this.comboBox_units.SelectedIndexChanged += new System.EventHandler(this.comboBoxSizeUnit_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Units";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numericUpDownZoomFactor);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.textBoxData);
            this.groupBox2.Location = new System.Drawing.Point(324, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 195);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Zoom:";
            // 
            // numericUpDownZoomFactor
            // 
            this.numericUpDownZoomFactor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownZoomFactor.DecimalPlaces = 2;
            this.numericUpDownZoomFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownZoomFactor.Location = new System.Drawing.Point(134, 170);
            this.numericUpDownZoomFactor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownZoomFactor.Name = "numericUpDownZoomFactor";
            this.numericUpDownZoomFactor.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownZoomFactor.TabIndex = 0;
            this.numericUpDownZoomFactor.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.numericUpDownZoomFactor.ValueChanged += new System.EventHandler(this.numericUpDownZoomFactor_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button_print);
            this.groupBox3.Controls.Add(this.label_print_total);
            this.groupBox3.Controls.Add(this.numericUpDown_totalCount);
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Location = new System.Drawing.Point(12, 268);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(581, 232);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // button_print
            // 
            this.button_print.Location = new System.Drawing.Point(164, 188);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(75, 23);
            this.button_print.TabIndex = 30;
            this.button_print.Text = "&Print";
            this.button_print.UseVisualStyleBackColor = true;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // label_print_total
            // 
            this.label_print_total.AutoSize = true;
            this.label_print_total.Location = new System.Drawing.Point(12, 184);
            this.label_print_total.Name = "label_print_total";
            this.label_print_total.Size = new System.Drawing.Size(55, 13);
            this.label_print_total.TabIndex = 29;
            this.label_print_total.Text = "Print Total";
            // 
            // numericUpDown_totalCount
            // 
            this.numericUpDown_totalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_totalCount.Location = new System.Drawing.Point(82, 188);
            this.numericUpDown_totalCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_totalCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_totalCount.Name = "numericUpDown_totalCount";
            this.numericUpDown_totalCount.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown_totalCount.TabIndex = 0;
            this.numericUpDown_totalCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_totalCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_totalCount.ValueChanged += new System.EventHandler(this.numericUpDown_totalCount_ValueChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_topMargin, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_labelsPerPage, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_spaceBetween, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_leftMargin, 7, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(557, 44);
            this.tableLayoutPanel2.TabIndex = 24;
            // 
            // numericUpDown_topMargin
            // 
            this.numericUpDown_topMargin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_topMargin.DecimalPlaces = 3;
            this.numericUpDown_topMargin.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown_topMargin.Location = new System.Drawing.Point(331, 12);
            this.numericUpDown_topMargin.Name = "numericUpDown_topMargin";
            this.numericUpDown_topMargin.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown_topMargin.TabIndex = 27;
            this.numericUpDown_topMargin.ValueChanged += new System.EventHandler(this.numericUpDown_topMargin_ValueChanged);
            // 
            // numericUpDown_labelsPerPage
            // 
            this.numericUpDown_labelsPerPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_labelsPerPage.Location = new System.Drawing.Point(85, 12);
            this.numericUpDown_labelsPerPage.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_labelsPerPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_labelsPerPage.Name = "numericUpDown_labelsPerPage";
            this.numericUpDown_labelsPerPage.Size = new System.Drawing.Size(32, 20);
            this.numericUpDown_labelsPerPage.TabIndex = 0;
            this.numericUpDown_labelsPerPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_labelsPerPage.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown_labelsPerPage.ValueChanged += new System.EventHandler(this.numericUpDown_labelsPerPage_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Labels per row";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Label Spacing:";
            // 
            // numericUpDown_spaceBetween
            // 
            this.numericUpDown_spaceBetween.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_spaceBetween.DecimalPlaces = 3;
            this.numericUpDown_spaceBetween.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown_spaceBetween.Location = new System.Drawing.Point(207, 12);
            this.numericUpDown_spaceBetween.Name = "numericUpDown_spaceBetween";
            this.numericUpDown_spaceBetween.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown_spaceBetween.TabIndex = 21;
            this.numericUpDown_spaceBetween.ValueChanged += new System.EventHandler(this.numericUpDown_SpaceBetween_ValueChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Top Margin:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(385, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Left Margin:";
            // 
            // numericUpDown_leftMargin
            // 
            this.numericUpDown_leftMargin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_leftMargin.DecimalPlaces = 3;
            this.numericUpDown_leftMargin.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown_leftMargin.Location = new System.Drawing.Point(454, 12);
            this.numericUpDown_leftMargin.Name = "numericUpDown_leftMargin";
            this.numericUpDown_leftMargin.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown_leftMargin.TabIndex = 3;
            this.numericUpDown_leftMargin.ValueChanged += new System.EventHandler(this.numericUpDown_leftMargin_ValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.ContextMenuStrip = this.contextMenuStrip_Picture2;
            this.pictureBox2.Location = new System.Drawing.Point(6, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(557, 81);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // contextMenuStrip_Picture2
            // 
            this.contextMenuStrip_Picture2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolPrintAllStripMenuItem});
            this.contextMenuStrip_Picture2.Name = "contextMenuStrip_Picture1";
            this.contextMenuStrip_Picture2.Size = new System.Drawing.Size(100, 26);
            // 
            // toolPrintAllStripMenuItem
            // 
            this.toolPrintAllStripMenuItem.Name = "toolPrintAllStripMenuItem";
            this.toolPrintAllStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.toolPrintAllStripMenuItem.Text = "&Print";
            this.toolPrintAllStripMenuItem.Click += new System.EventHandler(this.printAllToolStripMenuItem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Printer:";
            // 
            // comboBox_printers
            // 
            this.comboBox_printers.FormattingEnabled = true;
            this.comboBox_printers.Location = new System.Drawing.Point(56, 19);
            this.comboBox_printers.Name = "comboBox_printers";
            this.comboBox_printers.Size = new System.Drawing.Size(223, 21);
            this.comboBox_printers.TabIndex = 0;
            this.comboBox_printers.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrinters_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(296, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Paper:";
            // 
            // comboBox_papers
            // 
            this.comboBox_papers.FormattingEnabled = true;
            this.comboBox_papers.Location = new System.Drawing.Point(340, 19);
            this.comboBox_papers.Name = "comboBox_papers";
            this.comboBox_papers.Size = new System.Drawing.Size(223, 21);
            this.comboBox_papers.TabIndex = 1;
            this.comboBox_papers.SelectedIndexChanged += new System.EventHandler(this.comboBox_papers_SelectedIndexChanged);
            this.comboBox_papers.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBox_papers_Format);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox_papers);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.comboBox_printers);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(18, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(575, 65);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(626, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem1});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.saveToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem1.Text = "&Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 556);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip_Picture1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoomFactor)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_totalCount)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_topMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_labelsPerPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_spaceBetween)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_leftMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.contextMenuStrip_Picture2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.ComboBox comboBox_products;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_size;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_units;
        private System.Windows.Forms.ComboBox comboBox_correctionLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_quiteZone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownZoomFactor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Picture1;
        private System.Windows.Forms.ToolStripMenuItem printSingelToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown_labelsPerPage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Picture2;
        private System.Windows.Forms.ToolStripMenuItem toolPrintAllStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown_spaceBetween;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown_topMargin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_printers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox_papers;
        private System.Windows.Forms.NumericUpDown numericUpDown_totalCount;
        private System.Windows.Forms.NumericUpDown numericUpDown_leftMargin;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Label label_print_total;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
    }
}

