using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6.Classes
{
    internal static class Maths
    {
        public static double Add(double Num1 , double Num2)
        {
            return Num1 + Num2;
        }
        public static double SubStract(double Num1, double Num2)
        {
            return Num1 - Num2;
        }
        public static double Multiply(double Num1, double Num2)
        {
            return Num1 * Num2;
        }
        public static double Divide(double Num1, double Num2)
        {
            return Num2 == 0 ? -1 : Num1/Num2;
        }

    }
}
