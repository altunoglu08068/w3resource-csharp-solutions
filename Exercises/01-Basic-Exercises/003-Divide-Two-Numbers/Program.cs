using System;

namespace DivideTwoNumbers
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
            Console.Clear();

            int x = InputNumber("Enter the dividend (first number): ");
            int y = InputNumber("Enter the divisor (second number): ");

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Conclusion: Indeterminate (0/0)");
                return;
            }
            else if (y == 0)
            {
                Console.WriteLine("Conclusion: Undefined");
                return;
            }
            else
            {
                double divide = (double)x / y;
                Console.WriteLine($"\nConclusion: {x} / {y} = {divide:F2}\n");
            }
        }
    }
}