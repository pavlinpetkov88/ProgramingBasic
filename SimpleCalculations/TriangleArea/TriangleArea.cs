using System;

class TriangleArea
{
    static void Main()
    {
        var a = double.Parse(Console.ReadLine());
        var h = double.Parse(Console.ReadLine());
       // var sum = (a * h) / 2;
        var area = (a * h)/2; Math.Round(area,2);
        Console.WriteLine("Triangle area = " + area);
    }
}
