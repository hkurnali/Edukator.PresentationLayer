using Edukator.BusinessLayer.Abstract;
using Edukator.BusinessLayer.Concrete;
using Edukator.DataAccesLayer.Abstract;
using Edukator.DataAccesLayer.Concrete;
using Edukator.DataAccesLayer.EntityFramework;
using Edukator.EntityLayer.Concrete;
using Edukator.PresentationLayer.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer
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
            services.AddScoped<ICategoryDal,EfCategoryDal>();
            services.AddScoped<ICategoryService,CategoryManager>();
           

            services.AddScoped<ICourseDal, EfCourseDal>();
            services.AddScoped<ICourseService, CourseManager>();

            services.AddScoped<IAboutPageEntranceDal, EfAboutPageEntranceDal>();
            services.AddScoped<IAboutPageEntranceService, AboutPageEntranceManager>();


            services.AddScoped<IMapDal, EfMapDal>();
            services.AddScoped<IMapService, MapManager>();

            services.AddScoped<IContactDal, EfContactDal>();
            services.AddScoped<IContactService, ContactManager>();

            services.AddScoped<ICourseRegisterDal, EfCourseRegisterDal>();
            services.AddScoped<ICourseRegisterService, CourseRegisterManager>();

            services.AddScoped<IAboutPageTeamDal, EfAboutPageTeamDal>();
            services.AddScoped<IAboutPageTeamService, AboutPageTeamManager>();

            services.AddScoped<IAboutPageValueDal, EfAboutPageValueDal>();
            services.AddScoped<IAboutPageValueService, AboutPageValueManager>();

            services.AddScoped<IFeatureDal, EfFeatureDal>();
            services.AddScoped<IFeatureService, FeatureManager>();



            services.AddScoped<IAboutPageCourseDal, EfAboutPageCourseDal>();
            services.AddScoped<IAboutPageCourseService, AboutPageCourseManager>();

            services.AddScoped<IAboutDal, EfAboutDal>();
            services.AddScoped<IAboutService, AboutManager>();


            services.AddScoped<ITestimonialDal, EfTestimonialDal>();
            services.AddScoped<ITestimonialService, TestimonialManager>();



            services.AddScoped<IMailSubscribeDal, EfMailSubscribeDal>();
            services.AddScoped<IMailSubscribeService, MailSubscribeManager>();


            services.AddScoped<IFooterDal, EfFooterDal>();
            services.AddScoped<IFooterService, FooterManager>();

            services.AddScoped<IContactPageMessageDal, EfContactPageMessageDal>();
            services.AddScoped<IContactPageMessageService, ContactPageMessageManager>();


            services.AddScoped<IServiceDal, EfServiceDal>();
            services.AddScoped<IServiceService, ServiceManager>();

            services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
            services.AddScoped<ISocialMediaService, SocialMediaMenager>();
            services.AddIdentity<AddUser,AppRole>().AddEntityFrameworkStores<Context>().AddErrorDescriber<CustomIdentityValidator>();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Default}/{action=Index}/{id?}"
                );
            });

        }
    }
}
