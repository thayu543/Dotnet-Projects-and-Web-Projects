using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail; // we have to declare two libraries

namespace Employee_Management_Application_using_C_.NET
{
    public partial class ForgetPassword : Form
    {
        string randomcode;
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody, to; // variables 
            Random random = new Random(); //random class
            randomcode = (random.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (textBox1.Text).ToString();
            from = "eshwarbalamurugan@gmail.com";
            pass = "hjwc bael xfay sjal";
            messageBody = "Your OTP Verification Code is  :" + randomcode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Employee Management Verification";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("OTP Sended Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (randomcode == (textBox2.Text).ToString())
            {
                MessageBox.Show("OTP Verified Successfully");
                ChangePassword cp = new ChangePassword();
                cp.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid OTP");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
