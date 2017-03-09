namespace isthatAlive {
    partial class BeforeStartWarning {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeforeStartWarning));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.agreeButton = new System.Windows.Forms.Button();
            this.disagreeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(289, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "경고!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "시작에 앞서, 아래 제한사항을 확인해주시기 바랍니다.";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Location = new System.Drawing.Point(12, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(609, 171);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(9, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "상기 제한사항을 읽고, 사용에 동의하는 경우에만 사용이 가능합니다.\r\n\r\n동의하시겠습니까?";
            // 
            // agreeButton
            // 
            this.agreeButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.agreeButton.Location = new System.Drawing.Point(12, 318);
            this.agreeButton.Name = "agreeButton";
            this.agreeButton.Size = new System.Drawing.Size(302, 47);
            this.agreeButton.TabIndex = 2;
            this.agreeButton.Text = "예, 동의합니다 (&A)";
            this.agreeButton.UseVisualStyleBackColor = true;
            // 
            // disagreeButton
            // 
            this.disagreeButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.disagreeButton.Location = new System.Drawing.Point(320, 318);
            this.disagreeButton.Name = "disagreeButton";
            this.disagreeButton.Size = new System.Drawing.Size(300, 47);
            this.disagreeButton.TabIndex = 3;
            this.disagreeButton.Text = "아니오, 동의하지 않습니다 (&D)";
            this.disagreeButton.UseVisualStyleBackColor = true;
            // 
            // BeforeStartWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 374);
            this.ControlBox = false;
            this.Controls.Add(this.disagreeButton);
            this.Controls.Add(this.agreeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BeforeStartWarning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BeforeStartWarning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button agreeButton;
        private System.Windows.Forms.Button disagreeButton;
    }
}