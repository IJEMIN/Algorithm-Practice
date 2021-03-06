using System;
using System.Collections;
using System.Collections.Generic;

public class MergeSort
{
    public void Run()
    {
        List<int> randomList = new List<int>(new int[] {23, 1, 5, 16, 42, 15, 4, 16, 8, 3});
        List<int> sortedList = Sort(randomList);

        Console.WriteLine(string.Join(", ", sortedList));
    }

    List<int> Sort(List<int> list)
    {
        if (list.Count <= 1) return list;

        int middlePivot = list.Count / 2;
        List<int> leftSide = list.GetRange(0, middlePivot);
        List<int> rightSide = list.GetRange(middlePivot, list.Count - middlePivot);

        return Merge(Sort(leftSide), Sort(rightSide));
    }

    List<int> Merge(List<int> left, List<int> right)
    {
        List<int> result = new List<int>();

        while (left.Count > 0 || right.Count > 0)
        {
            if (left.Count > 0 && right.Count > 0)
            {
                if (left[0] < right[0])
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }
            else if (left.Count > 0)
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }
            else
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }
        }

        return result;
    }
}