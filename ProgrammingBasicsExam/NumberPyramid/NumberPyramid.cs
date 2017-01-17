using System;


class NumberPyramid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var num = 1;
        
        for (int row = 0; row < n; row++)
        {

            for (int col = 0; col <= row; col++)
            {
                if (num - 1 == n)
                {
                    
                    break;
                }
                Console.Write(num++);
                Console.Write(" ");

            }
            if (num - 1 == n)
            {
                break;
            }
            Console.WriteLine();
        }

    }
}

