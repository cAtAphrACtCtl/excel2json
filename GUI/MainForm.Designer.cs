namespace excel2json.GUI
{
    partial class MainForm
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            statusStrip = new System.Windows.Forms.StatusStrip();
            statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            toolStrip = new System.Windows.Forms.ToolStrip();
            btnImportExcel = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            btnCopyJSON = new System.Windows.Forms.ToolStripButton();
            btnSaveJson = new System.Windows.Forms.ToolStripButton();
            btnCopyCSharp = new System.Windows.Forms.ToolStripButton();
            btnSaveCSharp = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            btnHelp = new System.Windows.Forms.ToolStripButton();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            panelExcelDropBox = new System.Windows.Forms.Panel();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            pictureBoxExcel = new System.Windows.Forms.PictureBox();
            labelExcelFile = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            textBoxExcelPath = new System.Windows.Forms.TextBox();
            btnExportCode = new System.Windows.Forms.Button();
            btnExportJson = new System.Windows.Forms.Button();
            textBoxBatchCSPath = new System.Windows.Forms.TextBox();
            textBoxBatchJsonPath = new System.Windows.Forms.TextBox();
            textBoxNameSpace = new System.Windows.Forms.TextBox();
            checkBoxAllString = new System.Windows.Forms.CheckBox();
            checkBoxCellJson = new System.Windows.Forms.CheckBox();
            textBoxExculdePrefix = new System.Windows.Forms.TextBox();
            comboBoxSheetName = new System.Windows.Forms.ComboBox();
            comboBoxDateFormat = new System.Windows.Forms.ComboBox();
            btnReimport = new System.Windows.Forms.Button();
            comboBoxLowcase = new System.Windows.Forms.ComboBox();
            comboBoxHeader = new System.Windows.Forms.ComboBox();
            comboBoxEncoding = new System.Windows.Forms.ComboBox();
            comboBoxType = new System.Windows.Forms.ComboBox();
            tabControlCode = new System.Windows.Forms.TabControl();
            tabPageJSON = new System.Windows.Forms.TabPage();
            tabCSharp = new System.Windows.Forms.TabPage();
            backgroundWorker = new System.ComponentModel.BackgroundWorker();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            statusStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panelExcelDropBox.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExcel).BeginInit();
            groupBox1.SuspendLayout();
            tabControlCode.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(11, 98);
            label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(187, 24);
            label2.TabIndex = 1;
            label2.Text = "Encoding:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(57, 46);
            label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(117, 24);
            label1.TabIndex = 1;
            label1.Text = "Export Type:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(11, 150);
            label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(187, 24);
            label4.TabIndex = 6;
            label4.Text = "Lowcase:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(11, 202);
            label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(187, 24);
            label3.TabIndex = 4;
            label3.Text = "Header:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Location = new System.Drawing.Point(11, 254);
            label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(187, 24);
            label5.TabIndex = 9;
            label5.Text = "Date Format:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Location = new System.Drawing.Point(11, 306);
            label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(187, 24);
            label6.TabIndex = 11;
            label6.Text = "SheetName:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Location = new System.Drawing.Point(11, 358);
            label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(187, 24);
            label7.TabIndex = 13;
            label7.Text = "ExculdePrefix:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Location = new System.Drawing.Point(-87, 664);
            label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(187, 24);
            label8.TabIndex = 23;
            label8.Text = "ExcelPath:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Location = new System.Drawing.Point(-75, 537);
            label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(187, 24);
            label9.TabIndex = 24;
            label9.Text = "NameSpace";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusLabel });
            statusStrip.Location = new System.Drawing.Point(0, 1093);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 26, 0);
            statusStrip.Size = new System.Drawing.Size(1437, 31);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "Ready";
            // 
            // statusLabel
            // 
            statusLabel.IsLink = true;
            statusLabel.Name = "statusLabel";
            statusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            statusLabel.Size = new System.Drawing.Size(211, 24);
            statusLabel.Text = "https://neil3d.github.io";
            statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            statusLabel.Click += statusLabel_Click;
            // 
            // toolStrip
            // 
            toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnImportExcel, toolStripSeparator1, btnCopyJSON, btnSaveJson, btnCopyCSharp, btnSaveCSharp, toolStripSeparator2, btnHelp });
            toolStrip.Location = new System.Drawing.Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            toolStrip.Size = new System.Drawing.Size(1437, 33);
            toolStrip.TabIndex = 4;
            toolStrip.Text = "Import excel file and export as JSON";
            // 
            // btnImportExcel
            // 
            btnImportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnImportExcel.Name = "btnImportExcel";
            btnImportExcel.Size = new System.Drawing.Size(121, 28);
            btnImportExcel.Text = "Import Excel";
            btnImportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnImportExcel.ToolTipText = "Import Excel .xlsx file";
            btnImportExcel.Click += btnImportExcel_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // btnCopyJSON
            // 
            btnCopyJSON.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnCopyJSON.Name = "btnCopyJSON";
            btnCopyJSON.Size = new System.Drawing.Size(111, 28);
            btnCopyJSON.Text = "Copy JSON";
            btnCopyJSON.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnCopyJSON.ToolTipText = "Copy JSON string to clipboard";
            btnCopyJSON.Click += btnCopyJSON_Click;
            // 
            // btnSaveJson
            // 
            btnSaveJson.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSaveJson.Name = "btnSaveJson";
            btnSaveJson.Size = new System.Drawing.Size(105, 28);
            btnSaveJson.Text = "Save JSON";
            btnSaveJson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSaveJson.ToolTipText = "Save JSON file";
            btnSaveJson.Click += btnSaveJson_Click;
            // 
            // btnCopyCSharp
            // 
            btnCopyCSharp.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnCopyCSharp.Name = "btnCopyCSharp";
            btnCopyCSharp.Size = new System.Drawing.Size(87, 28);
            btnCopyCSharp.Text = "Copy C#";
            btnCopyCSharp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnCopyCSharp.ToolTipText = "Save JSON file";
            btnCopyCSharp.Click += btnCopyCSharp_Click;
            // 
            // btnSaveCSharp
            // 
            btnSaveCSharp.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSaveCSharp.Name = "btnSaveCSharp";
            btnSaveCSharp.Size = new System.Drawing.Size(81, 28);
            btnSaveCSharp.Text = "Save C#";
            btnSaveCSharp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSaveCSharp.ToolTipText = "Save JSON file";
            btnSaveCSharp.Click += btnSaveCSharp_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // btnHelp
            // 
            btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new System.Drawing.Size(55, 28);
            btnHelp.Text = "Help";
            btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnHelp.ToolTipText = "Help Document on web";
            btnHelp.Click += btnHelp_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splitContainer1.Location = new System.Drawing.Point(0, 33);
            splitContainer1.Margin = new System.Windows.Forms.Padding(6);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControlCode);
            splitContainer1.Size = new System.Drawing.Size(1437, 1060);
            splitContainer1.SplitterDistance = 288;
            splitContainer1.SplitterWidth = 7;
            splitContainer1.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panelExcelDropBox);
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(286, 1058);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panelExcelDropBox
            // 
            panelExcelDropBox.AllowDrop = true;
            panelExcelDropBox.BackColor = System.Drawing.SystemColors.ControlLight;
            panelExcelDropBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelExcelDropBox.Controls.Add(flowLayoutPanel2);
            panelExcelDropBox.Location = new System.Drawing.Point(15, 16);
            panelExcelDropBox.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            panelExcelDropBox.Name = "panelExcelDropBox";
            panelExcelDropBox.Size = new System.Drawing.Size(493, 258);
            panelExcelDropBox.TabIndex = 1;
            panelExcelDropBox.DragDrop += panelExcelDropBox_DragDrop;
            panelExcelDropBox.DragEnter += panelExcelDropBox_DragEnter;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(pictureBoxExcel);
            flowLayoutPanel2.Controls.Add(labelExcelFile);
            flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(491, 260);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // pictureBoxExcel
            // 
            pictureBoxExcel.Location = new System.Drawing.Point(6, 6);
            pictureBoxExcel.Margin = new System.Windows.Forms.Padding(6);
            pictureBoxExcel.Name = "pictureBoxExcel";
            pictureBoxExcel.Size = new System.Drawing.Size(480, 174);
            pictureBoxExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBoxExcel.TabIndex = 0;
            pictureBoxExcel.TabStop = false;
            // 
            // labelExcelFile
            // 
            labelExcelFile.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelExcelFile.Location = new System.Drawing.Point(6, 186);
            labelExcelFile.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelExcelFile.Name = "labelExcelFile";
            labelExcelFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            labelExcelFile.Size = new System.Drawing.Size(477, 70);
            labelExcelFile.TabIndex = 1;
            labelExcelFile.Text = "Drop you .xlsx file here!";
            labelExcelFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBoxExcelPath);
            groupBox1.Controls.Add(btnExportCode);
            groupBox1.Controls.Add(btnExportJson);
            groupBox1.Controls.Add(textBoxBatchCSPath);
            groupBox1.Controls.Add(textBoxBatchJsonPath);
            groupBox1.Controls.Add(textBoxNameSpace);
            groupBox1.Controls.Add(checkBoxAllString);
            groupBox1.Controls.Add(checkBoxCellJson);
            groupBox1.Controls.Add(textBoxExculdePrefix);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBoxSheetName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBoxDateFormat);
            groupBox1.Controls.Add(btnReimport);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBoxLowcase);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBoxHeader);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxEncoding);
            groupBox1.Controls.Add(comboBoxType);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox1.Location = new System.Drawing.Point(15, 306);
            groupBox1.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(6);
            groupBox1.Size = new System.Drawing.Size(493, 730);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Options";
            // 
            // textBoxExcelPath
            // 
            textBoxExcelPath.Location = new System.Drawing.Point(103, 657);
            textBoxExcelPath.Margin = new System.Windows.Forms.Padding(6);
            textBoxExcelPath.Name = "textBoxExcelPath";
            textBoxExcelPath.Size = new System.Drawing.Size(272, 30);
            textBoxExcelPath.TabIndex = 22;
            textBoxExcelPath.DoubleClick += textBoxExcelPath_Click;
            // 
            // btnExportCode
            // 
            btnExportCode.Location = new System.Drawing.Point(-4, 614);
            btnExportCode.Name = "btnExportCode";
            btnExportCode.Size = new System.Drawing.Size(116, 34);
            btnExportCode.TabIndex = 21;
            btnExportCode.Text = "ExportCode";
            btnExportCode.UseVisualStyleBackColor = true;
            btnExportCode.Click += btnExportCode_Click;
            // 
            // btnExportJson
            // 
            btnExportJson.Location = new System.Drawing.Point(-12, 573);
            btnExportJson.Name = "btnExportJson";
            btnExportJson.Size = new System.Drawing.Size(124, 34);
            btnExportJson.TabIndex = 20;
            btnExportJson.Text = "ExportJson";
            btnExportJson.UseVisualStyleBackColor = true;
            btnExportJson.Click += btnExportJson_Click;
            // 
            // textBoxBatchCSPath
            // 
            textBoxBatchCSPath.Location = new System.Drawing.Point(121, 615);
            textBoxBatchCSPath.Margin = new System.Windows.Forms.Padding(6);
            textBoxBatchCSPath.Name = "textBoxBatchCSPath";
            textBoxBatchCSPath.Size = new System.Drawing.Size(272, 30);
            textBoxBatchCSPath.TabIndex = 19;
            textBoxBatchCSPath.DoubleClick += textBoxExportJsonPath_Click;
            // 
            // textBoxBatchJsonPath
            // 
            textBoxBatchJsonPath.Location = new System.Drawing.Point(121, 573);
            textBoxBatchJsonPath.Margin = new System.Windows.Forms.Padding(6);
            textBoxBatchJsonPath.Name = "textBoxBatchJsonPath";
            textBoxBatchJsonPath.Size = new System.Drawing.Size(272, 30);
            textBoxBatchJsonPath.TabIndex = 18;
            textBoxBatchJsonPath.DoubleClick += textBoxFilePath_Click;
            // 
            // textBoxNameSpace
            // 
            textBoxNameSpace.Location = new System.Drawing.Point(121, 531);
            textBoxNameSpace.Margin = new System.Windows.Forms.Padding(6);
            textBoxNameSpace.Name = "textBoxNameSpace";
            textBoxNameSpace.Size = new System.Drawing.Size(272, 30);
            textBoxNameSpace.TabIndex = 17;
            textBoxNameSpace.Text = "Game.Data";
            // 
            // checkBoxAllString
            // 
            checkBoxAllString.AutoSize = true;
            checkBoxAllString.Location = new System.Drawing.Point(37, 460);
            checkBoxAllString.Margin = new System.Windows.Forms.Padding(6);
            checkBoxAllString.Name = "checkBoxAllString";
            checkBoxAllString.Size = new System.Drawing.Size(116, 28);
            checkBoxAllString.TabIndex = 16;
            checkBoxAllString.Text = "All String";
            checkBoxAllString.UseVisualStyleBackColor = true;
            // 
            // checkBoxCellJson
            // 
            checkBoxCellJson.AutoSize = true;
            checkBoxCellJson.Location = new System.Drawing.Point(37, 420);
            checkBoxCellJson.Margin = new System.Windows.Forms.Padding(6);
            checkBoxCellJson.Name = "checkBoxCellJson";
            checkBoxCellJson.Size = new System.Drawing.Size(260, 28);
            checkBoxCellJson.TabIndex = 15;
            checkBoxCellJson.Text = "Convert Json String in Cell";
            checkBoxCellJson.UseVisualStyleBackColor = true;
            // 
            // textBoxExculdePrefix
            // 
            textBoxExculdePrefix.Location = new System.Drawing.Point(209, 360);
            textBoxExculdePrefix.Margin = new System.Windows.Forms.Padding(6);
            textBoxExculdePrefix.Name = "textBoxExculdePrefix";
            textBoxExculdePrefix.Size = new System.Drawing.Size(272, 30);
            textBoxExculdePrefix.TabIndex = 14;
            // 
            // comboBoxSheetName
            // 
            comboBoxSheetName.DisplayMember = "0";
            comboBoxSheetName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxSheetName.FormattingEnabled = true;
            comboBoxSheetName.Items.AddRange(new object[] { "Yes", "No" });
            comboBoxSheetName.Location = new System.Drawing.Point(209, 306);
            comboBoxSheetName.Margin = new System.Windows.Forms.Padding(6);
            comboBoxSheetName.Name = "comboBoxSheetName";
            comboBoxSheetName.Size = new System.Drawing.Size(272, 32);
            comboBoxSheetName.TabIndex = 10;
            comboBoxSheetName.ValueMember = "0";
            // 
            // comboBoxDateFormat
            // 
            comboBoxDateFormat.DisplayMember = "0";
            comboBoxDateFormat.FormattingEnabled = true;
            comboBoxDateFormat.Items.AddRange(new object[] { "yyyy/MM/dd", "yyyy/MM/dd hh:mm:ss" });
            comboBoxDateFormat.Location = new System.Drawing.Point(209, 254);
            comboBoxDateFormat.Margin = new System.Windows.Forms.Padding(6);
            comboBoxDateFormat.Name = "comboBoxDateFormat";
            comboBoxDateFormat.Size = new System.Drawing.Size(272, 32);
            comboBoxDateFormat.TabIndex = 8;
            comboBoxDateFormat.ValueMember = "0";
            // 
            // btnReimport
            // 
            btnReimport.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnReimport.Location = new System.Drawing.Point(6, 694);
            btnReimport.Margin = new System.Windows.Forms.Padding(6);
            btnReimport.Name = "btnReimport";
            btnReimport.Size = new System.Drawing.Size(481, 30);
            btnReimport.TabIndex = 7;
            btnReimport.Text = "Reimport";
            btnReimport.UseVisualStyleBackColor = true;
            btnReimport.Click += btnReimport_Click;
            // 
            // comboBoxLowcase
            // 
            comboBoxLowcase.DisplayMember = "0";
            comboBoxLowcase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxLowcase.FormattingEnabled = true;
            comboBoxLowcase.Items.AddRange(new object[] { "Yes", "No" });
            comboBoxLowcase.Location = new System.Drawing.Point(209, 150);
            comboBoxLowcase.Margin = new System.Windows.Forms.Padding(6);
            comboBoxLowcase.Name = "comboBoxLowcase";
            comboBoxLowcase.Size = new System.Drawing.Size(272, 32);
            comboBoxLowcase.TabIndex = 5;
            comboBoxLowcase.ValueMember = "0";
            // 
            // comboBoxHeader
            // 
            comboBoxHeader.DisplayMember = "0";
            comboBoxHeader.FormattingEnabled = true;
            comboBoxHeader.Items.AddRange(new object[] { "2", "3", "4", "5", "6" });
            comboBoxHeader.Location = new System.Drawing.Point(209, 202);
            comboBoxHeader.Margin = new System.Windows.Forms.Padding(6);
            comboBoxHeader.Name = "comboBoxHeader";
            comboBoxHeader.Size = new System.Drawing.Size(272, 32);
            comboBoxHeader.TabIndex = 3;
            comboBoxHeader.ValueMember = "0";
            // 
            // comboBoxEncoding
            // 
            comboBoxEncoding.DisplayMember = "0";
            comboBoxEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxEncoding.FormattingEnabled = true;
            comboBoxEncoding.Location = new System.Drawing.Point(209, 98);
            comboBoxEncoding.Margin = new System.Windows.Forms.Padding(6);
            comboBoxEncoding.Name = "comboBoxEncoding";
            comboBoxEncoding.Size = new System.Drawing.Size(272, 32);
            comboBoxEncoding.TabIndex = 0;
            comboBoxEncoding.ValueMember = "0";
            // 
            // comboBoxType
            // 
            comboBoxType.DisplayMember = "0";
            comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Dict Object", "Array" });
            comboBoxType.Location = new System.Drawing.Point(209, 46);
            comboBoxType.Margin = new System.Windows.Forms.Padding(6);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new System.Drawing.Size(272, 32);
            comboBoxType.TabIndex = 0;
            comboBoxType.ValueMember = "0";
            // 
            // tabControlCode
            // 
            tabControlCode.Controls.Add(tabPageJSON);
            tabControlCode.Controls.Add(tabCSharp);
            tabControlCode.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControlCode.Location = new System.Drawing.Point(0, 0);
            tabControlCode.Margin = new System.Windows.Forms.Padding(6);
            tabControlCode.Name = "tabControlCode";
            tabControlCode.SelectedIndex = 0;
            tabControlCode.Size = new System.Drawing.Size(1140, 1058);
            tabControlCode.TabIndex = 0;
            // 
            // tabPageJSON
            // 
            tabPageJSON.Location = new System.Drawing.Point(4, 33);
            tabPageJSON.Margin = new System.Windows.Forms.Padding(6);
            tabPageJSON.Name = "tabPageJSON";
            tabPageJSON.Padding = new System.Windows.Forms.Padding(6);
            tabPageJSON.Size = new System.Drawing.Size(1132, 1021);
            tabPageJSON.TabIndex = 0;
            tabPageJSON.Text = "JSON";
            tabPageJSON.UseVisualStyleBackColor = true;
            // 
            // tabCSharp
            // 
            tabCSharp.Location = new System.Drawing.Point(4, 33);
            tabCSharp.Margin = new System.Windows.Forms.Padding(6);
            tabCSharp.Name = "tabCSharp";
            tabCSharp.Padding = new System.Windows.Forms.Padding(6);
            tabCSharp.Size = new System.Drawing.Size(1132, 1021);
            tabCSharp.TabIndex = 1;
            tabCSharp.Text = "C#";
            tabCSharp.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker
            // 
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1437, 1124);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip);
            Controls.Add(statusStrip);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(6);
            MinimumSize = new System.Drawing.Size(1448, 1144);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "excel2json";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panelExcelDropBox.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxExcel).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControlCode.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnImportExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton btnCopyJSON;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelExcelDropBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBoxExcel;
        private System.Windows.Forms.Label labelExcelFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxEncoding;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxLowcase;
        private System.Windows.Forms.ComboBox comboBoxHeader;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ToolStripButton btnSaveJson;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnReimport;
        private System.Windows.Forms.TabControl tabControlCode;
        private System.Windows.Forms.TabPage tabPageJSON;
        private System.Windows.Forms.ComboBox comboBoxDateFormat;
        private System.Windows.Forms.ComboBox comboBoxSheetName;
        private System.Windows.Forms.TabPage tabCSharp;
        private System.Windows.Forms.ToolStripButton btnCopyCSharp;
        private System.Windows.Forms.ToolStripButton btnSaveCSharp;
        private System.Windows.Forms.TextBox textBoxExculdePrefix;
        private System.Windows.Forms.CheckBox checkBoxCellJson;
        private System.Windows.Forms.CheckBox checkBoxAllString;
        private System.Windows.Forms.TextBox textBoxBatchCSPath;
        private System.Windows.Forms.TextBox textBoxBatchJsonPath;
        private System.Windows.Forms.TextBox textBoxNameSpace;
        private System.Windows.Forms.Button btnExportCode;
        private System.Windows.Forms.Button btnExportJson;
        private System.Windows.Forms.TextBox textBoxExcelPath;
    }
}