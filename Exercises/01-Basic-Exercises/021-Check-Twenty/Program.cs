using System;

namespace CheckTwenty
{
    class Program
    {
        // Kontrollü sayı girişi için fonksiyonum.
        static int InputNumber(string prompt)
        {
            Console.Write(prompt);
            int number;

            while (!int.TryParse(Console.ReadLine() ?? "", out number))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("⚠️ Invalid input. Please enter a valid integer.");
                Console.ResetColor();

                Console.Write(prompt);
            }
            return number;
        }

        // Sayılardan biri 20 mi veya toplamları 20 mi kontrolü yapan fonksiyonum.
        static bool CheckTwenty(int num1, int num2) =>
            (num1 == 20) || (num2 == 20) || (num1 + num2 == 20);

        // Düzenli bir çıktı üreten fonksiyonum.
        static void PrintHeader(int num1, int num2, bool result)
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("         Check Twenty Validator         ");
            Console.WriteLine("========================================\n");

            string line1 = $"First number\t: {num1}";
            string line2 = $"Second number\t: {num2}";

            string resultText = result.ToString();
            string line3Prefix = $"Result (20 check)\t: ";
            string line3 = line3Prefix + resultText;

            int maxLength = Math.Max(line1.Length, Math.Max(line2.Length, line3.Length));
            string divider = new string('-', maxLength + 8);

            Console.WriteLine(divider);
            Console.WriteLine(line1);
            Console.WriteLine(line2);
            Console.WriteLine(divider);
            Console.Write(line3Prefix);
            Console.ForegroundColor = result ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine(resultText);
            Console.ResetColor();
            Console.WriteLine($"{divider}\n");
        }

        static void Main(string[] args)
        {
            Console.Clear();

            int num1 = InputNumber("Enter the first number\t: ");
            int num2 = InputNumber("Enter the second number\t: ");
            bool result = CheckTwenty(num1, num2);

            PrintHeader(num1, num2, result);
        }
    }
}