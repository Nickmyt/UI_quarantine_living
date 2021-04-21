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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thermometer f2 = new Thermometer();
            f2.Show();
            
        }

       


      

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Choose choose = new Choose();
            choose.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Thermometer thermometer = new Thermometer();
            thermometer.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OldPeople old = new OldPeople();
            old.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"online_help.chm");
        }
    }
}
