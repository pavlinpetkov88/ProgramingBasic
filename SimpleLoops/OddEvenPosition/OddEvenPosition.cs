using System;

class OddEvenPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());


        double oddSum = 0.0;
        double oddMin = double.MaxValue;
        double oddMax = double.MinValue;
        double evenSum = 0.0;
        double evenMin = double.MaxValue;
        double evenMax = double.MinValue;

        for (int i = 1; i <= n; i++)
        {
            double num = double.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                evenSum += num;
                if (num > evenMax)
                {
                    evenMax = num;
                }
                if (num < evenMin)
                {
                    evenMin = num;
                }
            }
            else if (i % 2 == 1)
            {
                oddSum += num;
                if (num < oddMin)
                {
                    oddMin = num;
                }
                if (num > oddMax)
                {
                    oddMax = num;
                }
            }
        }
        if (n == 0)
        {
            Console.WriteLine("OddSum={0}", oddSum);
            Console.WriteLine("OddMin=No,");
            Console.WriteLine("OddMax=No");
            Console.WriteLine("EvenSum={0}", evenSum);
            Console.WriteLine("EvenMin=No,");
            Console.WriteLine("EvenMax=No");
        }
        else if (n == 1)
        {
            Console.WriteLine("OddSum={0}", oddSum);
            Console.WriteLine("OddMin={0}", oddMin);
            Console.WriteLine("OddMax={0}", oddMax);
            Console.WriteLine("EvenSum={0}", evenSum);
            Console.WriteLine("EvenMin=No,");
            Console.WriteLine("EvenMax=No");
        }
        else if (n >= 2)
        {
            Console.WriteLine("OddSum={0}", oddSum);
            Console.WriteLine("OddMin={0}", oddMin);
            Console.WriteLine("OddMax={0}", oddMax);
            Console.WriteLine("EvenSum={0}", evenSum);
            Console.WriteLine("EvenMin={0}", evenMin);
            Console.WriteLine("EvenMax={0}", evenMax);
        }
       
    }
}
