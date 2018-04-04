using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace BulkMailer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            string fromMail = userTxt.Text;
            string pwd = passwordTxt.Text;
            List<string> emails = emailLst.Items.Cast<String>().ToList();
            string subject = subjectTxt.Text;
            string body = bodyTxt.Text;

            if (userTxt.Text != "" && emails != null && subject != "" &&  body != "" && pwd != "")
            {
                try
                {
                    if (IsValidEmail(fromMail))
                        SendEmail(fromMail, pwd, emails, subject, body);
                    else
                        MessageBox.Show("Your user email is wrong");
                }
                catch (Exception)
                {
                    MessageBox.Show("User and password are wrong or you need to allow access to lower" +
                        "level applications in your mail!");
                }
            }

        }
        
        public void SendEmail(string from, string password, List<string> emails, string subject, string body)
        {
            MailMessage message = new MailMessage();

            message.From = new MailAddress(from);

            // add all emails you want to send an email to
            foreach (var email in emails)
            {
                message.To.Add(email);
            }
            
            // set subject and body of the message
            message.Subject = subject;
            message.Body = body;

            // gmail smtp server
            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
            smtpServer.Port = 587;

            // set user name and password of the 
            // mail you want to send from
            smtpServer.Credentials = new System.Net.NetworkCredential(from.Split('@')[0], passwordTxt.Text);
            smtpServer.EnableSsl = true;

            smtpServer.Send(message);
            MessageBox.Show("Message has been sent");
        }


        public Boolean IsValidEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string mail = toTxt.Text;
            if (IsValidEmail(mail))
                emailLst.Items.Add(mail);
            else
                MessageBox.Show("The email you wish to add does not exist!");
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            int indexSelected = emailLst.SelectedIndex;
            if (indexSelected == -1)
                MessageBox.Show("You did not select an item to remove!");
            else
                emailLst.Items.RemoveAt(indexSelected);
        }
    }
}
