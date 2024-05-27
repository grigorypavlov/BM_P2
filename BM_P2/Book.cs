namespace BM_P2;

public class Book : IPublication
{
    private string title;
    private string content;

    public Book(string title, string content)
    {
        this.title = title;
        this.content = content;
    }

    public string GetInformation()
    {
        if (string.IsNullOrEmpty(content))
        {
            return $"The book \"{title}\" has no content";
        }
        else
        {
            return $"Content of the book \"{title}\" is \"{content}\"";
        }
    }
}
