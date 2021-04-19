namespace TTT
{
    partial class AiGameForm
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
            this.Ai_GamePlayerTitle_lbl = new System.Windows.Forms.Label();
            this.AiGamePlayerlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ai_GamePlayerTitle_lbl
            // 
            this.Ai_GamePlayerTitle_lbl.AutoSize = true;
            this.Ai_GamePlayerTitle_lbl.Location = new System.Drawing.Point(613, 81);
            this.Ai_GamePlayerTitle_lbl.Name = "Ai_GamePlayerTitle_lbl";
            this.Ai_GamePlayerTitle_lbl.Size = new System.Drawing.Size(73, 13);
            this.Ai_GamePlayerTitle_lbl.TabIndex = 0;
            this.Ai_GamePlayerTitle_lbl.Text = "Current Player";
            // 
            // AiGamePlayerlbl
            // 
            this.AiGamePlayerlbl.AutoSize = true;
            this.AiGamePlayerlbl.Location = new System.Drawing.Point(616, 108);
            this.AiGamePlayerlbl.Name = "AiGamePlayerlbl";
            this.AiGamePlayerlbl.Size = new System.Drawing.Size(35, 13);
            this.AiGamePlayerlbl.TabIndex = 1;
            this.AiGamePlayerlbl.Text = "label1";
            // 
            // AiGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AiGamePlayerlbl);
            this.Controls.Add(this.Ai_GamePlayerTitle_lbl);
            this.Name = "AiGameForm";
            this.Text = "AiGameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ai_GamePlayerTitle_lbl;
        private System.Windows.Forms.Label AiGamePlayerlbl;
    }
}