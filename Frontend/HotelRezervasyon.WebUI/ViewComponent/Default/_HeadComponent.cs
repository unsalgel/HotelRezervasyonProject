using Microsoft.AspNetCore.Mvc;

namespace HotelRezervasyon.WebUI.ViewComponents.Default
{
    public class _HeadComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
