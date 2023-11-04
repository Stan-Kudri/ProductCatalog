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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableForm));
            this.IdCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxBottleNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxUsedTips = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpCompaniesButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteCompany = new System.Windows.Forms.Button();
            this.btnEditCompany = new System.Windows.Forms.Button();
            this.btnAddCompany = new System.Windows.Forms.Button();
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
            this.tabPageCompany = new System.Windows.Forms.TabPage();
            this.tlpCompany = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPagedCompanies = new System.Windows.Forms.TableLayoutPanel();
            this.btnFirstPageCompanies = new MaterialSkin.Controls.MaterialButton();
            this.btnLastPageCompanies = new MaterialSkin.Controls.MaterialButton();
            this.btnBackPageCompanies = new MaterialSkin.Controls.MaterialButton();
            this.btnNextPageCompanies = new MaterialSkin.Controls.MaterialButton();
            this.textBoxCurrentPageCompanies = new System.Windows.Forms.TextBox();
            this.cmbPageSizeCompanies = new System.Windows.Forms.ComboBox();
            this.pageModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tlpCompanyList = new System.Windows.Forms.TableLayoutPanel();
            this.listViewCompanies = new MaterialSkin.Controls.MaterialListView();
            this.columnIDCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNameCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDateCreation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.tlpCompaniesButton.SuspendLayout();
            this.tlpStepsButton.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.materialTabControl.SuspendLayout();
            this.tabPageCompany.SuspendLayout();
            this.tlpCompany.SuspendLayout();
            this.tlpPagedCompanies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.tlpCompanyList.SuspendLayout();
            this.tabPageStep.SuspendLayout();
            this.tlpSteps.SuspendLayout();
            this.tlpPagedStep.SuspendLayout();
            this.tlpListStep.SuspendLayout();
            this.SuspendLayout();
            // 
            // IdMode
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdCompany.DefaultCellStyle = dataGridViewCellStyle1;
            this.IdCompany.HeaderText = "    ID";
            this.IdCompany.MinimumWidth = 30;
            this.IdCompany.Name = "IdMode";
            this.IdCompany.ReadOnly = true;
            this.IdCompany.Width = 169;
            // 
            // NameMode
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NameCompany.DefaultCellStyle = dataGridViewCellStyle2;
            this.NameCompany.FillWeight = 120F;
            this.NameCompany.HeaderText = "    Name";
            this.NameCompany.MinimumWidth = 250;
            this.NameCompany.Name = "NameMode";
            this.NameCompany.ReadOnly = true;
            this.NameCompany.Width = 250;
            // 
            // MaxBottleNumber
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaxBottleNumber.DefaultCellStyle = dataGridViewCellStyle3;
            this.MaxBottleNumber.FillWeight = 120F;
            this.MaxBottleNumber.HeaderText = "    MaxBottleNumber";
            this.MaxBottleNumber.MinimumWidth = 60;
            this.MaxBottleNumber.Name = "MaxBottleNumber";
            this.MaxBottleNumber.ReadOnly = true;
            this.MaxBottleNumber.Width = 203;
            // 
            // MaxUsedTips
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaxUsedTips.DefaultCellStyle = dataGridViewCellStyle4;
            this.MaxUsedTips.HeaderText = "    MaxUsedTips";
            this.MaxUsedTips.MinimumWidth = 40;
            this.MaxUsedTips.Name = "MaxUsedTips";
            this.MaxUsedTips.ReadOnly = true;
            this.MaxUsedTips.Width = 169;
            // 
            // tlpCompaniesButton
            // 
            this.tlpCompaniesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCompaniesButton.ColumnCount = 3;
            this.tlpCompaniesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCompaniesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCompaniesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCompaniesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCompaniesButton.Controls.Add(this.btnDeleteCompany, 2, 0);
            this.tlpCompaniesButton.Controls.Add(this.btnEditCompany, 1, 0);
            this.tlpCompaniesButton.Controls.Add(this.btnAddCompany, 0, 0);
            this.tlpCompaniesButton.ForeColor = System.Drawing.Color.Transparent;
            this.tlpCompaniesButton.Location = new System.Drawing.Point(641, 7);
            this.tlpCompaniesButton.Margin = new System.Windows.Forms.Padding(1);
            this.tlpCompaniesButton.MinimumSize = new System.Drawing.Size(110, 29);
            this.tlpCompaniesButton.Name = "tlpCompanyButton";
            this.tlpCompaniesButton.RowCount = 1;
            this.tlpCompaniesButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCompaniesButton.Size = new System.Drawing.Size(110, 29);
            this.tlpCompaniesButton.TabIndex = 2;
            this.toolTip.SetToolTip(this.tlpCompaniesButton, "Edit item Company");
            // 
            // btnDeleteCompany
            // 
            this.btnDeleteCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCompany.AutoSize = true;
            this.btnDeleteCompany.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteCompany.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCompany.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDeleteCompany.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDeleteCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCompany.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCompany.Image")));
            this.btnDeleteCompany.Location = new System.Drawing.Point(72, 0);
            this.btnDeleteCompany.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteCompany.Name = "btnDeleteCompany";
            this.btnDeleteCompany.Size = new System.Drawing.Size(38, 29);
            this.btnDeleteCompany.TabIndex = 7;
            this.toolTip.SetToolTip(this.btnDeleteCompany, "Delete company");
            this.btnDeleteCompany.UseVisualStyleBackColor = false;
            this.btnDeleteCompany.Click += new System.EventHandler(this.BtnDeleteCompany_Click);
            // 
            // btnEditCompany
            // 
            this.btnEditCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCompany.AutoSize = true;
            this.btnEditCompany.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditCompany.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEditCompany.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCompany.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCompany.Image")));
            this.btnEditCompany.Location = new System.Drawing.Point(36, 0);
            this.btnEditCompany.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditCompany.Name = "btnEditCompany";
            this.btnEditCompany.Size = new System.Drawing.Size(36, 29);
            this.btnEditCompany.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnEditCompany, "Edit company");
            this.btnEditCompany.UseVisualStyleBackColor = true;
            this.btnEditCompany.Click += new System.EventHandler(this.BtnEditCompany_Click);
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCompany.AutoSize = true;
            this.btnAddCompany.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddCompany.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCompany.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAddCompany.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCompany.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCompany.Image")));
            this.btnAddCompany.Location = new System.Drawing.Point(0, 0);
            this.btnAddCompany.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(36, 29);
            this.btnAddCompany.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnAddCompany, "Add company");
            this.btnAddCompany.UseVisualStyleBackColor = false;
            this.btnAddCompany.Click += new System.EventHandler(this.BtnAddCompany_Click);
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
            this.toolTip.SetToolTip(this.btnDeleteStep, "Delete item Step");
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
            this.toolTip.SetToolTip(this.btnAddStep, "Add item Step");
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
            this.toolTip.SetToolTip(this.btnEditStep, "Edit item Step");
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
            this.materialTabControl.Controls.Add(this.tabPageCompany);
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
            // tabPageCompany
            // 
            this.tabPageCompany.Controls.Add(this.tlpCompany);
            this.tabPageCompany.Controls.Add(this.tlpCompanyList);
            this.tabPageCompany.Location = new System.Drawing.Point(4, 22);
            this.tabPageCompany.Name = "tabPageCompany";
            this.tabPageCompany.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompany.Size = new System.Drawing.Size(758, 331);
            this.tabPageCompany.TabIndex = 0;
            this.tabPageCompany.Text = "Modes";
            this.tabPageCompany.UseVisualStyleBackColor = true;
            // 
            // tlpCompany
            // 
            this.tlpCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCompany.ColumnCount = 3;
            this.tlpCompany.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCompany.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCompany.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCompany.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCompany.Controls.Add(this.tlpPagedCompanies, 1, 0);
            this.tlpCompany.Controls.Add(this.tlpCompaniesButton, 2, 0);
            this.tlpCompany.Controls.Add(this.cmbPageSizeCompanies, 0, 0);
            this.tlpCompany.Location = new System.Drawing.Point(3, 290);
            this.tlpCompany.Name = "tlpCompany";
            this.tlpCompany.RowCount = 1;
            this.tlpCompany.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCompany.Size = new System.Drawing.Size(752, 37);
            this.tlpCompany.TabIndex = 9;
            // 
            // tlpPagedCompanies
            // 
            this.tlpPagedCompanies.ColumnCount = 5;
            this.tlpPagedCompanies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlpPagedCompanies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlpPagedCompanies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpPagedCompanies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlpPagedCompanies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlpPagedCompanies.Controls.Add(this.btnFirstPageCompanies, 0, 0);
            this.tlpPagedCompanies.Controls.Add(this.btnLastPageCompanies, 4, 0);
            this.tlpPagedCompanies.Controls.Add(this.btnBackPageCompanies, 1, 0);
            this.tlpPagedCompanies.Controls.Add(this.btnNextPageCompanies, 3, 0);
            this.tlpPagedCompanies.Controls.Add(this.textBoxCurrentPageCompanies, 2, 0);
            this.tlpPagedCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPagedCompanies.Location = new System.Drawing.Point(253, 3);
            this.tlpPagedCompanies.Name = "tlpPagedCompanies";
            this.tlpPagedCompanies.RowCount = 1;
            this.tlpPagedCompanies.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagedCompanies.Size = new System.Drawing.Size(244, 31);
            this.tlpPagedCompanies.TabIndex = 9;
            // 
            // btnFirstPageCompanies
            // 
            this.btnFirstPageCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFirstPageCompanies.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFirstPageCompanies.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFirstPageCompanies.Depth = 0;
            this.btnFirstPageCompanies.HighEmphasis = true;
            this.btnFirstPageCompanies.Icon = null;
            this.btnFirstPageCompanies.Location = new System.Drawing.Point(4, 6);
            this.btnFirstPageCompanies.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFirstPageCompanies.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFirstPageCompanies.Name = "btnFirstPageCompanies";
            this.btnFirstPageCompanies.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFirstPageCompanies.Size = new System.Drawing.Size(43, 19);
            this.btnFirstPageCompanies.TabIndex = 0;
            this.btnFirstPageCompanies.Text = "<<";
            this.btnFirstPageCompanies.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFirstPageCompanies.UseAccentColor = false;
            this.btnFirstPageCompanies.UseVisualStyleBackColor = true;
            this.btnFirstPageCompanies.Click += new System.EventHandler(this.BtnFirstPageModes_Click);
            // 
            // btnLastPageCompanies
            // 
            this.btnLastPageCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLastPageCompanies.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLastPageCompanies.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLastPageCompanies.Depth = 0;
            this.btnLastPageCompanies.HighEmphasis = true;
            this.btnLastPageCompanies.Icon = null;
            this.btnLastPageCompanies.Location = new System.Drawing.Point(196, 6);
            this.btnLastPageCompanies.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLastPageCompanies.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLastPageCompanies.Name = "btnLastPageCompanies";
            this.btnLastPageCompanies.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLastPageCompanies.Size = new System.Drawing.Size(44, 19);
            this.btnLastPageCompanies.TabIndex = 1;
            this.btnLastPageCompanies.Text = ">>";
            this.btnLastPageCompanies.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLastPageCompanies.UseAccentColor = false;
            this.btnLastPageCompanies.UseVisualStyleBackColor = true;
            this.btnLastPageCompanies.Click += new System.EventHandler(this.BtnLastPageModes_Click);
            // 
            // btnBackPageCompanies
            // 
            this.btnBackPageCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBackPageCompanies.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBackPageCompanies.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBackPageCompanies.Depth = 0;
            this.btnBackPageCompanies.HighEmphasis = true;
            this.btnBackPageCompanies.Icon = null;
            this.btnBackPageCompanies.Location = new System.Drawing.Point(55, 6);
            this.btnBackPageCompanies.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBackPageCompanies.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBackPageCompanies.Name = "btnBackPageCompanies";
            this.btnBackPageCompanies.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBackPageCompanies.Size = new System.Drawing.Size(43, 19);
            this.btnBackPageCompanies.TabIndex = 2;
            this.btnBackPageCompanies.Text = "<";
            this.btnBackPageCompanies.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBackPageCompanies.UseAccentColor = false;
            this.btnBackPageCompanies.UseVisualStyleBackColor = true;
            this.btnBackPageCompanies.Click += new System.EventHandler(this.BtnBackPageModes_Click);
            // 
            // btnNextPageCompanies
            // 
            this.btnNextPageCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextPageCompanies.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNextPageCompanies.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNextPageCompanies.Depth = 0;
            this.btnNextPageCompanies.HighEmphasis = true;
            this.btnNextPageCompanies.Icon = null;
            this.btnNextPageCompanies.Location = new System.Drawing.Point(145, 6);
            this.btnNextPageCompanies.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNextPageCompanies.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNextPageCompanies.Name = "btnNextPageCompanies";
            this.btnNextPageCompanies.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNextPageCompanies.Size = new System.Drawing.Size(43, 19);
            this.btnNextPageCompanies.TabIndex = 3;
            this.btnNextPageCompanies.Text = ">";
            this.btnNextPageCompanies.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNextPageCompanies.UseAccentColor = false;
            this.btnNextPageCompanies.UseVisualStyleBackColor = true;
            this.btnNextPageCompanies.Click += new System.EventHandler(this.BtnNextPageModes_Click);
            // 
            // textBoxCurrentPageCompanies
            // 
            this.textBoxCurrentPageCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCurrentPageCompanies.Location = new System.Drawing.Point(105, 5);
            this.textBoxCurrentPageCompanies.Name = "textBoxCurrentPageCompanies";
            this.textBoxCurrentPageCompanies.Size = new System.Drawing.Size(33, 20);
            this.textBoxCurrentPageCompanies.TabIndex = 4;
            this.textBoxCurrentPageCompanies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCurrentPageCompanies.TextChanged += new System.EventHandler(this.TextBoxCurrentPageMode_TextChanged);
            // 
            // cmbPageSizeCompanies
            // 
            this.cmbPageSizeCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbPageSizeCompanies.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pageModelBindingSource, "Size", true));
            this.cmbPageSizeCompanies.DataSource = this.itemsBindingSource;
            this.cmbPageSizeCompanies.FormattingEnabled = true;
            this.cmbPageSizeCompanies.Location = new System.Drawing.Point(3, 13);
            this.cmbPageSizeCompanies.Name = "cmbPageSizeCompanies";
            this.cmbPageSizeCompanies.Size = new System.Drawing.Size(121, 21);
            this.cmbPageSizeCompanies.TabIndex = 10;
            this.cmbPageSizeCompanies.SelectedIndexChanged += new System.EventHandler(this.CmbPageSizeModes_Changed);
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
            // tlpCompanyList
            // 
            this.tlpCompanyList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCompanyList.ColumnCount = 1;
            this.tlpCompanyList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCompanyList.Controls.Add(this.listViewCompanies, 0, 0);
            this.tlpCompanyList.Location = new System.Drawing.Point(0, 0);
            this.tlpCompanyList.Name = "tlpCompanyList";
            this.tlpCompanyList.RowCount = 1;
            this.tlpCompanyList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCompanyList.Size = new System.Drawing.Size(755, 290);
            this.tlpCompanyList.TabIndex = 6;
            this.tlpCompanyList.SizeChanged += new System.EventHandler(this.TlpModesList_SizeChanged);
            // 
            // listViewModes
            // 
            this.listViewCompanies.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listViewCompanies.AutoSizeTable = false;
            this.listViewCompanies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewCompanies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewCompanies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIDCompany,
            this.columnNameCompany,
            this.columnDateCreation,
            this.columnCountry});
            this.listViewCompanies.Depth = 0;
            this.listViewCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCompanies.FullRowSelect = true;
            this.listViewCompanies.HideSelection = false;
            this.listViewCompanies.Location = new System.Drawing.Point(3, 3);
            this.listViewCompanies.MinimumSize = new System.Drawing.Size(200, 100);
            this.listViewCompanies.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewCompanies.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewCompanies.Name = "listViewModes";
            this.listViewCompanies.OwnerDraw = true;
            this.listViewCompanies.Size = new System.Drawing.Size(749, 284);
            this.listViewCompanies.TabIndex = 5;
            this.listViewCompanies.UseCompatibleStateImageBehavior = false;
            this.listViewCompanies.View = System.Windows.Forms.View.Details;
            // 
            // columnIDCompany
            // 
            this.columnIDCompany.Tag = "80";
            this.columnIDCompany.Text = "ID";
            this.columnIDCompany.Width = 80;
            // 
            // columnNameCompany
            // 
            this.columnNameCompany.Tag = "300";
            this.columnNameCompany.Text = "Name";
            this.columnNameCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnNameCompany.Width = 300;
            // 
            // columnDateCreation
            // 
            this.columnDateCreation.Tag = "180";
            this.columnDateCreation.Text = "DateCreation";
            this.columnDateCreation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDateCreation.Width = 180;
            // 
            // columnCountry
            // 
            this.columnCountry.Tag = "180";
            this.columnCountry.Text = "Country";
            this.columnCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCountry.Width = 180;
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
            this.tlpListStep.SizeChanged += new System.EventHandler(this.TlpListStep_SizeChanged);
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
            this.columnIDStep.Tag = "50";
            this.columnIDStep.Text = "ID";
            this.columnIDStep.Width = 50;
            // 
            // columnModeName
            // 
            this.columnModeName.Tag = "110";
            this.columnModeName.Text = "ModeName";
            this.columnModeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnModeName.Width = 110;
            // 
            // columnTimer
            // 
            this.columnTimer.Tag = "90";
            this.columnTimer.Text = "Timer";
            this.columnTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTimer.Width = 90;
            // 
            // columnDestination
            // 
            this.columnDestination.Tag = "150";
            this.columnDestination.Text = "Destination";
            this.columnDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDestination.Width = 150;
            // 
            // columnSpeed
            // 
            this.columnSpeed.Tag = "90";
            this.columnSpeed.Text = "Speed";
            this.columnSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSpeed.Width = 90;
            // 
            // columnType
            // 
            this.columnType.Tag = "140";
            this.columnType.Text = "Type";
            this.columnType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnType.Width = 140;
            // 
            // columnVolume
            // 
            this.columnVolume.Tag = "90";
            this.columnVolume.Text = "Volume";
            this.columnVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnVolume.Width = 90;
            // 
            // columnModeId
            // 
            this.columnModeId.Tag = "0";
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
            this.tlpCompaniesButton.ResumeLayout(false);
            this.tlpCompaniesButton.PerformLayout();
            this.tlpStepsButton.ResumeLayout(false);
            this.tlpStepsButton.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.materialTabControl.ResumeLayout(false);
            this.tabPageCompany.ResumeLayout(false);
            this.tlpCompany.ResumeLayout(false);
            this.tlpPagedCompanies.ResumeLayout(false);
            this.tlpPagedCompanies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.tlpCompanyList.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tlpCompaniesButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmItemFile;
        private System.Windows.Forms.ToolStripMenuItem tsmItemImport;
        private System.Windows.Forms.ToolStripMenuItem tsmItemClose;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.Button btnEditCompany;
        private System.Windows.Forms.Button btnDeleteCompany;
        private System.Windows.Forms.Button btnDeleteStep;
        private System.Windows.Forms.Button btnAddStep;
        private System.Windows.Forms.Button btnEditStep;
        private System.Windows.Forms.ToolStripMenuItem tsmItemExport;
        private System.Windows.Forms.ToolStripMenuItem tsmImportFromExcel;
        private System.Windows.Forms.ToolStripMenuItem tsmSaveToExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxBottleNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxUsedTips;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private System.Windows.Forms.TabPage tabPageCompany;
        private System.Windows.Forms.TabPage tabPageStep;
        private MaterialSkin.Controls.MaterialListView listViewCompanies;
        private System.Windows.Forms.ColumnHeader columnIDCompany;
        private System.Windows.Forms.ColumnHeader columnNameCompany;
        private System.Windows.Forms.ColumnHeader columnDateCreation;
        private System.Windows.Forms.ColumnHeader columnCountry;
        private System.Windows.Forms.TableLayoutPanel tlpCompanyList;
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
        private System.Windows.Forms.TableLayoutPanel tlpCompany;
        private System.Windows.Forms.TableLayoutPanel tlpPagedCompanies;
        private MaterialSkin.Controls.MaterialButton btnFirstPageCompanies;
        private MaterialSkin.Controls.MaterialButton btnLastPageCompanies;
        private MaterialSkin.Controls.MaterialButton btnBackPageCompanies;
        private MaterialSkin.Controls.MaterialButton btnNextPageCompanies;
        private System.Windows.Forms.TextBox textBoxCurrentPageCompanies;
        private System.Windows.Forms.ComboBox cmbPageSizeCompanies;
        private System.Windows.Forms.ColumnHeader columnModeId;
    }
}