using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            return Ok(_roomService.TGetList());
        }
        [HttpPost]
        public IActionResult AddRoom(Room model)
        {
            _roomService.TInsert(model);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            var query = _roomService.TGetByID(id);
            _roomService.TDelete(query);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRoom(Room model)
        {
            _roomService.TUpdate(model);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            return Ok(_roomService.TGetByID(id));
        }
    }
}
