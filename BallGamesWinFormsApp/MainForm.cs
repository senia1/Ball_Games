namespace BallGamesWinFormsApp
{
    public partial class MainForm : Form
    {
        RandomSizeAndPointBall randomSizeAndPointball;
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
            randomSizeAndPointball = new RandomSizeAndPointBall(this);
            randomSizeAndPointball.Show();
            //randomSizeAndPointBall.Show();

        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            var pointBall = new PointBall(this, e.X, e.Y);
            pointBall.Show();
        }

        private void stopBallButton_Click(object sender, EventArgs e)
        {
            randomSizeAndPointball.Clear();
            randomSizeAndPointball.Go();
            randomSizeAndPointball.Show();
        }
    }
}