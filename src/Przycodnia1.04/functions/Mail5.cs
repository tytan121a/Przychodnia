using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Przychodnia.functions
{
    public class Mail5
    {

        public void SendEmail(string recipient, string subject, string body)
        {
                try
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("przychodnia_v4@wp.pl", "Przychodnia");
                    mail.To.Add(recipient);
                    mail.Subject = subject;
                    mail.Body = body;

                    SmtpClient smtp = new SmtpClient("smtp.wp.pl");
                    smtp.Port = 587;
                smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential("przychodnia_v4@wp.pl", "Piesek123!");

                    smtp.Send(mail);
                }
                catch (SmtpException smtpEx)
                {
                    MessageBox.Show("SMTP błąd: " + smtpEx.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                   MessageBox.Show("Inny błąd: " + ex.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }


}
}
