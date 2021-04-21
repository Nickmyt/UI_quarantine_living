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
    public partial class Computer_screen : Form
    {
        Timer t = new Timer();
        public Computer_screen()
        {
            InitializeComponent();
        }

        private void Computer_screen_Load(object sender, EventArgs e)
        {

            t.Tick += new EventHandler(this.T_tick);
            t.Start();
            this.panel2.Hide();

        }
        private void T_tick(object sender, EventArgs e) {
            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            string time = "";
            if (h < 10)
            {
                time += "0" + h;
            }
            else {
                time += h;
            }
            time += ":";
            if (m <  10)
            {
                time += "0" + m;
            }
            else {
                time += m;
                
            }

            //update label for time
            label4.Text = time;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.panel2.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Closing Computer");
            
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel2.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SmartQuarantineApp SQA = new SmartQuarantineApp();
            SQA.Show();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("App needs updating");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"online_help.chm");
        }
    }
}
