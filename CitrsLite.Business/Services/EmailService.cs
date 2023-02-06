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
        }
    }
}
