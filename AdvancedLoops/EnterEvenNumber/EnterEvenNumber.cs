using System;

class EnterEvenNumber
{
    static void Main()
    {
        int number = 0;
        while (true)
        {
            try
            {
                number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine("Even number entered: {0}", number);
                    break;
                }
                else
                {
                    Console.WriteLine("The number is not even!");
                }
            }

            catch (OverflowException)
            {
                Console.WriteLine("The number is to big!");

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");

            }

        }

    }
}

