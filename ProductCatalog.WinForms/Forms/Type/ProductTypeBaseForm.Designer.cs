namespace ProductCatalog.Forms.Type
{
    partial class ProductTypeBaseForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tlpField = new System.Windows.Forms.TableLayoutPanel();
            cmbListCategory = new MaterialSkin.Controls.MaterialComboBox();
            categoryBindingSource = new System.Windows.Forms.BindingSource(components);
            selectCategoryBindingSource = new System.Windows.Forms.BindingSource(components);
            tbName = new MaterialSkin.Controls.MaterialTextBox2();
            itemsBindingSource = new System.Windows.Forms.BindingSource(components);
            tlpButton = new System.Windows.Forms.TableLayoutPanel();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            btnClose = new MaterialSkin.Controls.MaterialButton();
            btnClear = new MaterialSkin.Controls.MaterialButton();
            tlpField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selectCategoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemsBindingSource).BeginInit();
            tlpButton.SuspendLayout();
            SuspendLayout();
            // 
            // tlpField
            // 
            tlpField.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tlpField.ColumnCount = 1;
            tlpField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpField.Controls.Add(cmbListCategory, 0, 0);
            tlpField.Controls.Add(tbName, 0, 1);
            tlpField.Location = new System.Drawing.Point(6, 81);
            tlpField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpField.Name = "tlpField";
            tlpField.RowCount = 2;
            tlpField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tlpField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tlpField.Size = new System.Drawing.Size(280, 115);
            tlpField.TabIndex = 0;
            // 
            // cmbListCategory
            // 
            cmbListCategory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbListCategory.AutoResize = false;
            cmbListCategory.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            cmbListCategory.DataSource = categoryBindingSource;
            cmbListCategory.Depth = 0;
            cmbListCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            cmbListCategory.DropDownHeight = 174;
            cmbListCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbListCategory.DropDownWidth = 121;
            cmbListCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            cmbListCategory.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            cmbListCategory.FormattingEnabled = true;
            cmbListCategory.IntegralHeight = false;
            cmbListCategory.ItemHeight = 43;
            cmbListCategory.Location = new System.Drawing.Point(4, 3);
            cmbListCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbListCategory.MaxDropDownItems = 4;
            cmbListCategory.MouseState = MaterialSkin.MouseState.OUT;
            cmbListCategory.Name = "cmbListCategory";
            cmbListCategory.Size = new System.Drawing.Size(272, 49);
            cmbListCategory.StartIndex = 0;
            cmbListCategory.TabIndex = 0;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataMember = "Items";
            categoryBindingSource.DataSource = selectCategoryBindingSource;
            // 
            // selectCategoryBindingSource
            // 
            selectCategoryBindingSource.DataSource = typeof(BindingItem.ObservableCollection.SelectCategory);
            // 
            // tbName
            // 
            tbName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbName.AnimateReadOnly = false;
            tbName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tbName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            tbName.DataBindings.Add(new System.Windows.Forms.Binding("Text", itemsBindingSource, "Name", true));
            tbName.Depth = 0;
            tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            tbName.HideSelection = true;
            tbName.Hint = "Name";
            tbName.LeadingIcon = null;
            tbName.Location = new System.Drawing.Point(4, 60);
            tbName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbName.MaxLength = 32767;
            tbName.MouseState = MaterialSkin.MouseState.OUT;
            tbName.Name = "tbName";
            tbName.PasswordChar = '\0';
            tbName.PrefixSuffixText = null;
            tbName.ReadOnly = false;
            tbName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            tbName.SelectedText = "";
            tbName.SelectionLength = 0;
            tbName.SelectionStart = 0;
            tbName.ShortcutsEnabled = true;
            tbName.Size = new System.Drawing.Size(272, 48);
            tbName.TabIndex = 1;
            tbName.TabStop = false;
            tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            tbName.TrailingIcon = null;
            tbName.UseSystemPasswordChar = false;
            // 
            // itemsBindingSource
            // 
            itemsBindingSource.DataMember = "Items";
            itemsBindingSource.DataSource = selectCategoryBindingSource;
            // 
            // tlpButton
            // 
            tlpButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tlpButton.ColumnCount = 3;
            tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tlpButton.Controls.Add(btnSave, 0, 0);
            tlpButton.Controls.Add(btnClose, 2, 0);
            tlpButton.Controls.Add(btnClear, 1, 0);
            tlpButton.Location = new System.Drawing.Point(6, 202);
            tlpButton.Margin = new System.Windows.Forms.Padding(0);
            tlpButton.Name = "tlpButton";
            tlpButton.RowCount = 1;
            tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpButton.Size = new System.Drawing.Size(280, 52);
            tlpButton.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new System.Drawing.Point(5, 7);
            btnSave.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            btnSave.Size = new System.Drawing.Size(83, 38);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnClose
            // 
            btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClose.Depth = 0;
            btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            btnClose.HighEmphasis = true;
            btnClose.Icon = null;
            btnClose.Location = new System.Drawing.Point(191, 7);
            btnClose.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            btnClose.Name = "btnClose";
            btnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            btnClose.Size = new System.Drawing.Size(84, 38);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnClose.UseAccentColor = false;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += BtnClose_Click;
            // 
            // btnClear
            // 
            btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClear.Depth = 0;
            btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            btnClear.HighEmphasis = true;
            btnClear.Icon = null;
            btnClear.Location = new System.Drawing.Point(98, 7);
            btnClear.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            btnClear.Name = "btnClear";
            btnClear.NoAccentTextColor = System.Drawing.Color.Empty;
            btnClear.Size = new System.Drawing.Size(83, 38);
            btnClear.TabIndex = 4;
            btnClear.Text = "Default Value";
            btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnClear.UseAccentColor = false;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // ProductTypeBaseForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(292, 260);
            Controls.Add(tlpButton);
            Controls.Add(tlpField);
            Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            MinimumSize = new System.Drawing.Size(260, 260);
            Name = "ProductTypeBaseForm";
            Padding = new System.Windows.Forms.Padding(5, 85, 5, 3);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Product Type";
            Load += TypeBaseForm_Load;
            tlpField.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)selectCategoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemsBindingSource).EndInit();
            tlpButton.ResumeLayout(false);
            tlpButton.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TableLayoutPanel tlpField;
        protected System.Windows.Forms.TableLayoutPanel tlpButton;
        protected MaterialSkin.Controls.MaterialButton btnSave;
        protected MaterialSkin.Controls.MaterialButton btnClose;
        protected MaterialSkin.Controls.MaterialButton btnClear;
        protected MaterialSkin.Controls.MaterialComboBox cmbListCategory;
        protected MaterialSkin.Controls.MaterialTextBox2 tbName;
        protected System.Windows.Forms.BindingSource itemsBindingSource;
        protected System.Windows.Forms.BindingSource selectCategoryBindingSource;
        protected System.Windows.Forms.BindingSource categoryBindingSource;
        private new System.ComponentModel.IContainer components;
    }
}
