using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public static class ValidationService
    {
        public static bool ParseNumber(string number, out int parsedNumber)
        {
            return int.TryParse(number, out parsedNumber);
        }

        public static bool ParseDoubleNumber(string number, out double parsedNumber)
        {
            return double.TryParse(number, out parsedNumber);
        }

        public static bool AssertPositive(string number)
        {
            if (!ParseNumber(number, out int parsedNumber))
            {
                return false;
            }
            else
            {
                return parsedNumber >= 0 ? true : false;
            }
        }

        public static bool AssertLargerThanZero(string number)
        {
            if (!ParseNumber(number, out int parsedNumber))
            {
                return false;
            }
            else
            {
                return parsedNumber >= 1 ? true : false;
            }
        }

        public static bool AssertStringLenght(string input, int lenght)
        {
            return input.Length >= lenght;
        }

        public static bool AssertEmail(string input)
        {
            return input.Contains("@") ? true : false;
        }

        public static bool IsNotNull(object test)
        {
            if (test != null) return true;
            else return false;
        }

        public static bool IsNotEmpty(string input)
        {
            return input != "" ? true : false;
        }
    }
}
