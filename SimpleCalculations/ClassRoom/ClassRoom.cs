using System;

class ClassRoom
{
    static void Main()
    {
        var h = double.Parse(Console.ReadLine());
        var w = double.Parse(Console.ReadLine());
        double lengthInCM = h * 100;
        double widthInCM = w * 100;

        int workplace = (int)(lengthInCM ) / 120;
        int colum = (int)(widthInCM - 100) / 70;
        int tableInClassRoom = (workplace * colum) - 3;
        Console.WriteLine(tableInClassRoom);
    }
}
