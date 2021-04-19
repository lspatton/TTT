namespace TTT
{
    partial class Form1
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
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.HumanGameBtn = new System.Windows.Forms.Button();
            this.AiGameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Location = new System.Drawing.Point(225, 21);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(356, 13);
            this.welcomeLbl.TabIndex = 0;
            this.welcomeLbl.Text = "Welcome to TTT! It\'s the most okayest TicTacToe game you ever played!";
            // 
            // HumanGameBtn
            // 
            this.HumanGameBtn.Location = new System.Drawing.Point(228, 246);
            this.HumanGameBtn.Name = "HumanGameBtn";
            this.HumanGameBtn.Size = new System.Drawing.Size(85, 23);
            this.HumanGameBtn.TabIndex = 1;
            this.HumanGameBtn.Text = "PlayerVsPlayer";
            this.HumanGameBtn.UseVisualStyleBackColor = true;
            this.HumanGameBtn.Click += new System.EventHandler(this.HumanGameBtn_Click);
            // 
            // AiGameBtn
            // 
            this.AiGameBtn.Location = new System.Drawing.Point(505, 246);
            this.AiGameBtn.Name = "AiGameBtn";
            this.AiGameBtn.Size = new System.Drawing.Size(75, 23);
            this.AiGameBtn.TabIndex = 2;
            this.AiGameBtn.Text = "PlayerVsAi";
            this.AiGameBtn.UseVisualStyleBackColor = true;
            this.AiGameBtn.Click += new System.EventHandler(this.AiGameBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AiGameBtn);
            this.Controls.Add(this.HumanGameBtn);
            this.Controls.Add(this.welcomeLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Button HumanGameBtn;
        private System.Windows.Forms.Button AiGameBtn;
    }
}

