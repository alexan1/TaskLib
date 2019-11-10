using System;
using System.Collections.Generic;
using System.Text;

namespace TaskLib
{
    public class Calk
    {        
        static int value(char c) { return (int)(c - '0'); }

        static bool isOperand(char c)
        {
            return (c >= '0' && c <= '9');

        }
        
        public static int Calc(string exp)
        {           
            if (exp.Length == 0) return -1;
                        
            int res = value(exp[0]);
                        
            for (int i = 1; i < exp.Length; i += 2)
            {                
                char opr = exp[i], opd = exp[i + 1];
                                
                if (isOperand(opd) == false) return -1;
                                
                if (opr == '+') res += value(opd);
                else if (opr == '-') res -= value(opd);
                else if (opr == '*') res *= value(opd);
                else if (opr == '/') res /= value(opd);
                                
                else return -1;
            }
            return res;
        }
    }
}
