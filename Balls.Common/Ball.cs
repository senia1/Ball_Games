
namespace Balls.Common
{
    public class Ball
    {
        protected Form form;
        protected System.Windows.Forms.Timer timer;
        protected static Random random = new Random();
        SolidBrush brush = new SolidBrush(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)));

        protected float centerX = 100;
        protected float centerY = 100;

        protected float vx = 1;
        protected float vy = 1;

        protected int radius = 25;
        public Ball(Form form)
        {
            this.form = form;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1;
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            Move();
        }

        public bool IsMovable()
        {
            return timer.Enabled;
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public virtual void Show()
        {
            Draw(brush);
        }

        public void Clear()
        {
            var clearBrush = new SolidBrush(form.BackColor);
            Draw(clearBrush);
        }

        public virtual int LeftSide()
        {
            return radius;
        }

        public virtual int RightSide()
        {
            return form.ClientSize.Width - radius;
        }

        public int TopSide()
        {
            return radius;
        }

        public int DownSide()
        {
            return form.ClientSize.Height - radius;
        }

        public bool OnForm()
        {
            return centerX <= RightSide() &&
                    centerY <= DownSide() &&
                    centerX >= LeftSide() &&
                    centerY >= TopSide();
        }

        public bool Contains(int pointX, int pointY)
        {
            return (centerX - pointX) * (centerX - pointX) + (centerY - pointY) * (centerY - pointY) <= radius * radius;
        }

        public void Move()
        {
            Clear();
            Go();
            Show();
        }

        protected virtual void Go()
        {
            centerX += vx;
            centerY += vy;
        }

        public virtual void SlowGo()
        {
            timer.Interval = 50;
        }

        public bool Intersect(Ball other)
        {
            var dx = centerX - other.centerX;
            var dy = centerY - other.centerY;
            return dx * dx + dy * dy <= (radius + other.radius) * (radius + other.radius);
        }

        protected void Draw(Brush brush)
        {
            var graphics = form.CreateGraphics();
            var rectangle = new RectangleF(centerX - radius, centerY - radius, radius * 2, radius * 2);
            graphics.FillEllipse(brush, rectangle);
        }
    }
}
