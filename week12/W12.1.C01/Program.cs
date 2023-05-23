using System;

public class Program
{
	public static void Main(string[] args)
	{
		int iUserNumber = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(RecursiveSum(iUserNumber));
	}

	public static int RecursiveSum(int n) => n <= 0 ? 0 : n + RecursiveSum(n - 1);
}