namespace TestTask.Control.PageTabControls
{
    partial class TypeProductListView
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
            this.tlpFilter = new System.Windows.Forms.TableLayoutPanel();
            this.labelSortField = new MaterialSkin.Controls.MaterialLabel();
            this.buttonClearFilter = new MaterialSkin.Controls.MaterialButton();
            this.labelSearchName = new MaterialSkin.Controls.MaterialLabel();
            this.tbSearchStrName = new System.Windows.Forms.TextBox();
            this.buttonUseFilter = new MaterialSkin.Controls.MaterialButton();
            this.cmbSortField = new System.Windows.Forms.ComboBox();
            this.sortTypeProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTypeSort = new System.Windows.Forms.ComboBox();
            this.itemsBindingSourceSortType = new System.Windows.Forms.BindingSource(this.components);
            this.typeSortFieldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelTypeSort = new MaterialSkin.Controls.MaterialLabel();
            this.listView = new TestTask.Control.ListViewControl();
            this.tlpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortTypeProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSourceSortType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSortFieldBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpFilter
            // 
            this.tlpFilter.ColumnCount = 8;
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tlpFilter.Controls.Add(this.labelSortField, 4, 0);
            this.tlpFilter.Controls.Add(this.buttonClearFilter, 7, 0);
            this.tlpFilter.Controls.Add(this.labelSearchName, 0, 0);
            this.tlpFilter.Controls.Add(this.tbSearchStrName, 1, 0);
            this.tlpFilter.Controls.Add(this.buttonUseFilter, 6, 0);
            this.tlpFilter.Controls.Add(this.cmbSortField, 5, 0);
            this.tlpFilter.Controls.Add(this.cmbTypeSort, 3, 0);
            this.tlpFilter.Controls.Add(this.labelTypeSort, 2, 0);
            this.tlpFilter.Location = new System.Drawing.Point(1, -1);
            this.tlpFilter.Margin = new System.Windows.Forms.Padding(1);
            this.tlpFilter.Name = "tlpFilter";
            this.tlpFilter.RowCount = 1;
            this.tlpFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilter.Size = new System.Drawing.Size(749, 32);
            this.tlpFilter.TabIndex = 13;
            // 
            // labelSortField
            // 
            this.labelSortField.AutoSize = true;
            this.labelSortField.Depth = 0;
            this.labelSortField.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSortField.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelSortField.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.labelSortField.Location = new System.Drawing.Point(360, 12);
            this.labelSortField.Margin = new System.Windows.Forms.Padding(3);
            this.labelSortField.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSortField.Name = "labelSortField";
            this.labelSortField.Size = new System.Drawing.Size(68, 17);
            this.labelSortField.TabIndex = 6;
            this.labelSortField.Text = "Field:";
            this.labelSortField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClearFilter
            // 
            this.buttonClearFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonClearFilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonClearFilter.Depth = 0;
            this.buttonClearFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonClearFilter.HighEmphasis = true;
            this.buttonClearFilter.Icon = null;
            this.buttonClearFilter.Location = new System.Drawing.Point(651, 6);
            this.buttonClearFilter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonClearFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonClearFilter.Name = "buttonClearFilter";
            this.buttonClearFilter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonClearFilter.Size = new System.Drawing.Size(94, 20);
            this.buttonClearFilter.TabIndex = 1;
            this.buttonClearFilter.Text = "Clear Filter";
            this.buttonClearFilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonClearFilter.UseAccentColor = false;
            this.buttonClearFilter.UseVisualStyleBackColor = true;
            this.buttonClearFilter.Click += new System.EventHandler(this.ButtonClearFilter_Click);
            // 
            // labelSearchName
            // 
            this.labelSearchName.AutoSize = true;
            this.labelSearchName.Depth = 0;
            this.labelSearchName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSearchName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelSearchName.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.labelSearchName.Location = new System.Drawing.Point(3, 12);
            this.labelSearchName.Margin = new System.Windows.Forms.Padding(3);
            this.labelSearchName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSearchName.Name = "labelSearchName";
            this.labelSearchName.Size = new System.Drawing.Size(83, 17);
            this.labelSearchName.TabIndex = 2;
            this.labelSearchName.Text = "Search name";
            this.labelSearchName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSearchStrName
            // 
            this.tbSearchStrName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbSearchStrName.Location = new System.Drawing.Point(92, 9);
            this.tbSearchStrName.Name = "tbSearchStrName";
            this.tbSearchStrName.Size = new System.Drawing.Size(83, 20);
            this.tbSearchStrName.TabIndex = 3;
            // 
            // buttonUseFilter
            // 
            this.buttonUseFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonUseFilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonUseFilter.Depth = 0;
            this.buttonUseFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonUseFilter.HighEmphasis = true;
            this.buttonUseFilter.Icon = null;
            this.buttonUseFilter.Location = new System.Drawing.Point(554, 6);
            this.buttonUseFilter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonUseFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonUseFilter.Name = "buttonUseFilter";
            this.buttonUseFilter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonUseFilter.Size = new System.Drawing.Size(89, 20);
            this.buttonUseFilter.TabIndex = 4;
            this.buttonUseFilter.Text = "Use Filter";
            this.buttonUseFilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonUseFilter.UseAccentColor = false;
            this.buttonUseFilter.UseVisualStyleBackColor = true;
            this.buttonUseFilter.Click += new System.EventHandler(this.ButtonUseFilter_Click);
            // 
            // cmbSortField
            // 
            this.cmbSortField.DataSource = this.sortTypeProductBindingSource;
            this.cmbSortField.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbSortField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSortField.FormattingEnabled = true;
            this.cmbSortField.Location = new System.Drawing.Point(434, 8);
            this.cmbSortField.Name = "cmbSortField";
            this.cmbSortField.Size = new System.Drawing.Size(113, 21);
            this.cmbSortField.TabIndex = 5;
            this.cmbSortField.SelectedIndexChanged += new System.EventHandler(this.CmbSortField_Changed);
            // 
            // sortTypeProductBindingSource
            // 
            this.sortTypeProductBindingSource.DataSource = typeof(TestTask.BindingItem.Pages.TypeProduct.SortTypeProduct);
            // 
            // cmbTypeSort
            // 
            this.cmbTypeSort.DataSource = this.itemsBindingSourceSortType;
            this.cmbTypeSort.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbTypeSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeSort.FormattingEnabled = true;
            this.cmbTypeSort.Location = new System.Drawing.Point(248, 8);
            this.cmbTypeSort.Name = "cmbTypeSort";
            this.cmbTypeSort.Size = new System.Drawing.Size(106, 21);
            this.cmbTypeSort.TabIndex = 10;
            this.cmbTypeSort.SelectedIndexChanged += new System.EventHandler(this.CmbTypeSort_Changed);
            // 
            // itemsBindingSourceSortType
            // 
            this.itemsBindingSourceSortType.DataMember = "Items";
            this.itemsBindingSourceSortType.DataSource = this.typeSortFieldBindingSource;
            // 
            // typeSortFieldBindingSource
            // 
            this.typeSortFieldBindingSource.DataSource = typeof(TestTask.BindingItem.Pages.TypeSortField);
            // 
            // labelTypeSort
            // 
            this.labelTypeSort.AutoSize = true;
            this.labelTypeSort.Depth = 0;
            this.labelTypeSort.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelTypeSort.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelTypeSort.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.labelTypeSort.Location = new System.Drawing.Point(181, 12);
            this.labelTypeSort.Margin = new System.Windows.Forms.Padding(3);
            this.labelTypeSort.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTypeSort.Name = "labelTypeSort";
            this.labelTypeSort.Size = new System.Drawing.Size(61, 17);
            this.labelTypeSort.TabIndex = 9;
            this.labelTypeSort.Text = "Sort by:";
            this.labelTypeSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.AutoSize = true;
            this.listView.Depth = 0;
            this.listView.Location = new System.Drawing.Point(0, 34);
            this.listView.MouseState = MaterialSkin.MouseState.HOVER;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(751, 297);
            this.listView.TabIndex = 14;
            // 
            // TypeProductListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView);
            this.Controls.Add(this.tlpFilter);
            this.Name = "TypeProductListView";
            this.Size = new System.Drawing.Size(750, 330);
            this.SizeChanged += new System.EventHandler(this.ListView_SizeChanged);
            this.tlpFilter.ResumeLayout(false);
            this.tlpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortTypeProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSourceSortType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSortFieldBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListViewControl listView;
        private System.Windows.Forms.TableLayoutPanel tlpFilter;
        private MaterialSkin.Controls.MaterialLabel labelSortField;
        private MaterialSkin.Controls.MaterialButton buttonClearFilter;
        private MaterialSkin.Controls.MaterialLabel labelSearchName;
        private System.Windows.Forms.TextBox tbSearchStrName;
        private MaterialSkin.Controls.MaterialButton buttonUseFilter;
        private System.Windows.Forms.ComboBox cmbSortField;
        private System.Windows.Forms.BindingSource sortTypeProductBindingSource;
        private System.Windows.Forms.ComboBox cmbTypeSort;
        private MaterialSkin.Controls.MaterialLabel labelTypeSort;
        private System.Windows.Forms.BindingSource itemsBindingSourceSortType;
        private System.Windows.Forms.BindingSource typeSortFieldBindingSource;
    }
}
