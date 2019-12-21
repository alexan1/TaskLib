using System;
using System.Collections.Generic;
using System.Text;

namespace TaskLib
{
    public class Node
    {
        // keep these fields public
        public Node left, right;

        /// the value of this​​​​​​‌​​​‌​‌​​‌‌‌​​‌‌​​‌‌​​‌​​ node
        public int value;

        public Node Find(int v)
        {
            Node n = this;

            while (n != null)
            {
                if (v > n.value)
                    n = n.right;
                else if (v < n.value)
                    n = n.left;
                else
                    return n;
            }
            return null;
        }
    }
}
