namespace TestTask
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
            this.components = new System.ComponentModel.Container();
            this.tlpLogIn = new System.Windows.Forms.TableLayoutPanel();
            this.tbLogIn = new MaterialSkin.Controls.MaterialTextBox();
            this.userModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSignIn = new MaterialSkin.Controls.MaterialButton();
            this.btnSignUpNow = new MaterialSkin.Controls.MaterialButton();
            this.tlpLogIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpLogIn
            // 
            this.tlpLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLogIn.ColumnCount = 1;
            this.tlpLogIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLogIn.Controls.Add(this.tbLogIn, 0, 0);
            this.tlpLogIn.Controls.Add(this.tbPassword, 0, 1);
            this.tlpLogIn.Controls.Add(this.btnSignIn, 0, 2);
            this.tlpLogIn.Controls.Add(this.btnSignUpNow, 0, 3);
            this.tlpLogIn.Location = new System.Drawing.Point(20, 70);
            this.tlpLogIn.MinimumSize = new System.Drawing.Size(260, 280);
            this.tlpLogIn.Name = "tlpLogIn";
            this.tlpLogIn.RowCount = 4;
            this.tlpLogIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLogIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLogIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLogIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLogIn.Size = new System.Drawing.Size(260, 280);
            this.tlpLogIn.TabIndex = 1;
            // 
            // tbLogIn
            // 
            this.tbLogIn.AnimateReadOnly = false;
            this.tbLogIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogIn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userModelBindingSource, "Username", true));
            this.tbLogIn.Depth = 0;
            this.tbLogIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLogIn.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            // userModelBindingSource
            // 
            this.userModelBindingSource.DataSource = typeof(TestTask.BindingItem.UserModel);
            // 
            // tbPassword
            // 
            this.tbPassword.AnimateReadOnly = false;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userModelBindingSource, "Password", true));
            this.tbPassword.Depth = 0;
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            // btnSignIn
            // 
            this.btnSignIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSignIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSignIn.Depth = 0;
            this.btnSignIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSignIn.HighEmphasis = true;
            this.btnSignIn.Icon = null;
            this.btnSignIn.Location = new System.Drawing.Point(20, 155);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.btnSignIn.MinimumSize = new System.Drawing.Size(220, 40);
            this.btnSignIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSignIn.Size = new System.Drawing.Size(220, 40);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSignIn.UseAccentColor = false;
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
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
            this.btnSignUpNow.Click += new System.EventHandler(this.BtnSignUpNow_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 360);
            this.Controls.Add(this.tlpLogIn);
            this.MinimumSize = new System.Drawing.Size(300, 360);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.tlpLogIn.ResumeLayout(false);
            this.tlpLogIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpLogIn;
        private MaterialSkin.Controls.MaterialTextBox tbLogIn;
        private MaterialSkin.Controls.MaterialTextBox tbPassword;
        private MaterialSkin.Controls.MaterialButton btnSignIn;
        private MaterialSkin.Controls.MaterialButton btnSignUpNow;
        private System.Windows.Forms.BindingSource userModelBindingSource;
    }
}

