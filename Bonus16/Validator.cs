using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus16
{
    public static class Validator
    {
        public static bool IsValidInt(string input)
        {
            int output;

            return int.TryParse(input, out output);
        }

        public static bool IsValidString(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }

        public static bool IsValidDouble(string input)
        {
            double output;

            return double.TryParse(input, out output);
        }
    }
}
