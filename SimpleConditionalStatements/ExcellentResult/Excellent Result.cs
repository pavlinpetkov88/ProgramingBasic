using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        var grade = double.Parse(Console.ReadLine());
        if (grade >= 5.50)
        {
            Console.WriteLine("Excellent!");
        }
    }
}
