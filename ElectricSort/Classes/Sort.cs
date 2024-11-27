using ElectricSort.Enums;

namespace ElectricSort.Classes
{
    /// <summary>
    /// Tömb műveletek rendezési osztálya. [Statikus osztály, ezért nincs szükség konstruktorra mert nem példányosítható]
    /// </summary>
    public static class Sort
    {
        /// <summary>
        /// A tömb rendezési metódusa szám esetén növekvő sorrendben.
        /// </summary>
        /// <param name="array">A rendezni kívánt tömb.</param>
        /// <param name="sortBy">A rendezési szempont.</param>
        /// <returns>A rendezett lista</returns>
        public static ElectricCar[] AscendingNumValue(ElectricCar[] array, SortBy sortBy)
        {
            for (var i = 0; i < array.Length; i++) // Buborékos rendezés
            {
                for (var j = 0; j < array.Length; j++)
                {
                    double elementAtI = 0; // Alap értékek
                    double elementAtJ = 0;
                    if (sortBy == SortBy.Id) // Id alapján rendezett
                    {
                        elementAtI = array[i].Id;
                        elementAtJ = array[j].Id;
                    }
                    if (sortBy == SortBy.ModelYear) // Évjárat alapján rendezett
                    {
                        elementAtI = array[i].ModelYear.Year;
                        elementAtJ = array[j].ModelYear.Year;
                    }
                    if (sortBy == SortBy.BatteryCapacity) // Akkumulátor mérete alapján rendezett
                    {
                        elementAtI = array[i].BatteryCapacity;
                        elementAtJ = array[j].BatteryCapacity;
                    }
                    if (sortBy == SortBy.RealRange) // Hatótáv alapján rendezett
                    {
                        elementAtI = array[i].RealRange;
                        elementAtJ = array[j].RealRange;
                    }

                    if (elementAtJ > elementAtI) // Növekvő sorrend
                    {
                        ElectricCar tempItem = array[j];
                        array[j] = array[i];
                        array[i] = tempItem;
                    }
                }
            }

            return array; // Visszatérő, rendezett lista
        }

        /// <summary>
        /// A tömb rendezési metódusa szám esetén csökkenő sorrendben.
        /// </summary>
        /// <param name="array">A rendezni kívánt tömb.</param>
        /// <param name="sortBy">A rendezési szempont.</param>
        /// <returns>A rendezett lista</returns>
        public static ElectricCar[] DescendingNumValue(ElectricCar[] array, SortBy sortBy)
        {
            for (var i = 0; i < array.Length; i++) // Buborék rendezés
            {
                for (var j = 0; j < array.Length; j++)
                {
                    double elementAtI = 0; // Alap értékek
                    double elementAtJ = 0;
                    if (sortBy == SortBy.Id) // Id alapján rendezett
                    {
                        elementAtI = array[i].Id;
                        elementAtJ = array[j].Id;
                    }
                    if (sortBy == SortBy.ModelYear) // Évjárat alapján rendezett
                    {
                        elementAtI = array[i].ModelYear.Year;
                        elementAtJ = array[j].ModelYear.Year;
                    }
                    if (sortBy == SortBy.BatteryCapacity) // Akkumulátor mérete alapján rendezett
                    {
                        elementAtI = array[i].BatteryCapacity;
                        elementAtJ = array[j].BatteryCapacity;
                    }
                    if (sortBy == SortBy.RealRange) // Hatótáv alapján rendezett
                    {
                        elementAtI = array[i].RealRange;
                        elementAtJ = array[j].RealRange;
                    }

                    if (elementAtJ < elementAtI) // Csökkenő sorrend
                    {
                        ElectricCar tempItem = array[j];
                        array[j] = array[i];
                        array[i] = tempItem;
                    }
                }
            }

            return array; // Visszatérő, rendezett lista
        }

        /// <summary>
        /// A tömb rendezési metódusa szöveg esetén növekvő sorrendben.
        /// </summary>
        /// <param name="array">A rendezni kívánt tömb.</param>
        /// <returns>A rendezett lista</returns>
        public static ElectricCar[] AscendingTxtValue(ElectricCar[] array)
        {
            for (var i = 0; i < array.Length; i++) // Buborékos rendezés
            {
                for (var j = 0; j < array.Length; j++)
                {
                    string elementAtI = $"{array[i].Make} {array[i].Model}"; // Nincs szükség az if statementekre, hiszen a Make és a Model az összes szöveges property.
                    string elementAtJ = $"{array[j].Make} {array[j].Model}";

                    if (string.Compare(elementAtJ, elementAtI, StringComparison.OrdinalIgnoreCase) > 0) // Növekvő sorrend
                    {
                        ElectricCar tempItem = array[j];
                        array[j] = array[i];
                        array[i] = tempItem;
                    }
                }
            }

            return array; // Visszatérő, rendezett lista
        }

        /// <summary>
        /// A tömb rendezési metódusa szöveg esetén csökkenő sorrendben.
        /// </summary>
        /// <param name="array">A rendezni kívánt tömb.</param>
        /// <returns>A rendezett lista</returns>
        public static ElectricCar[] DescendingTxtValue(ElectricCar[] array)
        {
            for (var i = 0; i < array.Length; i++) // Buborékos rendezés
            {
                for (var j = 0; j < array.Length; j++)
                {
                    string elementAtI = $"{array[i].Make} {array[i].Model}"; // Nincs szükség az if statementekre, hiszen a Make és a Model az összes szöveges property.
                    string elementAtJ = $"{array[j].Make} {array[j].Model}";

                    if (string.Compare(elementAtJ, elementAtI, StringComparison.OrdinalIgnoreCase) < 0) // Csökkenő sorrend
                    {
                        ElectricCar tempItem = array[j];
                        array[j] = array[i];
                        array[i] = tempItem;
                    }
                }
            }

            return array; // Visszatérő, rendezett lista
        }

        /// <summary>
        /// A tömb feltöltése alap adattal.
        /// </summary>
        /// <returns>Egy alap tömböt.</returns>
        public static ElectricCar[] InitializeArray()
        {
            ElectricCar[] array =
            {
                new ElectricCar(1, "Tesla", "Model 3", new DateOnly(2023, 01, 01), 75.0, 525),
                new ElectricCar(2, "BYD", "Seal", new DateOnly(2023, 01, 01), 82.5, 445),
                new ElectricCar(3, "BMW", "i4", new DateOnly(2024, 01, 01), 81.3, 515),
                new ElectricCar(4, "Renault", "Zoe", new DateOnly(2019, 01, 01), 52.0, 315),
                new ElectricCar(5, "Volkswagen", "ID.3", new DateOnly(2021, 01, 01), 58.0, 350)
            };

            return array;
        }
    }
}
