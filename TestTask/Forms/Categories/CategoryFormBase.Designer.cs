namespace TestTask.Forms.Categories
{
    partial class CategoryFormBase
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
            this.tlpText = new System.Windows.Forms.TableLayoutPanel();
            this.tbCategory = new MaterialSkin.Controls.MaterialTextBox2();
            this.categoryModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tlpButtonCategory = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.tlpText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryModelBindingSource)).BeginInit();
            this.tlpButtonCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpText
            // 
            this.tlpText.ColumnCount = 1;
            this.tlpText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpText.Controls.Add(this.tbCategory, 0, 0);
            this.tlpText.Location = new System.Drawing.Point(5, 70);
            this.tlpText.Name = "tlpText";
            this.tlpText.RowCount = 1;
            this.tlpText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpText.Size = new System.Drawing.Size(240, 50);
            this.tlpText.TabIndex = 0;
            // 
            // tbCategory
            // 
            this.tbCategory.AnimateReadOnly = false;
            this.tbCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoryModelBindingSource, "Name", true));
            this.tbCategory.Depth = 0;
            this.tbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCategory.HideSelection = true;
            this.tbCategory.Hint = "Name";
            this.tbCategory.LeadingIcon = null;
            this.tbCategory.Location = new System.Drawing.Point(3, 3);
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
            this.tbCategory.Size = new System.Drawing.Size(234, 48);
            this.tbCategory.TabIndex = 0;
            this.tbCategory.TabStop = false;
            this.tbCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCategory.TrailingIcon = null;
            this.tbCategory.UseSystemPasswordChar = false;
            // 
            // categoryModelBindingSource
            // 
            this.categoryModelBindingSource.DataSource = typeof(TestTask.BindingItem.CategoryModel);
            // 
            // tlpButtonCategory
            // 
            this.tlpButtonCategory.ColumnCount = 3;
            this.tlpButtonCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtonCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtonCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtonCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButtonCategory.Controls.Add(this.btnSave, 0, 0);
            this.tlpButtonCategory.Controls.Add(this.btnClose, 2, 0);
            this.tlpButtonCategory.Controls.Add(this.btnClear, 1, 0);
            this.tlpButtonCategory.Location = new System.Drawing.Point(5, 125);
            this.tlpButtonCategory.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButtonCategory.Name = "tlpButtonCategory";
            this.tlpButtonCategory.RowCount = 1;
            this.tlpButtonCategory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtonCategory.Size = new System.Drawing.Size(240, 45);
            this.tlpButtonCategory.TabIndex = 1;
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
            // CategoryFormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 175);
            this.Controls.Add(this.tlpButtonCategory);
            this.Controls.Add(this.tlpText);
            this.MinimumSize = new System.Drawing.Size(250, 175);
            this.Name = "CategoryFormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryFormBase_Load);
            this.tlpText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryModelBindingSource)).EndInit();
            this.tlpButtonCategory.ResumeLayout(false);
            this.tlpButtonCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TableLayoutPanel tlpText;
        protected System.Windows.Forms.TableLayoutPanel tlpButtonCategory;
        protected MaterialSkin.Controls.MaterialTextBox2 tbCategory;
        protected MaterialSkin.Controls.MaterialButton btnSave;
        protected MaterialSkin.Controls.MaterialButton btnClear;
        protected MaterialSkin.Controls.MaterialButton btnClose;
        protected System.Windows.Forms.BindingSource categoryModelBindingSource;
        private System.ComponentModel.IContainer components;
    }
}