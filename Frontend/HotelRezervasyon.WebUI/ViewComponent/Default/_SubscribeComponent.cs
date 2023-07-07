using Microsoft.AspNetCore.Mvc;

namespace HotelRezervasyon.WebUI.ViewComponents.Default
{
    public class _SubscribeComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
