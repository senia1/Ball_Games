
namespace SalutWinFormsApp
{
    public partial class MainForm : Form
    {
        Random random = new Random();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Ball_TopReached(object? sender, HitEventArgs e)
        {
            for (int i = 0; i < random.Next(4, 10); i++)
            {
                var ball = new SalutBall(this, e.X, e.Y);
                ball.Start();
            }
        }

        private void startButton_Click_1(object sender, EventArgs e)
        {
            StartSalutBall startSalutball = new StartSalutBall(this);
            startSalutball.TopReached += Ball_TopReached;
            startSalutball.Start();
        }

        private void MainForm_MouseDown_1(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < random.Next(4, 10); i++)
            {
                var ball = new SalutBall(this, e.X, e.Y);
                ball.Start();
            }
        }
    }
}