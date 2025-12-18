using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Practices.Models
{
    /// <summary>
    /// Modelo: Ford Escape
    /// SOLID: LSP (Liskov Substitution) - Escape es un Vehicle válido
    ///        OCP - extensión sin modificar Vehicle base
    /// 
    /// CAMBIO: Nueva clase Escape (requisito "Add new Escape model")
    /// POR QUÉ: OCP - nuevo modelo como especialización, no modifica base
    /// </summary>
    public class Escape : Vehicle
    {
        // CAMBIO: Constructor con parámetro fuelLimit
        // POR QUÉ: Escape personaliza combustible (50 galones vs default 60)
        public Escape(int fuelLimit)
        {
            FuelLimit = fuelLimit;
        }

        public override int Tires 
        { 
            // CAMBIO: Escape tiene 4 neumáticos (especificación modelo)
            // POR QUÉ: LSP - cada vehículo puede tener propiedades específicas
            get => 4; 
        }
    }
}
