namespace NinjaPractice
{
    public class BinaryTree
    {
        private Node<int> root;

        public Node<int> Insert(int value)
        {
            var currentNode = root;

            if (currentNode == null)
            {
                currentNode = new Node<int>(null, null, value);

                return currentNode;
            }
            else
            {
                while(currentNode != null)
                {
                    currentNode = value > currentNode.Value ? currentNode.Right : currentNode.Left;
                }
                
                currentNode = new Node<int>(null, null, value);
            }

            return currentNode;
        }
        
        public Node<int> InsertByRecurrence(Node<int> searchPoint, int value)
        {
            var currentNode = searchPoint;

            if (currentNode == null)
            {
                currentNode = new Node<int>(null, null, value);

                return currentNode;
            }

            if (value > currentNode.Value)
            {
                currentNode.Right = InsertByRecurrence(currentNode.Right, value);
            }
            else
            {
                currentNode.Left = InsertByRecurrence(currentNode.Right, value);
            }

            return currentNode;
        }
    }
}