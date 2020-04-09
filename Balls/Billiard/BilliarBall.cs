using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Balls;


namespace Billiard
{
    class BilliarBall : RandomColorAndPointAndProjectionBall
    {
        public BilliarBall(Form form) : base(form)
        {

        }

        protected override void Go()
        {
            base.Go();
            if (CenterX - radius < 0 || CenterX + radius > form.ClientSize.Width)
            {
                vx = -vx;
            }
            if (CenterY - radius < 0 || CenterY + radius > form.ClientSize.Height)
            {
                vy = -vy;
            }
        }
    }
}
