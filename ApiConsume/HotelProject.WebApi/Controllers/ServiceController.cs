using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _ServiceService;

        public ServiceController(IServiceService ServiceService)
        {
            _ServiceService = ServiceService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            return Ok(_ServiceService.TGetList());
        }
        [HttpPost]
        public IActionResult AddService(Service model)
        {
            _ServiceService.TInsert(model);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var query = _ServiceService.TGetByID(id);
            _ServiceService.TDelete(query);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateService(Service model)
        {
            _ServiceService.TUpdate(model);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            return Ok(_ServiceService.TGetByID(id));
        }
    }
}
