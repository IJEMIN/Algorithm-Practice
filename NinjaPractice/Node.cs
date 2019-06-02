using System;

namespace NinjaPractice
{
    public class Node<T> where T: IComparable
    {
        private T _value;

        public Node(Node<T> left, Node<T> right, T value)
        {
            Left = left;
            Right = right;
            _value = value;
        }

        public Node<T> Left { get; set; }

        public Node<T> Right { get; set; }

        public T Value => _value;
    }
}