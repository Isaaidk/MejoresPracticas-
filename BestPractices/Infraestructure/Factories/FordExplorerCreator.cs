using Best_Practices.ModelBuilders;
using Best_Practices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Practices.Infraestructure.Factories
{
    public class FordExplorerCreator : Creator
    {
        public override Vehicle Create()
        {
            // CAMBIO: VehicleBuilder nuevo reemplaza CarBuilder
            // POR QUÉ: WithCurrentYear() + escalable para propiedades adicionales
            var builder = new VehicleBuilder()
                .WithBrand("Ford")
                .WithModel("Explorer")
                .WithColor("Black")
                .WithCurrentYear();
            
            return builder.Build();
        }
    }
}
