using System;

    class MetricConverter
    {
        static void Main()
        {

        double number = double.Parse(Console.ReadLine());
        var unitOne = Console.ReadLine();
        var unitTwo = Console.ReadLine();

        double metricUnit1 = 0.0;
        double metricUnit2 = 0.0;

        if (unitOne == "mm")
        {
            metricUnit1 = 1000;
        }
        else if (unitOne == "cm")
        {
            metricUnit1 = 100;
        }
        else if (unitOne == "m")
        {
            metricUnit1 = 1;
        }
        else if (unitOne == "mi")
        {
            metricUnit1 = 0.000621371192;
        }
        else if (unitOne == "in")
        {
            metricUnit1 = 39.3700787;
        }
        else if (unitOne == "km")
        {
            metricUnit1 = 0.001;
        }
        else if (unitOne == "ft")
        {
            metricUnit1 = 3.2808399;
        }
        else if (unitOne == "yd")
        {
            metricUnit1 = 1.0936133;
        }

        if (unitTwo == "mm")
        {
            metricUnit2 = 1000;
        }
        else if (unitTwo == "cm")
        {
            metricUnit2 = 100;
        }
        else if (unitTwo == "m")
        {
            metricUnit2 = 1;
        }
        else if (unitTwo == "mi")
        {
            metricUnit2 = 0.000621371192;
        }
        else if (unitTwo == "in")
        {
            metricUnit2 = 39.3700787;
        }
        else if (unitTwo == "km")
        {
            metricUnit2 = 0.001;
        }
        else if (unitTwo == "ft")
        {
            metricUnit2 = 3.2808399;
        }
        else if (unitTwo == "yd")
        {
            metricUnit2 = 1.0936133;
        }

        double result = (number / metricUnit1) * metricUnit2;
        Console.WriteLine(result + " {0}", unitTwo);
    }
    }
