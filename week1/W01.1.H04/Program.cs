using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		int iPoints = 0;
		List<string> correctAnswers = new List<string>() {"C", "D", "A", "D"};

		Console.Write("Answer the following MCQs:\nWhich of the following is NOT a valid type in C#?\nA: bool\nB: int\nC: var\nD: string\n>");
		string firstAnswer = Console.ReadLine().ToUpper();
		if (firstAnswer == correctAnswers[0])
			iPoints++;

		Console.Write("What happens if you execute the following line C#?\nint x = 1.23;\nA: x will be 1.23\nB: x will be 1\nC: x will be 1.0\nD: you will get a compiler error\n>");
		string secondAnswer = Console.ReadLine().ToUpper();
		if (secondAnswer == correctAnswers[1])
			iPoints++;

		Console.Write("Consider the following line:\ndouble d = 1.23;\nWhat are TWO ways to convert variable d to an int?\nA: int i = (int)d;\nB: int i = int(d)\nC: int i = 0 + d\nD: int i = Convert.ToInt32(d)\n");
		Console.Write("Your first answer:\n>");
		string thirdAnswer = Console.ReadLine().ToUpper();
		Console.Write("Your second answer:\n>");
		string fourthAnswer = Console.ReadLine().ToUpper();
		if ((thirdAnswer == correctAnswers[2] && fourthAnswer == correctAnswers[3])
		    || (thirdAnswer == correctAnswers[3] && fourthAnswer == correctAnswers[2]))
			iPoints++;

		string extraString(int iPoints) => iPoints == 3 ? "Well done!" : ""; 
		Console.WriteLine($"Your score: {iPoints} out of 3. {extraString(iPoints)}");

	}
}