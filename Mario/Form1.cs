namespace Mario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
           

        }

        private new void Move(object sender, PreviewKeyDownEventArgs e)
        {
            
            
            if (e.KeyValue == 37)
            {
                if (pictureBox1.Location.X>55)
                {
                 pictureBox1.Location = new Point(pictureBox1.Location.X - 10,pictureBox1.Location.Y);

                }

            }
            else if (e.KeyValue == 38)
            {
                if (pictureBox1.Location.Y>60)
                {
                 pictureBox1.Location = new Point(pictureBox1.Location.X , pictureBox1.Location.Y - 20);

                }

            }
            else if (e.KeyValue == 39)
            {
                if (pictureBox1.Location.X<520)
                {
                 pictureBox1.Location = new Point(pictureBox1.Location.X+10, pictureBox1.Location.Y );

                }

            }
            else if (e.KeyValue == 40)
            {
                if (pictureBox1.Location.Y<500)
                {
                 pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 20);

                }

            }
        }

      
    }
}