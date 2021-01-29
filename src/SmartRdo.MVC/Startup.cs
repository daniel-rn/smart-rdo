using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NToastNotify;
using SmartRdo.Data.Context;
using SmartRdo.MVC.Configurations;

namespace SmartRdo.MVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddNToastNotifyNoty(new NotyOptions
            {
                ProgressBar = true,
                Timeout = 4000,
                Theme = "metroui"
                
                
            });

            services.AddIdentityConfiguration(Configuration);

            services.AddDbContext<SmartRdoDbContext>(options =>
                options.UseNpgsql(Configuration.GetConnectionString("SmartRdoConnection")));

            services.ResolveDependencies();

            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseNToastNotify();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseRouting();
            
            app.UseGlobalizationConfig();

            app.UseAuthentication();
           
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

            // remover o commentario
        }
    }
}
