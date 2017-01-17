using System;

class CelsiusToFahrenheit
{
    static void Main()
    {
        var celsius = double.Parse(Console.ReadLine());
        var celsiustofahrenheit = (celsius * 1.8) + 32;
        var result = Math.Round(celsiustofahrenheit, 2);
        Console.WriteLine("Fahrenheit = " + result);
    }
}
