using System.Threading;

namespace TaskLib
{
    public class Counter
    {
        private static int _count;

        public static int Increment()
        {            
            return Interlocked.Increment(ref _count);
        }
    }
}
