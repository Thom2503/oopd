public static class RewardGenerator
{
	public static readonly Random Rand = new Random(0);

	public static T GetRandomElement<T>(List<T> lList) => lList[Rand.Next(0, lList.Count)];
}