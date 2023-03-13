namespace SW03.Test;

public class StaticVsNonStaticExample
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var bookWrittenByMarco = new Book("Marco Luthiger");
        Console.WriteLine(bookWrittenByMarco.GetBookCount());
        var bookWrittenBySimon = new Book("Simon Neidhart");
        
        Console.WriteLine(bookWrittenByMarco.Author);
        Console.WriteLine(bookWrittenBySimon.Author);
        Console.WriteLine(bookWrittenByMarco.GetBookCount());
        Console.WriteLine(bookWrittenBySimon.GetBookCount());
        Console.WriteLine($"Books created: {Book.BookCount}");
    }
}