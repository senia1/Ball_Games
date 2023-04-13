namespace BallGamesWinFormsApp
{
    public partial class MainForm : Form
    {
        List<RandomSizeAndPointBall> randomSizeAndPointBalls = new List<RandomSizeAndPointBall>();
        PointBall pointBall;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void manyBallsButton_Click(object sender, EventArgs e)
        {
            //var ball = new Ball(this);
            for (int i = 0; i < 10; i++)
            {
                var randomSizeAndPointBall = new RandomSizeAndPointBall(this);
                randomSizeAndPointBalls.Add(randomSizeAndPointBall);
            }
            
            //randomSizeAndPointball.Show();
            //randomSizeAndPointBall.Show();
            timer.Enabled = true;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            var pointBall = new PointBall(this, e.X, e.Y);
            pointBall.Show();
        }

        private void stopBallButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                randomSizeAndPointBalls[i].Move();
            }
        }
    }
}