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
    public partial class SmartQuarantineApp : Form
    {
        public bool check = false;
        public SmartQuarantineApp()
        {
            InitializeComponent();
        }

        private void SmartQuarantineApp_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SMS sms = new SMS();
            sms.Show();
        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Destinations destinations = new Destinations();
            destinations.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
                SmartHome smart = new SmartHome();
                smart.check = check;
                smart.Show();
                
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"online_help.chm");
            //Help
        }
    }
}
