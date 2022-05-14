using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_00_Click(object sender, EventArgs e)
        {
            button_Click(button_00);
        }

        private void button_Click(Button button)
        {
            button.Text = lbl_player.Text;

            if(IsGameEnded())
            {
                MessageBox.Show("Player " + lbl_player.Text + " won a game");
            }

            if (lbl_player.Text == "O")
            {
                lbl_player.Text = "X";
            }
            else
            {
                lbl_player.Text = "O";
            }
            button.Enabled = false;
        }

        private void lbl_Click(object sender, EventArgs e)
        {
            
        }

        private void button_01_Click(object sender, EventArgs e)
        {
            button_Click(button_01);
        }

        private void button_02_Click(object sender, EventArgs e)
        {
            button_Click(button_02);
        }

        private void button_10_Click(object sender, EventArgs e)
        {
            button_Click(button_10);
        }

        private void button_11_Click(object sender, EventArgs e)
        {
            button_Click(button_11);
        }

        private void button_12_Click(object sender, EventArgs e)
        {
            button_Click(button_12);
        }

        private void button_20_Click(object sender, EventArgs e)
        {
            button_Click(button_20);
        }

        private void button_21_Click(object sender, EventArgs e)
        {
            button_Click(button_21);
        }

        private void button_22_Click(object sender, EventArgs e)
        {
            button_Click(button_22);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_player.Text = "O";
            Button[] buttons = new Button[]
            {
                button_00, button_01, button_02, button_10, button_11, button_12, button_20, button_21, button_22
            };
            foreach(Button button in buttons)
            {
                button.Text = "";
                button.Enabled = true;
            }
              
        }

        private bool IsGameEnded()
        {
            if (button_00.Text != "" && button_00.Text == button_01.Text && button_00.Text == button_02.Text)
            {
                return true;
            }
            return false;
        }
    }
}
