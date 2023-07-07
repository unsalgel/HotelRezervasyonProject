using System.ComponentModel.DataAnnotations;

namespace HotelRezervasyon.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "Kullanıcı adı  Alanı boş geçilemez")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifre zorunlu bir alandır")]
        public string Password { get; set; }
    }
}
