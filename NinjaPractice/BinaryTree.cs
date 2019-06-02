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
            }
            else if (value > root.Value)
            {
                root.Right = InsertByRecurrence(ref root.Right, value);
            }
            else
            {
                root.Left = InsertByRecurrence(ref root.Left, value);
            }

            return root;
        }
    }
}