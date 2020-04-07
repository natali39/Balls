using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balls
{
    class RandomColorAndPointBall : RandomPointBall
    {
        public RandomColorAndPointBall(Form form) : base(form)
        {
            color = SelectColor();
        }

        protected Color SelectColor()
        {
            return Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
        }
    }
}
