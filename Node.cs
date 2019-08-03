using System;
namespace CountUnivalTree
{
    public class Node
    {
        public int Value { get; set; }
        public Node L { get; set; }
        public Node R { get; set; }

        public Node(int v)
        {
            Value = v;
        }

        public Node AddLeft(int v)
        {
            L = new Node(v);
            return L;
        }

        public Node AddRight(int v)
        {
            R = new Node(v);
            return R;
        }

        private Node() { }
    }
}
