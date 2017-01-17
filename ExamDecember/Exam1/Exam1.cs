using System;

class Exam1
{
    static void Main()
    {
        int speed = int.Parse(Console.ReadLine());
        var fTime = double.Parse(Console.ReadLine()) / 60;
        var sTime = double.Parse(Console.ReadLine()) / 60;
        var tTime = double.Parse(Console.ReadLine()) / 60;

        double res1 = fTime * speed;
        double speed10 = speed * 1.1;

        double res2 = sTime * speed10;
        double speed5 = speed10 - (speed10 * 0.05);
        double res3 = tTime * speed5;
        var result = res1 + res2 + res3;

        Console.WriteLine("{0:f2}", result);

    }
}
