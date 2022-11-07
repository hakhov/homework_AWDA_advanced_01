using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Converter : Form
    {

        public string Email = "";
        public int PhoneNumber;
        
        public Converter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool email = false;
            bool number = false;


            if (textBox1.Text != null || textBox2.Text != null)
            {
                Email = textBox1.Text;
                email = true;

                if (int.TryParse(textBox2.Text, out int s))
                {
                    PhoneNumber = s;

                    number = true;
                }
                else textBox2.Text = "";




            }
            else
            {
                startNew();
            }
            if (email && number)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
            }
            else startNew();

        }

        private void startNew()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != null || textBox3.Text != null)
            {
                progressBar1.Visible = true;
                progressBar1.Value = 100;
                groupBox2.Visible = false;
                label5.Visible = true;
                

                MessageBox.Show($"Cnvertation sucseed, message was sent to Email- {Email} and PhoneNumber- {PhoneNumber} ", "Congarts", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                comboBox1.Text = "";
                textBox3.Text = " ";
            }

        }

       
    }
}
