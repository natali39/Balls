using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balls
{
    public class Ball
    {
        protected Form form;
        private float centerX = 100;
        private float centerY = 100;
        protected int radius = 25;
        protected Color color = Color.Aquamarine;
        protected float vx = 1;
        protected float vy = 1;
        public Timer timer;

        protected static Random random = new Random();

        protected float CenterX
        {
            set
            {
                if ((value < radius) || (value + radius > form.ClientSize.Width))
                {
                    //throw new ArgumentException("Шарик выходит за границы формы!");
                }
                centerX = value;
            }
            get { return centerX; }
        }

        protected float CenterY
        {
            set
            {
                if (value < radius || value + radius > form.ClientSize.Height)
                {
                    //throw new ArgumentException("Шарик выходит за границы формы!");
                }
                centerY = value;
            }
            get { return centerY; }
        }

        public bool IsMoveable //=> timer.Enabled;
        {
            get
            {
                return timer.Enabled;
            }
        }

        public Ball(Form form)
        {
            this.form = form;
            InitTimer();
        }

        private void InitTimer()
        {
            timer = new Timer();
            timer.Interval = 30;
            timer.Tick += Timer_Tick;
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }

        public void Draw()
        {
            var graphics = form.CreateGraphics();
            var rectangle = new RectangleF(centerX - radius, centerY - radius, radius * 2, radius * 2);
            var solidBrush = new SolidBrush(color); 
            graphics.FillEllipse(solidBrush, rectangle);
        }

        public void Clear()
        {
            var graphics = form.CreateGraphics();
            var rectangle = new RectangleF(CenterX - radius, CenterY - radius, radius * 2, radius * 2);
            graphics.FillEllipse(new SolidBrush(form.BackColor), rectangle);
        }

        protected void Go()
        {
            CenterX += vx;
            CenterY += vy;
        }

        public void Move()
        {
            Clear();
            Go();
            Draw();
        }

        public bool OnForm()
        {
            return CenterX - radius > 0 && CenterX + radius < form.ClientSize.Width &&
                   CenterY - radius > 0 && CenterY + radius < form.ClientSize.Height; 
        }
    }
}
