using System;

namespace HETUprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tarkastaa Hetun oikeudellisuuden.");
            string userInput = "06 110196-183A";
            userInput = RemoveSpaces(userInput);
            int idNumber = InputParser(userInput);
            char getLastChar = GetUserInputChkMark(userInput);
            bool isOK = isValidID(idNumber, getLastChar);
            PrintResult(isOK);
            isValidID(idNumber, 'C');

        }
        static bool IsValidDate(string userInput)
        {
            //if (userInput.StartsWith('4')) väärin
            //    return false;
            bool result = false;
            string day = userInput.Substring(0, 2);
            string month = userInput.Substring(2, 2);
            string year = userInput.Substring(4, 2);
            string century = userInput.Substring(6, 1);

            if (century == "-")
            {
                year = "19" + year;
            }
            else if (century == "A")
            {
                year = "20" + year;
            }
            else
            {
                Console.WriteLine("Väärä vuosisata");
                return result; // Keskeytetään ohjelman suoritus
            }
            // Tarkastetaan päivämäärän oikeellisuus try-catch lohkossa
            try
            {
                DateTime birthday = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
                result = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            return result;
        }

        //Tarkistetaan Hetun pituus 
        static bool IsValidLenght(string userInput)
        {
            if (userInput.Length == 11)
                return true;
            else
                return false;
        }

        //Poistetaan tyhjät 
        static string RemoveSpaces(string userInput)
        {
            string result = userInput.Replace(" ", "");
            return result;
        }

        static char GetUserInputChkMark(string userInput)
        {
            return userInput[userInput.Length - 1];
        }
        static int InputParser(string stringParser)
        {
            string removed = stringParser.Remove(10, 1);
            removed = removed.Remove(6, 1);
            //Luetaan 
            //string result = stringParser.Substring(0, 6);
            //return int.Parse(removed);
            return 0; 
        }
        static bool isValidID(int idNumber, char userInputChkMark)
        {
            string chkMark = "0123456789ABCDEFHJKLPRSTUVWXY";
            int mChecker = idNumber % 31;
            if (chkMark[mChecker] == userInputChkMark)
                return true;
            
            else
                return false;
        }
        
        static void PrintResult(bool isValidID)
        {
            if (isValidID)
                Console.WriteLine("Sotu on oikein!");
            else
                Console.WriteLine("Sotu on väärin!");
        }
    }
}
