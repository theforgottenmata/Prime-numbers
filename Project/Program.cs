using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vítejte v programu Rozklad čísla na prvočinitele ");

            Console.WriteLine("\n-------------------------------------------------\n");

            bool validation = false;
            int number, devider, count = 0, randomNumber;

            Console.WriteLine("Zadejte číslo větší jak 1, jelikož 1 není prvočíslo");


            var rand = new Random();

            randomNumber = rand.Next(1, 101);


            while (validation == false)
            {

                string userInput = Console.ReadLine(); // Čeká se na vstup uživatele

                bool succes = Int32.TryParse(userInput, out number); // 
                


                if (succes && number > 0 && number != 1){  // Ošetření vstupu

                    validation = true;

                    int inputNumber = Int32.Parse(userInput); // Input (string) od uživatele převeden na číslo (number

                    Console.WriteLine($"\nZadali jste číslo {userInput}");

                    Console.WriteLine("Číslo: " + userInput + " rozdělíme na prvočísla následovně: ");

                    for (devider = 2; inputNumber > 1; devider++)  // for cyklus, který se opakuje dokud je číslo od uživatele vyšší jak 1, pokud ho vydělím tolikrát, že je 0, for cycle se ukončí
                        if (inputNumber % devider == 0) // jestliže zadané číslo dělené dělitelem nemá zbytek po dělení tak se podmínka provede
                        {

                            while (inputNumber % devider == 0) // dokud je zbytek po dělení 0
                            {
                                Console.WriteLine($"{inputNumber} / {devider} = {inputNumber / devider}");

                                inputNumber /= devider;
                                count++;

                            }



                            /*while (count > 0) // dokud je count vyšší jak 0 ( 1, 2, 3, apod...)
                            {
                                Console.WriteLine($"{devider}*");
                                count--;
                            }
                            */

                        }

                    Console.Write("\b");  // Odstranění posledního znaku výsledku
                }
                else // Pokud uživatel nezadá žádaný input, program vypíše zprávu, aby uživatel zadal číslo vyšší jak 1
                {
                    Console.WriteLine("Zadaná hodnota není správná");
                }
            }
        }
    }
}
