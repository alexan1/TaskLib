using System;
using System.Collections.Generic;

namespace TaskLib
{
    public static class Tickets
    {
        public static int Solution(int[] a)
        {
            var res = MinTicketCostHelper(a, 0);

            return Math.Min(res, 25);
        }

        private static int MinTicketCostHelper(IReadOnlyList<int> a, int index)
        {
            if (index >= a.Count)
                return 0;

            var oneDayTicketCost = 2 + MinTicketCostHelper(a, index + 1);

            var sevenDayTicketIndex = index + 1;
            while (sevenDayTicketIndex < a.Count && a[sevenDayTicketIndex] <= a[index] + 6)
                sevenDayTicketIndex++;

            var seveDayTicketCost = 7 + MinTicketCostHelper(a, sevenDayTicketIndex);

            return Math.Min(oneDayTicketCost, seveDayTicketCost);
        }
    }
}
