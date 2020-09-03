using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace SmartRdo.API.Configurations
{
    public static class SwaggerConfiguration
    {
        public static void AddSwaggerConf(this IServiceCollection services)
        {
            services.AddSwaggerGen(c => {

                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "SmartRdo",
                        Version = "v1",
                        Description = "SmartRdo, gerencia de equipes",
                        Contact = new OpenApiContact
                        {
                            Name = "SmartRdo LTDA.",
                            Url = new Uri("https://github.com/daniel-rn")
                        }
                    });
            });
        }

        public static void UseSwaggerConf(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "SmartRdo, gerencia de equipes");
            });
        }
    }
}