namespace BM_P2;

public class Book
{
    public Book(string title, string author, DateTime published)
    {
        Title = title;
        Author = author;
        Published = published;
    }

    public string Title { get; }

    public string Author { get; }

    public DateTime Published { get; }
}