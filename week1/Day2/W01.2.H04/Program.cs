using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Hello, taxes!");
		double dbBalance = 0.0;
		double taxesPaid = 0.0;
		double dbInterest = 0.0;

		Console.WriteLine("How much balance to put in?");
		dbBalance = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("How much interest?");
		dbInterest = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("For how many years?");
		int iYears = Convert.ToInt32(Console.ReadLine());

		for (int i = 0; i < iYears; i++)
		{
			double dbTaxes = 0.0;
			dbBalance += ((dbBalance / 100) * dbInterest);
			if (dbBalance > 50_000 && dbBalance <= 100_000)
			{
				double dbModuloAmount = dbBalance % 50_000;
				dbTaxes += ((dbModuloAmount / 100) * 1.5);
			}
			if (dbBalance > 100_000)
			{
				double dbModuloAmount = dbBalance % 100_000;
				dbTaxes += ((dbModuloAmount / 100) * 3.0);
				dbTaxes += ((50_000 / 100) * 1.5);
			}
			taxesPaid += dbTaxes;
			dbBalance -= dbTaxes;
		}
		Console.WriteLine($"Balance after {iYears} years: {(int)dbBalance}");
		Console.WriteLine($"Amount of taxes paid: {(int)taxesPaid}");
	}
}