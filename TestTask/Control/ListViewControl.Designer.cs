namespace TestTask.Control
{
    partial class ListViewControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListViewControl));
            this.itemsBindingSourcePageCategory = new System.Windows.Forms.BindingSource(this.components);
            this.pageModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tlpListViewControl = new System.Windows.Forms.TableLayoutPanel();
            this.listView = new MaterialSkin.Controls.MaterialListView();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelSizePage = new MaterialSkin.Controls.MaterialLabel();
            this.tlpButtonEditItem = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.btnDeleteItems = new System.Windows.Forms.Button();
            this.tlpPagedCompanies = new System.Windows.Forms.TableLayoutPanel();
            this.btnBackPage = new MaterialSkin.Controls.MaterialButton();
            this.btnLastPage = new MaterialSkin.Controls.MaterialButton();
            this.btnFirstPage = new MaterialSkin.Controls.MaterialButton();
            this.btnNextPage = new MaterialSkin.Controls.MaterialButton();
            this.tbCurrentPage = new System.Windows.Forms.TextBox();
            this.cmbPageSize = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSourcePageCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageModelBindingSource)).BeginInit();
            this.tlpListViewControl.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.tlpButtonEditItem.SuspendLayout();
            this.tlpPagedCompanies.SuspendLayout();
            this.SuspendLayout();
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
            // tlpListViewControl
            // 
            this.tlpListViewControl.AutoSize = true;
            this.tlpListViewControl.ColumnCount = 1;
            this.tlpListViewControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpListViewControl.Controls.Add(this.listView, 0, 0);
            this.tlpListViewControl.Controls.Add(this.tableLayoutPanel, 0, 1);
            this.tlpListViewControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpListViewControl.Location = new System.Drawing.Point(0, 0);
            this.tlpListViewControl.Name = "tlpListViewControl";
            this.tlpListViewControl.RowCount = 2;
            this.tlpListViewControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpListViewControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpListViewControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpListViewControl.Size = new System.Drawing.Size(751, 297);
            this.tlpListViewControl.TabIndex = 1;
            // 
            // listView
            // 
            this.listView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listView.AutoSizeTable = false;
            this.listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Depth = 0;
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(3, 3);
            this.listView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listView.MouseState = MaterialSkin.MouseState.OUT;
            this.listView.Name = "listView";
            this.listView.OwnerDraw = true;
            this.listView.Size = new System.Drawing.Size(745, 247);
            this.listView.TabIndex = 21;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 6;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel.Controls.Add(this.labelSizePage, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.tlpButtonEditItem, 5, 0);
            this.tableLayoutPanel.Controls.Add(this.tlpPagedCompanies, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.cmbPageSize, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 256);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(745, 38);
            this.tableLayoutPanel.TabIndex = 25;
            // 
            // labelSizePage
            // 
            this.labelSizePage.AutoSize = true;
            this.labelSizePage.Depth = 0;
            this.labelSizePage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSizePage.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelSizePage.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.labelSizePage.Location = new System.Drawing.Point(92, 15);
            this.labelSizePage.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.labelSizePage.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSizePage.Name = "labelSizePage";
            this.labelSizePage.Size = new System.Drawing.Size(113, 17);
            this.labelSizePage.TabIndex = 18;
            this.labelSizePage.Text = "Show on page";
            this.labelSizePage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpButtonEditItem
            // 
            this.tlpButtonEditItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpButtonEditItem.ColumnCount = 3;
            this.tlpButtonEditItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtonEditItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtonEditItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtonEditItem.Controls.Add(this.btnAddItem, 0, 0);
            this.tlpButtonEditItem.Controls.Add(this.btnEditItem, 1, 0);
            this.tlpButtonEditItem.Controls.Add(this.btnDeleteItems, 2, 0);
            this.tlpButtonEditItem.Location = new System.Drawing.Point(612, 3);
            this.tlpButtonEditItem.Name = "tlpButtonEditItem";
            this.tlpButtonEditItem.RowCount = 1;
            this.tlpButtonEditItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtonEditItem.Size = new System.Drawing.Size(130, 32);
            this.tlpButtonEditItem.TabIndex = 0;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.AutoSize = true;
            this.btnAddItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddItem.BackColor = System.Drawing.Color.Transparent;
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAddItem.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItem.Image")));
            this.btnAddItem.Location = new System.Drawing.Point(1, 1);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(41, 30);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditItem.AutoSize = true;
            this.btnEditItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditItem.FlatAppearance.BorderSize = 0;
            this.btnEditItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEditItem.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditItem.Image = ((System.Drawing.Image)(resources.GetObject("btnEditItem.Image")));
            this.btnEditItem.Location = new System.Drawing.Point(44, 1);
            this.btnEditItem.Margin = new System.Windows.Forms.Padding(1);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(41, 30);
            this.btnEditItem.TabIndex = 5;
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.BtnEditItem_Click);
            // 
            // btnDeleteItems
            // 
            this.btnDeleteItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteItems.AutoSize = true;
            this.btnDeleteItems.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteItems.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteItems.FlatAppearance.BorderSize = 0;
            this.btnDeleteItems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDeleteItems.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDeleteItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItems.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteItems.Image")));
            this.btnDeleteItems.Location = new System.Drawing.Point(87, 1);
            this.btnDeleteItems.Margin = new System.Windows.Forms.Padding(1);
            this.btnDeleteItems.Name = "btnDeleteItems";
            this.btnDeleteItems.Size = new System.Drawing.Size(42, 30);
            this.btnDeleteItems.TabIndex = 7;
            this.btnDeleteItems.UseVisualStyleBackColor = false;
            this.btnDeleteItems.Click += new System.EventHandler(this.BtnDeleteItems_Click);
            // 
            // tlpPagedCompanies
            // 
            this.tlpPagedCompanies.ColumnCount = 5;
            this.tlpPagedCompanies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPagedCompanies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPagedCompanies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPagedCompanies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPagedCompanies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPagedCompanies.Controls.Add(this.btnBackPage, 1, 0);
            this.tlpPagedCompanies.Controls.Add(this.btnLastPage, 4, 0);
            this.tlpPagedCompanies.Controls.Add(this.btnFirstPage, 0, 0);
            this.tlpPagedCompanies.Controls.Add(this.btnNextPage, 3, 0);
            this.tlpPagedCompanies.Controls.Add(this.tbCurrentPage, 2, 0);
            this.tlpPagedCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPagedCompanies.Location = new System.Drawing.Point(300, 3);
            this.tlpPagedCompanies.MaximumSize = new System.Drawing.Size(250, 35);
            this.tlpPagedCompanies.Name = "tlpPagedCompanies";
            this.tlpPagedCompanies.RowCount = 1;
            this.tlpPagedCompanies.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagedCompanies.Size = new System.Drawing.Size(143, 32);
            this.tlpPagedCompanies.TabIndex = 10;
            // 
            // btnBackPage
            // 
            this.btnBackPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBackPage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBackPage.Depth = 0;
            this.btnBackPage.HighEmphasis = true;
            this.btnBackPage.Icon = null;
            this.btnBackPage.Location = new System.Drawing.Point(29, 6);
            this.btnBackPage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBackPage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBackPage.Name = "btnBackPage";
            this.btnBackPage.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBackPage.Size = new System.Drawing.Size(17, 20);
            this.btnBackPage.TabIndex = 7;
            this.btnBackPage.Text = "<";
            this.btnBackPage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBackPage.UseAccentColor = false;
            this.btnBackPage.UseVisualStyleBackColor = true;
            // 
            // btnLastPage
            // 
            this.btnLastPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLastPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLastPage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLastPage.Depth = 0;
            this.btnLastPage.HighEmphasis = true;
            this.btnLastPage.Icon = null;
            this.btnLastPage.Location = new System.Drawing.Point(119, 6);
            this.btnLastPage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLastPage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLastPage.Size = new System.Drawing.Size(20, 20);
            this.btnLastPage.TabIndex = 6;
            this.btnLastPage.Text = ">>";
            this.btnLastPage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLastPage.UseAccentColor = false;
            this.btnLastPage.UseVisualStyleBackColor = true;
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
            this.btnFirstPage.Size = new System.Drawing.Size(17, 20);
            this.btnFirstPage.TabIndex = 5;
            this.btnFirstPage.Text = "<<";
            this.btnFirstPage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFirstPage.UseAccentColor = false;
            this.btnFirstPage.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNextPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNextPage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNextPage.Depth = 0;
            this.btnNextPage.HighEmphasis = true;
            this.btnNextPage.Icon = null;
            this.btnNextPage.Location = new System.Drawing.Point(94, 6);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNextPage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNextPage.Size = new System.Drawing.Size(17, 20);
            this.btnNextPage.TabIndex = 8;
            this.btnNextPage.Text = ">";
            this.btnNextPage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNextPage.UseAccentColor = false;
            this.btnNextPage.UseVisualStyleBackColor = true;
            // 
            // tbCurrentPage
            // 
            this.tbCurrentPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCurrentPage.Location = new System.Drawing.Point(53, 6);
            this.tbCurrentPage.Name = "tbCurrentPage";
            this.tbCurrentPage.Size = new System.Drawing.Size(34, 20);
            this.tbCurrentPage.TabIndex = 9;
            this.tbCurrentPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbPageSize
            // 
            this.cmbPageSize.DataSource = this.itemsBindingSourcePageCategory;
            this.cmbPageSize.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbPageSize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbPageSize.FormattingEnabled = true;
            this.cmbPageSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbPageSize.Location = new System.Drawing.Point(3, 11);
            this.cmbPageSize.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.cmbPageSize.Name = "cmbPageSize";
            this.cmbPageSize.Size = new System.Drawing.Size(83, 21);
            this.cmbPageSize.TabIndex = 17;
            // 
            // ListViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tlpListViewControl);
            this.Name = "ListViewControl";
            this.Size = new System.Drawing.Size(751, 297);
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSourcePageCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageModelBindingSource)).EndInit();
            this.tlpListViewControl.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tlpButtonEditItem.ResumeLayout(false);
            this.tlpButtonEditItem.PerformLayout();
            this.tlpPagedCompanies.ResumeLayout(false);
            this.tlpPagedCompanies.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.BindingSource itemsBindingSourcePageCategory;
        protected System.Windows.Forms.BindingSource pageModelBindingSource;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.TableLayoutPanel tlpListViewControl;
        protected MaterialSkin.Controls.MaterialListView listView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private MaterialSkin.Controls.MaterialLabel labelSizePage;
        private System.Windows.Forms.TableLayoutPanel tlpButtonEditItem;
        protected System.Windows.Forms.Button btnAddItem;
        protected System.Windows.Forms.Button btnEditItem;
        protected System.Windows.Forms.Button btnDeleteItems;
        protected System.Windows.Forms.ComboBox cmbPageSize;
        private System.Windows.Forms.TableLayoutPanel tlpPagedCompanies;
        protected MaterialSkin.Controls.MaterialButton btnBackPage;
        protected MaterialSkin.Controls.MaterialButton btnLastPage;
        protected MaterialSkin.Controls.MaterialButton btnFirstPage;
        protected MaterialSkin.Controls.MaterialButton btnNextPage;
        protected System.Windows.Forms.TextBox tbCurrentPage;
    }
}
