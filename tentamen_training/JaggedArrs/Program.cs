using System;

public class Program
{
	public static void Main(string[] args)
	{
		int[][] array = new int[][]{
  			new int[] { 3, 4 },                // -> array[0]
  			new int[] { 1, 3, -2, 9},          // -> array[1]
  			new int[] { 3, -1, 9 },            // -> array[2]
  			new int[] { 3, -1, 9, 40, 100 }    // -> array[3]
		};
		//rowSums
		int[] rowSums = CalcRowSums(array);
		rowSums.ToList().ForEach(x => Console.WriteLine(x));
		//colSums
		int[] colSums = CalcSumCols(array);
		colSums.ToList().ForEach(x => Console.WriteLine(x));
	}

	public static int[] CalcRowSums(int[][] arr)
	{
		int maxVal = 0;
		for (int i = 0; i < arr.Length; i++)
			if (arr[i].Length > maxVal)
				maxVal = arr[i].Length;

		int[] resArr = new int[maxVal];
		for (int row = 0; row < arr.Length; row++)
		{
			int sum = 0;
			for (int col = 0; col < arr[row].Length; col++)
			{
				sum += arr[row][col];
			}
			resArr[row] = sum;
		}

		return resArr;
	}

	public static int[] CalcSumCols(int[][] arr)
	{
		int maxVal = 0;
		for (int i = 0; i < arr.Length; i++)
			if (arr[i].Length > maxVal)
				maxVal = arr[i].Length;
		int[] resArr = new int[maxVal];
		for (int i = 0; i < maxVal; i++)
		{
			int sum = 0;
			for (int j = 0; j < arr.Length; j++)
			{
				try
				{
					sum += arr[j][i];
				}
				catch (IndexOutOfRangeException ex)
				{
					sum += 0;
				}
			}
			resArr[i] = sum;
		}
		return resArr;
	}
}