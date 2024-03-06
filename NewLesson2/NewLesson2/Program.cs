using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            double operand1, operand2, result = 0;
            string sign, weather;

            Console.WriteLine("First number: ");
            operand1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Second number: ");
            operand2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Select operation: +, -, *, / ");
            sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;
                case "/":
                    if (operand2 == 0)
                        Console.WriteLine("Error!");
                    else
                        result = operand1 / operand2;
                    break;
                default:
                    Console.WriteLine("Unknown command, try again!");
                    break;

            }
            Console.WriteLine(result);
            // Range check
            if (result >= 0 && result <= 14)
                Console.WriteLine("Number is in range [0-14]");
            else if (result >= 15 && result <= 35)
                Console.WriteLine("Number is in range [15-35]");
            else if (result >= 36 && result <= 50)
                Console.WriteLine("Number is in range [36-50]");
            else if (result >= 51 && result <= 100)
                Console.WriteLine("Number is in range [51-100]");
            else
                Console.WriteLine("Numder is out of available ranges.");
            //Parity check
            if (result % 2 == 0)
                Console.WriteLine("Even number");
            else
                Console.WriteLine("Odd number");
            /* if (result & 1==0)       the method works if the number is an integer type
                 Console.WriteLine("Even number");
             else
                 Console.WriteLine("Odd number");*/
            Console.WriteLine("Enter a word in russian: ");
            weather = Console.ReadLine();
            switch (weather)
            {
                case "Солнечно":
                    Console.WriteLine("Sunny");
                    break;
                case "Дождливо":
                    Console.WriteLine("Rainy");
                    break;
                case "Тепло":
                    Console.WriteLine("Warm");
                    break;
                case "Морозно":
                    Console.WriteLine("Frostly");
                    break;
                case "Ветрено":
                    Console.WriteLine("Windy");
                    break;
                case "Туманно":
                    Console.WriteLine("Foggy");
                    break;
                case "Облачно":
                    Console.WriteLine("Cloudly");
                    break;
                case "Холодно":
                    Console.WriteLine("Cold");
                    break;
                case "Жарко":
                    Console.WriteLine("Hot");
                    break;
                case "Прохладно":
                    Console.WriteLine("Chilly");
                    break;
                default:
                    Console.WriteLine("Translation missing!");
                    break;



            }

            Console.ReadKey();
        }
    }
}