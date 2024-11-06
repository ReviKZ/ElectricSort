using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricSort.Interfaces
{
    /// <summary>
    /// Az elektromos autó osztály interfésze.
    /// </summary>
    public interface IElectricCar
    {
        /// <summary>
        /// Egy azonosító szám, ami automatikusan generálódik a létrehozásnál.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// A márka neve.
        /// </summary>
        public string Make { get; set; }

        /// <summary>
        /// A modell neve.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Az évjárat.
        /// </summary>
        public DateOnly ModelYear { get; set; }

        /// <summary>
        /// Az akkumulátor kapacitása kWh-ban.
        /// </summary>
        public double BatteryCapacity { get; set; }

        /// <summary>
        /// Az autó valós hatótávja km-ben.
        /// </summary>
        public double RealRange { get; set; }
    }
}
