using System;
using System.Collections;

public class BubbleSort
{
    public void Run()
    {
        Action<int[]> bubleSort = (int[] list) =>
        {
            bool again = false;
            int limit = list.Length;

            do
            {
                again = false;

                for (var i = 0; i < limit; i++)
                {
                    var currentValue = list[i];
                    var nextValue = i + 1 < limit ? list[i + 1] : int.MaxValue;

                    if (nextValue < currentValue)
                    {
                        list[i] = nextValue;
                        list[i + 1] = currentValue;
                        again = true;
                    }
                }
            } while (again);
        };

        int[] randomList = new int[] {23, 1, 5, 16, 42, 15, 4, 16, 8};
        bubleSort(randomList);

        Console.WriteLine(string.Join(", ", randomList));
    }
}