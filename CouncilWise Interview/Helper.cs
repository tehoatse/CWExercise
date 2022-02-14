using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouncilWise
{
    public static class Helper
    {
        public const decimal TaxRate = 0.1m;
        public const int TaxDivisor = 11;

        public static decimal CurrencyRound(this decimal value)
        {
            return Math.Round(value, 2);
        }

        public static bool IsPalindrome(string testString)
        {
            testString = testString.ToUpper();
            for (int i = 0; i < testString.Length/2; i++)
            {
                if (testString[i] != testString[testString.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
