using Microsoft.AspNetCore.Http;
using OnlineShop.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineShop.Services
{
    public interface IMailingService
    {
        //Task SendEmailAsync(string mailTo, string subject, string body, IList<IFormFile> attachments = null);

        //Task SendWelcomeEmailAsync(WelcomeRequest request);

    }
}
