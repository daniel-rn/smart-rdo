using Microsoft.Extensions.DependencyInjection;
using SmartRdo.Business.Interfaces;
using SmartRdo.Business.Interfaces.repository;
using SmartRdo.Business.Interfaces.services;
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

            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IClienteRepository, ClienteRepository>();

            services.AddScoped<IOperadoresService, OperadorService>();
            services.AddScoped<IOperadorRepository, OperadorRepository>();

            services.AddScoped<IAreasService, AreasService>();
            services.AddScoped<IAreasRepository, AreaRepository>();

            services.AddScoped<IResponsavelAreasService, ResponsavelAreaService>();
            services.AddScoped<IResponsavelAreaRepository, ResponsavelAreaRepository>();

            services.AddScoped<IEquipamentoRepository, EquipamentoRepository>();
            services.AddScoped<IEquipamentoService, EquipamentoService>();

            return services;
        }
    }
}
