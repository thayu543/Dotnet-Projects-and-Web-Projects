
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Intrinsics.X86;

namespace Employee_Management_Application_using_C_.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (loguname_tb.Text.Trim() == "" || lgpass_tb.Text.Trim() == "")
                {
                    MessageBox.Show("Fill all the data's");
                }
                else if (loguname_tb.Text.Trim() == "Thayumanavan" || lgpass_tb.Text.Trim() == "ra5656**")
                {
                    MessageBox.Show("Welcome Back Thayumanavan");
                    Dashboard D = new Dashboard();
                    D.Show();
                    this.Hide();
                }
                else
                {
                    SqlConnection con = new SqlConnection("Data source=LAPTOP-NR9A91AS\\SQLEXPRESS; Initial Catalog=employeemanagement;Integrated Security=true");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_login", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("@uname", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = loguname_tb.Text.Trim();

                    SqlParameter p2 = new SqlParameter(@"cpassword", SqlDbType.VarChar);
                    cmd.Parameters.Add(p2).Value = lgpass_tb.Text.Trim();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    //type casting operator:
                    int a = Convert.ToInt32(ds.Tables[0].Rows.Count);
                    if (a > 0)
                    {
                        MessageBox.Show("Welcome Back" + loguname_tb.Text);
                        EmpDashboard ep = new EmpDashboard();
                        ep.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Invalid User");
                        con.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loguname_tb.Clear();
            lgpass_tb.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lgpass_tb.PasswordChar = checkBox1.Checked ? '0' : '*';
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you want to Exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration_Form R = new Registration_Form();
            R.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword FP = new ForgetPassword();
            FP.Show();
            this.Hide();
        }
    }
}