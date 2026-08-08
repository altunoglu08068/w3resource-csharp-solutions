using System;

namespace SwapTwoNumbers
{
    internal class Program
    {
        static int InputNumber(string prompt)
        {
            Console.Write(prompt);

            int number;

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

            int firstNumber = InputNumber("Enter the First Number: ");
            int secondNumber = InputNumber("Enter the Second Number: ");

            Console.WriteLine("\nBefore Swapping:");
            Console.WriteLine($"First Number\t: {firstNumber}");
            Console.WriteLine($"Second Number\t: {secondNumber}");

            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;

            Console.WriteLine("\nAfter Swapping:");
            Console.WriteLine($"First Number\t: {firstNumber}");
            Console.WriteLine($"Second Number\t: {secondNumber}\n");
        }
    }
}