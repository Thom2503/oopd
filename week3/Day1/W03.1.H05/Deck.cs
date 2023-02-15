public class Deck
{
	public readonly List<Card> Cards = new List<Card>();
	public readonly bool AreJokersIncluded;

	public Deck(bool bAreJokersIncluded)
	{
		AreJokersIncluded = bAreJokersIncluded;
		List<string> lSuits = new List<string>(){"Diamonds", "Clubs", "Hearts", "Spades"};
		List<string> lRanks = new List<string>(){"Ace", "Jack", "Queen", "King"};
		int iCurrentRank = 0;

		foreach (string strSuit in lSuits)
		{
			for (int i = 1; i <= 13; i++)
			{
				string strRank = i.ToString();
				if (i == 1 || i == 11 || i == 12 || i == 13)
				{
					strRank = lRanks[iCurrentRank];
					iCurrentRank++;
				}

				Card newCard = new Card(strSuit, strRank);
				this.Cards.Add(newCard);
			}

			iCurrentRank = 0;
		}

		if (bAreJokersIncluded == true)
		{
			this.Cards.Add(new Card("Joker", "Red"));
			this.Cards.Add(new Card("Joker", "Black"));
		}
	}

	public void Shuffle()
	{
		Random rand = new Random();
		// ik ga dit gebruiken https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
		int iListCount = this.Cards.Count();
		while (iListCount > 1)
		{
			iListCount--;
			int j = rand.Next(iListCount);
			Card value = this.Cards[j];
			this.Cards[j] = this.Cards[iListCount];
			this.Cards[iListCount] = value;
		}
	}

	public Card? Draw()
	{
		if (this.Cards.Count() == 0)
			return null;

		Card topCard = this.Cards[0];
		this.Cards.Remove(topCard);
		return topCard;
	}
}