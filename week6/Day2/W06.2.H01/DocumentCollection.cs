public class DocumentCollection
{
	private List<Document> _documents = new List<Document>();

	public void AddDocument(Document doc) => this._documents.Add(doc);

	public void RemoveDocument(Document doc) => this._documents.Remove(doc);

	public void DisplayDocuments()
	{
		foreach (Document doc in this._documents)
			Console.WriteLine($"{doc.ID}: {doc.Title}");
	}

	public Document? FindDocument(string strTitle) => this._documents.FirstOrDefault(x => x.Title == strTitle);
}