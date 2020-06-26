﻿using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using SmartRdo.API.Data;
using SmartRdo.API.Extensions;

namespace SmartRdo.API.Configurations
{
    public static class IdentityConfig
    {
        // pensar no problema de autenticacao para api e mvc
        public static IServiceCollection AddIdentityConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApiDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("MyWebMvcConnection")));

            services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApiDbContext>()
                .AddDefaultTokenProviders();

            //services.AddDefaultIdentity<IdentityUser>()
            //    .AddRoles<IdentityRole>()
            //    .AddEntityFrameworkStores<ApiDbContext>()
            //    //.AddErrorDescriber<IdentityMensagensPortugues>()
            //    .AddDefaultTokenProviders();

            var appSettingsSection = configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = true;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = appSettings.ValidoEm,
                    ValidIssuer = appSettings.Emissor
                };
            });

            return services;
        }
    }
}
