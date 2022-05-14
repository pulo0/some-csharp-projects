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

            lbx_history.Items.Add("Player: " + lbl_player.Text + " choose " + button.Name);

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

            if(button.Text == "O")
            {
                Color green = Color.FromArgb(50, 194, 58);
                button.BackColor = green;
            }
            else if (button.Text == "X")
            {
                Color red = Color.FromArgb(194, 50, 50);
                button.BackColor = red;
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
                button.BackColor = button1.BackColor;
                lbx_history.Items.Clear();
            }
              
        }

        private bool IsGameEnded()
        {
            if (button_00.Text != "" && button_00.Text == button_01.Text && button_00.Text == button_02.Text)
            {
                return true;
            }
            else if (button_10.Text != "" && button_10.Text == button_11.Text && button_10.Text == button_12.Text)
            {
                return true;
            }
            else if (button_20.Text != "" && button_20.Text == button_21.Text && button_20.Text == button_22.Text)
            {
                return true;
            }


            if (button_00.Text != "" && button_00.Text == button_10.Text && button_00.Text == button_20.Text)
            {
                return true;
            }
            else if (button_01.Text != "" && button_01.Text == button_11.Text && button_01.Text == button_21.Text)
            {
                return true;
            }
            else if (button_02.Text != "" && button_02.Text == button_12.Text && button_02.Text == button_22.Text)
            {
                return true;
            }


            if (button_00.Text != "" && button_00.Text == button_11.Text && button_00.Text == button_22.Text)
            {
                return true;
            }
            else if (button_20.Text != "" && button_20.Text == button_11.Text && button_20.Text == button_02.Text)
            {
                return true;
            }
            return false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Color whiteModeBaby = Color.FromArgb(235,236,237);
            Color darkModeBaby = Color.FromArgb(28,29,31);

            if(checkBox1.Checked == true)
            {
                BackColor = darkModeBaby;
                lbl.ForeColor = whiteModeBaby;
                lbl_player.ForeColor = whiteModeBaby;
            }
            else
            {
                BackColor = whiteModeBaby;
                lbl.ForeColor = darkModeBaby;
                lbl_player.ForeColor = darkModeBaby;
            }
            
        }
    }
}
