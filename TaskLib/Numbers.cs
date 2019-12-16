using System;
using System.Collections.Generic;

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

    }
}
