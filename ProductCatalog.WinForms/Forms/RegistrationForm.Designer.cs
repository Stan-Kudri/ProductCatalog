namespace ProductCatalog.WinForms.Forms
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private new System.ComponentModel.IContainer components = null;

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
            tlpRegistration = new System.Windows.Forms.TableLayoutPanel();
            tbLogIn = new MaterialSkin.Controls.MaterialTextBox();
            userModelBindingSource = new System.Windows.Forms.BindingSource(components);
            tbPassword = new MaterialSkin.Controls.MaterialTextBox();
            btnSignUpNow = new MaterialSkin.Controls.MaterialButton();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tlpRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userModelBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tlpRegistration
            // 
            tlpRegistration.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tlpRegistration.ColumnCount = 1;
            tlpRegistration.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpRegistration.Controls.Add(tbLogIn, 0, 0);
            tlpRegistration.Controls.Add(tbPassword, 0, 1);
            tlpRegistration.Location = new System.Drawing.Point(12, 81);
            tlpRegistration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpRegistration.MinimumSize = new System.Drawing.Size(292, 138);
            tlpRegistration.Name = "tlpRegistration";
            tlpRegistration.RowCount = 2;
            tlpRegistration.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpRegistration.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpRegistration.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tlpRegistration.Size = new System.Drawing.Size(292, 138);
            tlpRegistration.TabIndex = 2;
            // 
            // tbLogIn
            // 
            tbLogIn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbLogIn.AnimateReadOnly = false;
            tbLogIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tbLogIn.DataBindings.Add(new System.Windows.Forms.Binding("Text", userModelBindingSource, "Username", true));
            tbLogIn.Depth = 0;
            tbLogIn.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            tbLogIn.Hint = "Username";
            tbLogIn.LeadingIcon = null;
            tbLogIn.Location = new System.Drawing.Point(6, 6);
            tbLogIn.Margin = new System.Windows.Forms.Padding(6);
            tbLogIn.MaxLength = 50;
            tbLogIn.MouseState = MaterialSkin.MouseState.OUT;
            tbLogIn.Multiline = false;
            tbLogIn.Name = "tbLogIn";
            tbLogIn.Size = new System.Drawing.Size(280, 50);
            tbLogIn.TabIndex = 0;
            tbLogIn.Text = "";
            tbLogIn.TrailingIcon = null;
            // 
            // userModelBindingSource
            // 
            userModelBindingSource.DataSource = typeof(BindingItem.UserModel);
            // 
            // tbPassword
            // 
            tbPassword.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbPassword.AnimateReadOnly = false;
            tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tbPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", userModelBindingSource, "Password", true));
            tbPassword.Depth = 0;
            tbPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            tbPassword.Hint = "Password";
            tbPassword.LeadingIcon = null;
            tbPassword.Location = new System.Drawing.Point(6, 75);
            tbPassword.Margin = new System.Windows.Forms.Padding(6);
            tbPassword.MaxLength = 50;
            tbPassword.MouseState = MaterialSkin.MouseState.OUT;
            tbPassword.Multiline = false;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new System.Drawing.Size(280, 50);
            tbPassword.TabIndex = 1;
            tbPassword.Text = "";
            tbPassword.TrailingIcon = null;
            // 
            // btnSignUpNow
            // 
            btnSignUpNow.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnSignUpNow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnSignUpNow.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSignUpNow.Depth = 0;
            btnSignUpNow.HighEmphasis = true;
            btnSignUpNow.Icon = null;
            btnSignUpNow.Location = new System.Drawing.Point(6, 6);
            btnSignUpNow.Margin = new System.Windows.Forms.Padding(6);
            btnSignUpNow.MouseState = MaterialSkin.MouseState.HOVER;
            btnSignUpNow.Name = "btnSignUpNow";
            btnSignUpNow.NoAccentTextColor = System.Drawing.Color.Empty;
            btnSignUpNow.Size = new System.Drawing.Size(280, 34);
            btnSignUpNow.TabIndex = 3;
            btnSignUpNow.Text = "Registration";
            btnSignUpNow.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSignUpNow.UseAccentColor = false;
            btnSignUpNow.UseVisualStyleBackColor = true;
            btnSignUpNow.Click += BtnSignUpNow_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnSignUpNow, 0, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(12, 223);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(292, 46);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(315, 277);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tlpRegistration);
            Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            MinimumSize = new System.Drawing.Size(315, 277);
            Name = "RegistrationForm";
            Padding = new System.Windows.Forms.Padding(5, 85, 5, 3);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Registration";
            FormClosing += RegistrationForm_FormClosing;
            tlpRegistration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userModelBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRegistration;
        private MaterialSkin.Controls.MaterialTextBox tbLogIn;
        private MaterialSkin.Controls.MaterialTextBox tbPassword;
        private MaterialSkin.Controls.MaterialButton btnSignUpNow;
        private System.Windows.Forms.BindingSource userModelBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
