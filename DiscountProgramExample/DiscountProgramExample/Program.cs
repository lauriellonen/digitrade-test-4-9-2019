using System;

namespace DiscountProgramExample
/*
 * This program is counting ticket discount for the users 
 * Versio 1.1.3 made by Lauri Ellonen 
*/

{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, please proceed to buy your ticket. " + "Please note: one discount per user " +
                "except if you are student and or a Mtk clubmember");

            int ticketPrice = 25;
            double studentDiscount = ticketPrice * 0.45;
            double mtkClubDiscount = ticketPrice * 0.15;
            double mtkStdentClubDiscount = ticketPrice * 0.15 + studentDiscount;
            double serviceManDiscount = ticketPrice * 0.5;
            double serviceManPlusStudentD = ticketPrice * 0.45 + serviceManDiscount;
            /*
             * Customer will have to input their age.
             * And also the customers that are eligible for the discounted prices
             * have been parametered. 
            */
            Console.Write("Please, input your age ");
            int userInputAge = int.Parse(Console.ReadLine());
            String isStudent;
            String isMtkClubMember;
            String isServiceMan;
            //String isSomeonePayingTicket;

            if (userInputAge <= 7)
            {
                Console.WriteLine("Your ticket price is free.");
            }
            else if (userInputAge >= 8 && userInputAge <= 15)
            {
                Console.WriteLine($"Ticket price is {ticketPrice * 0.5} euros");
            }
            if (userInputAge >= 18 && userInputAge <= 27)
            {
                //Asking if the customer is in the service.
                Console.Write("Are you in the service? y/n: ");
                isServiceMan = Console.ReadLine();
                if (isServiceMan == "y")
                {
                    Console.WriteLine($"Your ticket price is {ticketPrice - serviceManDiscount} euros");
                }
                else if (isServiceMan == "n")
                {
                    Console.WriteLine($"Your ticket price is {ticketPrice} euros");
                }
            }
            if (userInputAge >= 16 && userInputAge <= 59)
            {
                //Asking a customer if they are student.
                Console.Write("Are you a student? y/n: ");
                isStudent = Console.ReadLine();
                if (isStudent == "y")
                {
                    //Asking customer if they are a Mtk clubmember.
                    Console.Write("Are you maybe a Mtk clubmemember? y/n: ");
                    isMtkClubMember = Console.ReadLine();
                    if (isMtkClubMember == "y")
                    {
                        Console.WriteLine($"Mtk ClubMember ticket price is {ticketPrice - mtkStdentClubDiscount} euros");
                    }
                    else
                    {
                        Console.WriteLine($"Your ticket price is {ticketPrice - studentDiscount} euros");
                    }
                }
                else
                {
                    //Asking customer if they are a Mtk clubmember.
                    Console.Write("Are you maybe a Mtk clubmemember? y/n: ");
                    isMtkClubMember = Console.ReadLine();
                    if (isMtkClubMember == "y")
                    {
                        Console.WriteLine($"Mtk ClubMember ticket price is {ticketPrice - mtkClubDiscount} euros");
                    }
                    else
                    {
                        Console.WriteLine($"Your ticket price is {ticketPrice} euros");
                    }
                }

            }
            if (userInputAge >= 60)
            {
                Console.WriteLine("Your ticket is free.");
            }
        }
    }
}


