using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _SubscribeService;

        public SubscribeController(ISubscribeService SubscribeService)
        {
            _SubscribeService = SubscribeService;
        }

        [HttpGet]
        public IActionResult SubscribeList()
        {
            return Ok(_SubscribeService.TGetList());
        }
        [HttpPost]
        public IActionResult AddSubscribe(Subscribe model)
        {
            _SubscribeService.TInsert(model);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSubscribe(int id)
        {
            var query = _SubscribeService.TGetByID(id);
            _SubscribeService.TDelete(query);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSubscribe(Subscribe model)
        {
            _SubscribeService.TUpdate(model);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetSubscribe(int id)
        {
            return Ok(_SubscribeService.TGetByID(id));
        }
    }
}
