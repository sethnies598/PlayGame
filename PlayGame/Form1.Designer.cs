namespace PlayGame
{
    partial class VideoGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoGame));
            this.startButton = new System.Windows.Forms.Button();
            this.countDown = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.Font = new System.Drawing.Font("Poor Richard", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.startButton.Location = new System.Drawing.Point(203, 244);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(416, 117);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "START GAME";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // countDown
            // 
            this.countDown.Font = new System.Drawing.Font("Poor Richard", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDown.ForeColor = System.Drawing.Color.LimeGreen;
            this.countDown.Location = new System.Drawing.Point(12, 120);
            this.countDown.Name = "countDown";
            this.countDown.Size = new System.Drawing.Size(776, 121);
            this.countDown.TabIndex = 1;
            this.countDown.Text = "Video Game";
            this.countDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countDown.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(644, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 61);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // VideoGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countDown);
            this.Controls.Add(this.startButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VideoGame";
            this.Text = "VideoGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label countDown;
        private System.Windows.Forms.Label label1;
    }
}

