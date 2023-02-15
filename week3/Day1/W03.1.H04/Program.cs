using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine(GameTools.CoinFlip(5));
		GameTools.ReturnCount = false;
		Console.WriteLine(GameTools.CoinFlip(5));
		GameTools.ReturnCount = true;
		Console.WriteLine(GameTools.DiceRoll(6, 5));
		GameTools.ReturnCount = false;
		Console.WriteLine(GameTools.DiceRoll(6, 5));
	}
}