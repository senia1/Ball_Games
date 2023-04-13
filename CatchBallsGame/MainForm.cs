using Balls.Common;

namespace CatchBallsGame
{
    public partial class MainForm : Form
    {
        List<MoveBall> moveBallsList;
        MoveBall moveBall;
        private int countBalls;
        public MainForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            clearButton.Enabled = true;
            countBalls = 0;
            moveBallsList = new List<MoveBall>();

            for (int i = 0; i < 10; i++)
            {
                moveBall = new MoveBall(this);
                moveBallsList.Add(moveBall);
                moveBall.Start();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            clearButton.Enabled = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (var item in moveBallsList)
            {
                item.Clear();
            }
            moveBallsList.Clear();
            countBallsLabel.Text = "0";
            clearButton.Enabled = false;
            startButton.Enabled = true;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (moveBallsList != null)
            {
                foreach (var ball in moveBallsList)
                {
                    if (ball.IsMovable() && ball.Contains(e.X, e.Y) && ball.OnForm())
                    {
                        ball.Stop();
                        countBalls++;
                    }
                }
                countBallsLabel.Text = countBalls.ToString();
            }
        }
    }
}