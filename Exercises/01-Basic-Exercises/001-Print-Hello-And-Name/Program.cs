using System;

namespace HelloAndName
{
    internal class Program
    {
        // Kendi yazdığımız boşluk kontrol metodu (Hazır metot yok)
        static bool IsOnlySpaces(string input)
        {
            if (input.Length == 0) return true; // Metnin uzunluğu sıfırsa true döndürüyorum.

            for (int i = 0; i < input.Length; i++) // Döngüyü metnin uzunluğu kadar döndürüyorum.
            {
                if (input[i] != ' ')
                {
                    return false; // Boşluk dışında en az bir karakter bulunduysa false döndürüyorum.
                }
            }

            return true; // Metnin tamamı boşluk karakterlerinden oluşuyorsa true döndürüyorum.
        }

        static void Main(string[] args)
        {
            string name;

            do // Metin giriş ve kontrolünü yapıyorum. 
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine() ?? "";
            } while (IsOnlySpaces(name));

            Console.WriteLine("\nHello");
            Console.WriteLine(name);
        }
    }
}