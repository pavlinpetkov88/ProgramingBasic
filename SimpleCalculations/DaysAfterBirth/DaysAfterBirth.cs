//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//class DaysAfterBirth
//{
//    static void Main(string[] args)
//    {
//        string[] format = { "dd-MM-yyyy" };
//        string dateString = Console.ReadLine();
//        DateTime parsedDate;
//        if (DateTime.TryParseExact(dateString, format, null,
//                                        DateTimeStyles.AllowWhiteSpaces |
//                                        DateTimeStyles.AdjustToUniversal,
//                                        out parsedDate))
//        {
//            parsedDate = parsedDate.AddDays(999);
//            Console.WriteLine("{0}", parsedDate.ToString("dd-MM-yyyy"));
//        }
//        else
//        {
//            Console.WriteLine("Cannot convert {0}", dateString);
//        }
//    }
//}

using System;
using System.Globalization;

class Days
{
    static void Main()
    {
        string dateString, format;
        DateTime result;
        CultureInfo provider = CultureInfo.InvariantCulture;

        // Parse date-only value with invariant culture.
        dateString = Console.ReadLine();
        format = "dd-MM-yyyy";
        try
        {
            result = DateTime.ParseExact(dateString, format, provider);
            Console.WriteLine("{0} converts to {1}.", dateString, result.ToString());
        }
        catch (FormatException)
        {
            Console.WriteLine("{0} is not in the correct format.", dateString);
        }
    }
}