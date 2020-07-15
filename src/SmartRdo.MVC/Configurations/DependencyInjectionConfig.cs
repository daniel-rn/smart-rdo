using Microsoft.Extensions.DependencyInjection;
using SmartRdo.Business.Interfaces;
using SmartRdo.Business.Notificacoes;
using SmartRdo.Business.Services;
using SmartRdo.Data.Context;
using SmartRdo.Data.Repository;

namespace SmartRdo.MVC.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<SmartRdoDbContext>();
            services.AddScoped<INotificador, Notificador>();

            services.AddScoped<IAtividadeService, AtividadeService>();
            services.AddScoped<IAtividadeRepository, AtividadeRepository>();

            return services;
        }
    }
}
