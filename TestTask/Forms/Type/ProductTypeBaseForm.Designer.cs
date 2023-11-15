namespace TestTask.Forms.Type
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
            this.components = new System.ComponentModel.Container();
            this.tlpField = new System.Windows.Forms.TableLayoutPanel();
            this.cmbListCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbName = new MaterialSkin.Controls.MaterialTextBox2();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tlpField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectCategoryBindingSource)).BeginInit();
            this.tlpButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpField
            // 
            this.tlpField.ColumnCount = 1;
            this.tlpField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpField.Controls.Add(this.cmbListCategory, 0, 0);
            this.tlpField.Controls.Add(this.tbName, 0, 1);
            this.tlpField.Location = new System.Drawing.Point(5, 70);
            this.tlpField.Name = "tlpField";
            this.tlpField.RowCount = 2;
            this.tlpField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpField.Size = new System.Drawing.Size(240, 100);
            this.tlpField.TabIndex = 0;
            // 
            // cmbListCategory
            // 
            this.cmbListCategory.AutoResize = false;
            this.cmbListCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbListCategory.DataSource = this.categoryBindingSource;
            this.cmbListCategory.Depth = 0;
            this.cmbListCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbListCategory.DropDownHeight = 174;
            this.cmbListCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListCategory.DropDownWidth = 121;
            this.cmbListCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbListCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbListCategory.FormattingEnabled = true;
            this.cmbListCategory.IntegralHeight = false;
            this.cmbListCategory.ItemHeight = 43;
            this.cmbListCategory.Location = new System.Drawing.Point(3, 3);
            this.cmbListCategory.MaxDropDownItems = 4;
            this.cmbListCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbListCategory.Name = "cmbListCategory";
            this.cmbListCategory.Size = new System.Drawing.Size(234, 49);
            this.cmbListCategory.StartIndex = 0;
            this.cmbListCategory.TabIndex = 0;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.selectCategoryBindingSource;
            // 
            // selectCategoryBindingSource
            // 
            this.selectCategoryBindingSource.DataSource = typeof(TestTask.BindingItem.ObservableCollection.SelectCategory);
            // 
            // tbName
            // 
            this.tbName.AnimateReadOnly = false;
            this.tbName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Name", true));
            this.tbName.Depth = 0;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbName.HideSelection = true;
            this.tbName.LeadingIcon = null;
            this.tbName.Location = new System.Drawing.Point(3, 53);
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
            this.tbName.Size = new System.Drawing.Size(234, 48);
            this.tbName.TabIndex = 1;
            this.tbName.TabStop = false;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbName.TrailingIcon = null;
            this.tbName.UseSystemPasswordChar = false;
            // 
            // tlpButton
            // 
            this.tlpButton.ColumnCount = 3;
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButton.Controls.Add(this.btnSave, 0, 0);
            this.tlpButton.Controls.Add(this.btnClose, 2, 0);
            this.tlpButton.Controls.Add(this.btnClear, 1, 0);
            this.tlpButton.Location = new System.Drawing.Point(5, 175);
            this.tlpButton.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 1;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButton.Size = new System.Drawing.Size(240, 45);
            this.tlpButton.TabIndex = 2;
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
            this.btnSave.Size = new System.Drawing.Size(72, 33);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClose.Depth = 0;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.HighEmphasis = true;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(164, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClose.Size = new System.Drawing.Size(72, 33);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClear.Depth = 0;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.HighEmphasis = true;
            this.btnClear.Icon = null;
            this.btnClear.Location = new System.Drawing.Point(84, 6);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClear.Size = new System.Drawing.Size(72, 33);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Default Value";
            this.btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClear.UseAccentColor = false;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Items";
            this.categoryBindingSource.DataSource = this.selectCategoryBindingSource;
            // 
            // ProductTypeBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 225);
            this.Controls.Add(this.tlpButton);
            this.Controls.Add(this.tlpField);
            this.Name = "ProductTypeBaseForm";
            this.Text = "Product Type";
            this.Load += new System.EventHandler(this.ProductTypeBaseForm_Load);
            this.tlpField.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectCategoryBindingSource)).EndInit();
            this.tlpButton.ResumeLayout(false);
            this.tlpButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);

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
        protected System.ComponentModel.IContainer components;
    }
}