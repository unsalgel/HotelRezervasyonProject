using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelRezervasyon.WebUI.ViewComponents.Sidebar
{

    public class _SidebarComponent:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _SidebarComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            
                var client = _httpClientFactory.CreateClient();
                var responseContactMessage = await client.GetAsync("http://localhost:9362/api/Contact/GetContactCount");
                var jsonContactData = await responseContactMessage.Content.ReadAsStringAsync();
                ViewBag.ContactCount = jsonContactData;
                var responseSendMessage = await client.GetAsync("http://localhost:9362/api/SendMessage/GetSendMessageCount");
                var jsonSendData = await responseSendMessage.Content.ReadAsStringAsync();
                ViewBag.SendMesageCount = jsonSendData;
              
            
            return View();
        }
    }
}
