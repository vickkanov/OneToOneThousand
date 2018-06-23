using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OneToOneThousand
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strOneToNineteen = {"", "one", "two", "three", "four", 
                                         "five", "six", "seven", "eight", "nine",
                                         "ten", "eleven", "twelve", "thirteen", "fourteen",
                                         "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};

            string[] strTens = {"", "", "twenty", "thirty", "fourty", 
                                "fifty", "sixty", "seventy", "eighty", "ninety"};

            string strHundred  = "hundred",
                   strAnd      = "and",
                   strThousand = "thousand";

            int letterCountUnderTen = 0,
                letterCountTenToNineteen = 0,
                letterCountTwentyToNinetyNine = 0,
                letterCountOneToNinetyNine,
                letterCountOneToOneThousand,
                i;

            // Count letters from 1 to 9
            for (i = 1; i <= 9; ++i)
            {
                letterCountUnderTen += strOneToNineteen[i].Length;
            } // of count letters from 1 to 9

            // Count letters from 10 to 19
            for (i = 10; i <= 19; ++i)
            {
                letterCountTenToNineteen += strOneToNineteen[i].Length;
            } // of count letters from 10 to 19

            // Count letters from 20 to 99
            for (i = 2; i <= 9; ++i)
            {
                letterCountTwentyToNinetyNine += 10 * strTens[i].Length + 
                                                 letterCountUnderTen;
            } // of count letters from 20 to 99

            letterCountOneToNinetyNine = letterCountUnderTen +
                                         letterCountTenToNineteen +
                                         letterCountTwentyToNinetyNine;

            // Count letters from 1 to 999
            letterCountOneToOneThousand = letterCountOneToNinetyNine;
            for (i = 1; i <= 9; ++i)
            {
                letterCountOneToOneThousand += 100 * (strOneToNineteen[i].Length + strHundred.Length) +
                                                99 * strAnd.Length +
                                               letterCountOneToNinetyNine;
            } // of count letters from 100 to 999
            
            letterCountOneToOneThousand += strOneToNineteen[1].Length + strThousand.Length;

            // Write the result to Console
            Console.WriteLine("Count of letters from 1 - 1000 is: " + letterCountOneToOneThousand);
            Console.ReadLine();

        } // of static void Main()
    } // of class Program
} // of namespace OneToOneThousand
