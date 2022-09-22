using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;
using System;
using System.Threading.Tasks;

namespace OnlineShop.Areas.Customer.Controllers.Api
{
    [Route ("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    [Area("Customer")]
    public class UsersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UsersController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpDelete]
        public async Task< IActionResult> DeleteUser(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
                return NotFound();
            var resulte = await _userManager.DeleteAsync(user);
            if (!resulte.Succeeded)
            {
                throw new Exception();
            }
            return Ok();
        }
    }
}
