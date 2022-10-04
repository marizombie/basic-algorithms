using System;
					
public class Program
{
	public static void Main()
	{        
		var els = new int[] {2, 4, 5, 6, 9, 24, 25, 48, 59, 100};

		BinarySearch(els, 0);
		BinarySearch(els, -100);
		BinarySearch(els, 20);

		BinarySearch(els, 24);
		BinarySearch(els, 5);
		BinarySearch(els, 9);

		BinarySearch(els, 100);
		BinarySearch(els, 2);
	}
		
	public static int BinarySearch(int[] elements, int number)
	{
		var (left, right) = (0, elements.Length - 1);

		if (elements[left] == number) 
		{
			Console.WriteLine($"Found the number {number} at index {left}");
			return left;
		}
		else if (elements[right] == number)
		{
			Console.WriteLine($"Found the number {number} at index {right}");
			return right;
		}

		while (left < right)
		{
			var middle_index = left + (right - left);
			if (elements[middle_index] == number)
			{
				Console.WriteLine($"Found the number {number} at index {middle_index}");
				return middle_index;
			}
			else if (number < elements[middle_index])
			{
				right = middle_index - 1;
			}
			else if (number > elements[middle_index])
			{
				left = middle_index + 1;
			}
		}
		Console.WriteLine($"Number {number} not found in the array");
		return -1;
	}
}