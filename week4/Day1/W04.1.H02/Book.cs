using Newtonsoft.Json;

public class Book
{
	public string Title;
	public string Author;
	public int PublicationYear;

	public static List<Book> Books = new List<Book>();

	public Book(string strTitle, string strAuthor, int iPubYear)
	{
		Title = strTitle;
		Author = strAuthor;
		PublicationYear = iPubYear;
	}

	public static void ReadFromJSON()
	{
		try
		{
			StreamReader reader = new StreamReader("books.json");
			string JSON2String = reader.ReadToEnd();
			Book.Books = JsonConvert.DeserializeObject<List<Book>>(JSON2String)!;
			reader.Close();
			reader.Dispose();
		}
		catch (FileNotFoundException ex)
		{
			Console.WriteLine($"Missing JSON file. {ex.Message}");
		}
		catch (JsonReaderException ex)
		{
			Console.WriteLine($"Invalid JSON. {ex.Message}");
		}
	}

	public static void WriteToJSON()
	{
		try
		{
			StreamWriter writer = new StreamWriter("books.json");
			string List2JSON = JsonConvert.SerializeObject(Book.Books);
			writer.Write(List2JSON);
			writer.Close();
			writer.Dispose();
		}
		catch (FileNotFoundException ex)
		{
			Console.WriteLine($"Missing JSON file. {ex.Message}");
		}
		catch (JsonReaderException ex)
		{
			Console.WriteLine($"Invalid JSON. {ex.Message}");
		}
	}
	public static void RemoveAllBooks()
	{
		Book.Books = new List<Book>();
		WriteToJSON();
	}

	public static void AddBook(Book book) => Book.Books.Add(book);

	public static void RemoveBook(int iBookID)
	{
		Book foundBook = Book.GetBook(iBookID);
		if (foundBook != null)
		{
			Book.Books.Remove(foundBook);
			Book.WriteToJSON();
			Console.WriteLine("Book removed.");
		}
	}

	public static List<Book> GetBooks() => Book.Books;

	public static Book GetBook(int iBookID)
	{
		try
		{
			Book foundBook = Book.Books[iBookID - 1];
			return foundBook;
		}
		catch (ArgumentOutOfRangeException ex)
		{
			Console.WriteLine("Book does not exist.");
			return null;
		}
	}

	public static void SetBooks(List<Book> lBooks) => lBooks.ForEach(x => Book.AddBook(x));
}