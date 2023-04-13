﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallGamesWinFormsApp
{
    
    public class RandomPointBall:Ball
    {
        protected static Random random = new Random();
        public RandomPointBall(MainForm form):base(form)
        {
            x = random.Next(0, form.ClientSize.Width);
            y = random.Next(0, form.ClientSize.Height); 
        }
    }
}
