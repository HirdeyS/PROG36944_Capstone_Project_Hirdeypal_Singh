using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

namespace Capstone_Project_Piyush_Hirdey.Services
{
    public class NoOpEmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // do nothing — for development
            return Task.CompletedTask;
        }
    }
}
