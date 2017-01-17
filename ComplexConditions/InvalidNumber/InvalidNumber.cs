using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class InvalidNumber
{
    static void Main()
    {
        var number = int.Parse(Console.ReadLine()); //input.console
        while (true)
        {
            if (!(number >= 100 && number <= 200 || number == 0))
            {
                Console.WriteLine("invalid");
                break;
            }
            else
            {
                number = int.Parse(Console.ReadLine());
            }
        }
    }
}
