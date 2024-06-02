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
using School_Managment_System;

namespace School_Manament_System
{
    public partial class AddStudentsForm : Form
    {
        public AddStudentsForm()
        {
            InitializeComponent();
            showtable();
        }
        private string imagepath;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "image files (*.jpg; *.png;)|*.jpg;*.png";
            if(open.ShowDialog() == DialogResult.OK)
            {
                imagepath = open.FileName;
                simage.ImageLocation = imagepath;
            }
        }

        SqlConnection conn = new SqlConnection("Data Source=ABDIMALIK\\MSSQLSERVER01;Initial Catalog=school;Integrated Security=True;");
        private void showtable()
        {
            conn.Open();
            string query = "select * from studdents";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            sdatagrid.DataSource= ds.Tables[0];
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(sname.Text == " " && saddress.Text == " ")
            {
                MessageBox.Show("Please fill all the blank fields", "Erroe Message", MessageBoxButtons.OK,MessageBoxIcon.Information);
            } else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into studdents (students_name,students_gender,students_addres,students_grade,students_section,students_image)values (@sname,@sgender,@saddress,@sgrade,@ssection,@simage)", conn);
                    cmd.Parameters.AddWithValue("@sname", sname.Text);
                    cmd.Parameters.AddWithValue("@sgender", sgender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@saddress", saddress.Text);
                    cmd.Parameters.AddWithValue("@sgrade", sgrade.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ssection", ssection.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@simage", simage.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student's data has been saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    showtable();
                } 
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sname_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddStudentsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDataSet2.studdents' table. You can move, or remove it, as needed.
            this.studdentsTableAdapter2.Fill(this.schoolDataSet2.studdents);
            // TODO: This line of code loads data into the 'schoolDataSet1.studdents' table. You can move, or remove it, as needed.
            this.studdentsTableAdapter1.Fill(this.schoolDataSet1.studdents);
            // TODO: This line of code loads data into the 'schoolDataSet.studdents' table. You can move, or remove it, as needed.
            this.studdentsTableAdapter.Fill(this.schoolDataSet.studdents);

        }

        private void sdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            this.Hide();
            m.Show();
        }

        private void supdatebtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update studdents set students_name=@sname,students_gender=@sgender,students_addres=@saddress,students_grade=@sgrade,students_section=@ssection,students_image=@simage where ID=@SID", conn);
            cmd.Parameters.AddWithValue("@sname", sname.Text);
            cmd.Parameters.AddWithValue("@sgender", sgender.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@saddress", saddress.Text);
            cmd.Parameters.AddWithValue("@sgrade", sgrade.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@ssection", ssection.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@simage", simage.Text);
            cmd.Parameters.AddWithValue("@SID", key);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Student's data has been Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
            showtable();
        }
        int key = 0;
        private void sdatagrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (sdatagrid.SelectedRows.Count > 0)
                {
                    sname.Text = sdatagrid.SelectedRows[0].Cells[1].Value.ToString();
                    sgender.SelectedItem = sdatagrid.SelectedRows[0].Cells[2].Value.ToString();
                    saddress.Text = sdatagrid.SelectedRows[0].Cells[3].Value.ToString();
                    sgrade.SelectedItem = sdatagrid.SelectedRows[0].Cells[4].Value.ToString();
                    ssection.SelectedItem = sdatagrid.SelectedRows[0].Cells[5].Value.ToString();
                    simage.Text = sdatagrid.SelectedRows[0].Cells[6].Value.ToString();
                    if (sname.Text == " ")
                    {
                        key = 0;
                    }
                    else
                    {
                        key = Convert.ToInt32(sdatagrid.SelectedRows[0].Cells[0].Value.ToString());
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid duplicate Selection", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void AddStudentsForm_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void sdeletebtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from studdents where ID=@SID", conn);
            cmd.Parameters.AddWithValue("@SID", key);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Student's data has been deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
            showtable();

        }
    }
}
