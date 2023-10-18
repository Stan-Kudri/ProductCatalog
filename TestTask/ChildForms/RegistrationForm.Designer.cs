namespace TestTask.ChildForms
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.tlpRegistration = new System.Windows.Forms.TableLayoutPanel();
            this.tbLogIn = new MaterialSkin.Controls.MaterialTextBox();
            this.tbPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSignUpNow = new MaterialSkin.Controls.MaterialButton();
            this.tbConfirmPass = new MaterialSkin.Controls.MaterialTextBox();
            this.tlpRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpRegistration
            // 
            this.tlpRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpRegistration.ColumnCount = 1;
            this.tlpRegistration.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRegistration.Controls.Add(this.tbLogIn, 0, 0);
            this.tlpRegistration.Controls.Add(this.tbPassword, 0, 1);
            this.tlpRegistration.Controls.Add(this.btnSignUpNow, 0, 3);
            this.tlpRegistration.Controls.Add(this.tbConfirmPass, 0, 2);
            this.tlpRegistration.Location = new System.Drawing.Point(20, 70);
            this.tlpRegistration.MinimumSize = new System.Drawing.Size(260, 280);
            this.tlpRegistration.Name = "tlpRegistration";
            this.tlpRegistration.RowCount = 4;
            this.tlpRegistration.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpRegistration.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpRegistration.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpRegistration.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpRegistration.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpRegistration.Size = new System.Drawing.Size(260, 280);
            this.tlpRegistration.TabIndex = 2;
            // 
            // tbLogIn
            // 
            this.tbLogIn.AnimateReadOnly = false;
            this.tbLogIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogIn.Depth = 0;
            this.tbLogIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbLogIn.Hint = "Username";
            this.tbLogIn.LeadingIcon = null;
            this.tbLogIn.Location = new System.Drawing.Point(20, 10);
            this.tbLogIn.Margin = new System.Windows.Forms.Padding(20, 10, 20, 5);
            this.tbLogIn.MaxLength = 50;
            this.tbLogIn.MouseState = MaterialSkin.MouseState.OUT;
            this.tbLogIn.Multiline = false;
            this.tbLogIn.Name = "tbLogIn";
            this.tbLogIn.Size = new System.Drawing.Size(220, 50);
            this.tbLogIn.TabIndex = 0;
            this.tbLogIn.Text = "";
            this.tbLogIn.TrailingIcon = null;
            // 
            // tbPassword
            // 
            this.tbPassword.AnimateReadOnly = false;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Depth = 0;
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPassword.Hint = "Password";
            this.tbPassword.LeadingIcon = null;
            this.tbPassword.Location = new System.Drawing.Point(20, 80);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(20, 10, 20, 5);
            this.tbPassword.MaxLength = 50;
            this.tbPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPassword.Multiline = false;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(220, 50);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Text = "";
            this.tbPassword.TrailingIcon = null;
            // 
            // btnSignUpNow
            // 
            this.btnSignUpNow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSignUpNow.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSignUpNow.Depth = 0;
            this.btnSignUpNow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSignUpNow.HighEmphasis = true;
            this.btnSignUpNow.Icon = null;
            this.btnSignUpNow.Location = new System.Drawing.Point(20, 225);
            this.btnSignUpNow.Margin = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.btnSignUpNow.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSignUpNow.Name = "btnSignUpNow";
            this.btnSignUpNow.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSignUpNow.Size = new System.Drawing.Size(220, 40);
            this.btnSignUpNow.TabIndex = 3;
            this.btnSignUpNow.Text = "Create an account";
            this.btnSignUpNow.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSignUpNow.UseAccentColor = false;
            this.btnSignUpNow.UseVisualStyleBackColor = true;
            // 
            // tbConfirmPass
            // 
            this.tbConfirmPass.AnimateReadOnly = false;
            this.tbConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbConfirmPass.Depth = 0;
            this.tbConfirmPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbConfirmPass.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbConfirmPass.Hint = "Confirm password";
            this.tbConfirmPass.LeadingIcon = null;
            this.tbConfirmPass.Location = new System.Drawing.Point(20, 150);
            this.tbConfirmPass.Margin = new System.Windows.Forms.Padding(20, 10, 20, 5);
            this.tbConfirmPass.MaxLength = 50;
            this.tbConfirmPass.MouseState = MaterialSkin.MouseState.OUT;
            this.tbConfirmPass.Multiline = false;
            this.tbConfirmPass.Name = "tbConfirmPass";
            this.tbConfirmPass.Size = new System.Drawing.Size(220, 50);
            this.tbConfirmPass.TabIndex = 4;
            this.tbConfirmPass.Text = "";
            this.tbConfirmPass.TrailingIcon = null;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 360);
            this.Controls.Add(this.tlpRegistration);
            this.MinimumSize = new System.Drawing.Size(300, 360);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrationForm_FormClosing);
            this.tlpRegistration.ResumeLayout(false);
            this.tlpRegistration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRegistration;
        private MaterialSkin.Controls.MaterialTextBox tbLogIn;
        private MaterialSkin.Controls.MaterialTextBox tbPassword;
        private MaterialSkin.Controls.MaterialButton btnSignUpNow;
        private MaterialSkin.Controls.MaterialTextBox tbConfirmPass;
    }
}