namespace Buchhaltung;

public class Bankkonto
{
    private string kontonummer;
    private decimal kontostand;
    private List<Transaktion> transaktionen;

    public Bankkonto(string kontonummer, decimal anfangsKontostand)
    {
        this.kontonummer = kontonummer;
        this.kontostand = anfangsKontostand;
        this.transaktionen = new List<Transaktion>();
    }

    public decimal Kontostand
    {
        get { return kontostand; }
        private set { kontostand = value; }
    }

    public void Einzahlen(decimal betrag)
    {
        if (betrag <= 0)
        {
            throw new ArgumentException("Der Einzahlungsbetrag muss größer als Null sein.");
        }

        Kontostand += betrag;
        Transaktion transaktion = new Transaktion(DateTime.Now, betrag, "Einzahlung");
        transaktionen.Add(transaktion);
    }

    public void Auszahlen(decimal betrag)
    {
        if (betrag <= 0)
        {
            throw new ArgumentException("Der Auszahlungsbetrag muss größer als Null sein.");
        }

        if (betrag > Kontostand)
        {
            throw new ArgumentException("Der Auszahlungsbetrag ist größer als der Kontostand.");
        }

        Kontostand -= betrag;
        Transaktion transaktion = new Transaktion(DateTime.Now, -betrag, "Auszahlung");
        transaktionen.Add(transaktion);
    }

    public IReadOnlyList<Transaktion> Transaktionen
    {
        get { return transaktionen.AsReadOnly(); }
    }
}