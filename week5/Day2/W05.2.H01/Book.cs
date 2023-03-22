public class Book : Publication
{
	public string ISBN;
	public string Currency;
	public double Price;
	public string Author;

	public Book(string strISBN, string strTitle, string strAuthor, string strPublisher, List<string> lAudience)
	     : base(strTitle, strPublisher, "Book", lAudience)
	{
		ISBN = strISBN;
		Author = strAuthor;
	}

	public bool IsSuitableForChild() => base.Audience.Any(x => x.Contains("Children"));

	public void SetPrice(double dbPrice, string strCurrency)
	{
		if (dbPrice <= 0)
			return;
		this.Price = dbPrice;
		this.Currency = strCurrency;
	}

	public override string ToString() => $"{this.Author}, ISBN: {this.ISBN}, {this.Title}, {this.Pages} pages, {this.PublishedOn}, {this.Currency} {this.Price}";
}