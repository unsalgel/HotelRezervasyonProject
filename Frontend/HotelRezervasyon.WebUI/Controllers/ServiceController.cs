using HotelRezervasyon.WebUI.Dtos.ServiceDto;
using HotelRezervasyon.WebUI.Models.StaffModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelRezervasyon.WebUI.Controllers
{
    public class ServiceController : Controller
    {
            private readonly IHttpClientFactory _httpClientFactory;
            private string url = "http://localhost:9362/api/Service/";
            public ServiceController(IHttpClientFactory httpClientFactory)
            {
                _httpClientFactory = httpClientFactory;
            }
            public async Task<IActionResult> Index()
            {
                var client = _httpClientFactory.CreateClient();
                //veri listelemek için
                var responseMessage = await client.GetAsync(url);
                if (responseMessage.IsSuccessStatusCode)
                {
                    var JsonData = await responseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(JsonData);
                    return View(values);
                }
                return View();
            }
        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddService(CreateServiceDto _createServiceDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var client = _httpClientFactory.CreateClient();
            //gönderirken json'a çevireceğimiz için yazıyorum
            var jsondata = JsonConvert.SerializeObject(_createServiceDto);
            //içeriği json olarak okuması için
            StringContent content = new StringContent(jsondata, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync(url, content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> DeleteService(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync(url + $"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateService(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync(url + $"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateServiceDto>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateService(UpdateServiceDto _updateServiceDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(_updateServiceDto);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync(url, content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }
    }
}
