using System;
					
public class Program
{
	public static void Main()
	{        
		var a = new int[] {45, 34, 2, 67, 10, 23, -2, 22, 100,-40, 28, 4, 6, 8, 2, 102};
		PrintResult(a);
	}
		
	public static (int, int[]) BubbleSort(int[] array)
	{
		var listLen = array.Length;
		var numSwaps = 0;

		for(var i=0; i < listLen; i++)
		{
			for (var j=0; j < listLen-1; j++)
			{
				if (array[j] < array[j+1]) continue;
				(array[j], array[j+1]) = (array[j+1], array[j]);
				numSwaps += 1;
			}
		}
		return (numSwaps, array);
	}

	public static void PrintResult(int[] array)
	{
		var (num, sortedArray) = BubbleSort(array);
		Console.WriteLine($"Array is sorted in {num} swaps");
		Console.WriteLine(string.Join(" ", sortedArray));
	}
}