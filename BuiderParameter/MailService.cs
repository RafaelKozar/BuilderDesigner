using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiderParameter
{
    public class MailService
    {
        public class EmailBuilder
        {
            private readonly Email email;
            public EmailBuilder(Email email) => this.email = email;
            public EmailBuilder From(string from)
            {
                email.From = from;
                return this;
            }

            public EmailBuilder To(string to)
            {
                email.To = to;
                return this;
            }
        }
        private void SendEmailInternal(Email email) { 
            Console.WriteLine(email.From+email.To);
        }
        public void SendEmail(Action<EmailBuilder> buildAction)
        {
            var email = new Email();
            email.Body = "Body";
            buildAction(new EmailBuilder(email));            
            SendEmailInternal(email);
        }
    }
}
