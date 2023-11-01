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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle73 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle74 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle75 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle76 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tlpMode = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPagedMode = new System.Windows.Forms.TableLayoutPanel();
            this.btnFirstPageModes = new MaterialSkin.Controls.MaterialButton();
            this.btnLastPageModes = new MaterialSkin.Controls.MaterialButton();
            this.btnBackPageModes = new MaterialSkin.Controls.MaterialButton();
            this.btnNextPageModes = new MaterialSkin.Controls.MaterialButton();
            this.textBoxCurrentPageMode = new System.Windows.Forms.TextBox();
            this.cmbPageSizeModes = new System.Windows.Forms.ComboBox();
            this.pageModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tlpModesList = new System.Windows.Forms.TableLayoutPanel();
            this.listViewModes = new MaterialSkin.Controls.MaterialListView();
            this.columnIDModes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNameModes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMaxBottleNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMaxUsedTips = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageStep = new System.Windows.Forms.TabPage();
            this.tlpSteps = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPagedStep = new System.Windows.Forms.TableLayoutPanel();
            this.btnFirstPageSteps = new MaterialSkin.Controls.MaterialButton();
            this.btnLastPageSteps = new MaterialSkin.Controls.MaterialButton();
            this.btnBackPageSteps = new MaterialSkin.Controls.MaterialButton();
            this.btnNextPageSteps = new MaterialSkin.Controls.MaterialButton();
            this.textBoxCurrentPageStep = new System.Windows.Forms.TextBox();
            this.cmbPageSizeSteps = new System.Windows.Forms.ComboBox();
            this.tlpListStep = new System.Windows.Forms.TableLayoutPanel();
            this.listViewSteps = new MaterialSkin.Controls.MaterialListView();
            this.columnIDStep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnModeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTimer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDestination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVolume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnModeId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tlpModesButton.SuspendLayout();
            this.tlpStepsButton.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.materialTabControl.SuspendLayout();
            this.tabPageModes.SuspendLayout();
            this.tlpMode.SuspendLayout();
            this.tlpPagedMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.tlpModesList.SuspendLayout();
            this.tabPageStep.SuspendLayout();
            this.tlpSteps.SuspendLayout();
            this.tlpPagedStep.SuspendLayout();
            this.tlpListStep.SuspendLayout();
            this.SuspendLayout();
            // 
            // IdMode
            // 
            dataGridViewCellStyle73.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdMode.DefaultCellStyle = dataGridViewCellStyle73;
            this.IdMode.HeaderText = "    ID";
            this.IdMode.MinimumWidth = 30;
            this.IdMode.Name = "IdMode";
            this.IdMode.ReadOnly = true;
            this.IdMode.Width = 169;
            // 
            // NameMode
            // 
            dataGridViewCellStyle74.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NameMode.DefaultCellStyle = dataGridViewCellStyle74;
            this.NameMode.FillWeight = 120F;
            this.NameMode.HeaderText = "    Name";
            this.NameMode.MinimumWidth = 250;
            this.NameMode.Name = "NameMode";
            this.NameMode.ReadOnly = true;
            this.NameMode.Width = 250;
            // 
            // MaxBottleNumber
            // 
            dataGridViewCellStyle75.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaxBottleNumber.DefaultCellStyle = dataGridViewCellStyle75;
            this.MaxBottleNumber.FillWeight = 120F;
            this.MaxBottleNumber.HeaderText = "    MaxBottleNumber";
            this.MaxBottleNumber.MinimumWidth = 60;
            this.MaxBottleNumber.Name = "MaxBottleNumber";
            this.MaxBottleNumber.ReadOnly = true;
            this.MaxBottleNumber.Width = 203;
            // 
            // MaxUsedTips
            // 
            dataGridViewCellStyle76.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaxUsedTips.DefaultCellStyle = dataGridViewCellStyle76;
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
            this.tlpModesButton.Location = new System.Drawing.Point(641, 7);
            this.tlpModesButton.Margin = new System.Windows.Forms.Padding(1);
            this.tlpModesButton.MinimumSize = new System.Drawing.Size(110, 29);
            this.tlpModesButton.Name = "tlpModesButton";
            this.tlpModesButton.RowCount = 1;
            this.tlpModesButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpModesButton.Size = new System.Drawing.Size(110, 29);
            this.tlpModesButton.TabIndex = 2;
            this.toolTip.SetToolTip(this.tlpModesButton, "Edit item Mode");
            // 
            // btnDeleteMode
            // 
            this.btnDeleteMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteMode.AutoSize = true;
            this.btnDeleteMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteMode.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDeleteMode.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDeleteMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMode.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteMode.Image")));
            this.btnDeleteMode.Location = new System.Drawing.Point(72, 0);
            this.btnDeleteMode.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteMode.Name = "btnDeleteMode";
            this.btnDeleteMode.Size = new System.Drawing.Size(38, 29);
            this.btnDeleteMode.TabIndex = 7;
            this.toolTip.SetToolTip(this.btnDeleteMode, "Delete item Mode");
            this.btnDeleteMode.UseVisualStyleBackColor = false;
            this.btnDeleteMode.Click += new System.EventHandler(this.BtnDeleteMode_Click);
            // 
            // btnEditMode
            // 
            this.btnEditMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditMode.AutoSize = true;
            this.btnEditMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEditMode.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMode.Image = ((System.Drawing.Image)(resources.GetObject("btnEditMode.Image")));
            this.btnEditMode.Location = new System.Drawing.Point(36, 0);
            this.btnEditMode.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditMode.Name = "btnEditMode";
            this.btnEditMode.Size = new System.Drawing.Size(36, 29);
            this.btnEditMode.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnEditMode, "Edit item Mode");
            this.btnEditMode.UseVisualStyleBackColor = true;
            this.btnEditMode.Click += new System.EventHandler(this.BtnEditMode_Click);
            // 
            // btnAddMode
            // 
            this.btnAddMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMode.AutoSize = true;
            this.btnAddMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddMode.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAddMode.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMode.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMode.Image")));
            this.btnAddMode.Location = new System.Drawing.Point(0, 0);
            this.btnAddMode.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddMode.Name = "btnAddMode";
            this.btnAddMode.Size = new System.Drawing.Size(36, 29);
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
            this.tlpStepsButton.Location = new System.Drawing.Point(641, 7);
            this.tlpStepsButton.Margin = new System.Windows.Forms.Padding(1);
            this.tlpStepsButton.MinimumSize = new System.Drawing.Size(110, 29);
            this.tlpStepsButton.Name = "tlpStepsButton";
            this.tlpStepsButton.RowCount = 1;
            this.tlpStepsButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStepsButton.Size = new System.Drawing.Size(110, 29);
            this.tlpStepsButton.TabIndex = 1;
            // 
            // btnDeleteStep
            // 
            this.btnDeleteStep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteStep.AutoSize = true;
            this.btnDeleteStep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteStep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDeleteStep.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDeleteStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStep.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteStep.Image")));
            this.btnDeleteStep.Location = new System.Drawing.Point(72, 0);
            this.btnDeleteStep.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteStep.Name = "btnDeleteStep";
            this.btnDeleteStep.Size = new System.Drawing.Size(38, 29);
            this.btnDeleteStep.TabIndex = 7;
            this.toolTip.SetToolTip(this.btnDeleteStep, "Delete item Mode");
            this.btnDeleteStep.UseVisualStyleBackColor = true;
            this.btnDeleteStep.Click += new System.EventHandler(this.BtnDeleteStep_Click);
            // 
            // btnAddStep
            // 
            this.btnAddStep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddStep.AutoSize = true;
            this.btnAddStep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddStep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAddStep.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStep.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStep.Image")));
            this.btnAddStep.Location = new System.Drawing.Point(0, 0);
            this.btnAddStep.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddStep.Name = "btnAddStep";
            this.btnAddStep.Size = new System.Drawing.Size(36, 29);
            this.btnAddStep.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnAddStep, "Add item Mode");
            this.btnAddStep.UseVisualStyleBackColor = true;
            this.btnAddStep.Click += new System.EventHandler(this.BtnAddStep_Click);
            // 
            // btnEditStep
            // 
            this.btnEditStep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditStep.AutoSize = true;
            this.btnEditStep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditStep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEditStep.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStep.Image = ((System.Drawing.Image)(resources.GetObject("btnEditStep.Image")));
            this.btnEditStep.Location = new System.Drawing.Point(36, 0);
            this.btnEditStep.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditStep.Name = "btnEditStep";
            this.btnEditStep.Size = new System.Drawing.Size(36, 29);
            this.btnEditStep.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnEditStep, "Edit item Mode");
            this.btnEditStep.UseVisualStyleBackColor = true;
            this.btnEditStep.Click += new System.EventHandler(this.BtnEditStep_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Azure;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmItemFile});
            this.menuStrip.Location = new System.Drawing.Point(3, 24);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(774, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip";
            // 
            // tsmItemFile
            // 
            this.tsmItemFile.BackColor = System.Drawing.Color.Transparent;
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
            this.materialTabSelector.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.materialTabSelector.BaseTabControl = this.materialTabControl;
            this.materialTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector.Depth = 0;
            this.materialTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector.Location = new System.Drawing.Point(8, 51);
            this.materialTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector.Name = "materialTabSelector";
            this.materialTabSelector.Size = new System.Drawing.Size(762, 21);
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
            this.materialTabControl.Location = new System.Drawing.Point(8, 75);
            this.materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl.Multiline = true;
            this.materialTabControl.Name = "materialTabControl";
            this.materialTabControl.SelectedIndex = 0;
            this.materialTabControl.Size = new System.Drawing.Size(766, 357);
            this.materialTabControl.TabIndex = 5;
            // 
            // tabPageModes
            // 
            this.tabPageModes.Controls.Add(this.tlpMode);
            this.tabPageModes.Controls.Add(this.tlpModesList);
            this.tabPageModes.Location = new System.Drawing.Point(4, 22);
            this.tabPageModes.Name = "tabPageModes";
            this.tabPageModes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageModes.Size = new System.Drawing.Size(758, 331);
            this.tabPageModes.TabIndex = 0;
            this.tabPageModes.Text = "Modes";
            this.tabPageModes.UseVisualStyleBackColor = true;
            // 
            // tlpMode
            // 
            this.tlpMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMode.ColumnCount = 3;
            this.tlpMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMode.Controls.Add(this.tlpPagedMode, 1, 0);
            this.tlpMode.Controls.Add(this.tlpModesButton, 2, 0);
            this.tlpMode.Controls.Add(this.cmbPageSizeModes, 0, 0);
            this.tlpMode.Location = new System.Drawing.Point(3, 290);
            this.tlpMode.Name = "tlpMode";
            this.tlpMode.RowCount = 1;
            this.tlpMode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMode.Size = new System.Drawing.Size(752, 37);
            this.tlpMode.TabIndex = 9;
            // 
            // tlpPagedMode
            // 
            this.tlpPagedMode.ColumnCount = 5;
            this.tlpPagedMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlpPagedMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlpPagedMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpPagedMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlpPagedMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlpPagedMode.Controls.Add(this.btnFirstPageModes, 0, 0);
            this.tlpPagedMode.Controls.Add(this.btnLastPageModes, 4, 0);
            this.tlpPagedMode.Controls.Add(this.btnBackPageModes, 1, 0);
            this.tlpPagedMode.Controls.Add(this.btnNextPageModes, 3, 0);
            this.tlpPagedMode.Controls.Add(this.textBoxCurrentPageMode, 2, 0);
            this.tlpPagedMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPagedMode.Location = new System.Drawing.Point(253, 3);
            this.tlpPagedMode.Name = "tlpPagedMode";
            this.tlpPagedMode.RowCount = 1;
            this.tlpPagedMode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagedMode.Size = new System.Drawing.Size(244, 31);
            this.tlpPagedMode.TabIndex = 9;
            // 
            // btnFirstPageModes
            // 
            this.btnFirstPageModes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFirstPageModes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFirstPageModes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFirstPageModes.Depth = 0;
            this.btnFirstPageModes.HighEmphasis = true;
            this.btnFirstPageModes.Icon = null;
            this.btnFirstPageModes.Location = new System.Drawing.Point(4, 6);
            this.btnFirstPageModes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFirstPageModes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFirstPageModes.Name = "btnFirstPageModes";
            this.btnFirstPageModes.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFirstPageModes.Size = new System.Drawing.Size(43, 19);
            this.btnFirstPageModes.TabIndex = 0;
            this.btnFirstPageModes.Text = "<<";
            this.btnFirstPageModes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFirstPageModes.UseAccentColor = false;
            this.btnFirstPageModes.UseVisualStyleBackColor = true;
            this.btnFirstPageModes.Click += new System.EventHandler(this.BtnFirstPageModes_Click);
            // 
            // btnLastPageModes
            // 
            this.btnLastPageModes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLastPageModes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLastPageModes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLastPageModes.Depth = 0;
            this.btnLastPageModes.HighEmphasis = true;
            this.btnLastPageModes.Icon = null;
            this.btnLastPageModes.Location = new System.Drawing.Point(196, 6);
            this.btnLastPageModes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLastPageModes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLastPageModes.Name = "btnLastPageModes";
            this.btnLastPageModes.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLastPageModes.Size = new System.Drawing.Size(44, 19);
            this.btnLastPageModes.TabIndex = 1;
            this.btnLastPageModes.Text = ">>";
            this.btnLastPageModes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLastPageModes.UseAccentColor = false;
            this.btnLastPageModes.UseVisualStyleBackColor = true;
            this.btnLastPageModes.Click += new System.EventHandler(this.BtnLastPageModes_Click);
            // 
            // btnBackPageModes
            // 
            this.btnBackPageModes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBackPageModes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBackPageModes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBackPageModes.Depth = 0;
            this.btnBackPageModes.HighEmphasis = true;
            this.btnBackPageModes.Icon = null;
            this.btnBackPageModes.Location = new System.Drawing.Point(55, 6);
            this.btnBackPageModes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBackPageModes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBackPageModes.Name = "btnBackPageModes";
            this.btnBackPageModes.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBackPageModes.Size = new System.Drawing.Size(43, 19);
            this.btnBackPageModes.TabIndex = 2;
            this.btnBackPageModes.Text = "<";
            this.btnBackPageModes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBackPageModes.UseAccentColor = false;
            this.btnBackPageModes.UseVisualStyleBackColor = true;
            this.btnBackPageModes.Click += new System.EventHandler(this.BtnBackPageModes_Click);
            // 
            // btnNextPageModes
            // 
            this.btnNextPageModes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextPageModes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNextPageModes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNextPageModes.Depth = 0;
            this.btnNextPageModes.HighEmphasis = true;
            this.btnNextPageModes.Icon = null;
            this.btnNextPageModes.Location = new System.Drawing.Point(145, 6);
            this.btnNextPageModes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNextPageModes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNextPageModes.Name = "btnNextPageModes";
            this.btnNextPageModes.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNextPageModes.Size = new System.Drawing.Size(43, 19);
            this.btnNextPageModes.TabIndex = 3;
            this.btnNextPageModes.Text = ">";
            this.btnNextPageModes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNextPageModes.UseAccentColor = false;
            this.btnNextPageModes.UseVisualStyleBackColor = true;
            this.btnNextPageModes.Click += new System.EventHandler(this.BtnNextPageModes_Click);
            // 
            // textBoxCurrentPageMode
            // 
            this.textBoxCurrentPageMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCurrentPageMode.Location = new System.Drawing.Point(105, 5);
            this.textBoxCurrentPageMode.Name = "textBoxCurrentPageMode";
            this.textBoxCurrentPageMode.Size = new System.Drawing.Size(33, 20);
            this.textBoxCurrentPageMode.TabIndex = 4;
            this.textBoxCurrentPageMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCurrentPageMode.TextChanged += new System.EventHandler(this.TextBoxCurrentPageMode_TextChanged);
            // 
            // cmbPageSizeModes
            // 
            this.cmbPageSizeModes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbPageSizeModes.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pageModelBindingSource, "Size", true));
            this.cmbPageSizeModes.DataSource = this.itemsBindingSource;
            this.cmbPageSizeModes.FormattingEnabled = true;
            this.cmbPageSizeModes.Location = new System.Drawing.Point(3, 13);
            this.cmbPageSizeModes.Name = "cmbPageSizeModes";
            this.cmbPageSizeModes.Size = new System.Drawing.Size(121, 21);
            this.cmbPageSizeModes.TabIndex = 10;
            this.cmbPageSizeModes.SelectedIndexChanged += new System.EventHandler(this.CmbPageSizeModes_Changed);
            // 
            // pageModelBindingSource
            // 
            this.pageModelBindingSource.DataSource = typeof(TestTask.BindingItem.UserBinding.PageModel);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.pageModelBindingSource;
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
            this.tlpModesList.Size = new System.Drawing.Size(755, 290);
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
            this.listViewModes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewModes.FullRowSelect = true;
            this.listViewModes.HideSelection = false;
            this.listViewModes.Location = new System.Drawing.Point(3, 3);
            this.listViewModes.MinimumSize = new System.Drawing.Size(200, 100);
            this.listViewModes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewModes.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewModes.Name = "listViewModes";
            this.listViewModes.OwnerDraw = true;
            this.listViewModes.Size = new System.Drawing.Size(749, 284);
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
            this.tabPageStep.Controls.Add(this.tlpSteps);
            this.tabPageStep.Controls.Add(this.tlpListStep);
            this.tabPageStep.Location = new System.Drawing.Point(4, 22);
            this.tabPageStep.Name = "tabPageStep";
            this.tabPageStep.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStep.Size = new System.Drawing.Size(758, 331);
            this.tabPageStep.TabIndex = 1;
            this.tabPageStep.Text = "Steps";
            this.tabPageStep.UseVisualStyleBackColor = true;
            // 
            // tlpSteps
            // 
            this.tlpSteps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSteps.ColumnCount = 3;
            this.tlpSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSteps.Controls.Add(this.tlpPagedStep, 1, 0);
            this.tlpSteps.Controls.Add(this.tlpStepsButton, 2, 0);
            this.tlpSteps.Controls.Add(this.cmbPageSizeSteps, 0, 0);
            this.tlpSteps.Location = new System.Drawing.Point(3, 290);
            this.tlpSteps.Name = "tlpSteps";
            this.tlpSteps.RowCount = 1;
            this.tlpSteps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSteps.Size = new System.Drawing.Size(752, 37);
            this.tlpSteps.TabIndex = 8;
            // 
            // tlpPagedStep
            // 
            this.tlpPagedStep.ColumnCount = 5;
            this.tlpPagedStep.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlpPagedStep.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlpPagedStep.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpPagedStep.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlpPagedStep.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlpPagedStep.Controls.Add(this.btnFirstPageSteps, 0, 0);
            this.tlpPagedStep.Controls.Add(this.btnLastPageSteps, 4, 0);
            this.tlpPagedStep.Controls.Add(this.btnBackPageSteps, 1, 0);
            this.tlpPagedStep.Controls.Add(this.btnNextPageSteps, 3, 0);
            this.tlpPagedStep.Controls.Add(this.textBoxCurrentPageStep, 2, 0);
            this.tlpPagedStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPagedStep.Location = new System.Drawing.Point(253, 3);
            this.tlpPagedStep.Name = "tlpPagedStep";
            this.tlpPagedStep.RowCount = 1;
            this.tlpPagedStep.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagedStep.Size = new System.Drawing.Size(244, 31);
            this.tlpPagedStep.TabIndex = 9;
            // 
            // btnFirstPageSteps
            // 
            this.btnFirstPageSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFirstPageSteps.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFirstPageSteps.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFirstPageSteps.Depth = 0;
            this.btnFirstPageSteps.HighEmphasis = true;
            this.btnFirstPageSteps.Icon = null;
            this.btnFirstPageSteps.Location = new System.Drawing.Point(4, 6);
            this.btnFirstPageSteps.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFirstPageSteps.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFirstPageSteps.Name = "btnFirstPageSteps";
            this.btnFirstPageSteps.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFirstPageSteps.Size = new System.Drawing.Size(43, 19);
            this.btnFirstPageSteps.TabIndex = 0;
            this.btnFirstPageSteps.Text = "<<";
            this.btnFirstPageSteps.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFirstPageSteps.UseAccentColor = false;
            this.btnFirstPageSteps.UseVisualStyleBackColor = true;
            this.btnFirstPageSteps.Click += new System.EventHandler(this.BtnFirstPageSteps_Click);
            // 
            // btnLastPageSteps
            // 
            this.btnLastPageSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLastPageSteps.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLastPageSteps.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLastPageSteps.Depth = 0;
            this.btnLastPageSteps.HighEmphasis = true;
            this.btnLastPageSteps.Icon = null;
            this.btnLastPageSteps.Location = new System.Drawing.Point(196, 6);
            this.btnLastPageSteps.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLastPageSteps.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLastPageSteps.Name = "btnLastPageSteps";
            this.btnLastPageSteps.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLastPageSteps.Size = new System.Drawing.Size(44, 19);
            this.btnLastPageSteps.TabIndex = 1;
            this.btnLastPageSteps.Text = ">>";
            this.btnLastPageSteps.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLastPageSteps.UseAccentColor = false;
            this.btnLastPageSteps.UseVisualStyleBackColor = true;
            this.btnLastPageSteps.Click += new System.EventHandler(this.BtnLastPageSteps_Click);
            // 
            // btnBackPageSteps
            // 
            this.btnBackPageSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBackPageSteps.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBackPageSteps.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBackPageSteps.Depth = 0;
            this.btnBackPageSteps.HighEmphasis = true;
            this.btnBackPageSteps.Icon = null;
            this.btnBackPageSteps.Location = new System.Drawing.Point(55, 6);
            this.btnBackPageSteps.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBackPageSteps.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBackPageSteps.Name = "btnBackPageSteps";
            this.btnBackPageSteps.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBackPageSteps.Size = new System.Drawing.Size(43, 19);
            this.btnBackPageSteps.TabIndex = 2;
            this.btnBackPageSteps.Text = "<";
            this.btnBackPageSteps.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBackPageSteps.UseAccentColor = false;
            this.btnBackPageSteps.UseVisualStyleBackColor = true;
            this.btnBackPageSteps.Click += new System.EventHandler(this.BtnBackPageSteps_Click);
            // 
            // btnNextPageSteps
            // 
            this.btnNextPageSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextPageSteps.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNextPageSteps.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNextPageSteps.Depth = 0;
            this.btnNextPageSteps.HighEmphasis = true;
            this.btnNextPageSteps.Icon = null;
            this.btnNextPageSteps.Location = new System.Drawing.Point(145, 6);
            this.btnNextPageSteps.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNextPageSteps.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNextPageSteps.Name = "btnNextPageSteps";
            this.btnNextPageSteps.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNextPageSteps.Size = new System.Drawing.Size(43, 19);
            this.btnNextPageSteps.TabIndex = 3;
            this.btnNextPageSteps.Text = ">";
            this.btnNextPageSteps.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNextPageSteps.UseAccentColor = false;
            this.btnNextPageSteps.UseVisualStyleBackColor = true;
            this.btnNextPageSteps.Click += new System.EventHandler(this.BtnNextPageSteps_Click);
            // 
            // textBoxCurrentPageStep
            // 
            this.textBoxCurrentPageStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCurrentPageStep.Location = new System.Drawing.Point(105, 5);
            this.textBoxCurrentPageStep.Name = "textBoxCurrentPageStep";
            this.textBoxCurrentPageStep.Size = new System.Drawing.Size(33, 20);
            this.textBoxCurrentPageStep.TabIndex = 4;
            this.textBoxCurrentPageStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCurrentPageStep.TextChanged += new System.EventHandler(this.TextBoxCurrentPageStep_TextChanged);
            // 
            // cmbPageSizeSteps
            // 
            this.cmbPageSizeSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbPageSizeSteps.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pageModelBindingSource, "Size", true));
            this.cmbPageSizeSteps.DataSource = this.itemsBindingSource;
            this.cmbPageSizeSteps.FormattingEnabled = true;
            this.cmbPageSizeSteps.Location = new System.Drawing.Point(3, 13);
            this.cmbPageSizeSteps.Name = "cmbPageSizeSteps";
            this.cmbPageSizeSteps.Size = new System.Drawing.Size(121, 21);
            this.cmbPageSizeSteps.TabIndex = 10;
            this.cmbPageSizeSteps.SelectedIndexChanged += new System.EventHandler(this.CmbPageSizeSteps_Changed);
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
            this.tlpListStep.Size = new System.Drawing.Size(755, 290);
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
            this.columnModeName,
            this.columnTimer,
            this.columnDestination,
            this.columnSpeed,
            this.columnType,
            this.columnVolume,
            this.columnModeId});
            this.listViewSteps.Depth = 0;
            this.listViewSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSteps.FullRowSelect = true;
            this.listViewSteps.HideSelection = false;
            this.listViewSteps.Location = new System.Drawing.Point(3, 3);
            this.listViewSteps.MinimumSize = new System.Drawing.Size(200, 100);
            this.listViewSteps.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewSteps.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewSteps.Name = "listViewSteps";
            this.listViewSteps.OwnerDraw = true;
            this.listViewSteps.Size = new System.Drawing.Size(749, 284);
            this.listViewSteps.TabIndex = 5;
            this.listViewSteps.UseCompatibleStateImageBehavior = false;
            this.listViewSteps.View = System.Windows.Forms.View.Details;
            // 
            // columnIDStep
            // 
            this.columnIDStep.Text = "ID";
            this.columnIDStep.Width = 50;
            // 
            // columnModeName
            // 
            this.columnModeName.Text = "ModeName";
            this.columnModeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnModeName.Width = 110;
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
            this.columnType.Width = 140;
            // 
            // columnVolume
            // 
            this.columnVolume.Text = "Volume";
            this.columnVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnVolume.Width = 90;
            // 
            // columnModeId
            // 
            this.columnModeId.Text = "ModeId";
            this.columnModeId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnModeId.Width = 0;
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 435);
            this.Controls.Add(this.materialTabSelector);
            this.Controls.Add(this.materialTabControl);
            this.Controls.Add(this.menuStrip);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TableForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.tlpMode.ResumeLayout(false);
            this.tlpPagedMode.ResumeLayout(false);
            this.tlpPagedMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.tlpModesList.ResumeLayout(false);
            this.tabPageStep.ResumeLayout(false);
            this.tlpSteps.ResumeLayout(false);
            this.tlpPagedStep.ResumeLayout(false);
            this.tlpPagedStep.PerformLayout();
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
        private System.Windows.Forms.ColumnHeader columnModeName;
        private System.Windows.Forms.ColumnHeader columnTimer;
        private System.Windows.Forms.ColumnHeader columnDestination;
        private System.Windows.Forms.ColumnHeader columnSpeed;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnVolume;
        private System.Windows.Forms.TableLayoutPanel tlpSteps;
        private System.Windows.Forms.TableLayoutPanel tlpPagedStep;
        private MaterialSkin.Controls.MaterialButton btnFirstPageSteps;
        private MaterialSkin.Controls.MaterialButton btnLastPageSteps;
        private MaterialSkin.Controls.MaterialButton btnBackPageSteps;
        private MaterialSkin.Controls.MaterialButton btnNextPageSteps;
        private System.Windows.Forms.TextBox textBoxCurrentPageStep;
        private System.Windows.Forms.ComboBox cmbPageSizeSteps;
        private System.Windows.Forms.BindingSource pageModelBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.TableLayoutPanel tlpMode;
        private System.Windows.Forms.TableLayoutPanel tlpPagedMode;
        private MaterialSkin.Controls.MaterialButton btnFirstPageModes;
        private MaterialSkin.Controls.MaterialButton btnLastPageModes;
        private MaterialSkin.Controls.MaterialButton btnBackPageModes;
        private MaterialSkin.Controls.MaterialButton btnNextPageModes;
        private System.Windows.Forms.TextBox textBoxCurrentPageMode;
        private System.Windows.Forms.ComboBox cmbPageSizeModes;
        private System.Windows.Forms.ColumnHeader columnModeId;
    }
}