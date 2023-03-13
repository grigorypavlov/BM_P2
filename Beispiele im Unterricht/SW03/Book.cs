namespace SW03;

public class Book
{
    public static int BookCount { get; set; }
    
    public string Author { get; private set; }

    public Book(string author)
    {
        Author = author;
        BookCount++;
    }

    public string GetBookCount()
    {
        return $"{Author} Bookcount: {BookCount}";
    }
}