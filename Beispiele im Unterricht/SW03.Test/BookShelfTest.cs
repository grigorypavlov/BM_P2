namespace SW03.Test;

public class BookShelfTest
{
    [Test]
    public void ShouldNotBeAbleToAddMoreThan10Books()
    {
        var bookshelf = new BookShelf();
        for (int i = 0; i < 11; i++)
        {
            bookshelf.Add(new Book($"author{i}"));
        }
    }
}