using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMessageController : ControllerBase
    {
        private readonly ISendMessageService _SendMessageService;

        public SendMessageController(ISendMessageService SendMessageService)
        {
            _SendMessageService = SendMessageService;
        }

        [HttpGet]
        public IActionResult SendMessageList()
        {
            return Ok(_SendMessageService.TGetList());
        }
        [HttpPost]
        public IActionResult AddSendMessage(SendMessage model)
        {
            _SendMessageService.TInsert(model);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSendMessage(int id)
        {
            var query = _SendMessageService.TGetByID(id);
            _SendMessageService.TDelete(query);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSendMessage(SendMessage model)
        {
            _SendMessageService.TUpdate(model);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetSendMessage(int id)
        {
            return Ok(_SendMessageService.TGetByID(id));
        }
        [HttpGet("GetSendMessageCount")]
        public IActionResult GetSendMessageCount()
        {
            return Ok(_SendMessageService.TGetSendMessageCount());
        }

    }
}
