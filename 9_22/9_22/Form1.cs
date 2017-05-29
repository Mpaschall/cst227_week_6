using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_22
    {
        public partial class Form1 : Form
        {
            int cups = 0;
            double credit = 0;
            public Form1()
            {
                InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                credit += .10;
                label6.Text = string.Format("{0:0.00}", credit);
            }

            private void button2_Click(object sender, EventArgs e)
            {
                credit += .05;
                label6.Text = string.Format("{0:0.00}", credit);
            }

            private void button3_Click(object sender, EventArgs e)
            {
                credit += .25;
                label6.Text = string.Format("{0:0.00}", credit);
            }

            private void button4_Click(object sender, EventArgs e)
            {
                cups += 10;
                label4.Text = cups.ToString();
            }

            private void button5_Click(object sender, EventArgs e)
            {
                if (credit >= 0.50)
                {
                    cups -= 1;
                    label4.Text = cups.ToString();
                    credit -= 0.50;
                    label6.Text = string.Format("{0:0.00}", credit);
                    MessageBox.Show("You received a cup of coffee.");
                }
                else
                {
                    MessageBox.Show("Please enter more money.");
                }
            }

            private void button6_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Refunded $" + credit);
                credit = 0;
                label6.Text = string.Format("{0:0.00}", credit);
            }
        }
    }


