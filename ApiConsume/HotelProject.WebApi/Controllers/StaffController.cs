using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            return Ok(_staffService.TGetList());
        }
        [HttpPost]
        public IActionResult AddStaff(Staff model)
        {
            _staffService.TInsert(model);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStaff(int id)
        {
            var query = _staffService.TGetByID(id);
            _staffService.TDelete(query);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStaff(Staff model)
        {
            _staffService.TUpdate(model);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            return Ok(_staffService.TGetByID(id));
        }
    }
}
