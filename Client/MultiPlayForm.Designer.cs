namespace Client
{
    partial class MultiPlayForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RoomTextBox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox1.Location = new System.Drawing.Point(32, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 786);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // RoomTextBox
            // 
            this.RoomTextBox.Location = new System.Drawing.Point(863, 25);
            this.RoomTextBox.Name = "RoomTextBox";
            this.RoomTextBox.Size = new System.Drawing.Size(245, 25);
            this.RoomTextBox.TabIndex = 1;
            this.RoomTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RoomTextBox.TextChanged += new System.EventHandler(this.RoomTextBox_TextChanged);
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(1167, 25);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(100, 40);
            this.EnterButton.TabIndex = 2;
            this.EnterButton.Text = "Connect";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(1008, 113);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(100, 40);
            this.PlayButton.TabIndex = 3;
            this.PlayButton.Text = "PlayButton";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(934, 177);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(245, 25);
            this.Status.TabIndex = 4;
            this.Status.Text = "방을 입력하여 접속해주세요";
            this.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MultiPlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 1053);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.RoomTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MultiPlayForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MultiPlayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox RoomTextBox;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.TextBox Status;
    }
}