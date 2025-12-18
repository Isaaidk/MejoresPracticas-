using Best_Practices.ModelBuilders;
using Best_Practices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Practices.Infraestructure.Factories
{
    /// <summary>
    /// Patrón: Factory Method (Concrete Creator)
    /// SOLID: SRP (responsabilidad única) + OCP (extensible sin modificar)
    /// 
    /// CAMBIO: Nueva factory para Ford Escape (requisito "Add new Escape model")
    /// POR QUÉ: OCP - agregar modelo como nueva clase, no modificar existentes
    /// </summary>
    public class FordEscapeCreator : Creator
    {
        public override Vehicle Create()
        {
            // CAMBIO: BuildEscape() específico para esta clase
            // POR QUÉ: Escape requiere constructor con parámetro fuelLimit
            var builder = new VehicleBuilder()
                .WithBrand("Ford")
                .WithModel("Escape")
                .WithColor("Red")
                .WithCurrentYear()
                .WithFuelLimit(50);
            
            return builder.BuildEscape();
        }
    }
}
