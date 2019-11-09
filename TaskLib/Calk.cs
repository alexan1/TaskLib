using System;
using System.Collections.Generic;
using System.Text;

namespace TaskLib
{
    class Calk
    {
        // utility function to find value of and operand  
        static int value(char c) { return (int)(c - '0'); }

        // This function evaluates simple  
        // expressions. It returns -1 if the  
        // given expression is invalid.  
        static int evaluate(string exp)
        {
            // Base Case: Given expression is empty  
            if (exp.Length == 0) return -1;

            // The first character must be 
            // an operand, find its value  
            int res = value(exp[0]);

            // Traverse the remaining characters in pairs  
            for (int i = 1; i < exp.Length; i += 2)
            {
                // The next character must be an operator, and  
                // next to next an operand  
                char opr = exp[i], opd = exp[i + 1];

                // If next to next character is not an operand  
                if (isOperand(opd) == false) return -1;

                // Update result according to the operator  
                if (opr == '+') res += value(opd);
                else if (opr == '-') res -= value(opd);
                else if (opr == '*') res *= value(opd);
                else if (opr == '/') res /= value(opd);

                // If not a valid operator  
                else return -1;
            }
            return res;
        }
}
