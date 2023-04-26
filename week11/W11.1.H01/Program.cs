using System;

public class Program
{
	public static void Main(string[] args)
	{
		string email = "email@gmail.com";
		(string, string, string) parts = EmailParser.ParseEmail(email);
		Console.WriteLine(parts);
	}
}