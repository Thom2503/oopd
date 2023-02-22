using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		string fileContents = File.ReadAllText("MyTextFile.txt");
		Console.Write(fileContents);
	}
}