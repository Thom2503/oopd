using System;

public class Program
{
	public static void Main(string[] args)
	{
		int iUserNumber = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(Factorial(iUserNumber));
	}

	public static int Factorial(int n)
	{
		if (n < 0)
			return -1;
		else if (n <= 1)
			return 1;
		else
			return n * Factorial(n - 1);
	}
	//} => n <= 0 ? 1 : n * Factorial(n - 1);
}