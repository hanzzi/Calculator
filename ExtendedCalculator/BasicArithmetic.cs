using System;
using System.Collections.Generic;
using System.Text;

namespace ExtendedCalculator
{
    class BasicArithmetic
    {
        // Adds two numbers
        public double Addition(double Num1, double Num2)
        {
            return Num1 + Num2;
        }

        //Subracts two numbers
        public double Subtract(double Num1, double Num2)
        { 
            return Num1 - Num2;
        }

        // Multiplies two numbers
        public double Multiply(double Num1, double Num2)
        {
            return Num1 * Num2;
        }

        // Divides two numbers
        public double Divide(double Num1, double Num2)
        {
            return Num1 / Num2;
        }
    }
}
