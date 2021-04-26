namespace TaskLib
{
    public static class PairElement
    {
        public static int FindIdenticalPairs(int[] a)
        {
            var ans = 0;

            var n = a.Length;
            for (var i = 0; i < n; i++)
                for (var j = i + 1; j < n; j++)

                    if (a[i] == a[j])
                        ans++;
            return ans;
        }
    }
}
