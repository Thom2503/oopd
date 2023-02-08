using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Write("Give a start and an end number\nstart number:\n>");
		int iStart = Convert.ToInt32(Console.ReadLine());
		Console.Write("end number:\n>");
		int iEnd = Convert.ToInt32(Console.ReadLine());

		for (int i = iStart; i <= iEnd; i++)
		{
			switch (i)
			{
				case int n when n % 15 == 0:
					Console.WriteLine("FizzBuzz");
					break;
				case int n when n % 5 == 0:
					Console.WriteLine("Buzz");
					break;
				case int n when n % 3 == 0:
					Console.WriteLine("Fizz");
					break;
				default:
					Console.WriteLine(i);
					break;
			}
		}
	}
}