using FluentAssertions;

namespace Pruefung.Tests;

public class FirmenKontoTests
{
    [Test]
    public void FirmenkontoDarfNurEinenBesitzerHaben()
    {
        List<Person> firmas = new List<Person>();
        firmas.Add(
            new Firma("MeineFirma",
                new[]
                {
                    new NatuerlichePerson("Muster", "Max", new DateTime(2000, 10, 3)),
                    new NatuerlichePerson("Beispiel", "Hans", new DateTime(2002, 6, 23))
                }.ToList()));

        var firmenKonto = new FirmenKonto(4, firmas, 5);

        firmenKonto.Besitzer.Should().BeEquivalentTo(firmas);
    }
    [Test]
    public void FirmenkontoDarfKeinNegativesStartGuthabenHaben()
    {
        List<Person> firmas = new List<Person>();
        firmas.Add(
            new Firma("MeineFirma",
                new[]
                {
                    new NatuerlichePerson("Muster", "Max", new DateTime(2000, 10, 3)),
                    new NatuerlichePerson("Beispiel", "Hans", new DateTime(2002, 6, 23))
                }.ToList()));



        Action act = () => new FirmenKonto(4, firmas, -1);
        
        act.Should().Throw<ArgumentException>().WithMessage("Guthaben darf nicht negativ sein!");
    }

    [Test]
    public void FirmenkontoDarfNichtMehrereBesitzerHaben()
    {
        List<Person> firmas = new List<Person>();
        var firma1 = new Firma("MeineFirma",
            new[]
            {
                new NatuerlichePerson("Muster", "Max", new DateTime(2000, 10, 3)),
                new NatuerlichePerson("Beispiel", "Hans", new DateTime(2002, 6, 23))
            }.ToList());
        firmas.Add(firma1);
        var firma2 = new Firma("MeineFirma",
            new[]
            {
                new NatuerlichePerson("Habicht", "Peter", new DateTime(2001, 5, 3)),
                new NatuerlichePerson("Wasser", "Herold", new DateTime(1991, 6, 23))
            }.ToList());
        firmas.Add(firma2);

        Action act = () => new FirmenKonto(4, firmas, 5);
        
        act.Should().Throw<ArgumentException>().WithMessage("Firmenkonto darf / muss nur einen Besitzer haben!");
    }

    [Test]
    public void MitarbeiterVonFirmaKannAlsSignaturBerechtigterErfasstWerden()
    {
        List<Person> firmas = new List<Person>();
        var signaturberechtigter = new NatuerlichePerson("Muster", "Max", new DateTime(2000, 10, 3));
        firmas.Add(
            new Firma("MeineFirma",
                new[]
                {
                    signaturberechtigter,
                    new NatuerlichePerson("Beispiel", "Hans", new DateTime(2002, 6, 23))
                }.ToList()));

        var firmenKonto = new FirmenKonto(4, firmas, 5);

        var hatGeklappt = firmenKonto.SetzeSignaturberechtigten(signaturberechtigter);
        hatGeklappt.Should().BeTrue();
        firmenKonto.SignaturBerechtigter.Should().Be(signaturberechtigter);
    }

    [Test]
    public void AussenstehenderKannNichtAlsSignaturBerechtigterErfasstWerden()
    {
        List<Person> firmas = new List<Person>();
        var aussenstehender = new NatuerlichePerson("Jemand", "Anderes", new DateTime(2002, 6, 23));
        firmas.Add(
            new Firma("MeineFirma",
                new[]
                {
                    new NatuerlichePerson("Muster", "Max", new DateTime(2000, 10, 3)),
                    new NatuerlichePerson("Beispiel", "Hans", new DateTime(2002, 6, 23))
                }.ToList()));

        var firmenKonto = new FirmenKonto(4, firmas, 5);

        var hatGeklappt = firmenKonto.SetzeSignaturberechtigten(aussenstehender);
        hatGeklappt.Should().BeFalse();
    }
}