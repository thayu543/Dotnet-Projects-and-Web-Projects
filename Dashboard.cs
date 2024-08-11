using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_Application_using_C_.NET
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you want to Logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                MessageBox.Show("Logout Successfully");
                Form1 form = new Form1();
                form.Show();
                this.Hide();

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source=LAPTOP-NR9A91AS\\SQLEXPRESS; Initial Catalog=employeemanagement;Integrated Security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_emp_register", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p1 = new SqlParameter("@emp_id", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = textBox4.Text.Trim();

            SqlParameter p2 = new SqlParameter(@"emp_name", SqlDbType.VarChar);
            cmd.Parameters.Add(p2).Value = textBox1.Text.Trim();

            SqlParameter p3 = new SqlParameter("@emp_salary", SqlDbType.VarChar);
            cmd.Parameters.Add(p3).Value = textBox2.Text.Trim();

            SqlParameter p4 = new SqlParameter("@emp_dep", SqlDbType.VarChar);
            cmd.Parameters.Add(p4).Value = comboBox1.SelectedItem.ToString();

            SqlParameter p5 = new SqlParameter("@emp_role", SqlDbType.VarChar);
            cmd.Parameters.Add(p5).Value = comboBox2.SelectedItem.ToString();

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Employee Details Added Successfully");
            }
            else
            {
                MessageBox.Show("!!!failed!!!");
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source=LAPTOP-NR9A91AS\\SQLEXPRESS; Initial Catalog=employeemanagement;Integrated Security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_fetch", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            da.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you want to Delete Employee?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Data source=LAPTOP-NR9A91AS\\SQLEXPRESS; Initial Catalog=employeemanagement;Integrated Security=true");
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_delete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p5 = new SqlParameter("@emp_id", SqlDbType.VarChar);
                cmd.Parameters.Add(p5).Value = textBox3.Text;

                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Deleted Successfully");

                }
                con.Close();
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data source=LAPTOP-NR9A91AS\\SQLEXPRESS; Initial Catalog=employeemanagement;Integrated Security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_search", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@Searchdata", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = textBox3.Text;
            SqlDataAdapter SD = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            SD.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data source=LAPTOP-NR9A91AS\\SQLEXPRESS; Initial Catalog=employeemanagement;Integrated Security=true");
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_update", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@emp_id", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = textBox4.Text.Trim();

                SqlParameter p2 = new SqlParameter(@"emp_name", SqlDbType.VarChar);
                cmd.Parameters.Add(p2).Value = textBox1.Text.Trim();

                SqlParameter p3 = new SqlParameter("@emp_salary", SqlDbType.VarChar);
                cmd.Parameters.Add(p3).Value = textBox2.Text.Trim();

                SqlParameter p4 = new SqlParameter("@emp_dep", SqlDbType.VarChar);
                cmd.Parameters.Add(p4).Value = comboBox1.SelectedItem.ToString();

                SqlParameter p5 = new SqlParameter("@emp_role", SqlDbType.VarChar);
                cmd.Parameters.Add(p5).Value = comboBox2.SelectedItem.ToString();

                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Employee Data Updated Successfully");
                }
                else
                {
                    MessageBox.Show("!!!Updation failed!!!");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(bitmap, 120, 120);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

            }
           catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
    }
}

