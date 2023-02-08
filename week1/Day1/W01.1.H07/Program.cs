using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		// 2 dictionaries voor het maken van het compas
		Dictionary<string, bool> directions = new Dictionary<string, bool>()
		{
			{"north", false}, {"east", false}, {"south", false}, {"west", false}
		};
		Dictionary<string, string> directionCompas = new Dictionary<string, string>()
		{
			{"north", "    N\n    |\n"}, {"west", "W---"}, {"east", "---E\n"}, {"south", "    |\n    S"}
		};

		// vraag voor elk deel of het erbij moet komen en zet dat in de dictionary.
		foreach (KeyValuePair<string, bool> kvp in directions)
		{
			Console.Write($"{kvp.Key}? Y/N\n>");
			string include = Console.ReadLine().ToLower();
			bool bIncludeDirection = false;
			if (include == "y" || include == "n")
			{
				bIncludeDirection = (include == "y") ? true : false;
			}
			directions[kvp.Key] = bIncludeDirection;
		}
		// maak de delen van de string die het kompas moeten worden
		string northPart = directions["north"] == true ? directionCompas["north"] : "";
		string westPart = directions["west"] == true ? directionCompas["west"] : "    ";
		string eastPart = directions["east"] == true ? directionCompas["east"] : "\n";
		string southPart = directions["south"] == true ? directionCompas["south"] : "";
		// print de compas delen
		Console.Write("Give a bearing (a number) for the direction in which you are going.\n>");
		Console.WriteLine("From here you can go:");
		Console.WriteLine($"{northPart}{westPart}|{eastPart}{southPart}\n");

		// vraag aan de gebruiker om een bearing te geven, gebruik % 360 om de rest ook te krijgen
		// bij grote getallen zoals 700 die dan 260 zou moeten geven
		int iBearing = Convert.ToInt32(Console.ReadLine()) % 360;
		string cardinalDirection = iBearing switch
		{
			> 315 => "north",
			> 45 and <= 135 => "east",
			> 135 and <= 225 => "south",
			<= 45 => "north",
			_ => "west",
		};
		string outputString = directions[cardinalDirection] == true
		                    ? $"You are going {cardinalDirection}"
							: $"You can't go {cardinalDirection}";

		Console.WriteLine(outputString);
	}
}