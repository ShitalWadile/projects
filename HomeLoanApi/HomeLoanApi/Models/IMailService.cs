using MailKit.Net.Smtp;

using MailKit.Security;

namespace HomeLoanApi.Models
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}
