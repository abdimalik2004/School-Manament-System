using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Managment_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width  += 5;
            if(panel2.Width >= 650)
            {
                timer1.Stop();
                Login d = new Login();
                this.Hide();
                d.Show();
            } 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
