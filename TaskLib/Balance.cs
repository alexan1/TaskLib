﻿using System;
using System.Collections.Generic;

namespace TaskLib
{
    public static class Balance
    {
        private static readonly char[] OpenParentheses = { '(', '[', '{' };
        private static readonly char[] CloseParentheses = { ')', ']', '}' };
        public static bool Check(string str)
        {
            var parentheses = new Stack<int>();

            foreach (var chr in str)
            {
                int index;

                // Check if the 'chr' is an open parenthesis, and get its index:
                if ((index = Array.IndexOf(OpenParentheses, chr)) != -1)
                {
                    parentheses.Push(index);  // Add index to stach
                }
                // Check if the 'chr' is a close parenthesis, and get its index:
                else if ((index = Array.IndexOf(CloseParentheses, chr)) != -1)
                {
                    // Return 'false' if the stack is empty or if the currently
                    // open parenthesis is not paired with the 'chr':
                    if (parentheses.Count == 0 || parentheses.Pop() != index)
                        return false;
                }
            }
            // Return 'true' if there is no open parentheses, and 'false' - otherwise:
            return parentheses.Count == 0;
        }
    }
}
