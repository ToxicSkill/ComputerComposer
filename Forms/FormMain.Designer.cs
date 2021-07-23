
namespace ComputerComposerNsp
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dataGridViewComputers = new System.Windows.Forms.DataGridView();
            this.labelComputers = new System.Windows.Forms.Label();
            this.dataGridViewParts = new System.Windows.Forms.DataGridView();
            this.labelAction = new System.Windows.Forms.Label();
            this.labelGraphics = new System.Windows.Forms.Label();
            this.comboBoxGraphics = new System.Windows.Forms.ComboBox();
            this.labelProcessor = new System.Windows.Forms.Label();
            this.comboBoxProcessor = new System.Windows.Forms.ComboBox();
            this.labelRam = new System.Windows.Forms.Label();
            this.labelBox = new System.Windows.Forms.Label();
            this.labelPowerUnit = new System.Windows.Forms.Label();
            this.labelSystem = new System.Windows.Forms.Label();
            this.comboBoxRam = new System.Windows.Forms.ComboBox();
            this.comboBoxBox = new System.Windows.Forms.ComboBox();
            this.comboBoxPowerUnit = new System.Windows.Forms.ComboBox();
            this.comboBoxSystem = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.checkBoxRGB = new System.Windows.Forms.CheckBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelRGB = new System.Windows.Forms.Label();
            this.pictureBoxSingleComputer = new System.Windows.Forms.PictureBox();
            this.pictureBoxSystem = new System.Windows.Forms.PictureBox();
            this.pictureBoxPowerUnit = new System.Windows.Forms.PictureBox();
            this.pictureBoxBox = new System.Windows.Forms.PictureBox();
            this.pictureBoxRam = new System.Windows.Forms.PictureBox();
            this.pictureBoxCPU = new System.Windows.Forms.PictureBox();
            this.pictureBoxGPU = new System.Windows.Forms.PictureBox();
            this.pictureBoxElements = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCreateComputer = new System.Windows.Forms.Label();
            this.labelHello = new System.Windows.Forms.Label();
            this.labelActualUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComputers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSingleComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPowerUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxElements)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewComputers
            // 
            this.dataGridViewComputers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewComputers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewComputers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComputers.GridColor = System.Drawing.Color.Red;
            this.dataGridViewComputers.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewComputers.Name = "dataGridViewComputers";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComputers.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewComputers.Size = new System.Drawing.Size(985, 187);
            this.dataGridViewComputers.TabIndex = 0;
            this.dataGridViewComputers.SelectionChanged += new System.EventHandler(this.dataGridViewComputers_SelectionChanged);
            // 
            // labelComputers
            // 
            this.labelComputers.AutoSize = true;
            this.labelComputers.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelComputers.Location = new System.Drawing.Point(12, 13);
            this.labelComputers.Name = "labelComputers";
            this.labelComputers.Size = new System.Drawing.Size(123, 25);
            this.labelComputers.TabIndex = 1;
            this.labelComputers.Text = "Computers";
            // 
            // dataGridViewParts
            // 
            this.dataGridViewParts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewParts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParts.GridColor = System.Drawing.Color.Black;
            this.dataGridViewParts.Location = new System.Drawing.Point(12, 317);
            this.dataGridViewParts.Name = "dataGridViewParts";
            this.dataGridViewParts.Size = new System.Drawing.Size(571, 307);
            this.dataGridViewParts.TabIndex = 2;
            // 
            // labelAction
            // 
            this.labelAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAction.AutoSize = true;
            this.labelAction.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAction.Location = new System.Drawing.Point(12, 267);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(60, 25);
            this.labelAction.TabIndex = 3;
            this.labelAction.Text = "Parts";
            // 
            // labelGraphics
            // 
            this.labelGraphics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGraphics.AutoSize = true;
            this.labelGraphics.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGraphics.Location = new System.Drawing.Point(638, 362);
            this.labelGraphics.Name = "labelGraphics";
            this.labelGraphics.Size = new System.Drawing.Size(102, 24);
            this.labelGraphics.TabIndex = 7;
            this.labelGraphics.Text = "Graphics";
            // 
            // comboBoxGraphics
            // 
            this.comboBoxGraphics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGraphics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxGraphics.FormattingEnabled = true;
            this.comboBoxGraphics.Location = new System.Drawing.Point(765, 362);
            this.comboBoxGraphics.Name = "comboBoxGraphics";
            this.comboBoxGraphics.Size = new System.Drawing.Size(191, 28);
            this.comboBoxGraphics.TabIndex = 8;
            this.comboBoxGraphics.SelectedIndexChanged += new System.EventHandler(this.comboBoxGraphics_SelectedIndexChanged);
            this.comboBoxGraphics.Click += new System.EventHandler(this.comboBoxGraphics_Click);
            // 
            // labelProcessor
            // 
            this.labelProcessor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProcessor.AutoSize = true;
            this.labelProcessor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelProcessor.Location = new System.Drawing.Point(638, 407);
            this.labelProcessor.Name = "labelProcessor";
            this.labelProcessor.Size = new System.Drawing.Size(106, 24);
            this.labelProcessor.TabIndex = 9;
            this.labelProcessor.Text = "Processor";
            // 
            // comboBoxProcessor
            // 
            this.comboBoxProcessor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxProcessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxProcessor.FormattingEnabled = true;
            this.comboBoxProcessor.Location = new System.Drawing.Point(765, 407);
            this.comboBoxProcessor.Name = "comboBoxProcessor";
            this.comboBoxProcessor.Size = new System.Drawing.Size(191, 28);
            this.comboBoxProcessor.TabIndex = 10;
            this.comboBoxProcessor.SelectedIndexChanged += new System.EventHandler(this.comboBoxProcessor_SelectedIndexChanged);
            this.comboBoxProcessor.Click += new System.EventHandler(this.comboBoxProcessor_Click);
            // 
            // labelRam
            // 
            this.labelRam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRam.AutoSize = true;
            this.labelRam.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRam.Location = new System.Drawing.Point(638, 452);
            this.labelRam.Name = "labelRam";
            this.labelRam.Size = new System.Drawing.Size(55, 24);
            this.labelRam.TabIndex = 11;
            this.labelRam.Text = "Ram";
            // 
            // labelBox
            // 
            this.labelBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBox.AutoSize = true;
            this.labelBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBox.Location = new System.Drawing.Point(638, 497);
            this.labelBox.Name = "labelBox";
            this.labelBox.Size = new System.Drawing.Size(46, 24);
            this.labelBox.TabIndex = 12;
            this.labelBox.Text = "Box";
            // 
            // labelPowerUnit
            // 
            this.labelPowerUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPowerUnit.AutoSize = true;
            this.labelPowerUnit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPowerUnit.Location = new System.Drawing.Point(638, 542);
            this.labelPowerUnit.Name = "labelPowerUnit";
            this.labelPowerUnit.Size = new System.Drawing.Size(118, 24);
            this.labelPowerUnit.TabIndex = 13;
            this.labelPowerUnit.Text = "Power unit";
            // 
            // labelSystem
            // 
            this.labelSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSystem.AutoSize = true;
            this.labelSystem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSystem.Location = new System.Drawing.Point(638, 587);
            this.labelSystem.Name = "labelSystem";
            this.labelSystem.Size = new System.Drawing.Size(80, 24);
            this.labelSystem.TabIndex = 14;
            this.labelSystem.Text = "System";
            // 
            // comboBoxRam
            // 
            this.comboBoxRam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxRam.FormattingEnabled = true;
            this.comboBoxRam.Location = new System.Drawing.Point(765, 452);
            this.comboBoxRam.Name = "comboBoxRam";
            this.comboBoxRam.Size = new System.Drawing.Size(191, 28);
            this.comboBoxRam.TabIndex = 15;
            this.comboBoxRam.SelectedIndexChanged += new System.EventHandler(this.comboBoxRam_SelectedIndexChanged);
            this.comboBoxRam.Click += new System.EventHandler(this.comboBoxRam_Click);
            // 
            // comboBoxBox
            // 
            this.comboBoxBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxBox.FormattingEnabled = true;
            this.comboBoxBox.Location = new System.Drawing.Point(765, 497);
            this.comboBoxBox.Name = "comboBoxBox";
            this.comboBoxBox.Size = new System.Drawing.Size(191, 28);
            this.comboBoxBox.TabIndex = 16;
            this.comboBoxBox.SelectedIndexChanged += new System.EventHandler(this.comboBoxBox_SelectedIndexChanged);
            this.comboBoxBox.Click += new System.EventHandler(this.comboBoxBox_Click);
            // 
            // comboBoxPowerUnit
            // 
            this.comboBoxPowerUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPowerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPowerUnit.FormattingEnabled = true;
            this.comboBoxPowerUnit.Location = new System.Drawing.Point(765, 542);
            this.comboBoxPowerUnit.Name = "comboBoxPowerUnit";
            this.comboBoxPowerUnit.Size = new System.Drawing.Size(191, 28);
            this.comboBoxPowerUnit.TabIndex = 17;
            this.comboBoxPowerUnit.SelectedIndexChanged += new System.EventHandler(this.comboBoxPowerUnit_SelectedIndexChanged);
            this.comboBoxPowerUnit.Click += new System.EventHandler(this.comboBoxPowerUnit_Click);
            // 
            // comboBoxSystem
            // 
            this.comboBoxSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxSystem.FormattingEnabled = true;
            this.comboBoxSystem.Location = new System.Drawing.Point(765, 587);
            this.comboBoxSystem.Name = "comboBoxSystem";
            this.comboBoxSystem.Size = new System.Drawing.Size(191, 28);
            this.comboBoxSystem.TabIndex = 18;
            this.comboBoxSystem.SelectedIndexChanged += new System.EventHandler(this.comboBoxSystem_SelectedIndexChanged);
            this.comboBoxSystem.Click += new System.EventHandler(this.comboBoxSystem_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.Location = new System.Drawing.Point(989, 313);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(198, 28);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "Create";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(989, 362);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(198, 28);
            this.buttonDelete.TabIndex = 20;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEdit.Location = new System.Drawing.Point(989, 407);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(198, 28);
            this.buttonEdit.TabIndex = 21;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // checkBoxRGB
            // 
            this.checkBoxRGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRGB.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxRGB.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBoxRGB.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxRGB.Location = new System.Drawing.Point(1056, 501);
            this.checkBoxRGB.Name = "checkBoxRGB";
            this.checkBoxRGB.Size = new System.Drawing.Size(17, 29);
            this.checkBoxRGB.TabIndex = 22;
            this.checkBoxRGB.Text = " ";
            this.checkBoxRGB.UseVisualStyleBackColor = true;
            // 
            // labelID
            // 
            this.labelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelID.Location = new System.Drawing.Point(990, 542);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(31, 24);
            this.labelID.TabIndex = 23;
            this.labelID.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxID.Location = new System.Drawing.Point(1056, 539);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(79, 27);
            this.textBoxID.TabIndex = 24;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxName.Location = new System.Drawing.Point(765, 315);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(191, 27);
            this.textBoxName.TabIndex = 25;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPrice.Location = new System.Drawing.Point(1056, 587);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(131, 27);
            this.textBoxPrice.TabIndex = 27;
            this.textBoxPrice.Text = "0";
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrice.Location = new System.Drawing.Point(989, 587);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(61, 24);
            this.labelPrice.TabIndex = 26;
            this.labelPrice.Text = "Price";
            // 
            // labelRGB
            // 
            this.labelRGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRGB.AutoSize = true;
            this.labelRGB.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRGB.Location = new System.Drawing.Point(990, 501);
            this.labelRGB.Name = "labelRGB";
            this.labelRGB.Size = new System.Drawing.Size(53, 24);
            this.labelRGB.TabIndex = 28;
            this.labelRGB.Text = "RGB";
            // 
            // pictureBoxSingleComputer
            // 
            this.pictureBoxSingleComputer.Image = global::ComputerComposerNsp.Properties.Resources.SingleComputer;
            this.pictureBoxSingleComputer.Location = new System.Drawing.Point(1003, 50);
            this.pictureBoxSingleComputer.Name = "pictureBoxSingleComputer";
            this.pictureBoxSingleComputer.Size = new System.Drawing.Size(184, 187);
            this.pictureBoxSingleComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSingleComputer.TabIndex = 36;
            this.pictureBoxSingleComputer.TabStop = false;
            this.pictureBoxSingleComputer.Visible = false;
            // 
            // pictureBoxSystem
            // 
            this.pictureBoxSystem.Image = global::ComputerComposerNsp.Properties.Resources.windows;
            this.pictureBoxSystem.Location = new System.Drawing.Point(1003, 50);
            this.pictureBoxSystem.Name = "pictureBoxSystem";
            this.pictureBoxSystem.Size = new System.Drawing.Size(184, 187);
            this.pictureBoxSystem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSystem.TabIndex = 35;
            this.pictureBoxSystem.TabStop = false;
            this.pictureBoxSystem.Visible = false;
            // 
            // pictureBoxPowerUnit
            // 
            this.pictureBoxPowerUnit.Image = global::ComputerComposerNsp.Properties.Resources.PSU;
            this.pictureBoxPowerUnit.Location = new System.Drawing.Point(1003, 50);
            this.pictureBoxPowerUnit.Name = "pictureBoxPowerUnit";
            this.pictureBoxPowerUnit.Size = new System.Drawing.Size(184, 187);
            this.pictureBoxPowerUnit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPowerUnit.TabIndex = 34;
            this.pictureBoxPowerUnit.TabStop = false;
            this.pictureBoxPowerUnit.Visible = false;
            // 
            // pictureBoxBox
            // 
            this.pictureBoxBox.Image = global::ComputerComposerNsp.Properties.Resources.box;
            this.pictureBoxBox.Location = new System.Drawing.Point(1003, 50);
            this.pictureBoxBox.Name = "pictureBoxBox";
            this.pictureBoxBox.Size = new System.Drawing.Size(184, 187);
            this.pictureBoxBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBox.TabIndex = 33;
            this.pictureBoxBox.TabStop = false;
            this.pictureBoxBox.Visible = false;
            // 
            // pictureBoxRam
            // 
            this.pictureBoxRam.Image = global::ComputerComposerNsp.Properties.Resources.ram;
            this.pictureBoxRam.Location = new System.Drawing.Point(1003, 50);
            this.pictureBoxRam.Name = "pictureBoxRam";
            this.pictureBoxRam.Size = new System.Drawing.Size(184, 187);
            this.pictureBoxRam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRam.TabIndex = 32;
            this.pictureBoxRam.TabStop = false;
            this.pictureBoxRam.Visible = false;
            // 
            // pictureBoxCPU
            // 
            this.pictureBoxCPU.Image = global::ComputerComposerNsp.Properties.Resources.CPU;
            this.pictureBoxCPU.Location = new System.Drawing.Point(1003, 50);
            this.pictureBoxCPU.Name = "pictureBoxCPU";
            this.pictureBoxCPU.Size = new System.Drawing.Size(184, 187);
            this.pictureBoxCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCPU.TabIndex = 31;
            this.pictureBoxCPU.TabStop = false;
            this.pictureBoxCPU.Visible = false;
            // 
            // pictureBoxGPU
            // 
            this.pictureBoxGPU.Image = global::ComputerComposerNsp.Properties.Resources.GPU;
            this.pictureBoxGPU.Location = new System.Drawing.Point(1003, 50);
            this.pictureBoxGPU.Name = "pictureBoxGPU";
            this.pictureBoxGPU.Size = new System.Drawing.Size(184, 187);
            this.pictureBoxGPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGPU.TabIndex = 30;
            this.pictureBoxGPU.TabStop = false;
            this.pictureBoxGPU.Visible = false;
            // 
            // pictureBoxElements
            // 
            this.pictureBoxElements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxElements.Location = new System.Drawing.Point(1003, 50);
            this.pictureBoxElements.Name = "pictureBoxElements";
            this.pictureBoxElements.Size = new System.Drawing.Size(184, 187);
            this.pictureBoxElements.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxElements.TabIndex = 29;
            this.pictureBoxElements.TabStop = false;
            this.pictureBoxElements.WaitOnLoad = true;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(638, 317);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(72, 24);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name";
            // 
            // labelCreateComputer
            // 
            this.labelCreateComputer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCreateComputer.AutoSize = true;
            this.labelCreateComputer.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCreateComputer.Location = new System.Drawing.Point(638, 267);
            this.labelCreateComputer.Name = "labelCreateComputer";
            this.labelCreateComputer.Size = new System.Drawing.Size(254, 25);
            this.labelCreateComputer.TabIndex = 5;
            this.labelCreateComputer.Text = "Assemble the computer";
            // 
            // labelHello
            // 
            this.labelHello.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHello.Location = new System.Drawing.Point(935, 13);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(62, 25);
            this.labelHello.TabIndex = 37;
            this.labelHello.Text = "Hello";
            // 
            // labelActualUser
            // 
            this.labelActualUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelActualUser.AutoSize = true;
            this.labelActualUser.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelActualUser.Location = new System.Drawing.Point(1003, 14);
            this.labelActualUser.Name = "labelActualUser";
            this.labelActualUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelActualUser.Size = new System.Drawing.Size(0, 24);
            this.labelActualUser.TabIndex = 38;
            this.labelActualUser.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1199, 636);
            this.Controls.Add(this.labelActualUser);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.pictureBoxSingleComputer);
            this.Controls.Add(this.pictureBoxSystem);
            this.Controls.Add(this.pictureBoxPowerUnit);
            this.Controls.Add(this.pictureBoxBox);
            this.Controls.Add(this.pictureBoxRam);
            this.Controls.Add(this.pictureBoxCPU);
            this.Controls.Add(this.pictureBoxGPU);
            this.Controls.Add(this.pictureBoxElements);
            this.Controls.Add(this.labelRGB);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.checkBoxRGB);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxSystem);
            this.Controls.Add(this.comboBoxPowerUnit);
            this.Controls.Add(this.comboBoxBox);
            this.Controls.Add(this.comboBoxRam);
            this.Controls.Add(this.labelSystem);
            this.Controls.Add(this.labelPowerUnit);
            this.Controls.Add(this.labelBox);
            this.Controls.Add(this.labelRam);
            this.Controls.Add(this.comboBoxProcessor);
            this.Controls.Add(this.labelProcessor);
            this.Controls.Add(this.comboBoxGraphics);
            this.Controls.Add(this.labelGraphics);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelCreateComputer);
            this.Controls.Add(this.labelAction);
            this.Controls.Add(this.dataGridViewParts);
            this.Controls.Add(this.labelComputers);
            this.Controls.Add(this.dataGridViewComputers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1215, 675);
            this.Name = "FormMain";
            this.Text = "Computer Composer";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComputers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSingleComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPowerUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxElements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewComputers;
        private System.Windows.Forms.Label labelComputers;
        private System.Windows.Forms.DataGridView dataGridViewParts;
        private System.Windows.Forms.Label labelAction;
        private System.Windows.Forms.Label labelGraphics;
        private System.Windows.Forms.ComboBox comboBoxGraphics;
        private System.Windows.Forms.Label labelProcessor;
        private System.Windows.Forms.ComboBox comboBoxProcessor;
        private System.Windows.Forms.Label labelRam;
        private System.Windows.Forms.Label labelBox;
        private System.Windows.Forms.Label labelPowerUnit;
        private System.Windows.Forms.Label labelSystem;
        private System.Windows.Forms.ComboBox comboBoxRam;
        private System.Windows.Forms.ComboBox comboBoxBox;
        private System.Windows.Forms.ComboBox comboBoxPowerUnit;
        private System.Windows.Forms.ComboBox comboBoxSystem;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.CheckBox checkBoxRGB;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelRGB;
        private System.Windows.Forms.PictureBox pictureBoxElements;
        private System.Windows.Forms.PictureBox pictureBoxGPU;
        private System.Windows.Forms.PictureBox pictureBoxCPU;
        private System.Windows.Forms.PictureBox pictureBoxRam;
        private System.Windows.Forms.PictureBox pictureBoxBox;
        private System.Windows.Forms.PictureBox pictureBoxPowerUnit;
        private System.Windows.Forms.PictureBox pictureBoxSystem;
        private System.Windows.Forms.PictureBox pictureBoxSingleComputer;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCreateComputer;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Label labelActualUser;
    }
}

