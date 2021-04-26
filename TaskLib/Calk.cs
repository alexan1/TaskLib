namespace TaskLib
{
    public class Calk
    {
        private static int Value(char c) { return c - '0'; }

        private static bool IsOperand(char c)
        {
            return (c >= '0' && c <= '9');

        }
        
        public static int Calc(string exp)
        {
            exp = exp.Replace(" ", "");
            if (exp.Length == 0) return -1;
                        
            var res = Value(exp[0]);
                        
            for (var i = 1; i < exp.Length; i += 2)
            {                
                char opr = exp[i], opd = exp[i + 1];
                                
                if (IsOperand(opd) == false) return -1;
                                
                switch (opr)
                {
                    case '+':
                        res += Value(opd);
                        break;
                    case '-':
                        res -= Value(opd);
                        break;
                    case '*':
                        res *= Value(opd);
                        break;
                    case '/':
                        res /= Value(opd);
                        break;
                    default:
                        return -1;
                }
            }
            return res;
        }
    }
}