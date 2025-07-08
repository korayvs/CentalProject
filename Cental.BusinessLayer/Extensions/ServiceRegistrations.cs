using Cental.BusinessLayer.Abstract;
using Cental.BusinessLayer.Concrete;
using Cental.DataAccessLayer.Abstract;
using Cental.DataAccessLayer.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BusinessLayer.Extensions
{
    public static class ServiceRegistrations
    {        
        public static void AddServiceRegistrations(this IServiceCollection services)
        {
            //IOC Container

            services.AddScoped<IAboutDal, EfAboutDal>();
            services.AddScoped<IAboutService, AboutManager>();
            
            services.AddScoped<IBannerDal, EfBannerDal>();
            services.AddScoped<IBannerService, BannerManager>();
            
            services.AddScoped<IBrandDal, EfBrandDal>();
            services.AddScoped<IBrandService, BrandManager>();
            
            services.AddScoped<ICarDal, EfCarDal>();
            services.AddScoped<ICarService, CarManager>();

            services.AddScoped<IImageService, ImageService>();

            services.AddScoped<IUserSocialDal, EfUserSocialDal>();
            services.AddScoped<IUserSocialService, UserSocialManager>();

            services.AddScoped<IBookingDal, EfBookingDal>();
            services.AddScoped<IBookingService, BookingManager>();

            services.AddScoped<IReviewDal, EfReviewDal>();
            services.AddScoped<IReviewService, ReviewManager>();

            services.AddScoped<IContactInfoDal, EfContactInfoDal>();
            services.AddScoped<IContactInfoService, ContactInfoManager>();

            services.AddScoped<IFeatureDal, EfFeatureDal>();
            services.AddScoped<IFeatureService, FeatureManager>();

            services.AddScoped<IMessageDal, EfMessageDal>();
            services.AddScoped<IMessageService, MessageManager>();

            services.AddScoped<IProcessDal, EfProcessDal>();
            services.AddScoped<IProcessService, ProcessManager>();

            services.AddScoped<IServiceDal, EfServiceDal>();
            services.AddScoped<IServiceService, ServiceManager>();

            services.AddScoped<ITestimonialDal, EfTestimonialDal>();
            services.AddScoped<ITestimonialService, TestimonialManager>();

            services.AddScoped<IDashboardDal, EfDashboardDal>();
            services.AddScoped<IDashboardService, DashboardManager>();

            services.AddScoped<IFactCounterDal, EfFactCounterDal>();
            services.AddScoped<IFactCounterService, FactCounterManager>();

            services.AddScoped<IImageService, ImageService>();
        }
    }
}
