using Balls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TryCatchMe
{
    public partial class TryCatchForm : Form
    {
        List<Ball> balls = new List<Ball>();

        int countBallsOnGame = 5;
        int countCatchBalls = 0;

        public TryCatchForm()
        {
            InitializeComponent();
        }

        private void StartNewGame()
        {
            ClearForm();
            countCatchBalls = 0;
            ShowScore();
            CreateBalls();
        }

        private void CreateBalls()
        {
            for (int i = 0; i < countBallsOnGame; i++)
            {
                var ball = new RandomColorAndPointAndProjectionBall(this);
                balls.Add(ball);
                ball.Start();
            }
        }

        private void CatchBalls()
        {
            foreach (var ball in balls)
            {
                if (ball.OnForm() && ball.IsMoveable)
                {
                    ball.Stop();
                    countCatchBalls++;
                    ShowScore();
                    break;
                }
            }
        }

        private void ClearForm()
        {
            foreach (var ball in balls)
            {
                ball.Clear();
            }
            balls.Clear();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartNewGame();
            StartButton.Enabled = false;
        }

        private void CatchButton_Click(object sender, EventArgs e)
        {
            CatchBalls();
            if (IsEnd())
            {
                MessageBox.Show("Игра окончена!");
                StartButton.Enabled = true;
            }
        }

        private void ShowScore()
        {
            ScoreLabel.Text = $"Cчёт: {countCatchBalls}";
        }

        private bool IsEnd()
        {
            int countBallsIsMoveableOnForm = 0;
            foreach (var ball in balls)
            {
                if (ball.OnForm() && ball.IsMoveable)
                {
                    countBallsIsMoveableOnForm++;
                }
            }
            if (countBallsIsMoveableOnForm > 0)
                return false;
            else
                return true;
        }
    }
}
