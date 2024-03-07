using System;
using System.Text.RegularExpressions;
using System.Text;

namespace Lesson4
{
    class StringManipulator
    {
        public static string ReplaceAndRemoveDigits(string input)
        {
            string replacedString = input.Replace("test", "testing");
            return Regex.Replace(replacedString, @"\d", "");
        }

        public static void Concatenate()
        {
            Console.WriteLine("Welcome to the TMS lesons.");
            string word1 = "Welcome";
            string word2 = "to";
            string word3 = "the";
            string word4 = "TMS";
            string word5 = "lessons.";

            Console.WriteLine($"\"{word1}\" \"{word2}\" \"{word3}\" \"{word4}\" \"{word5}\"");
        }

        public static void ABC(string input)
        {
            string beforeABC = string.Empty;
            string afterABC = string.Empty;
            int IndexOfSubstringABC = input.IndexOf("abc");
            if (IndexOfSubstringABC != -1)
            {
                beforeABC = input.Substring(0, IndexOfSubstringABC);
                afterABC = input.Substring(IndexOfSubstringABC + 3);
            }
            Console.WriteLine($"Before ABC: \"{beforeABC}\"");
            Console.WriteLine($"After ABC: \"{afterABC}\"");
        }

        public static string BadGoodDay(string input)
        {
            string result = input;
            int startIndex = input.IndexOf("Плохой");
            if (startIndex != -1)
            {
                result = result.Remove(startIndex, 6);
                result = result.Insert(startIndex, "Хороший");
                result = result + "!!!!!!!!";
                int lastExclamationIndex = result.LastIndexOf('!');
                if (lastExclamationIndex != -1)
                {
                    result = result.Remove(lastExclamationIndex, 1);
                    result = result.Insert(lastExclamationIndex, "?");
                }
            }
            return result;
        }

        public static void First(string documentNumber) //5.1
        {
            string[] words = documentNumber.Split('-');
            string Block1 = words[0];
            string Block2 = words[2];
            Console.WriteLine(Block1 + " " + Block2);
        }

        public static void Second(string documentNumber) //5.2
        {
            string result1 = documentNumber.Replace(documentNumber.Substring(5, 3), "***").Replace(documentNumber.Substring(14, 3), "***");
            Console.WriteLine(result1);
        }

        public static void Third(string documentNumber) //5.3
        {
            string[] words = documentNumber.Split('-');
            Console.WriteLine(words[1].ToLower() + "/" + words[3].ToLower() + "/" + Char.ToLower(words[4][1]) + "/" + Char.ToLower(words[4][3]));
        }

        public static void Fourth(string documentNumber) //5.4
        {
            StringBuilder Letters = new StringBuilder("Letters:");
            foreach (char c in documentNumber)
            {
                if (char.IsLetter(c))
                {
                    Letters.Append(char.ToUpper(c));
                }
            }
            Console.WriteLine(Letters.ToString());
        }

        public static void Fifth(string documentNumber) //5.5
        {
            if (documentNumber.ToLower().Contains("abc"))
            {
                Console.WriteLine("The document number contains the sequence abc.");
            }
            else
            {
                Console.WriteLine("The document number does not contain the abc sequence.");
            }
        }

        public static void Sixth(string documentNumber) //5.6
        {
            string message = documentNumber.StartsWith("555")
                ? "The document number starts with the sequence 555."
                : "The document number does not start with the sequence 555.";
            Console.WriteLine(message);
        }

        public static void Seventh(string documentNumber) //5.7
        {
            if (documentNumber.EndsWith("1a2b"))
            {
                Console.WriteLine("The document number ends with the sequence 1a2b.");
            }
            else
            {
                Console.WriteLine("The document number does not end with the sequence 1a2b.");
            }
        }
    }


    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the task number to check: ");
            int task;
            task = Convert.ToInt32(Console.ReadLine());
            switch (task)
            {
                case 1:
                    string input = "Let's run 123test456 once, then run 789test 123 a second time and make sure that code 5858 works";
                    Console.WriteLine(input);
                    string correctedline = StringManipulator.ReplaceAndRemoveDigits(input);
                    Console.WriteLine(correctedline);
                    break;
                case 2:
                    StringManipulator.Concatenate();
                    break;
                case 3:
                    string inputString = "teamwithsomeofexcersicesabcwanttomakeitbetter";
                    StringManipulator.ABC(inputString);
                    break;
                case 4:
                    string day = "Плохой день.";
                    string goodday = StringManipulator.BadGoodDay(day);
                    Console.WriteLine(goodday);
                    break;
                case 5:
                    string documentNumber = "1234-abc-5678-def-1a2b";

                    StringManipulator.First(documentNumber);
                    StringManipulator.Second(documentNumber);
                    StringManipulator.Third(documentNumber);
                    StringManipulator.Fourth(documentNumber);
                    StringManipulator.Fifth(documentNumber);
                    StringManipulator.Sixth(documentNumber);
                    StringManipulator.Seventh(documentNumber);
                    break;
            }



        }

    }
}
