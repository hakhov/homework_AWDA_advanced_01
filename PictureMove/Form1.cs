namespace PictureMove
{
    public partial class Form1 : Form
    {
        bool MoveLeft, MoveRight, MoveUp, MoveDown;
        int s = 20;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void MoveTimerEvent(object sender, EventArgs e)
        {
            if (MoveLeft && pictureBox1.Left > 0)
            {
                pictureBox1.Left -= s;
            }
            if (MoveRight && (pictureBox1.Left + 20 < this.Width - pictureBox1.Width))
            {
                pictureBox1.Left += s;
            }
            if (MoveUp && pictureBox1.Top > 0)
            {
                pictureBox1.Top -= s;
            }
            if (MoveDown && (pictureBox1.Top + 20 < this.Height - pictureBox1.Height))
            {
                pictureBox1.Top += s;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                MoveLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                MoveRight = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                MoveUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                MoveDown = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                MoveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                MoveRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                MoveUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                MoveDown = false;
            }
        }
    }
}