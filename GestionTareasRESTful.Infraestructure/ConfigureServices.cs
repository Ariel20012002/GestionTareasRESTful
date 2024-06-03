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
            return services;
        }
        
    }
}
