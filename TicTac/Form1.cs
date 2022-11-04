using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTac
{
    public partial class TicTac : Form
    {
        sbyte pushCounter = 0;
        bool push = true;

        public TicTac()
        {
            InitializeComponent();
        }

        private void BtClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (push)
            {
                button.Text = "X";
            }
            else
                button.Text = "O";
            push = !push;
            pushCounter++;
            button.Enabled = false;
            if (pushCounter > 4) checkWinner(); 
        }

        private void checkWinner()
        {
            bool isWinner = false;
            if ((btA1.Text==btB1.Text) && (btB1.Text==btC1.Text) && !btC1.Enabled)
            {
                isWinner = true;
            }
            if ((btA2.Text==btB2.Text) && (btB2.Text==btC2.Text) && !btC2.Enabled)
            {
                isWinner = true;
            }
            if ((btA3.Text == btB3.Text) && (btB3.Text == btC3.Text) && !btC3.Enabled)
            {
                isWinner = true;
            }
            if ((btA1.Text == btA2.Text) && (btA2.Text == btA3.Text) && !btA1.Enabled)
            {
                isWinner = true;
            }
            if ((btB1.Text == btB2.Text) && (btB2.Text == btB3.Text) && !btB1.Enabled)
            {
                isWinner = true;
            }
            if ((btC1.Text == btC2.Text) && (btC2.Text == btC3.Text) && !btC1.Enabled)
            {
                isWinner = true;
            }
            if ((btA1.Text == btB2.Text) && (btB2.Text == btC3.Text) && !btA1.Enabled)
            {
                isWinner = true;
            }
            if ((btC1.Text == btB2.Text) && (btB2.Text == btA3.Text) && !btC1.Enabled)
            {
                isWinner = true;
            }
            char winner = ' ';
            if (isWinner)
            {
                if (push)
                {
                    winner = 'O';
                    lbO.Text = (int.Parse(lbO.Text) + 1).ToString();
                    push = !push;
                }
                else
                {
                        winner = 'X';
                        lbX.Text = (int.Parse(lbX.Text) + 1).ToString();
                        push = !push;
                }
                MessageBox.Show(
                    $"Winner is {winner}", 
                    "Winner Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                startNew();
            }
            else
            {
                if (pushCounter==9)
                {
                    MessageBox.Show(
                    $"There is No Winner",
                    "Winner Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    startNew();
                    lbNo.Text = (int.Parse(lbNo.Text) + 1).ToString();
                }
            }
        }

        private void startNew()
        {
           // push = true;
            pushCounter = 0;
            foreach (var item in Controls)
            {
               
                try
                {
                    Button button = item as Button;
                    button.Enabled = true;
                    button.Text = " ";
                }
                catch { }
                
            }
        }

        

        private void MLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Enabled)
            {
                button.Text = " ";  
            }
            
        }

        private void MEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Enabled)
            {
                if (push)
                {
                    button.Text = "X";
                }
                else
                {
                    button.Text = "O";
                }
            }
        }

        private void Ngame(object sender, EventArgs e)
        {
            startNew();
            push = true;
            lbNo.Text = "0";
            lbO.Text = "0";
            lbX.Text = "0";
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Info(object sender, EventArgs e)
        {
            MessageBox.Show(
                    $"This game was made by Dashyan",
                    "Owner Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
           
        }
    }
}
