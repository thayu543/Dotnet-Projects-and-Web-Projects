using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;// Regular Expression Library.
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Diagnostics.Eventing.Reader;

namespace Employee_Management_Application_using_C_.NET
{
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
        }
        public bool IsEmailValid(string email)
        {
            string pattern = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";

            Regex r = new Regex(pattern);
            return r.IsMatch(email);
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {

        }







        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (username_tb.Text.Trim() != "" && spassword_tb.Text.Trim() != "" && cpassword_tb.Text.Trim() != "" && email_tb.Text.Trim() != "" && mobilenum_tb.Text.Trim() != "")
                {
                    string emailAddress = email_tb.Text;
                    bool isValid = IsEmailValid(emailAddress);
                    if (isValid)
                    {
                        if (cpassword_tb.Text.Trim().Length >= 8)
                        {
                            if (cpassword_tb.Text.Trim() == spassword_tb.Text.Trim())
                            {
                                SqlConnection con = new SqlConnection("Data source=LAPTOP-NR9A91AS\\SQLEXPRESS; Initial Catalog=employeemanagement;Integrated Security=true");
                                con.Open();
                                SqlCommand cmd = new SqlCommand("sp_register1", con);
                                cmd.CommandType = CommandType.StoredProcedure;

                                SqlParameter p1 = new SqlParameter("@uname", SqlDbType.VarChar);
                                cmd.Parameters.Add(p1).Value = username_tb.Text.Trim();

                                SqlParameter p2 = new SqlParameter(@"spassword", SqlDbType.VarChar);
                                cmd.Parameters.Add(p2).Value = spassword_tb.Text.Trim();

                                SqlParameter p3 = new SqlParameter("@cpassword", SqlDbType.VarChar);
                                cmd.Parameters.Add(p3).Value = cpassword_tb.Text.Trim();

                                SqlParameter p4 = new SqlParameter("@email", SqlDbType.VarChar);
                                cmd.Parameters.Add(p4).Value = email_tb.Text.Trim();

                                SqlParameter p5 = new SqlParameter("@mobile_num", SqlDbType.VarChar);
                                cmd.Parameters.Add(p5).Value = mobilenum_tb.Text.Trim();

                                int a = cmd.ExecuteNonQuery();
                                if (a > 0)
                                {
                                    MessageBox.Show("Registered Successfully");
                                }
                                else
                                {
                                    MessageBox.Show("Registeration failed");
                                    con.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Miss Matching Password");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password must contain 8 digits");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Enter Email in correct format");
                    }


                }
                else
                {
                    MessageBox.Show("Fill all the Data's");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you want to Logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();// if we want to call from one page to another.
            form.Show();
            this.Hide();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            username_tb.Clear();
            spassword_tb.Clear();
            cpassword_tb.Clear();
            email_tb.Clear();
            mobilenum_tb.Clear();
        }
    }
}

