﻿
namespace BallGamesWinFormsApp
{
    public class Ball
    {
        private MainForm form;
        protected int vx = 1;
        protected int vy = 1;
        protected int x = 150;
        protected int y = 150;
        protected int size = 70;
        public Ball(MainForm form)
        {
            this.form = form;
        }

        public void Show() 
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.Aqua;
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }

        private void Go() 
        {
            x += vx;
            y += vy;
        }

        private void Clear() 
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.White;
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }

        public void Move() 
        {
            Clear();
            Go();
            Show();
        }
    }
}
