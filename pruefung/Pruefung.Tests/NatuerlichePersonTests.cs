using FluentAssertions;

namespace Pruefung.Tests;

public class NatuerlichePersonTests
{
    [Test]
    public void ShouldBeCreated()
    {
        Action act = () => new NatuerlichePerson("Muster", "Max", new DateTime(2002, 8, 12));

        act.Should().NotThrow();
    }

    [TestCase("Muster", "Max", 2002, 8, 12)]
    [TestCase("Schmidt", "Harald", 1965, 1, 14)]
    [TestCase("Neidhart", "Simon", 1991, 7, 24)]
    public void ShouldHaveCorrectProperties(string nachname, string vorname, int year, int month, int day)
    {
        var geburtsdatum = new DateTime(year, month, day);
        var person = new NatuerlichePerson(nachname, vorname, geburtsdatum);

        person.Nachname.Should().Be(nachname);
        person.Vorname.Should().Be(vorname);
        person.Geburtsdatum.Should().Be(geburtsdatum);
    }
}