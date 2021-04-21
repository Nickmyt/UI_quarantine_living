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
    public partial class Form4 : Form
    {
        Random rand = new Random();
        public Form4()
        {
            InitializeComponent();
        }
        public string plan { get; set; }
        public int transportation{ get; set; }
        //This needs some rework ,show a map maybe , we'll see
        private void Form4_Load(object sender, EventArgs e)
        {

            int traffic_scale = rand.Next(1, 100);
            if (traffic_scale <= 50)
            {
                //Μπορει να χρειαστει να το βάλω σε label
                MessageBox.Show("Η διαδρομή σας δεν θα έχει ιδαιτερη κίνηση");
            }
            else {
               
                MessageBox.Show("Η διαδρομη σας θα χρειαστει αλλαγή , Βρηκα διαδρομη για εσας");
            }
            sms.Text = plan;
            if (transportation ==1)
            {
               
                pictureBox1.Image = Properties.Resources.pharmacy;
            }
            else if (transportation ==2)
            {
                pictureBox1.Image = Properties.Resources.Bicycle;

            }
            else if (transportation == 3)
            {
                pictureBox1.Image = Properties.Resources.Car;
            }
            else if (transportation == 4)
            {
                pictureBox1.Image = Properties.Resources.Bus;

            }
            else if (transportation == 5)
            {
                pictureBox1.Image = Properties.Resources.Metro;
            }
            else if (transportation == 6) {
                pictureBox1.Image = Properties.Resources.Electric;

            }
            //Κανε αναλογα τι διαλεξε να βαζει μια εικονα στο picture box
            //Βρες τι θα κανεις με την ωρα

        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sms_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Σταλθηκε στο κινητό σας");
            this.Close();
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
