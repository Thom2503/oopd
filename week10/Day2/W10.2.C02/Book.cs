public class Book : IComparable<Book>
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

	public int CompareTo(Book other)
	{
		if (other == null)
			return 1;
		int ret = Year.CompareTo(other.Year);
		if (ret != 0)
			return ret;
		ret = Author.CompareTo(other.Author);
		if (ret != 0)
			return ret;
		return Title.CompareTo(other.Title);
	}
}