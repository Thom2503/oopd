using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		Deck deck = new Deck(true);
		//deck.Cards.ForEach((x) => Console.WriteLine(x.GetName()));
		deck.Shuffle();
		deck.Cards.ForEach((x) => Console.WriteLine(x.GetName()));
	}
}