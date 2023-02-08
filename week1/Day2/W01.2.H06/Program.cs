using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Write("Give a number 2-9\n>");
		int iNumber = Convert.ToInt32(Console.ReadLine());
		if (iNumber < 2)
			iNumber = 2;
		if (iNumber > 9)
			iNumber = 9;

		string headerString = "  |";
		for (int i = 1; i <= iNumber; i++)
		{
			headerString += $"   {i}";
		}
		int iHrLength = (iNumber * 4) + 4;
		string headerHrString = "";
		for (int i = 0; i < iHrLength; i++)
		{
			headerHrString += "-";
		}
		Console.Write($"{headerString}\n{headerHrString}\n");
	
		for (int row = 1; row <= iNumber; row++)
		{
			Console.Write($"{row} |");
			for (int col = 1; col <= iNumber; col++)
			{
				int iProduct = row * col;
				Console.Write($"{iProduct,4}");
			}
			Console.Write("\n");
		}
	}
}