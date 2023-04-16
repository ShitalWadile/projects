using MailKit.Net.Smtp;

using MailKit.Security;

namespace HomeLoanApi.Models
{
    public class MailSettings
    {

        public string Mail { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string EnableSSL { get; set; }
        //public string UseDefaultCredentials { get; set; }
        //public string IsBodyHtml { get; set; }

        public User Users { get; set; }
    }
}
