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
using System.Net.Mail;

namespace WFEnvioCorreo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            var fromAddress = new MailAddress("asolorzanotapia@ppg.com");
            var toAddress = new MailAddress("asolorzanotapia@ppg.com");
            //const string fromPassword = "fromPassword";
            const string subject = "Prueba";
            const string body = "Prueba";

            var smtp = new SmtpClient
            {
                Host = "mail.ppg.com",
                Port = 25,
                EnableSsl = false,
                //DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = true,
                //Credentials = new NetworkCredential(fromAddress.Address, fromPassword);
                //Credentials = new NetworkCredential("asolorzanotapia@ppg.com", "Nala200531+*")
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
