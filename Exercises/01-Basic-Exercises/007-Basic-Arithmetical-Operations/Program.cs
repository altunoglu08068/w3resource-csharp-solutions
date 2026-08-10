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
            Console.WriteLine($"\n{firstNumber} + {secondNumber} \t\t= {firstNumber + secondNumber}");
            Console.WriteLine($"{firstNumber} - {secondNumber} \t\t= {firstNumber - secondNumber}");
            Console.WriteLine($"{firstNumber} x {secondNumber} \t\t= {firstNumber * secondNumber}");

            if (firstNumber == 0 && secondNumber == 0)
            {
                Console.WriteLine($"{firstNumber} / {secondNumber} \t= Uncertain");
                Console.WriteLine($"{firstNumber} mod {secondNumber} \t= Uncertain\n");
            }
            else if (secondNumber == 0)
            {
                Console.WriteLine($"{firstNumber} / {secondNumber} \t\t= Undefined");
                Console.WriteLine($"{firstNumber} mod {secondNumber} \t\t= Undefined\n");
            }
            else
            {
                double division = (double)firstNumber / secondNumber;
                Console.WriteLine($"{firstNumber} / {secondNumber} \t\t= {division:F2}");
                Console.WriteLine($"{firstNumber} mod {secondNumber} \t= {firstNumber % secondNumber}\n");
            }
        }

        static void Main(string[] args)
        {
            Console.Clear();

            int firstNumber = InputNumber("Input the first number\t: ");
            int secondNumber = InputNumber("Input the second number\t: ");

            ShowResults(firstNumber, secondNumber);
        }
    }
}