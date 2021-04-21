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
    public partial class SMS : Form
    {
        public bool radio_chosen = false;
        public string sms;
        public bool txtbox = false;
        //Δες αν χρειαζονται και αλλες μεταβλητές για την φορμα
        public SMS()
        {
            InitializeComponent();
        }

        private void SMS_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {



            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text))
            {



                if (radioButton1.Checked == true)
                {
                    sms = "1" + " " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
                    radio_chosen = true;
                }
                else if (radioButton2.Checked == true)
                {
                    sms = "2" + " " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
                    radio_chosen = true;
                }
                else if (radioButton3.Checked == true)
                {
                    sms = "3" + " " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
                    radio_chosen = true;

                }
                else if (radioButton4.Checked == true)
                {
                    sms = "4" + " " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
                    radio_chosen = true;
                }
                else if (radioButton5.Checked == true)
                {
                    sms = "5" + " " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
                    radio_chosen = true;
                }
                else if (radioButton6.Checked == true)
                {
                    sms = "2" + " " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
                    radio_chosen = true;
                }
                else
                {
                    MessageBox.Show("Παρακαλω διαλεξτε λογο εξόδου");
                    return;
                }
            }else  
            {
                    MessageBox.Show("Παρακαλώ γραψτε όνομα , επίθετο , διευθηνση");
                    return;
             }

                MessageBox.Show("Το μυνημα σας σταλθηκε στο προχειρο του κινητου σας :" + sms);
                this.Close();

            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            richTextBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"online_help.chm");// Help
        }
    }
}


