using System;

namespace MultiplyThreeNumbers
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

            int firstNumber = InputNumber("Input the first number to multiply: ");
            int secondNumber = InputNumber("Input the second number to multiply: ");
            int thirdNumber = InputNumber("Input the third number to multiply: ");

            int result = firstNumber * secondNumber * thirdNumber;

            Console.WriteLine($"\nConclusion: {firstNumber} x {secondNumber} x {thirdNumber} = {result}\n");
        }
    }
}