using System;


class Histogram
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int p1 = 0;
        int p2 = 0;
        int p3 = 0;
        int p4 = 0;
        int p5 = 0;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 200) p1++;
            else if (number >= 200 && number < 400) p2++;
            else if (number >= 400 && number < 600) p3++;
            else if (number >= 600 && number < 800) p4++;
            else
            {
                p5++;
            }

        }

        double percentP1 = p1 * 100d / n;
        double percentP2 = p2 * 100d / n;
        double percentP4 = p4 * 100d / n;
        double percentP5 = p5 * 100d / n;
        double percentP3 = p3 * 100d / n;

        Console.WriteLine("{0:f2}%", percentP1);
        Console.WriteLine("{0:f2}%", percentP2);
        Console.WriteLine("{0:f2}%", percentP3);
        Console.WriteLine("{0:f2}%", percentP4);
        Console.WriteLine("{0:f2}%", percentP5);
        
    }
}

