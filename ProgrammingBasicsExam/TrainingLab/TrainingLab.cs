using System;

class ClassRoom
{
    static void Main()
    {
        var h = double.Parse(Console.ReadLine());
        var w = double.Parse(Console.ReadLine());
        double lengthInCM = h * 100;
        double widthInCM = w * 100;

        var workplace = (lengthInCM) / 120;
        var colum = (widthInCM - 100) / 70;
        var tableInClassRoom = (workplace * colum) - 3;
        Console.WriteLine(tableInClassRoom);
    }
}
