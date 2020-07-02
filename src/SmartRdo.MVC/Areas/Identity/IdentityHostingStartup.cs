using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(SmartRdo.MVC.Areas.Identity.IdentityHostingStartup))]
namespace SmartRdo.MVC.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}