using GestionTareasRESTful.Domain.Repository;
using GestionTareasRESTful.Infraestructure.Data;
using GestionTareasRESTful.Infraestructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GestionTareasRESTful.Infraestructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices
            ( this IServiceCollection services, IConfiguration configuration ) 
        {
            services.AddDbContext<TareaDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("TareaDbContext") ??
                    throw new InvalidOperationException("Connection string 'TareaDbContext not found '"))
                );

            services.AddTransient<ITareaRepository, TareaRepository>();
            return services;
        }
        
    }
}
