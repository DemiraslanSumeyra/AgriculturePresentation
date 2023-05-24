using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
           services.AddScoped<IServiceService, ServiceManager>();
           services.AddScoped<IServiceDal, EFServiceDal>();
            services.AddScoped<ITeamService, TeamManager>();
            services.AddScoped<ITeamDal, EFTeamDal>();
            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementDal, EFAnnouncementDal>();
            services.AddScoped<IImageService, ImageManager>();
            services.AddScoped<IImageDal, EFImageDal>();
            services.AddScoped<IAddressService, AddressManager>();
            services.AddScoped<IAddressDal, EFAddressDal>();
            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IContactDal, EFContactDal>();
            services.AddScoped<ISocialMediaService, SocialMediaManager>();
            services.AddScoped<ISocialMediaDal, EFSocialMediaDal>();
            services.AddScoped<IAdminService, AdminManager>();
            services.AddScoped<IAdminDal, EFAdminDal>();
        }
    }
}
