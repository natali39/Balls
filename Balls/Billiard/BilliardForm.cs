using Balls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billiard
{
    public partial class BilliardForm : Form
    {
        public BilliardForm()
        {
            InitializeComponent();
        }

        private void BilliardForm_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                var ball = new BilliarBall(this);
                ball.Start();
            }
        }
    }
}
