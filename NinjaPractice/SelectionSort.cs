using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace NinjaPractice
{
    public class SelectionSort
    {
        public void Run()
        {
            var list = new int[] {23, 4, 4, 2, 8, 16, 15};

            Sort(list).ToList().ForEach(item => Console.WriteLine(item));
        }

        public int[] Sort(int[] items)
        {
            for (var i = 0; i < items.Length; i++)
            {
                var pivotIndex = i;

                for (var j = pivotIndex  + 1; j < items.Length; j++)
                {
                    if (items[j] < items[pivotIndex])
                    {
                        pivotIndex = j;
                    }
                }

                if (pivotIndex != i)
                {
                    var oldMinValue = items[i];
                    items[i] = items[pivotIndex];
                    items[pivotIndex] = oldMinValue;
                }
            }

            return items;
        }
    }
}