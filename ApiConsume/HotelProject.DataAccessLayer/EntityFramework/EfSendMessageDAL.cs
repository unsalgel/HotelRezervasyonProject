using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System.Linq;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfSendMessageDAL : GenericRepository<SendMessage>, ISendMessageDAL
    {
        public EfSendMessageDAL(Context context) : base(context)
        {
        }

        public int GetSendMessageCount()
        {
            var context = new Context();
            var values = context.SendMessages.Count();
            return values;
     
        }
    }
}
