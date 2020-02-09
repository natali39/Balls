namespace AnyBalls
{
    partial class AnyBallsForm
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
            this.DrawBallButton = new System.Windows.Forms.Button();
            this.DrawRandomSizeAndPointBallButton = new System.Windows.Forms.Button();
            this.DrawRandomPointBallButton = new System.Windows.Forms.Button();
            this.MoveBallButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DrawBallButton
            // 
            this.DrawBallButton.Location = new System.Drawing.Point(12, 12);
            this.DrawBallButton.Name = "DrawBallButton";
            this.DrawBallButton.Size = new System.Drawing.Size(120, 55);
            this.DrawBallButton.TabIndex = 0;
            this.DrawBallButton.Text = "Рисовать шарик";
            this.DrawBallButton.UseVisualStyleBackColor = true;
            this.DrawBallButton.Click += new System.EventHandler(this.DrawBallButton_Click);
            // 
            // DrawRandomSizeAndPointBallButton
            // 
            this.DrawRandomSizeAndPointBallButton.Location = new System.Drawing.Point(284, 12);
            this.DrawRandomSizeAndPointBallButton.Name = "DrawRandomSizeAndPointBallButton";
            this.DrawRandomSizeAndPointBallButton.Size = new System.Drawing.Size(120, 55);
            this.DrawRandomSizeAndPointBallButton.TabIndex = 1;
            this.DrawRandomSizeAndPointBallButton.Text = "Рисовать шарик случайного размера в случайном месте";
            this.DrawRandomSizeAndPointBallButton.UseVisualStyleBackColor = true;
            this.DrawRandomSizeAndPointBallButton.Click += new System.EventHandler(this.DrawRandomSizeAndPointBallButton_Click);
            // 
            // DrawRandomPointBallButton
            // 
            this.DrawRandomPointBallButton.Location = new System.Drawing.Point(149, 12);
            this.DrawRandomPointBallButton.Name = "DrawRandomPointBallButton";
            this.DrawRandomPointBallButton.Size = new System.Drawing.Size(120, 55);
            this.DrawRandomPointBallButton.TabIndex = 2;
            this.DrawRandomPointBallButton.Text = "Рисовать шарик в случайном месте";
            this.DrawRandomPointBallButton.UseVisualStyleBackColor = true;
            this.DrawRandomPointBallButton.Click += new System.EventHandler(this.DrawRandomPointBallButton_Click);
            // 
            // MoveBallButton
            // 
            this.MoveBallButton.Location = new System.Drawing.Point(419, 12);
            this.MoveBallButton.Name = "MoveBallButton";
            this.MoveBallButton.Size = new System.Drawing.Size(120, 55);
            this.MoveBallButton.TabIndex = 3;
            this.MoveBallButton.Text = "Двигать шарик";
            this.MoveBallButton.UseVisualStyleBackColor = true;
            this.MoveBallButton.Click += new System.EventHandler(this.MoveBallButton_Click);
            // 
            // AnyBallsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 372);
            this.Controls.Add(this.MoveBallButton);
            this.Controls.Add(this.DrawRandomPointBallButton);
            this.Controls.Add(this.DrawRandomSizeAndPointBallButton);
            this.Controls.Add(this.DrawBallButton);
            this.Name = "AnyBallsForm";
            this.Text = "Разные шарики";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnyBallsForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DrawBallButton;
        private System.Windows.Forms.Button DrawRandomSizeAndPointBallButton;
        private System.Windows.Forms.Button DrawRandomPointBallButton;
        private System.Windows.Forms.Button MoveBallButton;
    }
}

