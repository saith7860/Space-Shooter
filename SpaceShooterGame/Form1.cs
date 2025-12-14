using System.Windows.Forms;

namespace SpaceShooterGame
{
    public partial class SpaceShooter : Form
    {
        PictureBox[] stars;
        int backgroundSpeed;
        Random rnd;
        public SpaceShooter()
        {
            InitializeComponent();
        }

        private void SpaceShooter_Load(object sender, EventArgs e)
        {
            stars = new PictureBox[10];
            backgroundSpeed = 4;
            rnd = new Random();
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(rnd.Next(20, 580), rnd.Next(-10, 400));
                if (i % 2 == 0)
                {
                    stars[i].Size = new Size(2, 2);
                    stars[i].BackColor = Color.Wheat;

                }
                else
                {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.DarkGray;

                }
                this.Controls.Add(stars[i]);
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < stars.Length/2; i++)
            {
                stars[i].Top += backgroundSpeed;
                if (stars[i].Top>=this.Height)
                {
                    stars[i].Top = -stars[i].Height;

                }
            }
            for (int i = stars.Length/2; i < stars.Length; i++)
            {
                stars[i].Top += backgroundSpeed - 2;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;

                }
            }
        }
    }
}
