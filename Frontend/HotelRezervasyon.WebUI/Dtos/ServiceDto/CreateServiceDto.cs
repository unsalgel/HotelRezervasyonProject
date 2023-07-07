using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace HotelRezervasyon.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="Lütfen Hizmet Icon linki giriniz")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Lütfen Hizmet başlığı alanını boş bırakmayınız")]
        [StringLength(150, MinimumLength =15, ErrorMessage = "Minimum 15 Max 150 karakter girebilirsin")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen Hizmet Açıklaması alanını boş bırakmayınız")]
        [StringLength(500, MinimumLength = 30, ErrorMessage = "Minimum 30 Max 500 karakter girebilirsin")]
        public string Description { get; set; }
    }
}
