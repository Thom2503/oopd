using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Give a year:");
		int iYear = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(PrintIsLeapYear(iYear));
	}

	public static bool IsDivisibleBy(int x, int y)
	{
		return x % y == 0;
	}

	public static bool IsLeapYear(int iYear)
	{
		if (!IsDivisibleBy(iYear, 100))
			if (IsDivisibleBy(iYear, 400) || IsDivisibleBy(iYear, 4))
				return true;
		
		return false;
	}

	public static string PrintIsLeapYear(int iYear)
	{
		return IsLeapYear(iYear) ? $"{iYear} is a leap year" : $"{iYear} is not a leap year";
	}
}