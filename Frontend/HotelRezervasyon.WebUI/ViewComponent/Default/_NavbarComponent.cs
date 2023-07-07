using Microsoft.AspNetCore.Mvc;

namespace HotelRezervasyon.WebUI.ViewComponents.Default
{
    public class _NavbarComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
