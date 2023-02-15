public class Card
{
	public readonly string Suit;
	public readonly string Rank;

	public Card(string strSuit, string strRank)
	{
		Suit = strSuit;
		Rank = strRank;
	}

	public string GetName()
	{
		if (this.Suit == "Joker")
			return $"{this.Rank} {this.Suit}";

		return $"{this.Rank} of {this.Suit}";
	}
}