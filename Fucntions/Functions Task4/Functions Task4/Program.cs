using System;

namespace Functions_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma palauttaa syötetyistä luvuista suurimman luvun");
            string resultMessage = MaxNumberCalculator();
            Console.WriteLine($"Syötit seuraavat luvut:\n {resultMessage}");
        }
        static string MaxNumberCalculator()
        {
            int maxNumber=0;
            int sequenceOfNumber;
            string message = string.Empty;
            Console.WriteLine("Syötä 10 kokonaislukua");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}.");
                string userInput = Console.ReadLine();
                bool isnumber = int.TryParse(userInput, out int userValue);

                if (isnumber)
                {
                    message = $"{message}, {userValue}"; 
                    if (userValue > maxNumber)
                    {
                        maxNumber = userValue;
                        sequenceOfNumber = i + 1;
                    }
                }
                else
                {
                    Console.WriteLine("Väärä syöte, syötä luku:");
                    i--;        
                }
            }
            return message;
        }
    }
}
