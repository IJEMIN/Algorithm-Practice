using System;

namespace NinjaPractice
{
    public class BinaryTree
    {
        public Node m_root;

        public Node Insert(int value)
        {
            if (m_root != null) return InsertByRecurrence(m_root, value);
            
            m_root = new Node(null, null, value);
            return m_root;

        }
        
        private Node InsertByRecurrence(Node root, int value)
        {
            if (root == null)
            {
                root = new Node(null, null, value);
            }
            else if (value > root.Value)
            {
                root.Right = InsertByRecurrence(root.Right, value);
            }
            else
            {
                root.Left = InsertByRecurrence(root.Left, value);
            }

            return root;
        }
    }
}