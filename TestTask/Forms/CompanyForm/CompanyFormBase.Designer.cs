namespace TestTask.Forms.CompanyForm
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
            this.components = new System.ComponentModel.Container();
            this.tbNameCompany = new MaterialSkin.Controls.MaterialTextBox2();
            this.companyModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tlpNameCompany = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCompany = new System.Windows.Forms.TableLayoutPanel();
            this.tbContry = new MaterialSkin.Controls.MaterialTextBox2();
            this.dtpCreateCompany = new System.Windows.Forms.DateTimePicker();
            this.tlbButtonCompany = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.companyModelBindingSource)).BeginInit();
            this.tlpNameCompany.SuspendLayout();
            this.tlpCompany.SuspendLayout();
            this.tlbButtonCompany.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNameCompany
            // 
            this.tbNameCompany.AnimateReadOnly = false;
            this.tbNameCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbNameCompany.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbNameCompany.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyModelBindingSource, "Name", true));
            this.tbNameCompany.Depth = 0;
            this.tbNameCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNameCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbNameCompany.HideSelection = true;
            this.tbNameCompany.Hint = "Name";
            this.tbNameCompany.LeadingIcon = null;
            this.tbNameCompany.Location = new System.Drawing.Point(3, 3);
            this.tbNameCompany.MaxLength = 32767;
            this.tbNameCompany.MouseState = MaterialSkin.MouseState.OUT;
            this.tbNameCompany.Name = "tbNameCompany";
            this.tbNameCompany.PasswordChar = '\0';
            this.tbNameCompany.PrefixSuffixText = null;
            this.tbNameCompany.ReadOnly = false;
            this.tbNameCompany.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbNameCompany.SelectedText = "";
            this.tbNameCompany.SelectionLength = 0;
            this.tbNameCompany.SelectionStart = 0;
            this.tbNameCompany.ShortcutsEnabled = true;
            this.tbNameCompany.Size = new System.Drawing.Size(244, 48);
            this.tbNameCompany.TabIndex = 1;
            this.tbNameCompany.TabStop = false;
            this.tbNameCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNameCompany.TrailingIcon = null;
            this.tbNameCompany.UseSystemPasswordChar = false;
            // 
            // companyModelBindingSource
            // 
            this.companyModelBindingSource.DataSource = typeof(TestTask.BindingItem.UserBinding.CompanyModel);
            // 
            // tlpNameCompany
            // 
            this.tlpNameCompany.ColumnCount = 1;
            this.tlpNameCompany.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNameCompany.Controls.Add(this.tbNameCompany, 0, 0);
            this.tlpNameCompany.Location = new System.Drawing.Point(5, 70);
            this.tlpNameCompany.MinimumSize = new System.Drawing.Size(250, 50);
            this.tlpNameCompany.Name = "tlpNameCompany";
            this.tlpNameCompany.RowCount = 1;
            this.tlpNameCompany.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNameCompany.Size = new System.Drawing.Size(250, 50);
            this.tlpNameCompany.TabIndex = 2;
            // 
            // tlpCompany
            // 
            this.tlpCompany.ColumnCount = 1;
            this.tlpCompany.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCompany.Controls.Add(this.tbContry, 0, 0);
            this.tlpCompany.Controls.Add(this.dtpCreateCompany, 0, 1);
            this.tlpCompany.Location = new System.Drawing.Point(5, 125);
            this.tlpCompany.MinimumSize = new System.Drawing.Size(250, 100);
            this.tlpCompany.Name = "tlpCompany";
            this.tlpCompany.RowCount = 2;
            this.tlpCompany.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCompany.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCompany.Size = new System.Drawing.Size(250, 100);
            this.tlpCompany.TabIndex = 3;
            // 
            // tbContry
            // 
            this.tbContry.AnimateReadOnly = false;
            this.tbContry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbContry.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbContry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyModelBindingSource, "Country", true));
            this.tbContry.Depth = 0;
            this.tbContry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbContry.HideSelection = true;
            this.tbContry.Hint = "Contry";
            this.tbContry.LeadingIcon = null;
            this.tbContry.Location = new System.Drawing.Point(3, 3);
            this.tbContry.MaxLength = 32767;
            this.tbContry.MouseState = MaterialSkin.MouseState.OUT;
            this.tbContry.Name = "tbContry";
            this.tbContry.PasswordChar = '\0';
            this.tbContry.PrefixSuffixText = null;
            this.tbContry.ReadOnly = false;
            this.tbContry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbContry.SelectedText = "";
            this.tbContry.SelectionLength = 0;
            this.tbContry.SelectionStart = 0;
            this.tbContry.ShortcutsEnabled = true;
            this.tbContry.Size = new System.Drawing.Size(244, 48);
            this.tbContry.TabIndex = 0;
            this.tbContry.TabStop = false;
            this.tbContry.Text = "Belarus";
            this.tbContry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbContry.TrailingIcon = null;
            this.tbContry.UseSystemPasswordChar = false;
            // 
            // dtpCreateCompany
            // 
            this.dtpCreateCompany.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtpCreateCompany.CustomFormat = "";
            this.dtpCreateCompany.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.companyModelBindingSource, "DateCreation", true));
            this.dtpCreateCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpCreateCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpCreateCompany.Location = new System.Drawing.Point(3, 53);
            this.dtpCreateCompany.MaxDate = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            this.dtpCreateCompany.Name = "dtpCreateCompany";
            this.dtpCreateCompany.Size = new System.Drawing.Size(244, 26);
            this.dtpCreateCompany.TabIndex = 1;
            this.dtpCreateCompany.Value = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            // 
            // tlbButtonCompany
            // 
            this.tlbButtonCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tlbButtonCompany.ColumnCount = 3;
            this.tlbButtonCompany.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlbButtonCompany.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlbButtonCompany.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlbButtonCompany.Controls.Add(this.btnSave, 0, 0);
            this.tlbButtonCompany.Controls.Add(this.btnClear, 1, 0);
            this.tlbButtonCompany.Controls.Add(this.btnClose, 2, 0);
            this.tlbButtonCompany.Location = new System.Drawing.Point(4, 231);
            this.tlbButtonCompany.MinimumSize = new System.Drawing.Size(250, 45);
            this.tlbButtonCompany.Name = "tlbButtonCompany";
            this.tlbButtonCompany.RowCount = 1;
            this.tlbButtonCompany.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbButtonCompany.Size = new System.Drawing.Size(250, 45);
            this.tlbButtonCompany.TabIndex = 4;
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
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClear.Depth = 0;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.HighEmphasis = true;
            this.btnClear.Icon = null;
            this.btnClear.Location = new System.Drawing.Point(87, 6);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClear.Size = new System.Drawing.Size(75, 33);
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
            this.btnClose.Location = new System.Drawing.Point(170, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClose.Size = new System.Drawing.Size(76, 33);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // CompanyFormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 280);
            this.Controls.Add(this.tlbButtonCompany);
            this.Controls.Add(this.tlpCompany);
            this.Controls.Add(this.tlpNameCompany);
            this.MinimumSize = new System.Drawing.Size(260, 280);
            this.Name = "CompanyFormBase";
            this.Text = "Company";
            this.Load += new System.EventHandler(this.AddModeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyModelBindingSource)).EndInit();
            this.tlpNameCompany.ResumeLayout(false);
            this.tlpCompany.ResumeLayout(false);
            this.tlbButtonCompany.ResumeLayout(false);
            this.tlbButtonCompany.PerformLayout();
            this.ResumeLayout(false);

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