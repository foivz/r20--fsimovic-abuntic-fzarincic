﻿using System;
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

        public static bool AssertStringLenght(string input, int lenght)
        {
            return input.Length >= lenght;
        }
    }
}