using System.Drawing;
using TestTask.BindingItem;

namespace TestTask.Forms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tlpCompaniesButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteCompany = new System.Windows.Forms.Button();
            this.btnEditCompany = new System.Windows.Forms.Button();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.tlpProductsButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteStep = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmImportFromExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaveToExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tlpCategoriesButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.materialTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageCompanies = new System.Windows.Forms.TabPage();
            this.tlpCompany = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPagedCompanies = new System.Windows.Forms.TableLayoutPanel();
            this.btnFirstPageCompanies = new MaterialSkin.Controls.MaterialButton();
            this.btnLastPageCompanies = new MaterialSkin.Controls.MaterialButton();
            this.btnBackPageCompanies = new MaterialSkin.Controls.MaterialButton();
            this.btnNextPageCompanies = new MaterialSkin.Controls.MaterialButton();
            this.tbCurrentPageCompanies = new System.Windows.Forms.TextBox();
            this.bindingSourcePage = new System.Windows.Forms.BindingSource(this.components);
            this.cmbPageSizeCompanies = new System.Windows.Forms.ComboBox();
            this.bindingSourcePageCompanies = new System.Windows.Forms.BindingSource(this.components);
            this.tlpCompanyList = new System.Windows.Forms.TableLayoutPanel();
            this.listViewCompanies = new MaterialSkin.Controls.MaterialListView();
            this.columnIDCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNameCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDateCreation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.tlpProduct = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPagedProduct = new System.Windows.Forms.TableLayoutPanel();
            this.btnFirstPageProducts = new MaterialSkin.Controls.MaterialButton();
            this.btnLastPageProduct = new MaterialSkin.Controls.MaterialButton();
            this.btnBackPageProducts = new MaterialSkin.Controls.MaterialButton();
            this.btnNextPageProduct = new MaterialSkin.Controls.MaterialButton();
            this.tbCurrentPageProduct = new System.Windows.Forms.TextBox();
            this.cmbPageSizeProduct = new System.Windows.Forms.ComboBox();
            this.bindingSourcePageProducts = new System.Windows.Forms.BindingSource(this.components);
            this.tlpListProduct = new System.Windows.Forms.TableLayoutPanel();
            this.listViewProduct = new MaterialSkin.Controls.MaterialListView();
            this.columnIDStep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDestination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCompanyId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCategoryId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageCategory = new System.Windows.Forms.TabPage();
            this.tlpCategory = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCategoriesPageControl = new System.Windows.Forms.TableLayoutPanel();
            this.btnFirstPageCategories = new MaterialSkin.Controls.MaterialButton();
            this.btnLastPageCategories = new MaterialSkin.Controls.MaterialButton();
            this.btnBackPageCategories = new MaterialSkin.Controls.MaterialButton();
            this.btnNextPageCategories = new MaterialSkin.Controls.MaterialButton();
            this.tbCurrentPageCategories = new System.Windows.Forms.TextBox();
            this.cmbCategoryPageSize = new System.Windows.Forms.ComboBox();
            this.bindingSourcePageCategories = new System.Windows.Forms.BindingSource(this.components);
            this.tlpListCategory = new System.Windows.Forms.TableLayoutPanel();
            this.listViewCategories = new MaterialSkin.Controls.MaterialListView();
            this.columnIDCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCategoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageCATEGORIES = new System.Windows.Forms.TabPage();
            this.listViewCategoryCATEGORIES = new TestTask.Control.CategoryCantrol.ListViewCategoryControl();
            this.tabPageCategoriy = new System.Windows.Forms.TabPage();
            this.tabPageCategoryUserControl = new TestTask.Control.CategoryCantrol.TabPageCategoryUserControl();
            this.tlpCompaniesButton.SuspendLayout();
            this.tlpProductsButton.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tlpCategoriesButton.SuspendLayout();
            this.materialTabControl.SuspendLayout();
            this.tabPageCompanies.SuspendLayout();
            this.tlpCompany.SuspendLayout();
            this.tlpPagedCompanies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePageCompanies)).BeginInit();
            this.tlpCompanyList.SuspendLayout();
            this.tabPageProduct.SuspendLayout();
            this.tlpProduct.SuspendLayout();
            this.tlpPagedProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePageProducts)).BeginInit();
            this.tlpListProduct.SuspendLayout();
            this.tabPageCategory.SuspendLayout();
            this.tlpCategory.SuspendLayout();
            this.tlpCategoriesPageControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePageCategories)).BeginInit();
            this.tlpListCategory.SuspendLayout();
            this.tabPageCATEGORIES.SuspendLayout();
            this.tabPageCategoriy.SuspendLayout();
            this.SuspendLayout();
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
            this.tlpCompaniesButton.Name = "tlpCompaniesButton";
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
            // tlpProductsButton
            // 
            this.tlpProductsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpProductsButton.ColumnCount = 3;
            this.tlpProductsButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpProductsButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpProductsButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpProductsButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpProductsButton.Controls.Add(this.btnDeleteStep, 2, 0);
            this.tlpProductsButton.Controls.Add(this.btnAddProduct, 0, 0);
            this.tlpProductsButton.Controls.Add(this.btnEditProduct, 1, 0);
            this.tlpProductsButton.ForeColor = System.Drawing.Color.Transparent;
            this.tlpProductsButton.Location = new System.Drawing.Point(641, 7);
            this.tlpProductsButton.Margin = new System.Windows.Forms.Padding(1);
            this.tlpProductsButton.MinimumSize = new System.Drawing.Size(110, 29);
            this.tlpProductsButton.Name = "tlpProductsButton";
            this.tlpProductsButton.RowCount = 1;
            this.tlpProductsButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProductsButton.Size = new System.Drawing.Size(110, 29);
            this.tlpProductsButton.TabIndex = 1;
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
            this.toolTip.SetToolTip(this.btnDeleteStep, "Delete product");
            this.btnDeleteStep.UseVisualStyleBackColor = true;
            this.btnDeleteStep.Click += new System.EventHandler(this.BtnDeleteProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduct.AutoSize = true;
            this.btnAddProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.Location = new System.Drawing.Point(0, 0);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(36, 29);
            this.btnAddProduct.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnAddProduct, "Add product");
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditProduct.AutoSize = true;
            this.btnEditProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEditProduct.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnEditProduct.Image")));
            this.btnEditProduct.Location = new System.Drawing.Point(36, 0);
            this.btnEditProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(36, 29);
            this.btnEditProduct.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnEditProduct, "Edit product");
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.BtnEditProduct_Click);
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
            // tlpCategoriesButton
            // 
            this.tlpCategoriesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCategoriesButton.ColumnCount = 3;
            this.tlpCategoriesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCategoriesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCategoriesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCategoriesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCategoriesButton.Controls.Add(this.btnDeleteCategory, 2, 0);
            this.tlpCategoriesButton.Controls.Add(this.btnEditCategory, 1, 0);
            this.tlpCategoriesButton.Controls.Add(this.btnAddCategory, 0, 0);
            this.tlpCategoriesButton.ForeColor = System.Drawing.Color.Transparent;
            this.tlpCategoriesButton.Location = new System.Drawing.Point(641, 7);
            this.tlpCategoriesButton.Margin = new System.Windows.Forms.Padding(1);
            this.tlpCategoriesButton.MinimumSize = new System.Drawing.Size(110, 29);
            this.tlpCategoriesButton.Name = "tlpCategoriesButton";
            this.tlpCategoriesButton.RowCount = 1;
            this.tlpCategoriesButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCategoriesButton.Size = new System.Drawing.Size(110, 29);
            this.tlpCategoriesButton.TabIndex = 2;
            this.toolTip.SetToolTip(this.tlpCategoriesButton, "Edit item Company");
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCategory.AutoSize = true;
            this.btnDeleteCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDeleteCategory.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCategory.Image")));
            this.btnDeleteCategory.Location = new System.Drawing.Point(72, 0);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(38, 29);
            this.btnDeleteCategory.TabIndex = 7;
            this.toolTip.SetToolTip(this.btnDeleteCategory, "Delete category");
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.BtnDeleteCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCategory.AutoSize = true;
            this.btnEditCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEditCategory.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCategory.Image")));
            this.btnEditCategory.Location = new System.Drawing.Point(36, 0);
            this.btnEditCategory.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(36, 29);
            this.btnEditCategory.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnEditCategory, "Edit category");
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.BtnEditCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCategory.AutoSize = true;
            this.btnAddCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAddCategory.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.Image")));
            this.btnAddCategory.Location = new System.Drawing.Point(0, 0);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(36, 29);
            this.btnAddCategory.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnAddCategory, "Add category");
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.BtnAddCategory_Click);
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
            this.materialTabControl.Controls.Add(this.tabPageCompanies);
            this.materialTabControl.Controls.Add(this.tabPageProduct);
            this.materialTabControl.Controls.Add(this.tabPageCategory);
            this.materialTabControl.Controls.Add(this.tabPageCATEGORIES);
            this.materialTabControl.Controls.Add(this.tabPageCategoriy);
            this.materialTabControl.Depth = 0;
            this.materialTabControl.Location = new System.Drawing.Point(8, 75);
            this.materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl.Multiline = true;
            this.materialTabControl.Name = "materialTabControl";
            this.materialTabControl.SelectedIndex = 0;
            this.materialTabControl.Size = new System.Drawing.Size(766, 357);
            this.materialTabControl.TabIndex = 5;
            // 
            // tabPageCompanies
            // 
            this.tabPageCompanies.Controls.Add(this.tlpCompany);
            this.tabPageCompanies.Controls.Add(this.tlpCompanyList);
            this.tabPageCompanies.Location = new System.Drawing.Point(4, 22);
            this.tabPageCompanies.Name = "tabPageCompanies";
            this.tabPageCompanies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompanies.Size = new System.Drawing.Size(758, 331);
            this.tabPageCompanies.TabIndex = 0;
            this.tabPageCompanies.Text = "Companies";
            this.tabPageCompanies.UseVisualStyleBackColor = true;
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
            this.tlpPagedCompanies.Controls.Add(this.tbCurrentPageCompanies, 2, 0);
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
            this.btnFirstPageCompanies.Click += new System.EventHandler(this.BtnFirstPageCompany_Click);
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
            this.btnLastPageCompanies.Click += new System.EventHandler(this.BtnLastPageCompany_Click);
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
            this.btnBackPageCompanies.Click += new System.EventHandler(this.BtnBackPageCompany_Click);
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
            this.btnNextPageCompanies.Click += new System.EventHandler(this.BtnNextPageCompany_Click);
            // 
            // tbCurrentPageCompanies
            // 
            this.tbCurrentPageCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCurrentPageCompanies.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePage, "Number", true));
            this.tbCurrentPageCompanies.Location = new System.Drawing.Point(105, 5);
            this.tbCurrentPageCompanies.Name = "tbCurrentPageCompanies";
            this.tbCurrentPageCompanies.Size = new System.Drawing.Size(33, 20);
            this.tbCurrentPageCompanies.TabIndex = 4;
            this.tbCurrentPageCompanies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCurrentPageCompanies.TextChanged += new System.EventHandler(this.TextBoxCurrentPageMode_TextChanged);
            // 
            // bindingSourcePage
            // 
            this.bindingSourcePage.DataSource = typeof(TestTask.BindingItem.PageModel);
            // 
            // cmbPageSizeCompanies
            // 
            this.cmbPageSizeCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbPageSizeCompanies.DataSource = this.bindingSourcePageCompanies;
            this.cmbPageSizeCompanies.FormattingEnabled = true;
            this.cmbPageSizeCompanies.Location = new System.Drawing.Point(3, 13);
            this.cmbPageSizeCompanies.Name = "cmbPageSizeCompanies";
            this.cmbPageSizeCompanies.Size = new System.Drawing.Size(121, 21);
            this.cmbPageSizeCompanies.TabIndex = 10;
            this.cmbPageSizeCompanies.SelectedIndexChanged += new System.EventHandler(this.CmbPageSizeCompany_Changed);
            // 
            // bindingSourcePageCompanies
            // 
            this.bindingSourcePageCompanies.DataMember = "Items";
            this.bindingSourcePageCompanies.DataSource = this.bindingSourcePage;
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
            this.tlpCompanyList.SizeChanged += new System.EventHandler(this.TlpCompanyList_SizeChanged);
            // 
            // listViewCompanies
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
            this.listViewCompanies.Name = "listViewCompanies";
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
            // tabPageProduct
            // 
            this.tabPageProduct.Controls.Add(this.tlpProduct);
            this.tabPageProduct.Controls.Add(this.tlpListProduct);
            this.tabPageProduct.Location = new System.Drawing.Point(4, 22);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduct.Size = new System.Drawing.Size(758, 331);
            this.tabPageProduct.TabIndex = 1;
            this.tabPageProduct.Text = "Products";
            this.tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // tlpProduct
            // 
            this.tlpProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpProduct.ColumnCount = 3;
            this.tlpProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpProduct.Controls.Add(this.tlpPagedProduct, 1, 0);
            this.tlpProduct.Controls.Add(this.tlpProductsButton, 2, 0);
            this.tlpProduct.Controls.Add(this.cmbPageSizeProduct, 0, 0);
            this.tlpProduct.Location = new System.Drawing.Point(3, 290);
            this.tlpProduct.Name = "tlpProduct";
            this.tlpProduct.RowCount = 1;
            this.tlpProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProduct.Size = new System.Drawing.Size(752, 37);
            this.tlpProduct.TabIndex = 8;
            // 
            // tlpPagedProduct
            // 
            this.tlpPagedProduct.ColumnCount = 5;
            this.tlpPagedProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlpPagedProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlpPagedProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpPagedProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlpPagedProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlpPagedProduct.Controls.Add(this.btnFirstPageProducts, 0, 0);
            this.tlpPagedProduct.Controls.Add(this.btnLastPageProduct, 4, 0);
            this.tlpPagedProduct.Controls.Add(this.btnBackPageProducts, 1, 0);
            this.tlpPagedProduct.Controls.Add(this.btnNextPageProduct, 3, 0);
            this.tlpPagedProduct.Controls.Add(this.tbCurrentPageProduct, 2, 0);
            this.tlpPagedProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPagedProduct.Location = new System.Drawing.Point(253, 3);
            this.tlpPagedProduct.Name = "tlpPagedProduct";
            this.tlpPagedProduct.RowCount = 1;
            this.tlpPagedProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagedProduct.Size = new System.Drawing.Size(244, 31);
            this.tlpPagedProduct.TabIndex = 9;
            // 
            // btnFirstPageProducts
            // 
            this.btnFirstPageProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFirstPageProducts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFirstPageProducts.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFirstPageProducts.Depth = 0;
            this.btnFirstPageProducts.HighEmphasis = true;
            this.btnFirstPageProducts.Icon = null;
            this.btnFirstPageProducts.Location = new System.Drawing.Point(4, 6);
            this.btnFirstPageProducts.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFirstPageProducts.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFirstPageProducts.Name = "btnFirstPageProducts";
            this.btnFirstPageProducts.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFirstPageProducts.Size = new System.Drawing.Size(43, 19);
            this.btnFirstPageProducts.TabIndex = 0;
            this.btnFirstPageProducts.Text = "<<";
            this.btnFirstPageProducts.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFirstPageProducts.UseAccentColor = false;
            this.btnFirstPageProducts.UseVisualStyleBackColor = true;
            this.btnFirstPageProducts.Click += new System.EventHandler(this.BtnFirstPageProduct_Click);
            // 
            // btnLastPageProduct
            // 
            this.btnLastPageProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLastPageProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLastPageProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLastPageProduct.Depth = 0;
            this.btnLastPageProduct.HighEmphasis = true;
            this.btnLastPageProduct.Icon = null;
            this.btnLastPageProduct.Location = new System.Drawing.Point(196, 6);
            this.btnLastPageProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLastPageProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLastPageProduct.Name = "btnLastPageProduct";
            this.btnLastPageProduct.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLastPageProduct.Size = new System.Drawing.Size(44, 19);
            this.btnLastPageProduct.TabIndex = 1;
            this.btnLastPageProduct.Text = ">>";
            this.btnLastPageProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLastPageProduct.UseAccentColor = false;
            this.btnLastPageProduct.UseVisualStyleBackColor = true;
            this.btnLastPageProduct.Click += new System.EventHandler(this.BtnLastPageProduct_Click);
            // 
            // btnBackPageProducts
            // 
            this.btnBackPageProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBackPageProducts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBackPageProducts.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBackPageProducts.Depth = 0;
            this.btnBackPageProducts.HighEmphasis = true;
            this.btnBackPageProducts.Icon = null;
            this.btnBackPageProducts.Location = new System.Drawing.Point(55, 6);
            this.btnBackPageProducts.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBackPageProducts.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBackPageProducts.Name = "btnBackPageProducts";
            this.btnBackPageProducts.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBackPageProducts.Size = new System.Drawing.Size(43, 19);
            this.btnBackPageProducts.TabIndex = 2;
            this.btnBackPageProducts.Text = "<";
            this.btnBackPageProducts.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBackPageProducts.UseAccentColor = false;
            this.btnBackPageProducts.UseVisualStyleBackColor = true;
            this.btnBackPageProducts.Click += new System.EventHandler(this.BtnBackPageProduct_Click);
            // 
            // btnNextPageProduct
            // 
            this.btnNextPageProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextPageProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNextPageProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNextPageProduct.Depth = 0;
            this.btnNextPageProduct.HighEmphasis = true;
            this.btnNextPageProduct.Icon = null;
            this.btnNextPageProduct.Location = new System.Drawing.Point(145, 6);
            this.btnNextPageProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNextPageProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNextPageProduct.Name = "btnNextPageProduct";
            this.btnNextPageProduct.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNextPageProduct.Size = new System.Drawing.Size(43, 19);
            this.btnNextPageProduct.TabIndex = 3;
            this.btnNextPageProduct.Text = ">";
            this.btnNextPageProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNextPageProduct.UseAccentColor = false;
            this.btnNextPageProduct.UseVisualStyleBackColor = true;
            this.btnNextPageProduct.Click += new System.EventHandler(this.BtnNextPageProduct_Click);
            // 
            // tbCurrentPageProduct
            // 
            this.tbCurrentPageProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCurrentPageProduct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePage, "Number", true));
            this.tbCurrentPageProduct.Location = new System.Drawing.Point(105, 5);
            this.tbCurrentPageProduct.Name = "tbCurrentPageProduct";
            this.tbCurrentPageProduct.Size = new System.Drawing.Size(33, 20);
            this.tbCurrentPageProduct.TabIndex = 4;
            this.tbCurrentPageProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCurrentPageProduct.TextChanged += new System.EventHandler(this.TextBoxCurrentPageProduct_TextChanged);
            // 
            // cmbPageSizeProduct
            // 
            this.cmbPageSizeProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbPageSizeProduct.DataSource = this.bindingSourcePageProducts;
            this.cmbPageSizeProduct.FormattingEnabled = true;
            this.cmbPageSizeProduct.Location = new System.Drawing.Point(3, 13);
            this.cmbPageSizeProduct.Name = "cmbPageSizeProduct";
            this.cmbPageSizeProduct.Size = new System.Drawing.Size(121, 21);
            this.cmbPageSizeProduct.TabIndex = 10;
            this.cmbPageSizeProduct.SelectedIndexChanged += new System.EventHandler(this.CmbPageSizeProduct_Changed);
            // 
            // bindingSourcePageProducts
            // 
            this.bindingSourcePageProducts.DataMember = "Items";
            this.bindingSourcePageProducts.DataSource = this.bindingSourcePage;
            // 
            // tlpListProduct
            // 
            this.tlpListProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpListProduct.ColumnCount = 1;
            this.tlpListProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpListProduct.Controls.Add(this.listViewProduct, 0, 0);
            this.tlpListProduct.Location = new System.Drawing.Point(0, 0);
            this.tlpListProduct.Name = "tlpListProduct";
            this.tlpListProduct.RowCount = 1;
            this.tlpListProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpListProduct.Size = new System.Drawing.Size(755, 290);
            this.tlpListProduct.TabIndex = 7;
            this.tlpListProduct.SizeChanged += new System.EventHandler(this.TlpProductList_SizeChanged);
            // 
            // listViewProduct
            // 
            this.listViewProduct.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listViewProduct.AutoSizeTable = false;
            this.listViewProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIDStep,
            this.columnCompanyName,
            this.columnCategory,
            this.columnType,
            this.columnPrice,
            this.columnDestination,
            this.columnCompanyId,
            this.columnCategoryId});
            this.listViewProduct.Depth = 0;
            this.listViewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewProduct.FullRowSelect = true;
            this.listViewProduct.HideSelection = false;
            this.listViewProduct.Location = new System.Drawing.Point(3, 3);
            this.listViewProduct.MinimumSize = new System.Drawing.Size(200, 100);
            this.listViewProduct.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewProduct.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.OwnerDraw = true;
            this.listViewProduct.Size = new System.Drawing.Size(749, 284);
            this.listViewProduct.TabIndex = 5;
            this.listViewProduct.UseCompatibleStateImageBehavior = false;
            this.listViewProduct.View = System.Windows.Forms.View.Details;
            // 
            // columnIDStep
            // 
            this.columnIDStep.Tag = "50";
            this.columnIDStep.Text = "ID";
            this.columnIDStep.Width = 50;
            // 
            // columnCompanyName
            // 
            this.columnCompanyName.Tag = "140";
            this.columnCompanyName.Text = "Company";
            this.columnCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCompanyName.Width = 140;
            // 
            // columnCategory
            // 
            this.columnCategory.Tag = "110";
            this.columnCategory.Text = "Category";
            this.columnCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCategory.Width = 110;
            // 
            // columnType
            // 
            this.columnType.Tag = "150";
            this.columnType.Text = "Type";
            this.columnType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnType.Width = 150;
            // 
            // columnPrice
            // 
            this.columnPrice.Tag = "90";
            this.columnPrice.Text = "Price";
            this.columnPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPrice.Width = 90;
            // 
            // columnDestination
            // 
            this.columnDestination.Tag = "160";
            this.columnDestination.Text = "Destination";
            this.columnDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDestination.Width = 160;
            // 
            // columnCompanyId
            // 
            this.columnCompanyId.Tag = "0";
            this.columnCompanyId.Text = "CompanyId";
            this.columnCompanyId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCompanyId.Width = 0;
            // 
            // columnCategoryId
            // 
            this.columnCategoryId.Text = "CategoryId";
            this.columnCategoryId.Width = 0;
            // 
            // tabPageCategory
            // 
            this.tabPageCategory.Controls.Add(this.tlpCategory);
            this.tabPageCategory.Controls.Add(this.tlpListCategory);
            this.tabPageCategory.Location = new System.Drawing.Point(4, 22);
            this.tabPageCategory.Name = "tabPageCategory";
            this.tabPageCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategory.Size = new System.Drawing.Size(758, 331);
            this.tabPageCategory.TabIndex = 2;
            this.tabPageCategory.Text = "Categories";
            this.tabPageCategory.UseVisualStyleBackColor = true;
            // 
            // tlpCategory
            // 
            this.tlpCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCategory.ColumnCount = 3;
            this.tlpCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCategory.Controls.Add(this.tlpCategoriesPageControl, 1, 0);
            this.tlpCategory.Controls.Add(this.tlpCategoriesButton, 2, 0);
            this.tlpCategory.Controls.Add(this.cmbCategoryPageSize, 0, 0);
            this.tlpCategory.Location = new System.Drawing.Point(3, 290);
            this.tlpCategory.Name = "tlpCategory";
            this.tlpCategory.RowCount = 1;
            this.tlpCategory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCategory.Size = new System.Drawing.Size(752, 37);
            this.tlpCategory.TabIndex = 11;
            // 
            // tlpCategoriesPageControl
            // 
            this.tlpCategoriesPageControl.ColumnCount = 5;
            this.tlpCategoriesPageControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlpCategoriesPageControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlpCategoriesPageControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpCategoriesPageControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlpCategoriesPageControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlpCategoriesPageControl.Controls.Add(this.btnFirstPageCategories, 0, 0);
            this.tlpCategoriesPageControl.Controls.Add(this.btnLastPageCategories, 4, 0);
            this.tlpCategoriesPageControl.Controls.Add(this.btnBackPageCategories, 1, 0);
            this.tlpCategoriesPageControl.Controls.Add(this.btnNextPageCategories, 3, 0);
            this.tlpCategoriesPageControl.Controls.Add(this.tbCurrentPageCategories, 2, 0);
            this.tlpCategoriesPageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCategoriesPageControl.Location = new System.Drawing.Point(253, 3);
            this.tlpCategoriesPageControl.Name = "tlpCategoriesPageControl";
            this.tlpCategoriesPageControl.RowCount = 1;
            this.tlpCategoriesPageControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCategoriesPageControl.Size = new System.Drawing.Size(244, 31);
            this.tlpCategoriesPageControl.TabIndex = 9;
            // 
            // btnFirstPageCategories
            // 
            this.btnFirstPageCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFirstPageCategories.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFirstPageCategories.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFirstPageCategories.Depth = 0;
            this.btnFirstPageCategories.HighEmphasis = true;
            this.btnFirstPageCategories.Icon = null;
            this.btnFirstPageCategories.Location = new System.Drawing.Point(4, 6);
            this.btnFirstPageCategories.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFirstPageCategories.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFirstPageCategories.Name = "btnFirstPageCategories";
            this.btnFirstPageCategories.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFirstPageCategories.Size = new System.Drawing.Size(43, 19);
            this.btnFirstPageCategories.TabIndex = 0;
            this.btnFirstPageCategories.Text = "<<";
            this.btnFirstPageCategories.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFirstPageCategories.UseAccentColor = false;
            this.btnFirstPageCategories.UseVisualStyleBackColor = true;
            this.btnFirstPageCategories.Click += new System.EventHandler(this.BtnFirstPageCategories_Click);
            // 
            // btnLastPageCategories
            // 
            this.btnLastPageCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLastPageCategories.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLastPageCategories.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLastPageCategories.Depth = 0;
            this.btnLastPageCategories.HighEmphasis = true;
            this.btnLastPageCategories.Icon = null;
            this.btnLastPageCategories.Location = new System.Drawing.Point(196, 6);
            this.btnLastPageCategories.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLastPageCategories.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLastPageCategories.Name = "btnLastPageCategories";
            this.btnLastPageCategories.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLastPageCategories.Size = new System.Drawing.Size(44, 19);
            this.btnLastPageCategories.TabIndex = 1;
            this.btnLastPageCategories.Text = ">>";
            this.btnLastPageCategories.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLastPageCategories.UseAccentColor = false;
            this.btnLastPageCategories.UseVisualStyleBackColor = true;
            this.btnLastPageCategories.Click += new System.EventHandler(this.BtnLastPageCategories_Click);
            // 
            // btnBackPageCategories
            // 
            this.btnBackPageCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBackPageCategories.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBackPageCategories.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBackPageCategories.Depth = 0;
            this.btnBackPageCategories.HighEmphasis = true;
            this.btnBackPageCategories.Icon = null;
            this.btnBackPageCategories.Location = new System.Drawing.Point(55, 6);
            this.btnBackPageCategories.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBackPageCategories.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBackPageCategories.Name = "btnBackPageCategories";
            this.btnBackPageCategories.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBackPageCategories.Size = new System.Drawing.Size(43, 19);
            this.btnBackPageCategories.TabIndex = 2;
            this.btnBackPageCategories.Text = "<";
            this.btnBackPageCategories.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBackPageCategories.UseAccentColor = false;
            this.btnBackPageCategories.UseVisualStyleBackColor = true;
            this.btnBackPageCategories.Click += new System.EventHandler(this.BtnBackPageCategories_Click);
            // 
            // btnNextPageCategories
            // 
            this.btnNextPageCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextPageCategories.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNextPageCategories.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNextPageCategories.Depth = 0;
            this.btnNextPageCategories.HighEmphasis = true;
            this.btnNextPageCategories.Icon = null;
            this.btnNextPageCategories.Location = new System.Drawing.Point(145, 6);
            this.btnNextPageCategories.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNextPageCategories.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNextPageCategories.Name = "btnNextPageCategories";
            this.btnNextPageCategories.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNextPageCategories.Size = new System.Drawing.Size(43, 19);
            this.btnNextPageCategories.TabIndex = 3;
            this.btnNextPageCategories.Text = ">";
            this.btnNextPageCategories.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNextPageCategories.UseAccentColor = false;
            this.btnNextPageCategories.UseVisualStyleBackColor = true;
            this.btnNextPageCategories.Click += new System.EventHandler(this.BtnNextPageCategories_Click);
            // 
            // tbCurrentPageCategories
            // 
            this.tbCurrentPageCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCurrentPageCategories.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePage, "Number", true));
            this.tbCurrentPageCategories.Location = new System.Drawing.Point(105, 5);
            this.tbCurrentPageCategories.Name = "tbCurrentPageCategories";
            this.tbCurrentPageCategories.Size = new System.Drawing.Size(33, 20);
            this.tbCurrentPageCategories.TabIndex = 4;
            this.tbCurrentPageCategories.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCurrentPageCategories.TextChanged += new System.EventHandler(this.TextBoxCurrentPageCategories_TextChanged);
            // 
            // cmbCategoryPageSize
            // 
            this.cmbCategoryPageSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbCategoryPageSize.DataSource = this.bindingSourcePageCategories;
            this.cmbCategoryPageSize.FormattingEnabled = true;
            this.cmbCategoryPageSize.Location = new System.Drawing.Point(3, 13);
            this.cmbCategoryPageSize.Name = "cmbCategoryPageSize";
            this.cmbCategoryPageSize.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoryPageSize.TabIndex = 10;
            this.cmbCategoryPageSize.SelectedIndexChanged += new System.EventHandler(this.CmbPageSizeCategory_Changed);
            // 
            // bindingSourcePageCategories
            // 
            this.bindingSourcePageCategories.DataMember = "Items";
            this.bindingSourcePageCategories.DataSource = this.bindingSourcePage;
            // 
            // tlpListCategory
            // 
            this.tlpListCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpListCategory.ColumnCount = 1;
            this.tlpListCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpListCategory.Controls.Add(this.listViewCategories, 0, 0);
            this.tlpListCategory.Location = new System.Drawing.Point(0, 0);
            this.tlpListCategory.Name = "tlpListCategory";
            this.tlpListCategory.RowCount = 1;
            this.tlpListCategory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpListCategory.Size = new System.Drawing.Size(755, 290);
            this.tlpListCategory.TabIndex = 10;
            this.tlpListCategory.SizeChanged += new System.EventHandler(this.TlpListCategory_SizeChanged);
            // 
            // listViewCategories
            // 
            this.listViewCategories.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listViewCategories.AutoSizeTable = false;
            this.listViewCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewCategories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIDCategory,
            this.columnCategoryName});
            this.listViewCategories.Depth = 0;
            this.listViewCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCategories.FullRowSelect = true;
            this.listViewCategories.HideSelection = false;
            this.listViewCategories.Location = new System.Drawing.Point(3, 3);
            this.listViewCategories.MinimumSize = new System.Drawing.Size(200, 100);
            this.listViewCategories.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewCategories.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewCategories.Name = "listViewCategories";
            this.listViewCategories.OwnerDraw = true;
            this.listViewCategories.Size = new System.Drawing.Size(749, 284);
            this.listViewCategories.TabIndex = 5;
            this.listViewCategories.UseCompatibleStateImageBehavior = false;
            this.listViewCategories.View = System.Windows.Forms.View.Details;
            // 
            // columnIDCategory
            // 
            this.columnIDCategory.Tag = "200";
            this.columnIDCategory.Text = "ID";
            this.columnIDCategory.Width = 200;
            // 
            // columnCategoryName
            // 
            this.columnCategoryName.Tag = "540";
            this.columnCategoryName.Text = "Name";
            this.columnCategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCategoryName.Width = 540;
            // 
            // tabPageCATEGORIES
            // 
            this.tabPageCATEGORIES.Controls.Add(this.listViewCategoryCATEGORIES);
            this.tabPageCATEGORIES.Location = new System.Drawing.Point(4, 22);
            this.tabPageCATEGORIES.Name = "tabPageCATEGORIES";
            this.tabPageCATEGORIES.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCATEGORIES.Size = new System.Drawing.Size(758, 331);
            this.tabPageCATEGORIES.TabIndex = 3;
            this.tabPageCATEGORIES.Text = "CATEGORIES";
            this.tabPageCATEGORIES.UseVisualStyleBackColor = true;
            // 
            // listViewCategoryCATEGORIES
            // 
            this.listViewCategoryCATEGORIES.Depth = 0;
            this.listViewCategoryCATEGORIES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCategoryCATEGORIES.Location = new System.Drawing.Point(3, 3);
            this.listViewCategoryCATEGORIES.MouseState = MaterialSkin.MouseState.HOVER;
            this.listViewCategoryCATEGORIES.Name = "listViewCategoryCATEGORIES";
            this.listViewCategoryCATEGORIES.Size = new System.Drawing.Size(752, 325);
            this.listViewCategoryCATEGORIES.TabIndex = 0;
            // 
            // tabPageCategoriy
            // 
            this.tabPageCategoriy.Controls.Add(this.tabPageCategoryUserControl);
            this.tabPageCategoriy.Location = new System.Drawing.Point(4, 22);
            this.tabPageCategoriy.Name = "tabPageCategoriy";
            this.tabPageCategoriy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategoriy.Size = new System.Drawing.Size(758, 331);
            this.tabPageCategoriy.TabIndex = 4;
            this.tabPageCategoriy.Text = "CaTeGoRy";
            this.tabPageCategoriy.UseVisualStyleBackColor = true;
            // 
            // tabPageCategoryUserControl
            // 
            this.tabPageCategoryUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPageCategoryUserControl.Depth = 0;
            this.tabPageCategoryUserControl.Location = new System.Drawing.Point(3, 3);
            this.tabPageCategoryUserControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabPageCategoryUserControl.Name = "tabPageCategoryUserControl";
            this.tabPageCategoryUserControl.Size = new System.Drawing.Size(752, 325);
            this.tabPageCategoryUserControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 435);
            this.Controls.Add(this.materialTabSelector);
            this.Controls.Add(this.materialTabControl);
            this.Controls.Add(this.menuStrip);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TableForm_FormClosing);
            this.Load += new System.EventHandler(this.TableForm_Load);
            this.tlpCompaniesButton.ResumeLayout(false);
            this.tlpCompaniesButton.PerformLayout();
            this.tlpProductsButton.ResumeLayout(false);
            this.tlpProductsButton.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tlpCategoriesButton.ResumeLayout(false);
            this.tlpCategoriesButton.PerformLayout();
            this.materialTabControl.ResumeLayout(false);
            this.tabPageCompanies.ResumeLayout(false);
            this.tlpCompany.ResumeLayout(false);
            this.tlpPagedCompanies.ResumeLayout(false);
            this.tlpPagedCompanies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePageCompanies)).EndInit();
            this.tlpCompanyList.ResumeLayout(false);
            this.tabPageProduct.ResumeLayout(false);
            this.tlpProduct.ResumeLayout(false);
            this.tlpPagedProduct.ResumeLayout(false);
            this.tlpPagedProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePageProducts)).EndInit();
            this.tlpListProduct.ResumeLayout(false);
            this.tabPageCategory.ResumeLayout(false);
            this.tlpCategory.ResumeLayout(false);
            this.tlpCategoriesPageControl.ResumeLayout(false);
            this.tlpCategoriesPageControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePageCategories)).EndInit();
            this.tlpListCategory.ResumeLayout(false);
            this.tabPageCATEGORIES.ResumeLayout(false);
            this.tabPageCategoriy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpProductsButton;
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
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.ToolStripMenuItem tsmItemExport;
        private System.Windows.Forms.ToolStripMenuItem tsmImportFromExcel;
        private System.Windows.Forms.ToolStripMenuItem tsmSaveToExcel;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private System.Windows.Forms.TabPage tabPageCompanies;
        private System.Windows.Forms.TabPage tabPageProduct;
        private MaterialSkin.Controls.MaterialListView listViewCompanies;
        private System.Windows.Forms.ColumnHeader columnIDCompany;
        private System.Windows.Forms.ColumnHeader columnNameCompany;
        private System.Windows.Forms.ColumnHeader columnDateCreation;
        private System.Windows.Forms.ColumnHeader columnCountry;
        private System.Windows.Forms.TableLayoutPanel tlpCompanyList;
        private System.Windows.Forms.TableLayoutPanel tlpListProduct;
        private MaterialSkin.Controls.MaterialListView listViewProduct;
        private System.Windows.Forms.ColumnHeader columnIDStep;
        private System.Windows.Forms.ColumnHeader columnCompanyName;
        private System.Windows.Forms.ColumnHeader columnCategory;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnDestination;
        private System.Windows.Forms.TableLayoutPanel tlpProduct;
        private System.Windows.Forms.TableLayoutPanel tlpPagedProduct;
        private MaterialSkin.Controls.MaterialButton btnFirstPageProducts;
        private MaterialSkin.Controls.MaterialButton btnLastPageProduct;
        private MaterialSkin.Controls.MaterialButton btnBackPageProducts;
        private MaterialSkin.Controls.MaterialButton btnNextPageProduct;
        private System.Windows.Forms.TextBox tbCurrentPageProduct;
        private System.Windows.Forms.ComboBox cmbPageSizeProduct;
        private System.Windows.Forms.BindingSource pageModelBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.TableLayoutPanel tlpCompany;
        private System.Windows.Forms.TableLayoutPanel tlpPagedCompanies;
        private MaterialSkin.Controls.MaterialButton btnFirstPageCompanies;
        private MaterialSkin.Controls.MaterialButton btnLastPageCompanies;
        private MaterialSkin.Controls.MaterialButton btnBackPageCompanies;
        private MaterialSkin.Controls.MaterialButton btnNextPageCompanies;
        private System.Windows.Forms.TextBox tbCurrentPageCompanies;
        private System.Windows.Forms.ComboBox cmbPageSizeCompanies;
        private System.Windows.Forms.ColumnHeader columnCompanyId;
        private System.Windows.Forms.BindingSource bindingSourcePage;
        private System.Windows.Forms.BindingSource bindingSourcePageCompanies;
        private System.Windows.Forms.BindingSource bindingSourcePageProducts;
        private System.Windows.Forms.TabPage tabPageCategory;
        private System.Windows.Forms.TableLayoutPanel tlpCategory;
        private System.Windows.Forms.TableLayoutPanel tlpCategoriesPageControl;
        private MaterialSkin.Controls.MaterialButton btnFirstPageCategories;
        private MaterialSkin.Controls.MaterialButton btnLastPageCategories;
        private MaterialSkin.Controls.MaterialButton btnBackPageCategories;
        private MaterialSkin.Controls.MaterialButton btnNextPageCategories;
        private System.Windows.Forms.TextBox tbCurrentPageCategories;
        private System.Windows.Forms.TableLayoutPanel tlpCategoriesButton;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.ComboBox cmbCategoryPageSize;
        private System.Windows.Forms.TableLayoutPanel tlpListCategory;
        private MaterialSkin.Controls.MaterialListView listViewCategories;
        private System.Windows.Forms.ColumnHeader columnIDCategory;
        private System.Windows.Forms.ColumnHeader columnCategoryName;
        private System.Windows.Forms.BindingSource bindingSourcePageCategories;
        private System.Windows.Forms.ColumnHeader columnCategoryId;
        private System.Windows.Forms.TabPage tabPageCATEGORIES;
        private Control.CategoryCantrol.ListViewCategoryControl listViewCategoryCATEGORIES;
        private System.Windows.Forms.TabPage tabPageCategoriy;
        private Control.CategoryCantrol.TabPageCategoryUserControl tabPageCategoryUserControl;
    }
}