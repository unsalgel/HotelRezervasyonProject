using HotelProject.EntityLayer.Concrete;
using HotelRezervasyon.WebUI.Dtos.BookingDto;
using HotelRezervasyon.WebUI.Dtos.ContactDto;
using HotelRezervasyon.WebUI.Dtos.SendMessageDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HotelRezervasyon.WebUI.Controllers
{
    public class AdminContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private string url = "http://localhost:9362/api/Contact/";
        private string sendmessageurl = "http://localhost:9362/api/SendMessage/";
        public AdminContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Inbox()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync(url);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
           
                var values = JsonConvert.DeserializeObject<List<ResultContactDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        public async Task<IActionResult> SendBox()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync(sendmessageurl);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSendBoxDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddSendMessage()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddSendMessage(CreateSendMessage model)
        {

            model.SenderMail = "hotellierfounder@outlook.com";
            model.SenderName = "Admin";
            model.Date = DateTime.Now.Date;
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync(sendmessageurl, content);
            //mail başlangıç
            MailMessage mail = new MailMessage();
            mail.IsBodyHtml = true;
            mail.To.Add(model.ReceiverMail);
            mail.From = new MailAddress(model.SenderMail, "Hotelier", System.Text.Encoding.UTF8);
            mail.Subject = model.Title;
            mail.Body = model.Content;
            mail.IsBodyHtml = true;
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(model.SenderMail, "Deneme123.");
            smtpClient.Port = 587;
            smtpClient.Host = "smtp-mail.outlook.com";
            smtpClient.EnableSsl = true;
            smtpClient.Send(mail);
            //mail bitiş

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("SendBox");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> MessageDetails(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync(url + $"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetMessageByIdDto>(jsonData);
                return View(values);
            }

            return View();
        }
        [HttpGet]
        public async Task<IActionResult> MessageDetails2(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync(sendmessageurl + $"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetSenderMessageByIdDto>(jsonData);
                return View(values);
            }
            return View();
        }


    }
}
