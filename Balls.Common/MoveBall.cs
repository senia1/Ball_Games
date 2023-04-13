
namespace Balls.Common
{
    public class MoveBall : RandomPointBall
    {
        private System.Windows.Forms.Timer timer;
        public MoveBall(Form form) : base(form)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Move();
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }
    }
}
