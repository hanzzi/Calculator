﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExtendedCalculator
{
    class ExtendedArithmetic : BasicArithmetic
    {
        public double Power(double Num1, double Num2)
        {
            double Value = System.Math.Pow(Num1, Num2);

            return Value;
        }

        public double SquareRoot(double Num1)
        {
            double Value = System.Math.Sqrt(Num1);

            return Value;
        }

        public double Random(double Num1, double Num2)
        {
            int INum1;
            int INum2;
            Random rnd = new Random();
            int.TryParse(Num1.ToString(), out INum1);
            int.TryParse(Num2.ToString(), out INum2);


            double Value = rnd.Next(INum1, INum2);

            return Value;
        }
    }
}
