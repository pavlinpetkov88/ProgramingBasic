using System;

class Digits
{
    static void Main()
    {
        int number;

        do
        {
            number = int.Parse(Console.ReadLine());
        } while (number < 100 || number > 999);

        int[] digits = new int[3];
        int originalNumber = number;
        int n = 0;
        int m = 0;

        for (int index = 3 - 1; index >= 0; index--)
        {
            digits[index] = number % 10;
            number = number / 10;
        }

        n = digits[0] + digits[1];
        m = digits[0] + digits[2];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (originalNumber % 5 == 0)
                {
                    originalNumber = originalNumber - digits[0];
                    Console.Write("{0} ", originalNumber);
                }
                else if (originalNumber % 3 == 0)
                {
                    originalNumber = originalNumber - digits[1];
                    Console.Write("{0} ", originalNumber);

                }
                else
                {
                    originalNumber = originalNumber + digits[2];
                    Console.Write("{0} ", originalNumber);
                }
            }
            Console.WriteLine();
        }
    }
}

