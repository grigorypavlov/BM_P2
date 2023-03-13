namespace SW03;

public class BookShelf
{
    private readonly List<Book> books;
    private const int MaxBookCount = 10;

    public BookShelf()
    {
        this.books = new List<Book>();
    }

    public void Add(Book book)
    {
        if (this.books.Count >= MaxBookCount)
        {
            throw new ArgumentException("Too many books for me");
        }

        this.books.Add(book);
    }
}