using GestionTareasRESTful.Domain.Repository;
using GestionTareasRESTful.Infraestructure.Data;
using GestionTareasRESTful.Infraestructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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
