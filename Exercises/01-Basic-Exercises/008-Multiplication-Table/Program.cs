using System;

namespace MultiplicationTable
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

        static void ShowMultiplicationTable(int number)
        {
            Console.WriteLine();

            for (int i = 0; i <= 10; i++)
                Console.WriteLine($"{number} x {i} \t= {number * i}");

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.Clear();

            int number = InputNumber("Enter the number: ");

            ShowMultiplicationTable(number);
        }
    }
}