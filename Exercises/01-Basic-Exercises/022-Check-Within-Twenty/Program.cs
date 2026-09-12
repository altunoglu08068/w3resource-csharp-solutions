using System;

namespace CheckWithinTwenty
{
    class Program
    {
        // Kontrollü sayı girişi yapan fonksiyonum.
        static int InputNumber(string prompt)
        {
            Console.Write(prompt);
            int number;

            while (!int.TryParse(Console.ReadLine() ?? "", out number))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n⚠️ Invalid input. Please enter a valid integer.");
                Console.ResetColor();

                Console.Write(prompt);
            }
            return number;
        }

        // Sayının 100 veya 200'e 20 birim yakınlığını kontrol eden metotum.
        static bool IsWithinTwenty(int number) =>
            Math.Abs(100 - number) <= 20 || Math.Abs(200 - number) <= 20;

        // Düzenli bir çıktı için metodum.
        static void PrintHeader(int number, bool result)
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("     Within 20 of 100 or 200 Check      ");
            Console.WriteLine("========================================\n");

            string line1 = $"Input number\t: {number}";
            string resultText = result.ToString();
            string line2Prefix = "Result\t\t: ";
            string line2 = line2Prefix + resultText;

            int maxLength = Math.Max(line1.Length, line2.Length);
            string divider = new string('-', maxLength + 8);

            Console.WriteLine(divider);
            Console.WriteLine(line1);
            Console.WriteLine(divider);
            Console.Write(line2Prefix);
            Console.ForegroundColor = result ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine(resultText);
            Console.ResetColor();
            Console.WriteLine($"{divider}\n");
        }

        static void Main(string[] args)
        {
            Console.Clear();

            int number = InputNumber("Enter an integer\t: ");
            bool isWithin = IsWithinTwenty(number);

            PrintHeader(number, isWithin);
        }
    }
}