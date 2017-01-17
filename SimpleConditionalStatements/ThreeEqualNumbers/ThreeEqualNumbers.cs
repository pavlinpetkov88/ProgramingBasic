using System;

class ThreeEqualNumbers
{
    static void Main()
    {

        int firstNumber = int.Parse(Console.ReadLine());
        int secoundNumber = int.Parse(Console.ReadLine());
        int thriedNumber = int.Parse(Console.ReadLine());

        if (firstNumber == secoundNumber & firstNumber == thriedNumber & secoundNumber == thriedNumber)
        {
            Console.WriteLine("yes");
        }

        else
        {
            Console.WriteLine("no");
        }
    }
}

