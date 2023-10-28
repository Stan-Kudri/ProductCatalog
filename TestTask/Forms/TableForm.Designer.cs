using System.Drawing;

namespace TestTask.Forms
{
    partial class TableForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcData = new System.Windows.Forms.TabControl();
            this.tabPageModes = new System.Windows.Forms.TabPage();
            this.dgvModes = new System.Windows.Forms.DataGridView();
            this.IdMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxBottleNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxUsedTips = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpModesButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteMode = new System.Windows.Forms.Button();
            this.btnEditMode = new System.Windows.Forms.Button();
            this.btnAddMode = new System.Windows.Forms.Button();
            this.tabPageSteps = new System.Windows.Forms.TabPage();
            this.tlpStepsButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteStep = new System.Windows.Forms.Button();
            this.btnAddStep = new System.Windows.Forms.Button();
            this.btnEditStep = new System.Windows.Forms.Button();
            this.dgvSteps = new System.Windows.Forms.DataGridView();
            this.IdStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmImportFromExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaveToExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tcData.SuspendLayout();
            this.tabPageModes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModes)).BeginInit();
            this.tlpModesButton.SuspendLayout();
            this.tabPageSteps.SuspendLayout();
            this.tlpStepsButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSteps)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcData
            // 
            this.tcData.Controls.Add(this.tabPageModes);
            this.tcData.Controls.Add(this.tabPageSteps);
            this.tcData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tcData.Location = new System.Drawing.Point(3, 88);
            this.tcData.Name = "tcData";
            this.tcData.SelectedIndex = 0;
            this.tcData.Size = new System.Drawing.Size(846, 512);
            this.tcData.TabIndex = 0;
            // 
            // tabPageModes
            // 
            this.tabPageModes.Controls.Add(this.dgvModes);
            this.tabPageModes.Controls.Add(this.tlpModesButton);
            this.tabPageModes.Location = new System.Drawing.Point(4, 25);
            this.tabPageModes.Name = "tabPageModes";
            this.tabPageModes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageModes.Size = new System.Drawing.Size(838, 483);
            this.tabPageModes.TabIndex = 0;
            this.tabPageModes.Text = "Modes";
            this.tabPageModes.UseVisualStyleBackColor = true;
            // 
            // dgvModes
            // 
            this.dgvModes.AllowUserToAddRows = false;
            this.dgvModes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvModes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvModes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvModes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvModes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvModes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMode,
            this.NameMode,
            this.MaxBottleNumber,
            this.MaxUsedTips});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModes.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvModes.GridColor = System.Drawing.Color.White;
            this.dgvModes.Location = new System.Drawing.Point(3, 3);
            this.dgvModes.Name = "dgvModes";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModes.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvModes.Size = new System.Drawing.Size(832, 444);
            this.dgvModes.TabIndex = 4;
            // 
            // IdMode
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdMode.DefaultCellStyle = dataGridViewCellStyle2;
            this.IdMode.HeaderText = "    ID";
            this.IdMode.MinimumWidth = 30;
            this.IdMode.Name = "IdMode";
            this.IdMode.ReadOnly = true;
            // 
            // NameMode
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NameMode.DefaultCellStyle = dataGridViewCellStyle3;
            this.NameMode.FillWeight = 120F;
            this.NameMode.HeaderText = "    Name";
            this.NameMode.MinimumWidth = 250;
            this.NameMode.Name = "NameMode";
            this.NameMode.ReadOnly = true;
            // 
            // MaxBottleNumber
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaxBottleNumber.DefaultCellStyle = dataGridViewCellStyle4;
            this.MaxBottleNumber.FillWeight = 120F;
            this.MaxBottleNumber.HeaderText = "    MaxBottleNumber";
            this.MaxBottleNumber.MinimumWidth = 60;
            this.MaxBottleNumber.Name = "MaxBottleNumber";
            this.MaxBottleNumber.ReadOnly = true;
            // 
            // MaxUsedTips
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaxUsedTips.DefaultCellStyle = dataGridViewCellStyle5;
            this.MaxUsedTips.HeaderText = "    MaxUsedTips";
            this.MaxUsedTips.MinimumWidth = 40;
            this.MaxUsedTips.Name = "MaxUsedTips";
            this.MaxUsedTips.ReadOnly = true;
            // 
            // tlpModesButton
            // 
            this.tlpModesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpModesButton.ColumnCount = 3;
            this.tlpModesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpModesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpModesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpModesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpModesButton.Controls.Add(this.btnDeleteMode, 2, 0);
            this.tlpModesButton.Controls.Add(this.btnEditMode, 1, 0);
            this.tlpModesButton.Controls.Add(this.btnAddMode, 0, 0);
            this.tlpModesButton.ForeColor = System.Drawing.Color.Transparent;
            this.tlpModesButton.Location = new System.Drawing.Point(740, 451);
            this.tlpModesButton.Margin = new System.Windows.Forms.Padding(1);
            this.tlpModesButton.MinimumSize = new System.Drawing.Size(95, 29);
            this.tlpModesButton.Name = "tlpModesButton";
            this.tlpModesButton.RowCount = 1;
            this.tlpModesButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpModesButton.Size = new System.Drawing.Size(95, 29);
            this.tlpModesButton.TabIndex = 2;
            this.toolTip.SetToolTip(this.tlpModesButton, "Edit item Mode");
            // 
            // btnDeleteMode
            // 
            this.btnDeleteMode.AutoSize = true;
            this.btnDeleteMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteMode.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDeleteMode.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDeleteMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMode.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteMode.Image")));
            this.btnDeleteMode.Location = new System.Drawing.Point(62, 0);
            this.btnDeleteMode.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteMode.Name = "btnDeleteMode";
            this.btnDeleteMode.Size = new System.Drawing.Size(33, 29);
            this.btnDeleteMode.TabIndex = 7;
            this.toolTip.SetToolTip(this.btnDeleteMode, "Delete item Mode");
            this.btnDeleteMode.UseVisualStyleBackColor = false;
            this.btnDeleteMode.Click += new System.EventHandler(this.BtnDeleteMode_Click);
            // 
            // btnEditMode
            // 
            this.btnEditMode.AutoSize = true;
            this.btnEditMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEditMode.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMode.Image = ((System.Drawing.Image)(resources.GetObject("btnEditMode.Image")));
            this.btnEditMode.Location = new System.Drawing.Point(31, 0);
            this.btnEditMode.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditMode.Name = "btnEditMode";
            this.btnEditMode.Size = new System.Drawing.Size(31, 29);
            this.btnEditMode.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnEditMode, "Edit item Mode");
            this.btnEditMode.UseVisualStyleBackColor = true;
            this.btnEditMode.Click += new System.EventHandler(this.BtnEditMode_Click);
            // 
            // btnAddMode
            // 
            this.btnAddMode.AutoSize = true;
            this.btnAddMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddMode.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAddMode.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMode.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMode.Image")));
            this.btnAddMode.Location = new System.Drawing.Point(0, 0);
            this.btnAddMode.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddMode.Name = "btnAddMode";
            this.btnAddMode.Size = new System.Drawing.Size(31, 29);
            this.btnAddMode.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnAddMode, "Add item Mode");
            this.btnAddMode.UseVisualStyleBackColor = false;
            this.btnAddMode.Click += new System.EventHandler(this.BtnAddMode_Click);
            // 
            // tabPageSteps
            // 
            this.tabPageSteps.Controls.Add(this.tlpStepsButton);
            this.tabPageSteps.Controls.Add(this.dgvSteps);
            this.tabPageSteps.Location = new System.Drawing.Point(4, 22);
            this.tabPageSteps.Name = "tabPageSteps";
            this.tabPageSteps.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSteps.Size = new System.Drawing.Size(838, 486);
            this.tabPageSteps.TabIndex = 1;
            this.tabPageSteps.Text = "Steps";
            this.tabPageSteps.UseVisualStyleBackColor = true;
            // 
            // tlpStepsButton
            // 
            this.tlpStepsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpStepsButton.ColumnCount = 3;
            this.tlpStepsButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpStepsButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpStepsButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpStepsButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpStepsButton.Controls.Add(this.btnDeleteStep, 2, 0);
            this.tlpStepsButton.Controls.Add(this.btnAddStep, 0, 0);
            this.tlpStepsButton.Controls.Add(this.btnEditStep, 1, 0);
            this.tlpStepsButton.ForeColor = System.Drawing.Color.Transparent;
            this.tlpStepsButton.Location = new System.Drawing.Point(740, 453);
            this.tlpStepsButton.Margin = new System.Windows.Forms.Padding(1);
            this.tlpStepsButton.MinimumSize = new System.Drawing.Size(95, 29);
            this.tlpStepsButton.Name = "tlpStepsButton";
            this.tlpStepsButton.RowCount = 1;
            this.tlpStepsButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStepsButton.Size = new System.Drawing.Size(95, 29);
            this.tlpStepsButton.TabIndex = 1;
            // 
            // btnDeleteStep
            // 
            this.btnDeleteStep.AutoSize = true;
            this.btnDeleteStep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteStep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDeleteStep.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDeleteStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStep.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteStep.Image")));
            this.btnDeleteStep.Location = new System.Drawing.Point(62, 0);
            this.btnDeleteStep.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteStep.Name = "btnDeleteStep";
            this.btnDeleteStep.Size = new System.Drawing.Size(33, 29);
            this.btnDeleteStep.TabIndex = 7;
            this.toolTip.SetToolTip(this.btnDeleteStep, "Delete item Mode");
            this.btnDeleteStep.UseVisualStyleBackColor = true;
            this.btnDeleteStep.Click += new System.EventHandler(this.BtnDeleteStep_Click);
            // 
            // btnAddStep
            // 
            this.btnAddStep.AutoSize = true;
            this.btnAddStep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddStep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAddStep.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStep.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStep.Image")));
            this.btnAddStep.Location = new System.Drawing.Point(0, 0);
            this.btnAddStep.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddStep.Name = "btnAddStep";
            this.btnAddStep.Size = new System.Drawing.Size(31, 29);
            this.btnAddStep.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnAddStep, "Add item Mode");
            this.btnAddStep.UseVisualStyleBackColor = true;
            this.btnAddStep.Click += new System.EventHandler(this.BtnAddStep_Click);
            // 
            // btnEditStep
            // 
            this.btnEditStep.AutoSize = true;
            this.btnEditStep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditStep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEditStep.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStep.Image = ((System.Drawing.Image)(resources.GetObject("btnEditStep.Image")));
            this.btnEditStep.Location = new System.Drawing.Point(31, 0);
            this.btnEditStep.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditStep.Name = "btnEditStep";
            this.btnEditStep.Size = new System.Drawing.Size(31, 29);
            this.btnEditStep.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnEditStep, "Edit item Mode");
            this.btnEditStep.UseVisualStyleBackColor = true;
            this.btnEditStep.Click += new System.EventHandler(this.BtnEditStep_Click);
            // 
            // dgvSteps
            // 
            this.dgvSteps.AllowUserToAddRows = false;
            this.dgvSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSteps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSteps.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSteps.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSteps.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSteps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSteps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdStep,
            this.ModeId,
            this.Timer,
            this.Destination,
            this.Speed,
            this.Type,
            this.Volume});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSteps.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSteps.GridColor = System.Drawing.Color.White;
            this.dgvSteps.Location = new System.Drawing.Point(3, 3);
            this.dgvSteps.Name = "dgvSteps";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSteps.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvSteps.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvSteps.Size = new System.Drawing.Size(832, 446);
            this.dgvSteps.TabIndex = 0;
            // 
            // IdStep
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdStep.DefaultCellStyle = dataGridViewCellStyle9;
            this.IdStep.FillWeight = 70F;
            this.IdStep.HeaderText = "    ID";
            this.IdStep.MinimumWidth = 50;
            this.IdStep.Name = "IdStep";
            this.IdStep.ReadOnly = true;
            // 
            // ModeId
            // 
            this.ModeId.FillWeight = 90F;
            this.ModeId.HeaderText = "    ModeId";
            this.ModeId.MinimumWidth = 60;
            this.ModeId.Name = "ModeId";
            this.ModeId.ReadOnly = true;
            // 
            // Timer
            // 
            this.Timer.FillWeight = 80F;
            this.Timer.HeaderText = "    Timer";
            this.Timer.MinimumWidth = 70;
            this.Timer.Name = "Timer";
            this.Timer.ReadOnly = true;
            // 
            // Destination
            // 
            this.Destination.FillWeight = 180F;
            this.Destination.HeaderText = "    Destination";
            this.Destination.MinimumWidth = 160;
            this.Destination.Name = "Destination";
            this.Destination.ReadOnly = true;
            // 
            // Speed
            // 
            this.Speed.FillWeight = 9.885016F;
            this.Speed.HeaderText = "    Speed";
            this.Speed.MinimumWidth = 100;
            this.Speed.Name = "Speed";
            this.Speed.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "    Type";
            this.Type.MinimumWidth = 120;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Volume
            // 
            this.Volume.FillWeight = 90F;
            this.Volume.HeaderText = "    Volume";
            this.Volume.MinimumWidth = 70;
            this.Volume.Name = "Volume";
            this.Volume.ReadOnly = true;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmItemFile});
            this.menuStrip.Location = new System.Drawing.Point(3, 64);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(846, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip";
            // 
            // tsmItemFile
            // 
            this.tsmItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmItemImport,
            this.tsmItemExport,
            this.tsmItemClose});
            this.tsmItemFile.Name = "tsmItemFile";
            this.tsmItemFile.Size = new System.Drawing.Size(37, 20);
            this.tsmItemFile.Text = "File";
            // 
            // tsmItemImport
            // 
            this.tsmItemImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmImportFromExcel});
            this.tsmItemImport.Name = "tsmItemImport";
            this.tsmItemImport.Size = new System.Drawing.Size(139, 22);
            this.tsmItemImport.Text = "Import from";
            // 
            // tsmImportFromExcel
            // 
            this.tsmImportFromExcel.Name = "tsmImportFromExcel";
            this.tsmImportFromExcel.Size = new System.Drawing.Size(101, 22);
            this.tsmImportFromExcel.Text = "Excel";
            this.tsmImportFromExcel.Click += new System.EventHandler(this.TsmImportFromExcel_Click);
            // 
            // tsmItemExport
            // 
            this.tsmItemExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSaveToExcel});
            this.tsmItemExport.Name = "tsmItemExport";
            this.tsmItemExport.Size = new System.Drawing.Size(139, 22);
            this.tsmItemExport.Text = "Export to";
            // 
            // tsmSaveToExcel
            // 
            this.tsmSaveToExcel.Name = "tsmSaveToExcel";
            this.tsmSaveToExcel.Size = new System.Drawing.Size(101, 22);
            this.tsmSaveToExcel.Text = "Excel";
            this.tsmSaveToExcel.Click += new System.EventHandler(this.TsmItemSaveExcel_Click);
            // 
            // tsmItemClose
            // 
            this.tsmItemClose.Name = "tsmItemClose";
            this.tsmItemClose.Size = new System.Drawing.Size(139, 22);
            this.tsmItemClose.Text = "Close";
            this.tsmItemClose.Click += new System.EventHandler(this.TsmItemClose_Click);
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 603);
            this.Controls.Add(this.tcData);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TableForm";
            this.Text = "Table";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TableForm_FormClosing);
            this.Load += new System.EventHandler(this.TableForm_Load);
            this.tcData.ResumeLayout(false);
            this.tabPageModes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModes)).EndInit();
            this.tlpModesButton.ResumeLayout(false);
            this.tlpModesButton.PerformLayout();
            this.tabPageSteps.ResumeLayout(false);
            this.tlpStepsButton.ResumeLayout(false);
            this.tlpStepsButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSteps)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcData;
        private System.Windows.Forms.TabPage tabPageModes;
        private System.Windows.Forms.TabPage tabPageSteps;
        private System.Windows.Forms.DataGridView dgvSteps;
        private System.Windows.Forms.TableLayoutPanel tlpStepsButton;
        private System.Windows.Forms.TableLayoutPanel tlpModesButton;
        private System.Windows.Forms.DataGridView dgvModes;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmItemFile;
        private System.Windows.Forms.ToolStripMenuItem tsmItemImport;
        private System.Windows.Forms.ToolStripMenuItem tsmItemClose;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnAddMode;
        private System.Windows.Forms.Button btnEditMode;
        private System.Windows.Forms.Button btnDeleteMode;
        private System.Windows.Forms.Button btnDeleteStep;
        private System.Windows.Forms.Button btnAddStep;
        private System.Windows.Forms.Button btnEditStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxBottleNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxUsedTips;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
        private System.Windows.Forms.ToolStripMenuItem tsmItemExport;
        private System.Windows.Forms.ToolStripMenuItem tsmImportFromExcel;
        private System.Windows.Forms.ToolStripMenuItem tsmSaveToExcel;
    }
}