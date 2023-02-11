public class Book
{
	public int ID;
	public string Title;

	public Book(int iID, string strTitle)
	{
		ID = iID;
		Title = strTitle;
	}

	public string Info()
	{
		return $"ID = {this.ID}, Title = {this.Title}";
	}
}