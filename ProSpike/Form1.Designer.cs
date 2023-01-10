namespace ProSpike
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleText = new System.Windows.Forms.Label();
            this.OffHBallBtn = new System.Windows.Forms.Button();
            this.OffSlideBtn = new System.Windows.Forms.Button();
            this.MidHBall = new System.Windows.Forms.Button();
            this.BackPipeBtn = new System.Windows.Forms.Button();
            this.PwrShootBtn = new System.Windows.Forms.Button();
            this.BackCBtn = new System.Windows.Forms.Button();
            this.PwrHBallBtn = new System.Windows.Forms.Button();
            this.Custom = new System.Windows.Forms.Button();
            this.MidQuickBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleText.Location = new System.Drawing.Point(397, 25);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(210, 50);
            this.titleText.TabIndex = 1;
            this.titleText.Text = "Select a Set";
            // 
            // OffHBallBtn
            // 
            this.OffHBallBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OffHBallBtn.Location = new System.Drawing.Point(33, 320);
            this.OffHBallBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OffHBallBtn.Name = "OffHBallBtn";
            this.OffHBallBtn.Size = new System.Drawing.Size(219, 48);
            this.OffHBallBtn.TabIndex = 5;
            this.OffHBallBtn.Text = "Offside High Ball";
            this.OffHBallBtn.UseVisualStyleBackColor = true;
            this.OffHBallBtn.Click += new System.EventHandler(this.OffHBallBtn_Click);
            // 
            // OffSlideBtn
            // 
            this.OffSlideBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OffSlideBtn.Location = new System.Drawing.Point(33, 396);
            this.OffSlideBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OffSlideBtn.Name = "OffSlideBtn";
            this.OffSlideBtn.Size = new System.Drawing.Size(219, 48);
            this.OffSlideBtn.TabIndex = 6;
            this.OffSlideBtn.Text = "Offside Slide";
            this.OffSlideBtn.UseVisualStyleBackColor = true;
            this.OffSlideBtn.Click += new System.EventHandler(this.OffSlideBtn_Click);
            // 
            // MidHBall
            // 
            this.MidHBall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MidHBall.Location = new System.Drawing.Point(33, 168);
            this.MidHBall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MidHBall.Name = "MidHBall";
            this.MidHBall.Size = new System.Drawing.Size(219, 48);
            this.MidHBall.TabIndex = 3;
            this.MidHBall.Text = "Middle High Ball";
            this.MidHBall.UseVisualStyleBackColor = true;
            this.MidHBall.Click += new System.EventHandler(this.MidHBall_Click);
            // 
            // BackPipeBtn
            // 
            this.BackPipeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackPipeBtn.Location = new System.Drawing.Point(33, 472);
            this.BackPipeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackPipeBtn.Name = "BackPipeBtn";
            this.BackPipeBtn.Size = new System.Drawing.Size(219, 48);
            this.BackPipeBtn.TabIndex = 7;
            this.BackPipeBtn.Text = "Backrow Pipe";
            this.BackPipeBtn.UseVisualStyleBackColor = true;
            this.BackPipeBtn.Click += new System.EventHandler(this.BackPipeBtn_Click);
            // 
            // PwrShootBtn
            // 
            this.PwrShootBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PwrShootBtn.Location = new System.Drawing.Point(33, 92);
            this.PwrShootBtn.Margin = new System.Windows.Forms.Padding(0, 4, 3, 4);
            this.PwrShootBtn.Name = "PwrShootBtn";
            this.PwrShootBtn.Size = new System.Drawing.Size(219, 48);
            this.PwrShootBtn.TabIndex = 2;
            this.PwrShootBtn.Text = "Power Shoot";
            this.PwrShootBtn.UseVisualStyleBackColor = true;
            this.PwrShootBtn.Click += new System.EventHandler(this.PwrShootBtn_Click);
            // 
            // BackCBtn
            // 
            this.BackCBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackCBtn.Location = new System.Drawing.Point(33, 548);
            this.BackCBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackCBtn.Name = "BackCBtn";
            this.BackCBtn.Size = new System.Drawing.Size(219, 48);
            this.BackCBtn.TabIndex = 8;
            this.BackCBtn.Text = "Backrow C";
            this.BackCBtn.UseVisualStyleBackColor = true;
            this.BackCBtn.Click += new System.EventHandler(this.BackCBtn_Click);
            // 
            // PwrHBallBtn
            // 
            this.PwrHBallBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PwrHBallBtn.Location = new System.Drawing.Point(33, 16);
            this.PwrHBallBtn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.PwrHBallBtn.Name = "PwrHBallBtn";
            this.PwrHBallBtn.Size = new System.Drawing.Size(219, 48);
            this.PwrHBallBtn.TabIndex = 0;
            this.PwrHBallBtn.Text = "Power High Ball";
            this.PwrHBallBtn.UseVisualStyleBackColor = true;
            this.PwrHBallBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Custom
            // 
            this.Custom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Custom.Location = new System.Drawing.Point(33, 624);
            this.Custom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Custom.Name = "Custom";
            this.Custom.Size = new System.Drawing.Size(219, 48);
            this.Custom.TabIndex = 9;
            this.Custom.Text = "Custom";
            this.Custom.UseVisualStyleBackColor = true;
            this.Custom.Click += new System.EventHandler(this.Custom_Click);
            // 
            // MidQuickBtn
            // 
            this.MidQuickBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MidQuickBtn.Location = new System.Drawing.Point(33, 244);
            this.MidQuickBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MidQuickBtn.Name = "MidQuickBtn";
            this.MidQuickBtn.Size = new System.Drawing.Size(219, 48);
            this.MidQuickBtn.TabIndex = 4;
            this.MidQuickBtn.Text = "Middle Quick";
            this.MidQuickBtn.UseVisualStyleBackColor = true;
            this.MidQuickBtn.Click += new System.EventHandler(this.MidQuickBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.MidQuickBtn);
            this.groupBox1.Controls.Add(this.Custom);
            this.groupBox1.Controls.Add(this.PwrHBallBtn);
            this.groupBox1.Controls.Add(this.BackCBtn);
            this.groupBox1.Controls.Add(this.PwrShootBtn);
            this.groupBox1.Controls.Add(this.BackPipeBtn);
            this.groupBox1.Controls.Add(this.MidHBall);
            this.groupBox1.Controls.Add(this.OffSlideBtn);
            this.groupBox1.Controls.Add(this.OffHBallBtn);
            this.groupBox1.Location = new System.Drawing.Point(1056, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(272, 699);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 723);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.titleText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private Button PwrHBallBtn;
        private Label titleText;
        private Button PwrShootBtn;
        private Button MidHBall;
        private Button MidQuickBtn;
        private Button OffHBallBtn;
        private Button OffSlideBtn;
        private Button BackPipeBtn;
        private Button BackCBtn;
        private Button Custom;
        private GroupBox groupBox1;
    }
}