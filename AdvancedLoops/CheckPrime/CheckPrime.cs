using System;

class CheckPrime
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        bool prime = true;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                prime = false;
            }
        }
        if (n < 2)
        {
            Console.WriteLine("{0} Not Prime", n);
        }
        else if (prime)
        {
            Console.WriteLine("{0} Prime" , n);
        }
        else
        {
            Console.WriteLine("{0} Not Prime", n);
        }
        
    }
}