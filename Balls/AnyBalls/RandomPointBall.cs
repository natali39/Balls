using System;
using System.Windows.Forms;

namespace Balls
{
    public class RandomPointBall : Ball
    {
        public RandomPointBall(Form form) : base(form)
        {
            CenterX = random.Next(radius, form.ClientSize.Width - radius);
            CenterY = random.Next(radius, form.ClientSize.Height - radius);
        }
    }
}
