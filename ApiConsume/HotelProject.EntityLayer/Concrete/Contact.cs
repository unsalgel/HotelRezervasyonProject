using System;
using System.ComponentModel.DataAnnotations;
 

namespace HotelProject.EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }
        public string FullName{ get; set; }
        public string Mail{ get; set; }
        public string Subject{ get; set; }
        public string Message{ get; set; }
        public DateTime Date { get; set; }
    }
}
