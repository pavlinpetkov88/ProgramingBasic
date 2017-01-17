using System;

class Battles
{
    static void Main()

    {

        int playerOne = int.Parse(Console.ReadLine());
        int playerTwo = int.Parse(Console.ReadLine());
        int numberOfBattles = int.Parse(Console.ReadLine());

        int counter = 0;
        
        for (int i = 1; i <= playerOne; i++)
        {
            for (int j = 1; j <= playerTwo ; j++)
            {
                counter++;
                if (counter > numberOfBattles)
                {
                    break;
                }
                Console.Write("({0} <-> {1}) ", i , j);
            }
        }

    }
}
