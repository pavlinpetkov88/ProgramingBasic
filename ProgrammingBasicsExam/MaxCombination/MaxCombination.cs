using System;

class MaxCombination
{
    static void Main()
    {

        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int maxComb = int.Parse(Console.ReadLine());

        int num1 = start;
        int num2 = start;

        for (int i = 0; i < maxComb; i++)
        {
            Console.Write("<{0}-{1}>", num1, num2);

            if (num2 <= end)
            {
                num2++;
            }

            if (num2 > end)
            {
                num1++;
                num2 = start;
            }

            if (num1 > end)
            {
                break;
            }
           
        }

       

        //int start = int.Parse(Console.ReadLine());
        //int end = int.Parse(Console.ReadLine());
        //int combinations = int.Parse(Console.ReadLine());
        //int count = end - start;
        //int endCounter = 0;

        //int a = start;
        //int b = start;


        //for (int i = 0; i <= count; i++)
        //{
        //    for (int j = 0; j <= count; j++)
        //    {
        //        if (endCounter < combinations)
        //        {
        //            Console.Write("<" + a + " " + b + ">");
        //            endCounter++;
        //        }
        //        b++;
        //    }
        //    a++;
        //    b = start;
        //}

    }
}

//var start = int.Parse(Console.ReadLine());
//var end = int.Parse(Console.ReadLine());
//var stop = int.Parse(Console.ReadLine());

//var counter = 0;

//        for (int i = start; i <= end; i++)
//        {
//            for (int j = start; j <= end; j++)
//            {
//                counter++;
//                if (counter > stop)
//                {
//                    break;
//                }
//                Console.Write("<{0}-{1}>", i, j);
//            }
//        }