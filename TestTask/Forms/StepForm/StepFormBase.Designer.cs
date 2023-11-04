namespace TestTask.Forms.StepForm
{
    partial class StepFormBase
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
            this.tbTimer = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmbCompanyValue = new MaterialSkin.Controls.MaterialComboBox();
            this.tlpStepData = new System.Windows.Forms.TableLayoutPanel();
            this.tbDestination = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbSpeed = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbType = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbVolume = new MaterialSkin.Controls.MaterialTextBox2();
            this.tlpAddButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.tlpStepData.SuspendLayout();
            this.tlpAddButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTimer
            // 
            this.tbTimer.AnimateReadOnly = false;
            this.tbTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbTimer.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbTimer.Depth = 0;
            this.tbTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTimer.HideSelection = true;
            this.tbTimer.Hint = "Timer";
            this.tbTimer.LeadingIcon = null;
            this.tbTimer.Location = new System.Drawing.Point(3, 51);
            this.tbTimer.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbTimer.MaxLength = 32767;
            this.tbTimer.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.PasswordChar = '\0';
            this.tbTimer.PrefixSuffixText = null;
            this.tbTimer.ReadOnly = false;
            this.tbTimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbTimer.SelectedText = "";
            this.tbTimer.SelectionLength = 0;
            this.tbTimer.SelectionStart = 0;
            this.tbTimer.ShortcutsEnabled = true;
            this.tbTimer.Size = new System.Drawing.Size(294, 48);
            this.tbTimer.TabIndex = 0;
            this.tbTimer.TabStop = false;
            this.tbTimer.Text = "0";
            this.tbTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbTimer.TrailingIcon = null;
            this.tbTimer.UseSystemPasswordChar = false;
            this.tbTimer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTimer_KeyPress);
            // 
            // cmbCompanyValue
            // 
            this.cmbCompanyValue.AutoResize = false;
            this.cmbCompanyValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            // tlpStepData
            // 
            this.tlpStepData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpStepData.ColumnCount = 1;
            this.tlpStepData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStepData.Controls.Add(this.cmbCompanyValue, 0, 0);
            this.tlpStepData.Controls.Add(this.tbTimer, 0, 1);
            this.tlpStepData.Controls.Add(this.tbDestination, 0, 2);
            this.tlpStepData.Controls.Add(this.tbSpeed, 0, 3);
            this.tlpStepData.Controls.Add(this.tbType, 0, 4);
            this.tlpStepData.Controls.Add(this.tbVolume, 0, 5);
            this.tlpStepData.Location = new System.Drawing.Point(4, 69);
            this.tlpStepData.MinimumSize = new System.Drawing.Size(300, 300);
            this.tlpStepData.Name = "tlpStepData";
            this.tlpStepData.RowCount = 6;
            this.tlpStepData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpStepData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpStepData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpStepData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpStepData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpStepData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpStepData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpStepData.Size = new System.Drawing.Size(300, 300);
            this.tlpStepData.TabIndex = 2;
            // 
            // tbDestination
            // 
            this.tbDestination.AnimateReadOnly = false;
            this.tbDestination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbDestination.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbDestination.Depth = 0;
            this.tbDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbDestination.HideSelection = true;
            this.tbDestination.Hint = "Destination";
            this.tbDestination.LeadingIcon = null;
            this.tbDestination.Location = new System.Drawing.Point(3, 103);
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
            this.tbDestination.TabIndex = 2;
            this.tbDestination.TabStop = false;
            this.tbDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDestination.TrailingIcon = null;
            this.tbDestination.UseSystemPasswordChar = false;
            // 
            // tbSpeed
            // 
            this.tbSpeed.AnimateReadOnly = false;
            this.tbSpeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbSpeed.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbSpeed.Depth = 0;
            this.tbSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSpeed.HideSelection = true;
            this.tbSpeed.Hint = "Speed";
            this.tbSpeed.LeadingIcon = null;
            this.tbSpeed.Location = new System.Drawing.Point(3, 153);
            this.tbSpeed.MaxLength = 32767;
            this.tbSpeed.MouseState = MaterialSkin.MouseState.OUT;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.PasswordChar = '\0';
            this.tbSpeed.PrefixSuffixText = null;
            this.tbSpeed.ReadOnly = false;
            this.tbSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbSpeed.SelectedText = "";
            this.tbSpeed.SelectionLength = 0;
            this.tbSpeed.SelectionStart = 0;
            this.tbSpeed.ShortcutsEnabled = true;
            this.tbSpeed.Size = new System.Drawing.Size(294, 48);
            this.tbSpeed.TabIndex = 3;
            this.tbSpeed.TabStop = false;
            this.tbSpeed.Text = "0";
            this.tbSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSpeed.TrailingIcon = null;
            this.tbSpeed.UseSystemPasswordChar = false;
            this.tbSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbSpeed_KeyPress);
            // 
            // tbType
            // 
            this.tbType.AnimateReadOnly = false;
            this.tbType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbType.Depth = 0;
            this.tbType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbType.HideSelection = true;
            this.tbType.Hint = "Type";
            this.tbType.LeadingIcon = null;
            this.tbType.Location = new System.Drawing.Point(3, 203);
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
            this.tbType.TabIndex = 4;
            this.tbType.TabStop = false;
            this.tbType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbType.TrailingIcon = null;
            this.tbType.UseSystemPasswordChar = false;
            // 
            // tbVolume
            // 
            this.tbVolume.AnimateReadOnly = false;
            this.tbVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbVolume.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbVolume.Depth = 0;
            this.tbVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbVolume.HideSelection = true;
            this.tbVolume.Hint = "Volume";
            this.tbVolume.LeadingIcon = null;
            this.tbVolume.Location = new System.Drawing.Point(3, 253);
            this.tbVolume.MaxLength = 32767;
            this.tbVolume.MouseState = MaterialSkin.MouseState.OUT;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.PasswordChar = '\0';
            this.tbVolume.PrefixSuffixText = null;
            this.tbVolume.ReadOnly = false;
            this.tbVolume.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbVolume.SelectedText = "";
            this.tbVolume.SelectionLength = 0;
            this.tbVolume.SelectionStart = 0;
            this.tbVolume.ShortcutsEnabled = true;
            this.tbVolume.Size = new System.Drawing.Size(294, 48);
            this.tbVolume.TabIndex = 5;
            this.tbVolume.TabStop = false;
            this.tbVolume.Text = "0";
            this.tbVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbVolume.TrailingIcon = null;
            this.tbVolume.UseSystemPasswordChar = false;
            this.tbVolume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbVolume_KeyPress);
            // 
            // tlpAddButton
            // 
            this.tlpAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tlpAddButton.ColumnCount = 3;
            this.tlpAddButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAddButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAddButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAddButton.Controls.Add(this.btnSave, 0, 0);
            this.tlpAddButton.Controls.Add(this.btnClear, 1, 0);
            this.tlpAddButton.Controls.Add(this.btnClose, 2, 0);
            this.tlpAddButton.Location = new System.Drawing.Point(4, 370);
            this.tlpAddButton.MinimumSize = new System.Drawing.Size(300, 45);
            this.tlpAddButton.Name = "tlpAddButton";
            this.tlpAddButton.RowCount = 1;
            this.tlpAddButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddButton.Size = new System.Drawing.Size(300, 45);
            this.tlpAddButton.TabIndex = 3;
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
            // StepFormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 415);
            this.Controls.Add(this.tlpAddButton);
            this.Controls.Add(this.tlpStepData);
            this.MinimumSize = new System.Drawing.Size(310, 415);
            this.Name = "StepFormBase";
            this.Text = "Step Form";
            this.Load += new System.EventHandler(this.AddStepForm_Load);
            this.tlpStepData.ResumeLayout(false);
            this.tlpAddButton.ResumeLayout(false);
            this.tlpAddButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected MaterialSkin.Controls.MaterialTextBox2 tbTimer;
        protected MaterialSkin.Controls.MaterialComboBox cmbCompanyValue;
        protected System.Windows.Forms.TableLayoutPanel tlpStepData;
        protected MaterialSkin.Controls.MaterialTextBox2 tbDestination;
        protected MaterialSkin.Controls.MaterialTextBox2 tbSpeed;
        protected MaterialSkin.Controls.MaterialTextBox2 tbType;
        protected MaterialSkin.Controls.MaterialTextBox2 tbVolume;
        protected System.Windows.Forms.TableLayoutPanel tlpAddButton;
        protected MaterialSkin.Controls.MaterialButton btnSave;
        protected MaterialSkin.Controls.MaterialButton btnClear;
        protected MaterialSkin.Controls.MaterialButton btnClose;
        protected System.ComponentModel.IContainer components;
    }
}