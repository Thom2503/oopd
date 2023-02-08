using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		Random rand = new Random(0);
		bool bPlayAgain = true;

		Console.WriteLine("Time to play Guess The Number!");
		while (bPlayAgain == true)
		{
			Console.WriteLine("Give the minimum number:");
			int iMinNumber = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Give the maximum number:");
			int iMaxNumber = Convert.ToInt32(Console.ReadLine());

			if (iMaxNumber == iMinNumber)
			{
				iMaxNumber++;
				Console.WriteLine("The minimum and maximum are equal. Incrementing the maximum by 1.");
			} else if (iMinNumber > iMaxNumber)
			{
				Console.WriteLine("The minimum is higher than the maximum. Switching values.");
				// maak een temp variable aan om te kunnen swappen tussen de variables
				int iTmpNumber = iMaxNumber;
				iMaxNumber = iMinNumber;
				iMinNumber = iTmpNumber;
			}

			int iRandomNumber = rand.Next(iMinNumber, iMaxNumber + 1);
			bool bGuessedCorrect = false;

			while (bGuessedCorrect == false)
			{
				Console.WriteLine($"Guess the number [{iMinNumber}-{iMaxNumber}]");
				int iGuessedNumber = Convert.ToInt32(Console.ReadLine());

				if (iGuessedNumber == iRandomNumber)
				{
					Console.WriteLine($"{iGuessedNumber} is correct!");
					bGuessedCorrect = true;
				} else if (iGuessedNumber > iRandomNumber)
				{
					Console.WriteLine("Lower!");
				} else
				{
					Console.WriteLine("Higher!");
				}
			}

			if (bGuessedCorrect)
			{
				Console.WriteLine("Do you wish to play another round? Y to continue");
				string userPlayAgain = Console.ReadLine().ToLower();

				if (userPlayAgain != "y")
					bPlayAgain = false;
			}
		}
		Console.WriteLine("Thank you for playing!");
	}
}