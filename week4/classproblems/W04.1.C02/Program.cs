using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		File.AppendAllText("MyTextFile.txt", "\nAdded Line.");
		string fileContents = File.ReadAllText("MyTextFile.txt");
		Console.Write(fileContents);
	}
}