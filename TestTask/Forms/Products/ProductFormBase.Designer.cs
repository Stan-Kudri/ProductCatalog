using TestTask.BindingItem.ObservableCollection;

namespace TestTask.Forms.Products
{
    partial class ProductFormBase
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
            cmbCompanyValue = new MaterialSkin.Controls.MaterialComboBox();
            itemsBindingSourceCompany = new System.Windows.Forms.BindingSource(components);
            companyBindingSource = new System.Windows.Forms.BindingSource(components);
            tlpProductData = new System.Windows.Forms.TableLayoutPanel();
            tbPrice = new MaterialSkin.Controls.MaterialTextBox2();
            productModelBindingSource = new System.Windows.Forms.BindingSource(components);
            tbDestination = new MaterialSkin.Controls.MaterialTextBox2();
            cmbCategoryValue = new MaterialSkin.Controls.MaterialComboBox();
            itemsBindingSourceCategory = new System.Windows.Forms.BindingSource(components);
            categoryBindingSource = new System.Windows.Forms.BindingSource(components);
            cmbTypeValue = new MaterialSkin.Controls.MaterialComboBox();
            itemsBindingSourceTypes = new System.Windows.Forms.BindingSource(components);
            typeBindingSource = new System.Windows.Forms.BindingSource(components);
            tbName = new MaterialSkin.Controls.MaterialTextBox2();
            tlpProductButton = new System.Windows.Forms.TableLayoutPanel();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            btnClear = new MaterialSkin.Controls.MaterialButton();
            btnClose = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)itemsBindingSourceCompany).BeginInit();
            ((System.ComponentModel.ISupportInitialize)companyBindingSource).BeginInit();
            tlpProductData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemsBindingSourceCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemsBindingSourceTypes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)typeBindingSource).BeginInit();
            tlpProductButton.SuspendLayout();
            SuspendLayout();
            // 
            // cmbCompanyValue
            // 
            cmbCompanyValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbCompanyValue.AutoResize = false;
            cmbCompanyValue.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            cmbCompanyValue.DataSource = itemsBindingSourceCompany;
            cmbCompanyValue.Depth = 0;
            cmbCompanyValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            cmbCompanyValue.DropDownHeight = 174;
            cmbCompanyValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCompanyValue.DropDownWidth = 121;
            cmbCompanyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            cmbCompanyValue.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            cmbCompanyValue.FormattingEnabled = true;
            cmbCompanyValue.IntegralHeight = false;
            cmbCompanyValue.ItemHeight = 43;
            cmbCompanyValue.Location = new System.Drawing.Point(4, 57);
            cmbCompanyValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cmbCompanyValue.MaxDropDownItems = 4;
            cmbCompanyValue.MouseState = MaterialSkin.MouseState.OUT;
            cmbCompanyValue.Name = "cmbCompanyValue";
            cmbCompanyValue.Size = new System.Drawing.Size(342, 49);
            cmbCompanyValue.StartIndex = 0;
            cmbCompanyValue.TabIndex = 1;
            // 
            // itemsBindingSourceCompany
            // 
            itemsBindingSourceCompany.DataMember = "Items";
            itemsBindingSourceCompany.DataSource = companyBindingSource;
            // 
            // companyBindingSource
            // 
            companyBindingSource.DataSource = typeof(SelectCompany);
            // 
            // tlpProductData
            // 
            tlpProductData.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tlpProductData.ColumnCount = 1;
            tlpProductData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpProductData.Controls.Add(cmbCompanyValue, 0, 1);
            tlpProductData.Controls.Add(tbPrice, 0, 4);
            tlpProductData.Controls.Add(tbDestination, 0, 5);
            tlpProductData.Controls.Add(cmbCategoryValue, 0, 2);
            tlpProductData.Controls.Add(cmbTypeValue, 0, 3);
            tlpProductData.Controls.Add(tbName, 0, 0);
            tlpProductData.Location = new System.Drawing.Point(5, 80);
            tlpProductData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpProductData.MinimumSize = new System.Drawing.Size(350, 288);
            tlpProductData.Name = "tlpProductData";
            tlpProductData.RowCount = 6;
            tlpProductData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tlpProductData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tlpProductData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tlpProductData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tlpProductData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tlpProductData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tlpProductData.Size = new System.Drawing.Size(350, 346);
            tlpProductData.TabIndex = 2;
            // 
            // tbPrice
            // 
            tbPrice.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbPrice.AnimateReadOnly = false;
            tbPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tbPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            tbPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", productModelBindingSource, "Price", true));
            tbPrice.Depth = 0;
            tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            tbPrice.HideSelection = true;
            tbPrice.Hint = "Price";
            tbPrice.LeadingIcon = null;
            tbPrice.Location = new System.Drawing.Point(4, 231);
            tbPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbPrice.MaxLength = 32767;
            tbPrice.MouseState = MaterialSkin.MouseState.OUT;
            tbPrice.Name = "tbPrice";
            tbPrice.PasswordChar = '\0';
            tbPrice.PrefixSuffixText = null;
            tbPrice.ReadOnly = false;
            tbPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            tbPrice.SelectedText = "";
            tbPrice.SelectionLength = 0;
            tbPrice.SelectionStart = 0;
            tbPrice.ShortcutsEnabled = true;
            tbPrice.Size = new System.Drawing.Size(342, 48);
            tbPrice.TabIndex = 3;
            tbPrice.TabStop = false;
            tbPrice.Text = "0";
            tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            tbPrice.TrailingIcon = null;
            tbPrice.UseSystemPasswordChar = false;
            tbPrice.KeyPress += TbPrice_KeyPress;
            // 
            // productModelBindingSource
            // 
            productModelBindingSource.DataSource = typeof(BindingItem.ProductModel);
            // 
            // tbDestination
            // 
            tbDestination.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbDestination.AnimateReadOnly = false;
            tbDestination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tbDestination.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            tbDestination.DataBindings.Add(new System.Windows.Forms.Binding("Text", productModelBindingSource, "Destination", true));
            tbDestination.Depth = 0;
            tbDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            tbDestination.HideSelection = true;
            tbDestination.Hint = "Destination";
            tbDestination.LeadingIcon = null;
            tbDestination.Location = new System.Drawing.Point(4, 288);
            tbDestination.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbDestination.MaxLength = 32767;
            tbDestination.MouseState = MaterialSkin.MouseState.OUT;
            tbDestination.Name = "tbDestination";
            tbDestination.PasswordChar = '\0';
            tbDestination.PrefixSuffixText = null;
            tbDestination.ReadOnly = false;
            tbDestination.RightToLeft = System.Windows.Forms.RightToLeft.No;
            tbDestination.SelectedText = "";
            tbDestination.SelectionLength = 0;
            tbDestination.SelectionStart = 0;
            tbDestination.ShortcutsEnabled = true;
            tbDestination.Size = new System.Drawing.Size(342, 48);
            tbDestination.TabIndex = 4;
            tbDestination.TabStop = false;
            tbDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            tbDestination.TrailingIcon = null;
            tbDestination.UseSystemPasswordChar = false;
            // 
            // cmbCategoryValue
            // 
            cmbCategoryValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbCategoryValue.AutoResize = false;
            cmbCategoryValue.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            cmbCategoryValue.DataSource = itemsBindingSourceCategory;
            cmbCategoryValue.Depth = 0;
            cmbCategoryValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            cmbCategoryValue.DropDownHeight = 174;
            cmbCategoryValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCategoryValue.DropDownWidth = 121;
            cmbCategoryValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            cmbCategoryValue.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            cmbCategoryValue.FormattingEnabled = true;
            cmbCategoryValue.IntegralHeight = false;
            cmbCategoryValue.ItemHeight = 43;
            cmbCategoryValue.Location = new System.Drawing.Point(4, 117);
            cmbCategoryValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbCategoryValue.MaxDropDownItems = 4;
            cmbCategoryValue.MouseState = MaterialSkin.MouseState.OUT;
            cmbCategoryValue.Name = "cmbCategoryValue";
            cmbCategoryValue.Size = new System.Drawing.Size(342, 49);
            cmbCategoryValue.StartIndex = 0;
            cmbCategoryValue.TabIndex = 5;
            cmbCategoryValue.SelectedIndexChanged += CmbCategoryValue_Changed;
            // 
            // itemsBindingSourceCategory
            // 
            itemsBindingSourceCategory.DataMember = "Items";
            itemsBindingSourceCategory.DataSource = categoryBindingSource;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(SelectCategory);
            // 
            // cmbTypeValue
            // 
            cmbTypeValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbTypeValue.AutoResize = false;
            cmbTypeValue.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            cmbTypeValue.DataSource = itemsBindingSourceTypes;
            cmbTypeValue.Depth = 0;
            cmbTypeValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            cmbTypeValue.DropDownHeight = 174;
            cmbTypeValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbTypeValue.DropDownWidth = 121;
            cmbTypeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            cmbTypeValue.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            cmbTypeValue.FormattingEnabled = true;
            cmbTypeValue.IntegralHeight = false;
            cmbTypeValue.ItemHeight = 43;
            cmbTypeValue.Location = new System.Drawing.Point(4, 174);
            cmbTypeValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbTypeValue.MaxDropDownItems = 4;
            cmbTypeValue.MouseState = MaterialSkin.MouseState.OUT;
            cmbTypeValue.Name = "cmbTypeValue";
            cmbTypeValue.Size = new System.Drawing.Size(342, 49);
            cmbTypeValue.StartIndex = 0;
            cmbTypeValue.TabIndex = 6;
            // 
            // itemsBindingSourceTypes
            // 
            itemsBindingSourceTypes.DataMember = "Items";
            itemsBindingSourceTypes.DataSource = typeBindingSource;
            // 
            // typeBindingSource
            // 
            typeBindingSource.DataSource = typeof(SelectType);
            // 
            // tbName
            // 
            tbName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbName.AnimateReadOnly = false;
            tbName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tbName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            tbName.DataBindings.Add(new System.Windows.Forms.Binding("Text", productModelBindingSource, "Name", true));
            tbName.Depth = 0;
            tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            tbName.HideSelection = true;
            tbName.Hint = "Name";
            tbName.LeadingIcon = null;
            tbName.Location = new System.Drawing.Point(4, 3);
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
            tbName.Size = new System.Drawing.Size(342, 48);
            tbName.TabIndex = 7;
            tbName.TabStop = false;
            tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            tbName.TrailingIcon = null;
            tbName.UseSystemPasswordChar = false;
            // 
            // tlpProductButton
            // 
            tlpProductButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tlpProductButton.ColumnCount = 3;
            tlpProductButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tlpProductButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tlpProductButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tlpProductButton.Controls.Add(btnSave, 0, 0);
            tlpProductButton.Controls.Add(btnClear, 1, 0);
            tlpProductButton.Controls.Add(btnClose, 2, 0);
            tlpProductButton.Location = new System.Drawing.Point(5, 421);
            tlpProductButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpProductButton.MinimumSize = new System.Drawing.Size(350, 52);
            tlpProductButton.Name = "tlpProductButton";
            tlpProductButton.RowCount = 1;
            tlpProductButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpProductButton.Size = new System.Drawing.Size(350, 52);
            tlpProductButton.TabIndex = 3;
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
            btnSave.Size = new System.Drawing.Size(106, 38);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnClear
            // 
            btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClear.Depth = 0;
            btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            btnClear.HighEmphasis = true;
            btnClear.Icon = null;
            btnClear.Location = new System.Drawing.Point(121, 7);
            btnClear.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            btnClear.Name = "btnClear";
            btnClear.NoAccentTextColor = System.Drawing.Color.Empty;
            btnClear.Size = new System.Drawing.Size(106, 38);
            btnClear.TabIndex = 1;
            btnClear.Text = "Default Value";
            btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnClear.UseAccentColor = false;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // btnClose
            // 
            btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClose.Depth = 0;
            btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            btnClose.HighEmphasis = true;
            btnClose.Icon = null;
            btnClose.Location = new System.Drawing.Point(237, 7);
            btnClose.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            btnClose.Name = "btnClose";
            btnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            btnClose.Size = new System.Drawing.Size(108, 38);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnClose.UseAccentColor = false;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += BtnClose_Click;
            // 
            // ProductFormBase
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(362, 479);
            Controls.Add(tlpProductButton);
            Controls.Add(tlpProductData);
            Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            MinimumSize = new System.Drawing.Size(362, 460);
            Name = "ProductFormBase";
            Padding = new System.Windows.Forms.Padding(5, 85, 5, 3);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Product";
            Load += AddForm_Load;
            ((System.ComponentModel.ISupportInitialize)itemsBindingSourceCompany).EndInit();
            ((System.ComponentModel.ISupportInitialize)companyBindingSource).EndInit();
            tlpProductData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemsBindingSourceCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemsBindingSourceTypes).EndInit();
            ((System.ComponentModel.ISupportInitialize)typeBindingSource).EndInit();
            tlpProductButton.ResumeLayout(false);
            tlpProductButton.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        protected MaterialSkin.Controls.MaterialComboBox cmbCompanyValue;
        protected System.Windows.Forms.TableLayoutPanel tlpProductData;
        protected MaterialSkin.Controls.MaterialTextBox2 tbPrice;
        protected MaterialSkin.Controls.MaterialTextBox2 tbDestination;
        protected System.Windows.Forms.TableLayoutPanel tlpProductButton;
        protected MaterialSkin.Controls.MaterialButton btnSave;
        protected MaterialSkin.Controls.MaterialButton btnClear;
        protected MaterialSkin.Controls.MaterialButton btnClose;
        protected System.Windows.Forms.BindingSource itemsBindingSourceCompany;
        protected System.Windows.Forms.BindingSource companyBindingSource;
        protected MaterialSkin.Controls.MaterialComboBox cmbCategoryValue;
        protected System.Windows.Forms.BindingSource itemsBindingSourceCategory;
        protected System.Windows.Forms.BindingSource categoryBindingSource;
        protected MaterialSkin.Controls.MaterialComboBox cmbTypeValue;
        protected System.Windows.Forms.BindingSource typeBindingSource;
        protected System.Windows.Forms.BindingSource productModelBindingSource;
        protected System.Windows.Forms.BindingSource itemsBindingSourceTypes;
        protected MaterialSkin.Controls.MaterialTextBox2 tbName;
        private System.ComponentModel.IContainer components;
    }
}