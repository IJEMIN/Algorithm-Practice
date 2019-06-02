using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NinjaPractice
{
    // 룩업 연산이 빠르다 <- 특정 노드의 위치를 알아내는 연산
    // O(log(n))
    public class BinarySearch
    {
        public void Run<T>(T[] items, T findTarget)
        {
            Console.WriteLine("Items : " + string.Join(", ", items));
            Console.WriteLine("Find Target : " + findTarget);

            
      
        }

        public Node<int>[] nodes;


        public Node<int> FindNode(Node<int> root, int targetValue)
        {
            var currentNode = root;

            while (currentNode != null)
            {
                if (currentNode.Value == targetValue) return currentNode;

                currentNode = targetValue > currentNode.Value ? currentNode.Right : currentNode.Left;
            }

            return null;
        }
        
        

        public Node<int> FindNodeByRecurrence(Node<int> root, int targetValue)
        {
            if (root == null) return null;
            
            var currentNode = root;

            if (currentNode.Value == targetValue) return currentNode;

            return FindNodeByRecurrence(targetValue < currentNode.Value ? currentNode.Left : currentNode.Right, targetValue);
        }
        
        
        
        public int Search(int[] items, int target)
        {
            var min = 0;
            var max = items.Length;
            while (min <= max)
            {
                var middle = (int)Math.Floor((min + max) / 2.0);

                if (items[middle] == target)
                {
                    return middle;
                }
                else
                {
                    if (items[middle] < target)
                    {
                        min = middle;
                    }
                    else
                    {
                        max = middle;
                    }
                }
            }

            return -1;
        }
    }
}