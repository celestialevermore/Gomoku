﻿namespace Client
{
    partial class MenuForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.SinglePlayButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.MultiPlayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SinglePlayButton
            // 
            this.SinglePlayButton.Location = new System.Drawing.Point(226, 92);
            this.SinglePlayButton.Name = "SinglePlayButton";
            this.SinglePlayButton.Size = new System.Drawing.Size(100, 40);
            this.SinglePlayButton.TabIndex = 0;
            this.SinglePlayButton.Text = "혼자하기";
            this.SinglePlayButton.UseVisualStyleBackColor = true;
            this.SinglePlayButton.Click += new System.EventHandler(this.SinglePlayButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(226, 209);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 40);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "종료하기";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // MultiPlayButton
            // 
            this.MultiPlayButton.Location = new System.Drawing.Point(226, 149);
            this.MultiPlayButton.Name = "MultiPlayButton";
            this.MultiPlayButton.Size = new System.Drawing.Size(100, 40);
            this.MultiPlayButton.TabIndex = 2;
            this.MultiPlayButton.Text = "함께하기";
            this.MultiPlayButton.UseVisualStyleBackColor = true;
            this.MultiPlayButton.Click += new System.EventHandler(this.MultiPlayButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.MultiPlayButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.SinglePlayButton);
            this.Name = "MenuForm";
            this.Text = "Gomoku Game Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SinglePlayButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button MultiPlayButton;
    }
}

