using System;
using Interface;
using Abstract;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		Abstract.Knight knight = new Abstract.Knight(2, 1, true);
		Console.WriteLine(knight.ToString());
		Console.WriteLine(knight.CanMove(1, 2));

		Interface.Knight bknight = new Interface.Knight(2, 1, false);
		Console.WriteLine(bknight.ToString());
		Console.WriteLine(bknight.CanMove(1, 2));
	}
}