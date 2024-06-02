using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace School_Managment_System
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=ABDIMALIK\\MSSQLSERVER01;Initial Catalog=school;Integrated Security=True;");
        public Login()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            if (usertxt.Text == "" || passtxt.Text == "")
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                string query = "select * from users where username = '" + usertxt.Text + "' and password = '" + passtxt.Text +"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows.Count == 1)
                {
                    MainForm m = new MainForm();
                    this.Hide();
                    m.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            passtxt.PasswordChar = showpass.Checked ? '\0' : '*';
        }
    }
}
