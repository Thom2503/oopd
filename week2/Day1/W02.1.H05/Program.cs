using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		Library library = new Library(10);
		library.AddBook(1, "The Art of Computer Programming");
		Console.WriteLine(library.FindBook(1));
	}
}