using System;

namespace CalculateAverage
{
    internal class Program
    {
        static double InputNumber(string prompt)
        {
            double number;
            Console.Write(prompt);

            while (!double.TryParse(Console.ReadLine() ?? "", out number))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("⚠️ You entered an invalid number! Please try again.");
                Console.ResetColor();
                Console.Write(prompt);
            }

            return number;
        }

        static double CalculateAverage(double num1, double num2, double num3, double num4) => (num1 + num2 + num3 + num4) / 4;

        static void Main(string[] args)
        {
            Console.Clear();

            double num1 = InputNumber("Enter the first number: ");
            double num2 = InputNumber("Enter the second number: ");
            double num3 = InputNumber("Enter the third number: ");
            double num4 = InputNumber("Enter the fourth number: ");

            double average = CalculateAverage(num1, num2, num3, num4);
            Console.WriteLine($"\nThe average of {num1}, {num2}, {num3}, and {num4} is {average}.\n");
        }
    }
}