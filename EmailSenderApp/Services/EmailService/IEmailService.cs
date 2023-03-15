using EmailSenderApp.Models;

namespace EmailSenderApp.Services.EmailService
{
    public interface IEmailService
    {
        public void SendEmail(EmailStructure request);

    }
}
