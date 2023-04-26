public static class TestResultProcessor
{
	public static ValueTuple<double, bool> GetTestResult(int minPoints, int maxPoints)
	{
		double result = (minPoints / maxPoints) * 10;
		bool didPass = result >= 5.5;
		return ValueTuple.Create(result, didPass);
	}

	public static void PrintTestResult(ValueTuple<double, bool> grade)
	{
		Console.WriteLine($"Grade: {grade.Item1}");
		Console.WriteLine(grade.Item2 == true ? "Did pass" : "Did not pass");
	}
}