using Microsoft.Extensions.DependencyInjection;
using SmartRdo.Business.Interfaces;
using SmartRdo.Business.Notificacoes;
using SmartRdo.Data.Context;

namespace SmartRdo.MVC.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<SmartRdoDbContext>();
            services.AddScoped<INotificador, Notificador>();

            return services;
        }
    }
}
