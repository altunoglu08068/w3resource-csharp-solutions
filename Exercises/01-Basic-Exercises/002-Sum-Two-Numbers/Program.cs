using System;

namespace SumTwoNumbers
{
    internal class Program
    {
        static int InputNumber(string prompt)
        {
            int number;
            Console.Write(prompt);

            while (!int.TryParse(Console.ReadLine() ?? "", out number))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("⚠️ You entered an invalid number! Please try again.");
                Console.ResetColor();
                Console.Write(prompt);
            }

            return number;
        }

        static void Main(string[] args)
        {
            int x = InputNumber("Enter the first number: ");
            int y = InputNumber("Enter the second number: ");

            Console.WriteLine($"\nSum: {x} + {y} = {x + y}");
        }
    }
}