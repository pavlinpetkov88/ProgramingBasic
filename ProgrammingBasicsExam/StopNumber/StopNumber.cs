﻿using System;

class StopNumber
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());

        for (int i = m; n <= i; i--)
        {
            if (i % 2 == 0 && i % 3 == 0)
            {
               
                if (s == i)
                {
                    break;
                }
                Console.Write(i + " ");
            }
            
        }

    }
}
