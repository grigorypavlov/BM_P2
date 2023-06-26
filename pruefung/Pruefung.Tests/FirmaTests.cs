using FluentAssertions;

namespace Pruefung.Tests;

public class FirmaTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FirmaCanBeCreated()
    {
        var angestellter1 = new NatuerlichePerson("Max", "Muster", new DateTime(2000, 10, 3));
        var angestellte = new List<NatuerlichePerson>();
        angestellte.Add(angestellter1);

        Action act = () => new Firma("meineFirma", angestellte);

        act.Should().NotThrow();
    }

    [Test]
    public void FirmaHatKorrekteAttribute()
    {
        var angestellter1 = new NatuerlichePerson("Max", "Muster", new DateTime(2000, 10, 3));
        var angestellte = new List<NatuerlichePerson>();
        angestellte.Add(angestellter1);

        var firmenname = "meineFirma";
        var testee = new Firma(firmenname, angestellte);

        testee.Name.Should().Be(firmenname);
        testee.Angestellte.Should().BeEquivalentTo(angestellte);
    }
}