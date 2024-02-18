namespace BM_P2;

public class Library
{
    private List<Book> _books = new List<Book>();

    public void AddBook(Book orwell)
    {
        _books.Add(orwell);
    }

    public IReadOnlyCollection<Book> Books => _books;
}