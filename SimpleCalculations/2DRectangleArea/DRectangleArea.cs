using System;

class DRectangleArea
{
    static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        var width = Math.Abs(x2 - x1);
        var height = Math.Abs(y2 - y1);
        Console.WriteLine("Area: " + width * height);
        Console.WriteLine("Perimeter: " + 2 * (width + height));
    }
}
