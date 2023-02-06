﻿using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		// dictionary met de seizoenen en welke volgorde het is
		// dit is om te gebruiken om te bepalen welk seizoen het is op basis
		// van de maand
		Dictionary<int, string> seasons = new Dictionary<int, string>()
		{
			{0, "Winter"}, {1, "Spring"}, {2, "Summer"}, {3, "Autumn"}, {4, "Winter"}
		};

		Console.Write("What is the month? 1-12\n>");
		int iMonth = Convert.ToInt32(Console.ReadLine());
		Console.Write("What is the day? 1-31\n>");
		int iDay = Convert.ToInt32(Console.ReadLine());

		// bereken in welke maand het valt, omdat er 12 maanden zijn en 4 seizoenen
		// kan je elk seizoen een nummer geven. je kan dan de maand delen door 3
		// daar krijg je dan een comma getal uit maar als je daar Ceiling op
		// doet krijg je altijd 1, 2, 3, of 4. Door een bool te maken
		// om te checken of het boven of onder 21 is kan je die er af halen, dan krijg je 
		// het daadwerkelijke nummer.
		bool bIsBefore = iDay < 21;
		int iSeasonMonth = (int)Math.Ceiling((double)iMonth / 3.0);
		iSeasonMonth = iSeasonMonth - Convert.ToInt32(bIsBefore);
		Console.WriteLine($"On {iDay}-{iMonth} it is {seasons[iSeasonMonth]}");
	}
}