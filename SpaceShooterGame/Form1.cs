using System.Windows.Forms;

namespace SpaceShooterGame
{
    public partial class SpaceShooter : Form
    {
        //List<PictureBox> stars;
        int backgroundSpeed;
        int playerSpeed;
        Random rnd;
        
        public SpaceShooter()
        {
            InitializeComponent();
        }

        private void SpaceShooter_Load(object sender, EventArgs e)
        {
            //stars = new PictureBox[15];
            backgroundSpeed = 4;
            playerSpeed = 4;
            //rnd = new Random();
            //for (int i = 0; i < stars.Length; i++)
            //{
            //    stars[i] = new PictureBox();
            //    stars[i].BorderStyle = BorderStyle.None;
            //    stars[i].Location = new Point(rnd.Next(20, 580), rnd.Next(-10, 400));
            //    if (i % 2 == 0)
            //    {
            //        stars[i].Size = new Size(2, 2);
            //        stars[i].BackColor = Color.Wheat;

            //    }
            //    else
            //    {
            //        stars[i].Size = new Size(3, 3);
            //        stars[i].BackColor = Color.DarkGray;

            //    }
            //    this.Controls.Add(stars[i]);
            //}
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            //for (int i = 0; i < stars.Length / 2; i++)
            //{
            //    stars[i].Top += backgroundSpeed;
            //    if (stars[i].Top >= this.Height)
            //    {
            //        stars[i].Top = -stars[i].Height;

            //    }
            //}
            //for (int i = stars.Length / 2; i < stars.Length; i++)
            //{
            //    stars[i].Top += backgroundSpeed - 2;
            //    if (stars[i].Top >= this.Height)
            //    {
            //        stars[i].Top = -stars[i].Height;

            //    }
            //}
            //for (int i = 0; i < stars.Length; i++)
            //{
            //    if (stars[i].Bottom < 0)
            //    {
            //        stars.
            //    }
            //}
        }

        private void LeftMoveTimer_Tick(object sender, EventArgs e)
        {
            if (player.Left > 10)
            {
                player.Left -= playerSpeed;
            }
        }

        private void RightMoveTimer_Tick(object sender, EventArgs e)
        {
            if (player.Right < 780)
            {
                player.Left += playerSpeed;
            }
        }

        private void UpMoveTimer_Tick(object sender, EventArgs e)
        {
            if (player.Top > 10)
            {
                player.Top -= playerSpeed;
            }
        }

        private void DownMoveTimer_Tick(object sender, EventArgs e)
        {
            if (player.Top < 400)
            {
                player.Top += playerSpeed;
            }
        }

        private void SpaceShooter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                RightMoveTimer.Start();
            }
            if (e.KeyCode==Keys.Left)
            {
                LeftMoveTimer.Start(); 
            }
            if (e.KeyCode == Keys.Down)
            {
                DownMoveTimer.Start();
            }
            if (e.KeyCode == Keys.Up)
            {
                UpMoveTimer.Start();
            }
        }

        private void SpaceShooter_KeyUp(object sender, KeyEventArgs e)
        {
           RightMoveTimer.Stop();
            LeftMoveTimer.Stop();
            DownMoveTimer.Stop();
            UpMoveTimer.Stop();
        }
    }
}
