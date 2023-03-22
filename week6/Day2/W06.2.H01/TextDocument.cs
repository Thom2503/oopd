public class TextDocument : Document
{
	public string Body;

	public TextDocument(string strTitle, string strBody) : base(strTitle) => Body = strBody;

	public override void Accept(IDocumentVisitor visitor)
	{
		string strMoreLess = this.Body.Split("\n").Length >= 11 ? "long" : "short";
		Console.WriteLine($"Processing {strMoreLess} document...");

		visitor.Visit(this);
	}
}