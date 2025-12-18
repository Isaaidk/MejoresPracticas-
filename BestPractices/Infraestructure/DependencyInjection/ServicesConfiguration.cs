using Best_Practices.Controllers;
using Best_Practices.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Practices.Infraestructure.DependencyInjection
{
    public class ServicesConfiguration
    {
        // CAMBIO: DIP - Dependency Injection Configuration
        // POR QUÉ: Centraliza inyección de dependencias (SRP + DIP)
        public void ConfigureServices(IServiceCollection services)
        {
            // CAMBIO: InMemoryVehicleRepository reemplaza MyVehiclesRepository
            // POR QUÉ: Cumple requisito "without database dependency"
            // NOTA: Para cambiar a BD en futuro, usar: services.AddTransient<IVehicleRepository, SQLVehicleRepository>();
            // VENTAJA: DIP hace el cambio trivial (solo cambiar esta línea)
            services.AddTransient<IVehicleRepository, InMemoryVehicleRepository>();
        }
    }
}
