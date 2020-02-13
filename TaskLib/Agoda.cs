using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskLib
{
    public static class Agoba
    {
        //Sort a list of dates in ascending order (from past to pesent)
        public static List<string> sortDates(List<string> dates)
        {

            return dates.Select(date => DateTime.Parse(date)).ToList().OrderBy(date => date).Select(date => date.ToString()).ToList();


        }

        //Given an array of integers for example: [5, 23, 23, 66, 5, 23, 7, 0]
        //Find the two elements without a pair (one time in the array)
        //and return an array form for example: [66, 7]
        public static List<int> getFirstTwoElementsWithoutPair(List<int> list)
        {
            return list.GroupBy(i => i)
                    .Where(g => g.Count() % 2 == 1)
                    .Select(g => g.Key).ToList();
        }

        //Write a function that takes a string of words and returns then in reverse order (separated by sigle sapces).
        //Example: "agoda best apps" will return "apps best agoda"
        public static string reverseWords(string inputWords)
        {            
            var words = inputWords.Split(default(char[]), StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
             return string.Join(" ", words);
        }
    }
}
