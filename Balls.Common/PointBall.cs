using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balls.Common
{
    public class PointBall : Ball

    {
        public PointBall(Form form, int x, int y) : base(form)
        {
            this.x = x;
            this.y = y;
        }
    }
}
