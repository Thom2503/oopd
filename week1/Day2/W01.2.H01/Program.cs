using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine("What is the amount to pay?");
		int iNumberToPay = Convert.ToInt32(Console.ReadLine());
		int iPayedNumber = iNumberToPay;
		bool bPayed = false;
		List<int> optionsAmount = new List<int>() {5, 10, 20, 50};

		while (bPayed == false)
		{
			Console.WriteLine($"{iPayedNumber} left to pay");
			Console.Write("Pay how much?\n1: 5\n2: 10\n3: 20\n4: 50\n>");
			int iChosenNumber = Convert.ToInt16(Console.ReadLine());
			
			if (iChosenNumber < 1 || iChosenNumber > 4)
				continue;
			
			iPayedNumber -= optionsAmount[iChosenNumber - 1];
			if (iPayedNumber <= 0)
			{
				int iAbsPayedNumber = Math.Abs(iPayedNumber);
				if (iAbsPayedNumber == 0)
				{
					Console.WriteLine($"You have paid {iNumberToPay}");
					bPayed = true;
				} else
				{

					Console.Write($"You paid {iAbsPayedNumber} too much. Give a tip? y/n\n>");
					string tipAnswer = Console.ReadLine().ToLower();
					while (true)
					{
						if (tipAnswer == "n" || tipAnswer == "y")
							break;

						Console.Write($"You paid {iAbsPayedNumber} too much. Give a tip? y/n\n>");
						tipAnswer = Console.ReadLine().ToLower();
					}
				
					if (tipAnswer == "y")
					{
						Console.WriteLine($"You have paid {iAbsPayedNumber + iNumberToPay}");
						bPayed = true;
					} else if (tipAnswer == "n")
					{
						Console.WriteLine($"You have paid {iNumberToPay}");
						bPayed = true;
					}
				}
			}
		}
	}
}