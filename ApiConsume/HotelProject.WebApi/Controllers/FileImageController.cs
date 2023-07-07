using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileImageController : ControllerBase
    {//dosya veya resim ekleme işlemi için ben bunu  front end kısmında kullanmadım
        [HttpPost]
        public async Task<IActionResult> UploadImage([FromForm]IFormFile file)
        {
            var fileName =Guid.NewGuid()+Path.GetExtension(file.FileName);
            var path =Path.Combine(Directory.GetCurrentDirectory(), "images/"+fileName);
            var stream = new FileStream(path, FileMode.Create);
            await file.CopyToAsync(stream);
            return Created("", file);
        }
    }
}
