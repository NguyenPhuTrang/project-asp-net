using FindJobOnWeb.Model.Entities;
using FindJobOnWeb.Repository;
using FindJobOnWeb.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindJobOnWeb
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
            services.AddControllersWithViews();
            services.AddDbContext<JobOnWebContext>(item => item.UseSqlServer(Configuration.GetConnectionString("FindJobConnect")));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GennericRepository<>));
            services.AddScoped<IJobPostService, JobPostService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICompanyService, CompanyService>();
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapAreaControllerRoute(
                    name: "Admin",
                    areaName: "Administrator",
                    pattern: "Administrator/{controller=JobPost}/{action=Index}/{id?}");
                endpoints.MapAreaControllerRoute(
                    name: "Register",
                    areaName: "Administrator",
                    pattern: "Administrator/{controller=Register}/{action=Index}/{id?}");  
                endpoints.MapAreaControllerRoute(
                    name: "Login",
                    areaName: "Administrator",
                    pattern: "Administrator/{controller=Login}/{action=Index}/{id?}");
                endpoints.MapAreaControllerRoute(
                    name: "Home",
                    areaName: "Administrator",
                    pattern: "Administrator/{controller=HomeAdmin}/{action=Index}/{id?}"); 
                endpoints.MapAreaControllerRoute(
                    name: "RegisterCp",
                    areaName: "Administrator",
                    pattern: "Administrator/{controller=RegisterCp}/{action=Index}/{id?}"); 
                endpoints.MapAreaControllerRoute(
                    name: "Jobdetails",
                    areaName: "Administrator",
                    pattern: "Administrator/{controller=Jobdetails}/{action=Index}/{id?}"); 
                endpoints.MapAreaControllerRoute(
                    name: "FindJob",
                    areaName: "Administrator",
                    pattern: "Administrator/{controller=FindJob}/{action=Index}/{id?}"); 

            });
        }
    }
}
 