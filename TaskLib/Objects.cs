using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace TaskLib
{
    public class A
    {
        public string F()
        {
            var clas = this.GetType().Name;
            var method = MethodBase.GetCurrentMethod().Name;
            var result = clas + "." + method;
            return result;
        }
    }

    public class B : A
    {    
    }
}
