using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Balls
{
    public partial class AnyBallsForm : Form
    {
        Ball ball;

        public AnyBallsForm()
        {
            InitializeComponent();
        }

        private void DrawBallButton_Click(object sender, EventArgs e)
        {
            ball = new Ball(this);
            ball.Draw();
        }

        private void DrawRandomSizeAndPointBallButton_Click(object sender, EventArgs e)
        {
            ball = new RandomSizeAndPointBall(this);
            ball.Draw();
        }

        private void DrawRandomPointBallButton_Click(object sender, EventArgs e)
        {
            ball = new RandomPointBall(this);
            ball.Draw();
        }

        private void AnyBallsForm_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ball = new PointBall(this, e.X, e.Y);
                ball.Draw();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void DrawRandomColorAndPointBallButton_Click(object sender, EventArgs e)
        {
            ball = new RandomColorAndPointBall(this);
            ball.Draw();
        }

        private void MoveBallButton_Click(object sender, EventArgs e)
        {
            ball.Start();
        }

        private void DrawRandomColorAndPointAndProjectionBallButton_Click(object sender, EventArgs e)
        {
            ball = new RandomColorAndPointAndProjectionBall(this);
            ball.Draw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Ball> balls = new List<Ball>();
            for (int i = 0; i < 5; i++)
            {
                ball = new RandomColorAndPointAndProjectionBall(this);
                ball.Draw();
                balls.Add(ball);
            }
        }
    }
}
