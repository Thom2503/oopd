public class DocumentFactory : IFactory<Document>
{
	public Document CreateLightTheme() => new Document("White", "Black");

	public Document CreateDarkTheme() => new Document("Black", "White");
}