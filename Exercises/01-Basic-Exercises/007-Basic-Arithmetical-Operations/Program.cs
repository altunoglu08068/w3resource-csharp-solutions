using System;

namespace BasicArithmeticalOperations
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

        static void ShowResults(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"\n{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            Console.WriteLine($"{firstNumber} x {secondNumber} = {firstNumber * secondNumber}");

            if (firstNumber == 0 && secondNumber == 0)
            {
                Console.WriteLine($"{firstNumber} / {secondNumber} = Uncertain");
                Console.WriteLine($"{firstNumber} mod {secondNumber} = Uncertain\n");
            }
            else if (secondNumber == 0)
            {
                Console.WriteLine($"{firstNumber} / {secondNumber} = Undefined");
                Console.WriteLine($"{firstNumber} mod {secondNumber} = Undefined\n");
            }
            else
            {
                double division = (double)firstNumber / secondNumber;
                Console.WriteLine($"{firstNumber} / {secondNumber} = {division:F2}");
                Console.WriteLine($"{firstNumber} mod {secondNumber} = {firstNumber % secondNumber}\n");
            }
        }

        static void Main(string[] args)
        {
            Console.Clear();

            int firstNumber = InputNumber("Input the first number: ");
            int secondNumber = InputNumber("Input the second number: ");

            ShowResults(firstNumber, secondNumber);
        }
    }
}