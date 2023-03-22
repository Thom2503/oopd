public class Book
{
	public int ID;
	public string Title;

	public Book(int iID, string strTitle)
	{
		ID = iID;
		Title = strTitle;
	}

	public Book(int iID) : this(iID, "Title unknown") {}

	public string Info() => $"ID = {this.ID}, Title = {this.Title}";
}