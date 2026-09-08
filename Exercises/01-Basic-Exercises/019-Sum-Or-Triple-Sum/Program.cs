using System;

namespace SumOrTripleSum
{
    class Program
    {
        // Kontrollü integer girişi için fonksiyon
        static int InputNumber(string message)
        {
            Console.Write(message);
            int number;

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("⚠️ Invalid input. Please enter a valid integer.");
                Console.ResetColor();
                Console.Write(message);
            }

            return number;
        }

        // İki sayı eşitse toplamın 3 katını, değilse normal toplamı döndüren fonksiyonum.
        static int CalculateSumOrTripleSum(int a, int b) => (a == b) ? 3 * (a + b) : a + b;

        static void Main(string[] args)
        {
            Console.Clear();

            int a = InputNumber("Enter the first number\t: ");
            int b = InputNumber("Enter the second number\t: ");

            int result = CalculateSumOrTripleSum(a, b);

            string line1 = $"First number\t: {a}";
            string line2 = $"Second number\t: {b}";

            string resultText = result.ToString();
            string line3Prefix = (a == b)
                ? $"Result (Triple)\t: 3 x ({a} + {b}) = "
                : $"Result (Sum)\t: {a} + {b} = ";
            string line3 = line3Prefix + resultText;

            int maxLength = Math.Max(line1.Length, Math.Max(line2.Length, line3.Length));
            string divider = new string('-', maxLength + 8);

            Console.WriteLine($"\n{divider}");
            Console.WriteLine(line1);
            Console.WriteLine(line2);
            Console.WriteLine(divider);
            Console.Write(line3Prefix);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(resultText);
            Console.ResetColor();
            Console.WriteLine($"{divider}\n");
        }
    }
}