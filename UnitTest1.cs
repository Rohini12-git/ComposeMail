using System;
using System.Net.Mail;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComposeMail
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void email_send()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com" ,587);
            mail.From = new MailAddress("tselenium023@gmail.com");
            mail.To.Add("rohinipriya12@gmail.com");
            mail.Subject = "Test Mail - 1";
            mail.Body = "mail with attachment";

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(@"C:\Users\Rohini\Desktop\gmailcred.txt");
            mail.Attachments.Add(attachment);

            // SmtpServer.Port = 587;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential("tselenium023@gmail.com", "seleniumtest1994");
            SmtpServer.EnableSsl = true;
            

            SmtpServer.Send(mail);

        }
    }
}
