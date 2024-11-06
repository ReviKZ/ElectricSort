using ElectricSort.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricSort.Classes
{
    /// <summary>
    /// Az elektromos autó osztály, ami az interfésztől örököl.
    /// </summary>
    public class ElectricCar : IElectricCar
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <inheritdoc/>
        public string Make { get; set; }

        /// <inheritdoc/>
        public string Model { get; set; }

        /// <inheritdoc/>
        public DateOnly ModelYear { get; set; }

        /// <inheritdoc/>
        public double BatteryCapacity { get; set; }

        /// <inheritdoc/>
        public double RealRange { get; set; }

        /// <summary>
        /// Az elektromos autó osztály konstruktorja, ami létrehozza az osztályt, az ő alap értékeivel.
        /// </summary>
        /// <param name="id">Azonosító.</param>
        /// <param name="make">Márka.</param>
        /// <param name="model">Modell.</param>
        /// <param name="modelYear">Évjárat.</param>
        /// <param name="batteryCapacity">Akkumulátor kapacitás.</param>
        /// <param name="realRange">Hatótáv.</param>
        public ElectricCar(int id, string make, string model, DateOnly modelYear, double batteryCapacity, double realRange)
        {
            this.Id = id;
            this.Make = make;
            this.Model = model;
            this.ModelYear = modelYear;
            this.BatteryCapacity = batteryCapacity;
            this.RealRange = realRange;
        }

        /// <summary>
        /// Az osztály szöveges reprezentációjának felülírt metódusa.
        /// </summary>
        /// <returns>Az osztály szövegesített formátuma.</returns>
        public override string ToString()
        {
            return
                $"""
                Id: {Id}  |  Márka: {Make}  |  Modell: {Model}
                Évjárat: {ModelYear.Year}  |  Akkumulátor: {BatteryCapacity} kWh  |  Hatótáv: {RealRange} km
                """ + "\n";
        }
    }
}
