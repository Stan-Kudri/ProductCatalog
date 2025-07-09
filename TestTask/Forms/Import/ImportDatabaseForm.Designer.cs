namespace TestTask.ChildForms.Import
{
    partial class ImportDatabaseForm
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
            cbCompany = new MaterialSkin.Controls.MaterialCheckbox();
            cbProduct = new MaterialSkin.Controls.MaterialCheckbox();
            tlbComboBox = new System.Windows.Forms.TableLayoutPanel();
            cbType = new MaterialSkin.Controls.MaterialCheckbox();
            cbCategory = new MaterialSkin.Controls.MaterialCheckbox();
            btnImportData = new MaterialSkin.Controls.MaterialButton();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tlbComboBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // cbCompany
            // 
            cbCompany.AutoSize = true;
            cbCompany.Checked = true;
            cbCompany.CheckState = System.Windows.Forms.CheckState.Checked;
            cbCompany.Depth = 0;
            cbCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            cbCompany.Location = new System.Drawing.Point(0, 0);
            cbCompany.Margin = new System.Windows.Forms.Padding(0);
            cbCompany.MouseLocation = new System.Drawing.Point(-1, -1);
            cbCompany.MouseState = MaterialSkin.MouseState.HOVER;
            cbCompany.Name = "cbCompany";
            cbCompany.ReadOnly = false;
            cbCompany.Ripple = true;
            cbCompany.Size = new System.Drawing.Size(143, 63);
            cbCompany.TabIndex = 0;
            cbCompany.Text = "Company";
            cbCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cbCompany.UseVisualStyleBackColor = true;
            cbCompany.CheckedChanged += cbCompany_CheckedChanged;
            // 
            // cbProduct
            // 
            cbProduct.AutoSize = true;
            cbProduct.Checked = true;
            cbProduct.CheckState = System.Windows.Forms.CheckState.Checked;
            cbProduct.Depth = 0;
            cbProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            cbProduct.Location = new System.Drawing.Point(143, 0);
            cbProduct.Margin = new System.Windows.Forms.Padding(0);
            cbProduct.MouseLocation = new System.Drawing.Point(-1, -1);
            cbProduct.MouseState = MaterialSkin.MouseState.HOVER;
            cbProduct.Name = "cbProduct";
            cbProduct.ReadOnly = false;
            cbProduct.Ripple = true;
            cbProduct.Size = new System.Drawing.Size(144, 63);
            cbProduct.TabIndex = 1;
            cbProduct.Text = "Product";
            cbProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cbProduct.UseVisualStyleBackColor = true;
            cbProduct.CheckedChanged += cbProduct_CheckedChanged;
            // 
            // tlbComboBox
            // 
            tlbComboBox.ColumnCount = 2;
            tlbComboBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlbComboBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlbComboBox.Controls.Add(cbType, 0, 1);
            tlbComboBox.Controls.Add(cbCategory, 0, 1);
            tlbComboBox.Controls.Add(cbCompany, 0, 0);
            tlbComboBox.Controls.Add(cbProduct, 1, 0);
            tlbComboBox.Location = new System.Drawing.Point(9, 83);
            tlbComboBox.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            tlbComboBox.Name = "tlbComboBox";
            tlbComboBox.RowCount = 2;
            tlbComboBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlbComboBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlbComboBox.Size = new System.Drawing.Size(287, 127);
            tlbComboBox.TabIndex = 2;
            // 
            // cbType
            // 
            cbType.AutoSize = true;
            cbType.Checked = true;
            cbType.CheckState = System.Windows.Forms.CheckState.Checked;
            cbType.Depth = 0;
            cbType.Dock = System.Windows.Forms.DockStyle.Fill;
            cbType.Location = new System.Drawing.Point(0, 63);
            cbType.Margin = new System.Windows.Forms.Padding(0);
            cbType.MouseLocation = new System.Drawing.Point(-1, -1);
            cbType.MouseState = MaterialSkin.MouseState.HOVER;
            cbType.Name = "cbType";
            cbType.ReadOnly = false;
            cbType.Ripple = true;
            cbType.Size = new System.Drawing.Size(143, 64);
            cbType.TabIndex = 3;
            cbType.Text = "Type";
            cbType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cbType.UseVisualStyleBackColor = true;
            cbType.CheckedChanged += cbType_CheckedChanged;
            // 
            // cbCategory
            // 
            cbCategory.AutoSize = true;
            cbCategory.Checked = true;
            cbCategory.CheckState = System.Windows.Forms.CheckState.Checked;
            cbCategory.Depth = 0;
            cbCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            cbCategory.Location = new System.Drawing.Point(143, 63);
            cbCategory.Margin = new System.Windows.Forms.Padding(0);
            cbCategory.MouseLocation = new System.Drawing.Point(-1, -1);
            cbCategory.MouseState = MaterialSkin.MouseState.HOVER;
            cbCategory.Name = "cbCategory";
            cbCategory.ReadOnly = false;
            cbCategory.Ripple = true;
            cbCategory.Size = new System.Drawing.Size(144, 64);
            cbCategory.TabIndex = 2;
            cbCategory.Text = "Category";
            cbCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cbCategory.UseVisualStyleBackColor = true;
            cbCategory.CheckedChanged += cbCategory_CheckedChanged;
            // 
            // btnImportData
            // 
            btnImportData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnImportData.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnImportData.Depth = 0;
            btnImportData.Dock = System.Windows.Forms.DockStyle.Fill;
            btnImportData.HighEmphasis = true;
            btnImportData.Icon = null;
            btnImportData.Location = new System.Drawing.Point(5, 7);
            btnImportData.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            btnImportData.MouseState = MaterialSkin.MouseState.HOVER;
            btnImportData.Name = "btnImportData";
            btnImportData.NoAccentTextColor = System.Drawing.Color.Empty;
            btnImportData.Size = new System.Drawing.Size(277, 44);
            btnImportData.TabIndex = 3;
            btnImportData.Text = "Import From Excel";
            btnImportData.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnImportData.UseAccentColor = false;
            btnImportData.UseVisualStyleBackColor = true;
            btnImportData.Click += BtnImportData_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnImportData, 0, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(9, 213);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 12, 6, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            tableLayoutPanel1.Size = new System.Drawing.Size(287, 58);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // ImportDatabaseForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(303, 277);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tlbComboBox);
            Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            MinimumSize = new System.Drawing.Size(303, 277);
            Name = "ImportDatabaseForm";
            Padding = new System.Windows.Forms.Padding(5, 85, 5, 3);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Import from Excel";
            tlbComboBox.ResumeLayout(false);
            tlbComboBox.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCheckbox cbCompany;
        private MaterialSkin.Controls.MaterialCheckbox cbProduct;
        private System.Windows.Forms.TableLayoutPanel tlbComboBox;
        private MaterialSkin.Controls.MaterialButton btnImportData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialCheckbox cbCategory;
        private MaterialSkin.Controls.MaterialCheckbox cbType;
    }
}
