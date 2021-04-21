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
    public partial class Thermometer : Form
    {
        public int allseconds;
        static Random rnd = new Random();
       
        string masterpassword = "1234";
        StringBuilder password = new StringBuilder();
        public Thermometer()
        {
            InitializeComponent();
        }
        
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           

        }

        

        private void Thermometer_Load(object sender, EventArgs e)
        {
            label4.Hide();
            panel1.Hide();
            label5.Hide();
            password.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.White;
            panel1.Show();
            label4.Hide();

           



        }


        private async void Show_Temp()
        {
            label4.Hide();
            
            System.Collections.ArrayList tempature = new System.Collections.ArrayList();
            create_arr(tempature);
            var x = rnd.Next(tempature.Count);

            
            label4.Text = tempature[x].ToString();
            await Task.Delay(2000);
            label4.Show();
            Double tmp = Double.Parse(label4.Text);
            Color_result(tmp);
        }
        private static object create_arr(System.Collections.ArrayList tempature) {
            
            tempature.Add(36.6);
            tempature.Add(36.7);
            tempature.Add(36.8);
            tempature.Add(37);
            tempature.Add(37.2);
            tempature.Add(37.5);
            tempature.Add(37.8);
            tempature.Add(37.9);
            tempature.Add(38.2);
            tempature.Add(38.7);
            tempature.Add(39.0);
            tempature.Add(40.0);

            return tempature;
        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            label2.Text = "Πατηστε Scan για να θερμομετρηθείτε";
            pictureBox3.BackColor = Color.White;
            Show_Temp();
        }

        private void Color_result(Double tmp)
        {
           


                if (tmp <= 36.6)
                {
                    pictureBox3.BackColor = Color.Green;
                    MessageBox.Show("Μπειτε στο σπιτι");
                    this.Close();
                }
                else if (tmp <= 37.5 && 36.6 < tmp)
                {
                    //ASk Eleni what to do about this
                    pictureBox3.BackColor = Color.Orange;
                    label2.Text = "Παρακαλώ περιμένετε \n για 5 λεπτά και ξαναδοκιμάστε";
                    allseconds = (5 * 60);
                    this.timer1.Enabled = true;
                    label5.Show();
                    label3.Hide();
                    button2.Enabled = false;
                    button1.Enabled = false;
                }
                else
                {
                    pictureBox3.BackColor = Color.Red;
                    MessageBox.Show("Go to the nearest Pharmacy");


                    PharmacyPic pic = new PharmacyPic();

                    pic.Show();
                    this.Close();
                
                    

                    //Make a form or a panel to show directions to the pharmacy

                }


            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (allseconds > 0)
            {
                allseconds--;
                int minutes = allseconds / 60;
                int seconds = allseconds - (minutes * 60);
                this.label5.Text = minutes + ":" + seconds;


            }
            else {
                this.timer1.Stop();
                label5.Hide();
                button2.Enabled = true;
                button1.Enabled = true;
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            
            password.Append('9') ; 
        }

        private void one_Click(object sender, EventArgs e)
        {
            password.Append('1');
        }

        private void two_Click(object sender, EventArgs e)
        {
            password.Append('2');
        }

        private void three_Click(object sender, EventArgs e)
        {
            password.Append('3');
        }

        private void four_Click(object sender, EventArgs e)
        {
            password.Append('4');
        }

        private void five_Click(object sender, EventArgs e)
        {
            password.Append('5');
        }

        private void six_Click(object sender, EventArgs e)
        {
            password.Append('6');
        }

        private void seven_Click(object sender, EventArgs e)
        {
            password.Append('7');
        }

        private void eight_Click(object sender, EventArgs e)
        {
            password.Append('8');
        }

        private void Enter_Click(object sender, EventArgs e)
        {   
            //Taking the password , making it to string
            string pw = password.ToString(); 
            if (pw == masterpassword) {
                MessageBox.Show("Μπείτε στο σπίτι");
                password.Clear();
                this.Close();
                
            }
            password.Clear();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            password.Append('0');
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void help_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"online_help.chm");

        }

        //Need a method to do the thermometer and all its tasks.
        //Find how to visualise it.
        //Fix the appearance a bit to make it homagenous.
        //when the thermometer is over , go to the next form of the house.
    }
}
