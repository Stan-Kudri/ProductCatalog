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
            this.tcData = new System.Windows.Forms.TabControl();
            this.tabPageModes = new System.Windows.Forms.TabPage();
            this.dgvModes = new System.Windows.Forms.DataGridView();
            this.IdMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxBottleNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxUsedTips = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpModesButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddMode = new MaterialSkin.Controls.MaterialButton();
            this.btnEditMode = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteMode = new MaterialSkin.Controls.MaterialButton();
            this.tabPageSteps = new System.Windows.Forms.TabPage();
            this.tlpStepsButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddItemStep = new MaterialSkin.Controls.MaterialButton();
            this.btnEditStep = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteStep = new MaterialSkin.Controls.MaterialButton();
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
            this.tcData.SuspendLayout();
            this.tabPageModes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModes)).BeginInit();
            this.tlpModesButton.SuspendLayout();
            this.tabPageSteps.SuspendLayout();
            this.tlpStepsButton.SuspendLayout();
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
            this.tcData.Size = new System.Drawing.Size(774, 424);
            this.tcData.TabIndex = 0;
            // 
            // tabPageModes
            // 
            this.tabPageModes.Controls.Add(this.dgvModes);
            this.tabPageModes.Controls.Add(this.tlpModesButton);
            this.tabPageModes.Location = new System.Drawing.Point(4, 22);
            this.tabPageModes.Name = "tabPageModes";
            this.tabPageModes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageModes.Size = new System.Drawing.Size(766, 398);
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
            this.tlpModesButton.Controls.Add(this.btnAddMode, 0, 0);
            this.tlpModesButton.Controls.Add(this.btnEditMode, 1, 0);
            this.tlpModesButton.Controls.Add(this.btnDeleteMode, 2, 0);
            this.tlpModesButton.Location = new System.Drawing.Point(3, 370);
            this.tlpModesButton.MinimumSize = new System.Drawing.Size(760, 25);
            this.tlpModesButton.Name = "tlpModesButton";
            this.tlpModesButton.RowCount = 1;
            this.tlpModesButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpModesButton.Size = new System.Drawing.Size(760, 25);
            this.tlpModesButton.TabIndex = 2;
            // 
            // btnAddMode
            // 
            this.btnAddMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddMode.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddMode.Depth = 0;
            this.btnAddMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddMode.HighEmphasis = true;
            this.btnAddMode.Icon = null;
            this.btnAddMode.Location = new System.Drawing.Point(10, 3);
            this.btnAddMode.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnAddMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddMode.Name = "btnAddMode";
            this.btnAddMode.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddMode.Size = new System.Drawing.Size(233, 19);
            this.btnAddMode.TabIndex = 0;
            this.btnAddMode.Text = "Add";
            this.btnAddMode.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddMode.UseAccentColor = false;
            this.btnAddMode.UseVisualStyleBackColor = true;
            this.btnAddMode.Click += new System.EventHandler(this.BtnAddMode_Click);
            // 
            // btnEditMode
            // 
            this.btnEditMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditMode.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditMode.Depth = 0;
            this.btnEditMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditMode.HighEmphasis = true;
            this.btnEditMode.Icon = null;
            this.btnEditMode.Location = new System.Drawing.Point(263, 3);
            this.btnEditMode.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnEditMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditMode.Name = "btnEditMode";
            this.btnEditMode.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditMode.Size = new System.Drawing.Size(233, 19);
            this.btnEditMode.TabIndex = 1;
            this.btnEditMode.Text = "Edit";
            this.btnEditMode.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditMode.UseAccentColor = false;
            this.btnEditMode.UseVisualStyleBackColor = true;
            this.btnEditMode.Click += new System.EventHandler(this.BtnEditMode_Click);
            // 
            // btnDeleteMode
            // 
            this.btnDeleteMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteMode.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteMode.Depth = 0;
            this.btnDeleteMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteMode.HighEmphasis = true;
            this.btnDeleteMode.Icon = null;
            this.btnDeleteMode.Location = new System.Drawing.Point(516, 3);
            this.btnDeleteMode.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnDeleteMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteMode.Name = "btnDeleteMode";
            this.btnDeleteMode.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteMode.Size = new System.Drawing.Size(234, 19);
            this.btnDeleteMode.TabIndex = 2;
            this.btnDeleteMode.Text = "Delete";
            this.btnDeleteMode.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteMode.UseAccentColor = false;
            this.btnDeleteMode.UseVisualStyleBackColor = true;
            this.btnDeleteMode.Click += new System.EventHandler(this.BtnDeliteMode_Click);
            // 
            // tabPageSteps
            // 
            this.tabPageSteps.Controls.Add(this.tlpStepsButton);
            this.tabPageSteps.Controls.Add(this.dgvSteps);
            this.tabPageSteps.Location = new System.Drawing.Point(4, 22);
            this.tabPageSteps.Name = "tabPageSteps";
            this.tabPageSteps.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSteps.Size = new System.Drawing.Size(766, 398);
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
            this.tlpStepsButton.Controls.Add(this.btnAddItemStep, 0, 0);
            this.tlpStepsButton.Controls.Add(this.btnEditStep, 1, 0);
            this.tlpStepsButton.Controls.Add(this.btnDeleteStep, 2, 0);
            this.tlpStepsButton.Location = new System.Drawing.Point(3, 370);
            this.tlpStepsButton.MinimumSize = new System.Drawing.Size(760, 25);
            this.tlpStepsButton.Name = "tlpStepsButton";
            this.tlpStepsButton.RowCount = 1;
            this.tlpStepsButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStepsButton.Size = new System.Drawing.Size(760, 25);
            this.tlpStepsButton.TabIndex = 1;
            // 
            // btnAddItemStep
            // 
            this.btnAddItemStep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddItemStep.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddItemStep.Depth = 0;
            this.btnAddItemStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddItemStep.HighEmphasis = true;
            this.btnAddItemStep.Icon = null;
            this.btnAddItemStep.Location = new System.Drawing.Point(10, 3);
            this.btnAddItemStep.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnAddItemStep.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddItemStep.Name = "btnAddItemStep";
            this.btnAddItemStep.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddItemStep.Size = new System.Drawing.Size(233, 19);
            this.btnAddItemStep.TabIndex = 0;
            this.btnAddItemStep.Text = "Add";
            this.btnAddItemStep.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddItemStep.UseAccentColor = false;
            this.btnAddItemStep.UseVisualStyleBackColor = true;
            this.btnAddItemStep.Click += new System.EventHandler(this.BtnAddItemStep_Click);
            // 
            // btnEditStep
            // 
            this.btnEditStep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditStep.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditStep.Depth = 0;
            this.btnEditStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditStep.HighEmphasis = true;
            this.btnEditStep.Icon = null;
            this.btnEditStep.Location = new System.Drawing.Point(263, 3);
            this.btnEditStep.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnEditStep.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditStep.Name = "btnEditStep";
            this.btnEditStep.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditStep.Size = new System.Drawing.Size(233, 19);
            this.btnEditStep.TabIndex = 1;
            this.btnEditStep.Text = "Edit";
            this.btnEditStep.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditStep.UseAccentColor = false;
            this.btnEditStep.UseVisualStyleBackColor = true;
            this.btnEditStep.Click += new System.EventHandler(this.BtnEditStep_Click);
            // 
            // btnDeleteStep
            // 
            this.btnDeleteStep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteStep.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteStep.Depth = 0;
            this.btnDeleteStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteStep.HighEmphasis = true;
            this.btnDeleteStep.Icon = null;
            this.btnDeleteStep.Location = new System.Drawing.Point(516, 3);
            this.btnDeleteStep.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnDeleteStep.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteStep.Name = "btnDeleteStep";
            this.btnDeleteStep.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteStep.Size = new System.Drawing.Size(234, 19);
            this.btnDeleteStep.TabIndex = 2;
            this.btnDeleteStep.Text = "Delete";
            this.btnDeleteStep.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteStep.UseAccentColor = false;
            this.btnDeleteStep.UseVisualStyleBackColor = true;
            this.btnDeleteStep.Click += new System.EventHandler(this.BtnDeliteStep_Click);
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
            this.IdStep.FillWeight = 134.3092F;
            this.IdStep.HeaderText = "ID";
            this.IdStep.MinimumWidth = 30;
            this.IdStep.Name = "IdStep";
            this.IdStep.ReadOnly = true;
            // 
            // ModeId
            // 
            this.ModeId.HeaderText = "ModeId";
            this.ModeId.Name = "ModeId";
            this.ModeId.ReadOnly = true;
            // 
            // Timer
            // 
            this.Timer.FillWeight = 9.885016F;
            this.Timer.HeaderText = "Timer";
            this.Timer.MinimumWidth = 100;
            this.Timer.Name = "Timer";
            this.Timer.ReadOnly = true;
            // 
            // Destination
            // 
            this.Destination.FillWeight = 244.5199F;
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
            this.Type.FillWeight = 9.885016F;
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 80;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Volume
            // 
            this.Volume.FillWeight = 22.61278F;
            this.Volume.HeaderText = "Volume";
            this.Volume.MinimumWidth = 100;
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
            this.tlpTabControl.Size = new System.Drawing.Size(780, 430);
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
            this.ClientSize = new System.Drawing.Size(784, 451);
            this.Controls.Add(this.tlpTabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 490);
            this.Name = "TableForm";
            this.Text = "TableForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TableForm_FormClosing);
            this.Load += new System.EventHandler(this.TableForm_Load);
            this.tcData.ResumeLayout(false);
            this.tabPageModes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModes)).EndInit();
            this.tlpModesButton.ResumeLayout(false);
            this.tlpModesButton.PerformLayout();
            this.tabPageSteps.ResumeLayout(false);
            this.tlpStepsButton.ResumeLayout(false);
            this.tlpStepsButton.PerformLayout();
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
        private MaterialSkin.Controls.MaterialButton btnAddItemStep;
        private MaterialSkin.Controls.MaterialButton btnEditStep;
        private MaterialSkin.Controls.MaterialButton btnDeleteStep;
        private System.Windows.Forms.TableLayoutPanel tlpModesButton;
        private MaterialSkin.Controls.MaterialButton btnAddMode;
        private MaterialSkin.Controls.MaterialButton btnEditMode;
        private MaterialSkin.Controls.MaterialButton btnDeleteMode;
        private System.Windows.Forms.DataGridView dgvModes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxBottleNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxUsedTips;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmItemFile;
        private System.Windows.Forms.ToolStripMenuItem tsmItemImportFromExcel;
        private System.Windows.Forms.ToolStripMenuItem tsmItemClose;
    }
}