using System;

class MagicCombinations
{
    static void Main()
    {

        int magicNumber = int.Parse(Console.ReadLine());

        for (int i = 1; i < 10; i++)
        {
            for (int h = 1; h < 10; h++)
            {
                for (int j = 1; j < 10; j++)
                {
                    for (int k = 1; k < 10; k++)
                    {
                        for (int l = 1; l < 10; l++)
                        {
                            for (int p = 1; p < 10; p++)
                            {
                                if (i * h * j * k * l * p == magicNumber)
                                {
                                    Console.Write($"{i}{h}{j}{k}{l}{p} ");
                                }
                            }
                        }
                    }
                }
            }
        }


    }
}
