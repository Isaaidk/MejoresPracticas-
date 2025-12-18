using Best_Practices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Practices.Infraestructure.Factories
{
    /// <summary>
    /// Patrón: Factory Method (Abstract Creator)
    /// SOLID PRINCIPLES:
    ///   - SRP: Una razón para cambiar = crear vehículos específicos
    ///   - OCP: Abierto para extender (nuevas factories), cerrado para modificar
    ///   - LSP: Todas las factories son substituibles por su interfaz
    ///   - ISP: Interfaz específica y mínima para creadores
    ///   - DIP: Cliente depende de Creator (abstracción), no de concretas
    /// 
    /// CAMBIO: Factory Method elimina lógica condicional (if/switch) en cliente
    /// POR QUÉ: OCP - nuevo modelo = nueva clase Creator (cero cambios a existentes)
    /// </summary>
    public abstract class Creator
    {
       // CAMBIO: Método abstracto que implementan concretas
       // POR QUÉ: Define contrato para creación polimórfica (DIP)
       public abstract Vehicle Create();
    }
}
