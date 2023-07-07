using Microsoft.AspNetCore.Mvc;

namespace HotelRezervasyon.WebUI.ViewComponents.Default
{
    public class _ScriptComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
