public class DocumentVisitor : IDocumentVisitor
{
	public void Visit(TextDocument textDoc)
	{
		Console.WriteLine($"Text document: {textDoc.Title}");
		Console.WriteLine($"Body: {textDoc.Body}");
	}

	public void Visit(ImageDocument imageDoc)
	{
		Console.WriteLine($"Image document: {imageDoc.Title}");
		Console.WriteLine($"File path: {imageDoc.FilePath}");
	}

	public void Visit(AudioDocument audioDoc)
	{
		Console.WriteLine($"Audio document: {audioDoc.Title}");
		Console.WriteLine($"Duration: {audioDoc.Duration} seconds");
	}
}