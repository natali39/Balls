using System.Windows.Forms;

namespace Balls
{
    public class RandomColorAndPointAndProjectionBall : RandomColorAndPointBall
    {
        public RandomColorAndPointAndProjectionBall(Form form) : base (form)
        {
            vx = (float)((random.NextDouble() - 0.5) * 10);
            vy = (float)((random.NextDouble() - 0.5) * 10);
        }
    }
}
