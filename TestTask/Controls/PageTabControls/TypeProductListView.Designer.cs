namespace TestTask.Controls.PageTabControls
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
            components = new System.ComponentModel.Container();
            CheckComboBox.CheckBoxProperties checkBoxProperties1 = new CheckComboBox.CheckBoxProperties();
            tlpFilter = new System.Windows.Forms.TableLayoutPanel();
            labelTypeSort = new System.Windows.Forms.Label();
            labelSearchName = new System.Windows.Forms.Label();
            buttonClearFilter = new MaterialSkin.Controls.MaterialButton();
            tbSearchStrName = new System.Windows.Forms.TextBox();
            buttonUseFilter = new MaterialSkin.Controls.MaterialButton();
            btnTypeSort = new MaterialSkin.Controls.MaterialButton();
            checkCmbField = new CheckComboBox.CheckBoxComboBox();
            itemsBindingSourceSortType = new System.Windows.Forms.BindingSource(components);
            listView = new ListViewControl();
            tlpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)itemsBindingSourceSortType).BeginInit();
            SuspendLayout();
            // 
            // tlpFilter
            // 
            tlpFilter.ColumnCount = 7;
            tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tlpFilter.Controls.Add(labelTypeSort, 2, 0);
            tlpFilter.Controls.Add(labelSearchName, 0, 0);
            tlpFilter.Controls.Add(buttonClearFilter, 6, 0);
            tlpFilter.Controls.Add(tbSearchStrName, 1, 0);
            tlpFilter.Controls.Add(buttonUseFilter, 5, 0);
            tlpFilter.Controls.Add(btnTypeSort, 4, 0);
            tlpFilter.Controls.Add(checkCmbField, 3, 0);
            tlpFilter.Location = new System.Drawing.Point(1, -1);
            tlpFilter.Margin = new System.Windows.Forms.Padding(1);
            tlpFilter.Name = "tlpFilter";
            tlpFilter.RowCount = 1;
            tlpFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpFilter.Size = new System.Drawing.Size(874, 37);
            tlpFilter.TabIndex = 13;
            // 
            // labelTypeSort
            // 
            labelTypeSort.AutoSize = true;
            labelTypeSort.Dock = System.Windows.Forms.DockStyle.Bottom;
            labelTypeSort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelTypeSort.Location = new System.Drawing.Point(290, 13);
            labelTypeSort.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            labelTypeSort.Name = "labelTypeSort";
            labelTypeSort.Size = new System.Drawing.Size(63, 19);
            labelTypeSort.TabIndex = 17;
            labelTypeSort.Text = "Sort by:";
            labelTypeSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSearchName
            // 
            labelSearchName.AutoSize = true;
            labelSearchName.Dock = System.Windows.Forms.DockStyle.Bottom;
            labelSearchName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelSearchName.Location = new System.Drawing.Point(3, 13);
            labelSearchName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            labelSearchName.Name = "labelSearchName";
            labelSearchName.Size = new System.Drawing.Size(63, 19);
            labelSearchName.TabIndex = 16;
            labelSearchName.Text = "Search";
            labelSearchName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClearFilter
            // 
            buttonClearFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            buttonClearFilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonClearFilter.Depth = 0;
            buttonClearFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
            buttonClearFilter.HighEmphasis = true;
            buttonClearFilter.Icon = null;
            buttonClearFilter.Location = new System.Drawing.Point(770, 7);
            buttonClearFilter.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            buttonClearFilter.MouseState = MaterialSkin.MouseState.HOVER;
            buttonClearFilter.Name = "buttonClearFilter";
            buttonClearFilter.NoAccentTextColor = System.Drawing.Color.Empty;
            buttonClearFilter.Size = new System.Drawing.Size(99, 23);
            buttonClearFilter.TabIndex = 1;
            buttonClearFilter.Text = "Clear Filter";
            buttonClearFilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonClearFilter.UseAccentColor = false;
            buttonClearFilter.UseVisualStyleBackColor = true;
            buttonClearFilter.Click += ButtonClearFilter_Click;
            // 
            // tbSearchStrName
            // 
            tbSearchStrName.Dock = System.Windows.Forms.DockStyle.Bottom;
            tbSearchStrName.Location = new System.Drawing.Point(73, 11);
            tbSearchStrName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbSearchStrName.Name = "tbSearchStrName";
            tbSearchStrName.Size = new System.Drawing.Size(210, 23);
            tbSearchStrName.TabIndex = 3;
            // 
            // buttonUseFilter
            // 
            buttonUseFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            buttonUseFilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonUseFilter.Depth = 0;
            buttonUseFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
            buttonUseFilter.HighEmphasis = true;
            buttonUseFilter.Icon = null;
            buttonUseFilter.Location = new System.Drawing.Point(666, 7);
            buttonUseFilter.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            buttonUseFilter.MouseState = MaterialSkin.MouseState.HOVER;
            buttonUseFilter.Name = "buttonUseFilter";
            buttonUseFilter.NoAccentTextColor = System.Drawing.Color.Empty;
            buttonUseFilter.Size = new System.Drawing.Size(94, 23);
            buttonUseFilter.TabIndex = 4;
            buttonUseFilter.Text = "Use Filter";
            buttonUseFilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonUseFilter.UseAccentColor = false;
            buttonUseFilter.UseVisualStyleBackColor = true;
            buttonUseFilter.Click += ButtonUseFilter_Click;
            // 
            // btnTypeSort
            // 
            btnTypeSort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnTypeSort.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnTypeSort.Depth = 0;
            btnTypeSort.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnTypeSort.HighEmphasis = true;
            btnTypeSort.Icon = null;
            btnTypeSort.Location = new System.Drawing.Point(622, 6);
            btnTypeSort.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnTypeSort.MouseState = MaterialSkin.MouseState.HOVER;
            btnTypeSort.Name = "btnTypeSort";
            btnTypeSort.NoAccentTextColor = System.Drawing.Color.Empty;
            btnTypeSort.Size = new System.Drawing.Size(35, 25);
            btnTypeSort.TabIndex = 19;
            btnTypeSort.Text = "↑";
            btnTypeSort.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTypeSort.UseAccentColor = false;
            btnTypeSort.UseVisualStyleBackColor = true;
            btnTypeSort.Click += BtnTypeSort_Click;
            // 
            // checkCmbField
            // 
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            checkCmbField.CheckBoxProperties = checkBoxProperties1;
            checkCmbField.DisplayMemberSingleItem = "";
            checkCmbField.Dock = System.Windows.Forms.DockStyle.Bottom;
            checkCmbField.FormattingEnabled = true;
            checkCmbField.Location = new System.Drawing.Point(359, 11);
            checkCmbField.Name = "checkCmbField";
            checkCmbField.Size = new System.Drawing.Size(256, 23);
            checkCmbField.TabIndex = 18;
            // 
            // itemsBindingSourceSortType
            // 
            itemsBindingSourceSortType.DataMember = "Items";
            // 
            // listView
            // 
            listView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            listView.AutoSize = true;
            listView.Depth = 0;
            listView.Location = new System.Drawing.Point(0, 39);
            listView.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            listView.MouseState = MaterialSkin.MouseState.HOVER;
            listView.Name = "listView";
            listView.Size = new System.Drawing.Size(877, 343);
            listView.TabIndex = 14;
            listView.SizeChanged += ListView_SizeChanged;
            // 
            // TypeProductListView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(listView);
            Controls.Add(tlpFilter);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "TypeProductListView";
            Size = new System.Drawing.Size(875, 381);
            SizeChanged += ListView_SizeChanged;
            tlpFilter.ResumeLayout(false);
            tlpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)itemsBindingSourceSortType).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListViewControl listView;
        private System.Windows.Forms.TableLayoutPanel tlpFilter;
        private MaterialSkin.Controls.MaterialButton buttonClearFilter;
        private System.Windows.Forms.TextBox tbSearchStrName;
        private MaterialSkin.Controls.MaterialButton buttonUseFilter;
        private System.Windows.Forms.BindingSource itemsBindingSourceSortType;
        private System.Windows.Forms.Label labelTypeSort;
        private System.Windows.Forms.Label labelSearchName;
        private CheckComboBox.CheckBoxComboBox checkCmbField;
        private MaterialSkin.Controls.MaterialButton btnTypeSort;
    }
}
