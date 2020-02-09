using System;
using System.Drawing;
using System.Windows.Forms;

namespace AnyBalls
{
    public class Ball
    {
        protected Form form;
        private int centerX = 100;
        private int centerY = 100;
        protected int radius = 25;
        protected Color color;

        protected Random random = new Random();

        protected int CenterX
        {
            set
            {
                if ((value < radius) || (value + radius > form.ClientSize.Width))
                {
                    throw new ArgumentException("Шарик выходит за границы формы!");
                }
                centerX = value;
            }
            get { return centerX; }
        }

        protected int CenterY
        {
            set
            {
                if (value < radius || value + radius > form.ClientSize.Height)
                {
                    throw new ArgumentException("Шарик выходит за границы формы!");
                }
                centerY = value;
            }
            get { return centerY; }
        }

        public Ball(Form form)
        {
            this.form = form;
        }

        public void Draw()
        {
            var graphics = form.CreateGraphics();
            var rectangle = new Rectangle(centerX - radius, centerY - radius, radius * 2, radius * 2);
            graphics.FillEllipse(Brushes.FloralWhite, rectangle);
        }

        public void Move()
        {

        }
    }
}
