using AutoMapper;
using DevProject.Business.DependencyInjection;
using DevProject.DataAccess.Concrete.EntityFramework.Context;
using DevProject.Entities.Concrete;
using DevProject.WebUI.CustomCollectionExtension;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DevProject.WebUI
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
            services.AddDbContext<DevProjectContext>();
            services.AddCustomIdentity();
            services.AddAutoMapper(typeof(Startup));
            services.AddCustomValidator();
            services.AddControllersWithViews().AddFluentValidation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStatusCodePagesWithRedirects("/Home/StatusCode?code={0}");

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseStaticFiles();
            SeedDataIdentity.SeedData(userManager, roleManager).Wait();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                       name: "Admin",
                       pattern: "{area}/{controller=Admin}/{action=List}/{id?}"
                   );

                endpoints.MapControllerRoute(
                    name: "Member",
                    pattern: "{area}/{controller=Home}/{action=List}/{id?}"
                );

                endpoints.MapControllerRoute(
                     name: "default",
                     pattern: "{controller=Home}/{action=SignIn}/{id?}"
                 );
            });
        }
    }
}
