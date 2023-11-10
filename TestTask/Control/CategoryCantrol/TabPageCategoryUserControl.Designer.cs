using TestTask.Core.Models.Categories;

namespace TestTask.Control.CategoryCantrol
{
    partial class TabPageCategoryUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tlpFilterAndSort = new System.Windows.Forms.TableLayoutPanel();
            this.listViewCategoryControl = new TestTask.Control.CategoryCantrol.ListViewControl();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.tlpFilterAndSort, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.listViewCategoryControl, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(755, 331);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // tlpFilterAndSort
            // 
            this.tlpFilterAndSort.ColumnCount = 1;
            this.tlpFilterAndSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilterAndSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFilterAndSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFilterAndSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFilterAndSort.Location = new System.Drawing.Point(3, 3);
            this.tlpFilterAndSort.Name = "tlpFilterAndSort";
            this.tlpFilterAndSort.RowCount = 1;
            this.tlpFilterAndSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilterAndSort.Size = new System.Drawing.Size(749, 24);
            this.tlpFilterAndSort.TabIndex = 0;
            // 
            // listViewCategoryControl
            // 
            this.listViewCategoryControl.AutoSize = true;
            this.listViewCategoryControl.Depth = 0;
            this.listViewCategoryControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCategoryControl.Location = new System.Drawing.Point(3, 33);
            this.listViewCategoryControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.listViewCategoryControl.Name = "listViewCategoryControl";
            this.listViewCategoryControl.Size = new System.Drawing.Size(749, 295);
            this.listViewCategoryControl.TabIndex = 1;
            // 
            // TabPageCategoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "TabPageCategoryUserControl";
            this.Size = new System.Drawing.Size(755, 331);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tlpFilterAndSort;
        private ListViewControl listViewCategoryControl;
    }
}
