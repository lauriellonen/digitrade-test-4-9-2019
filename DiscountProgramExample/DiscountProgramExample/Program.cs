﻿using System;

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

            //Telling consumer to buy ticket
            Console.WriteLine("Hello, please proceed to buy your ticket. " + "Please note: one discount per user " + 
                "except if you are student and or a Mtk clubs member");
            //Informing them about prices
            Console.WriteLine("Prices / Adult price 16 euros. / Child under 7 free. / Children over 7 years 8 euros. / ");
            Console.WriteLine("Elderly people 65 or over 8 euros. / ");
            Console.WriteLine("Student price is 15% discount remember to show your studentcard for the cashier.");
            Console.WriteLine(" / Service Man price. / Mtk club member price. ");
            
            //Customer will have to input their age
            Console.Write("Please, input your age ");
            int userInputAge = int.Parse(Console.ReadLine());

            if(userInputAge == 0)
            {
                Console.Write("Charge normal price 16 euros");
            }
            if (userInputAge == 7)
            {
                Console.Write("You'll have a free pass to our show.");
            }
            




        }
    }
}
