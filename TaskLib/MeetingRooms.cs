using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskLib
{
    public static class MeetingRooms
    {
        //Given an array of meeting time intervals consisting of start and end times[[s1, e1],[s2, e2],...] (si<ei),
        //determine if a person could attend all meetings.
        public static bool CanAttendMeeting(int[][] intervals)
        {
            var len = intervals.Length;
            var startTime = new int[len];
            var endTime = new int[len];
            var count = 0;
            foreach (var interval in intervals)
            {
                startTime[count] = interval[0];
                endTime[count++] = interval[1];
            }
            Array.Sort(startTime);
            Array.Sort(endTime);
            for (var i = 1; i < len; i++)
            {
                if (startTime[i] < endTime[i - 1]) return false;
            }
            return true;
        }

        // Given an array of time intervals for people entering and leaving a room consisting of start and end times
        // [[s1,e1],[s2,e2],...] (si < ei). What is the maximum number of people in the room simultaneously?
        public static int MaxPeopleNumber(int[][] people)
        {
            var all = new List<int>();

            foreach (var man in people)
            {
                var rec = Enumerable.Range(man[0], man[1] - man[0]);
                all.AddRange(rec);
            }

            var result = all.GroupBy(s => s)
                .OrderByDescending(s => s.Count())
                .Select(s => s.Count()).First();

            return result;
        }
    }
}
