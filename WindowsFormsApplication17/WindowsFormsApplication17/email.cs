using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication17
{
    class email
    {
        public String sendEmail(string body)
        {
            String mes = "sucess";
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add("mail to address");//receiver mail address
                mail.From = new MailAddress("mail from address");//senders mail
                mail.Subject = "subject of mail";//subject of mail

                mail.Body = body;// message body

                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
                smtp.Credentials = new System.Net.NetworkCredential
                     ("Fullemailid@gmail.com", "password"); // ***use valid credentials***
                smtp.Port = 587;

                //Or your Smtp Email ID and Password
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                mes = "failed";
            }
            return mes;
        }
    }
}
