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
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip_Picture1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSizeUnit = new System.Windows.Forms.ComboBox();
            this.comboBoxCorrectionLevel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxQuiteZone = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownZoomFactor = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_labelsPerPage = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip_Picture1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoomFactor)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_labelsPerPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // comboBoxProducts
            // 
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(59, 16);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(223, 21);
            this.comboBoxProducts.TabIndex = 0;
            this.comboBoxProducts.SelectedIndexChanged += new System.EventHandler(this.comboBoxProducts_SelectedIndexChanged);
            this.comboBoxProducts.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxProducts_Format);
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
            this.pictureBox1.Location = new System.Drawing.Point(91, 49);
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
            this.printToolStripMenuItem});
            this.contextMenuStrip_Picture1.Name = "contextMenuStrip_Picture1";
            this.contextMenuStrip_Picture1.Size = new System.Drawing.Size(100, 26);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxProducts);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 224);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxSizeUnit, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxCorrectionLevel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxQuiteZone, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownSize, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(185, 115);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Correction:";
            // 
            // comboBoxSizeUnit
            // 
            this.comboBoxSizeUnit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxSizeUnit.FormattingEnabled = true;
            this.comboBoxSizeUnit.Items.AddRange(new object[] {
            "mm",
            "in"});
            this.comboBoxSizeUnit.Location = new System.Drawing.Point(121, 3);
            this.comboBoxSizeUnit.Name = "comboBoxSizeUnit";
            this.comboBoxSizeUnit.Size = new System.Drawing.Size(44, 21);
            this.comboBoxSizeUnit.TabIndex = 1;
            this.comboBoxSizeUnit.Text = "mm";
            this.comboBoxSizeUnit.SelectedIndexChanged += new System.EventHandler(this.comboBoxSizeUnit_SelectedIndexChanged);
            // 
            // comboBoxCorrectionLevel
            // 
            this.comboBoxCorrectionLevel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.comboBoxCorrectionLevel, 2);
            this.comboBoxCorrectionLevel.FormattingEnabled = true;
            this.comboBoxCorrectionLevel.Items.AddRange(new object[] {
            "L",
            "M",
            "Q",
            "H"});
            this.comboBoxCorrectionLevel.Location = new System.Drawing.Point(67, 30);
            this.comboBoxCorrectionLevel.Name = "comboBoxCorrectionLevel";
            this.comboBoxCorrectionLevel.Size = new System.Drawing.Size(32, 21);
            this.comboBoxCorrectionLevel.TabIndex = 2;
            this.comboBoxCorrectionLevel.Text = "L";
            this.comboBoxCorrectionLevel.SelectedIndexChanged += new System.EventHandler(this.comboBoxCorrectionLevel_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quite:";
            // 
            // comboBoxQuiteZone
            // 
            this.comboBoxQuiteZone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxQuiteZone.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "2",
            "4"});
            this.tableLayoutPanel1.SetColumnSpan(this.comboBoxQuiteZone, 2);
            this.comboBoxQuiteZone.FormattingEnabled = true;
            this.comboBoxQuiteZone.Items.AddRange(new object[] {
            "0",
            "2",
            "4"});
            this.comboBoxQuiteZone.Location = new System.Drawing.Point(67, 57);
            this.comboBoxQuiteZone.Name = "comboBoxQuiteZone";
            this.comboBoxQuiteZone.Size = new System.Drawing.Size(32, 21);
            this.comboBoxQuiteZone.TabIndex = 3;
            this.comboBoxQuiteZone.Text = "0";
            this.comboBoxQuiteZone.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuiteZone_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Size:";
            // 
            // numericUpDownSize
            // 
            this.numericUpDownSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownSize.DecimalPlaces = 3;
            this.numericUpDownSize.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownSize.Location = new System.Drawing.Point(67, 3);
            this.numericUpDownSize.Name = "numericUpDownSize";
            this.numericUpDownSize.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownSize.TabIndex = 0;
            this.numericUpDownSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            65536});
            this.numericUpDownSize.ValueChanged += new System.EventHandler(this.numericUpDownSize_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numericUpDownZoomFactor);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.textBoxData);
            this.groupBox2.Location = new System.Drawing.Point(324, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 224);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Zoom:";
            // 
            // numericUpDownZoomFactor
            // 
            this.numericUpDownZoomFactor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownZoomFactor.DecimalPlaces = 2;
            this.numericUpDownZoomFactor.Location = new System.Drawing.Point(131, 163);
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
            this.groupBox3.Controls.Add(this.numericUpDown_labelsPerPage);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Location = new System.Drawing.Point(12, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(581, 193);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // numericUpDown_labelsPerPage
            // 
            this.numericUpDown_labelsPerPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_labelsPerPage.Location = new System.Drawing.Point(60, 33);
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
            this.numericUpDown_labelsPerPage.TabIndex = 19;
            this.numericUpDown_labelsPerPage.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(10, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(553, 100);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 570);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip_Picture1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoomFactor)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_labelsPerPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSizeUnit;
        private System.Windows.Forms.ComboBox comboBoxCorrectionLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxQuiteZone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownZoomFactor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Picture1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown_labelsPerPage;
    }
}

