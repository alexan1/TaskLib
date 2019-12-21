using System.Threading;

namespace TaskLib
{
    public class Counter
    {
        private static int count = 0;

        public static int Increment()
        {            
            return Interlocked.Increment(ref count);
        }
    }
}
