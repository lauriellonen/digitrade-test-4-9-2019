using System;

namespace PasswordQueryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "qwerty1234";
            int attemptCounter = 0;

            Console.WriteLine("Input Password");
            string userInpunt = Console.ReadLine();

            while (userInpunt != password)
            {
                attemptCounter++;
                if (attemptCounter >= 3)
                {
                    Console.WriteLine("Account is LOCKED!");
                    return;
                }

                Console.WriteLine("Wrong Password! Please try again.");
                userInpunt = Console.ReadLine();
            }

            Console.WriteLine("Password correct! ");

        }
    }
}
