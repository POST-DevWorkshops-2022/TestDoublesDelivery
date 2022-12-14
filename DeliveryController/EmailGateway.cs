using System.Net;
using System.Net.Mail;

namespace DeliverySystem
{
    public class EmailGateway : IMessageGateway
    {
        public void Send(string address, string subject, string message)
        {
            var smtpClient = new SmtpClient("localhost")
            {
                Port = 587,
                Credentials = new NetworkCredential("email", "password"),
                EnableSsl = true,
            };
    
            smtpClient.Send("noreply@example.com", address, subject, message);
        }
    }
}