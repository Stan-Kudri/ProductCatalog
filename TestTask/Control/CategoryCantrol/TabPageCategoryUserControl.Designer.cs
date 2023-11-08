namespace TestTask.Control.CategoryCantrol
{
    partial class TabPageCategoryUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelSort = new System.Windows.Forms.TableLayoutPanel();
            this.cmbSortName = new System.Windows.Forms.ComboBox();
            this.itemsBindingSourceSortNameCategory = new System.Windows.Forms.BindingSource(this.components);
            this.sortPageCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelSortCategory = new MaterialSkin.Controls.MaterialLabel();
            this.cmbFilterCategory = new System.Windows.Forms.ComboBox();
            this.itemsBindingSourceFilterNameCategory = new System.Windows.Forms.BindingSource(this.components);
            this.filterModelCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelFilterCategory = new MaterialSkin.Controls.MaterialLabel();
            this.listViewCategoryControl = new TestTask.Control.CategoryCantrol.ListViewCategoryControl();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanelSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSourceSortNameCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortPageCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSourceFilterNameCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterModelCategoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanelSort, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.listViewCategoryControl, 0, 1);
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(755, 331);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanelSort
            // 
            this.tableLayoutPanelSort.ColumnCount = 4;
            this.tableLayoutPanelSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelSort.Controls.Add(this.cmbSortName, 1, 0);
            this.tableLayoutPanelSort.Controls.Add(this.labelSortCategory, 0, 0);
            this.tableLayoutPanelSort.Controls.Add(this.cmbFilterCategory, 3, 0);
            this.tableLayoutPanelSort.Controls.Add(this.labelFilterCategory, 2, 0);
            this.tableLayoutPanelSort.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelSort.Name = "tableLayoutPanelSort";
            this.tableLayoutPanelSort.RowCount = 1;
            this.tableLayoutPanelSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSort.Size = new System.Drawing.Size(749, 24);
            this.tableLayoutPanelSort.TabIndex = 0;
            // 
            // cmbSortName
            // 
            this.cmbSortName.DataSource = this.itemsBindingSourceSortNameCategory;
            this.cmbSortName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSortName.FormattingEnabled = true;
            this.cmbSortName.Location = new System.Drawing.Point(152, 3);
            this.cmbSortName.Name = "cmbSortName";
            this.cmbSortName.Size = new System.Drawing.Size(218, 21);
            this.cmbSortName.TabIndex = 0;
            this.cmbSortName.SelectedIndexChanged += new System.EventHandler(this.CmbSortName_Changed);
            // 
            // itemsBindingSourceSortNameCategory
            // 
            this.itemsBindingSourceSortNameCategory.DataMember = "Items";
            this.itemsBindingSourceSortNameCategory.DataSource = this.sortPageCategoriesBindingSource;
            // 
            // sortPageCategoriesBindingSource
            // 
            this.sortPageCategoriesBindingSource.DataSource = typeof(TestTask.BindingItem.Pages.Categories.SortPageCategories);
            // 
            // labelSortCategory
            // 
            this.labelSortCategory.AutoSize = true;
            this.labelSortCategory.Depth = 0;
            this.labelSortCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSortCategory.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelSortCategory.Location = new System.Drawing.Point(3, 3);
            this.labelSortCategory.Margin = new System.Windows.Forms.Padding(3);
            this.labelSortCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSortCategory.Name = "labelSortCategory";
            this.labelSortCategory.Size = new System.Drawing.Size(143, 18);
            this.labelSortCategory.TabIndex = 1;
            this.labelSortCategory.Text = "Sort by";
            this.labelSortCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbFilterCategory
            // 
            this.cmbFilterCategory.DataSource = this.itemsBindingSourceFilterNameCategory;
            this.cmbFilterCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilterCategory.FormattingEnabled = true;
            this.cmbFilterCategory.Location = new System.Drawing.Point(525, 3);
            this.cmbFilterCategory.Name = "cmbFilterCategory";
            this.cmbFilterCategory.Size = new System.Drawing.Size(221, 21);
            this.cmbFilterCategory.TabIndex = 2;
            this.cmbFilterCategory.SelectedIndexChanged += new System.EventHandler(this.CmbFilterCategory_Changed);
            // 
            // itemsBindingSourceFilterNameCategory
            // 
            this.itemsBindingSourceFilterNameCategory.DataMember = "Items";
            this.itemsBindingSourceFilterNameCategory.DataSource = this.filterModelCategoriesBindingSource;
            // 
            // filterModelCategoriesBindingSource
            // 
            this.filterModelCategoriesBindingSource.DataSource = typeof(TestTask.BindingItem.Pages.Categories.FilterModelCategories);
            // 
            // labelFilterCategory
            // 
            this.labelFilterCategory.AutoSize = true;
            this.labelFilterCategory.Depth = 0;
            this.labelFilterCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFilterCategory.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelFilterCategory.Location = new System.Drawing.Point(376, 0);
            this.labelFilterCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFilterCategory.Name = "labelFilterCategory";
            this.labelFilterCategory.Size = new System.Drawing.Size(143, 24);
            this.labelFilterCategory.TabIndex = 3;
            this.labelFilterCategory.Text = "Filter by name";
            this.labelFilterCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewCategoryControl
            // 
            this.listViewCategoryControl.Depth = 0;
            this.listViewCategoryControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCategoryControl.Location = new System.Drawing.Point(3, 33);
            this.listViewCategoryControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.listViewCategoryControl.Name = "listViewCategoryControl";
            this.listViewCategoryControl.Size = new System.Drawing.Size(749, 295);
            this.listViewCategoryControl.TabIndex = 1;
            // 
            // TabPageCategoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "TabPageCategoryUserControl";
            this.Size = new System.Drawing.Size(755, 331);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanelSort.ResumeLayout(false);
            this.tableLayoutPanelSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSourceSortNameCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortPageCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSourceFilterNameCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterModelCategoriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSort;
        private System.Windows.Forms.ComboBox cmbSortName;
        private ListViewCategoryControl listViewCategoryControl;
        private MaterialSkin.Controls.MaterialLabel labelSortCategory;
        private System.Windows.Forms.ComboBox cmbFilterCategory;
        private MaterialSkin.Controls.MaterialLabel labelFilterCategory;
        private System.Windows.Forms.BindingSource sortPageCategoriesBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSourceSortNameCategory;
        private System.Windows.Forms.BindingSource itemsBindingSourceFilterNameCategory;
        private System.Windows.Forms.BindingSource filterModelCategoriesBindingSource;
    }
}
