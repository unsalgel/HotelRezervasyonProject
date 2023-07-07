using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {

        private readonly IContactService _IContactService;

        public ContactController(IContactService ContactContact)
        {
            _IContactService = ContactContact;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            return Ok(_IContactService.TGetList());
        }
        [HttpPost]
        public IActionResult AddContact(Contact model)
        {
            model.Date = Convert.ToDateTime(DateTime.Now.ToString());
            _IContactService.TInsert(model);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var query = _IContactService.TGetByID(id);
            _IContactService.TDelete(query);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateContact(Contact model)
        {
            _IContactService.TUpdate(model);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            return Ok(_IContactService.TGetByID(id));
        }
        [HttpGet("GetContactCount")]
        public IActionResult GetContactCount()
        {
            return Ok(_IContactService.TGetContactCount());
        }

    }
}
