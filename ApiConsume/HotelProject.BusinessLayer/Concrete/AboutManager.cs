using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDAL _aboutDAL;

        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutDAL = aboutDAL;
        }

        public void TDelete(AboutUs t)
        {
            _aboutDAL.Delete(t);    
        }

        public AboutUs TGetByID(int id)
        {
            return _aboutDAL.GetByID(id);
        }

        public List<AboutUs> TGetList()
        {
            return _aboutDAL.GetList();
        }

        public void TInsert(AboutUs t)
        {
          _aboutDAL.Insert(t);
        }

        public void TUpdate(AboutUs t)
        {
            _aboutDAL.Update(t);
        }
    }
}
