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
    /// SOLID: Single Responsibility Principle (SRP)
    ///        Open/Closed Principle (OCP)
    /// 
    /// Factory específica para la creación de Ford Mustang.
    /// Responsable de generar un Mustang con configuración por defecto.
    /// 
    /// Configuración por defecto del Mustang:
    /// - Marca: Ford
    /// - Modelo: Mustang
    /// - Color: Red
    /// </summary>
    public class FordMustangCreator : Creator
    {
        public override Vehicle Create()
        {
            // CAMBIO: VehicleBuilder nuevo (soporta WithCurrentYear)
            // POR QUÉ: Año automático + escalable para +20 propiedades futuras
            var builder = new VehicleBuilder()
                .WithBrand("Ford")
                .WithModel("Mustang")
                .WithColor("Red")
                .WithCurrentYear();
            
            return builder.Build();
        }
    }
}
