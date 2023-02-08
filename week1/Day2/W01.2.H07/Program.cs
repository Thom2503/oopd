using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		List<double> grades = new List<double>() {6.5, 9.5, 4, 5, 4.5, 10, 7.1};

		for (int i = 0; i < grades.Count(); i++)	
		{
			double dbGrade = grades[i];
			Console.WriteLine($"Grade: {dbGrade}");
			if (dbGrade < 5.5)
			{
				string userAnswer = "";

				while (true)
				{
					if (userAnswer == "y" || userAnswer == "n")
						break;
					Console.WriteLine("Retake this course? y/n");
					userAnswer = Console.ReadLine().ToLower();
				}

				if (userAnswer == "y")
					dbGrade++;
				
				grades[i] = dbGrade;
			}
		}

		Console.WriteLine("Final grades:");
		foreach (double dbGrade in grades)
		{
			Console.WriteLine(dbGrade);
		}
	}
}