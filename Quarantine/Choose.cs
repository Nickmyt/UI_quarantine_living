using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quarantine
{
    public partial class Choose : Form
    {
        public Choose()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            Computer_screen computer = new Computer_screen();
            computer.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"online_help.chm");
        }
    }
}
