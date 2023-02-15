public static class GameTools
{
	public static bool ReturnCount = true;

	public static string CoinFlip(int iAmount)
	{
		List<string> lResults = new List<string>();
		Random rand = new Random();
		for (int i = 0; i < iAmount; i++)
		{
			int iRandInt = rand.Next(1, 3);
			lResults.Add(iRandInt == 1 ? "Heads" : "Tails");
		}

		string strReturnString = "";
		if (GameTools.ReturnCount == true)
		{
			List<string> lHeads = lResults.Where(strResult => strResult == "Heads").ToList();
			List<string> lTails = lResults.Where(strResult => strResult == "Tails").ToList();

			strReturnString += $"Heads: {lHeads.Count()}\nTails: {lTails.Count()}";
		} else
		{
			foreach (string strResult in lResults)
			{
				strReturnString += strResult + "\n";
			}
		}

		return strReturnString;
	}

	public static string DiceRoll(int iSides, int iAmount)
	{
		if (iSides < 3)
			return "Invalid number of die sides";

		List<int> lResults = new List<int>();
		Random rand = new Random();
		for (int i = 0; i < iAmount; i++)
		{
			int iRandInt = rand.Next(1, iSides + 1);
			lResults.Add(iRandInt);
		}

		string strReturnString = "";
		if (GameTools.ReturnCount != true)
		{
			for (int i = 0; i < lResults.Count(); i++)
			{
				strReturnString += $"Roll {i + 1}: {lResults[i]}\n";
			}
		} else
		{
			List<int> lSortedResults = lResults;
			lSortedResults.Sort();
			List<int> lNumberUsed = new List<int>();
			lSortedResults.ForEach((x) => {
				if (lNumberUsed.Contains(x))
					return;
				int iXAmount = lSortedResults.Where(y => y == x).ToList().Count();
				strReturnString += $"{x} was rolled {iXAmount} times\n";
				lNumberUsed.Add(x);
			});
		}
		
		return strReturnString;
	}
}