using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallGamesWinFormsApp
{
    
    public class RandomPointBall:Ball
    {
        static Random random = new Random();
        public RandomPointBall(MainForm form):base(form)
        {
            var x = random.Next(0, form.ClientSize.Width);
            var y = random.Next(0, form.ClientSize.Height); 
        }
    }
}
