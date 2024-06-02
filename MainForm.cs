using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School_Manament_System;
using System.Data;
using System.Data.SqlClient;

namespace School_Managment_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            showtable1();
            countstud();
            counttea();
            gstudents();
            acteachers();
        }
        SqlConnection conn = new SqlConnection("Data Source=ABDIMALIK\\MSSQLSERVER01;Initial Catalog=school;Integrated Security=True;");
        private void showtable1()
        {
            conn.Open();
            string query = "select * from studdents";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            datagrid2.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure to want logout", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(check == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Close();
                
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddStudentsForm s = new AddStudentsForm();
            this.Hide();
            s.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddTeachersFrom t = new AddTeachersFrom();
            this.Hide();
            t.Show();
        }
        private void countstud()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from studdents",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            snumbers.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }
        private void counttea()
        {
            conn.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from teacherss", conn);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            tnumbers.Text = dt1.Rows[0][0].ToString();
            conn.Close();
        }
        string grad = "secondary";
        private void gstudents()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from studdents where students_grade ='"+ grad+"'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            std.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }
        string stat = "Active";
        private void acteachers()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from teacherss where teachers_status ='" + stat + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
             tnumbers.Text= dt.Rows[0][0].ToString();
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDataSet4.studdents' table. You can move, or remove it, as needed.
            this.studdentsTableAdapter.Fill(this.schoolDataSet4.studdents);

        }
    }
}
