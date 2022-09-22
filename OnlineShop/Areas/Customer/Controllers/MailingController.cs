//using MailKit.Net.Smtp;
//using MailKit.Security;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using MimeKit;
//using OnlineShop.Dtos;
//using OnlineShop.Services;
//using OnlineShop.Settings;
//using System.IO;
//using System.Threading.Tasks;

//namespace OnlineShop.Areas.Customer.Controllers
//{

//    [Route("api/[controller]")]
//    [ApiController]
  


//    public class MailingController : ControllerBase
//    {
//        private readonly IMailingService _mailingService;

//        public MailingController(IMailingService mailingService)
//        {
//            _mailingService = mailingService;
//        }

//        [HttpPost("send")]
//        public async Task<IActionResult> SendMail([FromForm] MailRequestDto dto)
//        {
//            await _mailingService.SendEmailAsync(dto.ToEmail, dto.Subject, dto.Body, dto.Attachments);
//            return Ok();
//        }
            
//        [HttpPost("welcome")]
//        public async Task<IActionResult> SendWelcomeEmail([FromBody] WelcomeRequest dto)
//        {
//            var filePath = $"{Directory.GetCurrentDirectory()}\\Templates\\EmailTemplate.cshtml";
//            var str = new StreamReader(filePath);

//            var mailText = str.ReadToEnd();
//            str.Close();

//            mailText = mailText.Replace("[username]", dto.UserName).Replace("[email]", dto.Email);

//            await _mailingService.SendEmailAsync(dto.Email, "Welcome to our channel", mailText);
//            return Ok();
//        }
//    }
//}



