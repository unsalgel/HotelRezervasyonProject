using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _IGuestService;

        public GuestController(IGuestService GuestGuest)
        {
            _IGuestService = GuestGuest;
        }

        [HttpGet]
        public IActionResult GuestList()
        {
            return Ok(_IGuestService.TGetList());
        }
        [HttpPost]
        public IActionResult AddGuest(Guest model)
        {
            _IGuestService.TInsert(model);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteGuest(int id)
        {
            var query = _IGuestService.TGetByID(id);
            _IGuestService.TDelete(query);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateGuest(Guest model)
        {
            _IGuestService.TUpdate(model);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetGuest(int id)
        {
            return Ok(_IGuestService.TGetByID(id));
        }
    }
}
