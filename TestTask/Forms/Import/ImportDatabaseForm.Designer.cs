namespace TestTask.ChildForms.Import
{
    partial class ImportDatabaseForm
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
            this.cbModes = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbStep = new MaterialSkin.Controls.MaterialCheckbox();
            this.tlbComboBox = new System.Windows.Forms.TableLayoutPanel();
            this.btnImportData = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlbComboBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbModes
            // 
            this.cbModes.AutoSize = true;
            this.cbModes.Checked = true;
            this.cbModes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbModes.Depth = 0;
            this.cbModes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbModes.Location = new System.Drawing.Point(0, 0);
            this.cbModes.Margin = new System.Windows.Forms.Padding(0);
            this.cbModes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbModes.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbModes.Name = "cbModes";
            this.cbModes.ReadOnly = false;
            this.cbModes.Ripple = true;
            this.cbModes.Size = new System.Drawing.Size(123, 40);
            this.cbModes.TabIndex = 0;
            this.cbModes.Text = "Modes";
            this.cbModes.UseVisualStyleBackColor = true;
            // 
            // cbStep
            // 
            this.cbStep.AutoSize = true;
            this.cbStep.Checked = true;
            this.cbStep.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStep.Depth = 0;
            this.cbStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbStep.Location = new System.Drawing.Point(123, 0);
            this.cbStep.Margin = new System.Windows.Forms.Padding(0);
            this.cbStep.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbStep.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbStep.Name = "cbStep";
            this.cbStep.ReadOnly = false;
            this.cbStep.Ripple = true;
            this.cbStep.Size = new System.Drawing.Size(123, 40);
            this.cbStep.TabIndex = 1;
            this.cbStep.Text = "Step";
            this.cbStep.UseVisualStyleBackColor = true;
            // 
            // tlbComboBox
            // 
            this.tlbComboBox.ColumnCount = 2;
            this.tlbComboBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbComboBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbComboBox.Controls.Add(this.cbModes, 0, 0);
            this.tlbComboBox.Controls.Add(this.cbStep, 1, 0);
            this.tlbComboBox.Location = new System.Drawing.Point(8, 72);
            this.tlbComboBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tlbComboBox.Name = "tlbComboBox";
            this.tlbComboBox.RowCount = 1;
            this.tlbComboBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbComboBox.Size = new System.Drawing.Size(246, 40);
            this.tlbComboBox.TabIndex = 2;
            // 
            // btnImportData
            // 
            this.btnImportData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImportData.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnImportData.Depth = 0;
            this.btnImportData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImportData.HighEmphasis = true;
            this.btnImportData.Icon = null;
            this.btnImportData.Location = new System.Drawing.Point(4, 6);
            this.btnImportData.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImportData.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnImportData.Size = new System.Drawing.Size(238, 38);
            this.btnImportData.TabIndex = 3;
            this.btnImportData.Text = "Import From Excel";
            this.btnImportData.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnImportData.UseAccentColor = false;
            this.btnImportData.UseVisualStyleBackColor = true;
            this.btnImportData.Click += new System.EventHandler(this.BtnImportData_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnImportData, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 114);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(246, 50);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // ImportDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 170);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tlbComboBox);
            this.MinimumSize = new System.Drawing.Size(260, 170);
            this.Name = "ImportDatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import from Excel";
            this.tlbComboBox.ResumeLayout(false);
            this.tlbComboBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCheckbox cbModes;
        private MaterialSkin.Controls.MaterialCheckbox cbStep;
        private System.Windows.Forms.TableLayoutPanel tlbComboBox;
        private MaterialSkin.Controls.MaterialButton btnImportData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}