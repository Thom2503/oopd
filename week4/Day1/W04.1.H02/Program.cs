namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		Book.ReadFromJSON();

		bool bQuit = false;
		List<string> questions = new List<string>()
		{
			"Enter the title of the new book:\n>",
			"Enter the author of the new book:\n>",
			"Enter the publication year of the new book:\n>"
		};

		do
		{
			if (Book.Books.Count() != 0)
			{
				Console.Write("\nBook Collection:\n");
				int iNr = 1;
				foreach (Book book in Book.Books)
				{
					Console.Write($"{iNr}. {book.Title} by {book.Author} ({book.PublicationYear})\n");
					iNr++;
				}
			}

			Console.Write("\nWhat would you like to do?\n+: add a new book\n-: remove a book\nA number: see information on this book\nq: quit\n>");
			string userInput = Console.ReadLine();
			if (userInput == "+")
			{
				List<string> lAnswers = new List<string>();
				foreach (string strQuestion in questions)
				{
					Console.Write(strQuestion);
					string bookInput = Console.ReadLine();
					lAnswers.Add(bookInput);
				}

				try
				{
					int iYear = Convert.ToInt32(lAnswers[2]);
					Book.AddBook(new Book(lAnswers[0], lAnswers[1], iYear));
					Book.WriteToJSON();
				}
				catch (FormatException ex)
				{
					Console.WriteLine("Year is not in a valid format.");
				}
			}
			else if (userInput == "-")
			{
				Console.Write("Enter the number of the book to remove:\n>");
				try
				{
					int iBookID = Convert.ToInt32(Console.ReadLine());
					Book.RemoveBook(iBookID);
				}
				catch (FormatException ex)
				{
					Console.WriteLine("Not an index.");
				}
			}
			else if (userInput == "q")
			{
				bQuit = true;
			}
			else if (userInput.All(char.IsDigit) == true)
			{
				Book foundBook = Book.GetBook(Convert.ToInt32(userInput));
				if (foundBook == null)
					continue;
				Console.WriteLine($"Title: {foundBook.Title}");
				Console.WriteLine($"Author: {foundBook.Author}");
				Console.WriteLine($"Publication Year: {foundBook.PublicationYear}");
			}
			else
			{
				Console.WriteLine("Invalid choice.");
			}
		} while (bQuit != true);
	}
}