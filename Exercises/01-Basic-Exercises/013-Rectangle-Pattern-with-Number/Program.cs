using System;

namespace RectanglePatternWithNumber
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

        static void PrintRectanglePattern(int number)
        {
            Console.WriteLine();

            Console.WriteLine("{0}{0}{0}", number);

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("{0} {0}", number);
            }

            Console.WriteLine("{0}{0}{0}", number);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.Clear();

            int number = InputNumber("Enter a number: ");
            PrintRectanglePattern(number);
        }
    }
}
