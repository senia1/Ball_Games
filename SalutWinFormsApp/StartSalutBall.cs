﻿
namespace SalutWinFormsApp
{
    public class StartSalutBall : SalutBall
    {
        public event EventHandler<HitEventArgs> TopReached;
        public StartSalutBall(Form form) : base(form, form.ClientSize.Width / 2, form.ClientSize.Height)
        {
            vy = (float)random.NextDouble() * -6 - 7;
            vx = 0;
        }

        protected override void Go()
        {
            base.Go();

            if (vy > 0)
            {
                Stop();
                Clear();
                TopReached?.Invoke(this, new HitEventArgs(centerX, centerY));
            }
        }
    }
}
