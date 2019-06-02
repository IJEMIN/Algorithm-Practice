using System;

namespace NinjaPractice
{
    public class Node
    {
        private int _value;

        public Node(Node left, Node right, int value)
        {
            Left = left;
            Right = right;
            _value = value;
        }

        public Node Left;

        public Node Right;

        public int Value => _value;
    }
}