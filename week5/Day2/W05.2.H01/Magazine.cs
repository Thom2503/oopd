public class Magazine : Publication
{
	private string Issue;
	public override string? PublishedOn => this.PublicationDate != null ? $"Issue: {this.Issue}; published on {this.PublicationDate?.ToString("d")}"
	                                                                    : NOT_PUBLISHED;

	public Magazine(string strTitle, string strPublisher, string strIssue, List<string> lAudiences)
	         : base(strTitle, strPublisher, "Magazine", lAudiences)
	{
		Issue = strIssue;
	}
}