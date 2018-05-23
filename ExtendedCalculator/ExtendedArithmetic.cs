using System;
using System.Collections.Generic;
using System.Text;

namespace ExtendedCalculator
{
    class ExtendedArithmetic : BasicArithmetic
    {
        // Uses takes the Exponent of Num2 on Num1
        public double Power(double Num1, double Num2)
        {
            return Math.Pow(Num1, Num2);
        }

        // Takes the Square Root of a number
        public double SquareRoot(double Num1)
        {
            return Math.Sqrt(Num1);
        }

        // Takes a random number between two numbers
        public double Random(double Num1, double Num2)
        {
            Random rnd = new Random();
            int.TryParse(Num1.ToString(), out int INum1);
            int.TryParse(Num2.ToString(), out int INum2);

            return rnd.Next(INum1, INum2);
        }
    }
}
