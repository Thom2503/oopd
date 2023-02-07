using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine("What is your age?");
		int iAge = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine($"You are {iAge}. That's old enough to program!");
		Console.WriteLine($"Last year you were {iAge - 1}");
		Console.WriteLine($"Next year you will be {iAge + 1}");
		Console.WriteLine($"At double your age you will be {iAge * 2}");
		Console.WriteLine($"Next year, double your age will be {(iAge+1) * 2}");

		Console.WriteLine($"Half your age is {(double)iAge / 2.0}");
		Console.WriteLine($"Half your age (rounded down) is {iAge / 2}");
		Console.WriteLine($"The last digit of your age is {iAge % 10}");
	}
}