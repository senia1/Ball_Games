namespace BallGamesWinFormsApp
{
    public partial class MainForm : Form
    {
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
            var randomSizeAndPointBall = new RandomSizeAndPointBall(this);
            //ball.Show();
            randomSizeAndPointBall.Show();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            var pointBall = new PointBall(this,e.X,e.Y);
            pointBall.Show();
        }
    }
}