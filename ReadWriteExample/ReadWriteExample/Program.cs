using System;
/*
 * With this program you can learn the basics of C#
 * Producer Lauri Ellonen
 * Saimaa Ammattikorkeakoulu Saimia 
*/
namespace ReadWriteExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ReadWriteExample");      // Priting message to on your screen. 
            Console.Write("Terve, Söytäthän nimesi: ");
            /*
             * Printing on the screen basic message
             * Luetaan käyttäjän syöttämät merkit niin pitkään kun painetaan Enter,
             myös sijoitetaan merkit merkkijonomuodassa userInput.
            */
            string userInput = Console.ReadLine();      
            Console.WriteLine("---------------------");
            Console.WriteLine("Päivää " + userInput + "!");                
            Console.WriteLine("Moi {0}!",userInput);
            Console.WriteLine($"Hello {userInput}");

            /*
             * Basic way of printing on line 17
             * Perfered way by Jouni of doing printing in C# on line 19 
            */
        }
    }
}
