using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quarantine
{
    public partial class OldPeople : Form
    {
        public int which = 1;
        Random r = new Random();
        public int check1,check2;
        public OldPeople()
        {
            InitializeComponent();
        }

        private void OldPeople_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;

        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            check1 = r.Next(0, 100);
            if (check1 < 51)
            {
                StatusPA.Text = "Καλή";
                StatusPA.BackColor = Color.Lime;
            }
            else if (check1 > 51 && check1 < 90)
            {
                StatusPA.Text = "Μέτρια";
                StatusPA.BackColor = Color.Orange;
            }
            else {
                StatusPA.Text = "ΕΠΕΙΓΩΝ";
                StatusPA.BackColor = Color.Red;
                timer1.Enabled = false;
                timer2.Enabled = false;

                pictureBox1.Image = Properties.Resources.danger;
                button1.Enabled = false;
                button2.Enabled = false;

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (which == 1)
            {
                pictureBox1.Image = Properties.Resources.grandma;
                which = 0;
            }
            else {
                pictureBox1.Image = Properties.Resources.grandpa;
                which = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (which == 1)
            {
                pictureBox1.Image = Properties.Resources.grandma;
                which = 0;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.grandpa;
                which = 1;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            check2 = r.Next(0, 100);
            if (check2 < 51)
            {
                statusMA.Text = "Καλή";
                statusMA.BackColor = Color.Lime ;
            }
            else if (check2 > 51 && check2 < 90)
            {
                statusMA.Text = "Μέτρια";
                statusMA.BackColor = Color.Orange;
            }
            else
            {
                statusMA.Text = "ΕΠΕΙΓΩΝ";
                statusMA.BackColor = Color.Red;
                timer2.Enabled = false;
                timer1.Enabled = false;

                pictureBox1.Image = Properties.Resources.danger;
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"online_help.chm");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (check2 >= 91) {
                button1.Enabled = true;
                button2.Enabled = true;
                timer1.Enabled = true;
                timer2.Enabled = true;
                pictureBox1.Image = Properties.Resources.grandma;
                statusMA.Text = "Καλή";
                StatusPA.Text = "Καλή";
                statusMA.BackColor = Color.Lime;
                StatusPA.BackColor = Color.Lime;


            }
            if (check1>=91)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                timer1.Enabled = true;
                timer2.Enabled = true;
                pictureBox1.Image = Properties.Resources.grandpa;
                StatusPA.Text = "Καλή";
                statusMA.Text = "Καλή";
                statusMA.BackColor = Color.Lime;
                StatusPA.BackColor = Color.Lime;

            }
        }
    }
}
