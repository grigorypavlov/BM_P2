namespace Buchhaltung;

public class Transaktion
{
    public DateTime Datum { get; set; }
    public decimal Betrag { get; set; }
    public string Beschreibung { get; set; }

    public Transaktion(DateTime datum, decimal betrag, string beschreibung)
    {
        this.Datum = datum;
        this.Betrag = betrag;
        this.Beschreibung = beschreibung;
    }
}