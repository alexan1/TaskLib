namespace TaskLib
{
    public class Node
    {
        // keep these fields public
        public Node Left, Right;

        /// the value of this​​​​​​‌​​​‌​‌​​‌‌‌​​‌‌​​‌‌​​‌​​ node
        public int Value;

        public Node Find(int v)
        {
            var n = this;

            while (n != null)
            {
                if (v > n.Value)
                    n = n.Right;
                else if (v < n.Value)
                    n = n.Left;
                else
                    return n;
            }
            return null;
        }
    }
}
