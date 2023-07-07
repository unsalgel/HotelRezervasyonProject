using System.ComponentModel.DataAnnotations;

namespace HotelRezervasyon.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        [Required(ErrorMessage ="Lütfen ID alanını boş bırakmayınız")]
        public int ServiceID { get; set; }
        [Required(ErrorMessage = "Lütfen Icon alanını boş bırakmayınız")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Lütfen Hizmet başlığı alanını boş bırakmayınız")]
        [StringLength(150,MinimumLength =50,ErrorMessage ="Minimum 50 Max 150 karakter girebilirsin")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen Hizmet Açıklaması alanını boş bırakmayınız")]
        [StringLength(500, MinimumLength = 50, ErrorMessage = "Minimum 50 Max 500 karakter girebilirsin")]
        public string Description { get; set; }
    }
}
