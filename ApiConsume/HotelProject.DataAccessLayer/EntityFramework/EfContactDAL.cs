using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfContactDAL : GenericRepository<Contact>, IContactDAL
    {
        public EfContactDAL(Context context) : base(context)
        {
        }
        //Gelen Mesaj sayısını tutmak için
        public int GetContactCount()
        {
            var context = new Context();
            var values = context.Contacts.Count();
            return values;
        }
    }
}
