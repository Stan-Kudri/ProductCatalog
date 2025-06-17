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
            components = new System.ComponentModel.Container();
            menuStrip = new System.Windows.Forms.MenuStrip();
            tsmItemFile = new System.Windows.Forms.ToolStripMenuItem();
            tsmItemImport = new System.Windows.Forms.ToolStripMenuItem();
            tsmImportFromExcel = new System.Windows.Forms.ToolStripMenuItem();
            tsmItemExport = new System.Windows.Forms.ToolStripMenuItem();
            tsmSaveToExcel = new System.Windows.Forms.ToolStripMenuItem();
            tsmItemClose = new System.Windows.Forms.ToolStripMenuItem();
            toolTip = new System.Windows.Forms.ToolTip(components);
            materialTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            tabControl = new MaterialSkin.Controls.MaterialTabControl();
            tabPageCompanies = new System.Windows.Forms.TabPage();
            listViewCompany = new TestTask.Controls.PageTabControls.CompanyListView();
            tabPageCategory = new System.Windows.Forms.TabPage();
            listViewCategory = new TestTask.Controls.PageTabControls.CategoryListView();
            tabPageTypeProduct = new System.Windows.Forms.TabPage();
            listViewTypeProduct = new TestTask.Controls.PageTabControls.TypeProductListView();
            tabPageProducts = new System.Windows.Forms.TabPage();
            listViewProduct = new TestTask.Controls.PageTabControls.ProductListView();
            bindingSourcePage = new System.Windows.Forms.BindingSource(components);
            bindingSourcePageProducts = new System.Windows.Forms.BindingSource(components);
            bindingSourcePageCompanies = new System.Windows.Forms.BindingSource(components);
            bindingSourcePageCategories = new System.Windows.Forms.BindingSource(components);
            menuStrip.SuspendLayout();
            tabControl.SuspendLayout();
            tabPageCompanies.SuspendLayout();
            tabPageCategory.SuspendLayout();
            tabPageTypeProduct.SuspendLayout();
            tabPageProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePageProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePageCompanies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePageCategories).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.Transparent;
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmItemFile });
            menuStrip.Location = new Point(4, 28);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(902, 24);
            menuStrip.TabIndex = 3;
            menuStrip.Text = "menuStrip";
            // 
            // tsmItemFile
            // 
            tsmItemFile.BackColor = Color.Transparent;
            tsmItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmItemImport, tsmItemExport, tsmItemClose });
            tsmItemFile.Name = "tsmItemFile";
            tsmItemFile.Size = new Size(37, 20);
            tsmItemFile.Text = "File";
            // 
            // tsmItemImport
            // 
            tsmItemImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmImportFromExcel });
            tsmItemImport.Name = "tsmItemImport";
            tsmItemImport.Size = new Size(139, 22);
            tsmItemImport.Text = "Import from";
            // 
            // tsmImportFromExcel
            // 
            tsmImportFromExcel.Name = "tsmImportFromExcel";
            tsmImportFromExcel.Size = new Size(101, 22);
            tsmImportFromExcel.Text = "Excel";
            tsmImportFromExcel.Click += TsmImportFromExcel_Click;
            // 
            // tsmItemExport
            // 
            tsmItemExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmSaveToExcel });
            tsmItemExport.Name = "tsmItemExport";
            tsmItemExport.Size = new Size(139, 22);
            tsmItemExport.Text = "Export to";
            // 
            // tsmSaveToExcel
            // 
            tsmSaveToExcel.Name = "tsmSaveToExcel";
            tsmSaveToExcel.Size = new Size(101, 22);
            tsmSaveToExcel.Text = "Excel";
            tsmSaveToExcel.Click += TsmItemSaveExcel_Click;
            // 
            // tsmItemClose
            // 
            tsmItemClose.Name = "tsmItemClose";
            tsmItemClose.Size = new Size(139, 22);
            tsmItemClose.Text = "Close";
            tsmItemClose.Click += TsmItemClose_Click;
            // 
            // materialTabSelector
            // 
            materialTabSelector.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            materialTabSelector.BackColor = SystemColors.ActiveCaption;
            materialTabSelector.BaseTabControl = tabControl;
            materialTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            materialTabSelector.Depth = 0;
            materialTabSelector.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTabSelector.Location = new Point(9, 59);
            materialTabSelector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            materialTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabSelector.Name = "materialTabSelector";
            materialTabSelector.Size = new Size(889, 24);
            materialTabSelector.TabIndex = 6;
            materialTabSelector.Text = "TabSelector";
            // 
            // tabControl
            // 
            tabControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabControl.Controls.Add(tabPageCompanies);
            tabControl.Controls.Add(tabPageCategory);
            tabControl.Controls.Add(tabPageTypeProduct);
            tabControl.Controls.Add(tabPageProducts);
            tabControl.Depth = 0;
            tabControl.Location = new Point(9, 87);
            tabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            tabControl.Multiline = true;
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(894, 412);
            tabControl.TabIndex = 5;
            tabControl.SelectedIndexChanged += TabControl_Changed;
            // 
            // tabPageCompanies
            // 
            tabPageCompanies.Controls.Add(listViewCompany);
            tabPageCompanies.Location = new Point(4, 24);
            tabPageCompanies.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPageCompanies.Name = "tabPageCompanies";
            tabPageCompanies.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPageCompanies.Size = new Size(886, 384);
            tabPageCompanies.TabIndex = 0;
            tabPageCompanies.Text = "Companies";
            tabPageCompanies.UseVisualStyleBackColor = true;
            // 
            // listViewCompany
            // 
            listViewCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewCompany.Location = new Point(4, 3);
            listViewCompany.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            listViewCompany.Name = "listViewCompany";
            listViewCompany.Size = new Size(878, 378);
            listViewCompany.TabIndex = 1;
            // 
            // tabPageCategory
            // 
            tabPageCategory.Controls.Add(listViewCategory);
            tabPageCategory.Location = new Point(4, 24);
            tabPageCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPageCategory.Name = "tabPageCategory";
            tabPageCategory.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPageCategory.Size = new Size(886, 384);
            tabPageCategory.TabIndex = 3;
            tabPageCategory.Text = "Categories";
            tabPageCategory.UseVisualStyleBackColor = true;
            // 
            // listViewCategory
            // 
            listViewCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewCategory.Location = new Point(4, 3);
            listViewCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listViewCategory.Name = "listViewCategory";
            listViewCategory.Size = new Size(878, 378);
            listViewCategory.TabIndex = 0;
            // 
            // tabPageTypeProduct
            // 
            tabPageTypeProduct.Controls.Add(listViewTypeProduct);
            tabPageTypeProduct.Location = new Point(4, 24);
            tabPageTypeProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPageTypeProduct.Name = "tabPageTypeProduct";
            tabPageTypeProduct.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPageTypeProduct.Size = new Size(886, 384);
            tabPageTypeProduct.TabIndex = 5;
            tabPageTypeProduct.Text = "Types";
            tabPageTypeProduct.UseVisualStyleBackColor = true;
            // 
            // listViewTypeProduct
            // 
            listViewTypeProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewTypeProduct.Location = new Point(4, 3);
            listViewTypeProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listViewTypeProduct.Name = "listViewTypeProduct";
            listViewTypeProduct.Size = new Size(878, 378);
            listViewTypeProduct.TabIndex = 0;
            // 
            // tabPageProducts
            // 
            tabPageProducts.Controls.Add(listViewProduct);
            tabPageProducts.Location = new Point(4, 24);
            tabPageProducts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPageProducts.Name = "tabPageProducts";
            tabPageProducts.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPageProducts.Size = new Size(886, 384);
            tabPageProducts.TabIndex = 6;
            tabPageProducts.Text = "Products";
            tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // listViewProduct
            // 
            listViewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewProduct.Location = new Point(4, 3);
            listViewProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listViewProduct.Name = "listViewProduct";
            listViewProduct.Size = new Size(878, 378);
            listViewProduct.TabIndex = 0;
            // 
            // bindingSourcePage
            // 
            bindingSourcePage.DataSource = typeof(PageModel);
            // 
            // bindingSourcePageProducts
            // 
            bindingSourcePageProducts.DataMember = "Items";
            bindingSourcePageProducts.DataSource = bindingSourcePage;
            // 
            // bindingSourcePageCompanies
            // 
            bindingSourcePageCompanies.DataMember = "Items";
            bindingSourcePageCompanies.DataSource = bindingSourcePage;
            // 
            // bindingSourcePageCategories
            // 
            bindingSourcePageCategories.DataMember = "Items";
            bindingSourcePageCategories.DataSource = bindingSourcePage;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new Size(910, 502);
            Controls.Add(materialTabSelector);
            Controls.Add(tabControl);
            Controls.Add(menuStrip);
            FormStyle = FormStyles.ActionBar_None;
            MainMenuStrip = menuStrip;
            Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            Name = "MainForm";
            Padding = new System.Windows.Forms.Padding(4, 28, 4, 3);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Table";
            FormClosing += TableForm_FormClosing;
            Load += TableForm_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPageCompanies.ResumeLayout(false);
            tabPageCategory.ResumeLayout(false);
            tabPageTypeProduct.ResumeLayout(false);
            tabPageProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSourcePage).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePageProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePageCompanies).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePageCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage tabPageCompanies;
        private System.Windows.Forms.TabPage tabPageCategory;
        private System.Windows.Forms.TabPage tabPageTypeProduct;
        private System.Windows.Forms.TabPage tabPageProducts;
        private Controls.PageTabControls.CompanyListView listViewCompany;
        private Controls.PageTabControls.CategoryListView listViewCategory;
        private Controls.PageTabControls.TypeProductListView listViewTypeProduct;
        private Controls.PageTabControls.ProductListView listViewProduct;
    }
}
