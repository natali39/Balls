namespace Balls
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
            this.DrawRandomColorAndpPointBallButton = new System.Windows.Forms.Button();
            this.MoveBallButton = new System.Windows.Forms.Button();
            this.DrawRandomColorAndPointAndProjectionBallButton2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.DrawRandomSizeAndPointBallButton.Location = new System.Drawing.Point(264, 12);
            this.DrawRandomSizeAndPointBallButton.Name = "DrawRandomSizeAndPointBallButton";
            this.DrawRandomSizeAndPointBallButton.Size = new System.Drawing.Size(120, 55);
            this.DrawRandomSizeAndPointBallButton.TabIndex = 1;
            this.DrawRandomSizeAndPointBallButton.Text = "Рисовать шарик случайного размера в случайном месте";
            this.DrawRandomSizeAndPointBallButton.UseVisualStyleBackColor = true;
            this.DrawRandomSizeAndPointBallButton.Click += new System.EventHandler(this.DrawRandomSizeAndPointBallButton_Click);
            // 
            // DrawRandomPointBallButton
            // 
            this.DrawRandomPointBallButton.Location = new System.Drawing.Point(138, 12);
            this.DrawRandomPointBallButton.Name = "DrawRandomPointBallButton";
            this.DrawRandomPointBallButton.Size = new System.Drawing.Size(120, 55);
            this.DrawRandomPointBallButton.TabIndex = 2;
            this.DrawRandomPointBallButton.Text = "Рисовать шарик в случайном месте";
            this.DrawRandomPointBallButton.UseVisualStyleBackColor = true;
            this.DrawRandomPointBallButton.Click += new System.EventHandler(this.DrawRandomPointBallButton_Click);
            // 
            // DrawRandomColorAndpPointBallButton
            // 
            this.DrawRandomColorAndpPointBallButton.Location = new System.Drawing.Point(390, 12);
            this.DrawRandomColorAndpPointBallButton.Name = "DrawRandomColorAndpPointBallButton";
            this.DrawRandomColorAndpPointBallButton.Size = new System.Drawing.Size(120, 55);
            this.DrawRandomColorAndpPointBallButton.TabIndex = 4;
            this.DrawRandomColorAndpPointBallButton.Text = "Рисовать шарик случайного цвета в случайном месте";
            this.DrawRandomColorAndpPointBallButton.UseVisualStyleBackColor = true;
            this.DrawRandomColorAndpPointBallButton.Click += new System.EventHandler(this.DrawRandomColorAndPointBallButton_Click);
            // 
            // MoveBallButton
            // 
            this.MoveBallButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoveBallButton.Location = new System.Drawing.Point(12, 294);
            this.MoveBallButton.Name = "MoveBallButton";
            this.MoveBallButton.Size = new System.Drawing.Size(120, 55);
            this.MoveBallButton.TabIndex = 6;
            this.MoveBallButton.Text = "Двигать шарик";
            this.MoveBallButton.UseMnemonic = false;
            this.MoveBallButton.UseVisualStyleBackColor = true;
            this.MoveBallButton.Click += new System.EventHandler(this.MoveBallButton_Click);
            // 
            // DrawRandomColorAndPointAndProjectionBallButton2
            // 
            this.DrawRandomColorAndPointAndProjectionBallButton2.Location = new System.Drawing.Point(516, 12);
            this.DrawRandomColorAndPointAndProjectionBallButton2.Name = "DrawRandomColorAndPointAndProjectionBallButton2";
            this.DrawRandomColorAndPointAndProjectionBallButton2.Size = new System.Drawing.Size(120, 55);
            this.DrawRandomColorAndPointAndProjectionBallButton2.TabIndex = 7;
            this.DrawRandomColorAndPointAndProjectionBallButton2.Text = "Рисовать шарик случайного цвета в случайном месте";
            this.DrawRandomColorAndPointAndProjectionBallButton2.UseVisualStyleBackColor = true;
            this.DrawRandomColorAndPointAndProjectionBallButton2.Click += new System.EventHandler(this.DrawRandomColorAndPointAndProjectionBallButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnyBallsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DrawRandomColorAndPointAndProjectionBallButton2);
            this.Controls.Add(this.MoveBallButton);
            this.Controls.Add(this.DrawRandomColorAndpPointBallButton);
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
        private System.Windows.Forms.Button DrawRandomColorAndpPointBallButton;
        private System.Windows.Forms.Button MoveBallButton;
        private System.Windows.Forms.Button DrawRandomColorAndPointAndProjectionBallButton2;
        private System.Windows.Forms.Button button1;
    }
}

