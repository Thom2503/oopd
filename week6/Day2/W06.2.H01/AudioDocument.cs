public class AudioDocument : Document
{
	public int Duration;

	public AudioDocument(string strTitle, int iDuration) : base(strTitle) => Duration = iDuration;

	public override void Accept(IDocumentVisitor visitor) => visitor.Visit(this);
}