using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Text;

namespace CourseReportEmailer.Workers
{
    class EnrollmentDetailReportEmailSender
    {
        public void Send(string fileName)
        {
            SmtpClient client = new SmtpClient("smtp-mail.outlook.com");
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;

            // replace with your own information
            NetworkCredential creds = new NetworkCredential("[YOUR EMAIL]", "[YOUR PASSWORD]");

            client.EnableSsl = true;
            client.Credentials = creds;

            // replace with your own information
            MailMessage message = new MailMessage("[YOUR EMAIL]", "[RECEIVER EMAIL]");

            message.Subject = "Enrollment Details Report";
            message.IsBodyHtml = true;
            message.Body = "Hi,<br><br>Attached please find the enrollment details report.<br>";

            Attachment attachment = new Attachment(fileName);
            message.Attachments.Add(attachment);

            client.Send(message);
            Console.WriteLine("Sent.");
        }
    }
}
