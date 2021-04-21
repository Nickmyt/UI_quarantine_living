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
    public partial class Order : Form
    {
        public int cart,cnt;
        public int crt { get; set; }
        public Order()
        {
            InitializeComponent();
        }

        //Add a button so the user can select if its take out or he is going to pick it up

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void plus_espresso_Click(object sender, EventArgs e)
        {
            cart += 2;
            label32.Text = cart.ToString();
            cnt += 1;
            counter.Text = cnt.ToString();
        }

        private void plus_frappe_Click(object sender, EventArgs e)
        {
            cart += 2;
            label32.Text = cart.ToString();
            cnt += 1;
            counter.Text = cnt.ToString();
        }

        private void plus_cap_Click(object sender, EventArgs e)
        {
            cart += 2;
            label32.Text = cart.ToString();
            cnt += 1;
            counter.Text = cnt.ToString();
        }

        private void plus_Latte_Click(object sender, EventArgs e)
        {
            cart += 2;
            label32.Text = cart.ToString();
            cnt += 1;
            counter.Text = cnt.ToString();
        }

        private void plus_vounou_Click(object sender, EventArgs e)
        {
            cart += 2;
            label32.Text = cart.ToString();
            cnt += 1;
            counter.Text = cnt.ToString();
        }

        private void plus_lemon_Click(object sender, EventArgs e)
        {
            cart += 2;
            label32.Text = cart.ToString();
            cnt += 1;
            counter.Text = cnt.ToString();
        }

        private void add_black_Click(object sender, EventArgs e)
        {
            cart += 2;
            label32.Text = cart.ToString();
            cnt += 1;
            counter.Text = cnt.ToString();
        }

        private void add_chocolate_Click(object sender, EventArgs e)
        {
            cart += 2;
            label32.Text = cart.ToString();
            cnt += 1;
            counter.Text = cnt.ToString();
        }

        private void add_water_Click(object sender, EventArgs e)
        {
            cart += 2;
            label32.Text = cart.ToString();
            cnt += 1;
            counter.Text = cnt.ToString();
        }

        private void add_gemista_Click(object sender, EventArgs e)
        {
            cart += 6;
            label32.Text = cart.ToString();
            cnt += 1;
            counter.Text = cnt.ToString();
        }

        private void add_gigantes_Click(object sender, EventArgs e)
        {
            cart += 6;
            label32.Text = cart.ToString();
            cnt += 1;
            counter.Text = cnt.ToString();
        }

        private void add_pastitsio_Click(object sender, EventArgs e)
        {
            cart += 6;
            label32.Text = cart.ToString();
            cnt += 1;
            counter.Text = cnt.ToString();
        }

        private void add_spetso_Click(object sender, EventArgs e)
        {
            cart += 6;
            label32.Text = cart.ToString();
            cnt += 1;
            counter.Text = cnt.ToString();
        }

        private void add_steak_Click(object sender, EventArgs e)
        {
            cart += 5;
            label32.Text = cart.ToString();
            cnt += 1;
            counter.Text = cnt.ToString();
        }

        private void add_steak2_Click(object sender, EventArgs e)
        {
            cart += 5;
            label32.Text = cart.ToString();
            cnt += 1;
            counter.Text = cnt.ToString();
        }

        private void add_psaro_Click(object sender, EventArgs e)
        {
            cart += 5;
            label32.Text = cart.ToString();
            cnt += 1;
            counter.Text = cnt.ToString();
        }

        private void add_pikilia_Click(object sender, EventArgs e)
        {
            cart += 5;
            label32.Text = cart.ToString();
            cnt += 1;
            counter.Text = cnt.ToString();
        }

        private void add_ceasar_Click(object sender, EventArgs e)
        {
            cart += 2;
            label32.Text = cart.ToString();
            cnt += 1;
            counter.Text = cnt.ToString();
        }

        private void add_tost_Click(object sender, EventArgs e)
        {
            cart += 2;
            label32.Text = cart.ToString();
            cnt += 1;
            counter.Text = cnt.ToString();
        }

        private void add_pasta_Click(object sender, EventArgs e)
        {
            cart += 2;
            label32.Text = cart.ToString();
            cnt += 1;
            counter.Text = cnt.ToString();
        }

        private void add_donut_Click(object sender, EventArgs e)
        {
            cart += 2;
            label32.Text = cart.ToString();
            cnt += 1;
            counter.Text = cnt.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cart = 0;
            label32.Text = cart.ToString();
            counter.Text = 0.ToString();
        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void counter_Click(object sender, EventArgs e)
        {

        }

        private void Order_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(crt.ToString())){
                label32.Text = crt.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"online_help.chm");
            //Help
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!cart.Equals(0))
            {
                Transaction transaction = new Transaction();
                transaction.payment = cart.ToString();
                transaction.Show();
                this.Close();
            }
            else {
                MessageBox.Show("Δεν έχετε κάτι στο καλάθι σας");
                return;
            }
           
            
        }
    }
}
