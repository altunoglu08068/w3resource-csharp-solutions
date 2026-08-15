using System;

namespace RepeatNumberInRows
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

        static void DisplayRepeatedPatterns(int num)
        {
            Console.WriteLine();

            for (int i = 0; i < 2; i++) // 1 satır boşluklu, 1 satır bitişik deseni 2 kez tekrarlayarak 4 çıktı üretir.
            {
                Console.WriteLine("{0} {0} {0} {0}", num);
                Console.WriteLine("{0}{0}{0}{0}", num);
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.Clear();

            int number = InputNumber("Enter a digit: ");

            DisplayRepeatedPatterns(number);
        }
    }
}