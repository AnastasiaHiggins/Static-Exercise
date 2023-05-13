using System;
namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(68);

            Console.WriteLine($"celsius {celsius}");

            var fahrenheit = TempConverter.CelsiusToFahrenheit(23);

            Console.WriteLine($"fahrenheit {fahrenheit}");
        }
    }
}
