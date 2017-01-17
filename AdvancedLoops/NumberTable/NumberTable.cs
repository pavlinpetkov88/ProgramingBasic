using System;

class NumberTable
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        int num = 0;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                num = row + col + 1;
                if (num > n)
                {
                    num = Math.Abs(num -= 2 * n);

                }
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
       
    }
}
