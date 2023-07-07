using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomUpdateDto
    {
        [Required(ErrorMessage = "Lütfen ID numarasını giriniz !")]
        public int RoomID { get; set; } 
        [Required(ErrorMessage = "Lütfen oda numarasını giriniz !")]
        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Lütfen oda görseli giriniz !")]
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen Oda başlığı isimli kutucuğu doldurunuz !")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen Yatak sayısını  giriniz !")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen Banyo sayısını  giriniz !")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Lütfen Açıklama bilgisini giriniz !")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Lütfen fiyat bilgisini giriniz !")]
        public int Price { get; set; }
    }
}
