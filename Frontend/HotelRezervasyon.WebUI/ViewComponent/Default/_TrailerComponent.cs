using Microsoft.AspNetCore.Mvc;

namespace HotelRezervasyon.WebUI.ViewComponents.Default
{
    public class _TrailerComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
