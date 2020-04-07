using System.Windows.Forms;

namespace Balls
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
