using FluentAssertions;

namespace Pruefung.Tests;

public class PrivatKontoTests
{
    [Test]
    public void PrivatkontoDarfMehrereBesitzerHaben()
    {
        List<Person> personen = new List<Person>();
        personen.Add(new NatuerlichePerson("Muster", "Max", new DateTime(2000, 10, 3)));
        personen.Add(new NatuerlichePerson("Beispiel", "Hans", new DateTime(2002, 6, 23)));

        var privatKonto = new PrivatKonto(4, personen, 3);

        privatKonto.Besitzer.Should().BeEquivalentTo(personen);
    }

    [Test]
    public void PrivatkontoMussEinenBesitzerHaben()
    {
        List<Person> personen = new List<Person>();
        Action act = () => new PrivatKonto(4, personen, 5);
        act.Should().Throw<ArgumentException>().WithMessage("Privatkonto muss mindestens einen Besitzer haben!");
    }

    [Test]
    public void PrivatkontoDarfNichtFirmaGehoeren()
    {
        List<Person> personen = new List<Person>();
        var angestellte = new List<NatuerlichePerson>();
        angestellte.Add(new NatuerlichePerson("Muster", "Max", new DateTime(2002, 7, 21)));
        personen.Add(new Firma("ABC Firma AG", angestellte));
        Action act = () => new PrivatKonto(4, personen, 5);
        act.Should().Throw<ArgumentException>().WithMessage("Privatkonto muss natürlichen Personen gehören!");
    }

    [Test]
    public void BesitzerKannAlsSignaturberechtigterErfasstWerden()
    {
        List<Person> personen = new List<Person>();
        var signaturberechtigter = new NatuerlichePerson("Muster", "Max", new DateTime(2000, 10, 3));
        personen.Add(signaturberechtigter);
        personen.Add(new NatuerlichePerson("Beispiel", "Hans", new DateTime(2002, 6, 23)));

        var privatKonto = new PrivatKonto(4, personen, 3);

        var hatGeklappt = privatKonto.SetzeSignaturberechtigten(signaturberechtigter);
        hatGeklappt.Should().BeTrue();
    }

    [Test]
    public void AussenstehenderKannNichtAlsSignaturberechtigterErfasstWerden()
    {
        var aussenstehender = new NatuerlichePerson("Muster", "Max", new DateTime(2000, 10, 3));

        List<Person> personen = new List<Person>();
        personen.Add(new NatuerlichePerson("Beispiel", "Hans", new DateTime(2002, 6, 23)));
        var privatKonto = new PrivatKonto(4, personen, 3);

        var hatGeklappt = privatKonto.SetzeSignaturberechtigten(aussenstehender);
        hatGeklappt.Should().BeFalse();
    }
}