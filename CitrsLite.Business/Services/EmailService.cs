using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CitrsLite.Business.Services
{
    public class EmailService
    {
        public async Task Email(int participantId, string template)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.IsBodyHtml= true;
            mailMessage.Body = template;
            mailMessage.To.Add(new MailAddress("Daniel.Greco@fdacs.gov"));
            mailMessage.From = (new MailAddress("Citrs@fdacs.gov", "Citrs"));
            mailMessage.Subject = "Testing Attachment";            

            SmtpClient client = new SmtpClient("relay.freshfromflorida.com", 25);

            try
            {
                client.Send(mailMessage);

            }
            catch (Exception exception)
            {
                throw;
            }
        }
    }
}
