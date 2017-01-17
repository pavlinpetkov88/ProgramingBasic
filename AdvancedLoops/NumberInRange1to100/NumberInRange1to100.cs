using System;

class NumberInRange1to100
{
    static void Main()
    {

        int number = int.Parse(Console.ReadLine());
        while (true)
        {
            if (number >= 1 && number <= 100)
            {
                Console.WriteLine("The number is: {0}", number);
                break;
            }
            else
            {
                Console.WriteLine("Invalid number! {0}", number);
            }
            number = int.Parse(Console.ReadLine());

        }
    }
}
