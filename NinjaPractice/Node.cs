using System;

namespace NinjaPractice
{
    public class Node
    {
        public Node(Node left, Node right, int value)
        {
            Left = left;
            Right = right;
            Value = value;
        }

        public Node Left;

        public Node Right;

        public readonly int Value;
    }
}