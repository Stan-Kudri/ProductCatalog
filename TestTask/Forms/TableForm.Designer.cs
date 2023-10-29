using System.Drawing;

namespace TestTask.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle89 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle90 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle91 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle92 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableForm));
            this.IdMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxBottleNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxUsedTips = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpModesButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteMode = new System.Windows.Forms.Button();
            this.btnEditMode = new System.Windows.Forms.Button();
            this.btnAddMode = new System.Windows.Forms.Button();
            this.tlpStepsButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteStep = new System.Windows.Forms.Button();
            this.btnAddStep = new System.Windows.Forms.Button();
            this.btnEditStep = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmImportFromExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaveToExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.materialTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageModes = new System.Windows.Forms.TabPage();
            this.tlpModesList = new System.Windows.Forms.TableLayoutPanel();
            this.listViewModes = new MaterialSkin.Controls.MaterialListView();
            this.columnIDModes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNameModes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMaxBottleNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMaxUsedTips = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageStep = new System.Windows.Forms.TabPage();
            this.tlpListStep = new System.Windows.Forms.TableLayoutPanel();
            this.listViewSteps = new MaterialSkin.Controls.MaterialListView();
            this.columnIDStep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnModeId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTimer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDestination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVolume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tlpModesButton.SuspendLayout();
            this.tlpStepsButton.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.materialTabControl.SuspendLayout();
            this.tabPageModes.SuspendLayout();
            this.tlpModesList.SuspendLayout();
            this.tabPageStep.SuspendLayout();
            this.tlpListStep.SuspendLayout();
            this.SuspendLayout();
            // 
            // IdMode
            // 
            dataGridViewCellStyle89.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdMode.DefaultCellStyle = dataGridViewCellStyle89;
            this.IdMode.HeaderText = "    ID";
            this.IdMode.MinimumWidth = 30;
            this.IdMode.Name = "IdMode";
            this.IdMode.ReadOnly = true;
            this.IdMode.Width = 169;
            // 
            // NameMode
            // 
            dataGridViewCellStyle90.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NameMode.DefaultCellStyle = dataGridViewCellStyle90;
            this.NameMode.FillWeight = 120F;
            this.NameMode.HeaderText = "    Name";
            this.NameMode.MinimumWidth = 250;
            this.NameMode.Name = "NameMode";
            this.NameMode.ReadOnly = true;
            this.NameMode.Width = 250;
            // 
            // MaxBottleNumber
            // 
            dataGridViewCellStyle91.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaxBottleNumber.DefaultCellStyle = dataGridViewCellStyle91;
            this.MaxBottleNumber.FillWeight = 120F;
            this.MaxBottleNumber.HeaderText = "    MaxBottleNumber";
            this.MaxBottleNumber.MinimumWidth = 60;
            this.MaxBottleNumber.Name = "MaxBottleNumber";
            this.MaxBottleNumber.ReadOnly = true;
            this.MaxBottleNumber.Width = 203;
            // 
            // MaxUsedTips
            // 
            dataGridViewCellStyle92.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaxUsedTips.DefaultCellStyle = dataGridViewCellStyle92;
            this.MaxUsedTips.HeaderText = "    MaxUsedTips";
            this.MaxUsedTips.MinimumWidth = 40;
            this.MaxUsedTips.Name = "MaxUsedTips";
            this.MaxUsedTips.ReadOnly = true;
            this.MaxUsedTips.Width = 169;
            // 
            // tlpModesButton
            // 
            this.tlpModesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpModesButton.ColumnCount = 3;
            this.tlpModesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpModesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpModesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpModesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpModesButton.Controls.Add(this.btnDeleteMode, 2, 0);
            this.tlpModesButton.Controls.Add(this.btnEditMode, 1, 0);
            this.tlpModesButton.Controls.Add(this.btnAddMode, 0, 0);
            this.tlpModesButton.ForeColor = System.Drawing.Color.Transparent;
            this.tlpModesButton.Location = new System.Drawing.Point(648, 309);
            this.tlpModesButton.Margin = new System.Windows.Forms.Padding(1);
            this.tlpModesButton.MinimumSize = new System.Drawing.Size(95, 29);
            this.tlpModesButton.Name = "tlpModesButton";
            this.tlpModesButton.RowCount = 1;
            this.tlpModesButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpModesButton.Size = new System.Drawing.Size(95, 29);
            this.tlpModesButton.TabIndex = 2;
            this.toolTip.SetToolTip(this.tlpModesButton, "Edit item Mode");
            // 
            // btnDeleteMode
            // 
            this.btnDeleteMode.AutoSize = true;
            this.btnDeleteMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteMode.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDeleteMode.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDeleteMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMode.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteMode.Image")));
            this.btnDeleteMode.Location = new System.Drawing.Point(62, 0);
            this.btnDeleteMode.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteMode.Name = "btnDeleteMode";
            this.btnDeleteMode.Size = new System.Drawing.Size(33, 29);
            this.btnDeleteMode.TabIndex = 7;
            this.toolTip.SetToolTip(this.btnDeleteMode, "Delete item Mode");
            this.btnDeleteMode.UseVisualStyleBackColor = false;
            this.btnDeleteMode.Click += new System.EventHandler(this.BtnDeleteMode_Click);
            // 
            // btnEditMode
            // 
            this.btnEditMode.AutoSize = true;
            this.btnEditMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEditMode.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMode.Image = ((System.Drawing.Image)(resources.GetObject("btnEditMode.Image")));
            this.btnEditMode.Location = new System.Drawing.Point(31, 0);
            this.btnEditMode.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditMode.Name = "btnEditMode";
            this.btnEditMode.Size = new System.Drawing.Size(31, 29);
            this.btnEditMode.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnEditMode, "Edit item Mode");
            this.btnEditMode.UseVisualStyleBackColor = true;
            this.btnEditMode.Click += new System.EventHandler(this.BtnEditMode_Click);
            // 
            // btnAddMode
            // 
            this.btnAddMode.AutoSize = true;
            this.btnAddMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddMode.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAddMode.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMode.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMode.Image")));
            this.btnAddMode.Location = new System.Drawing.Point(0, 0);
            this.btnAddMode.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddMode.Name = "btnAddMode";
            this.btnAddMode.Size = new System.Drawing.Size(31, 29);
            this.btnAddMode.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnAddMode, "Add item Mode");
            this.btnAddMode.UseVisualStyleBackColor = false;
            this.btnAddMode.Click += new System.EventHandler(this.BtnAddMode_Click);
            // 
            // tlpStepsButton
            // 
            this.tlpStepsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpStepsButton.ColumnCount = 3;
            this.tlpStepsButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpStepsButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpStepsButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpStepsButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpStepsButton.Controls.Add(this.btnDeleteStep, 2, 0);
            this.tlpStepsButton.Controls.Add(this.btnAddStep, 0, 0);
            this.tlpStepsButton.Controls.Add(this.btnEditStep, 1, 0);
            this.tlpStepsButton.ForeColor = System.Drawing.Color.Transparent;
            this.tlpStepsButton.Location = new System.Drawing.Point(648, 309);
            this.tlpStepsButton.Margin = new System.Windows.Forms.Padding(1);
            this.tlpStepsButton.MinimumSize = new System.Drawing.Size(95, 29);
            this.tlpStepsButton.Name = "tlpStepsButton";
            this.tlpStepsButton.RowCount = 1;
            this.tlpStepsButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStepsButton.Size = new System.Drawing.Size(95, 29);
            this.tlpStepsButton.TabIndex = 1;
            // 
            // btnDeleteStep
            // 
            this.btnDeleteStep.AutoSize = true;
            this.btnDeleteStep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteStep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDeleteStep.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDeleteStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStep.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteStep.Image")));
            this.btnDeleteStep.Location = new System.Drawing.Point(62, 0);
            this.btnDeleteStep.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteStep.Name = "btnDeleteStep";
            this.btnDeleteStep.Size = new System.Drawing.Size(33, 29);
            this.btnDeleteStep.TabIndex = 7;
            this.toolTip.SetToolTip(this.btnDeleteStep, "Delete item Mode");
            this.btnDeleteStep.UseVisualStyleBackColor = true;
            this.btnDeleteStep.Click += new System.EventHandler(this.BtnDeleteStep_Click);
            // 
            // btnAddStep
            // 
            this.btnAddStep.AutoSize = true;
            this.btnAddStep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddStep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAddStep.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStep.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStep.Image")));
            this.btnAddStep.Location = new System.Drawing.Point(0, 0);
            this.btnAddStep.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddStep.Name = "btnAddStep";
            this.btnAddStep.Size = new System.Drawing.Size(31, 29);
            this.btnAddStep.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnAddStep, "Add item Mode");
            this.btnAddStep.UseVisualStyleBackColor = true;
            this.btnAddStep.Click += new System.EventHandler(this.BtnAddStep_Click);
            // 
            // btnEditStep
            // 
            this.btnEditStep.AutoSize = true;
            this.btnEditStep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditStep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEditStep.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStep.Image = ((System.Drawing.Image)(resources.GetObject("btnEditStep.Image")));
            this.btnEditStep.Location = new System.Drawing.Point(31, 0);
            this.btnEditStep.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditStep.Name = "btnEditStep";
            this.btnEditStep.Size = new System.Drawing.Size(31, 29);
            this.btnEditStep.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnEditStep, "Edit item Mode");
            this.btnEditStep.UseVisualStyleBackColor = true;
            this.btnEditStep.Click += new System.EventHandler(this.BtnEditStep_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmItemFile});
            this.menuStrip.Location = new System.Drawing.Point(3, 64);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(774, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip";
            // 
            // tsmItemFile
            // 
            this.tsmItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmItemImport,
            this.tsmItemExport,
            this.tsmItemClose});
            this.tsmItemFile.Name = "tsmItemFile";
            this.tsmItemFile.Size = new System.Drawing.Size(37, 20);
            this.tsmItemFile.Text = "File";
            // 
            // tsmItemImport
            // 
            this.tsmItemImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmImportFromExcel});
            this.tsmItemImport.Name = "tsmItemImport";
            this.tsmItemImport.Size = new System.Drawing.Size(139, 22);
            this.tsmItemImport.Text = "Import from";
            // 
            // tsmImportFromExcel
            // 
            this.tsmImportFromExcel.Name = "tsmImportFromExcel";
            this.tsmImportFromExcel.Size = new System.Drawing.Size(101, 22);
            this.tsmImportFromExcel.Text = "Excel";
            this.tsmImportFromExcel.Click += new System.EventHandler(this.TsmImportFromExcel_Click);
            // 
            // tsmItemExport
            // 
            this.tsmItemExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSaveToExcel});
            this.tsmItemExport.Name = "tsmItemExport";
            this.tsmItemExport.Size = new System.Drawing.Size(139, 22);
            this.tsmItemExport.Text = "Export to";
            // 
            // tsmSaveToExcel
            // 
            this.tsmSaveToExcel.Name = "tsmSaveToExcel";
            this.tsmSaveToExcel.Size = new System.Drawing.Size(101, 22);
            this.tsmSaveToExcel.Text = "Excel";
            this.tsmSaveToExcel.Click += new System.EventHandler(this.TsmItemSaveExcel_Click);
            // 
            // tsmItemClose
            // 
            this.tsmItemClose.Name = "tsmItemClose";
            this.tsmItemClose.Size = new System.Drawing.Size(139, 22);
            this.tsmItemClose.Text = "Close";
            this.tsmItemClose.Click += new System.EventHandler(this.TsmItemClose_Click);
            // 
            // materialTabSelector
            // 
            this.materialTabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector.BaseTabControl = this.materialTabControl;
            this.materialTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector.Depth = 0;
            this.materialTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector.Location = new System.Drawing.Point(5, 90);
            this.materialTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector.Name = "materialTabSelector";
            this.materialTabSelector.Size = new System.Drawing.Size(770, 48);
            this.materialTabSelector.TabIndex = 6;
            this.materialTabSelector.Text = "TabSelector";
            // 
            // materialTabControl
            // 
            this.materialTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl.Controls.Add(this.tabPageModes);
            this.materialTabControl.Controls.Add(this.tabPageStep);
            this.materialTabControl.Depth = 0;
            this.materialTabControl.Location = new System.Drawing.Point(8, 144);
            this.materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl.Multiline = true;
            this.materialTabControl.Name = "materialTabControl";
            this.materialTabControl.SelectedIndex = 0;
            this.materialTabControl.Size = new System.Drawing.Size(766, 370);
            this.materialTabControl.TabIndex = 5;
            // 
            // tabPageModes
            // 
            this.tabPageModes.Controls.Add(this.tlpModesList);
            this.tabPageModes.Controls.Add(this.tlpModesButton);
            this.tabPageModes.Location = new System.Drawing.Point(4, 22);
            this.tabPageModes.Name = "tabPageModes";
            this.tabPageModes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageModes.Size = new System.Drawing.Size(758, 344);
            this.tabPageModes.TabIndex = 0;
            this.tabPageModes.Text = "Modes";
            this.tabPageModes.UseVisualStyleBackColor = true;
            // 
            // tlpModesList
            // 
            this.tlpModesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpModesList.ColumnCount = 1;
            this.tlpModesList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpModesList.Controls.Add(this.listViewModes, 0, 0);
            this.tlpModesList.Location = new System.Drawing.Point(0, 0);
            this.tlpModesList.Name = "tlpModesList";
            this.tlpModesList.RowCount = 1;
            this.tlpModesList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpModesList.Size = new System.Drawing.Size(755, 305);
            this.tlpModesList.TabIndex = 6;
            // 
            // listViewModes
            // 
            this.listViewModes.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listViewModes.AutoSizeTable = false;
            this.listViewModes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewModes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewModes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIDModes,
            this.columnNameModes,
            this.columnMaxBottleNumber,
            this.columnMaxUsedTips});
            this.listViewModes.Depth = 0;
            this.listViewModes.FullRowSelect = true;
            this.listViewModes.HideSelection = false;
            this.listViewModes.Location = new System.Drawing.Point(3, 3);
            this.listViewModes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewModes.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewModes.Name = "listViewModes";
            this.listViewModes.OwnerDraw = true;
            this.listViewModes.Size = new System.Drawing.Size(740, 299);
            this.listViewModes.TabIndex = 5;
            this.listViewModes.UseCompatibleStateImageBehavior = false;
            this.listViewModes.View = System.Windows.Forms.View.Details;
            // 
            // columnIDModes
            // 
            this.columnIDModes.Text = "ID";
            this.columnIDModes.Width = 80;
            // 
            // columnNameModes
            // 
            this.columnNameModes.Text = "Name";
            this.columnNameModes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnNameModes.Width = 300;
            // 
            // columnMaxBottleNumber
            // 
            this.columnMaxBottleNumber.Text = "MaxBottleNumber";
            this.columnMaxBottleNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnMaxBottleNumber.Width = 180;
            // 
            // columnMaxUsedTips
            // 
            this.columnMaxUsedTips.Text = "MaxUsedTips";
            this.columnMaxUsedTips.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnMaxUsedTips.Width = 180;
            // 
            // tabPageStep
            // 
            this.tabPageStep.Controls.Add(this.tlpListStep);
            this.tabPageStep.Controls.Add(this.tlpStepsButton);
            this.tabPageStep.Location = new System.Drawing.Point(4, 22);
            this.tabPageStep.Name = "tabPageStep";
            this.tabPageStep.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStep.Size = new System.Drawing.Size(758, 344);
            this.tabPageStep.TabIndex = 1;
            this.tabPageStep.Text = "Steps";
            this.tabPageStep.UseVisualStyleBackColor = true;
            // 
            // tlpListStep
            // 
            this.tlpListStep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpListStep.ColumnCount = 1;
            this.tlpListStep.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpListStep.Controls.Add(this.listViewSteps, 0, 0);
            this.tlpListStep.Location = new System.Drawing.Point(0, 0);
            this.tlpListStep.Name = "tlpListStep";
            this.tlpListStep.RowCount = 1;
            this.tlpListStep.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpListStep.Size = new System.Drawing.Size(755, 305);
            this.tlpListStep.TabIndex = 7;
            // 
            // listViewSteps
            // 
            this.listViewSteps.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listViewSteps.AutoSizeTable = false;
            this.listViewSteps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewSteps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewSteps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIDStep,
            this.columnModeId,
            this.columnTimer,
            this.columnDestination,
            this.columnSpeed,
            this.columnType,
            this.columnVolume});
            this.listViewSteps.Depth = 0;
            this.listViewSteps.FullRowSelect = true;
            this.listViewSteps.HideSelection = false;
            this.listViewSteps.Location = new System.Drawing.Point(3, 3);
            this.listViewSteps.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewSteps.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewSteps.Name = "listViewSteps";
            this.listViewSteps.OwnerDraw = true;
            this.listViewSteps.Size = new System.Drawing.Size(740, 295);
            this.listViewSteps.TabIndex = 5;
            this.listViewSteps.UseCompatibleStateImageBehavior = false;
            this.listViewSteps.View = System.Windows.Forms.View.Details;
            // 
            // columnIDStep
            // 
            this.columnIDStep.Text = "ID";
            this.columnIDStep.Width = 50;
            // 
            // columnModeId
            // 
            this.columnModeId.Text = "ModeId";
            this.columnModeId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnModeId.Width = 100;
            // 
            // columnTimer
            // 
            this.columnTimer.Text = "Timer";
            this.columnTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTimer.Width = 90;
            // 
            // columnDestination
            // 
            this.columnDestination.Text = "Destination";
            this.columnDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDestination.Width = 150;
            // 
            // columnSpeed
            // 
            this.columnSpeed.Text = "Speed";
            this.columnSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSpeed.Width = 90;
            // 
            // columnType
            // 
            this.columnType.Text = "Type";
            this.columnType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnType.Width = 150;
            // 
            // columnVolume
            // 
            this.columnVolume.Text = "Volume";
            this.columnVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnVolume.Width = 90;
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 520);
            this.Controls.Add(this.materialTabSelector);
            this.Controls.Add(this.materialTabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TableForm";
            this.Text = "Table";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TableForm_FormClosing);
            this.Load += new System.EventHandler(this.TableForm_Load);
            this.tlpModesButton.ResumeLayout(false);
            this.tlpModesButton.PerformLayout();
            this.tlpStepsButton.ResumeLayout(false);
            this.tlpStepsButton.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.materialTabControl.ResumeLayout(false);
            this.tabPageModes.ResumeLayout(false);
            this.tlpModesList.ResumeLayout(false);
            this.tabPageStep.ResumeLayout(false);
            this.tlpListStep.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpStepsButton;
        private System.Windows.Forms.TableLayoutPanel tlpModesButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmItemFile;
        private System.Windows.Forms.ToolStripMenuItem tsmItemImport;
        private System.Windows.Forms.ToolStripMenuItem tsmItemClose;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnAddMode;
        private System.Windows.Forms.Button btnEditMode;
        private System.Windows.Forms.Button btnDeleteMode;
        private System.Windows.Forms.Button btnDeleteStep;
        private System.Windows.Forms.Button btnAddStep;
        private System.Windows.Forms.Button btnEditStep;
        private System.Windows.Forms.ToolStripMenuItem tsmItemExport;
        private System.Windows.Forms.ToolStripMenuItem tsmImportFromExcel;
        private System.Windows.Forms.ToolStripMenuItem tsmSaveToExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxBottleNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxUsedTips;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private System.Windows.Forms.TabPage tabPageModes;
        private System.Windows.Forms.TabPage tabPageStep;
        private MaterialSkin.Controls.MaterialListView listViewModes;
        private System.Windows.Forms.ColumnHeader columnIDModes;
        private System.Windows.Forms.ColumnHeader columnNameModes;
        private System.Windows.Forms.ColumnHeader columnMaxBottleNumber;
        private System.Windows.Forms.ColumnHeader columnMaxUsedTips;
        private System.Windows.Forms.TableLayoutPanel tlpModesList;
        private System.Windows.Forms.TableLayoutPanel tlpListStep;
        private MaterialSkin.Controls.MaterialListView listViewSteps;
        private System.Windows.Forms.ColumnHeader columnIDStep;
        private System.Windows.Forms.ColumnHeader columnModeId;
        private System.Windows.Forms.ColumnHeader columnTimer;
        private System.Windows.Forms.ColumnHeader columnDestination;
        private System.Windows.Forms.ColumnHeader columnSpeed;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnVolume;
    }
}