using System;
using System.Collections.Generic;
using System.Text;

namespace ExtendedCalculator
{
    class BasicArithmetic
    {
        public double Addition(double Num1, double Num2)
        {
            // Adds two parameters together
            double Value = Num1 + Num2;

            return Value;
        }

        public double Subtract(double Num1, double Num2)
        {
            double Value = Num1 - Num2;

            return Value;
        }

        public double Multiply(double Num1, double Num2)
        {
            double Value = Num1 * Num2;

            return Value;
        }

        public double Divide(double Num1, double Num2)
        {
            double Value = Num1 / Num2;

            return Value;
        }
    }
}
