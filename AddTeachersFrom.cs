using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient;
using School_Managment_System;
using static System.Collections.Specialized.BitVector32;
using System.Net;

namespace School_Manament_System
{
    public partial class AddTeachersFrom : Form
    {
        public AddTeachersFrom()
        {
            InitializeComponent();
            showtable();
        }
        private string imagepath;
        private void timportbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "image files (*.jpg; *.png;)|*.jpg;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                imagepath = open.FileName;
                timage.ImageLocation = imagepath;
            }
        }
        SqlConnection conn = new SqlConnection("Data Source=ABDIMALIK\\MSSQLSERVER01;Initial Catalog=school;Integrated Security=True;");
        private void showtable()
        {
            conn.Open();
            string query = "select * from teacherss";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            tdatagrid.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void taddbtn_Click(object sender, EventArgs e)
        {
            if(tname.Text == " " || taddress.Text == " ")
            {
                MessageBox.Show("Please fill the blank Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into teacherss (teachers_name,teachers_gender,teachers_addres,teachers_status,teachers_image)values (@tnam,@tgen,@tadd,@tstat,@timg)", conn);
                    cmd.Parameters.AddWithValue("@tnam", tname.Text);
                    cmd.Parameters.AddWithValue("@tgen", tgender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@tadd", taddress.Text);
                    cmd.Parameters.AddWithValue("@tstat", tstatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@timg", timage.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher's data has been saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    showtable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void AddTeachersFrom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDataSet3.teacherss' table. You can move, or remove it, as needed.
            this.teacherssTableAdapter.Fill(this.schoolDataSet3.teacherss);

        }

        private void label5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            this.Hide();
            m.Show();
        }
        int key = 0;

        private void tdatagrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (tdatagrid.SelectedRows.Count > 0)
                {
                    tname.Text = tdatagrid.SelectedRows[0].Cells[1].Value.ToString();
                    tgender.SelectedItem = tdatagrid.SelectedRows[0].Cells[2].Value.ToString();
                    taddress.Text = tdatagrid.SelectedRows[0].Cells[3].Value.ToString();
                    tstatus.SelectedItem = tdatagrid.SelectedRows[0].Cells[4].Value.ToString();
                    if (tdatagrid.Text == " ")
                    {
                        key = 0;
                    }
                    else
                    {
                        key = Convert.ToInt32(tdatagrid.SelectedRows[0].Cells[0].Value.ToString());
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid duplicate Selection");
            }
        }

        private void tupdatebtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update teacherss set teachers_name=@tnam,teachers_gender=@tgen,teachers_addres=@tadd,teachers_status=@tstat,teachers_image=@timg where ID=@TID", conn);
            cmd.Parameters.AddWithValue("@tnam", tname.Text);
            cmd.Parameters.AddWithValue("@tgen", tgender.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@tadd", taddress.Text);
            cmd.Parameters.AddWithValue("@tstat", tstatus.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@TID", key);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Teacher's data has been Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
            showtable();
        }

        private void tdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tdeletebtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from teacherss where ID=@TID",conn);
            cmd.Parameters.AddWithValue("TID", key);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Teacher's data has been deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
            showtable();
        }
    }
}
