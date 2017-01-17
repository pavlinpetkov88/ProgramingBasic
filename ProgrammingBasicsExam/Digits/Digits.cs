using System;

class Digits
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int oringinalNumber = number;
        int digit3 = oringinalNumber % 10;
        oringinalNumber /= 10;
        int digit2 = oringinalNumber % 10;
        oringinalNumber /= 10;
        int digit1 = oringinalNumber % 10;

        
        for (int i = 0; i < digit1 + digit2; i++)
        {
            for (int j = 0; j < digit1 + digit3; j++)
            {
                if (number % 5 == 0)
                {
                    number -= digit1;
                    Console.Write("{0} ", number);

                }
                else if (number % 3 == 0)
                {
                    number -= digit2;
                    Console.Write("{0} ", number);
                }
                else
                {
                    number += digit3;
                    Console.Write("{0} ", number);
                }
                
            }
            Console.WriteLine();
        }
    }
}
