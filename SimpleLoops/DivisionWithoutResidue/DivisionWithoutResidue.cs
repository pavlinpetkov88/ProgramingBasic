using System;

class DivisionWithoutResidue
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        int devide2 = 0;
        int devide3 = 0;
        int devide4 = 0;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0) devide2++;
            if (number % 3 == 0) devide3++;
            if (number % 4 ==0) devide4++;
        }

        var percentByDevide2 = devide2 * 100.00 / n;
        var percentByDevide3 = devide3 * 100.00 / n;
        var percentByDevide4 = devide4 * 100.00 / n;

        Console.WriteLine("{0:f2}%", percentByDevide2);
        Console.WriteLine("{0:f2}%", percentByDevide3);
        Console.WriteLine("{0:f2}%", percentByDevide4);
    }
}
