using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using RapidApiConsume.Models;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace RapidApiConsume.Controllers
{
    public class HotelController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<HotelViewModel> hotelViewModels = new List<HotelViewModel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/locations?name=T%C3%BCrkiye&locale=en-gb"),
                Headers =
    {
        { "X-RapidAPI-Key", "55a9615e6bmshed867a839d62db7p1dd59bjsn354381958d06" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                hotelViewModels=JsonConvert.DeserializeObject<List<HotelViewModel>>(body);
                return View(hotelViewModels);
            }
        
        }
    }
}
