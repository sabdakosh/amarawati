using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication17
{
    class email
    {
        public String sendEmail(string body, string attachmentPath)
        {
            String mes = "sucess";
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add("mr.outlive@gmail.com");//receiver mail address
                mail.From = new MailAddress("mr.sanjeevjarga@gmail.com");//senders mail
                mail.Subject = "subject of mail";//subject of mail

                mail.Body = body;// message body
                mail.IsBodyHtml = true;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();



                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(attachmentPath);
                mail.Attachments.Add(attachment);

                smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
                smtp.Credentials = new System.Net.NetworkCredential
                     ("mr.sanjeevjarga@gmail.com", "hiusanjetyl"); // ***use valid credentials***
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

    //class for grid 
    class Grid
    {
        public Rectangle Rectangle { get; set; }
        public string GridName { get; set; }
        public Grid(Point location, Size size, string name)
        {
            GridName = name;
            Rectangle = new Rectangle(location, size);
        }
    } 
}
