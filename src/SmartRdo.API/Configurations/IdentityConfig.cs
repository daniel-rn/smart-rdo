using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SmartRdo.API.Data;

namespace SmartRdo.API.Configurations
{
    public static class IdentityConfig
    {
        // pensar no problema de autenticacao para api e mvc
        public static IServiceCollection AddIdentityConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApiDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("MyWebMvcConnection")));

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApiDbContext>();

            return services;
        }
    }
}
