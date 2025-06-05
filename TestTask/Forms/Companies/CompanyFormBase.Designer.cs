using TestTask.BindingItem;

namespace TestTask.Forms.Companies
{
    partial class CompanyFormBase
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
            tbNameCompany = new MaterialSkin.Controls.MaterialTextBox2();
            companyModelBindingSource = new System.Windows.Forms.BindingSource(components);
            tlpNameCompany = new System.Windows.Forms.TableLayoutPanel();
            tlpCompany = new System.Windows.Forms.TableLayoutPanel();
            tbContry = new MaterialSkin.Controls.MaterialTextBox2();
            dtpCreateCompany = new System.Windows.Forms.DateTimePicker();
            tlbButtonCompany = new System.Windows.Forms.TableLayoutPanel();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            btnClear = new MaterialSkin.Controls.MaterialButton();
            btnClose = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)companyModelBindingSource).BeginInit();
            tlpNameCompany.SuspendLayout();
            tlpCompany.SuspendLayout();
            tlbButtonCompany.SuspendLayout();
            SuspendLayout();
            // 
            // tbNameCompany
            // 
            tbNameCompany.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbNameCompany.AnimateReadOnly = false;
            tbNameCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tbNameCompany.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            tbNameCompany.DataBindings.Add(new System.Windows.Forms.Binding("Text", companyModelBindingSource, "Name", true));
            tbNameCompany.Depth = 0;
            tbNameCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            tbNameCompany.HideSelection = true;
            tbNameCompany.Hint = "Name";
            tbNameCompany.LeadingIcon = null;
            tbNameCompany.Location = new System.Drawing.Point(4, 3);
            tbNameCompany.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbNameCompany.MaxLength = 32767;
            tbNameCompany.MouseState = MaterialSkin.MouseState.OUT;
            tbNameCompany.Name = "tbNameCompany";
            tbNameCompany.PasswordChar = '\0';
            tbNameCompany.PrefixSuffixText = null;
            tbNameCompany.ReadOnly = false;
            tbNameCompany.RightToLeft = System.Windows.Forms.RightToLeft.No;
            tbNameCompany.SelectedText = "";
            tbNameCompany.SelectionLength = 0;
            tbNameCompany.SelectionStart = 0;
            tbNameCompany.ShortcutsEnabled = true;
            tbNameCompany.Size = new System.Drawing.Size(284, 48);
            tbNameCompany.TabIndex = 1;
            tbNameCompany.TabStop = false;
            tbNameCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            tbNameCompany.TrailingIcon = null;
            tbNameCompany.UseSystemPasswordChar = false;
            // 
            // companyModelBindingSource
            // 
            companyModelBindingSource.DataSource = typeof(CompanyModel);
            // 
            // tlpNameCompany
            // 
            tlpNameCompany.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tlpNameCompany.ColumnCount = 1;
            tlpNameCompany.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpNameCompany.Controls.Add(tbNameCompany, 0, 0);
            tlpNameCompany.Location = new System.Drawing.Point(6, 81);
            tlpNameCompany.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpNameCompany.MinimumSize = new System.Drawing.Size(292, 58);
            tlpNameCompany.Name = "tlpNameCompany";
            tlpNameCompany.RowCount = 1;
            tlpNameCompany.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpNameCompany.Size = new System.Drawing.Size(292, 58);
            tlpNameCompany.TabIndex = 2;
            // 
            // tlpCompany
            // 
            tlpCompany.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tlpCompany.ColumnCount = 1;
            tlpCompany.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpCompany.Controls.Add(tbContry, 0, 0);
            tlpCompany.Controls.Add(dtpCreateCompany, 0, 1);
            tlpCompany.Location = new System.Drawing.Point(6, 144);
            tlpCompany.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpCompany.MinimumSize = new System.Drawing.Size(292, 115);
            tlpCompany.Name = "tlpCompany";
            tlpCompany.RowCount = 2;
            tlpCompany.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpCompany.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpCompany.Size = new System.Drawing.Size(292, 115);
            tlpCompany.TabIndex = 3;
            // 
            // tbContry
            // 
            tbContry.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbContry.AnimateReadOnly = false;
            tbContry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tbContry.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            tbContry.DataBindings.Add(new System.Windows.Forms.Binding("Text", companyModelBindingSource, "Country", true));
            tbContry.Depth = 0;
            tbContry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            tbContry.HideSelection = true;
            tbContry.Hint = "Contry";
            tbContry.LeadingIcon = null;
            tbContry.Location = new System.Drawing.Point(4, 3);
            tbContry.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbContry.MaxLength = 32767;
            tbContry.MouseState = MaterialSkin.MouseState.OUT;
            tbContry.Name = "tbContry";
            tbContry.PasswordChar = '\0';
            tbContry.PrefixSuffixText = null;
            tbContry.ReadOnly = false;
            tbContry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            tbContry.SelectedText = "";
            tbContry.SelectionLength = 0;
            tbContry.SelectionStart = 0;
            tbContry.ShortcutsEnabled = true;
            tbContry.Size = new System.Drawing.Size(284, 48);
            tbContry.TabIndex = 0;
            tbContry.TabStop = false;
            tbContry.Text = "Belarus";
            tbContry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            tbContry.TrailingIcon = null;
            tbContry.UseSystemPasswordChar = false;
            // 
            // dtpCreateCompany
            // 
            dtpCreateCompany.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dtpCreateCompany.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dtpCreateCompany.CustomFormat = "";
            dtpCreateCompany.DataBindings.Add(new System.Windows.Forms.Binding("Value", companyModelBindingSource, "DateCreation", true));
            dtpCreateCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtpCreateCompany.Location = new System.Drawing.Point(4, 60);
            dtpCreateCompany.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtpCreateCompany.MaxDate = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            dtpCreateCompany.Name = "dtpCreateCompany";
            dtpCreateCompany.Size = new System.Drawing.Size(284, 26);
            dtpCreateCompany.TabIndex = 1;
            dtpCreateCompany.Value = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            // 
            // tlbButtonCompany
            // 
            tlbButtonCompany.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tlbButtonCompany.ColumnCount = 3;
            tlbButtonCompany.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tlbButtonCompany.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tlbButtonCompany.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tlbButtonCompany.Controls.Add(btnSave, 0, 0);
            tlbButtonCompany.Controls.Add(btnClear, 1, 0);
            tlbButtonCompany.Controls.Add(btnClose, 2, 0);
            tlbButtonCompany.Location = new System.Drawing.Point(5, 267);
            tlbButtonCompany.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlbButtonCompany.MinimumSize = new System.Drawing.Size(292, 52);
            tlbButtonCompany.Name = "tlbButtonCompany";
            tlbButtonCompany.RowCount = 1;
            tlbButtonCompany.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlbButtonCompany.Size = new System.Drawing.Size(292, 52);
            tlbButtonCompany.TabIndex = 4;
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
            btnSave.Size = new System.Drawing.Size(87, 38);
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
            btnClear.Location = new System.Drawing.Point(102, 7);
            btnClear.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            btnClear.Name = "btnClear";
            btnClear.NoAccentTextColor = System.Drawing.Color.Empty;
            btnClear.Size = new System.Drawing.Size(87, 38);
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
            btnClose.Location = new System.Drawing.Point(199, 7);
            btnClose.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            btnClose.Name = "btnClose";
            btnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            btnClose.Size = new System.Drawing.Size(88, 38);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnClose.UseAccentColor = false;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += BtnClose_Click;
            // 
            // CompanyFormBase
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(303, 323);
            Controls.Add(tlbButtonCompany);
            Controls.Add(tlpCompany);
            Controls.Add(tlpNameCompany);
            Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            MinimumSize = new System.Drawing.Size(303, 323);
            Name = "CompanyFormBase";
            Padding = new System.Windows.Forms.Padding(5, 85, 5, 3);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Company";
            Load += AddModeForm_Load;
            ((System.ComponentModel.ISupportInitialize)companyModelBindingSource).EndInit();
            tlpNameCompany.ResumeLayout(false);
            tlpCompany.ResumeLayout(false);
            tlbButtonCompany.ResumeLayout(false);
            tlbButtonCompany.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        protected MaterialSkin.Controls.MaterialTextBox2 tbNameCompany;
        protected System.Windows.Forms.TableLayoutPanel tlpNameCompany;
        protected System.Windows.Forms.TableLayoutPanel tlpCompany;
        protected MaterialSkin.Controls.MaterialTextBox2 tbContry;
        protected System.Windows.Forms.TableLayoutPanel tlbButtonCompany;
        protected MaterialSkin.Controls.MaterialButton btnSave;
        protected MaterialSkin.Controls.MaterialButton btnClear;
        protected MaterialSkin.Controls.MaterialButton btnClose;
        protected System.Windows.Forms.BindingSource modeModelBindingSource;
        protected System.Windows.Forms.DateTimePicker dtpCreateCompany;
        private System.Windows.Forms.BindingSource companyModelBindingSource;
        private System.ComponentModel.IContainer components;
    }
}