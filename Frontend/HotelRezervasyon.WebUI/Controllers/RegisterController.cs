using HotelProject.EntityLayer.Concrete;
using HotelRezervasyon.WebUI.Dtos.RegisterDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelRezervasyon.WebUI.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Index(CreateNewUserDto _createNewUserDto)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            var appUser = new AppUser()
            {
                Name = _createNewUserDto.Name,
                SurName = _createNewUserDto.SurName,
                Email = _createNewUserDto.Mail,
                UserName = _createNewUserDto.UserName,
                ImageURL = "/images/resimyok.jpg",
                City = _createNewUserDto.City
            };
            var result = await _userManager.CreateAsync(appUser,_createNewUserDto.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
           
            return View();
        }
    }
}
