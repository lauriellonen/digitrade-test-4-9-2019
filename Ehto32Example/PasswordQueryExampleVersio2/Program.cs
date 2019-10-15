using System;

namespace PasswordQueryExampleVersio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "key1234";
            Console.WriteLine("Password Query with For-Loop");

            for(int i = 0; i <3; i++)
            {
                Console.Write($"{i+1}. Input Password: ");
                string userInput = Console.ReadLine();

                if (userInput == password)
                {
                    Console.WriteLine("Password CORRECT!");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid PASSWORD! please try again.");
                }
            }

            Console.WriteLine("Account LOCKED");
        }
    }
}
