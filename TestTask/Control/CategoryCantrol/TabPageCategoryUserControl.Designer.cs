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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelCmb = new System.Windows.Forms.TableLayoutPanel();
            this.cmbSortName = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sortPageCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listViewCategoryControl = new TestTask.Control.CategoryCantrol.ListViewCategoryControl();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanelCmb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortPageCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanelCmb, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.listViewCategoryControl, 0, 1);
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(755, 295);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanelCmb
            // 
            this.tableLayoutPanelCmb.ColumnCount = 1;
            this.tableLayoutPanelCmb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCmb.Controls.Add(this.cmbSortName, 0, 0);
            this.tableLayoutPanelCmb.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelCmb.Name = "tableLayoutPanelCmb";
            this.tableLayoutPanelCmb.RowCount = 1;
            this.tableLayoutPanelCmb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCmb.Size = new System.Drawing.Size(200, 24);
            this.tableLayoutPanelCmb.TabIndex = 0;
            // 
            // cmbSortName
            // 
            this.cmbSortName.DataSource = this.itemsBindingSource;
            this.cmbSortName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSortName.FormattingEnabled = true;
            this.cmbSortName.Location = new System.Drawing.Point(3, 3);
            this.cmbSortName.Name = "cmbSortName";
            this.cmbSortName.Size = new System.Drawing.Size(194, 21);
            this.cmbSortName.TabIndex = 0;
            this.cmbSortName.SelectedIndexChanged += new System.EventHandler(this.CmbSortName_Changed);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.sortPageCategoryBindingSource;
            // 
            // sortPageCategoryBindingSource
            // 
            this.sortPageCategoryBindingSource.DataSource = typeof(TestTask.BindingItem.Pages.SortPageCategory);
            // 
            // listViewCategoryControl
            // 
            this.listViewCategoryControl.Depth = 0;
            this.listViewCategoryControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCategoryControl.Location = new System.Drawing.Point(3, 33);
            this.listViewCategoryControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.listViewCategoryControl.Name = "listViewCategoryControl";
            this.listViewCategoryControl.Size = new System.Drawing.Size(749, 262);
            this.listViewCategoryControl.TabIndex = 1;
            // 
            // TabPageCategoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "TabPageCategoryUserControl";
            this.Size = new System.Drawing.Size(755, 296);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanelCmb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortPageCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCmb;
        private System.Windows.Forms.ComboBox cmbSortName;
        private System.Windows.Forms.BindingSource sortPageCategoryBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private ListViewCategoryControl listViewCategoryControl;
    }
}
