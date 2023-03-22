
public class ImageDocument : Document
{
	public string FilePath;

	public ImageDocument(string strTitle, string strFilePath) : base(strTitle) => FilePath = strFilePath;

	public override void Accept(IDocumentVisitor visitor) => visitor.Visit(this);
}