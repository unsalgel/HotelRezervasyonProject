using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelRezervasyon.WebUI.Dtos.AboutDto;
using HotelRezervasyon.WebUI.Dtos.BookingDto;
using HotelRezervasyon.WebUI.Dtos.ContactDto;
using HotelRezervasyon.WebUI.Dtos.GuestDto;
using HotelRezervasyon.WebUI.Dtos.LoginDto;
using HotelRezervasyon.WebUI.Dtos.RegisterDto;
using HotelRezervasyon.WebUI.Dtos.RoomDto;
using HotelRezervasyon.WebUI.Dtos.ServiceDto;
using HotelRezervasyon.WebUI.Dtos.StaffDto;
using HotelRezervasyon.WebUI.Dtos.SubscribeDto;
using HotelRezervasyon.WebUI.Dtos.TestimonialDto;

namespace HotelRezervasyon.WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            //Listeleme Map
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            //Güncelleme Map
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            //Ekleme Map
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<CreateNewUserDto,AppUser>().ReverseMap(); 
            CreateMap<LoginUserDto,AppUser>().ReverseMap(); 

            CreateMap<ResultAboutDto,AboutUs>().ReverseMap(); 
            CreateMap<UpdateAboutDto,AboutUs>().ReverseMap();

            CreateMap<ResultRoomDto, Room>().ReverseMap();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();
            CreateMap<CreateRoomDto, Room>().ReverseMap();


            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();
            CreateMap<CreateTestimonialDto, Testimonial>().ReverseMap();
            CreateMap<UpdateTestimonialDto, Testimonial>().ReverseMap();

            CreateMap<ResultStaffDto, Staff>().ReverseMap();
            CreateMap<CreateStaffDto, Staff>().ReverseMap();
            CreateMap<UpdateStaffDto, Staff>().ReverseMap();

            CreateMap<ResultSubscribeDto, Subscribe>().ReverseMap();
            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();
            CreateMap<UpdateSubscribeDto, Subscribe>().ReverseMap();


            CreateMap<ResultBookingDto, Booking>().ReverseMap();
            CreateMap<CreateBookingDto, Booking>().ReverseMap();
            CreateMap<UpdateBookingDto, Booking>().ReverseMap();

            CreateMap<CreateContactDto, Contact>().ReverseMap();
            CreateMap<ResultContactDto, Contact>().ReverseMap();

            CreateMap<ResultGuestDto, Guest>().ReverseMap();
            CreateMap<CreateGuestDto, Guest>().ReverseMap();
            CreateMap<UpdateGuestDto, Guest>().ReverseMap();


          

        }
    }
}
