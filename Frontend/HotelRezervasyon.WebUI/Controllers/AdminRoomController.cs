using HotelRezervasyon.WebUI.Dtos.RoomDto;
using HotelRezervasyon.WebUI.Dtos.ServiceDto;
using HotelRezervasyon.WebUI.Models.StaffModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HotelRezervasyon.WebUI.Controllers
{
    public class AdminRoomController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private string url = "http://localhost:9362/api/Room/";

        public AdminRoomController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync(url);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultRoomDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        public async Task<IActionResult> AddRoom(CreateRoomDto model, IFormFile RoomCoverImage)
        {
            if (ModelState.IsValid)
            {
                if (RoomCoverImage != null && RoomCoverImage.Length > 0)
                {
                    var fileName = Path.GetFileName(RoomCoverImage.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await RoomCoverImage.CopyToAsync(fileStream);
                    }
                    model.RoomCoverImage = "/images/" + fileName; // Resim yolu sütuna kaydediliyor.
                }

                var client = _httpClientFactory.CreateClient();
                var jsondata = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(jsondata, Encoding.UTF8, "application/json");
                var responseMessage = await client.PostAsync(url, content);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
        public async Task<IActionResult> DeleteRoom(int id)
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
        public async Task<IActionResult> UpdateRoom(int id)
        {

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync(url + $"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateRoomDto>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateRoom(UpdateRoomDto model, IFormFile RoomCoverImage)
        {
            if (RoomCoverImage != null && RoomCoverImage.Length > 0)
            {
                var fileName = Path.GetFileName(RoomCoverImage.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await RoomCoverImage.CopyToAsync(fileStream);
                }
                model.RoomCoverImage = "/images/" + fileName;
            }
            else
            {
                // Resim seçilmediyse, mevcut veritabanı kaydındaki resim yolu korunur
                var client = _httpClientFactory.CreateClient();
                var response = await client.GetAsync(url + $"{model.RoomID}");
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var existingRoom = JsonConvert.DeserializeObject<UpdateRoomDto>(responseContent);
                    model.RoomCoverImage = existingRoom.RoomCoverImage;
                }
            }

            var putClient = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var putResponseMessage = await putClient.PutAsync(url, content);
            if (putResponseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }


    }
}


