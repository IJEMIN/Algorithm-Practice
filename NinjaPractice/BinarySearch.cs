using System;
using System.Collections.Generic;

namespace NinjaPractice
{
    public class BinarySearch
    {
        public void Run()
        {
            Console.WriteLine(
                "Index of Target Value : " + Search(new int[] {1,24,523,124,1,23,45,15,616}, 23));         
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