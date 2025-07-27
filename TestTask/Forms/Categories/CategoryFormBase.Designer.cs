using TestTask.BindingItem.DBItemModel;

namespace TestTask.Forms.Categories
{
    partial class CategoryFormBase: BaseForm
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
            tlpText = new System.Windows.Forms.TableLayoutPanel();
            tbCategory = new MaterialSkin.Controls.MaterialTextBox2();
            categoryModelBindingSource = new System.Windows.Forms.BindingSource(components);
            tlpButtonCategory = new System.Windows.Forms.TableLayoutPanel();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            btnClose = new MaterialSkin.Controls.MaterialButton();
            btnClear = new MaterialSkin.Controls.MaterialButton();
            tlpText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoryModelBindingSource).BeginInit();
            tlpButtonCategory.SuspendLayout();
            SuspendLayout();
            // 
            // tlpText
            // 
            tlpText.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tlpText.ColumnCount = 1;
            tlpText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpText.Controls.Add(tbCategory, 0, 0);
            tlpText.Location = new System.Drawing.Point(6, 81);
            tlpText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpText.Name = "tlpText";
            tlpText.RowCount = 1;
            tlpText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpText.Size = new System.Drawing.Size(280, 58);
            tlpText.TabIndex = 0;
            // 
            // tbCategory
            // 
            tbCategory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbCategory.AnimateReadOnly = false;
            tbCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tbCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            tbCategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", categoryModelBindingSource, "Name", true));
            tbCategory.Depth = 0;
            tbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            tbCategory.HideSelection = true;
            tbCategory.Hint = "Name";
            tbCategory.LeadingIcon = null;
            tbCategory.Location = new System.Drawing.Point(4, 3);
            tbCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbCategory.MaxLength = 32767;
            tbCategory.MouseState = MaterialSkin.MouseState.OUT;
            tbCategory.Name = "tbCategory";
            tbCategory.PasswordChar = '\0';
            tbCategory.PrefixSuffixText = null;
            tbCategory.ReadOnly = false;
            tbCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            tbCategory.SelectedText = "";
            tbCategory.SelectionLength = 0;
            tbCategory.SelectionStart = 0;
            tbCategory.ShortcutsEnabled = true;
            tbCategory.Size = new System.Drawing.Size(272, 48);
            tbCategory.TabIndex = 0;
            tbCategory.TabStop = false;
            tbCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            tbCategory.TrailingIcon = null;
            tbCategory.UseSystemPasswordChar = false;
            // 
            // categoryModelBindingSource
            // 
            categoryModelBindingSource.DataSource = typeof(CategoryModel);
            // 
            // tlpButtonCategory
            // 
            tlpButtonCategory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tlpButtonCategory.ColumnCount = 3;
            tlpButtonCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tlpButtonCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tlpButtonCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tlpButtonCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tlpButtonCategory.Controls.Add(btnSave, 0, 0);
            tlpButtonCategory.Controls.Add(btnClose, 2, 0);
            tlpButtonCategory.Controls.Add(btnClear, 1, 0);
            tlpButtonCategory.Location = new System.Drawing.Point(6, 144);
            tlpButtonCategory.Margin = new System.Windows.Forms.Padding(0);
            tlpButtonCategory.Name = "tlpButtonCategory";
            tlpButtonCategory.RowCount = 1;
            tlpButtonCategory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpButtonCategory.Size = new System.Drawing.Size(280, 52);
            tlpButtonCategory.TabIndex = 1;
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
            // CategoryFormBase
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(292, 202);
            Controls.Add(tlpButtonCategory);
            Controls.Add(tlpText);
            Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            MinimumSize = new System.Drawing.Size(292, 202);
            Name = "CategoryFormBase";
            Padding = new System.Windows.Forms.Padding(5, 85, 5, 3);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "CategoryForm";
            Load += FormBase_Load;
            tlpText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)categoryModelBindingSource).EndInit();
            tlpButtonCategory.ResumeLayout(false);
            tlpButtonCategory.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TableLayoutPanel tlpText;
        protected System.Windows.Forms.TableLayoutPanel tlpButtonCategory;
        protected MaterialSkin.Controls.MaterialTextBox2 tbCategory;
        protected MaterialSkin.Controls.MaterialButton btnSave;
        protected MaterialSkin.Controls.MaterialButton btnClear;
        protected MaterialSkin.Controls.MaterialButton btnClose;
        protected System.Windows.Forms.BindingSource categoryModelBindingSource;
        private new System.ComponentModel.IContainer components;
    }
}
