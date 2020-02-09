using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyBalls
{
    class PointBall : RandomSizeAndPointBall
    {
        public PointBall(Form form, int x, int y) : base(form)
        {
            CenterX = x;
            CenterY = y;
        }
    }
}
