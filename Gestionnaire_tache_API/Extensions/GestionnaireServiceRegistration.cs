using Gestionnaire_tache_API.Data;
using Gestionnaire_tache_API.Model;
using Gestionnaire_tache_API.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

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

            services.AddTransient<IColumnService, ColumnService>(); 
            services.AddTransient<ITacheService, TacheService>();

            // Auto Mapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;    
        }
    }
}
