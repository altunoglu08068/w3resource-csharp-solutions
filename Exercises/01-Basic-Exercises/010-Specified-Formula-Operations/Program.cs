using System;

namespace SpecifiedFormulaOperations
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

        static double Formula1(double x, double y, double z) => (x + y) * z;
        static double Formula2(double x, double y, double z) => x * y + y * z;

        static void Main(string[] args)
        {
            Console.Clear();

            double x = InputNumber("Enter the value for x: ");
            double y = InputNumber("Enter the value for y: ");
            double z = InputNumber("Enter the value for z: ");

            double result1 = Formula1(x, y, z);
            double result2 = Formula2(x, y, z);

            Console.WriteLine($"\nResult of Formula 1 ((x + y) · z): {result1}");
            Console.WriteLine($"Result of Formula 2 (x · y + y · z): {result2}\n");
        }
    }
}