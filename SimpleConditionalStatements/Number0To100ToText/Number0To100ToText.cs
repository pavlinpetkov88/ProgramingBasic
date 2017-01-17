using System;
 
class Number0To100ToText
{
    static void Main()
    {
        var number = int.Parse(Console.ReadLine());

        string bigNumber = "";
        string numberToNine = "";
        string numberToNineteen = "";
        string numberToWord = "";

        if(number >= 0 && number < 100)
        {
            
            var decimalNumber = number / 10;
            var countingNumbers = number % 10;
 
            switch(countingNumbers)
            {
                case 0: numberToNine = "zero";
                    break;
                case 1: numberToNine = "one";
                    break;
                case 2: numberToNine = "two";
                    break;
                case 3: numberToNine = "three";
                    break;
                case 4: numberToNine = "four";
                    break;
                case 5:  numberToNine = "five";
                    break;
                case 6: numberToNine = "six";
                    break;
                case 7: numberToNine = "seven";
                    break;
                case 8: numberToNine = "eight";
                    break;
                case 9: numberToNine = "nine";
                    break;
                default:
                    break;
            }

            switch(decimalNumber)
            {
                case 1:
                    {
                        switch(number)
                        {
                            case 10: numberToNineteen = "ten";
                                break;
                            case 11: numberToNineteen = "eleven";
                                break;
                            case 12: numberToNineteen = "twelve";
                                break;
                            case 13: numberToNineteen = "thirteen";
                                break;
                            case 14: numberToNineteen = "fourteen";
                                break;
                            case 15: numberToNineteen = "fifteen";
                                break;
                            case 16: numberToNineteen = "sixteen";
                                break;
                            case 17: numberToNineteen = "seventeen";
                                break;
                            case 18: numberToNineteen = "eighteen";
                                break;
                            case 19: numberToNineteen = "nineteen";
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case 2: bigNumber = "twenty";
                    break;
                case 3: bigNumber = "thirty";
                    break;
                case 4: bigNumber = "fourty";
                    break;
                case 5: bigNumber = "fifty";
                    break;
                case 6: bigNumber = "sixty";
                    break;
                case 7: bigNumber = "seventy";
                    break;
                case 8: bigNumber = "eighty";
                    break;
                case 9: bigNumber = "ninety";
                    break;
                default:
                    break;
            }
 
            if(number == 0)
            {
                numberToWord = numberToNine;
            }
            else
            {
                if(decimalNumber == 1)
                {
                    numberToWord = numberToNineteen;
                }
                else
                {
                    if(number > 19)
                    {
                        switch(countingNumbers)
                        {
                            case 0: numberToWord = bigNumber;
                                break;
                            default: numberToWord = bigNumber + " " + numberToNine;
                                break;
                        }
                    }
                    else
                    {
                        if(decimalNumber == 0)
                        {
                            numberToWord = numberToNine;
                        }
                    }
 
                }
            }
            Console.WriteLine(numberToWord);
        } 
        else
        {
            if(number == 100)
            {
                Console.WriteLine("one hundred");
            }
            else
            {
                Console.WriteLine("invalid number");
            }
        }
 
    }
}
