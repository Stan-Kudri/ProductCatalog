namespace TestTask.Control.CategoryCantrol
{
    partial class ListViewCategoryControl
    {

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListViewCategoryControl));
            this.listView = new MaterialSkin.Controls.MaterialListView();
            this.columnIDCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCategoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tlpPageButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnFirstPage = new MaterialSkin.Controls.MaterialButton();
            this.btnLastPage = new MaterialSkin.Controls.MaterialButton();
            this.btnBackPage = new MaterialSkin.Controls.MaterialButton();
            this.tbCurrentPage = new System.Windows.Forms.TextBox();
            this.btnNextPage = new MaterialSkin.Controls.MaterialButton();
            this.cmbPageSize = new System.Windows.Forms.ComboBox();
            this.itemsBindingSourcePageCategory = new System.Windows.Forms.BindingSource(this.components);
            this.pageModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tlpCompaniesButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteItems = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.tlpPageButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSourcePageCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageModelBindingSource)).BeginInit();
            this.tlpCompaniesButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.AutoSizeTable = false;
            this.listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIDCategory,
            this.columnCategoryName});
            this.listView.Depth = 0;
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.MinimumSize = new System.Drawing.Size(200, 100);
            this.listView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listView.MouseState = MaterialSkin.MouseState.OUT;
            this.listView.Name = "listView";
            this.listView.OwnerDraw = true;
            this.listView.Size = new System.Drawing.Size(755, 270);
            this.listView.TabIndex = 6;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SizeChanged += new System.EventHandler(this.ListView_SizeChanged);
            // 
            // columnIDCategory
            // 
            this.columnIDCategory.Tag = "200";
            this.columnIDCategory.Text = "ID";
            this.columnIDCategory.Width = 200;
            // 
            // columnCategoryName
            // 
            this.columnCategoryName.Tag = "555";
            this.columnCategoryName.Text = "Name";
            this.columnCategoryName.Width = 555;
            // 
            // tlpPageButton
            // 
            this.tlpPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPageButton.ColumnCount = 5;
            this.tlpPageButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPageButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPageButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPageButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPageButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPageButton.Controls.Add(this.btnFirstPage, 0, 0);
            this.tlpPageButton.Controls.Add(this.btnLastPage, 4, 0);
            this.tlpPageButton.Controls.Add(this.btnBackPage, 1, 0);
            this.tlpPageButton.Controls.Add(this.tbCurrentPage, 2, 0);
            this.tlpPageButton.Controls.Add(this.btnNextPage, 3, 0);
            this.tlpPageButton.Location = new System.Drawing.Point(250, 270);
            this.tlpPageButton.Name = "tlpPageButton";
            this.tlpPageButton.RowCount = 1;
            this.tlpPageButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPageButton.Size = new System.Drawing.Size(255, 30);
            this.tlpPageButton.TabIndex = 7;
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirstPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFirstPage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFirstPage.Depth = 0;
            this.btnFirstPage.HighEmphasis = true;
            this.btnFirstPage.Icon = null;
            this.btnFirstPage.Location = new System.Drawing.Point(4, 6);
            this.btnFirstPage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFirstPage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFirstPage.Size = new System.Drawing.Size(45, 18);
            this.btnFirstPage.TabIndex = 5;
            this.btnFirstPage.Text = "<<";
            this.btnFirstPage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFirstPage.UseAccentColor = false;
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.BtnFirstPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLastPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLastPage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLastPage.Depth = 0;
            this.btnLastPage.HighEmphasis = true;
            this.btnLastPage.Icon = null;
            this.btnLastPage.Location = new System.Drawing.Point(203, 6);
            this.btnLastPage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLastPage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLastPage.Size = new System.Drawing.Size(48, 18);
            this.btnLastPage.TabIndex = 6;
            this.btnLastPage.Text = ">>";
            this.btnLastPage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLastPage.UseAccentColor = false;
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.BtnLastPage_Click);
            // 
            // btnBackPage
            // 
            this.btnBackPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBackPage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBackPage.Depth = 0;
            this.btnBackPage.HighEmphasis = true;
            this.btnBackPage.Icon = null;
            this.btnBackPage.Location = new System.Drawing.Point(57, 6);
            this.btnBackPage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBackPage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBackPage.Name = "btnBackPage";
            this.btnBackPage.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBackPage.Size = new System.Drawing.Size(45, 18);
            this.btnBackPage.TabIndex = 7;
            this.btnBackPage.Text = "<";
            this.btnBackPage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBackPage.UseAccentColor = false;
            this.btnBackPage.UseVisualStyleBackColor = true;
            this.btnBackPage.Click += new System.EventHandler(this.BtnBackPage_Click);
            // 
            // tbCurrentPage
            // 
            this.tbCurrentPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCurrentPage.Location = new System.Drawing.Point(109, 5);
            this.tbCurrentPage.Name = "tbCurrentPage";
            this.tbCurrentPage.Size = new System.Drawing.Size(34, 20);
            this.tbCurrentPage.TabIndex = 9;
            this.tbCurrentPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCurrentPage.TextChanged += new System.EventHandler(this.TbCurrentPage_TextChanged);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNextPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNextPage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNextPage.Depth = 0;
            this.btnNextPage.HighEmphasis = true;
            this.btnNextPage.Icon = null;
            this.btnNextPage.Location = new System.Drawing.Point(150, 6);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNextPage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNextPage.Size = new System.Drawing.Size(45, 18);
            this.btnNextPage.TabIndex = 8;
            this.btnNextPage.Text = ">";
            this.btnNextPage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNextPage.UseAccentColor = false;
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.BtnNextPage_Click);
            // 
            // cmbPageSize
            // 
            this.cmbPageSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbPageSize.DataSource = this.itemsBindingSourcePageCategory;
            this.cmbPageSize.FormattingEnabled = true;
            this.cmbPageSize.Location = new System.Drawing.Point(0, 280);
            this.cmbPageSize.Name = "cmbPageSize";
            this.cmbPageSize.Size = new System.Drawing.Size(121, 21);
            this.cmbPageSize.TabIndex = 11;
            this.cmbPageSize.SelectedIndexChanged += new System.EventHandler(this.CmbPageSize_Changed);
            // 
            // itemsBindingSourcePageCategory
            // 
            this.itemsBindingSourcePageCategory.DataMember = "Items";
            this.itemsBindingSourcePageCategory.DataSource = this.pageModelBindingSource;
            // 
            // pageModelBindingSource
            // 
            this.pageModelBindingSource.DataSource = typeof(TestTask.BindingItem.PageModel);
            // 
            // tlpCompaniesButton
            // 
            this.tlpCompaniesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCompaniesButton.ColumnCount = 3;
            this.tlpCompaniesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCompaniesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCompaniesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCompaniesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCompaniesButton.Controls.Add(this.btnDeleteItems, 2, 0);
            this.tlpCompaniesButton.Controls.Add(this.btnEditItem, 1, 0);
            this.tlpCompaniesButton.Controls.Add(this.btnAddItem, 0, 0);
            this.tlpCompaniesButton.ForeColor = System.Drawing.Color.Transparent;
            this.tlpCompaniesButton.Location = new System.Drawing.Point(645, 272);
            this.tlpCompaniesButton.Margin = new System.Windows.Forms.Padding(1);
            this.tlpCompaniesButton.Name = "tlpCompaniesButton";
            this.tlpCompaniesButton.RowCount = 1;
            this.tlpCompaniesButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCompaniesButton.Size = new System.Drawing.Size(110, 29);
            this.tlpCompaniesButton.TabIndex = 12;
            // 
            // btnDeleteItems
            // 
            this.btnDeleteItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteItems.AutoSize = true;
            this.btnDeleteItems.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteItems.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteItems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDeleteItems.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDeleteItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItems.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteItems.Image")));
            this.btnDeleteItems.Location = new System.Drawing.Point(72, 0);
            this.btnDeleteItems.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteItems.Name = "btnDeleteItems";
            this.btnDeleteItems.Size = new System.Drawing.Size(38, 29);
            this.btnDeleteItems.TabIndex = 7;
            this.btnDeleteItems.UseVisualStyleBackColor = false;
            this.btnDeleteItems.Click += new System.EventHandler(this.BtnDeleteItems_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditItem.AutoSize = true;
            this.btnEditItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEditItem.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditItem.Image = ((System.Drawing.Image)(resources.GetObject("btnEditItem.Image")));
            this.btnEditItem.Location = new System.Drawing.Point(36, 0);
            this.btnEditItem.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(36, 29);
            this.btnEditItem.TabIndex = 5;
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.BtnEditItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.AutoSize = true;
            this.btnAddItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddItem.BackColor = System.Drawing.Color.Transparent;
            this.btnAddItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAddItem.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItem.Image")));
            this.btnAddItem.Location = new System.Drawing.Point(0, 0);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(36, 29);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // ListViewCategoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpCompaniesButton);
            this.Controls.Add(this.cmbPageSize);
            this.Controls.Add(this.tlpPageButton);
            this.Controls.Add(this.listView);
            this.Name = "ListViewCategoryControl";
            this.Size = new System.Drawing.Size(755, 301);
            this.tlpPageButton.ResumeLayout(false);
            this.tlpPageButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSourcePageCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageModelBindingSource)).EndInit();
            this.tlpCompaniesButton.ResumeLayout(false);
            this.tlpCompaniesButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected MaterialSkin.Controls.MaterialListView listView;
        protected System.Windows.Forms.TableLayoutPanel tlpPageButton;
        protected System.Windows.Forms.ComboBox cmbPageSize;
        protected System.Windows.Forms.TableLayoutPanel tlpCompaniesButton;
        protected System.Windows.Forms.Button btnDeleteItems;
        protected System.Windows.Forms.Button btnEditItem;
        protected System.Windows.Forms.Button btnAddItem;
        protected MaterialSkin.Controls.MaterialButton btnFirstPage;
        protected MaterialSkin.Controls.MaterialButton btnLastPage;
        protected MaterialSkin.Controls.MaterialButton btnBackPage;
        protected System.Windows.Forms.TextBox tbCurrentPage;
        protected MaterialSkin.Controls.MaterialButton btnNextPage;
        protected System.Windows.Forms.BindingSource itemsBindingSourcePageCategory;
        protected System.Windows.Forms.BindingSource pageModelBindingSource;
        protected System.ComponentModel.IContainer components;
        protected System.Windows.Forms.ColumnHeader columnIDCategory;
        protected System.Windows.Forms.ColumnHeader columnCategoryName;
    }
}
