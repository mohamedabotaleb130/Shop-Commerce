using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Dtos
{
    public class WelcomeRequest
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
