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
            leftPanel = new System.Windows.Forms.FlowLayoutPanel();
            panelExcelDropBox = new System.Windows.Forms.Panel();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            pictureBoxExcel = new System.Windows.Forms.PictureBox();
            labelExcelFile = new System.Windows.Forms.Label();
            groupBoxOption = new System.Windows.Forms.GroupBox();
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
            SaveOptionButton = new System.Windows.Forms.Button();
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
            leftPanel.SuspendLayout();
            panelExcelDropBox.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExcel).BeginInit();
            groupBoxOption.SuspendLayout();
            tabControlCode.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(7, 69);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(119, 17);
            label2.TabIndex = 1;
            label2.Text = "Encoding:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(36, 33);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 17);
            label1.TabIndex = 1;
            label1.Text = "Export Type:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(7, 106);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(119, 17);
            label4.TabIndex = 6;
            label4.Text = "Lowcase:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(7, 143);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(119, 17);
            label3.TabIndex = 4;
            label3.Text = "Header:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Location = new System.Drawing.Point(7, 180);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(119, 17);
            label5.TabIndex = 9;
            label5.Text = "Date Format:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Location = new System.Drawing.Point(7, 217);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(119, 17);
            label6.TabIndex = 11;
            label6.Text = "SheetName:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Location = new System.Drawing.Point(7, 254);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(119, 17);
            label7.TabIndex = 13;
            label7.Text = "ExculdePrefix:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Location = new System.Drawing.Point(-36, 445);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(119, 17);
            label8.TabIndex = 23;
            label8.Text = "ExcelPath:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Location = new System.Drawing.Point(-16, 355);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(119, 17);
            label9.TabIndex = 24;
            label9.Text = "NameSpace";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusLabel });
            statusStrip.Location = new System.Drawing.Point(0, 774);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
            statusStrip.Size = new System.Drawing.Size(1658, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "Ready";
            // 
            // statusLabel
            // 
            statusLabel.IsLink = true;
            statusLabel.Name = "statusLabel";
            statusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            statusLabel.Size = new System.Drawing.Size(139, 17);
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
            toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            toolStrip.Size = new System.Drawing.Size(1658, 25);
            toolStrip.TabIndex = 4;
            toolStrip.Text = "Import excel file and export as JSON";
            // 
            // btnImportExcel
            // 
            btnImportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnImportExcel.Name = "btnImportExcel";
            btnImportExcel.Size = new System.Drawing.Size(85, 22);
            btnImportExcel.Text = "Import Excel";
            btnImportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnImportExcel.ToolTipText = "Import Excel .xlsx file";
            btnImportExcel.Click += btnImportExcel_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCopyJSON
            // 
            btnCopyJSON.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnCopyJSON.Name = "btnCopyJSON";
            btnCopyJSON.Size = new System.Drawing.Size(78, 22);
            btnCopyJSON.Text = "Copy JSON";
            btnCopyJSON.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnCopyJSON.ToolTipText = "Copy JSON string to clipboard";
            btnCopyJSON.Click += btnCopyJSON_Click;
            // 
            // btnSaveJson
            // 
            btnSaveJson.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSaveJson.Name = "btnSaveJson";
            btnSaveJson.Size = new System.Drawing.Size(75, 22);
            btnSaveJson.Text = "Save JSON";
            btnSaveJson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSaveJson.ToolTipText = "Save JSON file";
            btnSaveJson.Click += btnSaveJson_Click;
            // 
            // btnCopyCSharp
            // 
            btnCopyCSharp.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnCopyCSharp.Name = "btnCopyCSharp";
            btnCopyCSharp.Size = new System.Drawing.Size(62, 22);
            btnCopyCSharp.Text = "Copy C#";
            btnCopyCSharp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnCopyCSharp.ToolTipText = "Save JSON file";
            btnCopyCSharp.Click += btnCopyCSharp_Click;
            // 
            // btnSaveCSharp
            // 
            btnSaveCSharp.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSaveCSharp.Name = "btnSaveCSharp";
            btnSaveCSharp.Size = new System.Drawing.Size(59, 22);
            btnSaveCSharp.Text = "Save C#";
            btnSaveCSharp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSaveCSharp.ToolTipText = "Save JSON file";
            btnSaveCSharp.Click += btnSaveCSharp_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnHelp
            // 
            btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new System.Drawing.Size(39, 22);
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
            splitContainer1.Location = new System.Drawing.Point(0, 25);
            splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(leftPanel);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControlCode);
            splitContainer1.Size = new System.Drawing.Size(1658, 749);
            splitContainer1.SplitterDistance = 400;
            splitContainer1.TabIndex = 5;
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(panelExcelDropBox);
            leftPanel.Controls.Add(groupBoxOption);
            leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            leftPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            leftPanel.Location = new System.Drawing.Point(0, 0);
            leftPanel.Margin = new System.Windows.Forms.Padding(4);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new System.Drawing.Size(398, 747);
            leftPanel.TabIndex = 0;
            // 
            // panelExcelDropBox
            // 
            panelExcelDropBox.AllowDrop = true;
            panelExcelDropBox.BackColor = System.Drawing.SystemColors.ControlLight;
            panelExcelDropBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelExcelDropBox.Controls.Add(flowLayoutPanel2);
            panelExcelDropBox.Location = new System.Drawing.Point(10, 11);
            panelExcelDropBox.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            panelExcelDropBox.Name = "panelExcelDropBox";
            panelExcelDropBox.Size = new System.Drawing.Size(314, 183);
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
            flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(312, 184);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // pictureBoxExcel
            // 
            pictureBoxExcel.Location = new System.Drawing.Point(4, 4);
            pictureBoxExcel.Margin = new System.Windows.Forms.Padding(4);
            pictureBoxExcel.Name = "pictureBoxExcel";
            pictureBoxExcel.Size = new System.Drawing.Size(305, 123);
            pictureBoxExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBoxExcel.TabIndex = 0;
            pictureBoxExcel.TabStop = false;
            // 
            // labelExcelFile
            // 
            labelExcelFile.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelExcelFile.Location = new System.Drawing.Point(4, 131);
            labelExcelFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelExcelFile.Name = "labelExcelFile";
            labelExcelFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            labelExcelFile.Size = new System.Drawing.Size(304, 50);
            labelExcelFile.TabIndex = 1;
            labelExcelFile.Text = "Drop you .xlsx file here!";
            labelExcelFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxOption
            // 
            groupBoxOption.Controls.Add(SaveOptionButton);
            groupBoxOption.Controls.Add(label9);
            groupBoxOption.Controls.Add(label8);
            groupBoxOption.Controls.Add(textBoxExcelPath);
            groupBoxOption.Controls.Add(btnExportCode);
            groupBoxOption.Controls.Add(btnExportJson);
            groupBoxOption.Controls.Add(textBoxBatchCSPath);
            groupBoxOption.Controls.Add(textBoxBatchJsonPath);
            groupBoxOption.Controls.Add(textBoxNameSpace);
            groupBoxOption.Controls.Add(checkBoxAllString);
            groupBoxOption.Controls.Add(checkBoxCellJson);
            groupBoxOption.Controls.Add(textBoxExculdePrefix);
            groupBoxOption.Controls.Add(label7);
            groupBoxOption.Controls.Add(label6);
            groupBoxOption.Controls.Add(comboBoxSheetName);
            groupBoxOption.Controls.Add(label5);
            groupBoxOption.Controls.Add(comboBoxDateFormat);
            groupBoxOption.Controls.Add(btnReimport);
            groupBoxOption.Controls.Add(label4);
            groupBoxOption.Controls.Add(comboBoxLowcase);
            groupBoxOption.Controls.Add(label3);
            groupBoxOption.Controls.Add(comboBoxHeader);
            groupBoxOption.Controls.Add(label2);
            groupBoxOption.Controls.Add(label1);
            groupBoxOption.Controls.Add(comboBoxEncoding);
            groupBoxOption.Controls.Add(comboBoxType);
            groupBoxOption.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBoxOption.Location = new System.Drawing.Point(10, 216);
            groupBoxOption.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            groupBoxOption.Name = "groupBoxOption";
            groupBoxOption.Padding = new System.Windows.Forms.Padding(4);
            groupBoxOption.Size = new System.Drawing.Size(314, 517);
            groupBoxOption.TabIndex = 3;
            groupBoxOption.TabStop = false;
            groupBoxOption.Text = "Options";
            // 
            // textBoxExcelPath
            // 
            textBoxExcelPath.Location = new System.Drawing.Point(120, 442);
            textBoxExcelPath.Margin = new System.Windows.Forms.Padding(4);
            textBoxExcelPath.Name = "textBoxExcelPath";
            textBoxExcelPath.Size = new System.Drawing.Size(175, 23);
            textBoxExcelPath.TabIndex = 22;
            textBoxExcelPath.DoubleClick += textBoxExcelPath_Click;
            // 
            // btnExportCode
            // 
            btnExportCode.Location = new System.Drawing.Point(9, 404);
            btnExportCode.Margin = new System.Windows.Forms.Padding(2);
            btnExportCode.Name = "btnExportCode";
            btnExportCode.Size = new System.Drawing.Size(74, 24);
            btnExportCode.TabIndex = 21;
            btnExportCode.Text = "ExportCode";
            btnExportCode.UseVisualStyleBackColor = true;
            btnExportCode.Click += btnExportCode_Click;
            // 
            // btnExportJson
            // 
            btnExportJson.Location = new System.Drawing.Point(4, 376);
            btnExportJson.Margin = new System.Windows.Forms.Padding(2);
            btnExportJson.Name = "btnExportJson";
            btnExportJson.Size = new System.Drawing.Size(79, 24);
            btnExportJson.TabIndex = 20;
            btnExportJson.Text = "ExportJson";
            btnExportJson.UseVisualStyleBackColor = true;
            btnExportJson.Click += btnExportJson_Click;
            // 
            // textBoxBatchCSPath
            // 
            textBoxBatchCSPath.Location = new System.Drawing.Point(120, 408);
            textBoxBatchCSPath.Margin = new System.Windows.Forms.Padding(4);
            textBoxBatchCSPath.Name = "textBoxBatchCSPath";
            textBoxBatchCSPath.Size = new System.Drawing.Size(175, 23);
            textBoxBatchCSPath.TabIndex = 19;
            textBoxBatchCSPath.DoubleClick += textBoxExportJsonPath_Click;
            // 
            // textBoxBatchJsonPath
            // 
            textBoxBatchJsonPath.Location = new System.Drawing.Point(120, 377);
            textBoxBatchJsonPath.Margin = new System.Windows.Forms.Padding(4);
            textBoxBatchJsonPath.Name = "textBoxBatchJsonPath";
            textBoxBatchJsonPath.Size = new System.Drawing.Size(175, 23);
            textBoxBatchJsonPath.TabIndex = 18;
            textBoxBatchJsonPath.DoubleClick += textBoxFilePath_Click;
            // 
            // textBoxNameSpace
            // 
            textBoxNameSpace.Location = new System.Drawing.Point(120, 355);
            textBoxNameSpace.Margin = new System.Windows.Forms.Padding(4);
            textBoxNameSpace.Name = "textBoxNameSpace";
            textBoxNameSpace.Size = new System.Drawing.Size(175, 23);
            textBoxNameSpace.TabIndex = 17;
            textBoxNameSpace.Text = "Game.Data";
            // 
            // checkBoxAllString
            // 
            checkBoxAllString.AutoSize = true;
            checkBoxAllString.Location = new System.Drawing.Point(24, 326);
            checkBoxAllString.Margin = new System.Windows.Forms.Padding(4);
            checkBoxAllString.Name = "checkBoxAllString";
            checkBoxAllString.Size = new System.Drawing.Size(79, 21);
            checkBoxAllString.TabIndex = 16;
            checkBoxAllString.Text = "All String";
            checkBoxAllString.UseVisualStyleBackColor = true;
            // 
            // checkBoxCellJson
            // 
            checkBoxCellJson.AutoSize = true;
            checkBoxCellJson.Location = new System.Drawing.Point(24, 298);
            checkBoxCellJson.Margin = new System.Windows.Forms.Padding(4);
            checkBoxCellJson.Name = "checkBoxCellJson";
            checkBoxCellJson.Size = new System.Drawing.Size(179, 21);
            checkBoxCellJson.TabIndex = 15;
            checkBoxCellJson.Text = "Convert Json String in Cell";
            checkBoxCellJson.UseVisualStyleBackColor = true;
            // 
            // textBoxExculdePrefix
            // 
            textBoxExculdePrefix.Location = new System.Drawing.Point(133, 255);
            textBoxExculdePrefix.Margin = new System.Windows.Forms.Padding(4);
            textBoxExculdePrefix.Name = "textBoxExculdePrefix";
            textBoxExculdePrefix.Size = new System.Drawing.Size(175, 23);
            textBoxExculdePrefix.TabIndex = 14;
            // 
            // comboBoxSheetName
            // 
            comboBoxSheetName.DisplayMember = "0";
            comboBoxSheetName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxSheetName.FormattingEnabled = true;
            comboBoxSheetName.Items.AddRange(new object[] { "Yes", "No" });
            comboBoxSheetName.Location = new System.Drawing.Point(133, 217);
            comboBoxSheetName.Margin = new System.Windows.Forms.Padding(4);
            comboBoxSheetName.Name = "comboBoxSheetName";
            comboBoxSheetName.Size = new System.Drawing.Size(175, 25);
            comboBoxSheetName.TabIndex = 10;
            comboBoxSheetName.ValueMember = "0";
            // 
            // comboBoxDateFormat
            // 
            comboBoxDateFormat.DisplayMember = "0";
            comboBoxDateFormat.FormattingEnabled = true;
            comboBoxDateFormat.Items.AddRange(new object[] { "yyyy/MM/dd", "yyyy/MM/dd hh:mm:ss" });
            comboBoxDateFormat.Location = new System.Drawing.Point(133, 180);
            comboBoxDateFormat.Margin = new System.Windows.Forms.Padding(4);
            comboBoxDateFormat.Name = "comboBoxDateFormat";
            comboBoxDateFormat.Size = new System.Drawing.Size(175, 25);
            comboBoxDateFormat.TabIndex = 8;
            comboBoxDateFormat.ValueMember = "0";
            // 
            // btnReimport
            // 
            btnReimport.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnReimport.Location = new System.Drawing.Point(4, 492);
            btnReimport.Margin = new System.Windows.Forms.Padding(4);
            btnReimport.Name = "btnReimport";
            btnReimport.Size = new System.Drawing.Size(306, 21);
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
            comboBoxLowcase.Location = new System.Drawing.Point(133, 106);
            comboBoxLowcase.Margin = new System.Windows.Forms.Padding(4);
            comboBoxLowcase.Name = "comboBoxLowcase";
            comboBoxLowcase.Size = new System.Drawing.Size(175, 25);
            comboBoxLowcase.TabIndex = 5;
            comboBoxLowcase.ValueMember = "0";
            // 
            // comboBoxHeader
            // 
            comboBoxHeader.DisplayMember = "0";
            comboBoxHeader.FormattingEnabled = true;
            comboBoxHeader.Items.AddRange(new object[] { "2", "3", "4", "5", "6" });
            comboBoxHeader.Location = new System.Drawing.Point(133, 143);
            comboBoxHeader.Margin = new System.Windows.Forms.Padding(4);
            comboBoxHeader.Name = "comboBoxHeader";
            comboBoxHeader.Size = new System.Drawing.Size(175, 25);
            comboBoxHeader.TabIndex = 3;
            comboBoxHeader.ValueMember = "0";
            // 
            // comboBoxEncoding
            // 
            comboBoxEncoding.DisplayMember = "0";
            comboBoxEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxEncoding.FormattingEnabled = true;
            comboBoxEncoding.Location = new System.Drawing.Point(133, 69);
            comboBoxEncoding.Margin = new System.Windows.Forms.Padding(4);
            comboBoxEncoding.Name = "comboBoxEncoding";
            comboBoxEncoding.Size = new System.Drawing.Size(175, 25);
            comboBoxEncoding.TabIndex = 0;
            comboBoxEncoding.ValueMember = "0";
            // 
            // comboBoxType
            // 
            comboBoxType.DisplayMember = "0";
            comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Dict Object", "Array" });
            comboBoxType.Location = new System.Drawing.Point(133, 33);
            comboBoxType.Margin = new System.Windows.Forms.Padding(4);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new System.Drawing.Size(175, 25);
            comboBoxType.TabIndex = 0;
            comboBoxType.ValueMember = "0";
            // 
            // tabControlCode
            // 
            tabControlCode.Controls.Add(tabPageJSON);
            tabControlCode.Controls.Add(tabCSharp);
            tabControlCode.Location = new System.Drawing.Point(4, 16);
            tabControlCode.Margin = new System.Windows.Forms.Padding(4);
            tabControlCode.Name = "tabControlCode";
            tabControlCode.SelectedIndex = 0;
            tabControlCode.Size = new System.Drawing.Size(1364, 747);
            tabControlCode.TabIndex = 0;
            // 
            // tabPageJSON
            // 
            tabPageJSON.Location = new System.Drawing.Point(4, 26);
            tabPageJSON.Margin = new System.Windows.Forms.Padding(4);
            tabPageJSON.Name = "tabPageJSON";
            tabPageJSON.Padding = new System.Windows.Forms.Padding(4);
            tabPageJSON.Size = new System.Drawing.Size(1356, 717);
            tabPageJSON.TabIndex = 0;
            tabPageJSON.Text = "JSON";
            tabPageJSON.UseVisualStyleBackColor = true;
            // 
            // tabCSharp
            // 
            tabCSharp.Location = new System.Drawing.Point(4, 26);
            tabCSharp.Margin = new System.Windows.Forms.Padding(4);
            tabCSharp.Name = "tabCSharp";
            tabCSharp.Padding = new System.Windows.Forms.Padding(4);
            tabCSharp.Size = new System.Drawing.Size(1356, 717);
            tabCSharp.TabIndex = 1;
            tabCSharp.Text = "C#";
            tabCSharp.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker
            // 
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
            // 
            // SaveOptionButton
            // 
            SaveOptionButton.Location = new System.Drawing.Point(68, 0);
            SaveOptionButton.Name = "SaveOptionButton";
            SaveOptionButton.Size = new System.Drawing.Size(94, 23);
            SaveOptionButton.TabIndex = 25;
            SaveOptionButton.Text = "SaveOption";
            SaveOptionButton.UseVisualStyleBackColor = true;
            SaveOptionButton.Click += SaveOptionButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1658, 796);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip);
            Controls.Add(statusStrip);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4);
            MinimumSize = new System.Drawing.Size(927, 822);
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
            leftPanel.ResumeLayout(false);
            panelExcelDropBox.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxExcel).EndInit();
            groupBoxOption.ResumeLayout(false);
            groupBoxOption.PerformLayout();
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
        private System.Windows.Forms.FlowLayoutPanel leftPanel;
        private System.Windows.Forms.Panel panelExcelDropBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBoxExcel;
        private System.Windows.Forms.Label labelExcelFile;
        private System.Windows.Forms.GroupBox groupBoxOption;
        private System.Windows.Forms.ComboBox comboBoxEncoding;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxLowcase;
        private System.Windows.Forms.ComboBox comboBoxHeader;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ToolStripButton btnSaveJson;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnReimport;
        private System.Windows.Forms.ComboBox comboBoxDateFormat;
        private System.Windows.Forms.ComboBox comboBoxSheetName;
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
        private System.Windows.Forms.TabControl tabControlCode;
        private System.Windows.Forms.TabPage tabPageJSON;
        private System.Windows.Forms.TabPage tabCSharp;
        private System.Windows.Forms.Button SaveOptionButton;
    }
}