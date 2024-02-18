using FluentAssertions;

namespace BM_P2;

public class LibraryTests
{
    private readonly Library _testee = new Library();

    [Fact]
    public void BookShouldBeAddedToLibrary()
    {
        var orwell = new Book("1984", "George Orwell", new DateTime(1949, 6, 1));
        _testee.AddBook(orwell);

        _testee.Books.Should().Contain(orwell);
        var first = _testee.Books.First();
        first.Title.Should().Be("1984");
        first.Author.Should().Be("George Orwell");
        first.Published.Should().Be(new DateTime(1949, 6, 1));
    }
}