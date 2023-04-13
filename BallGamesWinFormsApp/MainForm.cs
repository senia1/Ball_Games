using Balls.Common;

namespace BallGamesWinFormsApp
{
    public partial class MainForm : Form
    {
        List<Ball> balls;
        int leftBallsCount;

        public MainForm()
        {
            InitializeComponent();
        }

        private void stopBallButton_Click(object sender, EventArgs e)
        {
            leftBallsCount = 0;

            foreach (var moveBall in balls)
            {
                moveBall.Stop();
                if (moveBall.OnForm())
                {
                    leftBallsCount++;
                }
            }
            MessageBox.Show($"The number of completely remaining balls on the form {leftBallsCount}");
            stopBallButton.Enabled = false;
            clearFormButton.Enabled = true;
        }

        private void manyBallsButton_Click(object sender, EventArgs e)
        {
            stopBallButton.Enabled = true;
            manyBallsButton.Enabled = false;

            balls = new List<Ball>();

            for (int i = 0; i < 10; i++)
            {
                var moveBall = new MoveBall(this);
                balls.Add(moveBall);
                moveBall.Start();
            }

            for (int i = 0; i < 10; i++)
            {
                var ball = new RandomSizeAndPointBall(this);
                balls.Add(ball);
                ball.Start();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            stopBallButton.Enabled = false;
            clearFormButton.Enabled = false;
        }

        private void clearFormButton_Click_1(object sender, EventArgs e)
        {
            foreach (var item in balls)
            {
                item.Clear();
            }
            balls.Clear();
            clearFormButton.Enabled = false;
            manyBallsButton.Enabled = true;
        }
    }
}