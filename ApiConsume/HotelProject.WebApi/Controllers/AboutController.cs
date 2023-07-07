using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _AboutService;

        public AboutController(IAboutService AboutService)
        {
            _AboutService = AboutService;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            return Ok(_AboutService.TGetList());
        }
        [HttpPost]
        public IActionResult AddAbout(AboutUs model)
        {
            _AboutService.TInsert(model);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var query = _AboutService.TGetByID(id);
            _AboutService.TDelete(query);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAbout(AboutUs model)
        {
            _AboutService.TUpdate(model);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            return Ok(_AboutService.TGetByID(id));
        }
    }
}
