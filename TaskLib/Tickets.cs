using System;
using System.Collections.Generic;
using System.Text;

namespace TaskLib
{
    public static class Tickets
    {
        public static int Solution(int[] A)
        {
            int res = MinTicketCostHelper(A, 0);

            return Math.Min(res, 25);
        }

        private static int MinTicketCostHelper(int[] A, int index)
        {
            if (index >= A.Length)
                return 0;


            int oneDayTicketCost = 2 + MinTicketCostHelper(A, index + 1);

            int sevenDayTicketIndex = index + 1;
            while (sevenDayTicketIndex < A.Length && A[sevenDayTicketIndex] <= A[index] + 6)
                sevenDayTicketIndex++;

            int seveDayTicketCost = 7 + MinTicketCostHelper(A, sevenDayTicketIndex);

            return Math.Min(oneDayTicketCost, seveDayTicketCost);
        }
    }
}
