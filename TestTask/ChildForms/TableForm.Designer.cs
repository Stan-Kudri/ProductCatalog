namespace TestTask.ChildForms
{
    partial class TableForm
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
            this.tcData = new System.Windows.Forms.TabControl();
            this.tabPageModes = new System.Windows.Forms.TabPage();
            this.dgvModes = new System.Windows.Forms.DataGridView();
            this.IdMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxBottleNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxUsedTips = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpModesButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteMode = new FontAwesome.Sharp.IconPictureBox();
            this.btnEditMode = new FontAwesome.Sharp.IconPictureBox();
            this.btnAddMode = new FontAwesome.Sharp.IconPictureBox();
            this.tabPageSteps = new System.Windows.Forms.TabPage();
            this.tlpStepsButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteStep = new FontAwesome.Sharp.IconPictureBox();
            this.btnAddStep = new FontAwesome.Sharp.IconPictureBox();
            this.btnEditStep = new FontAwesome.Sharp.IconPictureBox();
            this.dgvSteps = new System.Windows.Forms.DataGridView();
            this.IdStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpTabControl = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemImportFromExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tcData.SuspendLayout();
            this.tabPageModes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModes)).BeginInit();
            this.tlpModesButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddMode)).BeginInit();
            this.tabPageSteps.SuspendLayout();
            this.tlpStepsButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSteps)).BeginInit();
            this.tlpTabControl.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcData
            // 
            this.tcData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcData.Controls.Add(this.tabPageModes);
            this.tcData.Controls.Add(this.tabPageSteps);
            this.tcData.Location = new System.Drawing.Point(3, 3);
            this.tcData.Name = "tcData";
            this.tcData.SelectedIndex = 0;
            this.tcData.Size = new System.Drawing.Size(774, 464);
            this.tcData.TabIndex = 0;
            // 
            // tabPageModes
            // 
            this.tabPageModes.Controls.Add(this.dgvModes);
            this.tabPageModes.Controls.Add(this.tlpModesButton);
            this.tabPageModes.Location = new System.Drawing.Point(4, 22);
            this.tabPageModes.Name = "tabPageModes";
            this.tabPageModes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageModes.Size = new System.Drawing.Size(766, 438);
            this.tabPageModes.TabIndex = 0;
            this.tabPageModes.Text = "Modes";
            this.tabPageModes.UseVisualStyleBackColor = true;
            // 
            // dgvModes
            // 
            this.dgvModes.AllowUserToAddRows = false;
            this.dgvModes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvModes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMode,
            this.NameMode,
            this.MaxBottleNumber,
            this.MaxUsedTips});
            this.dgvModes.Location = new System.Drawing.Point(3, 3);
            this.dgvModes.MinimumSize = new System.Drawing.Size(760, 360);
            this.dgvModes.Name = "dgvModes";
            this.dgvModes.Size = new System.Drawing.Size(760, 360);
            this.dgvModes.TabIndex = 4;
            // 
            // IdMode
            // 
            this.IdMode.HeaderText = "ID";
            this.IdMode.MinimumWidth = 30;
            this.IdMode.Name = "IdMode";
            this.IdMode.ReadOnly = true;
            // 
            // NameMode
            // 
            this.NameMode.HeaderText = "Name";
            this.NameMode.MinimumWidth = 280;
            this.NameMode.Name = "NameMode";
            this.NameMode.ReadOnly = true;
            // 
            // MaxBottleNumber
            // 
            this.MaxBottleNumber.HeaderText = "MaxBottleNumber";
            this.MaxBottleNumber.MinimumWidth = 40;
            this.MaxBottleNumber.Name = "MaxBottleNumber";
            this.MaxBottleNumber.ReadOnly = true;
            // 
            // MaxUsedTips
            // 
            this.MaxUsedTips.HeaderText = "MaxUsedTips";
            this.MaxUsedTips.MinimumWidth = 40;
            this.MaxUsedTips.Name = "MaxUsedTips";
            this.MaxUsedTips.ReadOnly = true;
            // 
            // tlpModesButton
            // 
            this.tlpModesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tlpModesButton.ColumnCount = 3;
            this.tlpModesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpModesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpModesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpModesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpModesButton.Controls.Add(this.btnDeleteMode, 2, 0);
            this.tlpModesButton.Controls.Add(this.btnEditMode, 1, 0);
            this.tlpModesButton.Controls.Add(this.btnAddMode, 0, 0);
            this.tlpModesButton.Location = new System.Drawing.Point(3, 365);
            this.tlpModesButton.MinimumSize = new System.Drawing.Size(210, 75);
            this.tlpModesButton.Name = "tlpModesButton";
            this.tlpModesButton.RowCount = 1;
            this.tlpModesButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpModesButton.Size = new System.Drawing.Size(210, 75);
            this.tlpModesButton.TabIndex = 2;
            this.toolTip.SetToolTip(this.tlpModesButton, "Edit item Mode");
            // 
            // btnDeleteMode
            // 
            this.btnDeleteMode.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteMode.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteMode.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.btnDeleteMode.IconColor = System.Drawing.Color.Red;
            this.btnDeleteMode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteMode.IconSize = 64;
            this.btnDeleteMode.Location = new System.Drawing.Point(143, 3);
            this.btnDeleteMode.Name = "btnDeleteMode";
            this.btnDeleteMode.Size = new System.Drawing.Size(64, 69);
            this.btnDeleteMode.TabIndex = 5;
            this.btnDeleteMode.TabStop = false;
            this.toolTip.SetToolTip(this.btnDeleteMode, "Delete item Mode");
            this.btnDeleteMode.Click += new System.EventHandler(this.BtnDeleteMode_Click);
            // 
            // btnEditMode
            // 
            this.btnEditMode.BackColor = System.Drawing.Color.Transparent;
            this.btnEditMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditMode.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnEditMode.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnEditMode.IconColor = System.Drawing.Color.Goldenrod;
            this.btnEditMode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditMode.IconSize = 64;
            this.btnEditMode.Location = new System.Drawing.Point(73, 3);
            this.btnEditMode.Name = "btnEditMode";
            this.btnEditMode.Size = new System.Drawing.Size(64, 69);
            this.btnEditMode.TabIndex = 6;
            this.btnEditMode.TabStop = false;
            this.toolTip.SetToolTip(this.btnEditMode, "Edit item Mode");
            this.btnEditMode.Click += new System.EventHandler(this.BtnEditMode_Click);
            // 
            // btnAddMode
            // 
            this.btnAddMode.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddMode.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddMode.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddMode.IconColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddMode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddMode.IconSize = 64;
            this.btnAddMode.Location = new System.Drawing.Point(3, 3);
            this.btnAddMode.Name = "btnAddMode";
            this.btnAddMode.Size = new System.Drawing.Size(64, 69);
            this.btnAddMode.TabIndex = 5;
            this.btnAddMode.TabStop = false;
            this.toolTip.SetToolTip(this.btnAddMode, "Add item Mode");
            this.btnAddMode.Click += new System.EventHandler(this.BtnAddMode_Click);
            // 
            // tabPageSteps
            // 
            this.tabPageSteps.Controls.Add(this.tlpStepsButton);
            this.tabPageSteps.Controls.Add(this.dgvSteps);
            this.tabPageSteps.Location = new System.Drawing.Point(4, 22);
            this.tabPageSteps.Name = "tabPageSteps";
            this.tabPageSteps.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSteps.Size = new System.Drawing.Size(766, 438);
            this.tabPageSteps.TabIndex = 1;
            this.tabPageSteps.Text = "Steps";
            this.tabPageSteps.UseVisualStyleBackColor = true;
            // 
            // tlpStepsButton
            // 
            this.tlpStepsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tlpStepsButton.ColumnCount = 3;
            this.tlpStepsButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpStepsButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpStepsButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpStepsButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpStepsButton.Controls.Add(this.btnDeleteStep, 2, 0);
            this.tlpStepsButton.Controls.Add(this.btnAddStep, 0, 0);
            this.tlpStepsButton.Controls.Add(this.btnEditStep, 1, 0);
            this.tlpStepsButton.Location = new System.Drawing.Point(3, 365);
            this.tlpStepsButton.MinimumSize = new System.Drawing.Size(210, 75);
            this.tlpStepsButton.Name = "tlpStepsButton";
            this.tlpStepsButton.RowCount = 1;
            this.tlpStepsButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStepsButton.Size = new System.Drawing.Size(210, 75);
            this.tlpStepsButton.TabIndex = 1;
            // 
            // btnDeleteStep
            // 
            this.btnDeleteStep.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteStep.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteStep.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.btnDeleteStep.IconColor = System.Drawing.Color.Red;
            this.btnDeleteStep.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteStep.IconSize = 64;
            this.btnDeleteStep.Location = new System.Drawing.Point(143, 3);
            this.btnDeleteStep.Name = "btnDeleteStep";
            this.btnDeleteStep.Size = new System.Drawing.Size(64, 69);
            this.btnDeleteStep.TabIndex = 5;
            this.btnDeleteStep.TabStop = false;
            this.toolTip.SetToolTip(this.btnDeleteStep, "Delete item Step");
            this.btnDeleteStep.Click += new System.EventHandler(this.BtnDeleteStep_Click);
            // 
            // btnAddStep
            // 
            this.btnAddStep.BackColor = System.Drawing.Color.Transparent;
            this.btnAddStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddStep.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddStep.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddStep.IconColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddStep.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddStep.IconSize = 64;
            this.btnAddStep.Location = new System.Drawing.Point(3, 3);
            this.btnAddStep.Name = "btnAddStep";
            this.btnAddStep.Size = new System.Drawing.Size(64, 69);
            this.btnAddStep.TabIndex = 5;
            this.btnAddStep.TabStop = false;
            this.toolTip.SetToolTip(this.btnAddStep, "Add item Step");
            this.btnAddStep.Click += new System.EventHandler(this.BtnAddStep_Click);
            // 
            // btnEditStep
            // 
            this.btnEditStep.BackColor = System.Drawing.Color.Transparent;
            this.btnEditStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditStep.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnEditStep.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnEditStep.IconColor = System.Drawing.Color.Goldenrod;
            this.btnEditStep.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditStep.IconSize = 64;
            this.btnEditStep.Location = new System.Drawing.Point(73, 3);
            this.btnEditStep.Name = "btnEditStep";
            this.btnEditStep.Size = new System.Drawing.Size(64, 69);
            this.btnEditStep.TabIndex = 6;
            this.btnEditStep.TabStop = false;
            this.toolTip.SetToolTip(this.btnEditStep, "Edit item Step");
            this.btnEditStep.Click += new System.EventHandler(this.BtnEditStep_Click_1);
            // 
            // dgvSteps
            // 
            this.dgvSteps.AllowUserToAddRows = false;
            this.dgvSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSteps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSteps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdStep,
            this.ModeId,
            this.Timer,
            this.Destination,
            this.Speed,
            this.Type,
            this.Volume});
            this.dgvSteps.Location = new System.Drawing.Point(3, 3);
            this.dgvSteps.MinimumSize = new System.Drawing.Size(760, 360);
            this.dgvSteps.Name = "dgvSteps";
            this.dgvSteps.Size = new System.Drawing.Size(760, 360);
            this.dgvSteps.TabIndex = 0;
            // 
            // IdStep
            // 
            this.IdStep.FillWeight = 50F;
            this.IdStep.HeaderText = "ID";
            this.IdStep.MinimumWidth = 30;
            this.IdStep.Name = "IdStep";
            this.IdStep.ReadOnly = true;
            // 
            // ModeId
            // 
            this.ModeId.FillWeight = 40F;
            this.ModeId.HeaderText = "ModeId";
            this.ModeId.MinimumWidth = 30;
            this.ModeId.Name = "ModeId";
            this.ModeId.ReadOnly = true;
            // 
            // Timer
            // 
            this.Timer.FillWeight = 80F;
            this.Timer.HeaderText = "Timer";
            this.Timer.MinimumWidth = 70;
            this.Timer.Name = "Timer";
            this.Timer.ReadOnly = true;
            // 
            // Destination
            // 
            this.Destination.FillWeight = 200F;
            this.Destination.HeaderText = "Destination";
            this.Destination.MinimumWidth = 160;
            this.Destination.Name = "Destination";
            this.Destination.ReadOnly = true;
            // 
            // Speed
            // 
            this.Speed.FillWeight = 9.885016F;
            this.Speed.HeaderText = "Speed";
            this.Speed.MinimumWidth = 80;
            this.Speed.Name = "Speed";
            this.Speed.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 120;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Volume
            // 
            this.Volume.FillWeight = 90F;
            this.Volume.HeaderText = "Volume";
            this.Volume.MinimumWidth = 70;
            this.Volume.Name = "Volume";
            this.Volume.ReadOnly = true;
            // 
            // tlpTabControl
            // 
            this.tlpTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTabControl.ColumnCount = 1;
            this.tlpTabControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTabControl.Controls.Add(this.tcData, 0, 0);
            this.tlpTabControl.Location = new System.Drawing.Point(2, 20);
            this.tlpTabControl.MinimumSize = new System.Drawing.Size(780, 430);
            this.tlpTabControl.Name = "tlpTabControl";
            this.tlpTabControl.RowCount = 1;
            this.tlpTabControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTabControl.Size = new System.Drawing.Size(780, 470);
            this.tlpTabControl.TabIndex = 2;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmItemFile});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip";
            // 
            // tsmItemFile
            // 
            this.tsmItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmItemImportFromExcel,
            this.tsmItemClose});
            this.tsmItemFile.Name = "tsmItemFile";
            this.tsmItemFile.Size = new System.Drawing.Size(37, 20);
            this.tsmItemFile.Text = "File";
            // 
            // tsmItemImportFromExcel
            // 
            this.tsmItemImportFromExcel.Name = "tsmItemImportFromExcel";
            this.tsmItemImportFromExcel.Size = new System.Drawing.Size(169, 22);
            this.tsmItemImportFromExcel.Text = "Import from Excel";
            this.tsmItemImportFromExcel.Click += new System.EventHandler(this.TsmItemImportFromExcel_Click);
            // 
            // tsmItemClose
            // 
            this.tsmItemClose.Name = "tsmItemClose";
            this.tsmItemClose.Size = new System.Drawing.Size(169, 22);
            this.tsmItemClose.Text = "Close";
            this.tsmItemClose.Click += new System.EventHandler(this.TsmItemClose_Click);
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 491);
            this.Controls.Add(this.tlpTabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 530);
            this.Name = "TableForm";
            this.Text = "Table";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TableForm_FormClosing);
            this.Load += new System.EventHandler(this.TableForm_Load);
            this.tcData.ResumeLayout(false);
            this.tabPageModes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModes)).EndInit();
            this.tlpModesButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddMode)).EndInit();
            this.tabPageSteps.ResumeLayout(false);
            this.tlpStepsButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSteps)).EndInit();
            this.tlpTabControl.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcData;
        private System.Windows.Forms.TabPage tabPageModes;
        private System.Windows.Forms.TabPage tabPageSteps;
        private System.Windows.Forms.DataGridView dgvSteps;
        private System.Windows.Forms.TableLayoutPanel tlpStepsButton;
        private System.Windows.Forms.TableLayoutPanel tlpTabControl;
        private System.Windows.Forms.TableLayoutPanel tlpModesButton;
        private System.Windows.Forms.DataGridView dgvModes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxBottleNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxUsedTips;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmItemFile;
        private System.Windows.Forms.ToolStripMenuItem tsmItemImportFromExcel;
        private System.Windows.Forms.ToolStripMenuItem tsmItemClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
        private FontAwesome.Sharp.IconPictureBox btnAddMode;
        private FontAwesome.Sharp.IconPictureBox btnDeleteMode;
        private FontAwesome.Sharp.IconPictureBox btnEditMode;
        private System.Windows.Forms.ToolTip toolTip;
        private FontAwesome.Sharp.IconPictureBox btnDeleteStep;
        private FontAwesome.Sharp.IconPictureBox btnEditStep;
        private FontAwesome.Sharp.IconPictureBox btnAddStep;
    }
}