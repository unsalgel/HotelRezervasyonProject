using HotelProject.EntityLayer.Concrete;
using HotelRezervasyon.WebUI.Dtos.LoginDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelRezervasyon.WebUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginUserDto _loginUserDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var login = await _signInManager.PasswordSignInAsync(_loginUserDto.UserName, _loginUserDto.Password, true, true);
            if (login.Succeeded)
            {
                return RedirectToAction("Index", "Staff");
            }
            else
            {
                ModelState.AddModelError("", "Hatalı kullanıcı adı veya şifre girdiniz.");
            }
            return View();
        }
    }
}

