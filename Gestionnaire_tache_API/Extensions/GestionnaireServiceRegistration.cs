﻿using Gestionnaire_tache_API.Data;
using Gestionnaire_tache_API.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Gestionnaire_tache_API.Extensions
{
    public static class GestionnaireServiceRegistration
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GestionnaireDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("GestionnaireConnectionString"));
            });

            services.AddIdentity<ApplicationUser, IdentityRole>()
               .AddEntityFrameworkStores<GestionnaireDbContext>()
               .AddDefaultTokenProviders();

            return services;    
        }
    }
}
