using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToText100
{
    class NumberToText100
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number <= 19)
            {
                //Construct first number
                if (number == 0)
                {
                    Console.WriteLine("zero");
                }
                else if (number == 1)
                {
                    Console.WriteLine("one");
                }
                else if (number == 2)
                {
                    Console.WriteLine("two");
                }
            }
            else if (number >= 20 && number <= 99)
            {
                var firstDigit = number / 10;
                var secoundDigit = number % 10;
                var numberName = "";
                if (firstDigit == 2)
                {
                    numberName += "twenty";
                }
                else if (firstDigit == 3)
                {
                    numberName += "thirty";
                }
                if (secoundDigit == 1)
                {
                    numberName += "-one";
                }
                else if (secoundDigit == 2)
                {
                    numberName += "-two";
                }
                Console.WriteLine(numberName);
            }
            else if (number == 100)
            {
                Console.WriteLine("hunderd");
            }
        }
    }
}
