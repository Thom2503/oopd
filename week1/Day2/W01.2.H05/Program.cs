using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Write("We're printing a board. Give a number for the width and height:\n>");
		int iWidth = Convert.ToInt32(Console.ReadLine());

		while (true)
		{
			if (iWidth >= 2)
				break;
			Console.WriteLine("it needs to be 2 or more!\n>");
			iWidth = Convert.ToInt32(Console.ReadLine());
		}

		bool bBlackEven = true;
		for (int i = 1; i <= iWidth; i++)
		{
			for (int j = 1; j <= iWidth; j++)
			{
				string letterToWrite;
				if (bBlackEven == true)
				{
					letterToWrite = j % 2 == 0 ? "B" : "W";
				} else
				{
					letterToWrite = j % 2 == 0 ? "W" : "B";
				}
				Console.Write(letterToWrite);
			}
			bBlackEven = i % 2 == 0 ? true : false;
			Console.Write("\n");
		}
	}
}