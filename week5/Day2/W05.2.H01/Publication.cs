public class Publication
{
	public const string NOT_PUBLISHED = "not published yet";

	protected List<string> Audience;

	public string Publisher;
	public string Title;
	public string PublicationType;

	private int _pages;
	public int Pages
	{
		get => _pages;
		set => _pages = value <= 0 ? 1 : value;
	}

	private DateTime? _datePublished;
	public DateTime? PublicationDate 
	{
		get => _datePublished;
		set => _datePublished = value is DateTime ? value : null;
	}

	private string? _publishedOn;
	public virtual string? PublishedOn => _publishedOn = this.PublicationDate != null  ? this.PublicationDate?.ToString("d") : NOT_PUBLISHED;

	public Publication(string strTitle, string strPublisher, string strType, List<string> lAudience)
	{
		Title = strTitle;
		Publisher = strPublisher;
		PublicationType = strType;
		Audience = lAudience;
	}

	public bool IsSuitableForAudience(string strAudience) => Audience.Any(x => x.Contains(strAudience));

	public override string ToString() => $"{this.Title}, {this.Pages} pages, {this.PublishedOn}";
}