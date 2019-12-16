using System.Reflection;

namespace TaskLib
{
    public class A
    {
        public string F()
        {
            var clas = GetType().Name;
            var method = MethodBase.GetCurrentMethod().Name;
            var result = clas + "." + method;
            return result;
        }
    }

    public class B : A
    {    
    }
}
