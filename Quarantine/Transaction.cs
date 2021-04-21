using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Quarantine
{
    public partial class Transaction : Form
    {
        public string payment { get; set; }
      
        public Transaction()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            label4.Text = payment+ "€";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();

            order.crt = int.Parse(payment);

            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Text = "";
        }

        

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            textBox5.Text = "";
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cardnum,mm,yy,cvv;
            if (int.TryParse(textBox2.Text, out cardnum) && int.TryParse(textBox3.Text, out mm) && int.TryParse(textBox4.Text, out yy) && int.TryParse(textBox5.Text, out cvv))
            {
                System.Threading.Thread.Sleep(1000);
                MessageBox.Show("Η πληρωμη έγινε με επιτυχια.");
                this.Close();
            }
            else {
                MessageBox.Show("Παρακαλω συμπληρωστε σωστά τα στοιχεια σας");
            }
            
            //When this ends , then the orders form must close
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"online_help.chm");
        }
    }
}
