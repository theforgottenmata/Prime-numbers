using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vítejte v programu Rozklad čísla na prvočinitele "); // výpis do konzole
            Console.WriteLine("\n-------------------------------------------------\n"); // výpis do konzole

            bool choiceValidation = false, inputNumberValidation = false; //deklarace proměnných bool
            int number, devider, count = 0, randomNumber; //deklarace celočíselných proměnných
            var rand = new Random();

            Console.WriteLine("Zvolte si variantu"); // výpis do konzole

            while (choiceValidation == false) // bude se opakovat dokud vstup uživatele nebudu 1,2 potom se proměnná choiceValidation změní na true a program bude pokračovat
            {

                Console.WriteLine("1) Vygenerování čísla 1-100"); // výpis do konzole 
                Console.WriteLine("2) Zadání svého čísla"); // výpis do konzole

                string choice = Console.ReadLine(); // Čeká se na vstup uživatele

                if (choice == "1" || choice == "2") // ošetření aby uživatel zadal 1,2; 
                {
                    choiceValidation = true; // změna proměnné choiceValidation na true

                    switch (choice) // switch - využití na dva vstupy, pokud uživatel zada 1, zapne se část case "1" |  pokud uživatel zadá 2, zapne se část case "2"
                    {
                        case "1": // po stisknutí 1 se spustí část programu case "1"

                            Console.WriteLine("\n-------------------------------------------------\n"); // výpis do konzole

                            randomNumber = rand.Next(1, 101); // generování náhodného čísla

                            Console.WriteLine($"Bylo vygenerováno číslo {randomNumber}"); // výpis do konzole

                            for (devider = 2; randomNumber > 1; devider++)  // for cyklus, který se opakuje dokud je číslo od uživatele vyšší jak 1, pokud ho vydělím tolikrát, že je 0, for cycle se ukončí
                                if (randomNumber % devider == 0) // jestliže zadané číslo dělené dělitelem nemá zbytek po dělení tak se podmínka provede
                                {

                                    while (randomNumber % devider == 0) // dokud je zbytek po dělení 0
                                    {
                                        Console.WriteLine($"{randomNumber} / {devider} = {randomNumber / devider}"); // výpis do konzole

                                        randomNumber /= devider;  // randomNumber = randomNumber / devider
                                        count++; // k proměnné se přičte +1

                                    }

                                }

                            Console.Write("\b"); // Odstranění posledního znaku výsledku

                            break; // ukončení case "1"

                        case "2":// po stisknutí 2 se spustí část programu case "2"
                            Console.WriteLine("Zadejte číslo větší jak 1, jelikož 1 není prvočíslo"); // výpis do konzole


                            while (inputNumberValidation == false) // bude se opakovat dokud vstup uživatele > 1 potom se proměnná inputNumberValidation změní na true a program bude pokračovat
                            {

                                string userInput = Console.ReadLine(); // Čeká se na vstup uživatele

                                bool succes = Int32.TryParse(userInput, out number); // pokus o převedení vstupu na číslo, tato proměnná je deklarována jako bool (true/false)



                                if (succes && number > 1) // oštření vstupu (jestli succes == true, number je větší jak 1
                                {  

                                    Console.WriteLine("\n-------------------------------------------------\n"); // výpis do konzole

                                    inputNumberValidation = true; // změna proměnné inputNumberValidation na true

                                    int inputNumber = Int32.Parse(userInput); // Input (string) od uživatele převeden na číslo (number)

                                    Console.WriteLine($"\nZadali jste číslo {userInput}"); // výpis do konzole

                                    Console.WriteLine("Číslo: " + userInput + " rozdělíme na prvočísla následovně: "); // výpis do konzole

                                    for (devider = 2; inputNumber > 1; devider++)  // for cyklus, který se opakuje dokud je číslo od uživatele vyšší jak 1, pokud ho vydělím tolikrát, že je 0, for cycle se ukončí
                                        if (inputNumber % devider == 0) // jestliže zadané číslo dělené dělitelem nemá zbytek po dělení tak se podmínka provede
                                        {

                                            while (inputNumber % devider == 0) // dokud je zbytek po dělení 0
                                            {
                                                Console.WriteLine($"{inputNumber} / {devider} = {inputNumber / devider}"); // výpis do konzole

                                                inputNumber /= devider; // inputNumber = inputNumber / devider
                                                count++; // k proměnné se přičte +1
                                            }

                                        }

                                    Console.Write("\b");  // Odstranění posledního znaku výsledku
                                }
                                else // Pokud uživatel nezadá žádaný input, program vypíše zprávu, aby uživatel zadal číslo vyšší jak 1
                                {
                                    Console.WriteLine("Zadaná hodnota není správná"); // výpis do konzole
                                }
                            }
                            break;
                    }
                }
            }
        }
    }
}
