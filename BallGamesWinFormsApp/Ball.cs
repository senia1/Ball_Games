using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGamesWinFormsApp
{
    public class Ball
    {
        public Ball(MainForm form)
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.Aqua;
            var rectangle = new Rectangle(450, 150, 70, 70);
            graphics.FillEllipse(brush, rectangle);
        } 
    }
}
