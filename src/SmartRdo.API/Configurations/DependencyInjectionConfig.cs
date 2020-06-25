using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SmartRdo.API.Data;
using SmartRdo.Business.Interfaces;
using SmartRdo.Business.Notificacoes;

namespace SmartRdo.API.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ApiDbContext>();
            services.AddScoped<INotificador, Notificador>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            return services;
        }
    }
}
