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
            this.tbPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSignIn = new MaterialSkin.Controls.MaterialButton();
            this.btnSignUpNow = new MaterialSkin.Controls.MaterialButton();
            this.userModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tlbButton = new System.Windows.Forms.TableLayoutPanel();
            this.tlpLogIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userModelBindingSource)).BeginInit();
            this.tlbButton.SuspendLayout();
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
            this.tlpLogIn.Location = new System.Drawing.Point(10, 70);
            this.tlpLogIn.MinimumSize = new System.Drawing.Size(250, 120);
            this.tlpLogIn.Name = "tlpLogIn";
            this.tlpLogIn.RowCount = 2;
            this.tlpLogIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLogIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLogIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLogIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLogIn.Size = new System.Drawing.Size(250, 120);
            this.tlpLogIn.TabIndex = 1;
            // 
            // tbLogIn
            // 
            this.tbLogIn.AnimateReadOnly = false;
            this.tbLogIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogIn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userModelBindingSource, "Username", true));
            this.tbLogIn.Depth = 0;
            this.tbLogIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbLogIn.Hint = "Username";
            this.tbLogIn.LeadingIcon = null;
            this.tbLogIn.Location = new System.Drawing.Point(5, 5);
            this.tbLogIn.Margin = new System.Windows.Forms.Padding(5);
            this.tbLogIn.MaxLength = 50;
            this.tbLogIn.MouseState = MaterialSkin.MouseState.OUT;
            this.tbLogIn.Multiline = false;
            this.tbLogIn.Name = "tbLogIn";
            this.tbLogIn.Size = new System.Drawing.Size(240, 50);
            this.tbLogIn.TabIndex = 0;
            this.tbLogIn.Text = "";
            this.tbLogIn.TrailingIcon = null;
            // 
            // tbPassword
            // 
            this.tbPassword.AnimateReadOnly = false;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userModelBindingSource, "Password", true));
            this.tbPassword.Depth = 0;
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPassword.Hint = "Password";
            this.tbPassword.LeadingIcon = null;
            this.tbPassword.Location = new System.Drawing.Point(5, 65);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(5);
            this.tbPassword.MaxLength = 50;
            this.tbPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPassword.Multiline = false;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(240, 50);
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
            this.btnSignIn.Location = new System.Drawing.Point(5, 5);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(5);
            this.btnSignIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSignIn.Size = new System.Drawing.Size(240, 30);
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
            this.btnSignUpNow.Location = new System.Drawing.Point(5, 45);
            this.btnSignUpNow.Margin = new System.Windows.Forms.Padding(5);
            this.btnSignUpNow.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSignUpNow.Name = "btnSignUpNow";
            this.btnSignUpNow.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSignUpNow.Size = new System.Drawing.Size(240, 30);
            this.btnSignUpNow.TabIndex = 3;
            this.btnSignUpNow.Text = "Create an account";
            this.btnSignUpNow.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSignUpNow.UseAccentColor = false;
            this.btnSignUpNow.UseVisualStyleBackColor = true;
            this.btnSignUpNow.Click += new System.EventHandler(this.BtnSignUpNow_Click);
            // 
            // userModelBindingSource
            // 
            this.userModelBindingSource.DataSource = typeof(TestTask.BindingItem.UserModel);
            // 
            // tlbButton
            // 
            this.tlbButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tlbButton.ColumnCount = 1;
            this.tlbButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbButton.Controls.Add(this.btnSignIn, 0, 0);
            this.tlbButton.Controls.Add(this.btnSignUpNow, 0, 1);
            this.tlbButton.Location = new System.Drawing.Point(10, 196);
            this.tlbButton.MinimumSize = new System.Drawing.Size(250, 80);
            this.tlbButton.Name = "tlbButton";
            this.tlbButton.RowCount = 2;
            this.tlbButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbButton.Size = new System.Drawing.Size(250, 80);
            this.tlbButton.TabIndex = 2;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 280);
            this.Controls.Add(this.tlbButton);
            this.Controls.Add(this.tlpLogIn);
            this.MinimumSize = new System.Drawing.Size(270, 280);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.tlpLogIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userModelBindingSource)).EndInit();
            this.tlbButton.ResumeLayout(false);
            this.tlbButton.PerformLayout();
            this.ResumeLayout(false);

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

