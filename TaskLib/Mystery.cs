using System;
using System.Collections.Generic;
using System.Text;

namespace TaskLib
{
    public class P
    {
        public string Name;
        public P[] Acquaintances;

        public P(string name, P[] acquaintances)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or white space.", name);
            }

            this.Name = name;
            this.Acquaintances = acquaintances;
        }

        public bool Mystery(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or white space.", name);
            }


            Stack<P> myStack = new Stack<P>();
            foreach (P acquaintance in this.Acquaintances)
            {
                myStack.Push(acquaintance);
            }

            do
            {
                var person = myStack.Pop();

                if (person.Name.Equals(name))
                {
                    return true;
                }

                foreach (P acquaintance in person.Acquaintances)
                {
                    myStack.Push(acquaintance);
                }

            } while (myStack.Count >= 0);

            return false;
        }
    }
}
