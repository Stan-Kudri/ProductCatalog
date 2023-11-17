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
            this.components = new System.ComponentModel.Container();
            this.cmbCompanyValue = new MaterialSkin.Controls.MaterialComboBox();
            this.itemsBindingSourceCompany = new System.Windows.Forms.BindingSource(this.components);
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tlpProductData = new System.Windows.Forms.TableLayoutPanel();
            this.tbPrice = new MaterialSkin.Controls.MaterialTextBox2();
            this.productModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbDestination = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmbCategoryValue = new MaterialSkin.Controls.MaterialComboBox();
            this.itemsBindingSourceCategory = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTypeValue = new MaterialSkin.Controls.MaterialComboBox();
            this.itemsBindingSourceTypes = new System.Windows.Forms.BindingSource(this.components);
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbName = new MaterialSkin.Controls.MaterialTextBox2();
            this.tlpProductButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSourceCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.tlpProductData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSourceCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSourceTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            this.tlpProductButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCompanyValue
            // 
            this.cmbCompanyValue.AutoResize = false;
            this.cmbCompanyValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCompanyValue.DataSource = this.itemsBindingSourceCompany;
            this.cmbCompanyValue.Depth = 0;
            this.cmbCompanyValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCompanyValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCompanyValue.DropDownHeight = 174;
            this.cmbCompanyValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompanyValue.DropDownWidth = 121;
            this.cmbCompanyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCompanyValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCompanyValue.FormattingEnabled = true;
            this.cmbCompanyValue.IntegralHeight = false;
            this.cmbCompanyValue.ItemHeight = 43;
            this.cmbCompanyValue.Location = new System.Drawing.Point(3, 50);
            this.cmbCompanyValue.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cmbCompanyValue.MaxDropDownItems = 4;
            this.cmbCompanyValue.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCompanyValue.Name = "cmbCompanyValue";
            this.cmbCompanyValue.Size = new System.Drawing.Size(294, 49);
            this.cmbCompanyValue.StartIndex = 0;
            this.cmbCompanyValue.TabIndex = 1;
            // 
            // itemsBindingSourceCompany
            // 
            this.itemsBindingSourceCompany.DataMember = "Items";
            this.itemsBindingSourceCompany.DataSource = this.companyBindingSource;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(TestTask.BindingItem.ObservableCollection.SelectCompany);
            // 
            // tlpProductData
            // 
            this.tlpProductData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpProductData.ColumnCount = 1;
            this.tlpProductData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProductData.Controls.Add(this.cmbCompanyValue, 0, 1);
            this.tlpProductData.Controls.Add(this.tbPrice, 0, 4);
            this.tlpProductData.Controls.Add(this.tbDestination, 0, 5);
            this.tlpProductData.Controls.Add(this.cmbCategoryValue, 0, 2);
            this.tlpProductData.Controls.Add(this.cmbTypeValue, 0, 3);
            this.tlpProductData.Controls.Add(this.tbName, 0, 0);
            this.tlpProductData.Location = new System.Drawing.Point(4, 69);
            this.tlpProductData.MinimumSize = new System.Drawing.Size(300, 250);
            this.tlpProductData.Name = "tlpProductData";
            this.tlpProductData.RowCount = 6;
            this.tlpProductData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpProductData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpProductData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpProductData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpProductData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpProductData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpProductData.Size = new System.Drawing.Size(300, 300);
            this.tlpProductData.TabIndex = 2;
            // 
            // tbPrice
            // 
            this.tbPrice.AnimateReadOnly = false;
            this.tbPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productModelBindingSource, "Price", true));
            this.tbPrice.Depth = 0;
            this.tbPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPrice.HideSelection = true;
            this.tbPrice.Hint = "Price";
            this.tbPrice.LeadingIcon = null;
            this.tbPrice.Location = new System.Drawing.Point(3, 203);
            this.tbPrice.MaxLength = 32767;
            this.tbPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.PasswordChar = '\0';
            this.tbPrice.PrefixSuffixText = null;
            this.tbPrice.ReadOnly = false;
            this.tbPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPrice.SelectedText = "";
            this.tbPrice.SelectionLength = 0;
            this.tbPrice.SelectionStart = 0;
            this.tbPrice.ShortcutsEnabled = true;
            this.tbPrice.Size = new System.Drawing.Size(294, 48);
            this.tbPrice.TabIndex = 3;
            this.tbPrice.TabStop = false;
            this.tbPrice.Text = "0";
            this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPrice.TrailingIcon = null;
            this.tbPrice.UseSystemPasswordChar = false;
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPrice_KeyPress);
            // 
            // productModelBindingSource
            // 
            this.productModelBindingSource.DataSource = typeof(TestTask.BindingItem.ProductModel);
            // 
            // tbDestination
            // 
            this.tbDestination.AnimateReadOnly = false;
            this.tbDestination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbDestination.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbDestination.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productModelBindingSource, "Destination", true));
            this.tbDestination.Depth = 0;
            this.tbDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbDestination.HideSelection = true;
            this.tbDestination.Hint = "Destination";
            this.tbDestination.LeadingIcon = null;
            this.tbDestination.Location = new System.Drawing.Point(3, 253);
            this.tbDestination.MaxLength = 32767;
            this.tbDestination.MouseState = MaterialSkin.MouseState.OUT;
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.PasswordChar = '\0';
            this.tbDestination.PrefixSuffixText = null;
            this.tbDestination.ReadOnly = false;
            this.tbDestination.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbDestination.SelectedText = "";
            this.tbDestination.SelectionLength = 0;
            this.tbDestination.SelectionStart = 0;
            this.tbDestination.ShortcutsEnabled = true;
            this.tbDestination.Size = new System.Drawing.Size(294, 48);
            this.tbDestination.TabIndex = 4;
            this.tbDestination.TabStop = false;
            this.tbDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDestination.TrailingIcon = null;
            this.tbDestination.UseSystemPasswordChar = false;
            // 
            // cmbCategoryValue
            // 
            this.cmbCategoryValue.AutoResize = false;
            this.cmbCategoryValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCategoryValue.DataSource = this.itemsBindingSourceCategory;
            this.cmbCategoryValue.Depth = 0;
            this.cmbCategoryValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCategoryValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCategoryValue.DropDownHeight = 174;
            this.cmbCategoryValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryValue.DropDownWidth = 121;
            this.cmbCategoryValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCategoryValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCategoryValue.FormattingEnabled = true;
            this.cmbCategoryValue.IntegralHeight = false;
            this.cmbCategoryValue.ItemHeight = 43;
            this.cmbCategoryValue.Location = new System.Drawing.Point(3, 103);
            this.cmbCategoryValue.MaxDropDownItems = 4;
            this.cmbCategoryValue.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCategoryValue.Name = "cmbCategoryValue";
            this.cmbCategoryValue.Size = new System.Drawing.Size(294, 49);
            this.cmbCategoryValue.StartIndex = 0;
            this.cmbCategoryValue.TabIndex = 5;
            this.cmbCategoryValue.SelectedIndexChanged += new System.EventHandler(this.CmbCategoryValue_Changed);
            // 
            // itemsBindingSourceCategory
            // 
            this.itemsBindingSourceCategory.DataMember = "Items";
            this.itemsBindingSourceCategory.DataSource = this.categoryBindingSource;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(TestTask.BindingItem.ObservableCollection.SelectCategory);
            // 
            // cmbTypeValue
            // 
            this.cmbTypeValue.AutoResize = false;
            this.cmbTypeValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTypeValue.DataSource = this.itemsBindingSourceTypes;
            this.cmbTypeValue.Depth = 0;
            this.cmbTypeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTypeValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTypeValue.DropDownHeight = 174;
            this.cmbTypeValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeValue.DropDownWidth = 121;
            this.cmbTypeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTypeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTypeValue.FormattingEnabled = true;
            this.cmbTypeValue.IntegralHeight = false;
            this.cmbTypeValue.ItemHeight = 43;
            this.cmbTypeValue.Location = new System.Drawing.Point(3, 153);
            this.cmbTypeValue.MaxDropDownItems = 4;
            this.cmbTypeValue.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTypeValue.Name = "cmbTypeValue";
            this.cmbTypeValue.Size = new System.Drawing.Size(294, 49);
            this.cmbTypeValue.StartIndex = 0;
            this.cmbTypeValue.TabIndex = 6;
            // 
            // itemsBindingSourceTypes
            // 
            this.itemsBindingSourceTypes.DataMember = "Items";
            this.itemsBindingSourceTypes.DataSource = this.typeBindingSource;
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataSource = typeof(TestTask.BindingItem.ObservableCollection.SelectType);
            // 
            // tbName
            // 
            this.tbName.AnimateReadOnly = false;
            this.tbName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productModelBindingSource, "Name", true));
            this.tbName.Depth = 0;
            this.tbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbName.HideSelection = true;
            this.tbName.Hint = "Name";
            this.tbName.LeadingIcon = null;
            this.tbName.Location = new System.Drawing.Point(3, 3);
            this.tbName.MaxLength = 32767;
            this.tbName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.PrefixSuffixText = null;
            this.tbName.ReadOnly = false;
            this.tbName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbName.SelectedText = "";
            this.tbName.SelectionLength = 0;
            this.tbName.SelectionStart = 0;
            this.tbName.ShortcutsEnabled = true;
            this.tbName.Size = new System.Drawing.Size(294, 48);
            this.tbName.TabIndex = 7;
            this.tbName.TabStop = false;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbName.TrailingIcon = null;
            this.tbName.UseSystemPasswordChar = false;
            // 
            // tlpProductButton
            // 
            this.tlpProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tlpProductButton.ColumnCount = 3;
            this.tlpProductButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpProductButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpProductButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpProductButton.Controls.Add(this.btnSave, 0, 0);
            this.tlpProductButton.Controls.Add(this.btnClear, 1, 0);
            this.tlpProductButton.Controls.Add(this.btnClose, 2, 0);
            this.tlpProductButton.Location = new System.Drawing.Point(4, 365);
            this.tlpProductButton.MinimumSize = new System.Drawing.Size(300, 45);
            this.tlpProductButton.Name = "tlpProductButton";
            this.tlpProductButton.RowCount = 1;
            this.tlpProductButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProductButton.Size = new System.Drawing.Size(300, 45);
            this.tlpProductButton.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(4, 6);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(91, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClear.Depth = 0;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.HighEmphasis = true;
            this.btnClear.Icon = null;
            this.btnClear.Location = new System.Drawing.Point(103, 6);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClear.Size = new System.Drawing.Size(91, 33);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Default Value";
            this.btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClear.UseAccentColor = false;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClose.Depth = 0;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.HighEmphasis = true;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(202, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClose.Size = new System.Drawing.Size(94, 33);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ProductFormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 415);
            this.Controls.Add(this.tlpProductButton);
            this.Controls.Add(this.tlpProductData);
            this.MinimumSize = new System.Drawing.Size(310, 365);
            this.Name = "ProductFormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSourceCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.tlpProductData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSourceCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSourceTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            this.tlpProductButton.ResumeLayout(false);
            this.tlpProductButton.PerformLayout();
            this.ResumeLayout(false);

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