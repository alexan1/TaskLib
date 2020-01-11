using System;
using System.Collections.Generic;
using System.Text;

namespace TaskLib
{
    public static class Numbers
    {

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        public static IEnumerable<int> Get1000Primes()
        {
            var result = new List<int>();            

            for( int i = 2, count = 0; count < 1000; i++)
            {
                if (IsPrime(i))
                {
                    result.Add(i);
                    count++;
                }
            }


            return result;
        }

        public static string GenerateLowestNumber(string number, int n)
        {
            if (number == null || number.Length == 0 || n >= number.Length)
            {
                return null;
            }

            int start = 0;
            StringBuilder sb = new StringBuilder(number.Length - n);
            for (int i = 0; i < number.Length - n; i++)
            {
                int end = number.Length - n + i;
                if (start == end)
                {
                    sb.Append(number[start]);
                    continue;
                }
                String subStr = number.Substring(start, end);
                char min = FindMin(subStr);
                start = start + subStr.IndexOf(min) + 1;
                sb.Append(min);
            }
            return sb.ToString();
        }

        public static char FindMin(String subStr)
        {
            if (subStr.Length == 1)
            {
                return subStr[0];
            }
            char min = subStr[0];
            for (int i = 0; i < subStr.Length; i++)
            {
                char num = subStr[i];
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }

    }
}
