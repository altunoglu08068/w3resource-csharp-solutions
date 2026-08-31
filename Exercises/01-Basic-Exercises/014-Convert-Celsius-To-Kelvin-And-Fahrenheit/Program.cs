using System;

namespace ConvertCelsiusToKelvinAndFahrenheit
{
    class Program
    {
        static double InputNumber(string prompt)
        {
            Console.Write(prompt);
            double number;

            while (!double.TryParse(Console.ReadLine() ?? "", out number))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n⚠️ Invalid input.");
                Console.ResetColor();
                Console.Write("Please enter a valid number: ");
            }

            return number;
        }

        static double CelsiusToKelvin(double celsius) => celsius + 273.15;
        static double CelsiusToFahrenheit(double celsius) => (celsius * 9.0 / 5.0) + 32;

        static void Main(string[] args)
        {
            Console.Clear();

            double celsius = InputNumber("Enter the amount of celsius: ");
            double kelvin = CelsiusToKelvin(celsius);
            double fahrenheit = CelsiusToFahrenheit(celsius);

            Console.WriteLine($"\nCelsius: {celsius:F2} °C");
            Console.WriteLine("\n--------------------------");
            Console.WriteLine($"Kelvin\t\t: {kelvin:F2} K");
            Console.WriteLine($"Fahrenheit\t: {fahrenheit:F2} °F");
            Console.WriteLine("--------------------------\n");
        }
    }
}