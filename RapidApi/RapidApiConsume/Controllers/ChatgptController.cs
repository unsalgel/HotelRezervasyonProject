using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Collections.Generic;
using RapidApiConsume.Models;
using System.Text;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http.Json;

namespace RapidApiConsume.Controllers
{
    public class ChatgptController : Controller
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public ChatgptController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string question)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://simple-chatgpt-api.p.rapidapi.com/ask"),
                Headers =
                {
                    { "X-RapidAPI-Key", "55a9615e6bmshed867a839d62db7p1dd59bjsn354381958d06" },
                    { "X-RapidAPI-Host", "simple-chatgpt-api.p.rapidapi.com" },
                },
                Content = new StringContent(JsonConvert.SerializeObject(new { question }))
                {
                    Headers =
                    {
                        ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json")
                    }
                }
            };
            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();
            var query = JsonConvert.DeserializeObject<ChatgptViewModel>(result);

            ViewBag.Answer = query.answer;

            return View();
        }
    }


}

