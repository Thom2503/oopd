public abstract class Document
{
	private static int _id = 0;
	public int ID;
	public string Title;

	public Document(string strTitle)
	{
		Title = strTitle;
		ID = ++Document._id;
	}

	public abstract void Accept(IDocumentVisitor visitor);
}