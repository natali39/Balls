namespace TryCatchMe
{
    partial class TryCatchForm
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
            this.StartButton = new System.Windows.Forms.Button();
            this.CatchButton = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 22);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 37);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // CatchButton
            // 
            this.CatchButton.Location = new System.Drawing.Point(12, 81);
            this.CatchButton.Name = "CatchButton";
            this.CatchButton.Size = new System.Drawing.Size(75, 37);
            this.CatchButton.TabIndex = 1;
            this.CatchButton.Text = "Поймать шарик";
            this.CatchButton.UseVisualStyleBackColor = true;
            this.CatchButton.Click += new System.EventHandler(this.CatchButton_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(458, 22);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(13, 13);
            this.ScoreLabel.TabIndex = 3;
            this.ScoreLabel.Text = "0";
            // 
            // TryCatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 379);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.CatchButton);
            this.Controls.Add(this.StartButton);
            this.Name = "TryCatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поймай меня!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button CatchButton;
        private System.Windows.Forms.Label ScoreLabel;
    }
}

