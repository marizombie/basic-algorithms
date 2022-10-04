using System;
using System.Linq;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		var res = QuickSort(new List<int> {45, 34, 2, 67, 10, 23, 13, 21, 89, 0, -2, 22, 100,-40, 28, 4, 6, 8, 2, 102});
		Console.WriteLine(string.Join(" ", res));
	}
		
	public static List<int> QuickSort(List<int> array)
	{
		var (less, equal, greater) = (new List<int>(), new List<int>(), new List<int>());

		if (array.Count > 1)
		{
			var pivot = array[0];

			foreach (var element in array)
			{
				if (element < pivot)
					less.Add(element);
				else if (element == pivot)
					equal.Add(element);
				else if (element > pivot)
					greater.Add(element);
			}
			return QuickSort(less).Concat(equal).Concat(QuickSort(greater)).ToList();
		}
		else
		{
			return array;
		}
	}
}
