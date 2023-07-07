using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {

        private readonly IBookingService _IBookingService;

        public BookingController(IBookingService BookingBooking)
        {
            _IBookingService = BookingBooking;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            return Ok(_IBookingService.TGetList());
        }
        [HttpPost]
        public IActionResult AddBooking(Booking model)
        {
            _IBookingService.TInsert(model);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var query = _IBookingService.TGetByID(id);
            _IBookingService.TDelete(query);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateBooking(Booking model)
        {
            _IBookingService.TUpdate(model);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            return Ok(_IBookingService.TGetByID(id));
        }
    }
}
