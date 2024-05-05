using FluentAssertions;

namespace BM_P2;

public class HumanTests
{
    [Fact]
    public void ReadBook1_WhenBookHasContent_CanBeRead()
    {
        Human human = new Human();
        var title = "Holy bible";
        var content = "In the beginning, there was ...";
        
        Book book = new Book(title, content);

        var text = human.Read(book);

        text.Should().Be("Content of the book \"Holy bible\" is \"In the beginning, there was ...\"");
    }
    
    [Theory]
    [InlineData("")]
    [InlineData(null)]
    public void ReadBook1_WhenBookHasNoContent_CanNotBeRead(string content)
    {
        Human human = new Human();
        var title = "Holy bible";
        
        Book book = new Book(title, content);

        var text = human.Read(book);

        text.Should().Be("The book \"Holy bible\" has no content");
    }
    [Fact]
    public void ReadBook2_WhenBookHasContent_CanBeRead()
    {
        Human human = new Human();
        var title = "Three body problem";
        var content = "During the Cultural Revolution, Ye Wenjie, an astrophysics graduate";
        
        Book book = new Book(title, content);

        var text = human.Read(book);

        text.Should().Be("Content of the book \"Three body problem\" is \"During the Cultural Revolution, Ye Wenjie, an astrophysics graduate\"");
    }
    
    [Theory]
    [InlineData("")]
    [InlineData(null)]
    public void ReadBook2_WhenBookHasNoContent_CanNotBeRead(string content)
    {
        Human human = new Human();
        var title = "Three body problem";
        
        Book book = new Book(title, content);

        var text = human.Read(book);

        text.Should().Be("The book \"Three body problem\" has no content");
    }
    
    [Fact]
    public void ReadMagazine1_WhenMagazineHasContent_CanBeRead()
    {
        Human human = new Human();
        var title = "Vogue";
        var content = "Paris Hilton did..";
        var edition = 2;
        
        Magazine magazine = new Magazine(title, content, edition);

        var text = human.Read(magazine);

        text.Should().Be($"Content of the magazine \"Vogue\", edition 2, is \"Paris Hilton did..\"");
    }
    
    [Theory]
    [InlineData("")]
    [InlineData(null)]
    public void ReadMagazine1_WhenMagazineHasNoContent_CanNotBeRead(string content)
    {
        Human human = new Human();
        var title = "Vogue";
        var edition = 3;
        Magazine magazine = new Magazine(title, content, edition);

        var text = human.Read(magazine);

        text.Should().Be($"The magazine \"Vogue\", edition 3, has no content");
    }
    
    [Fact]
    public void ReadMagazine2_WhenMagazineHasContent_CanBeRead()
    {
        Human human = new Human();
        var title = "C't";
        var content = "Dynamischer Polymorphismus ist ...";
        var edition = 6;
        
        Magazine magazine = new Magazine(title, content, edition);

        var text = human.Read(magazine);

        text.Should().Be($"Content of the magazine \"C't\", edition 6, is \"Dynamischer Polymorphismus ist ...\"");
    }
    
    [Theory]
    [InlineData("")]
    [InlineData(null)]
    public void ReadMagazine2_WhenMagazineHasNoContent_CanNotBeRead(string content)
    {
        Human human = new Human();
        var title = "C't";
        var edition = 9;
        Magazine magazine = new Magazine(title, content, edition);

        var text = human.Read(magazine);

        text.Should().Be($"The magazine \"C't\", edition 9, has no content");
    }
}