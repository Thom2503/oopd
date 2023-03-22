public class Library
{
	public List<Book> Books;

	public Library(List<Book> lBooks) => Books = lBooks;

	public Library() : this(new List<Book>()) {}

	public void AddBook(Book book) => this.Books.Add(book);
	public void AddBook(int iID, string strTitle) => this.Books.Add(new Book(iID, strTitle));

	public Book? FindBook(int iID)
	{
		Book foundBook = this.Books.Find(x => x.ID == iID);
		if (foundBook != null)
			return foundBook;
		return null;
	}
	public Book FindBook(string strTitle)
	{
		Book foundBook;
		try
		{
			foundBook = this.Books.Find(x => x.ID == Convert.ToInt32(strTitle));
		} catch (FormatException ex)
		{
			Console.WriteLine($"ID = {strTitle}: not a valid book ID. Input string was not in a correct format.");
			foundBook = this.Books.Find(x => x.Title == strTitle);
		}
		if (foundBook != null)
			return foundBook;
		return null;
	}

}