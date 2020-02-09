using System;
using System.Drawing;
using System.Windows.Forms;

namespace AnyBalls
{
    public partial class AnyBallsForm : Form
    {
        Random random = new Random();

        public AnyBallsForm()
        {
            InitializeComponent();
        }

        private void DrawBallButton_Click(object sender, EventArgs e)
        {
            var ball = new Ball(this);
            ball.Draw();
        }

        private void DrawRandomSizeAndPointBallButton_Click(object sender, EventArgs e)
        {
            var ball = new RandomSizeAndPointBall(this);
            ball.Draw();
        }

        private void DrawRandomPointBallButton_Click(object sender, EventArgs e)
        {
            var ball = new RandomPointBall(this);
            ball.Draw();
        }

        private void AnyBallsForm_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                var ball = new PointBall(this, e.X, e.Y);
                ball.Draw();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void MoveBallButton_Click(object sender, EventArgs e)
        {

        }
    }
}
