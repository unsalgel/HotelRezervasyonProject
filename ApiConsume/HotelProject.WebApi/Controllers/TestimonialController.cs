using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _TestimonialService;

        public TestimonialController(ITestimonialService TestimonialService)
        {
            _TestimonialService = TestimonialService;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            return Ok(_TestimonialService.TGetList());
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial model)
        {
            _TestimonialService.TInsert(model);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var query = _TestimonialService.TGetByID(id);
            _TestimonialService.TDelete(query);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonial model)
        {
            _TestimonialService.TUpdate(model);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            return Ok(_TestimonialService.TGetByID(id));
        }
    }
}
