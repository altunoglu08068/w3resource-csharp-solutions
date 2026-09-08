using System;

namespace CheckOppositeSignedIntegers
{
    class Program
    {
        // Kontrollü integer girişi için fonksiyonum.
        static int InputInteger(string prompt)
        {
            Console.Write(prompt);

            int number;

            while (!int.TryParse(Console.ReadLine() ?? "", out number))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("⚠️ Invalid input. Please enter a valid integer: ");
                Console.ResetColor();
            }

            return number;
        }

        // Farklı işaretlerde mi diye kontrol eden fonksiyonum.
        static bool AreOppositeSigned(int num1, int num2) => (num1 < 0 && num2 > 0) || (num1 > 0 && num2 < 0);

        static void Main(string[] args)
        {
            Console.Clear();

            int num1 = InputInteger("Enter the first integer\t: ");
            int num2 = InputInteger("Enter the second integer: ");

            bool areOppositeSigned = AreOppositeSigned(num1, num2);

            // Çizgi uzunluğunu hesaplamak için tam metni alıyorum.
            string fullText = $"The integers {num1} and {num2} have opposite signs: {areOppositeSigned}";
            string divider = new string('-', fullText.Length);

            Console.WriteLine($"\n{divider}");

            // Sonra cümlenin ilk kısmını standart renkle yazdırıyorum.
            Console.Write($"The integers {num1} and {num2} have opposite signs: ");

            // Yalnızca True/False kısmının rengini belirleyip yazdırıyorum.
            Console.ForegroundColor = areOppositeSigned ? ConsoleColor.Green : ConsoleColor.Red;
            Console.Write(areOppositeSigned);
            Console.ResetColor();

            // Sonda satır sonunu tamamlıyorum.
            Console.WriteLine();

            Console.WriteLine($"{divider}\n");
        }
    }
}