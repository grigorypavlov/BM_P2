using FluentAssertions;
using Library.Host;

namespace Library.Test;

public class BibliothekTests
{
    private readonly Bibliothek testee;

    public BibliothekTests()
    {
        this.testee = new Bibliothek();
    }

    [Fact]
    public void BuchSollteHinzugefuegtWerdenKoennen()
    {
        var orwell = new Buch("1984", "George Orwell", new DateTime(1949, 6, 1));
        this.testee.BuchHinzufuegen(orwell);

        this.testee.VorhandeneBuecher();
    }
}