namespace BookCollection.Tests;

[TestClass]
public class BookCollectionTest
{
    /*
        This methods runs before every test. Optionally use this to make sure every test starts with an empty state.
    */
    [TestInitialize]
    public void RemoveAllBooks()
    {
        // Remove all books
		Book.RemoveAllBooks();
    }

    [TestMethod]
    public void Add_Book()
    {
        // Assert.IsTrue: assert that the count of books equals zero
		Assert.IsTrue(Book.Books.Count() == 0);
        // Add a book
		Book.AddBook(new Book("Norwegian Wood", "Haruki Murakami", 1984));
        // Assert.IsTrue: assert that the count of books equals one
		Assert.IsTrue(Book.Books.Count() == 1);
    }

    [TestMethod]
    public void Remove_Book()
    {
        // Add a book
		Book.AddBook(new Book("The Stranger", "Albert Camus", 1942));
        // Remove the book
		Book.RemoveBook(1);
        // Assert.IsTrue: assert that the count of books equals zero
		Assert.IsTrue(Book.Books.Count() == 0);
    }

    [TestMethod]
    public void Remove_AllBooks()
    {
		Book.AddBook(new Book("The Gay Science", "Friedrich Nietzsche", 1882));
		Book.AddBook(new Book("Sanshiro", "Natsume Soseki", 1908));
		Book.AddBook(new Book("Slaughterhouse-Five", "Kurt Vonnegut", 1969));
        // Remove all books
		Book.RemoveAllBooks();
        // Assert.IsTrue: assert that the count of books equals zero
		Assert.IsTrue(Book.Books.Count() == 0);
    }

    [TestMethod]
    public void Get_Books()
    {
        // Add three books
		Book.AddBook(new Book("Lolita", "Vladimir Nabokov", 1955));
		Book.AddBook(new Book("Nausea", "Jean-Paul Sartre", 1938));
		Book.AddBook(new Book("The Conquest of Bread", "Peter Kropotkin", 1892));
        // Assert.IsTrue: assert that the count of books equals three    
		Assert.IsTrue(Book.Books.Count() == 3);
    }

    [TestMethod]
    public void Get_Book()
    {
        // Add three books
		Book.AddBook(new Book("White Nights", "Fyodor Dostoevsky", 1848));
		Book.AddBook(new Book("Wage Labour and Capital", "Karl Marx", 1847));
		Book.AddBook(new Book("Kitchen", "Banana Yoshimoto", 1988));

        // Assert.AreEqual: assert (twice) that the title of an added book matches the expected title)
		Book Wage = Book.GetBook(2);
		Assert.AreEqual(Wage.Title, "Wage Labour and Capital");
		Book Kitchen = Book.GetBook(3);
		Assert.AreEqual(Kitchen.Title, "Kitchen");

    }

    [TestMethod]
    public void Set_Books()
    {
        // Create a list with three books
		Book b1 = new Book("Breasts and Eggs", "Mieko Kawakami", 2008);
		Book b2 = new Book("Snow Country", "Yasunari Kawabata", 1948);
		Book b3 = new Book("Ways of Seeing", "John Berger", 1972);
		List<Book> lBooks = new List<Book>() {b1, b2, b3};
        // Set the books
		Book.SetBooks(lBooks);
        // Assert.IsTrue: assert that the count of books equals three    
		Assert.IsTrue(Book.Books.Count() == 3);
        // Assert.AreEqual: assert (twice) that the title of an added book matches the expected title)
		Book SnowCountry = Book.GetBook(2);
		Assert.AreEqual(SnowCountry.Title, "Snow Country");
		Book BreastsEggs = Book.GetBook(1);
		Assert.AreEqual(BreastsEggs.Title, "Breasts and Eggs");

    }
}