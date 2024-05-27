namespace BM_P2;

public class Magazine : IPublication
{
    private string title;
    private string content;
    private int edition;

    public Magazine(string title, string content, int edition)
    {
        this.title = title;
        this.content = content;
        this.edition = edition;
    }

    public string GetInformation()
    {
        if (string.IsNullOrEmpty(content))
        {
            return $"The magazine \"{title}\", edition {edition}, has no content";
        }
        else
        {
            return $"Content of the magazine \"{title}\", edition {edition}, is \"{content}\"";
        }
    }
}