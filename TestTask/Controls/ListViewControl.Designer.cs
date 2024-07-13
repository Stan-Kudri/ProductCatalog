namespace TestTask.Controls
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListViewControl));
            itemsBindingSourcePageCategory = new System.Windows.Forms.BindingSource(components);
            pageModelBindingSource = new System.Windows.Forms.BindingSource(components);
            tlpListViewControl = new System.Windows.Forms.TableLayoutPanel();
            listView = new MaterialSkin.Controls.MaterialListView();
            tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            tlpButtonEditItem = new System.Windows.Forms.TableLayoutPanel();
            btnAddItem = new System.Windows.Forms.Button();
            btnEditItem = new System.Windows.Forms.Button();
            btnDeleteItems = new System.Windows.Forms.Button();
            tlpPagedCompanies = new System.Windows.Forms.TableLayoutPanel();
            tbCurrentPage = new System.Windows.Forms.TextBox();
            btnFirstPage = new MaterialSkin.Controls.MaterialButton();
            btnBackPage = new MaterialSkin.Controls.MaterialButton();
            btnNextPage = new MaterialSkin.Controls.MaterialButton();
            btnLastPage = new MaterialSkin.Controls.MaterialButton();
            cmbPageSize = new System.Windows.Forms.ComboBox();
            labelPageSize = new System.Windows.Forms.Label();
            toolTip = new System.Windows.Forms.ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)itemsBindingSourcePageCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pageModelBindingSource).BeginInit();
            tlpListViewControl.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            tlpButtonEditItem.SuspendLayout();
            tlpPagedCompanies.SuspendLayout();
            SuspendLayout();
            // 
            // itemsBindingSourcePageCategory
            // 
            itemsBindingSourcePageCategory.DataMember = "Items";
            itemsBindingSourcePageCategory.DataSource = pageModelBindingSource;
            // 
            // pageModelBindingSource
            // 
            pageModelBindingSource.DataSource = typeof(BindingItem.PageModel);
            // 
            // tlpListViewControl
            // 
            tlpListViewControl.AutoSize = true;
            tlpListViewControl.ColumnCount = 1;
            tlpListViewControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpListViewControl.Controls.Add(listView, 0, 0);
            tlpListViewControl.Controls.Add(tableLayoutPanel, 0, 1);
            tlpListViewControl.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpListViewControl.Location = new System.Drawing.Point(0, 0);
            tlpListViewControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpListViewControl.Name = "tlpListViewControl";
            tlpListViewControl.RowCount = 2;
            tlpListViewControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpListViewControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpListViewControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tlpListViewControl.Size = new System.Drawing.Size(877, 343);
            tlpListViewControl.TabIndex = 1;
            // 
            // listView
            // 
            listView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            listView.AutoSizeTable = false;
            listView.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            listView.Depth = 0;
            listView.Dock = System.Windows.Forms.DockStyle.Fill;
            listView.FullRowSelect = true;
            listView.Location = new System.Drawing.Point(4, 3);
            listView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listView.MinimumSize = new System.Drawing.Size(233, 115);
            listView.MouseLocation = new System.Drawing.Point(-1, -1);
            listView.MouseState = MaterialSkin.MouseState.OUT;
            listView.Name = "listView";
            listView.OwnerDraw = true;
            listView.Size = new System.Drawing.Size(869, 287);
            listView.TabIndex = 21;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = System.Windows.Forms.View.Details;
            listView.SizeChanged += ListView_SizeChanged;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel.ColumnCount = 6;
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            tableLayoutPanel.Controls.Add(tlpButtonEditItem, 5, 0);
            tableLayoutPanel.Controls.Add(tlpPagedCompanies, 3, 0);
            tableLayoutPanel.Controls.Add(cmbPageSize, 1, 0);
            tableLayoutPanel.Controls.Add(labelPageSize, 0, 0);
            tableLayoutPanel.Location = new System.Drawing.Point(4, 296);
            tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            tableLayoutPanel.Size = new System.Drawing.Size(869, 44);
            tableLayoutPanel.TabIndex = 25;
            // 
            // tlpButtonEditItem
            // 
            tlpButtonEditItem.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            tlpButtonEditItem.ColumnCount = 3;
            tlpButtonEditItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tlpButtonEditItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tlpButtonEditItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tlpButtonEditItem.Controls.Add(btnAddItem, 0, 0);
            tlpButtonEditItem.Controls.Add(btnEditItem, 1, 0);
            tlpButtonEditItem.Controls.Add(btnDeleteItems, 2, 0);
            tlpButtonEditItem.Location = new System.Drawing.Point(715, 3);
            tlpButtonEditItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpButtonEditItem.Name = "tlpButtonEditItem";
            tlpButtonEditItem.RowCount = 1;
            tlpButtonEditItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpButtonEditItem.Size = new System.Drawing.Size(150, 38);
            tlpButtonEditItem.TabIndex = 0;
            // 
            // btnAddItem
            // 
            btnAddItem.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnAddItem.AutoSize = true;
            btnAddItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnAddItem.BackColor = System.Drawing.Color.Transparent;
            btnAddItem.FlatAppearance.BorderSize = 0;
            btnAddItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            btnAddItem.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddItem.Image = (System.Drawing.Image)resources.GetObject("btnAddItem.Image");
            btnAddItem.Location = new System.Drawing.Point(1, 1);
            btnAddItem.Margin = new System.Windows.Forms.Padding(1);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new System.Drawing.Size(47, 36);
            btnAddItem.TabIndex = 5;
            toolTip.SetToolTip(btnAddItem, "Add item");
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += BtnAddItem_Click;
            // 
            // btnEditItem
            // 
            btnEditItem.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnEditItem.AutoSize = true;
            btnEditItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnEditItem.FlatAppearance.BorderSize = 0;
            btnEditItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            btnEditItem.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnEditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditItem.Image = (System.Drawing.Image)resources.GetObject("btnEditItem.Image");
            btnEditItem.Location = new System.Drawing.Point(50, 1);
            btnEditItem.Margin = new System.Windows.Forms.Padding(1);
            btnEditItem.Name = "btnEditItem";
            btnEditItem.Size = new System.Drawing.Size(47, 36);
            btnEditItem.TabIndex = 5;
            toolTip.SetToolTip(btnEditItem, "Edit item");
            btnEditItem.UseVisualStyleBackColor = true;
            btnEditItem.Click += BtnEditItem_Click;
            // 
            // btnDeleteItems
            // 
            btnDeleteItems.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnDeleteItems.AutoSize = true;
            btnDeleteItems.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnDeleteItems.BackColor = System.Drawing.Color.Transparent;
            btnDeleteItems.FlatAppearance.BorderSize = 0;
            btnDeleteItems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            btnDeleteItems.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnDeleteItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteItems.Image = (System.Drawing.Image)resources.GetObject("btnDeleteItems.Image");
            btnDeleteItems.Location = new System.Drawing.Point(99, 1);
            btnDeleteItems.Margin = new System.Windows.Forms.Padding(1);
            btnDeleteItems.Name = "btnDeleteItems";
            btnDeleteItems.Size = new System.Drawing.Size(50, 36);
            btnDeleteItems.TabIndex = 7;
            toolTip.SetToolTip(btnDeleteItems, "Remove item(s)");
            btnDeleteItems.UseVisualStyleBackColor = false;
            btnDeleteItems.Click += BtnDeleteItems_Click;
            // 
            // tlpPagedCompanies
            // 
            tlpPagedCompanies.ColumnCount = 5;
            tlpPagedCompanies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlpPagedCompanies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlpPagedCompanies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            tlpPagedCompanies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlpPagedCompanies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlpPagedCompanies.Controls.Add(tbCurrentPage, 2, 0);
            tlpPagedCompanies.Controls.Add(btnFirstPage, 0, 0);
            tlpPagedCompanies.Controls.Add(btnBackPage, 1, 0);
            tlpPagedCompanies.Controls.Add(btnNextPage, 3, 0);
            tlpPagedCompanies.Controls.Add(btnLastPage, 4, 0);
            tlpPagedCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpPagedCompanies.Location = new System.Drawing.Point(351, 3);
            tlpPagedCompanies.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpPagedCompanies.MaximumSize = new System.Drawing.Size(292, 40);
            tlpPagedCompanies.Name = "tlpPagedCompanies";
            tlpPagedCompanies.RowCount = 1;
            tlpPagedCompanies.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpPagedCompanies.Size = new System.Drawing.Size(165, 38);
            tlpPagedCompanies.TabIndex = 10;
            // 
            // tbCurrentPage
            // 
            tbCurrentPage.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbCurrentPage.Location = new System.Drawing.Point(60, 7);
            tbCurrentPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbCurrentPage.Name = "tbCurrentPage";
            tbCurrentPage.Size = new System.Drawing.Size(44, 23);
            tbCurrentPage.TabIndex = 9;
            tbCurrentPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnFirstPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnFirstPage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnFirstPage.Depth = 0;
            btnFirstPage.FlatAppearance.BorderSize = 0;
            btnFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnFirstPage.HighEmphasis = true;
            btnFirstPage.Icon = null;
            btnFirstPage.Location = new System.Drawing.Point(4, 6);
            btnFirstPage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnFirstPage.MouseState = MaterialSkin.MouseState.HOVER;
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.NoAccentTextColor = System.Drawing.Color.Empty;
            btnFirstPage.Size = new System.Drawing.Size(20, 26);
            btnFirstPage.TabIndex = 10;
            btnFirstPage.Text = "<<";
            btnFirstPage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFirstPage.UseAccentColor = false;
            btnFirstPage.UseVisualStyleBackColor = true;
            btnFirstPage.Click += BtnFirstPage_Click;
            // 
            // btnBackPage
            // 
            btnBackPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnBackPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnBackPage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBackPage.Depth = 0;
            btnBackPage.FlatAppearance.BorderSize = 0;
            btnBackPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnBackPage.HighEmphasis = true;
            btnBackPage.Icon = null;
            btnBackPage.Location = new System.Drawing.Point(32, 6);
            btnBackPage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnBackPage.MouseState = MaterialSkin.MouseState.HOVER;
            btnBackPage.Name = "btnBackPage";
            btnBackPage.NoAccentTextColor = System.Drawing.Color.Empty;
            btnBackPage.Size = new System.Drawing.Size(20, 26);
            btnBackPage.TabIndex = 11;
            btnBackPage.Text = "<";
            btnBackPage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBackPage.UseAccentColor = false;
            btnBackPage.UseVisualStyleBackColor = true;
            btnBackPage.Click += BtnBackPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnNextPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnNextPage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNextPage.Depth = 0;
            btnNextPage.FlatAppearance.BorderSize = 0;
            btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnNextPage.HighEmphasis = true;
            btnNextPage.Icon = null;
            btnNextPage.Location = new System.Drawing.Point(112, 6);
            btnNextPage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnNextPage.MouseState = MaterialSkin.MouseState.HOVER;
            btnNextPage.Name = "btnNextPage";
            btnNextPage.NoAccentTextColor = System.Drawing.Color.Empty;
            btnNextPage.Size = new System.Drawing.Size(20, 26);
            btnNextPage.TabIndex = 12;
            btnNextPage.Text = ">";
            btnNextPage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNextPage.UseAccentColor = false;
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += BtnNextPage_Click;
            // 
            // btnLastPage
            // 
            btnLastPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnLastPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnLastPage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLastPage.Depth = 0;
            btnLastPage.FlatAppearance.BorderSize = 0;
            btnLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnLastPage.HighEmphasis = true;
            btnLastPage.Icon = null;
            btnLastPage.Location = new System.Drawing.Point(140, 6);
            btnLastPage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnLastPage.MouseState = MaterialSkin.MouseState.HOVER;
            btnLastPage.Name = "btnLastPage";
            btnLastPage.NoAccentTextColor = System.Drawing.Color.Empty;
            btnLastPage.Size = new System.Drawing.Size(21, 26);
            btnLastPage.TabIndex = 13;
            btnLastPage.Text = ">>";
            btnLastPage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLastPage.UseAccentColor = false;
            btnLastPage.UseVisualStyleBackColor = true;
            btnLastPage.Click += BtnLastPage_Click;
            // 
            // cmbPageSize
            // 
            cmbPageSize.DataSource = itemsBindingSourcePageCategory;
            cmbPageSize.Dock = System.Windows.Forms.DockStyle.Bottom;
            cmbPageSize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmbPageSize.FormattingEnabled = true;
            cmbPageSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            cmbPageSize.Location = new System.Drawing.Point(108, 14);
            cmbPageSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 7);
            cmbPageSize.Name = "cmbPageSize";
            cmbPageSize.Size = new System.Drawing.Size(131, 23);
            cmbPageSize.TabIndex = 17;
            // 
            // labelPageSize
            // 
            labelPageSize.AutoSize = true;
            labelPageSize.Dock = System.Windows.Forms.DockStyle.Fill;
            labelPageSize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelPageSize.Location = new System.Drawing.Point(3, 0);
            labelPageSize.Name = "labelPageSize";
            labelPageSize.Size = new System.Drawing.Size(98, 44);
            labelPageSize.TabIndex = 21;
            labelPageSize.Text = "Show on page";
            labelPageSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListViewControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(tlpListViewControl);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "ListViewControl";
            Size = new System.Drawing.Size(877, 343);
            ((System.ComponentModel.ISupportInitialize)itemsBindingSourcePageCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pageModelBindingSource).EndInit();
            tlpListViewControl.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            tlpButtonEditItem.ResumeLayout(false);
            tlpButtonEditItem.PerformLayout();
            tlpPagedCompanies.ResumeLayout(false);
            tlpPagedCompanies.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        protected System.Windows.Forms.BindingSource itemsBindingSourcePageCategory;
        protected System.Windows.Forms.BindingSource pageModelBindingSource;
        protected System.Windows.Forms.TableLayoutPanel tlpListViewControl;
        protected MaterialSkin.Controls.MaterialListView listView;
        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        protected System.Windows.Forms.TableLayoutPanel tlpButtonEditItem;
        protected System.Windows.Forms.Button btnAddItem;
        protected System.Windows.Forms.Button btnEditItem;
        protected System.Windows.Forms.Button btnDeleteItems;
        protected System.Windows.Forms.ComboBox cmbPageSize;
        protected System.Windows.Forms.TableLayoutPanel tlpPagedCompanies;
        protected System.Windows.Forms.TextBox tbCurrentPage;
        protected System.Windows.Forms.ToolTip toolTip;
        protected MaterialSkin.Controls.MaterialButton btnFirstPage;
        protected MaterialSkin.Controls.MaterialButton btnBackPage;
        protected MaterialSkin.Controls.MaterialButton btnNextPage;
        protected MaterialSkin.Controls.MaterialButton btnLastPage;
        protected System.Windows.Forms.Label labelPageSize;
        private System.ComponentModel.IContainer components;
    }
}
