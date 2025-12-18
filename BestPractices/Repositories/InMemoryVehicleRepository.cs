using Best_Practices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Practices.Repositories
{
    /// <summary>
    /// Patrón: Repository Pattern
    /// SOLID: DIP (Dependency Inversion) - abstrae persistencia
    ///        SRP - responsable solo de acceso a datos
    /// 
    /// CAMBIO: Repositorio en memoria reemplaza acceso a BD
    /// POR QUÉ: Cumple requisito "without database dependency"
    /// 
    /// Ventaja: Intercambiable con SQLVehicleRepository (solo cambiar ServicesConfiguration)
    /// </summary>
    public class InMemoryVehicleRepository : IVehicleRepository
    {
        // CAMBIO: Lista en memoria gestiona vehículos
        // POR QUÉ: DIP - cliente no conoce detalles de persistencia
        private List<Vehicle> _vehicles = new List<Vehicle>();

        public void AddVehicle(Vehicle vehicle)
        {
            // CAMBIO: Validación antes de agregar
            // POR QUÉ: Evita corrupción de datos con referencias null
            if (vehicle == null)
                throw new ArgumentNullException(nameof(vehicle));

            _vehicles.Add(vehicle);
        }

        public Vehicle Find(string id)
        {
            // CAMBIO: GUID validation + LINQ search
            // POR QUÉ: Validación defensiva de formato antes de buscar
            if (!Guid.TryParse(id, out var guid))
                return null;

            return _vehicles.FirstOrDefault(v => v.Id == id);
        }

        public List<Vehicle> GetVehicles()
        {
            // CAMBIO: Retorna lista desde repositorio
            // POR QUÉ: Repository abstrae la fuente (en memoria vs BD en futuro)
            return _vehicles;
        }
    }
}
