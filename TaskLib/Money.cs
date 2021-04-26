namespace TaskLib
{
    public static class Money
    {
        public static int CountChange(int money, int[] coins)
        {
            var ways = new int[money + 1];
            ways[0] = 1;

            foreach (var t in coins)
            {
                for (var j = t; j <= money; j++)
                {
                    ways[j] += ways[j - t];
                }
            }

            return ways[money];

        }
    }
}
