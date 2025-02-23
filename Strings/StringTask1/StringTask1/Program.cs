﻿using System;

namespace StringTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merkkijono käsittely esimerkki");
            string message = "Hello World!";
            //Tulostetaan messages -muuttujen merkit yksitellen näytölle.
            Console.WriteLine($"{message} on {message.Length} merkkiä.");

            PrintMessage(message);

            //poistetaan välilyönnit alusta ja lopusta.
            string tempMessage = message.Trim();
            PrintMessage(tempMessage);

            //Muuntaa kirjaimet isoiksi kirjaimiksi. 
            tempMessage = message.ToUpper();
            PrintMessage(tempMessage);

            //Esitään merkinkohtaa merkkijonosta. 
            int position = tempMessage.IndexOf(' ');
            Console.WriteLine($"Välilyönti löytyy kohdasta {position}");
            //for (int i =0;i<message.Length; i++)
            //{
            //    Console.WriteLine(message[i]);
            //}
        }
        static void PrintMessage(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }
    }
}
