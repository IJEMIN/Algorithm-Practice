namespace NinjaPractice
{
    public class Node<T>
    {
        private Node<T> left;
        private Node<T> right;

        private T value;

        public Node(Node<T> left, Node<T> right, T value)
        {
            this.left = left;
            this.right = right;
            this.value = value;
        }

        public Node<T> GetLeft()
        {
            return left;
        }

        public Node<T> GetRight()
        {
            return right;
        }

        public T GetValue()
        {
            return value;
        }
    }
}