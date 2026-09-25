using System;

namespace PrintOddNumbers
{
    internal class Program
    {
        // 1 ile 99 arasındaki tek sayıları yazdıran metodum.
        static void PrintOddNumbers()
        {
            string title = "Odd Numbers from 1 to 99";

            // Başlık uzunluğuna kenar boşlukları ekleyerek çizgiyi dinamik oluşturuyorum.
            string divider = new string('-', title.Length + 16);

            Console.WriteLine(divider);
            Console.WriteLine($"        {title}");
            Console.WriteLine(divider);
            Console.WriteLine();

            for (int i = 1; i <= 99; i++)
            {
                // Sayının 2'ye bölümünden kalan 1 ise tektir.
                if (i % 2 == 1) Console.WriteLine($"\t\t{i,5}");
            }

            Console.WriteLine($"\n{divider}");
        }

        static void Main(string[] args)
        {
            Console.Clear();

            PrintOddNumbers();
        }
    }
}