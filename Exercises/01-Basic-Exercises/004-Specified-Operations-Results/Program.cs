using System;

namespace SpecifiedOperationsResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int firstResult = -1 + 4 * 6;
            int secondResult = (35 + 5) % 7;
            int thirdResult = 14 + (-4) * 6 / 11;
            int fourthResult = 2 + 15 / 6 * 1 - 7 % 2;

            Console.WriteLine($"First conclusion\t: {firstResult,2}");
            Console.WriteLine($"Second conclusion\t: {secondResult,2}");
            Console.WriteLine($"Third conclusion\t: {thirdResult,2}");
            Console.WriteLine($"Fourth conclusion\t: {fourthResult,2}\n");
        }
    }
}