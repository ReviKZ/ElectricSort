namespace ElectricSort.Classes
{
    /// <summary>
    /// Tömb műveletek osztálya amely valamilyen szempont alapján kiválaszt egy autót. [Statikus osztály, ezért nincs szükség konstruktorra mert nem példányosítható]
    /// </summary>
    public static class Select
    {
        /// <summary>
        /// A tömb legnagyobb eleme akkumulátor kapacitás alapján. 
        /// </summary>
        /// <param name="array">A tömb amiből választjuk a legnagyobbat.</param>
        /// <returns>A rendezett lista</returns>
        public static ElectricCar MaxByCapacity(ElectricCar[] array)
        {
            ElectricCar? max = array[0]; // Kezdőérték a 0. indexen

            for (var i = 1; i < array.Length; i++) // Mivel a 0. indexű elemmel kezdünk, az kihagyható az összehasonlításból
            {
                if (array[i].BatteryCapacity > max.BatteryCapacity) // Ha az akksi kapacitás nagyobb a vizsgáltnak
                {
                    max = array[i]; // Beállítás új értékként.
                }
            }

            return max;
        }

        /// <summary>
        /// A tömb legnagyobb eleme hatótáv alapján. 
        /// </summary>
        /// <param name="array">A tömb amiből választjuk a legnagyobbat.</param>
        /// <returns>A rendezett lista</returns>
        public static ElectricCar MaxByRange(ElectricCar[] array)
        {
            ElectricCar? max = array[0]; // Kezdőérték a 0. indexen

            for (var i = 1; i < array.Length; i++) // Mivel a 0. indexű elemmel kezdünk, az kihagyható az összehasonlításból
            {
                if (array[i].RealRange > max.RealRange) // Ha a hatótáv alapján nagyobb a vizsgáltnak
                {
                    max = array[i]; // Beállítás új értékként.
                }
            }

            return max;
        }

        /// <summary>
        /// A tömb legnagyobb eleme hatótáv alapján. 
        /// </summary>
        /// <param name="array">A tömb amiből választjuk a legnagyobbat.</param>
        /// <returns>A rendezett lista</returns>
        public static decimal AverageAgeOfCars(ElectricCar[] array)
        {
            decimal sumOfAge = 0; // Az autók életkorának összege
            DateTime today = DateTime.Today; // Veszi a mai dátumot

            for (var i = 0; i < array.Length; i++)
            {
                decimal age = today.Year - array[i].ModelYear.Year; // Kivonja a mai dátumból az autó évjáratát, hogy megapja a korát
                sumOfAge += age; // Hozzáadja az össz életkorhoz.
            }

            decimal avgAge = sumOfAge / array.Length; // Az össz életkort elosztja a tömb elemeinek számával, hogy megkapja az átlagéletkort.

            return avgAge;
        }
    }
}
