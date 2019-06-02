using System;

namespace NinjaPractice
{
    public class BinaryTree
    {
        public Node m_root;

        public Node Insert(int value)
        {
            return InsertByRecurrence(ref m_root, value);
            
        }
        
        private Node InsertByRecurrence(ref Node root, int value)
        {
            if (root == null)
            {
                root = new Node(null, null, value);
                return root;
            }

            return value > root.Value ? InsertByRecurrence(ref root.Right, value) : InsertByRecurrence(ref root.Left, value);
        }
    }
}