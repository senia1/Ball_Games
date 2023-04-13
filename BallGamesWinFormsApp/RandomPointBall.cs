using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallGamesWinFormsApp
{
    
    public class RandomPointBall
    {
        static Random random = new Random();
        public RandomPointBall(MainForm form)
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.Aqua;
            var x = random.Next(0, form.ClientSize.Width);
            var y = random.Next(0, form.ClientSize.Height);
            var rectangle = new Rectangle(x, y, 100, 100);
            graphics.FillEllipse(brush, rectangle);
        }
        
    }
}
