using System.ComponentModel.DataAnnotations;

namespace HotelRezervasyon.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Ad Alanı boş geçilemez")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyad Alanı boş geçilemez")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Kullanıcı adı  Alanı boş geçilemez")]
        public string UserName { get; set; }
        [EmailAddress(ErrorMessage = "Lütfen geçerli bir e-posta adresi girin")]
        [Required(ErrorMessage = "E-posta adresi zorunlu bir alandır")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Şifre zorunlu bir alandır")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage="Şifreler uyuşmuyor kontrol ediniz")]
        public string PasswordConfirm { get; set; }
        public string City { get; set; }
    }
}
