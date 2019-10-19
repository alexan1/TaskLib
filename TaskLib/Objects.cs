using System;
using System.Collections.Generic;
using System.Text;

namespace TaskLib
{
    public class A
    {
        public virtual string F()
        {
            return "A.F";
        }
    }

    public class B : A
    {
        public override string F()
        {
            return "B.F";
        }
    }
}
