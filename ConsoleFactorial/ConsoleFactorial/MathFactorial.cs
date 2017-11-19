using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class MathFactorial
    {
        public static int Factorial(this int value)
        {
            return (value <= 0) ? 1 : (value * Factorial(value - 1));
        }
        public static Int64 Factorial(this Int64 value)
        {
            return (value <= 0) ? 1 : (value * Factorial(value - 1));
        }
        public static ulong Factorial(this ulong value)
        {
            return (value <= 0) ? 1 : (value * Factorial(value - 1));
        }
        public static double Factorial(this double value)
        {
            return (value <= 0) ? 1 : (value * Factorial(value - 1));
        }
    }
}
