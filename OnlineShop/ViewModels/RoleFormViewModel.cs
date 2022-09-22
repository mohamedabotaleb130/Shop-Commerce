using System.ComponentModel.DataAnnotations;

namespace OnlineShop.ViewModels
{
    public class RoleFormViewModel
    {
        [Required, StringLength(256)]
        public string Name { get; set; }
    }
}