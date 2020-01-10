using System;

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
                return Convert.ToDouble(a) / Convert.ToDouble(b);
            }
        }

        public static int ConvertToNumber(string str)
        {
            if (Int32.TryParse(str, out int j))
                return j;
            else
                throw new ArgumentException();
        }

        public static void MakeTheNumbersMatch(int a, int b, int x, int y)
        {
            while (a != x && b != y)
            {
                if (a > x)
                {
                    a--;
                }
                else
                {
                    a++;
                }

                if (b > y)
                {
                    b--;
                }
                else
                {
                    b++;
                }
            }
        }



    }
}
