public class Library
{
	public List<Book> Books = new List<Book>();
	public int MaxSize;

	public Library(int iMaxSize)
	{
		MaxSize = iMaxSize;
	}

	public bool AddBook(int iID, string strTitle)
	{
		if (this.Books.Count() >= this.MaxSize)
			return false;

		Book newBook = new Book(iID, strTitle);
		this.Books.Add(newBook);

		return true;
	}

	public Book FindBook(int iID)
	{
		foreach (Book book in this.Books)
		{
			if (book.ID == iID)
				return book;
		}
		return null;
	}

	public void ModifyBook(int iID, string strTitle)
	{
		Book foundBook = this.FindBook(iID);
		if (foundBook == null)
			return;

		int iIndex = this.Books.IndexOf(foundBook);

		foundBook.ID = iID;
		foundBook.Title = strTitle;

		this.Books[iIndex] = foundBook;
	}
}