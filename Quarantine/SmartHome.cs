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
    public partial class SmartHome : Form
    {
        int allseconds, cafe;
        public bool check {get;set;}
        public SmartHome()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = false;
            button4.BackColor = Color.Maroon;
            button3.BackColor = Color.Transparent;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = true;
            button3.BackColor = Color.DarkGreen;
            button4.BackColor = Color.Transparent;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            esspresso.Enabled = true;
            capuccino.Enabled = true;
            button5.BackColor = Color.DarkGreen;
            button6.BackColor = Color.Transparent;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            esspresso.Enabled = false;
            capuccino.Enabled = false;
            button6.BackColor = Color.Maroon;
            button5.BackColor = Color.Transparent;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Yellow;
            button2.BackColor = Color.DarkGreen;
            button1.BackColor = Color.Transparent;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            button1.BackColor = Color.Maroon;
            button2.BackColor = Color.Transparent;

        }

        private void esspresso_Click(object sender, EventArgs e)
        {
            capuccino.Enabled = false;
            esspresso.BackColor = Color.Green;
            allseconds =  60;
            timercafe.Enabled = true;
            cafe = 2;
            button6.Enabled = false;
            button5.Enabled = false;
            
        }

        private void timercafe_Tick(object sender, EventArgs e)
        {
            if (cafe.Equals(1))
            {


                if (allseconds > 0)
                {
                    allseconds--;
                    int minutes = allseconds / 60;
                    int seconds = allseconds - (minutes * 60);
                    this.capuccino.Text = minutes + ":" + seconds;


                }
                else
                {
                    this.timercafe.Stop();
                    this.capuccino.Text = "capuccino";
                    button6.Enabled = true;
                    this.esspresso.Enabled = true;

                }
            }
            else if (cafe.Equals(2)) {
                if (allseconds > 0)
                {
                    allseconds--;
                    int minutes = allseconds / 60;
                    int seconds = allseconds - (minutes * 60);
                    this.esspresso.Text = minutes + ":" + seconds;


                }
                else
                {
                    this.timercafe.Stop();
                    this.esspresso.Text = "esspresso";
                    button6.Enabled = true;
                    this.capuccino.Enabled = true;
                    X.Enabled = true;

                }

            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            SKAI.Enabled = false;
            STAR.Enabled = false;
            NETFLIX.Enabled = false;
            pictureBox4.BackColor = Color.Transparent;
            button10.BackColor = Color.Maroon;
            button9.BackColor = Color.Transparent;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.DarkGreen;
            button10.BackColor = Color.Transparent;

            SKAI.Enabled = true;
            STAR.Enabled = true;
            NETFLIX.Enabled =true;
        }

        private void SKAI_Click(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.DeepSkyBlue;
        }

        private void STAR_Click(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.IndianRed;
        }

        private void NETFLIX_Click(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Black;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.button11.Text = "UNLOCKED";
            this.button11.BackColor = Color.DarkGreen;
            this.button12.BackColor = Color.Transparent;
            this.button12.Text = "LOCK";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.button12.Text = "LOCKED";
            this.button12.BackColor = Color.Maroon;
            this.button11.BackColor = Color.Transparent;
            this.button11.Text = "UNLOCK";
        }

        private void SmartHome_Load(object sender, EventArgs e)
        {
            button12.BackColor = Color.Maroon;
            button12.Text = "LOCKED";
            button10_Click(sender, e);
            button6_Click(sender, e);
            button4_Click(sender, e);
        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Transparent;
            button7.BackColor = Color.DarkGreen;
            pictureBox2.Image = Properties.Resources.broombroom;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Transparent;
            button8.BackColor = Color.Maroon;
            pictureBox2.Image = Properties.Resources.robot_vacuum_cleaner;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"online_help.chm");
        }

        private void capuccino_Click(object sender, EventArgs e)
        {
            esspresso.Enabled = false;
            capuccino.BackColor = Color.Green;
            allseconds =  60;
            timercafe.Enabled = true;
            cafe = 1;
            button6.Enabled = false;
            button5.Enabled = false;
        }
    }
}

