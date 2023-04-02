using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Hello World");
		List<object> lList = new List<object>();

		lList.Add(42);
		lList.Add("Hello");
		lList.Add('A');
		lList.Add(6.9);

		foreach (object obje in lList)
			Console.WriteLine($"{obje} = {obje.GetType()}");
	}
}