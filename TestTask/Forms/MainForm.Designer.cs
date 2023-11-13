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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmImportFromExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaveToExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.materialTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageCompanies = new System.Windows.Forms.TabPage();
            this.listViewCompany = new TestTask.Control.PageTabControls.CompanyListView();
            this.bindingSourcePage = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourcePageProducts = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageCategory = new System.Windows.Forms.TabPage();
            this.listViewCategory = new TestTask.Control.PageTabControls.CategoryListView();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.listViewProduct = new TestTask.Control.PageTabControls.ProductListView();
            this.bindingSourcePageCompanies = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourcePageCategories = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageCompanies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePageProducts)).BeginInit();
            this.tabPageCategory.SuspendLayout();
            this.tabPageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePageCompanies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePageCategories)).BeginInit();
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
            this.materialTabSelector.BaseTabControl = this.tabControl;
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
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageCompanies);
            this.tabControl.Controls.Add(this.tabPageCategory);
            this.tabControl.Controls.Add(this.tabPageProduct);
            this.tabControl.Depth = 0;
            this.tabControl.Location = new System.Drawing.Point(8, 75);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(766, 357);
            this.tabControl.TabIndex = 5;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_Changed);
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
            // bindingSourcePage
            // 
            this.bindingSourcePage.DataSource = typeof(TestTask.BindingItem.PageModel);
            // 
            // bindingSourcePageProducts
            // 
            this.bindingSourcePageProducts.DataMember = "Items";
            this.bindingSourcePageProducts.DataSource = this.bindingSourcePage;
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
            this.tabPageProduct.Controls.Add(this.listViewProduct);
            this.tabPageProduct.Location = new System.Drawing.Point(4, 22);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduct.Size = new System.Drawing.Size(758, 331);
            this.tabPageProduct.TabIndex = 4;
            this.tabPageProduct.Text = "Products";
            this.tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // listViewProduct
            // 
            this.listViewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewProduct.Location = new System.Drawing.Point(3, 3);
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.Size = new System.Drawing.Size(752, 325);
            this.listViewProduct.TabIndex = 0;
            // 
            // bindingSourcePageCompanies
            // 
            this.bindingSourcePageCompanies.DataMember = "Items";
            this.bindingSourcePageCompanies.DataSource = this.bindingSourcePage;
            // 
            // bindingSourcePageCategories
            // 
            this.bindingSourcePageCategories.DataMember = "Items";
            this.bindingSourcePageCategories.DataSource = this.bindingSourcePage;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 435);
            this.Controls.Add(this.materialTabSelector);
            this.Controls.Add(this.tabControl);
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
            this.tabControl.ResumeLayout(false);
            this.tabPageCompanies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePageProducts)).EndInit();
            this.tabPageCategory.ResumeLayout(false);
            this.tabPageProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePageCompanies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePageCategories)).EndInit();
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
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage tabPageCompanies;
        private Control.PageTabControls.CompanyListView listViewCompany;
        private System.Windows.Forms.TabPage tabPageCategory;
        private Control.PageTabControls.CategoryListView listViewCategory;
        private System.Windows.Forms.TabPage tabPageProduct;
        private Control.PageTabControls.ProductListView listViewProduct;
    }
}