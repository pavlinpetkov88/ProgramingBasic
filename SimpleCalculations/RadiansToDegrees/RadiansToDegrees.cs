using System;

class RadiansToDegrees
{
    static void Main()
    {
        var radians = double.Parse(Console.ReadLine());
        var deg = (radians * 180) / Math.PI;
        var result = Math.Round(deg,0);
        Console.WriteLine("Degrees = " + result);
    }
}
