using System;

namespace DiscountProgramExample
    /*
     * This program is counting ticket discount for the users 
     * Versio 1.0 made by Lauri Ellonen 
    */

{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, please proceed to buy your ticket. " + "Please note: one discount per user " + 
                "except if you are student and or a Mtk clubs member");
            int ticketPrice = 16;

            //Customer will have to input their age
            Console.Write("Please, input your age ");
            int userInputAge = int.Parse(Console.ReadLine());
            
            if (userInputAge <= 7)
            {
                Console.WriteLine("Ticket is free");
            }
            else if (userInputAge > 8 && userInputAge < 15)
            {
                Console.WriteLine($"Ticket price is {ticketPrice*0.5}");
            }
            if (userInputAge >= 16)
            {
                Console.WriteLine($"No dicount. The ticket price is {ticketPrice}");
            }
            else if (userInputAge > 65 && userInputAge< 70 )
            {
                Console.WriteLine($"Ticket price is {ticketPrice*0.5}");
            }
        }
    }
}
