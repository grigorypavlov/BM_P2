namespace SW03;

public class Book
{
    private const int MaxBookCount = 10;
    
    public string Author { get; private set; }

    public Book(string author)
    {
        Author = author;
    }

    public static int Add(int a, int b)
    {
        return a + b;
    }
}