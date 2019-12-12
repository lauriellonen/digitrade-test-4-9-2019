using System;

namespace HETUprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tarkastaa Hetun oikeudellisuuden.");
            string userInput = "061096-083C";
            int idNumber = InputParser(userInput);
            isValidID(idNumber);

        }
        static int InputParser(string stringParser)
        {
            string removed = stringParser.Remove(10, 1);
            removed = removed.Remove(6, 1);
            //Luetaan 
            string result = stringParser.Substring(0, 6);
            return int.Parse(removed);
        }
        static bool isValidID(int idNumber)
        {
            string chkMark = "0123456789ABCDEFHJKLPRSTUVWXY";
            int mChecker = idNumber % 31;
            Console.WriteLine(chkMark[mChecker]);
            return true;
        }
    }
}
