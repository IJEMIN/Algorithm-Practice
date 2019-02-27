using System;
using System.Collections;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		List<int> randomList = new List<int>(new int[] {23,1,5,16,42,15,4,16,8,3});	
		List<int> sortedList = QuickSort(randomList);
		
		Console.WriteLine(string.Join(", ", sortedList));
	}
	
	private static List<int> QuickSort(List<int> list) {
		if(list.Count < 2) return list;
		
		var pivotIndex = list.Count - 1;
		var pivotValue = list[pivotIndex];
		list.RemoveAt(pivotIndex);
		
		var left = new List<int>();
		var right = new List<int>();
		
		for(var i = 0; i < list.Count; i++) {
			if(list[i] < pivotValue) {
				left.Add(list[i]);	
			} else {
				right.Add(list[i]);
			}
		}
		
		List<int> result;
		result = QuickSort(left);
		result.Add(pivotValue);
		result.AddRange(QuickSort(right));
		return result;
	}
	
}