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
    public partial class Destinations : Form
    {


        public string plan = "";
        public string hour;
        public int transportation;
        public string dest;
        public Destinations()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(destination.Text))
            {
                if (this.radioButton1.Checked == true)
                {
                    plan = dateTimePicker1.Value + " " + destination.Text + " " + radioButton1.Text;
                    transportation = 1;
                }
                else if (this.radioButton2.Checked == true)
                {
                    plan = dateTimePicker1.Value + " " + destination.Text + " " + radioButton2.Text;
                    transportation = 2;
                }
                else if (this.radioButton3.Checked == true)
                {
                    plan = dateTimePicker1.Value + " " + destination.Text + " " + radioButton3.Text;
                    transportation = 3;
                }
                else if (this.radioButton4.Checked == true)
                {
                    plan = dateTimePicker1.Value + " " + destination.Text + " " + radioButton4.Text;
                    transportation = 4;
                }
                else if (this.radioButton5.Checked == true)
                {
                    plan = dateTimePicker1.Value + " " + destination.Text + " " + radioButton5.Text;
                    transportation = 5;
                }
                else if (this.radioButton6.Checked == true)
                {
                    plan = dateTimePicker1.Value + " " + destination.Text + " " + radioButton6.Text;
                    transportation = 6;
                }
                else {
                    MessageBox.Show("Παρακαλώ Επιλέξτε τροπο μεταφοράς");
                    return;
                }
                dest = destination.Text;
                hour = dateTimePicker1.Value.ToString();

            }
            else {
                MessageBox.Show("Παρακαλώ είσαγεται καποίο προορισμο");
                return;
            }
            Form4 form4 = new Form4();
            form4.plan = this.plan;
            form4.transportation = this.transportation;
            form4.Show();

        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Destinations_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"online_help.chm");
        }
    }
}
