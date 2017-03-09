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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppMain));
            this.appLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.stage1GroupView = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textURL = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.stage2GroupView = new System.Windows.Forms.GroupBox();
            this.collectView = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.collectGrid = new System.Windows.Forms.DataGridView();
            this.collectDateTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectStatusCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectViewStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.collectViewToolbar = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.collectTimer = new System.Windows.Forms.Timer(this.components);
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.appNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.startOrStopButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.aboutButton = new System.Windows.Forms.ToolStripButton();
            this.appNotifyContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.열기OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료QToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램정보AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.appLayoutPanel.SuspendLayout();
            this.stage1GroupView.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.stage2GroupView.SuspendLayout();
            this.collectView.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collectGrid)).BeginInit();
            this.collectViewStrip.SuspendLayout();
            this.collectViewToolbar.SuspendLayout();
            this.appNotifyContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // appLayoutPanel
            // 
            this.appLayoutPanel.ColumnCount = 1;
            this.appLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.appLayoutPanel.Controls.Add(this.stage1GroupView, 0, 0);
            this.appLayoutPanel.Controls.Add(this.stage2GroupView, 0, 1);
            this.appLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.appLayoutPanel.Name = "appLayoutPanel";
            this.appLayoutPanel.Padding = new System.Windows.Forms.Padding(6);
            this.appLayoutPanel.RowCount = 2;
            this.appLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.appLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.appLayoutPanel.Size = new System.Drawing.Size(1062, 857);
            this.appLayoutPanel.TabIndex = 0;
            // 
            // stage1GroupView
            // 
            this.stage1GroupView.Controls.Add(this.tableLayoutPanel1);
            this.stage1GroupView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stage1GroupView.Font = new System.Drawing.Font("나눔고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stage1GroupView.Location = new System.Drawing.Point(9, 9);
            this.stage1GroupView.Name = "stage1GroupView";
            this.stage1GroupView.Size = new System.Drawing.Size(1044, 134);
            this.stage1GroupView.TabIndex = 0;
            this.stage1GroupView.TabStop = false;
            this.stage1GroupView.Text = "Stage 1 : 기본 설정";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1038, 112);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(35, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Duration :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(25, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "사이트 주소 :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(42, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Interval :";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.numericUpDown1);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(103, 39);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(158, 27);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numericUpDown1.Location = new System.Drawing.Point(3, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 21);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(59, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Min (Max 1440)";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.textURL);
            this.flowLayoutPanel2.Controls.Add(this.btnValidate);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(103, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(654, 29);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // textURL
            // 
            this.textURL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textURL.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textURL.Location = new System.Drawing.Point(3, 4);
            this.textURL.Name = "textURL";
            this.textURL.Size = new System.Drawing.Size(567, 21);
            this.textURL.TabIndex = 1;
            // 
            // btnValidate
            // 
            this.btnValidate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnValidate.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnValidate.Location = new System.Drawing.Point(576, 3);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 2;
            this.btnValidate.Text = "확인(&V)";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.radioButton1);
            this.flowLayoutPanel3.Controls.Add(this.radioButton2);
            this.flowLayoutPanel3.Controls.Add(this.radioButton3);
            this.flowLayoutPanel3.Controls.Add(this.radioButton4);
            this.flowLayoutPanel3.Controls.Add(this.radioButton5);
            this.flowLayoutPanel3.Controls.Add(this.radioButton6);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(103, 75);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(366, 24);
            this.flowLayoutPanel3.TabIndex = 11;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 18);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "10분";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton2.Location = new System.Drawing.Point(59, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 18);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.Text = "30분";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton3.Location = new System.Drawing.Point(115, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(54, 18);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.Text = "1시간";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton4.Location = new System.Drawing.Point(175, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(54, 18);
            this.radioButton4.TabIndex = 14;
            this.radioButton4.Text = "6시간";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton5.Location = new System.Drawing.Point(235, 3);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(61, 18);
            this.radioButton5.TabIndex = 15;
            this.radioButton5.Text = "12시간";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton6.Location = new System.Drawing.Point(302, 3);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(61, 18);
            this.radioButton6.TabIndex = 16;
            this.radioButton6.Text = "24시간";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // stage2GroupView
            // 
            this.stage2GroupView.Controls.Add(this.collectView);
            this.stage2GroupView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stage2GroupView.Font = new System.Drawing.Font("나눔고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stage2GroupView.Location = new System.Drawing.Point(9, 149);
            this.stage2GroupView.Name = "stage2GroupView";
            this.stage2GroupView.Size = new System.Drawing.Size(1044, 699);
            this.stage2GroupView.TabIndex = 1;
            this.stage2GroupView.TabStop = false;
            this.stage2GroupView.Text = "Stage 2 : 사이트 상태 수집";
            // 
            // collectView
            // 
            this.collectView.Controls.Add(this.panel1);
            this.collectView.Controls.Add(this.collectViewStrip);
            this.collectView.Controls.Add(this.collectViewToolbar);
            this.collectView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collectView.Location = new System.Drawing.Point(3, 19);
            this.collectView.Name = "collectView";
            this.collectView.Size = new System.Drawing.Size(1038, 677);
            this.collectView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.collectGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1038, 630);
            this.panel1.TabIndex = 2;
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
            this.collectGrid.Location = new System.Drawing.Point(5, 5);
            this.collectGrid.Name = "collectGrid";
            this.collectGrid.ReadOnly = true;
            this.collectGrid.RowTemplate.Height = 23;
            this.collectGrid.Size = new System.Drawing.Size(1028, 620);
            this.collectGrid.TabIndex = 3;
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
            // collectViewStrip
            // 
            this.collectViewStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.collectViewStrip.Location = new System.Drawing.Point(0, 655);
            this.collectViewStrip.Name = "collectViewStrip";
            this.collectViewStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.collectViewStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.collectViewStrip.Size = new System.Drawing.Size(1038, 22);
            this.collectViewStrip.SizingGrip = false;
            this.collectViewStrip.TabIndex = 1;
            this.collectViewStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(26, 17);
            this.statusLabel.Text = "Idle";
            // 
            // collectViewToolbar
            // 
            this.collectViewToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startOrStopButton,
            this.saveButton,
            this.toolStripSeparator,
            this.aboutButton});
            this.collectViewToolbar.Location = new System.Drawing.Point(0, 0);
            this.collectViewToolbar.Name = "collectViewToolbar";
            this.collectViewToolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.collectViewToolbar.Size = new System.Drawing.Size(1038, 25);
            this.collectViewToolbar.TabIndex = 0;
            this.collectViewToolbar.Text = "toolStrip1";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // collectTimer
            // 
            this.collectTimer.Tick += new System.EventHandler(this.collectTimer_Tick);
            // 
            // appNotifyIcon
            // 
            this.appNotifyIcon.ContextMenuStrip = this.appNotifyContextMenu;
            this.appNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("appNotifyIcon.Icon")));
            this.appNotifyIcon.Text = "Is that Alive";
            this.appNotifyIcon.DoubleClick += new System.EventHandler(this.appNotifyIcon_DoubleClick);
            // 
            // startOrStopButton
            // 
            this.startOrStopButton.Image = global::isthatAlive.Properties.Resources.Run_16x;
            this.startOrStopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startOrStopButton.Name = "startOrStopButton";
            this.startOrStopButton.Size = new System.Drawing.Size(51, 22);
            this.startOrStopButton.Text = "시작";
            this.startOrStopButton.Click += new System.EventHandler(this.startOrStopButton_Click);
            this.startOrStopButton.MouseLeave += new System.EventHandler(this.startOrStopButton_MouseLeave);
            this.startOrStopButton.MouseHover += new System.EventHandler(this.startOrStopButton_MouseHover);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Enabled = false;
            this.saveButton.Image = global::isthatAlive.Properties.Resources.Save_16x;
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(23, 22);
            this.saveButton.Text = "수집 결과를 엑셀로 저장하기";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            this.saveButton.MouseLeave += new System.EventHandler(this.startOrStopButton_MouseLeave);
            this.saveButton.MouseHover += new System.EventHandler(this.saveButton_MouseHover);
            // 
            // aboutButton
            // 
            this.aboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aboutButton.Image = global::isthatAlive.Properties.Resources.StatusInformation_16x;
            this.aboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(23, 22);
            this.aboutButton.Text = "이 프로그램의 정보";
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            this.aboutButton.MouseLeave += new System.EventHandler(this.startOrStopButton_MouseLeave);
            this.aboutButton.MouseHover += new System.EventHandler(this.aboutButton_MouseHover);
            // 
            // appNotifyContextMenu
            // 
            this.appNotifyContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기OToolStripMenuItem,
            this.프로그램정보AToolStripMenuItem,
            this.toolStripSeparator1,
            this.종료QToolStripMenuItem});
            this.appNotifyContextMenu.Name = "appNotifyContextMenu";
            this.appNotifyContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.appNotifyContextMenu.Size = new System.Drawing.Size(167, 98);
            // 
            // 열기OToolStripMenuItem
            // 
            this.열기OToolStripMenuItem.Name = "열기OToolStripMenuItem";
            this.열기OToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.열기OToolStripMenuItem.Text = "열기(&O)";
            this.열기OToolStripMenuItem.Click += new System.EventHandler(this.appNotifyIcon_DoubleClick);
            // 
            // 종료QToolStripMenuItem
            // 
            this.종료QToolStripMenuItem.Name = "종료QToolStripMenuItem";
            this.종료QToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.종료QToolStripMenuItem.ShowShortcutKeys = false;
            this.종료QToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.종료QToolStripMenuItem.Text = "종료(&Q)";
            this.종료QToolStripMenuItem.Click += new System.EventHandler(this.종료QToolStripMenuItem_Click);
            // 
            // 프로그램정보AToolStripMenuItem
            // 
            this.프로그램정보AToolStripMenuItem.Name = "프로그램정보AToolStripMenuItem";
            this.프로그램정보AToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.프로그램정보AToolStripMenuItem.Text = "프로그램 정보(&A)";
            this.프로그램정보AToolStripMenuItem.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // AppMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 857);
            this.Controls.Add(this.appLayoutPanel);
            this.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppMain";
            this.Text = "Is that Alive?";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppMain_FormClosing);
            this.Load += new System.EventHandler(this.AppMain_Load);
            this.appLayoutPanel.ResumeLayout(false);
            this.stage1GroupView.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.stage2GroupView.ResumeLayout(false);
            this.collectView.ResumeLayout(false);
            this.collectView.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.collectGrid)).EndInit();
            this.collectViewStrip.ResumeLayout(false);
            this.collectViewStrip.PerformLayout();
            this.collectViewToolbar.ResumeLayout(false);
            this.collectViewToolbar.PerformLayout();
            this.appNotifyContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel appLayoutPanel;
        private System.Windows.Forms.GroupBox stage1GroupView;
        private System.Windows.Forms.GroupBox stage2GroupView;
        private System.Windows.Forms.Panel collectView;
        private System.Windows.Forms.StatusStrip collectViewStrip;
        private System.Windows.Forms.ToolStrip collectViewToolbar;
        private System.Windows.Forms.ToolStripButton startOrStopButton;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView collectGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectDateTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectStatusCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectStatusColumn;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton aboutButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox textURL;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Timer collectTimer;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.NotifyIcon appNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip appNotifyContextMenu;
        private System.Windows.Forms.ToolStripMenuItem 열기OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로그램정보AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 종료QToolStripMenuItem;
    }
}