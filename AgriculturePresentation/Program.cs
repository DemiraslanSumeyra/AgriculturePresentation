using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.Contexts;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IServiceService, ServiceManager>();
builder.Services.AddScoped<IServiceDal,EFServiceDal>();
builder.Services.AddScoped<ITeamService, TeamManager>();
builder.Services.AddScoped<ITeamDal, EFTeamDal>();
builder.Services.AddScoped<IAnnouncementService,AnnouncementManager>();
builder.Services.AddScoped<IAnnouncementDal,EFAnnouncementDal>();
builder.Services.AddScoped<IImageService, ImageManager>();
builder.Services.AddScoped<IImageDal, EFImageDal>();
builder.Services.AddScoped<IAddressService, AddressManager>();
builder.Services.AddScoped<IAddressDal, EFAddressDal>();
builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IContactDal, EFContactDal>();
builder.Services.AddScoped<ISocialMediaService, SocialMediaManager>();
builder.Services.AddScoped<ISocialMediaDal, EFSocialMediaDal>();
builder.Services.AddScoped<IAdminService, AdminManager>();
builder.Services.AddScoped<IAdminDal, EFAdminDal>();
builder.Services.AddDbContext<AgricultureContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
