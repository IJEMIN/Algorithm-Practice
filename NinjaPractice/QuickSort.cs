using System;
using System.Collections;
using System.Collections.Generic;

public class QuickSort{
    
    public void Run()
    {
        var randomList = new List<int>(new int[] {23, 1, 5, 16, 42, 15, 4, 16, 8, 3});
        var sortedList = Sort(randomList);

        Console.WriteLine(string.Join(", ", sortedList));
    }

    private List<int> Sort(List<int> list)
    {
        if (list.Count < 2) return list;

        var pivotIndex = list.Count - 1;
        var pivotValue = list[pivotIndex];
        list.RemoveAt(pivotIndex);

        var left = new List<int>();
        var right = new List<int>();

        foreach (var item in list)
        {
            if (item < pivotValue)
            {
                left.Add(item);
            }
            else
            {
                right.Add(item);
            }
        }

        var result = Sort(left);
        result.Add(pivotValue);
        result.AddRange(Sort(right));
        return result;
    }
}