public static class TestResultProcessor
{
	public static Tuple<double, bool> GetTestResult(int minPoints, int maxPoints)
	{
		double result = (minPoints / maxPoints) * 10;
		bool didPass = result >= 5.5;
		return Tuple.Create(result, didPass);
	}

	public static void PrintTestResult(Tuple<double, bool> grade)
	{
		Console.WriteLine($"Grade: {grade.Item1}");
		Console.WriteLine(grade.Item2 == true ? "Did pass" : "Did not pass");
	}
}