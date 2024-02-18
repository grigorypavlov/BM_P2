using FluentAssertions;

namespace BM_P2;

public class LibraryTests
{
    private readonly Library _testee = new Library();

    [Fact]
    public void BookShouldBeAddedToLibrary()
    {
        const string expectedTitle = "1984";
        const string expectedAuthor = "George Orwell";
        DateTime expectedDateTime = new(1949, 6, 1);
        var orwell = new Book(expectedTitle, expectedAuthor, expectedDateTime);

        _testee.AddBook(orwell);

        _testee.Books.Should().Contain(orwell);
        var first = _testee.Books.First();
        first.Title.Should().Be(expectedTitle);
        first.Author.Should().Be(expectedAuthor);
        first.Published.Should().Be(expectedDateTime);
    }
}