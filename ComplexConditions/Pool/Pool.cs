using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Pool
{
    static void Main()
    {
        int contentsOfWater = int.Parse(Console.ReadLine());
        int pipe1 = int.Parse(Console.ReadLine());
        int pipe2 = int.Parse(Console.ReadLine());
        float hour = float.Parse(Console.ReadLine());
        int overloadpoll = (pipe1 + pipe2) * (int)hour;

        if (overloadpoll <= contentsOfWater )
        {
            double pipe1WaterLoad = pipe1 * hour; //300
            double pipe2WaterLoad = pipe2 * hour; //360
            double pipe1and2Loads = pipe1WaterLoad + pipe2WaterLoad; //300liter + 360liter = 660liter pipe1 + pipe2
            double percentOfPipe1 = Math.Truncate((pipe1WaterLoad / pipe1and2Loads) * 100); //pipe1 %
            double percentOfPipe2 = Math.Truncate((pipe2WaterLoad / pipe1and2Loads) * 100); // pipe2 %
            double poolPercentToFull = Math.Truncate((pipe1and2Loads / contentsOfWater) * 100); //pool %

            Console.WriteLine("The pool is {0:f0}% full. Pipe 1: {1:f0}%. Pipe 2: {2:f0}%.", poolPercentToFull, percentOfPipe1, percentOfPipe2);
        }
        else
        {
            var overflows = ((pipe1 + pipe2)*hour) - contentsOfWater;
            Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hour , overflows);
        }
    }
}
