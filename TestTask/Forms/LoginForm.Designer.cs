namespace TestTask.Forms
{
    partial class LoginForm
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
            components = new System.ComponentModel.Container();
            tlpLogIn = new System.Windows.Forms.TableLayoutPanel();
            tbLogIn = new MaterialSkin.Controls.MaterialTextBox();
            userModelBindingSource = new System.Windows.Forms.BindingSource(components);
            tbPassword = new MaterialSkin.Controls.MaterialTextBox();
            btnSignIn = new MaterialSkin.Controls.MaterialButton();
            btnSignUpNow = new MaterialSkin.Controls.MaterialButton();
            tlbButton = new System.Windows.Forms.TableLayoutPanel();
            tlpLogIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userModelBindingSource).BeginInit();
            tlbButton.SuspendLayout();
            SuspendLayout();
            // 
            // tlpLogIn
            // 
            tlpLogIn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tlpLogIn.ColumnCount = 1;
            tlpLogIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpLogIn.Controls.Add(tbLogIn, 0, 0);
            tlpLogIn.Controls.Add(tbPassword, 0, 1);
            tlpLogIn.Location = new System.Drawing.Point(12, 81);
            tlpLogIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpLogIn.MinimumSize = new System.Drawing.Size(292, 138);
            tlpLogIn.Name = "tlpLogIn";
            tlpLogIn.RowCount = 2;
            tlpLogIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpLogIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpLogIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tlpLogIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tlpLogIn.Size = new System.Drawing.Size(292, 138);
            tlpLogIn.TabIndex = 1;
            // 
            // tbLogIn
            // 
            tbLogIn.AnimateReadOnly = false;
            tbLogIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tbLogIn.DataBindings.Add(new System.Windows.Forms.Binding("Text", userModelBindingSource, "Username", true));
            tbLogIn.Depth = 0;
            tbLogIn.Dock = System.Windows.Forms.DockStyle.Fill;
            tbLogIn.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            tbLogIn.Hint = "Username";
            tbLogIn.LeadingIcon = null;
            tbLogIn.Location = new System.Drawing.Point(6, 6);
            tbLogIn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            tbPassword.AnimateReadOnly = false;
            tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tbPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", userModelBindingSource, "Password", true));
            tbPassword.Depth = 0;
            tbPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            tbPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            tbPassword.Hint = "Password";
            tbPassword.LeadingIcon = null;
            tbPassword.Location = new System.Drawing.Point(6, 75);
            tbPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            tbPassword.MaxLength = 50;
            tbPassword.MouseState = MaterialSkin.MouseState.OUT;
            tbPassword.Multiline = false;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new System.Drawing.Size(280, 50);
            tbPassword.TabIndex = 1;
            tbPassword.Text = "";
            tbPassword.TrailingIcon = null;
            // 
            // btnSignIn
            // 
            btnSignIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnSignIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSignIn.Depth = 0;
            btnSignIn.Dock = System.Windows.Forms.DockStyle.Fill;
            btnSignIn.HighEmphasis = true;
            btnSignIn.Icon = null;
            btnSignIn.Location = new System.Drawing.Point(6, 6);
            btnSignIn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            btnSignIn.MouseState = MaterialSkin.MouseState.HOVER;
            btnSignIn.Name = "btnSignIn";
            btnSignIn.NoAccentTextColor = System.Drawing.Color.Empty;
            btnSignIn.Size = new System.Drawing.Size(280, 34);
            btnSignIn.TabIndex = 2;
            btnSignIn.Text = "Sign in";
            btnSignIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSignIn.UseAccentColor = false;
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += BtnSignIn_Click;
            // 
            // btnSignUpNow
            // 
            btnSignUpNow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnSignUpNow.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSignUpNow.Depth = 0;
            btnSignUpNow.Dock = System.Windows.Forms.DockStyle.Fill;
            btnSignUpNow.HighEmphasis = true;
            btnSignUpNow.Icon = null;
            btnSignUpNow.Location = new System.Drawing.Point(6, 52);
            btnSignUpNow.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            btnSignUpNow.MouseState = MaterialSkin.MouseState.HOVER;
            btnSignUpNow.Name = "btnSignUpNow";
            btnSignUpNow.NoAccentTextColor = System.Drawing.Color.Empty;
            btnSignUpNow.Size = new System.Drawing.Size(280, 34);
            btnSignUpNow.TabIndex = 3;
            btnSignUpNow.Text = "Create an account";
            btnSignUpNow.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSignUpNow.UseAccentColor = false;
            btnSignUpNow.UseVisualStyleBackColor = true;
            btnSignUpNow.Click += BtnSignUpNow_Click;
            // 
            // tlbButton
            // 
            tlbButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            tlbButton.ColumnCount = 1;
            tlbButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlbButton.Controls.Add(btnSignIn, 0, 0);
            tlbButton.Controls.Add(btnSignUpNow, 0, 1);
            tlbButton.Location = new System.Drawing.Point(12, 226);
            tlbButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlbButton.MinimumSize = new System.Drawing.Size(292, 92);
            tlbButton.Name = "tlbButton";
            tlbButton.RowCount = 2;
            tlbButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlbButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlbButton.Size = new System.Drawing.Size(292, 92);
            tlbButton.TabIndex = 2;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(315, 323);
            Controls.Add(tlbButton);
            Controls.Add(tlpLogIn);
            Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            MinimumSize = new System.Drawing.Size(315, 323);
            Name = "LoginForm";
            Padding = new System.Windows.Forms.Padding(5, 85, 5, 3);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Sign In";
            tlpLogIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userModelBindingSource).EndInit();
            tlbButton.ResumeLayout(false);
            tlbButton.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpLogIn;
        private MaterialSkin.Controls.MaterialTextBox tbLogIn;
        private MaterialSkin.Controls.MaterialTextBox tbPassword;
        private MaterialSkin.Controls.MaterialButton btnSignIn;
        private MaterialSkin.Controls.MaterialButton btnSignUpNow;
        private System.Windows.Forms.BindingSource userModelBindingSource;
        private System.Windows.Forms.TableLayoutPanel tlbButton;
    }
}

