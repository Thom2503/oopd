using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		Die die = new Die("Green", 20);
		die.Roll();
		Console.WriteLine(die);
	}
}