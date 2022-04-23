namespace Game
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8; 
        int gravity = 15; 
        int score = 0; 
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gametimerEvent(object sender, EventArgs e)
        {
            bird.Top += gravity;
            pipe2.Left -= pipeSpeed;
            pipe1.Left -= pipeSpeed;
            scoret.Text = "Score: "+score.ToString();
            if (pipe2.Left < -150)
            {
                pipe2.Left = 500;
                score++;
            }
            if (pipe1.Left < -180)
            {
                pipe1.Left = 750;
                score++;
            }


            if (bird.Bounds.IntersectsWith(pipe1.Bounds) ||
                bird.Bounds.IntersectsWith(pipe2.Bounds) ||
                bird.Bounds.IntersectsWith(ground.Bounds) || bird.Top < -25)
            {
                endGame();
            }

            if (score > 5)
            {
                pipeSpeed = 10;
            }
        }
        private void endGame()
        {
            gametimer.Stop(); 
            scoret.Text += " Game over!!!"; 
        }
        private void gamekeydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void gamekeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

    }
}