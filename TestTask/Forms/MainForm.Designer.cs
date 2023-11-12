using System.Drawing;
using TestTask.BindingItem;
using TestTask.Core.Models.Categories;

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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmImportFromExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaveToExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.materialTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.bindingSourcePage = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourcePageCompanies = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourcePageProducts = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourcePageCategories = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageCategory = new System.Windows.Forms.TabPage();
            this.listViewCategory = new TestTask.Control.PageTabControls.CategoryListView();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
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
            this.tlpProduct = new System.Windows.Forms.TableLayoutPanel();
            this.cmbPageSizeProduct = new System.Windows.Forms.ComboBox();
            this.tlpProductsButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDeleteStep = new System.Windows.Forms.Button();
            this.tlpPagedProduct = new System.Windows.Forms.TableLayoutPanel();
            this.tbCurrentPageProduct = new System.Windows.Forms.TextBox();
            this.btnNextPageProduct = new MaterialSkin.Controls.MaterialButton();
            this.btnBackPageProducts = new MaterialSkin.Controls.MaterialButton();
            this.btnLastPageProduct = new MaterialSkin.Controls.MaterialButton();
            this.btnFirstPageProducts = new MaterialSkin.Controls.MaterialButton();
            this.tabPageCompanies = new System.Windows.Forms.TabPage();
            this.listViewCompany = new TestTask.Control.PageTabControls.CompanyListView();
            this.materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePageCompanies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePageProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePageCategories)).BeginInit();
            this.tabPageCategory.SuspendLayout();
            this.tabPageProduct.SuspendLayout();
            this.tlpListProduct.SuspendLayout();
            this.tlpProduct.SuspendLayout();
            this.tlpProductsButton.SuspendLayout();
            this.tlpPagedProduct.SuspendLayout();
            this.tabPageCompanies.SuspendLayout();
            this.materialTabControl.SuspendLayout();
            this.SuspendLayout();
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
            // bindingSourcePage
            // 
            this.bindingSourcePage.DataSource = typeof(TestTask.BindingItem.PageModel);
            // 
            // bindingSourcePageCompanies
            // 
            this.bindingSourcePageCompanies.DataMember = "Items";
            this.bindingSourcePageCompanies.DataSource = this.bindingSourcePage;
            // 
            // bindingSourcePageProducts
            // 
            this.bindingSourcePageProducts.DataMember = "Items";
            this.bindingSourcePageProducts.DataSource = this.bindingSourcePage;
            // 
            // bindingSourcePageCategories
            // 
            this.bindingSourcePageCategories.DataMember = "Items";
            this.bindingSourcePageCategories.DataSource = this.bindingSourcePage;
            // 
            // tabPageCategory
            // 
            this.tabPageCategory.Controls.Add(this.listViewCategory);
            this.tabPageCategory.Location = new System.Drawing.Point(4, 22);
            this.tabPageCategory.Name = "tabPageCategory";
            this.tabPageCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategory.Size = new System.Drawing.Size(758, 331);
            this.tabPageCategory.TabIndex = 3;
            this.tabPageCategory.Text = "Categories";
            this.tabPageCategory.UseVisualStyleBackColor = true;
            // 
            // listViewCategory
            // 
            this.listViewCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCategory.Location = new System.Drawing.Point(3, 3);
            this.listViewCategory.Name = "listViewCategory";
            this.listViewCategory.Size = new System.Drawing.Size(752, 325);
            this.listViewCategory.TabIndex = 0;
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
            // tabPageCompanies
            // 
            this.tabPageCompanies.Controls.Add(this.listViewCompany);
            this.tabPageCompanies.Location = new System.Drawing.Point(4, 22);
            this.tabPageCompanies.Name = "tabPageCompanies";
            this.tabPageCompanies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompanies.Size = new System.Drawing.Size(758, 331);
            this.tabPageCompanies.TabIndex = 0;
            this.tabPageCompanies.Text = "Companies";
            this.tabPageCompanies.UseVisualStyleBackColor = true;
            // 
            // listViewCompany
            // 
            this.listViewCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCompany.Location = new System.Drawing.Point(3, 3);
            this.listViewCompany.Name = "listViewCompany";
            this.listViewCompany.Size = new System.Drawing.Size(752, 325);
            this.listViewCompany.TabIndex = 1;
            // 
            // materialTabControl
            // 
            this.materialTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl.Controls.Add(this.tabPageCompanies);
            this.materialTabControl.Controls.Add(this.tabPageProduct);
            this.materialTabControl.Controls.Add(this.tabPageCategory);
            this.materialTabControl.Depth = 0;
            this.materialTabControl.Location = new System.Drawing.Point(8, 75);
            this.materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl.Multiline = true;
            this.materialTabControl.Name = "materialTabControl";
            this.materialTabControl.SelectedIndex = 0;
            this.materialTabControl.Size = new System.Drawing.Size(766, 357);
            this.materialTabControl.TabIndex = 5;
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
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePageCompanies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePageProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePageCategories)).EndInit();
            this.tabPageCategory.ResumeLayout(false);
            this.tabPageProduct.ResumeLayout(false);
            this.tlpListProduct.ResumeLayout(false);
            this.tlpProduct.ResumeLayout(false);
            this.tlpProductsButton.ResumeLayout(false);
            this.tlpProductsButton.PerformLayout();
            this.tlpPagedProduct.ResumeLayout(false);
            this.tlpPagedProduct.PerformLayout();
            this.tabPageCompanies.ResumeLayout(false);
            this.materialTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmItemFile;
        private System.Windows.Forms.ToolStripMenuItem tsmItemImport;
        private System.Windows.Forms.ToolStripMenuItem tsmItemClose;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem tsmItemExport;
        private System.Windows.Forms.ToolStripMenuItem tsmImportFromExcel;
        private System.Windows.Forms.ToolStripMenuItem tsmSaveToExcel;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector;
        private System.Windows.Forms.BindingSource pageModelBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.BindingSource bindingSourcePage;
        private System.Windows.Forms.BindingSource bindingSourcePageCompanies;
        private System.Windows.Forms.BindingSource bindingSourcePageProducts;
        private System.Windows.Forms.BindingSource bindingSourcePageCategories;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private System.Windows.Forms.TabPage tabPageCompanies;
        private Control.PageTabControls.CompanyListView listViewCompany;
        private System.Windows.Forms.TabPage tabPageProduct;
        private System.Windows.Forms.TableLayoutPanel tlpProduct;
        private System.Windows.Forms.TableLayoutPanel tlpPagedProduct;
        private MaterialSkin.Controls.MaterialButton btnFirstPageProducts;
        private MaterialSkin.Controls.MaterialButton btnLastPageProduct;
        private MaterialSkin.Controls.MaterialButton btnBackPageProducts;
        private MaterialSkin.Controls.MaterialButton btnNextPageProduct;
        private System.Windows.Forms.TextBox tbCurrentPageProduct;
        private System.Windows.Forms.TableLayoutPanel tlpProductsButton;
        private System.Windows.Forms.Button btnDeleteStep;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.ComboBox cmbPageSizeProduct;
        private System.Windows.Forms.TableLayoutPanel tlpListProduct;
        private MaterialSkin.Controls.MaterialListView listViewProduct;
        private System.Windows.Forms.ColumnHeader columnIDStep;
        private System.Windows.Forms.ColumnHeader columnCompanyName;
        private System.Windows.Forms.ColumnHeader columnCategory;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnDestination;
        private System.Windows.Forms.ColumnHeader columnCompanyId;
        private System.Windows.Forms.ColumnHeader columnCategoryId;
        private System.Windows.Forms.TabPage tabPageCategory;
        private Control.PageTabControls.CategoryListView listViewCategory;
    }
}