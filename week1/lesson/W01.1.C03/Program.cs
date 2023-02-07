using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Write("What is the temperature in Celsius?\n>");
		double dbCelcius = Convert.ToDouble(Console.ReadLine());

		double dbFarhenheit = dbCelcius * 1.8 + 32;
		Console.WriteLine($"{dbCelcius} C = {dbFarhenheit} F");
		Console.WriteLine($"Rounded down that is {Math.Floor(dbFarhenheit)} F");
	}
}