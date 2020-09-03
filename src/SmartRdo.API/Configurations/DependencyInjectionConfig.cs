using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SmartRdo.API.Extensions;
using SmartRdo.Business.Interfaces;
using SmartRdo.Business.Interfaces.repository;
using SmartRdo.Business.Interfaces.services;
using SmartRdo.Business.Notificacoes;
using SmartRdo.Business.Services;
using SmartRdo.Data.Context;
using SmartRdo.Data.Repository;

namespace SmartRdo.API.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ApplicationDbContext>();
            services.AddScoped<SmartRdoDbContext>();
            services.AddScoped<IAtividadeRepository, AtividadeRepository>();
            services.AddScoped<INotificador, Notificador>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IUser, AspNetUser>();

            services.AddScoped<IAtividadeService, AtividadeService>();

            return services;
        }
    }
}
