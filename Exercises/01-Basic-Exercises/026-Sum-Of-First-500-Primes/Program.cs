using System;

namespace SumOfFirst500Primes
{
    internal class Program
    {
        // Bir sayının asal olup olmadığını kontrol eden optimize metot
        static bool IsPrime(int number)
        {
            if (number <= 1) return false; // 1 ve altı asal değil.
            if (number == 2) return true; // 2 asal sayı.

            // Diğer sayılar için kontol eden döngüm.
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        // İstenen ADET kadar asal sayıyı toplayan metodum.
        static long SumOfPrimes(int targetCount)
        {
            long sum = 0; // Toplamı tutan değişkenim.
            int count = 0; // Ne kadar asal sayı bulduğumuzu tutan değişkenim.
            int candidate = 2; // Denemeye en küçük asaldan başlıyorum.

            while (count < targetCount)
            {
                if (IsPrime(candidate)) // Metottan gelen asal olma durumuna göre işlem yapıyorum.
                {
                    sum += candidate;
                    count++; // Bir asal daha buldum!
                }

                candidate++; // Bir sonraki sayıyı test ediyorum.
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.Clear();

            int targetCount = 500; // Sınır sayımızı tutan değişkenim.
            long totalSum = SumOfPrimes(targetCount); // Toplamı tutan değişkenim.

            // Çıktı
            string title = $"Sum of the first {targetCount} prime numbers";
            string divider = new string('-', title.Length + 8);

            Console.WriteLine(divider);
            Console.WriteLine($"    {title}");
            Console.WriteLine(divider);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n\tResult: {totalSum}\n");
            Console.ResetColor();
            Console.WriteLine(divider);
        }
    }
}