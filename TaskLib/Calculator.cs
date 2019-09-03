using System;
using System.Collections.Generic;
using System.Text;

namespace TaskLib
{
    public static class  Calculator
    {
        public static int Add(int a, int b)
        {
            checked
            {
                return a + b;
            }
        }

        public static int Subtract(int a, int b)
        {
            checked
            {
                return a - b;
            }
        }

        public static int Mulptily(int a, int b)
        {
            checked
            {
                return a * b;
            }
        }

        public static double Divide(int a, int b)
        {
            checked
            {
                return a / b;
            }
        }


    }
}
