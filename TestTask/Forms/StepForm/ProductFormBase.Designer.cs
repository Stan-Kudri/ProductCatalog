namespace TestTask.Forms.StepForm
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
            this.tbCategory = new MaterialSkin.Controls.MaterialTextBox2();
            this.productModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbCompanyValue = new MaterialSkin.Controls.MaterialComboBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tlpProductData = new System.Windows.Forms.TableLayoutPanel();
            this.tbType = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbPrice = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbDestination = new MaterialSkin.Controls.MaterialTextBox2();
            this.tlpProductButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.productModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectCompanyBindingSource)).BeginInit();
            this.tlpProductData.SuspendLayout();
            this.tlpProductButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCategory
            // 
            this.tbCategory.AnimateReadOnly = false;
            this.tbCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productModelBindingSource, "Category", true));
            this.tbCategory.Depth = 0;
            this.tbCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCategory.HideSelection = true;
            this.tbCategory.Hint = "Category";
            this.tbCategory.LeadingIcon = null;
            this.tbCategory.Location = new System.Drawing.Point(3, 51);
            this.tbCategory.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbCategory.MaxLength = 32767;
            this.tbCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.PasswordChar = '\0';
            this.tbCategory.PrefixSuffixText = null;
            this.tbCategory.ReadOnly = false;
            this.tbCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCategory.SelectedText = "";
            this.tbCategory.SelectionLength = 0;
            this.tbCategory.SelectionStart = 0;
            this.tbCategory.ShortcutsEnabled = true;
            this.tbCategory.Size = new System.Drawing.Size(294, 48);
            this.tbCategory.TabIndex = 0;
            this.tbCategory.TabStop = false;
            this.tbCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCategory.TrailingIcon = null;
            this.tbCategory.UseSystemPasswordChar = false;
            // 
            // productModelBindingSource
            // 
            this.productModelBindingSource.DataSource = typeof(TestTask.BindingItem.UserBinding.ProductBinding.ProductModel);
            // 
            // cmbCompanyValue
            // 
            this.cmbCompanyValue.AutoResize = false;
            this.cmbCompanyValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCompanyValue.DataSource = this.itemsBindingSource;
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
            this.cmbCompanyValue.Location = new System.Drawing.Point(3, 0);
            this.cmbCompanyValue.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cmbCompanyValue.MaxDropDownItems = 4;
            this.cmbCompanyValue.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCompanyValue.Name = "cmbCompanyValue";
            this.cmbCompanyValue.Size = new System.Drawing.Size(294, 49);
            this.cmbCompanyValue.StartIndex = 0;
            this.cmbCompanyValue.TabIndex = 1;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.selectCompanyBindingSource;
            // 
            // selectCompanyBindingSource
            // 
            this.selectCompanyBindingSource.DataSource = typeof(TestTask.BindingItem.UserBinding.ProductBinding.SelectCompany);
            // 
            // tlpProductData
            // 
            this.tlpProductData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpProductData.ColumnCount = 1;
            this.tlpProductData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProductData.Controls.Add(this.cmbCompanyValue, 0, 0);
            this.tlpProductData.Controls.Add(this.tbCategory, 0, 1);
            this.tlpProductData.Controls.Add(this.tbType, 0, 2);
            this.tlpProductData.Controls.Add(this.tbPrice, 0, 3);
            this.tlpProductData.Controls.Add(this.tbDestination, 0, 4);
            this.tlpProductData.Location = new System.Drawing.Point(4, 69);
            this.tlpProductData.MinimumSize = new System.Drawing.Size(300, 250);
            this.tlpProductData.Name = "tlpProductData";
            this.tlpProductData.RowCount = 5;
            this.tlpProductData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpProductData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpProductData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpProductData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpProductData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpProductData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpProductData.Size = new System.Drawing.Size(300, 250);
            this.tlpProductData.TabIndex = 2;
            // 
            // tbType
            // 
            this.tbType.AnimateReadOnly = false;
            this.tbType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productModelBindingSource, "Type", true));
            this.tbType.Depth = 0;
            this.tbType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbType.HideSelection = true;
            this.tbType.Hint = "Type";
            this.tbType.LeadingIcon = null;
            this.tbType.Location = new System.Drawing.Point(3, 103);
            this.tbType.MaxLength = 32767;
            this.tbType.MouseState = MaterialSkin.MouseState.OUT;
            this.tbType.Name = "tbType";
            this.tbType.PasswordChar = '\0';
            this.tbType.PrefixSuffixText = null;
            this.tbType.ReadOnly = false;
            this.tbType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbType.SelectedText = "";
            this.tbType.SelectionLength = 0;
            this.tbType.SelectionStart = 0;
            this.tbType.ShortcutsEnabled = true;
            this.tbType.Size = new System.Drawing.Size(294, 48);
            this.tbType.TabIndex = 2;
            this.tbType.TabStop = false;
            this.tbType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbType.TrailingIcon = null;
            this.tbType.UseSystemPasswordChar = false;
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
            this.tbPrice.Location = new System.Drawing.Point(3, 153);
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
            this.tbDestination.Location = new System.Drawing.Point(3, 203);
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
            this.tlpProductButton.Location = new System.Drawing.Point(4, 315);
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
            this.ClientSize = new System.Drawing.Size(310, 365);
            this.Controls.Add(this.tlpProductButton);
            this.Controls.Add(this.tlpProductData);
            this.MinimumSize = new System.Drawing.Size(310, 365);
            this.Name = "ProductFormBase";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.AddStepForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectCompanyBindingSource)).EndInit();
            this.tlpProductData.ResumeLayout(false);
            this.tlpProductButton.ResumeLayout(false);
            this.tlpProductButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected MaterialSkin.Controls.MaterialTextBox2 tbCategory;
        protected MaterialSkin.Controls.MaterialComboBox cmbCompanyValue;
        protected System.Windows.Forms.TableLayoutPanel tlpProductData;
        protected MaterialSkin.Controls.MaterialTextBox2 tbType;
        protected MaterialSkin.Controls.MaterialTextBox2 tbPrice;
        protected MaterialSkin.Controls.MaterialTextBox2 tbDestination;
        protected System.Windows.Forms.TableLayoutPanel tlpProductButton;
        protected MaterialSkin.Controls.MaterialButton btnSave;
        protected MaterialSkin.Controls.MaterialButton btnClear;
        protected MaterialSkin.Controls.MaterialButton btnClose;
        protected System.Windows.Forms.BindingSource productModelBindingSource;
        protected System.Windows.Forms.BindingSource itemsBindingSource;
        protected System.Windows.Forms.BindingSource selectCompanyBindingSource;
        private System.ComponentModel.IContainer components;
    }
}