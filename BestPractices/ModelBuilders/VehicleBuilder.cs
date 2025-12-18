using System;
using Best_Practices.Models;

namespace Best_Practices.ModelBuilders
{
    /// <summary>
    /// Patrón: Builder Pattern (Fluent Builder)
    /// SOLID: SRP (construcción desacoplada) + OCP (fácil agregar propiedades)
    /// 
    /// Constructor flexible que proporciona interfaz fluida para vehículos.
    /// Diseñado para escalar con +20 propiedades adicionales sin modificar existentes.
    /// </summary>
    public class VehicleBuilder
    {
        private string _brand;
        private string _model;
        private string _color;
        private int _year = DateTime.Now.Year;
        private int _fuelLimit = 60;

        // CAMBIO: Interfaz fluida (retorna this)
        // POR QUÉ: Permite encadenamiento de métodos (patrón Builder)
        public VehicleBuilder WithBrand(string brand)
        {
            _brand = brand;
            return this;
        }

        public VehicleBuilder WithModel(string model)
        {
            _model = model;
            return this;
        }

        public VehicleBuilder WithColor(string color)
        {
            _color = color;
            return this;
        }

        public VehicleBuilder WithFuelLimit(int fuelLimit)
        {
            _fuelLimit = fuelLimit;
            return this;
        }

        /// <summary>
        /// CAMBIO: Nuevo método WithCurrentYear()
        /// POR QUÉ: Asigna automáticamente año actual (requisito "current year + 20 future")
        /// </summary>
        public VehicleBuilder WithCurrentYear()
        {
            _year = DateTime.Now.Year;
            return this;
        }

        public Car Build()
        {
            // CAMBIO: Constructor con object initializer
            // POR QUÉ: Separación clara entre construir y configurar (SRP)
            return new Car
            {
                Id = Guid.NewGuid().ToString(),
                Brand = _brand,
                Model = _model,
                Color = _color,
                Year = _year,
                FuelLimit = _fuelLimit
            };
        }

        /// <summary>
        /// CAMBIO: Nuevo método BuildEscape()
        /// POR QUÉ: Escape requiere constructor con parámetro fuelLimit (DIP)
        /// </summary>
        public Escape BuildEscape()
        {
            // CAMBIO: Parámetro específico para Escape
            // POR QUÉ: Escape define combustible en constructor (requisito modelo)
            return new Escape(_fuelLimit)
            {
                Id = Guid.NewGuid().ToString(),
                Brand = _brand,
                Model = _model,
                Color = _color,
                Year = _year
            };
        }
    }
}
