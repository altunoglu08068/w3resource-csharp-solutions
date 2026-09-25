using System;

namespace SumOfTheDigits
{
    internal class Program
    {
        // Kullanıcıdan geçerli bir tamsayı alan güvenli giriş metodum.
        static int InputNumber(string text)
        {
            int number;
            Console.Write(text);

            while (!int.TryParse(Console.ReadLine() ?? "", out number))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n⚠️  Invalid input! Please enter a valid integer.");
                Console.ResetColor();

                Console.Write(text);
            }

            return number;
        }

        // Basamakları toplayan algoritma metodu
        static int SumOfDigits(int number)
        {
            // Negatif sayılarda da basamak toplamı doğru çalışsın diye mutlak değer alıyorum.
            int x = Math.Abs(number);
            int sum = 0;

            while (x > 0)
            {
                int lastDigit = x % 10; // Son basamağı alıyorum.
                sum += lastDigit;       // Toplama ekliyorum.
                x /= 10;                 // Son basamağı siliyorum.
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.Clear();

            int number = InputNumber("Enter an integer: ");
            int sum = SumOfDigits(number);

            // Çıktı
            string title = "Sum of Digits of an Integer";
            string lineInput = $"Input Number : {number}";
            string lineResult = $"Digit Sum    : {sum}";

            int maxLength = Math.Max(title.Length, Math.Max(lineInput.Length, lineResult.Length));
            string divider = new string('-', maxLength + 8);

            Console.WriteLine($"\n{divider}");
            Console.WriteLine($"    {title}");
            Console.WriteLine(divider);
            Console.WriteLine($"\n    {lineInput}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"    {lineResult}\n");
            Console.ResetColor();
            Console.WriteLine(divider);
        }
    }
}