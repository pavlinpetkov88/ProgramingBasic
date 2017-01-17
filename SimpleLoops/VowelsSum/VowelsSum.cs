using System;

class VowelsSum
{
    static void Main()
    {
        string word = Console.ReadLine();

        int points = 0;

        for (int i = 0; i <= word.Length - 1; i++)
        {
            if (word[i] == 'a')
            {
                points += 1;
            }
            if (word[i] == 'e')
            {
                points += 2;
            }
            if (word[i] == 'i')
            {
                points += 3;
            }
            if (word[i] == 'o')
            {
                points += 4;
            }
            if (word[i] == 'u')
            {
                points += 5;
            }
        }
        Console.WriteLine(points);
    }
}

