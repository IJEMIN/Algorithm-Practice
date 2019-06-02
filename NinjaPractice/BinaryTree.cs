using System;
using System.Reflection.Metadata.Ecma335;

namespace NinjaPractice
{
    public class BinaryTree
    {
        private Node m_Root;

        public Node Root => m_Root;
        
        
        public Node Insert(int value)
        {
            return InsertByRecurrence(ref m_Root, value); 
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