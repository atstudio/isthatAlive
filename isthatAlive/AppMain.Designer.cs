namespace isthatAlive
{
    partial class AppMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppMain));
            this.appLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.stage1GroupView = new System.Windows.Forms.GroupBox();
            this.stage2GroupView = new System.Windows.Forms.GroupBox();
            this.collectView = new System.Windows.Forms.Panel();
            this.collectViewToolbar = new System.Windows.Forms.ToolStrip();
            this.collectViewStrip = new System.Windows.Forms.StatusStrip();
            this.collectGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.collectDateTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectStatusCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.appLayoutPanel.SuspendLayout();
            this.stage1GroupView.SuspendLayout();
            this.stage2GroupView.SuspendLayout();
            this.collectView.SuspendLayout();
            this.collectViewToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collectGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // appLayoutPanel
            // 
            this.appLayoutPanel.ColumnCount = 1;
            this.appLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.appLayoutPanel.Controls.Add(this.stage1GroupView, 0, 0);
            this.appLayoutPanel.Controls.Add(this.stage2GroupView, 0, 1);
            this.appLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.appLayoutPanel.Name = "appLayoutPanel";
            this.appLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.appLayoutPanel.RowCount = 2;
            this.appLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.57434F));
            this.appLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.42566F));
            this.appLayoutPanel.Size = new System.Drawing.Size(929, 686);
            this.appLayoutPanel.TabIndex = 0;
            // 
            // stage1GroupView
            // 
            this.stage1GroupView.Controls.Add(this.label3);
            this.stage1GroupView.Controls.Add(this.numericUpDown1);
            this.stage1GroupView.Controls.Add(this.label2);
            this.stage1GroupView.Controls.Add(this.textBox1);
            this.stage1GroupView.Controls.Add(this.label1);
            this.stage1GroupView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stage1GroupView.Location = new System.Drawing.Point(8, 8);
            this.stage1GroupView.Name = "stage1GroupView";
            this.stage1GroupView.Size = new System.Drawing.Size(913, 139);
            this.stage1GroupView.TabIndex = 0;
            this.stage1GroupView.TabStop = false;
            this.stage1GroupView.Text = "Stage 1 : 기본 설정";
            // 
            // stage2GroupView
            // 
            this.stage2GroupView.Controls.Add(this.collectView);
            this.stage2GroupView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stage2GroupView.Location = new System.Drawing.Point(8, 153);
            this.stage2GroupView.Name = "stage2GroupView";
            this.stage2GroupView.Size = new System.Drawing.Size(913, 525);
            this.stage2GroupView.TabIndex = 1;
            this.stage2GroupView.TabStop = false;
            this.stage2GroupView.Text = "Stage 2 : 사이트 상태 수집";
            // 
            // collectView
            // 
            this.collectView.Controls.Add(this.collectGrid);
            this.collectView.Controls.Add(this.collectViewStrip);
            this.collectView.Controls.Add(this.collectViewToolbar);
            this.collectView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collectView.Location = new System.Drawing.Point(3, 17);
            this.collectView.Name = "collectView";
            this.collectView.Size = new System.Drawing.Size(907, 505);
            this.collectView.TabIndex = 0;
            // 
            // collectViewToolbar
            // 
            this.collectViewToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.collectViewToolbar.Location = new System.Drawing.Point(0, 0);
            this.collectViewToolbar.Name = "collectViewToolbar";
            this.collectViewToolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.collectViewToolbar.Size = new System.Drawing.Size(907, 25);
            this.collectViewToolbar.TabIndex = 0;
            this.collectViewToolbar.Text = "toolStrip1";
            // 
            // collectViewStrip
            // 
            this.collectViewStrip.Location = new System.Drawing.Point(0, 483);
            this.collectViewStrip.Name = "collectViewStrip";
            this.collectViewStrip.Size = new System.Drawing.Size(907, 22);
            this.collectViewStrip.TabIndex = 1;
            this.collectViewStrip.Text = "statusStrip1";
            // 
            // collectGrid
            // 
            this.collectGrid.AllowUserToAddRows = false;
            this.collectGrid.AllowUserToDeleteRows = false;
            this.collectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.collectGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.collectDateTimeColumn,
            this.collectStatusCodeColumn,
            this.collectStatusColumn});
            this.collectGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collectGrid.Location = new System.Drawing.Point(0, 25);
            this.collectGrid.Name = "collectGrid";
            this.collectGrid.ReadOnly = true;
            this.collectGrid.RowTemplate.Height = 23;
            this.collectGrid.Size = new System.Drawing.Size(907, 458);
            this.collectGrid.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "사이트 주소 : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Interval : ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(69, 53);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Min";
            // 
            // collectDateTimeColumn
            // 
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = "N/A";
            this.collectDateTimeColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.collectDateTimeColumn.HeaderText = "일시";
            this.collectDateTimeColumn.Name = "collectDateTimeColumn";
            this.collectDateTimeColumn.ReadOnly = true;
            // 
            // collectStatusCodeColumn
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "000";
            this.collectStatusCodeColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.collectStatusCodeColumn.HeaderText = "상태 코드";
            this.collectStatusCodeColumn.Name = "collectStatusCodeColumn";
            this.collectStatusCodeColumn.ReadOnly = true;
            // 
            // collectStatusColumn
            // 
            dataGridViewCellStyle3.NullValue = "N/A";
            this.collectStatusColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.collectStatusColumn.HeaderText = "상태 (상세)";
            this.collectStatusColumn.Name = "collectStatusColumn";
            this.collectStatusColumn.ReadOnly = true;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // AppMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 686);
            this.Controls.Add(this.appLayoutPanel);
            this.Name = "AppMain";
            this.Text = "Is that Alive?";
            this.appLayoutPanel.ResumeLayout(false);
            this.stage1GroupView.ResumeLayout(false);
            this.stage1GroupView.PerformLayout();
            this.stage2GroupView.ResumeLayout(false);
            this.collectView.ResumeLayout(false);
            this.collectView.PerformLayout();
            this.collectViewToolbar.ResumeLayout(false);
            this.collectViewToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collectGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel appLayoutPanel;
        private System.Windows.Forms.GroupBox stage1GroupView;
        private System.Windows.Forms.GroupBox stage2GroupView;
        private System.Windows.Forms.Panel collectView;
        private System.Windows.Forms.DataGridView collectGrid;
        private System.Windows.Forms.StatusStrip collectViewStrip;
        private System.Windows.Forms.ToolStrip collectViewToolbar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectDateTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectStatusCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectStatusColumn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}