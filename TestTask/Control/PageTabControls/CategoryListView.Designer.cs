using TestTask.BindingItem.Pages;

namespace TestTask.Control.PageTabControls
{
    partial class CategoryListView
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
            tlpFilter = new System.Windows.Forms.TableLayoutPanel();
            labelSearchName = new System.Windows.Forms.Label();
            buttonClearFilter = new MaterialSkin.Controls.MaterialButton();
            tbSearchStrName = new System.Windows.Forms.TextBox();
            buttonUseFilter = new MaterialSkin.Controls.MaterialButton();
            cmbSortName = new System.Windows.Forms.ComboBox();
            itemsBindingSourceSortName = new System.Windows.Forms.BindingSource(components);
            sortPageCategoriesBindingSource = new System.Windows.Forms.BindingSource(components);
            listView = new ListViewControl();
            labelSortName = new System.Windows.Forms.Label();
            tlpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)itemsBindingSourceSortName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sortPageCategoriesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tlpFilter
            // 
            tlpFilter.ColumnCount = 6;
            tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tlpFilter.Controls.Add(labelSortName, 2, 0);
            tlpFilter.Controls.Add(labelSearchName, 0, 0);
            tlpFilter.Controls.Add(buttonClearFilter, 5, 0);
            tlpFilter.Controls.Add(tbSearchStrName, 1, 0);
            tlpFilter.Controls.Add(buttonUseFilter, 4, 0);
            tlpFilter.Controls.Add(cmbSortName, 3, 0);
            tlpFilter.Location = new System.Drawing.Point(1, -1);
            tlpFilter.Margin = new System.Windows.Forms.Padding(1);
            tlpFilter.Name = "tlpFilter";
            tlpFilter.RowCount = 1;
            tlpFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpFilter.Size = new System.Drawing.Size(874, 37);
            tlpFilter.TabIndex = 7;
            // 
            // labelSearchName
            // 
            labelSearchName.AutoSize = true;
            labelSearchName.Dock = System.Windows.Forms.DockStyle.Bottom;
            labelSearchName.Font = new System.Drawing.Font("Times New Roman", 12F);
            labelSearchName.Location = new System.Drawing.Point(3, 13);
            labelSearchName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            labelSearchName.Name = "labelSearchName";
            labelSearchName.Size = new System.Drawing.Size(125, 19);
            labelSearchName.TabIndex = 9;
            labelSearchName.Text = "Search name";
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
            buttonClearFilter.Location = new System.Drawing.Point(746, 7);
            buttonClearFilter.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            buttonClearFilter.MouseState = MaterialSkin.MouseState.HOVER;
            buttonClearFilter.Name = "buttonClearFilter";
            buttonClearFilter.NoAccentTextColor = System.Drawing.Color.Empty;
            buttonClearFilter.Size = new System.Drawing.Size(123, 23);
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
            tbSearchStrName.Location = new System.Drawing.Point(135, 11);
            tbSearchStrName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbSearchStrName.Name = "tbSearchStrName";
            tbSearchStrName.Size = new System.Drawing.Size(166, 23);
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
            buttonUseFilter.Location = new System.Drawing.Point(615, 7);
            buttonUseFilter.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            buttonUseFilter.MouseState = MaterialSkin.MouseState.HOVER;
            buttonUseFilter.Name = "buttonUseFilter";
            buttonUseFilter.NoAccentTextColor = System.Drawing.Color.Empty;
            buttonUseFilter.Size = new System.Drawing.Size(121, 23);
            buttonUseFilter.TabIndex = 4;
            buttonUseFilter.Text = "Use Filter";
            buttonUseFilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonUseFilter.UseAccentColor = false;
            buttonUseFilter.UseVisualStyleBackColor = true;
            buttonUseFilter.Click += ButtonUseFilter_Click;
            // 
            // cmbSortName
            // 
            cmbSortName.DataSource = itemsBindingSourceSortName;
            cmbSortName.Dock = System.Windows.Forms.DockStyle.Bottom;
            cmbSortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbSortName.FormattingEnabled = true;
            cmbSortName.Location = new System.Drawing.Point(440, 11);
            cmbSortName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbSortName.Name = "cmbSortName";
            cmbSortName.Size = new System.Drawing.Size(166, 23);
            cmbSortName.TabIndex = 5;
            cmbSortName.SelectedIndexChanged += CmbSortName_Changed;
            // 
            // itemsBindingSourceSortName
            // 
            itemsBindingSourceSortName.DataMember = "Items";
            itemsBindingSourceSortName.DataSource = sortPageCategoriesBindingSource;
            // 
            // sortPageCategoriesBindingSource
            // 
            sortPageCategoriesBindingSource.DataSource = typeof(TypeSortField);
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
            listView.TabIndex = 8;
            listView.SizeChanged += ListView_SizeChanged;
            // 
            // labelSortName
            // 
            labelSortName.AutoSize = true;
            labelSortName.Dock = System.Windows.Forms.DockStyle.Bottom;
            labelSortName.Font = new System.Drawing.Font("Times New Roman", 12F);
            labelSortName.Location = new System.Drawing.Point(308, 13);
            labelSortName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            labelSortName.Name = "labelSortName";
            labelSortName.Size = new System.Drawing.Size(125, 19);
            labelSortName.TabIndex = 9;
            labelSortName.Text = "Sort name by";
            labelSortName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CategoryListView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(listView);
            Controls.Add(tlpFilter);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "CategoryListView";
            Size = new System.Drawing.Size(875, 381);
            tlpFilter.ResumeLayout(false);
            tlpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)itemsBindingSourceSortName).EndInit();
            ((System.ComponentModel.ISupportInitialize)sortPageCategoriesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpFilter;
        private MaterialSkin.Controls.MaterialButton buttonClearFilter;
        private System.Windows.Forms.TextBox tbSearchStrName;
        private ListViewControl listView;
        private System.Windows.Forms.ComboBox cmbSortName;
        private System.Windows.Forms.BindingSource itemsBindingSourceSortName;
        private System.Windows.Forms.BindingSource sortPageCategoriesBindingSource;
        private MaterialSkin.Controls.MaterialButton buttonUseFilter;
        private System.Windows.Forms.Label labelSearchName;
        private System.Windows.Forms.Label labelSortName;
    }
}
