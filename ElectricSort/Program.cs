using ElectricSort.Classes;
using ElectricSort.Enums;

bool running = true; // A program futásának reprezentációja.
string? message = null; // Egy üzenet, ami opcionálisan megjelenhet.
ElectricCar[] electricCars = Sort.InitializeArray(); // Az elektromos autók tömbjének feltöltése.

while (running) // Végtelen ciklus, amíg a program fut.
{
    Console.Clear();
    Console.WriteLine
        ($"""
            Kérem válasszon az alábbi menüpontok közül:
            [1] - Autók listázása a legutóbbi rendezés sorrendjében
            [2] - Autók rendezése szempont alapján
            [3] - A lista alaphelyzetbe állítása
            [4] - A legnagyobb értékkel rendelkező autó kiválasztása egy szempont alapján.
            [5] - A tömbben szereplő autók átlagéletkora.
            [9] - Kilépés 

            {message ?? "" /* Ha nincs hibaüzenet akkor üres */} 
        """); // Főmenü

    Console.Write("> ");
    string? menuItem = Console.ReadLine(); // Input

    if (!int.TryParse(menuItem, out int selection)) // Ha nem számot írtunk, hibaüzenet
    {
        message = "Kérem írjon be egy számot!";
        continue;
    }
    else
    {
        if (selection == 9) // Ha 9-es, kilép
        {
            Console.Clear();
            Console.WriteLine("A legközelebbi viszont látásra!");
            running = false;
            break;
        }
        else if (selection == 1) // Ha 1-es, listázza az autókat.
        {
            Console.Clear();
            for (int i = 0; i < electricCars.Length; i++)
            {
                Console.WriteLine
                    ($"""
                    {i + 1}. :
                    {electricCars[i].ToString()}
                    """);
            }
            Console.WriteLine();
            Console.WriteLine("Ha vissza akar menni a menübe, kérem nyomjon egy ENTER-t!");
            Console.ReadLine();
        }
        else if (selection == 2) // Ha 2-es, almenü.
        {
            string? errorMessage = null;
            int[] options = { 0, 0 }; // Az almenükben választott kombó.

            while (options[0] == 0) // Egyes almenü
            {
                Console.Clear();
                Console.WriteLine
                ($"""
                Kérem válasszon milyen szempont alapján kíván rendezni:
                [1] - Rendezés Id szerint
                [2] - Rendezés név szerint
                [3] - Rendezés évjárat szerint
                [4] - Rendezés akku mérete szerint
                [5] - Rendezés hatótáv szerint

                {errorMessage ?? "" /* Ha nincs hibaüzenet akkor üres */}
                """);
                Console.Write("> ");
                string? inputOne = Console.ReadLine();
                if (!int.TryParse(inputOne, out int optionOne)) // Ha nem számot írtunk, hibaüzenet
                {
                    errorMessage = "Kérem írjon be egy számot!";
                    continue;
                }
                else if (optionOne < 1 || optionOne > 4)
                {
                    errorMessage = "Kérem a listából válasszon!";
                    continue;
                }
                else
                {
                    errorMessage = null;
                    options[0] = optionOne;
                    break;
                }

            }

            while (options[1] == 0) // Kettes almenü
            {
                Console.Clear();
                Console.WriteLine
                ($"""
                Kérem válasszon sorrendet:
                [1] - Növekvő sorrend
                [2] - Csökkenő sorrend

                {errorMessage ?? "" /* Ha nincs hibaüzenet akkor üres */}
                """);
                Console.Write("> ");
                string? inputTwo = Console.ReadLine(); // Kéri az inputot
                if (!int.TryParse(inputTwo, out int optionTwo)) // Ha nem számot írtunk, hibaüzenet
                {
                    errorMessage = "Kérem írjon be egy számot!";
                    continue;
                }
                else if (optionTwo < 1 || optionTwo > 2) // Ha nem a listából választunk, hibaüzenet
                {
                    errorMessage = "Kérem a listából válasszon!";
                    continue;
                }
                else // Egyébként megyünk tovább hibaüzenet nélkül
                {
                    errorMessage = null;
                    options[1] = optionTwo;
                    break;
                }
            }

            if (options[0] == 2) // Ha névszerinti rendezés van
            {
                if (options[1] == 1) // Ha növekvő listát szeretnénk
                {
                    Sort.AscendingTxtValue(electricCars);
                    message = "A lista rendezve lett!";
                    continue;
                }
                if (options[1] == 2) // Ha csökkenő listát szeretnénk
                {
                    Sort.DescendingTxtValue(electricCars);
                    message = "A lista rendezve lett!";
                    continue;
                }
            }
            else // Ha érték szerinti rendezés van.
            {
                if (options[1] == 1) // Ha növekvő listát szeretnénk
                {
                    Sort.AscendingNumValue(electricCars, (SortBy)options[0]);
                    message = "A lista rendezve lett!";
                    continue;
                }
                if (options[1] == 2) // Ha csökkenő listát szeretnénk
                {
                    Sort.DescendingNumValue(electricCars, (SortBy)options[0]);
                    message = "A lista rendezve lett!";
                    continue;
                }
            }
        }
        else if (selection == 3) // Ha 3-as, újra írja a listát.
        {
            electricCars = Sort.InitializeArray();
            message = "A lista alaphelyzetbe állítva!";
            continue;
        }
        else if (selection == 4) // Ha 4-es, almenü
        {
            string? errorMessage = null; // Opcionális hibaüzenet.
            int? option = null;

            while (option == null) // Amíg nincs választott érték.
            {
                Console.Clear();
                Console.WriteLine
                    ($"""
                        Kérem válasszon melyik szempont alapján kívánja megtalálni a legnagyobb elemet:
                        [1] - Akkumulátor kapacitás alapján
                        [2] - Hatótáv alapján

                        {errorMessage ?? "" /* Ha nincs hibaüzenet akkor üres */} 
                    """);

                Console.Write("> ");
                string? optionString = Console.ReadLine(); // Kéri az inputot
                if (!int.TryParse(optionString, out int selectedOption)) // Ha nem számot írtunk, hibaüzenet
                {
                    errorMessage = "Kérem írjon be egy számot!";
                    continue;
                }
                else if (selectedOption < 1 || selectedOption > 2) // Ha nem a listából választunk, hibaüzenet
                {
                    errorMessage = "Kérem a listából válasszon!";
                    continue;
                }
                else // Egyébként megyünk tovább hibaüzenet nélkül
                {
                    errorMessage = null;
                    option = selectedOption;
                    break;
                }
            }

            if (option == 1) // Ha az első opció
            {
                string? goBack = null;
                while (goBack == null) // Amíg nincs visszatérési érték
                {
                    Console.Clear();
                    ElectricCar car = Select.MaxByCapacity(electricCars); // Megfelelő metódus meghívása.
                    Console.WriteLine($"""
                    A legnagyobb akkumulátorkapacitással rendelkező autó:
                    {car.ToString()}
                    """);
                    Console.WriteLine();
                    Console.WriteLine("Ha vissza akar menni a menübe, kérem nyomjon egy ENTER-t!");
                    goBack = Console.ReadLine(); // Várja az inputot
                }
            }

            if (option == 2) // Ha a második opció
            {
                string? goBack = null;
                while (goBack == null) // Amíg nincs visszatérési érték
                {
                    Console.Clear();
                    ElectricCar car = Select.MaxByRange(electricCars); // Megfelelő metódus meghívása.
                    Console.WriteLine($"""
                    A legnagyobb hatótávval rendelkező autó:
                    {car.ToString()}
                    """);
                    Console.WriteLine();
                    Console.WriteLine("Ha vissza akar menni a menübe, kérem nyomjon egy ENTER-t!");
                    goBack = Console.ReadLine();
                }
            }
        }
        else if (selection == 5) // Ha az ötös
        {
            Console.Clear();
            decimal avgAge = Select.AverageAgeOfCars(electricCars); // Megfelelő metódus meghívása.
            Console.WriteLine($"""
                    A tömbben szereplő autók átlagéletkora:
                    {avgAge}
                    """);
            Console.WriteLine();
            Console.WriteLine("Ha vissza akar menni a menübe, kérem nyomjon egy ENTER-t!");
            Console.ReadLine();
        }
        else // Ha más szám, hibaüzenet
        {
            message = "Kérem a listából válasszon!";
            continue;
        }
    }
}
