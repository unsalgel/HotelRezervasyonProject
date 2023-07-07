using HotelProject.BusinessLayer.Abstract;
using HotelProject.BusinessLayer.Concrete;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Context>();
            //bir kere örnek oluþtur o örneði kullan

            services.AddScoped<IStaffDAL, EfStaffDAL>();
            services.AddScoped<IStaffService, StaffManager>();

            services.AddScoped<IRoomDAL, EfRoomDAL>();
            services.AddScoped<IRoomService, RoomManager>();

            services.AddScoped<ISubscribeDAL, EfSubscribeDAL>();
            services.AddScoped<ISubscribeService, SubscribeManager>();

            services.AddScoped<ITestimonialDAL, EfTestimonialsDAL>();
            services.AddScoped<ITestimonialService, TestimonialManager>();

            services.AddScoped<IServicesDAL, EfServiceDAL>();
            services.AddScoped<IServiceService, ServiceManager>();

            services.AddScoped<IAboutDAL, EfAboutDAL>();
            services.AddScoped<IAboutService, AboutManager>();

            services.AddScoped<IBookingDAL, EfBookingDAL>();
            services.AddScoped<IBookingService, BookingManager>();

            services.AddScoped<IContactDAL, EfContactDAL>();
            services.AddScoped<IContactService, ContactManager>();

            services.AddScoped<IGuestDAL, EfGuestDAL>();
            services.AddScoped<IGuestService, GuestManager>();

            services.AddScoped<ISendMessageDAL, EfSendMessageDAL>();
            services.AddScoped<ISendMessageService, SendMessageManager>();
            //Apinin farklý kaynaklara eriþime açýlmasýný saðlar
            services.AddCors(opt =>
            {
                opt.AddPolicy("OtelApiCors", opts =>
                {
                    //Herhangi bir kaynaða izin vermek için
                    opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });
            //auto mapper için ekledim
            services.AddAutoMapper(typeof(Startup));
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "HotelProject.WebApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "HotelProject.WebApi v1"));
            }
            //Yukarýda apimizi dýþ kaynaklara açarken verdiðimiz OtelApiCors deðerini burda app.usecors ile  tanýmlamamýz gerek
            app.UseCors("OtelApiCors");

            app.UseRouting();
            
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
